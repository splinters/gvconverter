using System;
using System.IO;

namespace GVConverter.Classes
{
	public class GenerateXMLForCreateTableArcGIS
	{
		/// <summary>
		/// </summary>
		/// <param name="typeGeometry"></param>
		/// <param name="newNameTableArcGis"></param>
		/// <returns></returns>
		public string GetXmLforCreateTable(string typeGeometry, string newNameTableArcGis, string SRID)
		{
			string newTypeGeometry = getGeometryForXML(typeGeometry);
			string featureClassDef = "";
			string pathToTableSchemaXml = "";
			if (typeGeometry.ToLower() == "point" || typeGeometry.ToLower() == "pointz" || typeGeometry.ToLower() == "pointzm")
			{
				pathToTableSchemaXml = AppDomain.CurrentDomain.BaseDirectory + 
                       ( (SRID == "2039") ? "TableSchemaXML\\FeatureDatasetGeometryPoint.xml" : "TableSchemaXML\\FeatureDatasetGeometryPoint4326.xml");
			}
			else
			{
				pathToTableSchemaXml = AppDomain.CurrentDomain.BaseDirectory +
                     ((SRID == "2039") ? "TableSchemaXML\\FeatureDatasetGeometryNotPoint.xml" : "TableSchemaXML\\FeatureDatasetGeometryNotPoint4326.xml");
			}

			using (StreamReader sr = new StreamReader(pathToTableSchemaXml))
			{
				while (sr.Peek() >= 0)
				{
					featureClassDef += sr.ReadLine() + "\n";
				}
				sr.Close();
			}
			string hasZ = getHasZ(typeGeometry);
			string hasM = getHasM(typeGeometry);

			string replacedfeatureClassDef = featureClassDef.Replace("{ChangeNameTable}", newNameTableArcGis);
			string replacedfeatureClassDef1 = replacedfeatureClassDef.Replace("{ChangeTypeGeometry}", newTypeGeometry);
			replacedfeatureClassDef1 = replacedfeatureClassDef1.Replace("{ChanheHasZ}", hasZ);
			replacedfeatureClassDef1 = replacedfeatureClassDef1.Replace("{ChanheHasM}", hasM);

            /*
            string wkt;
            if (SRID == "2039")
            {
                wkt = "<WKT> PROJCS['Israel_TM_Grid', GEOGCS['GCS_Israel', DATUM['D_Israel', SPHEROID['GRS_1980', 6378137.0, 298.257222101]], PRIMEM['Greenwich', 0.0], UNIT['Degree', 0.0174532925199433]], PROJECTION['Transverse_Mercator'], PARAMETER['False_Easting', 219529.584], PARAMETER['False_Northing', 626907.39], PARAMETER['Central_Meridian', 35.20451694444445], PARAMETER['Scale_Factor', 1.0000067], PARAMETER['Latitude_Of_Origin', 31.73439361111111], UNIT['Meter', 1.0], AUTHORITY['EPSG', 2039]] </WKT>";
                //< WKID > 2039 </ WKID >
            }
            else
            {
                wkt = "<WKT> GEOGCS['GCS_WGS_1984', DATUM['D_WGS_1984', SPHEROID['WGS_1984', 6378137.0, 298.257223563]], PRIMEM['Greenwich', 0.0], UNIT['Degree', 0.0174532925199433]] </WKT>";
                //< WKID > 4326 </ WKID >
            }
            replacedfeatureClassDef1 = replacedfeatureClassDef1.Replace("{WKT}", wkt);
            replacedfeatureClassDef1 = replacedfeatureClassDef1.Replace("{WKID}",SRID);
            */
			return replacedfeatureClassDef1;
		}

		/// <summary>
		/// </summary>
		/// <param name="typeGeometry"></param>
		/// <returns></returns>
		private string getGeometryForXML(string typeGeometry)
		{
			string retval = "";
			switch (typeGeometry.ToLower())
			{
				///////////////// Multipoint /////////////////
				case "multipoint":
					retval = "esriGeometryMultipoint";
					break;
				case "multipointz":
					retval = "esriGeometryMultipoint";
					break;
				case "multipointzm":
					retval = "esriGeometryMultipoint";
					break;
				///////////////// Point /////////////////
				case "point":
					retval = "esriGeometryPoint";
					break;
				case "pointz":
					retval = "esriGeometryPoint";
					break;
				case "pointzm":
					retval = "esriGeometryPoint";
					break;
				///////////////// Polyline /////////////////
				case "multilinestring":
					retval = "esriGeometryPolyline";
					break;
				case "multilinestringz":
					retval = "esriGeometryPolyline";
					break;
				case "multilinestringzm":
					retval = "esriGeometryPolyline";
					break;
				///////////////// Polygon /////////////////
				case "multipolygon":
					retval = "esriGeometryPolygon";
					break;
				case "multipolygonz":
					retval = "esriGeometryPolygon";
					break;
				case "multipolygonzm":
					retval = "esriGeometryPolygon";
					break;
			}

			return retval;
		}

		public string GetXmlforCreateField(string nameField, string dataType)
		{
			string defenitionField = "";
			defenitionField = genegateXmlDefinitionField(nameField, dataType);
			return defenitionField;
		}

		private string genegateXmlDefinitionField(string nameField, string dataType)
		{
			string myDataType = dataType;
			int indexSubstring = dataType.IndexOf("(");
			if (indexSubstring > 0)
			{
				myDataType = dataType.Remove(indexSubstring);
			}
			string fieldDef =
				"<esri:Field xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' xmlns:xs='http://www.w3.org/2001/XMLSchema' xmlns:esri='http://www.esri.com/schemas/ArcGIS/10.1' xsi:type='esri:Field'>";
			fieldDef += "<Name>" + nameField + "</Name>";
			fieldDef += "<Type>" + dataTypeArcGis(myDataType) + "</Type>";
			fieldDef += "<IsNullable>true</IsNullable>";
			fieldDef += "<Length>" + lengthField(myDataType) + "</Length>";
			fieldDef += "<Precision>0</Precision>";
			fieldDef += "<Scale>0</Scale>";
			fieldDef += "<AliasName>" + nameField + "</AliasName>";
			fieldDef += "<ModelName>" + nameField + "</ModelName>";
			fieldDef += "</esri:Field>";
			return fieldDef;
		}

		private string dataTypeArcGis(string dataType)
		{
			string returnDataType;

			switch (dataType.ToLower())
			{
				case "boolean":
					returnDataType = "esriFieldTypeString";
					break;
				case "integer":
					returnDataType = "esriFieldTypeInteger";
					break;
				case "numeric":
					returnDataType = "esriFieldTypeDouble";
					break;
				case "character varying":
					returnDataType = "esriFieldTypeString";
					break;
				case "double precision":
					returnDataType = "esriFieldTypeDouble";
					break;
				case "real":
					returnDataType = "esriFieldTypeDouble";
					break;
				case "date":
					returnDataType = "esriFieldTypeDate";
					break;
				default:
					returnDataType = "esriFieldTypeString";
					break;
			}

			return returnDataType;
		}

		private string lengthField(string dataType)
		{
			string length = string.Empty;
			switch (dataType.ToLower())
			{
				case "boolean":
					length = "255";
					break;
				case "integer":
					length = "4";
					break;
				case "numeric":
					length = "8";
					break;
				case "character varying":
					length = "255";
					break;
				case "double precision":
					length = "8";
					break;
				case "real":
					length = "8";
					break;
				default:
					length = "4";
					break;
			}
			return length;
		}

		private string getHasZ(string geometry)
		{
			string retval = "";
			switch (geometry.ToLower())
			{
				///////////////// Multipoint /////////////////
				case "multipoint":
					retval = "false";
					break;
				case "multipointz":
					retval = "true";
					break;
				case "multipointzm":
					retval = "true";
					break;
				///////////////// Point /////////////////
				case "point":
					retval = "false";
					break;
				case "pointz":
					retval = "true";
					break;
				case "pointzm":
					retval = "true";
					break;
				///////////////// Polyline /////////////////
				case "multilinestring":
					retval = "false";
					break;
				case "multilinestringz":
					retval = "true";
					break;
				case "multilinestringzm":
					retval = "true";
					break;
				///////////////// Polygon /////////////////
				case "multipolygon":
					retval = "false";
					break;
				case "multipolygonz":
					retval = "true";
					break;
				case "multipolygonzm":
					retval = "true";
					break;
			}
			return retval;
		}

		/// <summary>
		/// </summary>
		/// <param name="geometry"></param>
		/// <returns></returns>
		private string getHasM(string geometry)
		{
			string retval = "";
			switch (geometry.ToLower())
			{
				///////////////// Multipoint /////////////////
				case "multipoint":
					retval = "false";
					break;
				case "multipointz":
					retval = "false";
					break;
				case "multipointzm":
					retval = "true";
					break;
				///////////////// Point /////////////////
				case "point":
					retval = "false";
					break;
				case "pointz":
					retval = "false";
					break;
				case "pointzm":
					retval = "true";
					break;
				///////////////// Polyline /////////////////
				case "multilinestring":
					retval = "false";
					break;
				case "multilinestringz":
					retval = "false";
					break;
				case "multilinestringzm":
					retval = "true";
					break;
				///////////////// Polygon /////////////////
				case "multipolygon":
					retval = "false";
					break;
				case "multipolygonz":
					retval = "false";
					break;
				case "multipolygonzm":
					retval = "true";
					break;
			}
			return retval;
		}
	}
}
