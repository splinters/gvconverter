using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Esri.FileGDB;
using GVConverter.Properties;

namespace GVConverter.Classes
{
	public static class Domain
	{
		private static string GenerateDomainXmlDefinition(string domainName, DataTable dataTable, string domaintype)
		{
			var domainDef = new StringBuilder();

			domainDef.AppendLine("<esri:Domain xsi:type='esri:CodedValueDomain' xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' xmlns:xs='http://www.w3.org/2001/XMLSchema' xmlns:esri='http://www.esri.com/schemas/ArcGIS/10.1'>");
			domainDef.AppendLine($"<DomainName>{domainName}</DomainName>");
            switch (domaintype)
            {
                case "integer":
                    domainDef.AppendLine("<FieldType>esriFieldTypeInteger</FieldType>");
                    break;
                case "smallint":
                    domainDef.AppendLine("<FieldType>esriFieldTypeShort</FieldType>");
                    break;
                case "double precision":
                    domainDef.AppendLine("<FieldType>esriFieldTypeInteger</FieldType>");
                    break;
                case "text":
                    domainDef.AppendLine("<FieldType>esriFieldTypeString</FieldType>");
                    break;
                case "character varying":
                    domainDef.AppendLine("<FieldType>esriFieldTypeString</FieldType>");
                    break;
                case "":
                    domainDef.AppendLine("<FieldType>esriFieldTypeString</FieldType>");
                    break;
            }

            domainDef.AppendLine("<MergePolicy>esriMPTDefaultValue</MergePolicy>");
			domainDef.AppendLine("<SplitPolicy>esriSPTDefaultValue</SplitPolicy>");
			domainDef.AppendLine("<Description></Description>");
			domainDef.AppendLine("<Owner></Owner>");

			domainDef.AppendLine("<CodedValues xsi:type='esri:ArrayOfCodedValue'>");

			for (var i = 0; i < dataTable.Rows.Count; i++)
			{
				var codedValueCode = dataTable.Rows[i][1];
				var codedValueName = dataTable.Rows[i][2];

				domainDef.AppendLine($"<CodedValue xsi:type = 'esri:CodedValue'>");
				domainDef.AppendLine($"<Name>{codedValueName}</Name>");

                switch (domaintype)
                {
                    case "integer":
                        domainDef.AppendLine($"<Code xsi:type='xs:int'>{codedValueCode}</Code>");
                        break;
                    case "smallint":
                        domainDef.AppendLine($"<Code xsi:type='xs:short'>{codedValueCode}</Code>");
                        break;
                    case "double precision":
                        domainDef.AppendLine($"<Code xsi:type='xs:int'>{codedValueCode}</Code>");
                        break;
                    case "text":
                        domainDef.AppendLine($"<Code xsi:type='xs:string'>{codedValueCode}</Code>");
                        break;
                    case "character varying":
                        domainDef.AppendLine($"<Code xsi:type='xs:string'>{codedValueCode}</Code>");
                        break;
                    case "":
                        domainDef.AppendLine($"<Code xsi:type='xs:string'>{codedValueCode}</Code>");
                        break;
                }

                domainDef.AppendLine("</CodedValue>");
			}

			domainDef.AppendLine("</CodedValues>");
			domainDef.Append("</esri:Domain>");

            CallBackMy.callbackEventHandler("--------Domain Definition----------------");
            CallBackMy.callbackEventHandler(domainDef.ToString());
            CallBackMy.callbackEventHandler("-----------------------------------------");
            return domainDef.ToString();
		}

		public static void CreateArcGisDomain(string domainName, string domaintype)
		{
			try
			{
				var geodatabase = Geodatabase.Open(Settings.Default.PathToGDBFolder);

				var isDomainExist = geodatabase.Domains.Contains(domainName, StringComparer.OrdinalIgnoreCase);

				var dataTable = WorkGiscuit.ReadTable(domainName, "null");

                var domainDef = GenerateDomainXmlDefinition(domainName, dataTable, domaintype);

/*
                string domainDef = '<Domain xsi:type="esri: CodedValueDomain" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xs="http://www.w3.org/2001/XMLSchema" xmlns:esri="http://www.esri.com/schemas/ArcGIS/10.1">
                                +'< DomainName > vintst17dom </ DomainName >'
  +'< FieldType > esriFieldTypeString </ FieldType >'
  +'< MergePolicy > esriMPTDefaultValue </ MergePolicy >'
  +'< SplitPolicy > esriSPTDefaultValue </ SplitPolicy >'
  + '< Description > vintst 17 dom descr</ Description >'
     + '   < Owner >'
        + '</ Owner >'
        + '< CodedValues xsi: type = "esri:ArrayOfCodedValue" >'
        + '      < CodedValue xsi: type = "esri:CodedValue" >'
        + '     < Name > tttt11 </ Name >'
             + '< Code xsi: type = "xs:string" > t1 </ Code >'
             + '</ CodedValue >'
             + '< CodedValue xsi: type = "esri:CodedValue" >'
             + '    < Name > ttttt2 </ Name >'
             + '    < Code xsi: type = "xs:string" > t2 </ Code >'
             + '    </ CodedValue >'
             + '  </ CodedValues >'
             + '</ Domain > ';    
*/
				if (isDomainExist)
				{
					geodatabase.AlterDomain(domainDef);
				}
				else
				{
					geodatabase.CreateDomain(domainDef);
				}

				geodatabase.Close();
			}
			catch (FileGDBException ex)
			{
				MessageBox.Show($"{ex.Message} - {ex.ErrorCode}", @"Error creating domain in ArcGis",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"General exception. {ex.Message}", @"Error creating domain in ArcGis",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}