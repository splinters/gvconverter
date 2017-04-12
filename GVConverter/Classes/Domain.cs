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
		private static string GenerateDomainXmlDefinition(string domainName, DataTable dataTable)
		{
			var domainDef = new StringBuilder();

			domainDef.AppendLine("<esri:Domain xsi:type='esri:CodedValueDomain' xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' xmlns:xs='http://www.w3.org/2001/XMLSchema' xmlns:esri='http://www.esri.com/schemas/ArcGIS/10.1'>");
			domainDef.AppendLine($"<DomainName>{domainName}</DomainName>");
			domainDef.AppendLine("<FieldType>esriFieldTypeString</FieldType>");
			domainDef.AppendLine("<MergePolicy>esriMPTDefaultValue</MergePolicy>");
			domainDef.AppendLine("<SplitPolicy>esriSPTDefaultValue</SplitPolicy>");
			domainDef.AppendLine("<Description></Description>");
			domainDef.AppendLine("<Owner></Owner>");

			domainDef.AppendLine("<CodedValues xsi:type='esri:ArrayOfCodedValue'>");

			for (var i = 0; i < dataTable.Rows.Count; i++)
			{
				var codedValueCode = dataTable.Rows[i][1];
				var codedValueName = dataTable.Rows[i][2];

				domainDef.AppendLine("<CodedValue xsi:type='esri:CodedValue'>");
				domainDef.AppendLine($"<Name>{codedValueName}</Name>");
				domainDef.AppendLine($"<Code xsi:type='xs:string'>{codedValueCode}</Code>");
				domainDef.AppendLine("</CodedValue>");
			}

			domainDef.AppendLine("</CodedValues>");
			domainDef.Append("</esri:Domain>");
			
			return domainDef.ToString();
		}

		public static void CreateArcGisDomain(string domainName)
		{
			try
			{
				var geodatabase = Geodatabase.Open(Settings.Default.PathToGDBFolder);

				var isDomainExist = geodatabase.Domains.Contains(domainName, StringComparer.OrdinalIgnoreCase);

				var dataTable = WorkGiscuit.ReadTable(domainName, "null");

				var domainDef = GenerateDomainXmlDefinition(domainName, dataTable);

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