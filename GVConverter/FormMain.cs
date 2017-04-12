using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using GVConverter.Classes;
using Esri.FileGDB;
using GVConverter.Froms;
using GVConverter.Properties;

namespace GVConverter
{
	public partial class FormMain : Form
	{
		private Geodatabase _geodatabase;
		string TablesArcGISConvert;
		string TablesGiscuitConvert;
		private bool _cancelConvertToGiscuit = false;

		public FormMain()
		{
			InitializeComponent();
			labelBackgroubndWorkerConvertToGiscuit.Text = string.Empty;
			labelBackgroubndWorkerCompleteConvertToGiscuit.Text = string.Empty;
		}

		/// <summary>
		/// Get data from Geodatabase
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnGetData_Click(object sender, EventArgs e)
		{
			listBoxOfDomainsViewData.DataSource = new WorkArcGIS().GetDomainList();
			listBoxOfTablesArcGISViewData.DataSource = new WorkArcGIS().GetTableList();
		}

		/// <summary>
		/// Export data for choicing Domain to XML file 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnExportDomainToXML_Click(object sender, EventArgs e)
		{

			SaveFileDialog dialogResult = new SaveFileDialog();
			dialogResult.Filter = @"XML files (*.xml)|*.xml|All files (*.*)|*.*";
			dialogResult.FileName = "Domain " + listBoxOfDomainsViewData.SelectedItem;

			if (dialogResult.ShowDialog() == DialogResult.OK)
			{
				try
				{
					var geodatabase = Geodatabase.Open(Settings.Default.PathToGDBFolder);
					var domainDefinition = geodatabase.GetDomainDefinition(listBoxOfDomainsViewData.SelectedItem.ToString());
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.LoadXml(domainDefinition);
					xmlDocument.Save(dialogResult.FileName);
					MessageBox.Show(@"The file was saved!");
				}
				catch (FileGDBException ex)
				{
					MessageBox.Show($"{ex.Message} - {ex.ErrorCode}", @"Error exporting domain to XML",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{
					MessageBox.Show($"General exception. {ex.Message}", @"Error exporting domain to XML",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		/// <summary>
		/// Get data for current Doamin and show to the DataGrid
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void listBoxOfDomains_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBoxOfDomainsViewData.SelectedItem != null)
			{
				if (!btnExportDomainToXML.Enabled)
				{
					btnExportDomainToXML.Enabled = true;
				}

				var tmpGetData = new WorkArcGIS().GetDataForCurrentDomain(listBoxOfDomainsViewData.SelectedItem.ToString());
				dataGridViewDomains.DataSource = tmpGetData.Item1;
				textBoxFieldType.Text = tmpGetData.Item2;
				textBoxMergePolicy.Text = tmpGetData.Item3;
				textBoxSplitPolicy.Text = tmpGetData.Item4;
				textBoxDescription.Text = tmpGetData.Item5;
			}
		}

		/// <summary>
		/// Get data for current Table and show to the DataGrid
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void listBoxOfTables_SelectedIndexChanged(object sender, EventArgs e)
		{
			WorkArcGIS workArcGis = new WorkArcGIS();
			var tmpTableData = workArcGis.GetDataForCurrentTable(listBoxOfTablesArcGISViewData.SelectedItem.ToString());
			dataGridViewTablesArcGISViewData.DataSource = tmpTableData.Item1;
			textBoxXmin.Text = tmpTableData.Item2;
			textBoxXmax.Text = tmpTableData.Item3;
			textBoxYmin.Text = tmpTableData.Item4;
			textBoxYmax.Text = tmpTableData.Item5;
			textBoxZmin.Text = tmpTableData.Item6;
			textBoxZmax.Text = tmpTableData.Item7;
		}

		private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show(@"Are you sure?", @"Exit application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
			    DialogResult.No)
				e.Cancel = true;
		}

		private void btnGetDataGiscuit_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			listBoxOfTablesGuscuit.DataSource = WorkGiscuit.GetAllTables();
			Cursor.Current = Cursors.WaitCursor;
		}

		private void listBoxOfTablesGiscuit_SelectedIndexChanged(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			DataTable dataTable; 

			var geometryType = TempListTableGiscuit.DataTable.Select($"table_name = '{listBoxOfTablesGuscuit.SelectedItem}'")[0][1].ToString();

			if (string.IsNullOrEmpty(geometryType))
			{
				dataTable = WorkGiscuit.ReadTable(listBoxOfTablesGuscuit.SelectedItem.ToString(), "null");
			}
			else
			{
				dataTable = WorkGiscuit.ReadTableWithGeometry(listBoxOfTablesGuscuit.SelectedItem.ToString(), "null");
			}

			//			var conn =
			//				new NpgsqlConnection("Server=127.0.0.1; User Id=giscuit; Password=giscuit; Database=giscuit");
			//			conn.Open();
			//
			//			var command =
			//				new NpgsqlCommand(
			//					"SELECT ST_AsText(the_geom) as geomtrey, * FROM giscuit_layers." + listBoxOfTablesGuscuit.SelectedItem, conn);
			//			var npgsqlDataAdapter = new NpgsqlDataAdapter(command);
			//			try
			//			{
			//				npgsqlDataAdapter.Fill(dataTable);
			//			}
			//			catch (Exception)
			//			{
			//				throw;
			//			}
			//			finally
			//			{
			//				dataTable.Columns.Remove("the_geom");
			//				dataGridViewGiscuitViewData.DataSource = dataTable;
			//			}

			dataGridViewGiscuitViewData.DataSource = dataTable;
			textBoxTotalRowsGiscuitViewData.Text = dataTable.Rows.Count.ToString();
			Cursor.Current = Cursors.Default;
		}

		private void btnSettingsProgramm_Click(object sender, EventArgs e)
		{
			SettingsProgramm settingsProgramm = new SettingsProgramm();
			settingsProgramm.ShowDialog();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			MessageBox.Show(@"Soon there will be a Help", @"Inforamtion", MessageBoxButtons.OK,
				MessageBoxIcon.Information);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show(@"Soon there will be an Information about program", @"Inforamtion", MessageBoxButtons.OK,
				MessageBoxIcon.Information);
		}

		private void btnGetTablesArcGIS_Click(object sender, EventArgs e)
		{
			listBoxTablesArcGISConvert.DataSource = new WorkArcGIS().GetTableList();
			textBoxTotalTablesArcGISConvert.Text = listBoxTablesArcGISConvert.Items.Count.ToString();
			if (listBoxTablesArcGISConvert.Items.Count != 0)
			{
				radioButtonSortByNameArcGIS.Enabled = true;
				radioButtonByDefaultArcGIS.Enabled = true;
			}
			else
			{
				radioButtonSortByNameArcGIS.Enabled = false;
				radioButtonByDefaultArcGIS.Enabled = false;
			}
		}

		private void listBoxTablesArcGIS_SelectedIndexChanged(object sender, EventArgs e)
		{
			textBoxTypeShapeArcGISConvert.Text =
				new WorkArcGIS().GetTypeShapeArcGIS(listBoxTablesArcGISConvert.SelectedItem.ToString());
			if (!btnCreateTableFromArcGISConvert.Enabled)
			{
				btnCreateTableFromArcGISConvert.Enabled = true;
			}
			if (listBoxTablesGiscuitConvert.SelectedItem != null)
			{
				if (Equals(listBoxTablesArcGISConvert.SelectedItem.ToString().ToLower(),
					listBoxTablesGiscuitConvert.SelectedItem.ToString().ToLower()))
				{
					btnRunConvertArcGISToGiscuit.Enabled = true;
					btnConvertOverwriteData.Enabled = true;
				}
				else
				{
					btnRunConvertArcGISToGiscuit.Enabled = false;
					btnConvertOverwriteData.Enabled = false;
				}
			}
		}

		private void listBoxTablesGiscuit_SelectedIndexChanged(object sender, EventArgs e)
		{
			for (int i = 0; i < TempListTableGiscuit.DataTable.Rows.Count; i++)
			{
				if (TempListTableGiscuit.DataTable.Rows[i][0] == listBoxTablesGiscuitConvert.SelectedItem)
				{
					textBoxTypeShapeGiscuitConvert.Text = TempListTableGiscuit.DataTable.Rows[i][1].ToString();
				}
			}
			if (listBoxTablesArcGISConvert.SelectedItem != null)
			{
				if (Equals(listBoxTablesArcGISConvert.SelectedItem.ToString().ToLower(),
					listBoxTablesGiscuitConvert.SelectedItem.ToString().ToLower()))
				{
					btnRunConvertArcGISToGiscuit.Enabled = true;
					btnConvertOverwriteData.Enabled = true;
				}
				else
				{
					btnRunConvertArcGISToGiscuit.Enabled = false;
					btnConvertOverwriteData.Enabled = false;
				}
			}
			if (listBoxTablesGiscuitConvert.SelectedItem != null)
			{
				btnDeleteTableGiscuit.Enabled = true;
				btnClearDataGiscuitTable.Enabled = true;
			}
			else
			{
				btnDeleteTableGiscuit.Enabled = false;
				btnClearDataGiscuitTable.Enabled = false;
			}
		}

		private void getTablesGiscuit_Click(object sender, EventArgs e)
		{
			if (TempListTableGiscuit.DataTable != null) TempListTableGiscuit.DataTable.Clear();
			Cursor.Current = Cursors.WaitCursor;
			listBoxTablesGiscuitConvert.DataSource = WorkGiscuit.GetAllTables();
			textBoxTotalTablesGiscuitConvert.Text = listBoxTablesGiscuitConvert.Items.Count.ToString();
			radioButtonSortByNameGiscuit.Enabled = true;
			radioButtonByDefaultGiscuit.Enabled = true;
		}

		private void btnCreateTableFromArcGIS_Click(object sender, EventArgs e)
		{
			var shapeTypeArcGIS = new WorkArcGIS().GetTypeShapeArcGIS(listBoxTablesArcGISConvert.SelectedItem.ToString());
			CreateTableGiscuitForm createTableGiscuitForm = new CreateTableGiscuitForm(shapeTypeArcGIS,
				listBoxTablesArcGISConvert.SelectedItem.ToString());
			createTableGiscuitForm.ShowDialog();
			if (createTableGiscuitForm.DialogResult == DialogResult.OK)
			{
				if (TempListTableGiscuit.DataTable != null) TempListTableGiscuit.DataTable.Clear();
				Cursor.Current = Cursors.WaitCursor;
				listBoxTablesGiscuitConvert.DataSource = WorkGiscuit.GetAllTables();
				Cursor.Current = Cursors.Default;
			}
		}

		private void btnArcGISBrowseFolder_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = folderBrowserDialog1.ShowDialog();
			folderBrowserDialog1.Description = @"Select Geodatabase folder";
			if (dialogResult == DialogResult.OK)
			{
				textBoxLocationFolderGDB.Text = folderBrowserDialog1.SelectedPath;
				Settings.Default.Save();
			}
		}

		/// <summary>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnDeleteTableGiscuit_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult =
				MessageBox.Show(@"Table " + listBoxTablesGiscuitConvert.SelectedItem + " will be deleted. Are you sure?",
					@"Delete table", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dialogResult == DialogResult.Yes)
			{
				Cursor.Current = Cursors.WaitCursor;
				WorkGiscuit.DeleteTable(listBoxTablesGiscuitConvert.SelectedItem.ToString());
				if (TempListTableGiscuit.DataTable != null) TempListTableGiscuit.DataTable.Clear();
				listBoxTablesGiscuitConvert.DataSource = WorkGiscuit.GetAllTables();
			}

		}

		private void btnConvertOverwriteData_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult =
				MessageBox.Show(
					@"Old records in table " + listBoxTablesGiscuitConvert.SelectedItem + " will be overwrited. Are you sure?",
					@"Overwrite data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dialogResult == DialogResult.Yes)
			{
				Cursor.Current = Cursors.WaitCursor;
				WorkGiscuit.DeleteTableRecords(listBoxTablesGiscuitConvert.SelectedItem.ToString());
				Cursor.Current = Cursors.WaitCursor;
				settingsBackgroundWorker();
				backgroundWorker1.RunWorkerAsync();
			}
		}

		private void btbBrowseConvertTab_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = folderBrowserDialog1.ShowDialog();
			folderBrowserDialog1.Description = @"Select Geodatabase folder";
			if (dialogResult == DialogResult.OK)
			{
				textBoxGDBLocation.Text = folderBrowserDialog1.SelectedPath;
				Properties.Settings.Default.Save();
			}
		}

		private void radioButtonSortByNameArcGIS_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButtonSortByNameArcGIS.Checked)
			{
				List<object> list = new WorkArcGIS().GetTableList().OrderBy(item => item.ToString()).ToList();
				listBoxTablesArcGISConvert.DataSource = list;
			}
		}

		private void radioButtonByDefaultArcGIS_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButtonByDefaultArcGIS.Checked)
			{
				listBoxTablesArcGISConvert.DataSource = new WorkArcGIS().GetTableList();
			}
		}

		private void radioButtonSortByNameGiscuit_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButtonSortByNameGiscuit.Checked)
			{
				Cursor.Current = Cursors.WaitCursor;
				List<object> list = new List<object>();
				for (int i = 0; i < TempListTableGiscuit.DataTable.Rows.Count; i++)
				{
					list.Add(TempListTableGiscuit.DataTable.Rows[i][0]);
				}
				listBoxTablesGiscuitConvert.DataSource = list.OrderBy(item => item.ToString()).ToList();
			}
		}

		private void radioButtonByDefaultGiscuit_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButtonByDefaultGiscuit.Checked)
			{
				Cursor.Current = Cursors.WaitCursor;
				List<object> list = new List<object>();
				for (int i = 0; i < TempListTableGiscuit.DataTable.Rows.Count; i++)
				{
					list.Add(TempListTableGiscuit.DataTable.Rows[i][0]);
				}
				listBoxTablesGiscuitConvert.DataSource = list;
			}
		}

		private void btnClearDataGiscuitTable_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult =
				MessageBox.Show(
					@"All records in table " + listBoxTablesGiscuitConvert.SelectedItem + " will be deleted. Are you sure?",
					@"Delete data from tabe", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
			if (dialogResult == DialogResult.Yes)
			{
				Cursor.Current = Cursors.WaitCursor;
				WorkGiscuit.DeleteTableRecords(listBoxTablesGiscuitConvert.SelectedItem.ToString());
				MessageBox.Show(@"Has been deleted all data from table PostGIS", @"Added new data", MessageBoxButtons.OK,
					MessageBoxIcon.Information);
			}
		}

		private void btbBrowseFileGDBConvertToArcGIS_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = folderBrowserDialog1.ShowDialog();
			folderBrowserDialog1.Description = @"Select Geodatabase folder";
			if (dialogResult == DialogResult.OK)
			{
				textBoxGDBLocationConvertToArcGIS.Text = folderBrowserDialog1.SelectedPath;
				Properties.Settings.Default.Save();
			}
		}

		private void btnGetTablesArcGISConvertToAcrGIS_Click(object sender, EventArgs e)
		{
			listBoxTablesArcGISConvertToArcGIS.DataSource = new WorkArcGIS().GetTableList();
			textBoxTotalTablesArcGISConvertToArcGIS.Text = listBoxTablesArcGISConvertToArcGIS.Items.Count.ToString();

			if (listBoxTablesArcGISConvertToArcGIS.Items.Count != 0)
			{
				radioButtonSortByNameArcGISConvertToArcGIS.Enabled = true;
				radioButtonSortByDefaultArcGISConvertToArcGIS.Enabled = true;
			}
			else
			{
				radioButtonSortByNameArcGISConvertToArcGIS.Enabled = false;
				radioButtonSortByDefaultArcGISConvertToArcGIS.Enabled = false;
			}
		}

		private void btnGetDataGiscuitConvertToArcGIS_Click(object sender, EventArgs e)
		{
			if (TempListTableGiscuit.DataTable != null) TempListTableGiscuit.DataTable.Clear();
			Cursor.Current = Cursors.WaitCursor;
			listBoxTablesGiscuitConvertToArcGIS.DataSource = WorkGiscuit.GetAllTables();
			textBoxTotalTablesGiscuitConvertToAcrGIS.Text = listBoxTablesGiscuitConvertToArcGIS.Items.Count.ToString();
			radioButtonSortByNameGiscuitConvertToArcGIS.Enabled = true;
			radioButtonSortByDefaultGiscuitConvertToArcGIS.Enabled = true;
		}

		private void listBoxTablesGiscuitConvertToArcGIS_SelectedIndexChanged(object sender, EventArgs e)
		{
			for (int i = 0; i < TempListTableGiscuit.DataTable.Rows.Count; i++)
			{
				if (TempListTableGiscuit.DataTable.Rows[i][0] == listBoxTablesGiscuitConvertToArcGIS.SelectedItem)
				{
					textBoxTypeShapeGiscuitConvertToArcGIS.Text = TempListTableGiscuit.DataTable.Rows[i][1].ToString();
				}
			}
			if (!btnCreateTableFromGiscuitConvertToArcGIS.Enabled)
			{
				btnCreateTableFromGiscuitConvertToArcGIS.Enabled = true;
			}
			if (listBoxTablesArcGISConvertToArcGIS.SelectedItem != null)
			{
				if (Equals(listBoxTablesGiscuitConvertToArcGIS.SelectedItem.ToString().ToLower(),
					listBoxTablesArcGISConvertToArcGIS.SelectedItem.ToString().ToLower()))
				{
					btnAppendConvertToArcGIS.Enabled = true;
					brnOverwriteConvertToArcGIS.Enabled = true;
				}
				else
				{
					btnAppendConvertToArcGIS.Enabled = false;
					brnOverwriteConvertToArcGIS.Enabled = false;
				}
			}
		}

		private void radioButtonSortByNameGiscuitConvertToArcGIS_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButtonSortByNameGiscuitConvertToArcGIS.Checked)
			{
				Cursor.Current = Cursors.WaitCursor;
				List<object> list = new List<object>();
				for (int i = 0; i < TempListTableGiscuit.DataTable.Rows.Count; i++)
				{
					list.Add(TempListTableGiscuit.DataTable.Rows[i][0]);
				}
				listBoxTablesGiscuitConvertToArcGIS.DataSource = list.OrderBy(item => item.ToString()).ToList();
			}
		}

		private void radioButtonSortByDefaultGiscuitConvertToArcGIS_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButtonSortByDefaultGiscuitConvertToArcGIS.Checked)
			{
				Cursor.Current = Cursors.WaitCursor;
				List<object> list = new List<object>();
				for (int i = 0; i < TempListTableGiscuit.DataTable.Rows.Count; i++)
				{
					list.Add(TempListTableGiscuit.DataTable.Rows[i][0]);
				}
				listBoxTablesGiscuitConvertToArcGIS.DataSource = list;

			}
		}

		private void listBoxTablesArcGISConvertToArcGIS_SelectedIndexChanged(object sender, EventArgs e)
		{
			textBoxTypeShapeArcGISConvertToArcGIS.Text =
				new WorkArcGIS().GetTypeShapeArcGIS(listBoxTablesArcGISConvertToArcGIS.SelectedItem.ToString());
			if (listBoxTablesArcGISConvertToArcGIS.SelectedItem != null)
			{
				btnClearDataArcGISTableConvertToArcGIS.Enabled = true;
				btnDeleteTableArcGISConvetToArcGIS.Enabled = true;
			}
			else
			{
				btnClearDataArcGISTableConvertToArcGIS.Enabled = false;
				btnDeleteTableArcGISConvetToArcGIS.Enabled = false;
			}
			if (listBoxTablesGiscuitConvertToArcGIS.SelectedItem != null)
			{
				if (Equals(listBoxTablesGiscuitConvertToArcGIS.SelectedItem.ToString().ToLower(),
					listBoxTablesArcGISConvertToArcGIS.SelectedItem.ToString().ToLower()))
				{
					btnAppendConvertToArcGIS.Enabled = true;
					brnOverwriteConvertToArcGIS.Enabled = true;
				}
				else
				{
					btnAppendConvertToArcGIS.Enabled = false;
					brnOverwriteConvertToArcGIS.Enabled = false;
				}
			}
		}

		private void radioButtonSortByNameArcGISConvertToArcGIS_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButtonSortByNameArcGISConvertToArcGIS.Checked)
			{
				List<object> list = new WorkArcGIS().GetTableList().OrderBy(item => item.ToString()).ToList();
				listBoxTablesArcGISConvertToArcGIS.DataSource = list;
			}
		}

		private void radioButtonSortByDefaultArcGISConvertToArcGIS_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButtonSortByDefaultArcGISConvertToArcGIS.Checked)
			{
				listBoxTablesArcGISConvertToArcGIS.DataSource = new WorkArcGIS().GetTableList();
			}
		}

		private void btnRunConvertArcGISToGiscuit_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			settingsBackgroundWorker(); // Задаем настройки backgroundWorker для запусмка
			backgroundWorker1.RunWorkerAsync();
		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			WorkGiscuit.TransferRowsFromArcGisToGiscuit(TablesArcGISConvert, TablesGiscuitConvert, ref backgroundWorker1);
			MessageBox.Show(@"Has been added " + StaticVariables.NewRowsAddedToGiscuit + " new data from ArcGIS to PostGIS",
				@"Added new data", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			tabControlMain.Enabled = true;
			groupBox4.Enabled = true;

			if (_cancelConvertToGiscuit)
			{
				labelBackgroubndWorkerCompleteConvertToGiscuit.ForeColor = Color.Red;
				labelBackgroubndWorkerCompleteConvertToGiscuit.Text = "Convert canceled!";
			}
			else
			{
				labelBackgroubndWorkerCompleteConvertToGiscuit.ForeColor = Color.Green;
				labelBackgroubndWorkerCompleteConvertToGiscuit.Text = "Convert completed!";
			}
		}

		private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			if (!backgroundWorker1.CancellationPending)
			{
				progressBarConvertToGiscuit.Minimum = 0;
				progressBarConvertToGiscuit.Maximum = StaticVariables.TotalRowsConvertToGiscuit;
				progressBarConvertToGiscuit.Value = e.ProgressPercentage;
				labelBackgroubndWorkerConvertToGiscuit.Text = "Rows processed " + StaticVariables.CurrentRowConvertToGiscuit +
				                                              " of " + StaticVariables.TotalRowsConvertToGiscuit;
			}
			else
			{
				_cancelConvertToGiscuit = true;
			}
		}

		private void FormMain_KeyDown(object sender, KeyEventArgs e)
		{

		}

		private void FormMain_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((backgroundWorker1.IsBusy) && (e.KeyChar == (char) Keys.Escape))
			{
				DialogResult dialogResult = MessageBox.Show(@"This operation will be canceled! Are you sure?", @"Cancel convert",
					MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dialogResult == DialogResult.Yes)
				{
					backgroundWorker1.WorkerSupportsCancellation = true;
					backgroundWorker1.CancelAsync();
				}
			}
		}

		private void settingsBackgroundWorker()
		{
			tabControlMain.Enabled = false;
			groupBox4.Enabled = false;

			StaticVariables.CurrentRowConvertToGiscuit = 0;
			StaticVariables.TotalRowsConvertToGiscuit = 0;
			_cancelConvertToGiscuit = false;
			labelBackgroubndWorkerCompleteConvertToGiscuit.ForeColor = Color.Red;
			labelBackgroubndWorkerCompleteConvertToGiscuit.Text = @"For cancel convert press ESC...";
			labelBackgroubndWorkerCompleteConvertToGiscuit.Visible = true;
			progressBarConvertToGiscuit.Visible = true;
			progressBarConvertToGiscuit.Value = 0;
			labelBackgroubndWorkerConvertToGiscuit.Text = "Rows processed " + StaticVariables.CurrentRowConvertToGiscuit + " of " +
			                                              StaticVariables.TotalRowsConvertToGiscuit;
			TablesArcGISConvert = listBoxTablesArcGISConvert.SelectedItem.ToString();
			TablesGiscuitConvert = listBoxTablesGiscuitConvert.SelectedItem.ToString();
		}

		#region Convert PostGIS -> ArcGIS

		/// <summary>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnDeleteTableArcGISConvetToArcGIS_Click(object sender, EventArgs e)
		{
			string text = String.Format("Will be deleted table {0}. Are you sure?",
				listBoxTablesArcGISConvertToArcGIS.SelectedItem);
			DialogResult dialogResult = MessageBox.Show(text, @"Delete table", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dialogResult == DialogResult.Yes)
			{
				WorkArcGIS workArcGis = new WorkArcGIS();
				var tmpTableData = workArcGis.GetDataForCurrentTable(listBoxTablesArcGISConvertToArcGIS.SelectedItem.ToString());

				if (tmpTableData.Item1.Rows.Count == 0)
				{
					new WorkArcGIS().DeleteCurrentTable(listBoxTablesArcGISConvertToArcGIS.SelectedItem.ToString());
					listBoxTablesArcGISConvertToArcGIS.DataSource = new WorkArcGIS().GetTableList();
					textBoxTotalTablesArcGISConvertToArcGIS.Text = listBoxTablesArcGISConvertToArcGIS.Items.Count.ToString();
					if (listBoxTablesArcGISConvertToArcGIS.Items.Count != 0)
					{
						radioButtonSortByNameArcGISConvertToArcGIS.Enabled = true;
						radioButtonSortByDefaultArcGISConvertToArcGIS.Enabled = true;
					}
					else
					{
						radioButtonSortByNameArcGISConvertToArcGIS.Enabled = false;
						radioButtonSortByDefaultArcGISConvertToArcGIS.Enabled = false;
					}
				}
				else
				{
					MessageBox.Show(
						@"Table " + listBoxTablesArcGISConvertToArcGIS.SelectedItem + @" contains data and can not be deleted",
						@"Error delete table", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		/// <summary>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnClearDataArcGISTableConvertToArcGIS_Click(object sender, EventArgs e)
		{
			string text = String.Format("Will be deleted all data from table {0}. Are you sure?",
				listBoxTablesArcGISConvertToArcGIS.SelectedItem);
			DialogResult dialogResult = MessageBox.Show(text, @"Clear data from table", MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);
			if (dialogResult == DialogResult.Yes)
			{
				Cursor.Current = Cursors.WaitCursor;
				new WorkArcGIS().ClearDataCurrentTable(listBoxTablesArcGISConvertToArcGIS.SelectedItem.ToString());
				Cursor.Current = Cursors.Default;
				MessageBox.Show("Table has been cleared!");
			}
		}

		/// <summary>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnCreateTableFromGiscuitConvertToArcGIS_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			string geometry =
				WorkGiscuit.GetTableGeometryType(listBoxTablesGiscuitConvertToArcGIS.SelectedItem.ToString());
			var pgTableColumnsDef =
				WorkGiscuit.GetColumnsDefinition(listBoxTablesGiscuitConvertToArcGIS.SelectedItem.ToString());
			CreateTableArcGISForm createTableArcGisForm = new CreateTableArcGISForm(geometry,
				listBoxTablesGiscuitConvertToArcGIS.SelectedItem.ToString(), pgTableColumnsDef);
			createTableArcGisForm.ShowDialog();
			if (createTableArcGisForm.DialogResult == DialogResult.OK)
			{
				Cursor.Current = Cursors.WaitCursor;
				listBoxTablesArcGISConvertToArcGIS.DataSource = new WorkArcGIS().GetTableList();
				textBoxTotalTablesArcGISConvertToArcGIS.Text = listBoxTablesArcGISConvertToArcGIS.Items.Count.ToString();
				Cursor.Current = Cursors.WaitCursor;
				MessageBox.Show("Table has been created!");
			}
		}

		/// <summary>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnAppendConvertToArcGIS_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			WorkArcGIS wokArcGis = new WorkArcGIS();
			wokArcGis.AddNewItemsToTable(listBoxTablesArcGISConvertToArcGIS.SelectedItem.ToString());
			Cursor.Current = Cursors.WaitCursor;
			MessageBox.Show(@"Has been added new rows!", @"Convert complete");
		}

		/// <summary>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void brnOverwriteConvertToArcGIS_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult =
				MessageBox.Show(
					@"Old records in table " + listBoxTablesArcGISConvertToArcGIS.SelectedItem + " will be overwrited. Are you sure?",
					@"Overwrite data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dialogResult == DialogResult.Yes)
			{
				Cursor.Current = Cursors.WaitCursor;
				new WorkArcGIS().ClearDataCurrentTable(listBoxTablesArcGISConvertToArcGIS.SelectedItem.ToString());
				WorkArcGIS wokArcGis = new WorkArcGIS();
				wokArcGis.AddNewItemsToTable(listBoxTablesArcGISConvertToArcGIS.SelectedItem.ToString());
				Cursor.Current = Cursors.Default;
				MessageBox.Show(@"Has been added new rows!", @"Convert complete");
			}
		}

		#endregion


		#region Convert Domains ArcGIS -> PostGIS

		private void btbBrowseFileGDBConvertDoamins_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = folderBrowserDialog1.ShowDialog();
			folderBrowserDialog1.Description = @"Select Geodatabase folder";
			if (dialogResult == DialogResult.OK)
			{
				textBoxGDBLocationConvertDomains.Text = folderBrowserDialog1.SelectedPath;
				Properties.Settings.Default.Save();
			}
		}

		private void btnConvertDomainsRefreshArcGIS_Click(object sender, EventArgs e)
		{
			listBoxConvertDomainsArcGIS.DataSource = new WorkArcGIS().GetDomainList();
			textBoxConvertDomainsTotalTablesArcGIS.Text = listBoxConvertDomainsArcGIS.Items.Count.ToString();
			if (listBoxConvertDomainsArcGIS.Items.Count != 0)
			{
				radioBtnDomainArcGisSortByName.Enabled = true;
				radioBtnDomainArcGisSortDefault.Enabled = true;
			}
			else
			{
				radioBtnDomainArcGisSortByName.Enabled = false;
				radioBtnDomainArcGisSortDefault.Enabled = false;
			}

		}

		private void btnConvertDomainsRefreshGiscuit_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			listBoxConvertDomainsGiscuit.DataSource = WorkGiscuit.GetAllDomainNames();
			textBoxConvertDomainsTotalTablesGiscuit.Text = listBoxConvertDomainsGiscuit.Items.Count.ToString();

			if (listBoxConvertDomainsGiscuit.Items.Count != 0)
			{
				radioBtnConvertDomainPostGisSortByName.Enabled = true;
				radioBtnConvertDomainPostGisSortDefault.Enabled = true;
			}
			else
			{
				radioBtnConvertDomainPostGisSortByName.Enabled = false;
				radioBtnConvertDomainPostGisSortDefault.Enabled = false;
			}
		}

		private void listBoxConvertDomainsArcGIS_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBoxConvertDomainsArcGIS.SelectedItem != null)
			{
				btnConvertDomainsCreateTableGiscuit.Enabled = true;
			}
		}

		private void btnConvertDomainsCreateTableGiscuit_Click(object sender, EventArgs e)
		{
			CreateTableDomainGiscuitForm createTableDomainGiscuit =
				new CreateTableDomainGiscuitForm(listBoxConvertDomainsArcGIS.SelectedItem.ToString());
			createTableDomainGiscuit.ShowDialog();
			if (createTableDomainGiscuit.DialogResult == DialogResult.OK)
			{
				Cursor.Current = Cursors.WaitCursor;
				listBoxConvertDomainsGiscuit.DataSource = WorkGiscuit.GetAllDomainNames();
				textBoxConvertDomainsTotalTablesGiscuit.Text = listBoxConvertDomainsGiscuit.Items.Count.ToString();
				Cursor.Current = Cursors.WaitCursor;
				MessageBox.Show("Table domain created!");
			}
		}

		private void btnInsertRowDomainGiscuit_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			WorkGiscuit.InsertNewRowToDomain(listBoxConvertDomainsArcGIS.SelectedItem.ToString(),
				listBoxConvertDomainsGiscuit.SelectedItem.ToString());
			MessageBox.Show(@"Has been added new data from domain ArcGIS to PostGIS", @"Added new data", MessageBoxButtons.OK,
				MessageBoxIcon.Information);
		}

		private void btnOverwriteRowDomainGiscuit_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult =
				MessageBox.Show(
					@"Old records in table domain " + listBoxConvertDomainsGiscuit.SelectedItem + " will be overwrited. Are you sure?",
					@"Overwrite data domain", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dialogResult == DialogResult.Yes)
			{
				Cursor.Current = Cursors.WaitCursor;
				WorkGiscuit.DeleteTableRecords(listBoxConvertDomainsGiscuit.SelectedItem.ToString());
				WorkGiscuit.InsertNewRowToDomain(listBoxConvertDomainsArcGIS.SelectedItem.ToString(),
					listBoxConvertDomainsGiscuit.SelectedItem.ToString());
				MessageBox.Show(@"Has been added new data from domain ArcGIS to PostGIS", @"Added new data", MessageBoxButtons.OK,
					MessageBoxIcon.Information);
			}
		}

		#endregion

		private void radioBtnDomainArcGisSortByName_CheckedChanged(object sender, EventArgs e)
		{
			if (radioBtnDomainArcGisSortByName.Checked)
			{
				listBoxConvertDomainsArcGIS.DataSource = new WorkArcGIS().GetDomainList().OrderBy(item => item.ToString()).ToList();
			}
		}

		private void radioBtnDomainArcGisSortDefault_CheckedChanged(object sender, EventArgs e)
		{
			if (radioBtnDomainArcGisSortDefault.Checked)
			{
				listBoxConvertDomainsArcGIS.DataSource = new WorkArcGIS().GetDomainList();
			}
		}

		private void radioBtnConvertDomainPostGisSortByName_CheckedChanged(object sender, EventArgs e)
		{
			if (radioBtnConvertDomainPostGisSortByName.Checked)
			{
				Cursor.Current = Cursors.WaitCursor;
				List<object> list = new List<object>();
				for (int i = 0; i < TempListTableGiscuit.DataTable.Rows.Count; i++)
				{
					list.Add(TempListTableGiscuit.DataTable.Rows[i][0]);
				}
				listBoxConvertDomainsGiscuit.DataSource = list.OrderBy(item => item.ToString()).ToList();
			}
		}

		private void radioBtnConvertDomainPostGisSortDefault_CheckedChanged(object sender, EventArgs e)
		{
			if (radioBtnConvertDomainPostGisSortDefault.Checked)
			{
				Cursor.Current = Cursors.WaitCursor;
				List<object> list = new List<object>();
				for (int i = 0; i < TempListTableGiscuit.DataTable.Rows.Count; i++)
				{
					list.Add(TempListTableGiscuit.DataTable.Rows[i][0]);
				}
				listBoxConvertDomainsGiscuit.DataSource = list;
			}
		}

		private void btnOverwriteConvertDomainToArcGIS_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult =
				MessageBox.Show(
					@"Old records in table " + listBoxConvertDomainsFromPostGis.SelectedItem + " will be overwrited. Are you sure?",
					@"Overwrite data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dialogResult == DialogResult.Yes)
			{
				Cursor.Current = Cursors.WaitCursor;

				Domain.CreateArcGisDomain(listBoxConvertDomainsFromPostGis.SelectedItem.ToString());
				
				Cursor.Current = Cursors.Default;
				MessageBox.Show(@"Domain has been overwriten!", @"Domain overwrite complete");
			}
		}

		private void btnRefreshPostGisDomains_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			listBoxConvertDomainsFromPostGis.DataSource = WorkGiscuit.GetAllDomainNames();
			txtBoxFromPostGisDomainsCount.Text = listBoxConvertDomainsFromPostGis.Items.Count.ToString();

			if (listBoxConvertDomainsFromPostGis.Items.Count != 0)
			{
				rdBtnDomainFromPostGisSortByName.Enabled = true;
				rdBtnDomainFromPostGisSortDefault.Enabled = true;
			}
			else
			{
				rdBtnDomainFromPostGisSortByName.Enabled = false;
				rdBtnDomainFromPostGisSortDefault.Enabled = false;
			}
		}

		private void btnRefreshArcGisDomains_Click(object sender, EventArgs e)
		{
			listBoxConvertDomainsToArcGis.DataSource = new WorkArcGIS().GetDomainList();
			txtBoxToArcGisDomainsCount.Text = listBoxConvertDomainsToArcGis.Items.Count.ToString();

			if (listBoxConvertDomainsToArcGis.Items.Count != 0)
			{
				rdBtnDomainToArcGisSortByName.Enabled = true;
				rdBtnDomainToArcGisSortDefault.Enabled = true;
			}
			else
			{
				rdBtnDomainToArcGisSortByName.Enabled = false;
				rdBtnDomainToArcGisSortDefault.Enabled = false;
			}
		}

		private void rdBtnDomainToArcGisSortByName_CheckedChanged(object sender, EventArgs e)
		{
			if (rdBtnDomainToArcGisSortByName.Checked)
			{
				listBoxConvertDomainsToArcGis.DataSource = new WorkArcGIS().GetDomainList().OrderBy(item => item.ToString()).ToList();
			}
		}

		private void rdBtnDomainToArcGisSortDefault_CheckedChanged(object sender, EventArgs e)
		{
			if (rdBtnDomainToArcGisSortDefault.Checked)
			{
				listBoxConvertDomainsToArcGis.DataSource = new WorkArcGIS().GetDomainList();
			}

		}

		private void rdBtnDomainFromPostGisSortByName_CheckedChanged(object sender, EventArgs e)
		{
			if (rdBtnDomainFromPostGisSortByName.Checked)
			{
				Cursor.Current = Cursors.WaitCursor;
				List<object> list = new List<object>();
				for (int i = 0; i < TempListTableGiscuit.DataTable.Rows.Count; i++)
				{
					list.Add(TempListTableGiscuit.DataTable.Rows[i][0]);
				}
				listBoxConvertDomainsFromPostGis.DataSource = list.OrderBy(item => item.ToString()).ToList();
			}
		}

		private void rdBtnDomainFromPostGisSortDefault_CheckedChanged(object sender, EventArgs e)
		{
			if (rdBtnDomainFromPostGisSortDefault.Checked)
			{
				Cursor.Current = Cursors.WaitCursor;
				List<object> list = new List<object>();
				for (int i = 0; i < TempListTableGiscuit.DataTable.Rows.Count; i++)
				{
					list.Add(TempListTableGiscuit.DataTable.Rows[i][0]);
				}
				listBoxConvertDomainsFromPostGis.DataSource = list;
			}
		}
	}
}