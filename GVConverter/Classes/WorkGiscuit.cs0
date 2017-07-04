using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Esri.FileGDB;
using GVConverter.Properties;
using Npgsql;

namespace GVConverter.Classes
{
	internal static class WorkGiscuit
	{
		/// <summary>
		/// </summary>
		/// <returns></returns>
		public static List<object> GetAllTables()
		{
			List<object> listTables = null;

			using (var sshDbManager = new SshDbManager())
			{
				try
				{
					const string sql = @"SELECT t.table_name, gc.type 
										FROM information_schema.tables t 
										LEFT JOIN geometry_columns gc on t.table_schema = gc.f_table_schema 
											AND t.table_name = gc.f_table_name 
										WHERE t.table_schema = 'giscuit_layers'";
					var npgsqlDataAdapter = new NpgsqlDataAdapter(sql, sshDbManager.Connection);
					var dataSet = new DataSet();
					npgsqlDataAdapter.Fill(dataSet);

					TempListTableGiscuit.DataTable = dataSet.Tables[0];
					listTables = dataSet.Tables[0].Rows.Cast<DataRow>().Select(r => r[0]).ToList();
				}
				catch (Exception exception)
				{
					MessageBox.Show($"Reading all tables failed. {exception.Message}", @"Get all tables error", MessageBoxButtons.OK,
						MessageBoxIcon.Error);
				}
			}

			Cursor.Current = Cursors.Default;
			return listTables;
		}

		/// <summary>
		/// </summary>
		/// <returns></returns>
//		public static List<object> GetAllTablesWithoutGeometry()
//		{
//			using (var sshDbManager = new SshDbManager())
//			{
//				try
//				{
//					const string sql =
//						"SELECT table_name FROM information_schema.tables WHERE table_schema = 'giscuit_layers' and table_name not in (select f_table_name from geometry_columns)";
//					var npgsqlDataAdapter = new NpgsqlDataAdapter(sql, sshDbManager.Connection);
//					var dataSet = new DataSet();
//					npgsqlDataAdapter.Fill(dataSet);
//
//					TempListTableGiscuit.DataTable = dataSet.Tables[0];
//					var listTables = dataSet.Tables[0].Rows.Cast<DataRow>().Select(r => r[0]).ToList();
//
//					Cursor.Current = Cursors.Default;
//					return listTables;
//				}
//				catch (Exception exception)
//				{
//					MessageBox.Show($"Reading all tables failed. {exception.Message}", @"Get all tables error", MessageBoxButtons.OK,
//						MessageBoxIcon.Error);
//				}
//			}
//
//			Cursor.Current = Cursors.Default;
//			return null;
//		}

		public static List<object> GetAllDomainNames()
		{
			using (var sshDbManager = new SshDbManager())
			{
				try
				{
					const string sql = @"select table_name 
									from information_schema.columns 
									where table_schema = 'giscuit_layers' 
									group by table_name 
									having string_agg(column_name, ',') = 'gid,code,description,gviconvertmark'";
					var npgsqlDataAdapter = new NpgsqlDataAdapter(sql, sshDbManager.Connection);
					var dataSet = new DataSet();
					npgsqlDataAdapter.Fill(dataSet);

					TempListTableGiscuit.DataTable = dataSet.Tables[0];
					var listTables = dataSet.Tables[0].Rows.Cast<DataRow>().Select(r => r[0]).ToList();

					Cursor.Current = Cursors.Default;
					return listTables;
				}
				catch (Exception exception)
				{
					MessageBox.Show($"Reading all tables failed. {exception.Message}", @"Get all tables error", MessageBoxButtons.OK,
						MessageBoxIcon.Error);
				}
			}

			return null;
		}

		/// <summary>
		/// </summary>
		/// <param name="selectedTableArcGis"></param>
		/// <param name="selectedTableGiscuit"></param>
		/// <param name="backgroundWorker1"></param>
		public static void TransferRowsFromArcGisToGiscuit(string selectedTableArcGis, string selectedTableGiscuit, ref BackgroundWorker backgroundWorker1)
		{
			AddMarkColumnToDbTable(selectedTableGiscuit);

			using (var sshDbManager = new SshDbManager())
			{
				Geodatabase geodatabase;

				try
				{
					geodatabase = Geodatabase.Open(Settings.Default.PathToGDBFolder);
				}
				catch (FileGDBException)
				{
					new WorkArcGIS().ErrorMessage();
					return;
				}

				if (geodatabase == null)
				{
					MessageBox.Show(@"Incorrect Geodatabase. Perhaps Geodatabase version below 10.0 or wrong folder",
						@"Error open Geodatabase", MessageBoxButtons.OK,
						MessageBoxIcon.Error);
					return;
				}

				var sqlString = "select * from " + selectedTableArcGis;
				var i = 0;
				var typeOfGeometry = string.Empty;
//				var arcGisRowCount = geodatabase.OpenTable(selectedTableArcGis);
				StaticVariables.TotalRowsConvertToGiscuit = geodatabase.ExecuteSQL(sqlString).Count();
				StaticVariables.NewRowsAddedToGiscuit = 0;
				DataTable dataTable = null;
				var countRows = 0;

				foreach (var row in geodatabase.ExecuteSQL(sqlString))
				{
					i++;
					if (i == 1)
					{
						typeOfGeometry = new WorkArcGIS().GetTypeShapeArcGIS(selectedTableArcGis);
						var sql = "SELECT objectid FROM giscuit_layers." + selectedTableGiscuit;
						var npgsqlDataAdapter = new NpgsqlDataAdapter(sql, sshDbManager.Connection);
						var dataSet = new DataSet();
						npgsqlDataAdapter.Fill(dataSet);
						dataTable = dataSet.Tables[0];
					}
					if (dataTable != null)
					{
						countRows =
							dataTable.AsEnumerable()
								.Count(a => Convert.ToInt32(a["objectid"] == DBNull.Value ? 0 : a["objectid"]) == row.GetOID());

					}

					// backgroundworker Progressbar
					StaticVariables.CurrentRowConvertToGiscuit++;
					backgroundWorker1.ReportProgress(StaticVariables.CurrentRowConvertToGiscuit);
					if (backgroundWorker1.CancellationPending)
					{
						break;
					}
					var workArcGis = new WorkArcGIS();
					if (countRows == 0)
					{
						var shapeLength = workArcGis.GetLengthShapeValueFromRow(row).ToString(CultureInfo.InvariantCulture);
						string insertGeom;
						try
						{
							insertGeom = ConvertGeometryArcGIS.ConvertToWkt(row.GetGeometry(), typeOfGeometry, shapeLength);
						}
						catch (Exception)
						{
							continue;
						}
						var otherFields = new WorkArcGIS().GetFieldsName(selectedTableArcGis);
						var valuesFields = WorkArcGIS.ConvertRowValuesToSqlString(row);

						NpgsqlCommand command;

						if (row.GetGeometry().geometryType.ToString().ToLower() != "point")
						{
							command = new NpgsqlCommand(
								$"INSERT INTO giscuit_layers.{selectedTableGiscuit}" +
								$"(shape_leng, the_geom, {otherFields} gviconvertmark) " +
								$"VALUES({shapeLength}, {insertGeom}, @{valuesFields}true)",
								sshDbManager.Connection);
						}
						else
						{
							command = new NpgsqlCommand(
								$"INSERT INTO giscuit_layers.{selectedTableGiscuit}" +
								$"(the_geom, {otherFields} gviconvertmark) " +
								$"VALUES({insertGeom}, @{valuesFields}true)",
								sshDbManager.Connection);
						}

						try
						{
							command.ExecuteNonQuery();
							StaticVariables.NewRowsAddedToGiscuit++;
						}
						catch (NpgsqlException e)
						{
							MessageBox.Show($"Error message: {e.BaseMessage}, Error code: {e.Code}");
							break;
						}
					}
				}

				geodatabase.Close();
				Cursor.Current = Cursors.Default;
			}
		}

		private static void AddMarkColumnToDbTable(string selectedTableGiscuit)
		{
			using (var sshDbManager = new SshDbManager())
			{
				var command =
					new NpgsqlCommand(
						"SELECT a.attname AS name FROM  pg_attribute a WHERE a.attname='gviconvertmark' AND a.attrelid = 'giscuit_layers." +
						selectedTableGiscuit + "'::regclass", sshDbManager.Connection);

				var checkColumn = command.ExecuteScalar();

				if (checkColumn == null)
				{
					command.CommandText = "ALTER TABLE giscuit_layers." + selectedTableGiscuit + " ADD COLUMN gviconvertmark boolean";
					command.ExecuteScalar();
				}
			}
		}

		/// <summary>
		/// </summary>
		/// <param name="shapeTypeArcGis"></param>
		/// <param name="nameTableArcGis"></param>
		/// <param name="nameTabeGiscuit"></param>
		public static void CreateNewTable(string shapeTypeArcGis, string nameTableArcGis, string nameTabeGiscuit)
		{
			var shapeLeng = string.Empty;
			if (shapeTypeArcGis.ToLower() != "point")
			{
				if (shapeTypeArcGis.ToLower() != "pointz")
				{
					if (shapeTypeArcGis.ToLower() != "pointzm")
					{
						shapeLeng = "shape_leng numeric,";
					}
				}
			}
			var theGeom = GenerateSQLQueryGiscuit.GetGeometry(shapeTypeArcGis);
			var otherFields = GenerateSQLQueryGiscuit.OtherFields(nameTableArcGis);

			var owner = Settings.Default.NameDataBasePostgreSQL;
			////////////////////////////

			using (var sshDbManager = new SshDbManager())
			{
				var command = new NpgsqlCommand("CREATE TABLE giscuit_layers." + nameTabeGiscuit +
												"(gid serial NOT NULL," +
												shapeLeng + //"shape_leng numeric,"+
												theGeom +
												//"the_geom geometry(MultiLineString),"+ или the_geom geometry(POINT), и т.д.
												otherFields +
												"gviconvertmark boolean," +
												"CONSTRAINT " + nameTabeGiscuit + "_pkey PRIMARY KEY (gid)) " +
												"WITH (OIDS=FALSE);" +
												"ALTER TABLE giscuit_layers." + nameTabeGiscuit + " OWNER TO " + owner + ";" +
												"CREATE INDEX " + nameTabeGiscuit + "_the_geom_gist " +
												"ON giscuit_layers." + nameTabeGiscuit +
												" USING gist (the_geom);"
					, sshDbManager.Connection);
				try
				{
					command.ExecuteScalar();
					MessageBox.Show(@"New table has been created");
				}
				catch (NpgsqlException e)
				{
					if (e.Code == "42P07")
					{
						string message = "Table '" + nameTabeGiscuit + "' already exists";
						MessageBox.Show(message, @"Error create new table", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					throw;
				}
			}
		}

		/// <summary>
		/// </summary>
		/// <param name="nameTable"></param>
		public static void DeleteTable(string nameTable)
		{
			using (var sshDbManager = new SshDbManager())
			{
				var command = new NpgsqlCommand("SELECT count(*) from giscuit_layers." + nameTable, sshDbManager.Connection);
				try
				{
					Int64 countColumn = Convert.ToInt64(command.ExecuteScalar());
					if (countColumn != 0)
					{
						MessageBox.Show(@"Table " + nameTable + @" contains data and can not be deleted", @"Error delete table",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					else
					{
						command.CommandText = "drop table giscuit_layers." + nameTable;
						command.ExecuteNonQuery();
						MessageBox.Show($"Table {nameTable} deleted!", @"Delete table", MessageBoxButtons.OK,
							MessageBoxIcon.Information);
					}
				}
				catch (Exception)
				{
					//throw;
				}

				finally
				{
					Cursor.Current = Cursors.Default;
				}
			}
		}

		/// <summary>
		/// </summary>
		/// <param name="nameTable"></param>
		public static void DeleteTableRecords(string nameTable)
		{
			using (var sshDbManager = new SshDbManager())
			{
				var command = new NpgsqlCommand("DELETE from giscuit_layers." + nameTable, sshDbManager.Connection);
				try
				{
					command.ExecuteNonQuery();
				}
				catch (Exception)
				{
					//throw;
				}
				finally
				{
					Cursor.Current = Cursors.Default;
				}
			}
		}
		
		/// <summary>
		/// </summary>
		/// <param name="nameTable"></param>
		public static DataTable GetColumnsDefinition(string nameTable)
		{
			var dataTable = new DataTable();

			using (var sshDbManager = new SshDbManager())
			{
				var command =
					new NpgsqlCommand("SELECT a.attname as column_name, format_type(a.atttypid, a.atttypmod) AS data_type " +
									"FROM pg_attribute a " +
									"JOIN pg_class b ON (a.attrelid = b.relfilenode) " +
									"WHERE b.relname = '" + nameTable + "' and a.attstattarget = -1", sshDbManager.Connection);
				try
				{
					NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(command);
					npgsqlDataAdapter.Fill(dataTable);
				}
				catch (Exception)
				{
					// ignored
				}
				finally
				{
					Cursor.Current = Cursors.Default;
				}
			}

			return dataTable;
		}

		public static DataTable ReadTableWithGeometry(string pgTableName, string rowsLimit)
		{
			Cursor.Current = Cursors.WaitCursor;
			var dataTable = new DataTable();

			using (var sshDbManager = new SshDbManager())
			{
				try
				{
					var command =
						new NpgsqlCommand(
							$"SELECT ST_AsText(the_geom) as geometry, * FROM giscuit_layers.{pgTableName} limit {rowsLimit}",
							sshDbManager.Connection);
					var npgsqlDataAdapter = new NpgsqlDataAdapter(command);

					npgsqlDataAdapter.Fill(dataTable);
				}
				catch (Exception exception)
				{
					MessageBox.Show(exception.Message, @"Error reading table data", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			Cursor.Current = Cursors.Default;
			return dataTable;
		}

		public static DataTable ReadTable(string pgTableName, string rowsLimit)
		{
			Cursor.Current = Cursors.WaitCursor;
			var dataTable = new DataTable();

			using (var sshDbManager = new SshDbManager())
			{
				var command =
					new NpgsqlCommand(
						$"SELECT * FROM giscuit_layers.{pgTableName} limit {rowsLimit}",
						sshDbManager.Connection);
				var npgsqlDataAdapter = new NpgsqlDataAdapter(command);

				try
				{
					npgsqlDataAdapter.Fill(dataTable);
				}
				catch (Exception exception)
				{
					MessageBox.Show(exception.Message, @"Error reading table data", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					Cursor.Current = Cursors.Default;
				}
			}

			return dataTable;
		}

		/// <summary>
		/// </summary>
		/// <param name="nameTable"></param>
		/// <returns>DataTable</returns>
		public static DataTable GetAllRowsFromTable(string nameTable)
		{
			Cursor.Current = Cursors.WaitCursor;
			var dataTable = new DataTable();

			using (var sshDbManager = new SshDbManager())
			{
				var command =
					new NpgsqlCommand(
						"SELECT ST_AsText(the_geom) as geomtrey, ST_NumGeometries(the_geom) as NumGeometries, ST_NPoints(the_geom) as NumPoints, * FROM giscuit_layers." +
						nameTable, sshDbManager.Connection);
				var npgsqlDataAdapter = new NpgsqlDataAdapter(command);

				try
				{
					npgsqlDataAdapter.Fill(dataTable);
				}
				catch (Exception)
				{
//					throw;
				}
				finally
				{
					if (dataTable.Columns["the_geom"] != null)
						dataTable.Columns.Remove("the_geom");
					if (dataTable.Columns["gid"] != null)
						dataTable.Columns.Remove("gid");
					if (dataTable.Columns["objectid"] != null)
						dataTable.Columns.Remove("objectid");

					Cursor.Current = Cursors.Default;
				}
			}

			return dataTable;
		}


		/// <summary>
		/// </summary>
		/// <param name="newNameTableGiscuit"></param>
		public static void CreateNewDomainTable(string newNameTableGiscuit)
		{
			var owner = Settings.Default.NameDataBasePostgreSQL;

			using (var sshDbManager = new SshDbManager())
			{
				var command = new NpgsqlCommand("CREATE TABLE giscuit_layers." + newNameTableGiscuit +
				                                "(gid serial NOT NULL," +
				                                "Code integer," +
				                                "Description character varying," +
				                                "gviconvertmark boolean," +
				                                "CONSTRAINT " + newNameTableGiscuit + "_pkey PRIMARY KEY (gid)) " +
				                                "WITH (OIDS=FALSE);" +
				                                "ALTER TABLE giscuit_layers." + newNameTableGiscuit + " OWNER TO " + owner + ";"
					, sshDbManager.Connection);

				try
				{
					command.ExecuteScalar();
				}
				catch (NpgsqlException e)
				{
					if (e.Code == "42P07")
					{
						var message = "Table '" + newNameTableGiscuit + "' already exists";
						MessageBox.Show(message, @"Error create new table", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		public static void InsertNewRowToDomain(string nameTableArcGis, string nameTableGiscuit)
		{
			DataTable dataTable = new WorkArcGIS().GetDomainDataForInsert(nameTableArcGis);

			using (var sshDbManager = new SshDbManager())
			{
				try
				{
					for (int i = 0; i < dataTable.Rows.Count; i++)
					{
						var valueDescription = dataTable.Rows[i][1].ToString();
						valueDescription = valueDescription.Replace("'", "\\'");
						var command =
							new NpgsqlCommand(
								"INSERT INTO giscuit_layers." + nameTableGiscuit + "(code, description, gviconvertmark) VALUES(" +
								dataTable.Rows[i][0] + ", E'" +
								valueDescription + "', " +
								"true)", sshDbManager.Connection);
						command.ExecuteNonQuery();
					}
				}
				catch (Exception)
				{
//					throw;
				}
				finally
				{
					Cursor.Current = Cursors.Default;
				}
			}
		}

		public static string GetTableGeometryType(string tableName)
		{
			var pgColumnsDefinition = GetColumnsDefinition(tableName);
			var geometryType = string.Empty;

			for (var i = 0; i < pgColumnsDefinition.Rows.Count; i++)
			{
				if (pgColumnsDefinition.Rows[i][0].ToString().ToLower() == "the_geom")
				{
					geometryType = pgColumnsDefinition.Rows[i][1].ToString();
					break;
				}
			}

			var match = new Regex(@"\((\S+)\)").Match(geometryType);

			if (match.Success)
			{
				geometryType = match.Groups[1].Value;
			}

			return geometryType;
		}

		private static DataRow GetRowByObjectId(string selectedTableGiscuit, int rowOid)
		{
			using (var sshDbManager = new SshDbManager())
			{
				var sql = $"SELECT * FROM giscuit_layers.{selectedTableGiscuit} WHERE objectid = {rowOid}";
				var npgsqlDataAdapter = new NpgsqlDataAdapter(sql, sshDbManager.Connection);
				var dataSet = new DataSet();
				npgsqlDataAdapter.Fill(dataSet);
				var dataTable = dataSet.Tables[0];

				return dataTable?.Rows[0];
			}
		}
	}
}