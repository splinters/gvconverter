using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Esri.FileGDB;
using FieldType = Esri.FileGDB.FieldType;

/*
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Esri.FileGDB;
using GVConverter.Properties;
using Npgsql;
         */



namespace GVConverter.Classes
{
	// ReSharper disable once InconsistentNaming
	public class WorkArcGIS
	{
//		private Geodatabase geodatabase;

		/// <summary>
		/// </summary>
		/// <returns></returns>
		public List<object> GetTableList()
		{
			try
			{
				var geodatabase = Geodatabase.Open(Properties.Settings.Default.PathToGDBFolder);

				var tablesList = geodatabase.GetChildDatasets(@"\", "Feature Class").Select(ds => ds.TrimStart('\\')).ToList<object>();

				geodatabase.Close();

				return tablesList;
			}
			catch (FileGDBException)
			{
				ErrorMessage();
				return null;
			}
		}


		/// <summary>
		/// </summary>
		/// <returns></returns>
		public List<string> GetDomainList()
		{
			try
			{
				var geodatabase = Geodatabase.Open(Properties.Settings.Default.PathToGDBFolder);

				var domains = geodatabase.Domains.ToList();

				geodatabase.Close();

				return domains;
			}
			catch (FileGDBException)
			{
				ErrorMessage();
				return null;
			}
		}

		public void ErrorMessage()
		{
			MessageBox.Show(@"Incorrect Geodatabase. Perhaps Geodatabase version below 10.0 or wrong folder",
				@"Error open Geodatabase", MessageBoxButtons.OK,
				MessageBoxIcon.Error);
		}

		/// <summary>
		/// </summary>
		/// <param name="domainName"></param>
		/// <returns></returns>
		public Tuple<DataTable, string, string, string, string> GetDataForCurrentDomain(string domainName)
		{
			var geodatabase = Geodatabase.Open(Properties.Settings.Default.PathToGDBFolder);
			var dataTable = new DataTable();
			try
			{
				var domainDefinition = geodatabase.GetDomainDefinition(domainName);

				var xmlDocument = new XmlDocument();
				xmlDocument.LoadXml(domainDefinition);

				var fieldType   = xmlDocument.SelectSingleNode("//FieldType").InnerText;
				var mergePolicy = xmlDocument.SelectSingleNode("//MergePolicy").InnerText;
				var splitPolicy = xmlDocument.SelectSingleNode("//SplitPolicy").InnerText;
				var description = xmlDocument.SelectSingleNode("//Description").InnerText;

				dataTable.Columns.Clear();
                dataTable.Columns.Add("Code", typeof(string));
                dataTable.Columns.Add("Name", typeof (string));
                dataTable.Columns.Add("FieldType", typeof(string));

                foreach (XmlNode codedValueNode in xmlDocument.SelectNodes("//CodedValues/CodedValue"))
				{
					for (int i = 0; i < codedValueNode.ChildNodes.Count; i++)
					{
						if (codedValueNode.ChildNodes[i].Name == "Name")
						{
							var newRow = dataTable.NewRow();
							var codeNode = codedValueNode["Code"];
							if (codeNode != null) newRow[0] = codeNode.InnerText;
                            var nameNode = codedValueNode["Name"];
                            if (nameNode != null) newRow[1] = nameNode.InnerText;
                            newRow[2] = fieldType;
//                            newRow[3] = description;
                            dataTable.Rows.Add(newRow);
						}
					}
				}
				return Tuple.Create(dataTable, fieldType, mergePolicy, splitPolicy, description);
			}
			catch (FileGDBException)
			{
				ErrorMessage();
				return null;
			}
			finally
			{
				geodatabase.Close();
			}
		}

		/// <summary>
		/// </summary>
		/// <param name="tableName"></param>
		/// <returns></returns>
		public Tuple<DataTable, string, string, string, string, string, string> GetDataForCurrentTable(string tableName)
		{
			var geodatabase = Geodatabase.Open(Properties.Settings.Default.PathToGDBFolder);
			var dataTable = new DataTable();
			var sqlString = $"select * from {tableName}";
			var firstIteration = true;
            /*
                        Table esriTable = geodatabase.OpenTable(tableName);

                        foreach (var fieldDef in esriTable.FieldDefs)
                        {
                            dataTable.Columns.Add(fieldDef.Name, typeof (string));
                        }

                        esriTable.Close();
            */
            var rows = geodatabase.ExecuteSQL(sqlString);

            foreach (Row row in rows)
			{
				if (firstIteration)
				{
					for (int i = 0; i < row.FieldInformation.Count; i++)
					{
						if (!dataTable.Columns.Contains(row.FieldInformation.GetFieldName(i)))
						{
							dataTable.Columns.Add(row.FieldInformation.GetFieldName(i), typeof (string));
						}
					}
					break;
				}
			}

            Int32 limit10000count = 0;
            bool limit10000 = false;
            var count = rows.Count();
            if (count > 10000) {
                if (MessageBox.Show("Count records too big: " + count.ToString() + " Load only first 1000?", "Load Records",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
                {
//                    limit10000count = 0;
                    limit10000 = true;
                }
             }

			foreach (Row row in rows)
			{
                limit10000count++;
                if (limit10000 && limit10000count > 1000)
                {
                    break;
                }
				DataRow newDataRow = dataTable.NewRow();
				for (int i = 0; i < row.FieldInformation.Count; i++)
				{
					string fieldName = row.FieldInformation.GetFieldName(i);
					if (!row.IsNull(fieldName))
					{
						if (dataTable.Columns[fieldName].ColumnName == fieldName)
						{
							switch (row.FieldInformation.GetFieldType(i))
							{
								case FieldType.SmallInteger:
									newDataRow[fieldName] = row.GetShort(fieldName).ToString();
									break;
								case FieldType.Integer:
									newDataRow[fieldName] = row.GetInteger(fieldName).ToString();
									break;
								case FieldType.Single:
									newDataRow[fieldName] = row.GetFloat(fieldName).ToString();
									break;
								case FieldType.Double:
									newDataRow[fieldName] = row.GetDouble(fieldName).ToString();
									break;
								case FieldType.String:
									newDataRow[fieldName] = row.GetString(fieldName).ToString();
									break;
								case FieldType.Date:
									newDataRow[fieldName] = row.GetDate(fieldName).ToString();
									break;
								case FieldType.OID:
									newDataRow[fieldName] = row.GetOID().ToString();
									break;
								case FieldType.Geometry:
									newDataRow[fieldName] = row.GetGeometry().shapeType;   //536870963 - circle?   -1610612685 - multipolygonz?
                                    break;
								case FieldType.Blob:
									//newDataRow[fieldName] = executeSql.GetBinary();
									break;
								case FieldType.GUID:
									newDataRow[fieldName] = row.GetGUID(fieldName).ToString();
									break;
								case FieldType.GlobalID:
									newDataRow[fieldName] = row.GetGlobalID().ToString();
									break;
							}
						}
					}
				}
				dataTable.Rows.Add(newDataRow);
			}
			var table = geodatabase.OpenTable("\\"+tableName);
			var xMin = table.Extent.xMin.ToString(CultureInfo.InvariantCulture);
			var xMax = table.Extent.xMax.ToString(CultureInfo.InvariantCulture);
			var yMin = table.Extent.yMin.ToString(CultureInfo.InvariantCulture);
			var yMax = table.Extent.yMax.ToString(CultureInfo.InvariantCulture);
			var zMin = table.Extent.zMin.ToString(CultureInfo.InvariantCulture);
			var zMax = table.Extent.zMax.ToString(CultureInfo.InvariantCulture);

            var ds = table.Definition;
            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(ds);

            var spatial = xmlDocument.SelectSingleNode("//GeometryDef");
            //get spatial reference and SRID
            //                var spatial = xmlDocument.SelectSingleNode("//SpatialReference");
            var geometrytype = spatial.SelectSingleNode("//GeometryType").InnerText.ToString();
            var sSRID = spatial.SelectSingleNode("//WKID").InnerText;

            table.Dispose();
            return Tuple.Create(dataTable, xMin, xMax, yMin, yMax, zMin, count.ToString());
 //           return Tuple.Create(dataTable, xMin, xMax, yMin, yMax, zMin, zMax); // , count.ToString());
                                                                                //            return Tuple.Create(dataTable, xMin, xMax, yMin, yMax, zMin, zMax, geometrytype, SRID);
        }


        /// <summary>
        /// </summary>
        /// <param name="currentTable"></param>
        /// <returns></returns>
        public string GetTypeShapeArcGIS(string currentTable)
		{
			var geodatabase = Geodatabase.Open(Properties.Settings.Default.PathToGDBFolder);
			string str = string.Empty;
			string sqlString = "select * from " + currentTable;
			foreach (Row executeSql in geodatabase.ExecuteSQL(sqlString))
			{
				try
				{
					str = executeSql.GetGeometry().shapeType.ToString();
					int check;
					bool isNum = int.TryParse(str, out check);
					if (!isNum)
					{
						break;
					}
				}
				catch (FileGDBException e)
				{
					if (e.ErrorCode == -2147219885)
					{
						MessageBox.Show("This table not contain shape field", "Error read shape field", MessageBoxButtons.OK,
							MessageBoxIcon.Error);
					}
					else
					{
						throw;
					}
				}
			}
			return str;
		}

		/// <summary>
		/// </summary>
		/// <param name="row"></param>
		/// <returns></returns>
		public decimal GetLengthShapeValueFromRow(Row row)
		{
			decimal returnValue = 0;
			for (int i = 0; i < row.FieldInformation.Count; i++)
			{
				if (row.FieldInformation.GetFieldName(i).ToLower() == "shape_length")
				{
                    try
                    {
                        returnValue = Convert.ToDecimal(row.GetDouble(row.FieldInformation.GetFieldName(i)),
                            CultureInfo.InvariantCulture);
                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
				}
			}
			return returnValue;
		}

		/// <summary>
		/// </summary>
		/// <param name="nameTable"></param>
		/// <returns></returns>
		public string GetFieldNameAndType(string nameTable)
		{
			const string shape = @"shape";
			const string shapeLength = @"shape_length";
			const string shapeLeng = @"shape_leng";
			string sqlFileds = string.Empty;
			string filedName;
			var geodatabase = Geodatabase.Open(Properties.Settings.Default.PathToGDBFolder);
			string sqlString = "select * from " + nameTable;
			foreach (Row row in geodatabase.ExecuteSQL(sqlString))
			{
				for (int i = 0; i < row.FieldInformation.Count; i++)
				{
					filedName = row.FieldInformation.GetFieldName(i).ToLower();
					if (filedName != shape)
					{
						if (filedName != shapeLength)
						{
							if (filedName != shapeLeng)
							{
								sqlFileds = sqlFileds + row.FieldInformation.GetFieldName(i).ToLower() + " ";
								switch (row.FieldInformation.GetFieldType(i))
								{

									case FieldType.SmallInteger:
										sqlFileds = sqlFileds + "integer,";
										break;
									case FieldType.Integer:
										sqlFileds = sqlFileds + "integer,";
										break;
									case FieldType.Single:
										sqlFileds = sqlFileds + "float4,";
										break;
									case FieldType.Double:
										sqlFileds = sqlFileds + "float8,";
										break;
									case FieldType.String:
										sqlFileds = sqlFileds + "character varying,";
										break;
									case FieldType.Date:
										sqlFileds = sqlFileds + "date,";
										break;
									case FieldType.OID:
										sqlFileds = sqlFileds + "character varying,";
										break;
									case FieldType.Blob:
										break;
									case FieldType.GUID:
										sqlFileds = sqlFileds + "character varying,";
										break;
									case FieldType.GlobalID:
										sqlFileds = sqlFileds + "character varying,";
										break;
								}
							}
						}
					}
				}
				break;
			}
			return sqlFileds;
		}

		/// <summary>
		/// </summary>
		/// <param name="nameTable"></param>
		/// <returns></returns>
		public string GetFieldsName(string nameTable)
		{
			const string shape = @"shape";
			const string shapeLength = @"shape_length";
			const string shapeLeng = @"shape_leng";
			string sqlFileds = string.Empty;
			string filedName;
			var geodatabase = Geodatabase.Open(Properties.Settings.Default.PathToGDBFolder);
			string sqlString = "select * from " + nameTable;
			foreach (Row row in geodatabase.ExecuteSQL(sqlString))
			{
				for (int i = 0; i < row.FieldInformation.Count; i++)
				{
					filedName = row.FieldInformation.GetFieldName(i).ToLower();
					if (filedName != shape)
					{
						if (filedName != shapeLength)
						{
							if (filedName != shapeLeng)
							{
								sqlFileds = sqlFileds + row.FieldInformation.GetFieldName(i).ToLower() + ", ";
							}
						}
					}
				}
				break;
			}
			return sqlFileds;
		}

		/// <summary>
		/// </summary>
		/// <param name="currentRow"></param>
		/// <returns></returns>
		public static string ConvertRowValuesToSqlString(Row currentRow)
		{
			const string shape = @"shape";
			const string shapeLength = @"shape_length";
			const string shapeLeng = @"shape_leng";

			var sqlFileds = string.Empty;

			for (int i = 0; i < currentRow.FieldInformation.Count; i++)
			{
				string fieldNameToLower = currentRow.FieldInformation.GetFieldName(i).ToLower();
				string fieldName = currentRow.FieldInformation.GetFieldName(i);

				if (fieldNameToLower == shape || fieldNameToLower == shapeLength || fieldNameToLower == shapeLeng)
					continue;

				switch (currentRow.FieldInformation.GetFieldType(i))
				{
					case FieldType.SmallInteger:
						try
						{
							string value = currentRow.GetShort(fieldName).ToString(CultureInfo.InvariantCulture);
							sqlFileds = sqlFileds + "'" + value + "', ";
						}
						catch (Exception)
						{
							sqlFileds = sqlFileds + "null, ";
						}
						break;
					case FieldType.Integer:
						try
						{
							string value = currentRow.GetInteger(fieldName).ToString(CultureInfo.InvariantCulture);
							sqlFileds = sqlFileds + "'" + value + "', ";
						}
						catch (Exception)
						{
							sqlFileds = sqlFileds + "null, ";
						}
						break;
					case FieldType.Single:
						try
						{
							string value = currentRow.GetFloat(fieldName).ToString(CultureInfo.InvariantCulture);
							sqlFileds = sqlFileds + "'" + value + "', ";
						}
						catch (Exception)
						{
							sqlFileds = sqlFileds + "null, ";
						}
						break;
					case FieldType.Double:
						try
						{
							string value = currentRow.GetDouble(fieldName).ToString(CultureInfo.InvariantCulture);
							sqlFileds = sqlFileds + "'" + value + "', ";
						}
						catch (Exception)
						{
							sqlFileds = sqlFileds + "null, ";
						}
						break;
					case FieldType.String:
						try
						{
							string value = currentRow.GetString(fieldName);
							value = value.Trim();

							if (value == string.Empty)
							{
								sqlFileds = sqlFileds + "null, ";
								break;
							}
							if (!value.ToLower().Contains(@":\"))
							{
								value = value.Replace("'", "\\'");
								sqlFileds = sqlFileds + "E'" + value + "', ";
							}
							else
							{
								value = value.Replace("'", "");
								sqlFileds = sqlFileds + "'" + value + "', ";
							}
						}
						catch (Exception)
						{
							sqlFileds = sqlFileds + "null, ";
						}
						break;

					case FieldType.Date:
						try
						{
							Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
							string value = currentRow.GetDate(fieldName).ToString("MM.dd.yyyy");
							value = Convert.ToDateTime(value).ToShortDateString();
							sqlFileds = sqlFileds + "'" + value + "', ";
						}
						catch (Exception)
						{
							sqlFileds = sqlFileds + "null, ";
						}

						break;
					case FieldType.OID:
						try
						{
							string value = currentRow.GetOID().ToString(CultureInfo.InvariantCulture);
							sqlFileds = sqlFileds + "'" + value + "', ";
						}
						catch (Exception)
						{
							sqlFileds = sqlFileds + "null, ";
						}

						break;
					case FieldType.Blob:
						try
						{
							string value = currentRow.GetBinary(fieldName).ToString();
							sqlFileds = sqlFileds + value + ", ";
						}
						catch (Exception)
						{
							sqlFileds = sqlFileds + "null, ";
						}
						break;
					case FieldType.GUID:
						try
						{
							string value = currentRow.GetGUID(fieldName).ToString();
							sqlFileds = sqlFileds + "'" + value + "', ";
						}
						catch (Exception)
						{
							sqlFileds = sqlFileds + "null, ";
						}

						break;
					case FieldType.GlobalID:
						try
						{
							string value = currentRow.GetGlobalID().ToString();
							sqlFileds = sqlFileds + "'" + value + "', ";
						}
						catch (Exception)
						{
							sqlFileds = sqlFileds + "null, ";
						}
						break;
				}
			}
			return sqlFileds;
		}

		/// <summary>
		/// </summary>
		/// <param name="currentTable"></param>
		public void ClearDataCurrentTable(string currentTable)
		{
			var geodatabase = Geodatabase.Open(Properties.Settings.Default.PathToGDBFolder);
			var envelope = new Envelope();
			var table = geodatabase.OpenTable(currentTable);
			foreach (Row row in table.Search("*", "", envelope, RowInstance.Recycle))
			{
                try
                {
                    table.Delete(row);
                }
                catch (FileGDBException ex)
                {
                    if (ex.ErrorCode == -2147220947)
                    {
                        MessageBox.Show("Cannot acquire lock table " + currentTable + "  ", @"Error delete row from table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                finally
                {
                    //                   break;
                    //continue;
                }
            }
			
			table.Close();
			geodatabase.Close();
		}

		/// <summary>
		/// </summary>
		/// <param name="currentTable"></param>
		public void DeleteCurrentTable(string currentTable)
		{
			var geodatabase = Geodatabase.Open(Properties.Settings.Default.PathToGDBFolder);
            try
            {
                geodatabase.Delete(currentTable, "Feature Class");
            }
            catch (FileGDBException ex)
            {
                if (ex.ErrorCode == -2147220970)
                {
                    MessageBox.Show("Cannot acquire lock table " + currentTable + "  ", @"Error delete table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General exception. {ex.Message}", @"Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //                    MessageBox.Show("Table " + nameTable + " error! row - " + @i + ": " + @currentcellstring, "Export to gdb table", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //throw;
            }

            geodatabase.Close();
			MessageBox.Show("Table has been deleted!");
		}

		public void CreateNewTable(string typeGeometryGiscuit, string newNameTable, string SRID)
		{
			var geodatabase = Geodatabase.Open(Properties.Settings.Default.PathToGDBFolder);
			var replacedfeatureClassDef = new GenerateXMLForCreateTableArcGIS().GetXmLforCreateTable(typeGeometryGiscuit,
				newNameTable, SRID);

			try
			{
				var table = geodatabase.CreateTable(replacedfeatureClassDef, "");
				table.Close();
			}
			catch (FileGDBException e)
			{
				if (e.ErrorCode == -2147220653)
				{
					MessageBox.Show("Table " + newNameTable + " already exists", @"Error create new table", MessageBoxButtons.OK,
						MessageBoxIcon.Error);
				}
				else if (e.ErrorCode == -2147220654)
				{
					MessageBox.Show("The table name is invalid", @"Error create new table", MessageBoxButtons.OK, MessageBoxIcon.Error);
				} else
				{
                    //throw;
                    MessageBox.Show(e.Message, @"Error create new table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
			finally
			{
				geodatabase.Close();
			}
		}

		/// <summary>
		/// </summary>
		/// <param name="dataTable"></param>
		/// <param name="nameTable"></param>
		public void AddFieldToNewTable(DataTable dataTable, string nameTable)
		{
            Table table = null;
            try
            {
                var geodatabase = Geodatabase.Open(Properties.Settings.Default.PathToGDBFolder);
                table = geodatabase.OpenTable("\\" + nameTable);

            } catch (FileGDBException ex){
                MessageBox.Show($"Error. {ex.Message}", @"Get all tables error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;

            }

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                string columnName = "";
                columnName = dataTable.Rows[i][0].ToString().ToLower();
                if ((columnName != "the_geom") & (columnName != "shape_leng") & (columnName != "gviconvertmark") & (columnName != "gid") & (columnName != "objectid"))
                {
                    string defenitionField =
                        new GenerateXMLForCreateTableArcGIS().GetXmlforCreateField(dataTable.Rows[i][0].ToString(),
                            dataTable.Rows[i][1].ToString());
                    try
                    {
                        table.AddField(defenitionField);
                    }
                    catch (FileGDBException e)
                    {
                        if (e.ErrorCode == -2147219884)  //?
                            continue;
                    }
                }
            }
		}

        
		/// <summary>
		/// </summary>
		/// <param name="nameTable"></param>
//		public void AddNewItemsToTable(string nameTable) //, ref BackgroundWorker backgroundWorkerPostgisArcgis)

        public static void AddNewItemsToTable(string nameTable, bool toESPG2039, ref BackgroundWorker backgroundWorkerPostgisArcgis)
        {
            var geodatabase = Geodatabase.Open(Properties.Settings.Default.PathToGDBFolder);
			var pgGeometryType = WorkGiscuit.GetTableGeometryType(nameTable);
            CallBackMy.callbackEventHandler("GetAllRowsFromTable -->" + nameTable);
            var pgTable = WorkGiscuit.GetAllRowsFromTable(nameTable, toESPG2039);  //check OID reading
            CallBackMy.callbackEventHandler("Open geodatabase for add data....." );

            int partsNumber = 0; int pointsNumber = 0;
            var esriTable = geodatabase.OpenTable("\\" + nameTable);
            string currentcellstring;
            string pgColumnName = "";
            //FormMain.con
//            var formmain = new FormMain();

            CallBackMy.callbackEventHandler("Start add new item to table arcgis from postgres ." + nameTable +" EPSG2039 "+toESPG2039.ToString());


            /*
                        formmain.labelBackgroudConvertPostgis2Arcgis.Visible = true;
                        formmain.labelBackgroudConvertPostgis2Arcgis.Text = "";

                        formmain.ProgressPostgis2Arcgis.Visible = true;

                        formmain.ProgressPostgis2Arcgis.Minimum = 0;
                        formmain.ProgressPostgis2Arcgis.Maximum = pgTable.Rows.Count;
            */
            //            StaticVariables.TotalRowsConvertToGiscuit = pgTable.Rows.Count;
            //            StaticVariables.NewRowsAddedToGiscuit = 0;

            //  formmain.ProgressPostgis2Arcgis.Value = 0;
            //            CallBackMy.callbackEventHandlerProgress( 0, pgTable.Rows.Count);

//            StaticVariables.PostgresToArcGis.Minimum = 0;
            StaticVariables.TotalRowsConvertToArcGIS = pgTable.Rows.Count;
            StaticVariables.CurrentRowConvertToArcGIS = 0;
            //            StaticVariables.NewRowsAddedToArcGIS = 

            for (Int32 i = 0; i < pgTable.Rows.Count; i++)
            {
                currentcellstring = string.Empty;
                // backgroundworker Progressbar
                StaticVariables.CurrentRowConvertToArcGIS++;
                //CallBackMy.callbackEventHandler("Row --> " + StaticVariables.CurrentRowConvertToArcGIS.ToString());
                backgroundWorkerPostgisArcgis.ReportProgress(StaticVariables.CurrentRowConvertToArcGIS);
                if (backgroundWorkerPostgisArcgis.CancellationPending)
                {
                    break;
                }

                //тут должна быть проверка корректности геометрии
                try
                {

                    if (pgTable.Rows[i]["NumGeometries"] == DBNull.Value) 
                    {


                        for (int j = 0; j < pgTable.Columns.Count; j++)
                        {
                            var pgCell = pgTable.Rows[i][j];
                            currentcellstring = currentcellstring + pgTable.Columns[j].ColumnName + "->" + pgCell.ToString() + " |";
                        }
                        StaticVariables.ErrorGeometryCount++;
                        MessageBox.Show("Table " + nameTable + $" error geometry! row # " + @i + $" content:{currentcellstring}", "Export to gdb table", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        CallBackMy.callbackEventHandler("Error geometry!!!!!");
                        CallBackMy.callbackEventHandler(currentcellstring);  //отключить вывод каждой строки
                        
                        continue;
                    }
                    else
                    {
                        partsNumber = (int)pgTable.Rows[i]["NumGeometries"]; // geometry parts number
                    }

                    if (pgTable.Rows[i]["NumPoints"] == DBNull.Value)
                    {
                        for (int j = 0; j < pgTable.Columns.Count; j++)
                        {
                            var pgCell = pgTable.Rows[i][j];
                            currentcellstring = currentcellstring + pgTable.Columns[j].ColumnName + "->" + pgCell.ToString() + " |";
                        }
                        StaticVariables.ErrorGeometryCount++;
                        //MessageBox.Show("Table " + nameTable + $" error geometry! row - " + @i , "Export to gdb table", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        CallBackMy.callbackEventHandler("Error geometry!!!!!");
                        CallBackMy.callbackEventHandler(currentcellstring);
                        continue;
                    }
                    else
                    {
                        pointsNumber = (int)pgTable.Rows[i]["NumPoints"];
                    }

                         // total point amount in geometry

				var newEsriRow = esriTable.CreateRowObject();
				for (int j = 0; j < pgTable.Columns.Count; j++)
				{
					pgColumnName = pgTable.Columns[j].ColumnName;
					if (pgColumnName == "shape_leng")
						pgColumnName = "shape_length";
					var pgColumnType = pgTable.Columns[j].DataType.ToString();
					var pgCell = pgTable.Rows[i][j];
					if (pgColumnName != "geomtrey")
					{
						if ((pgColumnName != "numgeometries") & (pgColumnName != "numpoints") & (pgColumnName != "gviconvertmark") & (pgColumnName != "objectid"))
                            {
                               currentcellstring = currentcellstring + pgColumnName + "->" + pgCell.ToString() + " |";
//                               formmain.labelBackgroudConvertPostgis2Arcgis.Text = currentcellstring;
                               newEsriRow = SetValueToCell(newEsriRow, pgColumnName, pgColumnType, pgCell);
						}
					}
					else
					{
						switch (pgGeometryType.ToLower())
						{
							///////////////// Multipoint /////////////////
							case "multipoint":
								newEsriRow = ConvertGeometryGiscuitToArcGIS.GetGeometryMultipoint(newEsriRow, pgCell, pointsNumber);
								break;
							case "multipointz":
								newEsriRow = ConvertGeometryGiscuitToArcGIS.GetGeometryMultipointZ(newEsriRow, pgCell, pointsNumber);
								break;
							case "multipointzm":
								newEsriRow = ConvertGeometryGiscuitToArcGIS.GetGeometryMultipointZM(newEsriRow, pgCell, pointsNumber);
								break;
							///////////////// Point /////////////////
							case "point":
								newEsriRow = ConvertGeometryGiscuitToArcGIS.GetGeometryPoint(newEsriRow, pgCell);
								break;
							case "pointz":
								newEsriRow = ConvertGeometryGiscuitToArcGIS.GetGeometryPointZ(newEsriRow, pgCell);
								break;
							case "pointzm":
								newEsriRow = ConvertGeometryGiscuitToArcGIS.GetGeometryPointZM(newEsriRow, pgCell);
								break;
							///////////////// Polyline /////////////////
							case "multilinestring":
								newEsriRow = ConvertGeometryGiscuitToArcGIS.GetGeometryPolynie(newEsriRow, pgCell, partsNumber, pointsNumber);
								break;
							case "multilinestringz":
								newEsriRow = ConvertGeometryGiscuitToArcGIS.GetGeometryPolynieZ(newEsriRow, pgCell, partsNumber, pointsNumber);
								break;
							case "multilinestringzm":
								newEsriRow = ConvertGeometryGiscuitToArcGIS.GetGeometryPolynieZM(newEsriRow, pgCell, partsNumber, pointsNumber);
								break;
							///////////////// Polygon /////////////////
							case "multipolygon":
								newEsriRow = ConvertGeometryGiscuitToArcGIS.GetGeometryMultipolygon(newEsriRow, pgCell, partsNumber, pointsNumber);
								break;
							case "multipolygonz":
								newEsriRow = ConvertGeometryGiscuitToArcGIS.GetGeometryMultipolygonZ(newEsriRow, pgCell, partsNumber, pointsNumber);
								break;
							case "multipolygonzm":
								newEsriRow = ConvertGeometryGiscuitToArcGIS.GetGeometryMultipolygonZM(newEsriRow, pgCell, partsNumber, pointsNumber);
								break;
						}
					}
                    }



                    esriTable.Insert(newEsriRow);
                    //CallBackMy.callbackEventHandlerProgress(i, pgTable.Rows.Count);

                    /*
                                        // backgroundworker Progressbar
                                        StaticVariables.CurrentRowConvertToGiscuit = i;
                                        backgroundWorkerPostgisArcgis.ReportProgress(StaticVariables.CurrentRowConvertToGiscuit, 0);//, currentcellstring);
                                        if (backgroundWorkerPostgisArcgis.CancellationPending)
                                        {
                                            break;
                                        }
                    */
                }
                catch (FileGDBException ex)
                {
                    if (ex.ErrorCode == -2147219885)
                    {
//                        MessageBox.Show($"{ex.Message} - {ex.ErrorCode}", @"Error exporting ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show("Table " + nameTable + $" error - field {pgColumnName} not found! . {ex.Message} row - " + @i + ": " + @currentcellstring, "Export to gdb table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    else
                    {
                        //                    MessageBox.Show("Table " + nameTable + " error! row - " + @i + ": " + @currentcellstring, "Export to gdb table", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show($"{ex.Message} - {ex.ErrorCode}", @"Error exporting ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
//                    MessageBox.Show($"General exception. {ex.Message}", @"Error exporting domain to XML", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("Table " + nameTable + $" error! . {ex.Message} row - " + @i + ": " + @currentcellstring, "Export to gdb table", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //                    MessageBox.Show("Table " + nameTable + " error! row - " + @i + ": " + @currentcellstring, "Export to gdb table", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //throw;
                }

               //CallBackMy.callbackEventHandler(currentcellstring);  //вывод в сообщения 

            }
            esriTable.Close(); //закрыть файловую бгд
            CallBackMy.callbackEventHandler("Close ArcGIS gdb after convert.");
            //            geodatabase.Close();
        }



        /// <summary>
        /// </summary>
        /// <param name="row"></param>
        /// <param name="columnName"></param>
        /// <param name="columnType"></param>
        /// <param name="cellValue"></param>
        /// <returns></returns>
        private static Row SetValueToCell(Row row, string columnName, string columnType, object cellValue)
		{
            if (cellValue == DBNull.Value)
            {
                row.SetNull(columnName);
            }
            else
            {
                switch (columnType)
                {
                    case "System.Boolean":
                        //                 row.SetInteger(columnName, Convert.ToInt16(cellValue));
                        row.SetString(columnName, cellValue.ToString());
                        break;

                    case "System.Byte":
                        break;

                    case "System.Char":
                        row.SetString(columnName, cellValue.ToString());
                        break;

                    case "System.DateTime":
                        row.SetDate(columnName, Convert.ToDateTime(cellValue));
                        break;

                    case "System.Decimal":
                        row.SetDouble(columnName, Convert.ToDouble(cellValue));
                        break;

                    case "System.Double":
                        row.SetDouble(columnName, Convert.ToDouble(cellValue));
                        break;

                    case "System.Int16":
                        row.SetInteger(columnName, (int)cellValue);
                        break;

                    case "System.Int32":
                        row.SetInteger(columnName, (int)cellValue);
                        break;

                    case "System.Int64":
                        row.SetInteger(columnName, (int)cellValue);
                        break;

                    case "System.SByte":
                        break;

                    case "System.Single":
                        break;

                    case "System.String":
                        row.SetString(columnName, (string)cellValue);
                        break;

                    case "System.TimeSpan":
                        break;

                    case "System.UInt16":
                        row.SetInteger(columnName, (int)cellValue);
                        break;

                    case "System.UInt32":
                        row.SetInteger(columnName, (int)cellValue);
                        break;

                    case "System.UInt64":
                        row.SetInteger(columnName, (int)cellValue);
                        break;
                }
            }
			return row;
		}

		public DataTable GetDomainDataForInsert(string nameDomain)
		{
			var geodatabase = Geodatabase.Open(Properties.Settings.Default.PathToGDBFolder);
			var dataTable = new DataTable();
			try
			{
				var domainDefinition = geodatabase.GetDomainDefinition(nameDomain);

				var xmlDocument = new XmlDocument();
				xmlDocument.LoadXml(domainDefinition);

				dataTable.Columns.Clear();
				dataTable.Columns.Add("code", typeof (string));
				dataTable.Columns.Add("description", typeof (string));

				var codeValuesNodeList = xmlDocument.SelectNodes("//CodedValues/CodedValue");

				if (codeValuesNodeList == null) return dataTable;

				foreach (XmlNode codeValueNode in codeValuesNodeList)
				{
					for (var i = 0; i < codeValueNode.ChildNodes.Count; i++)
					{
						if (codeValueNode.ChildNodes[i].Name == "Name")
						{
							var newDataRow = dataTable.NewRow();
							var codeElement = codeValueNode["Code"];
							if (codeElement != null)
								newDataRow[0] = codeElement.InnerText;
							var nameElement = codeValueNode["Name"];
							if (nameElement != null)
								newDataRow[1] = nameElement.InnerText;
							dataTable.Rows.Add(newDataRow);
						}
					}
				}

				return dataTable;
			}
			catch (FileGDBException)
			{
				ErrorMessage();
				return null;
			}
			finally
			{
				geodatabase.Close();
			}
		}
	}
}