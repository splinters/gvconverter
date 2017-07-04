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
using System.Text;
using Npgsql;

namespace GVConverter
{
    public partial class FormMain : Form
    {
        //private Geodatabase _geodatabase;
        string TablesArcGISConvert;
        string TablesGiscuitConvert;
        string pgrowslimit = "100";
        private bool _cancelConvertToGiscuit = false;
        private bool _cancelConvertToArcGIS = false;

        public StringBuilder systemMessages = new StringBuilder("System Messages");

        public FormMain()
        {
            // Добавляем обработчик события - который запустит функцию Reload
            CallBackMy.callbackEventHandler = new CallBackMy.callbackEvent(this.AddSystemMessage);
            CallBackMy.callbackClearHandler = new CallBackMy.callbackClearmessage(this.ClearSystemMessage);

            InitializeComponent();
            labelBackgroubndWorkerConvertToGiscuit.Text = string.Empty;
            labelBackgroubndWorkerCompleteConvertToGiscuit.Text = string.Empty;

            systemMessages.AppendLine();
            systemMessages.AppendLine(">>>>>>>>>>");

            int check = 0;
            bool conn = false;
            
            Connect lf = new Connect();
        
            while ( check < 3 ) {
                lf.ShowDialog(this);

                if (lf.DialogResult == DialogResult.OK)
                {
                    if ( CheckConnection() )
                    {
                        conn = true;
                        break;
                    }
                }
                check++;

            }
            if ( !conn)
            {
                MessageBox.Show("Cannot connect to database "+ Settings.Default.IPSSH+"=>"+ Settings.Default.NameDataBasePostgreSQL, "Attention", 
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            //textBoxLimitRows.Text = pgrowslimit;
            textBoxLimitRows.Text = Settings.Default.pgrowslimit;
            checkBoxArcgis2PostgisWGS.Checked = Settings.Default.Arcgis2PostgisWGS84;
            checkBoxToESPG2039.Checked = Settings.Default.Postgis2ArcgisEPSG2039;
        }

        bool CheckConnection()
        {
            bool result = false;

            var Connection = new NpgsqlConnection(
                $"Server={Settings.Default.IPDataBasePostrgeSQL}; " +
                $"User Id={StaticVariables.LoginDataBasePostgreSQL}; " +
                $"Password={StaticVariables.PasswordDataBasePostgreSQL}; " +
                $"Database={Settings.Default.NameDataBasePostgreSQL};");
            try
            {
                Connection.Open();
                result = true;
            }

            catch (NpgsqlException ex)
            {
                if (ex.Code == "28P01")
                {
                    MessageBox.Show("Invalid password or name..", @"Error connection - ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message.ToString(), @"Error connect - ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString(), @"Error connect - ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection?.Close();
                Connection?.Dispose();
            }

            return result;
        }


        void AddSystemMessage(string param)
        {
            //Здесь чего нибудь делаем.
            //Это непосредственно то что выполнится по событию.
            //MessageBox.Show(param);

            if (Settings.Default.LogMessage)
            {
                if (systemMessages.Length < systemMessages.MaxCapacity)
                {
                    systemMessages.AppendLine(param);
                }
            }
        }

        void ClearSystemMessage(string param)
        {
            //Здесь чего нибудь делаем.
            //Это непосредственно то что выполнится по событию.
            string newStr = String.Empty + param;

            systemMessages.Clear();
            if (newStr.Length == 0)
            {
                systemMessages.AppendLine();
                systemMessages.AppendLine(">>>>>>>>>>");
            }
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

                    systemMessages.AppendLine(dialogResult.FileName + " file was saved!");

                    MessageBox.Show(@"The file was saved!");
                }
                catch (FileGDBException ex)
                {
                    systemMessages.AppendLine(ex.ToString());
                    MessageBox.Show($"{ex.Message} - {ex.ErrorCode}", @"Error exporting domain to XML",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    systemMessages.AppendLine(ex.ToString());
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
                textBoxFieldType.Text   = tmpGetData.Item2;
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
            //textBoxZmin.Text = tmpTableData.Item6;
            //textBoxZmax.Text = tmpTableData.Item7;

            textBoxRecordsArcgis.Text = tmpTableData.Item7;
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
            CallBackMy.callbackEventHandler("called listBoxOfTablesGiscuit_SelectedIndexChanged");
            Cursor.Current = Cursors.WaitCursor;
            DataTable dataTable;
            if (checkBoxPgAllRows.Checked)
            {
                pgrowslimit = "null";
            }
            else
            {
                pgrowslimit = textBoxLimitRows.Text;
            }
            try
            {

                var geometryType = TempListTableGiscuit.DataTable.Select($"table_name = '{listBoxOfTablesGuscuit.SelectedItem}'")[0][1].ToString();
                CallBackMy.callbackEventHandler("listBoxOfTablesGiscuit_SelectedIndexChanged geometrytupe --> " + geometryType.ToString());
                if (string.IsNullOrEmpty(geometryType))
                {
                    CallBackMy.callbackEventHandler("WorkGiscuit.Readtable");
                    dataTable = WorkGiscuit.ReadTable(listBoxOfTablesGuscuit.SelectedItem.ToString(), pgrowslimit); // "null");
                }
                else
                {
                    CallBackMy.callbackEventHandler("WorkGiscuit.ReadtableWithGeometry");
                    dataTable = WorkGiscuit.ReadTableWithGeometry(listBoxOfTablesGuscuit.SelectedItem.ToString(), pgrowslimit);  //"null"
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
                if (! (pgrowslimit == "null"))
                {
                    // добавить вычитку всех записей точечным запросом
                    Int64 pgCountAllRows = WorkGiscuit.GetRecordCount(listBoxOfTablesGuscuit.SelectedItem.ToString());
                    if (pgCountAllRows > Int32.Parse(pgrowslimit))
                    {
                        textBoxTotalRowsGiscuitViewData.Text = dataTable.Rows.Count.ToString() + " from " + pgCountAllRows.ToString();
                    }
                    else
                    {
                        textBoxTotalRowsGiscuitViewData.Text = dataTable.Rows.Count.ToString();
                    }
                } else
                {
                    textBoxTotalRowsGiscuitViewData.Text = dataTable.Rows.Count.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Error reading table data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnSettingsProgramm_Click(object sender, EventArgs e)
        {
            SettingsProgramm settingsProgramm = new SettingsProgramm();
            settingsProgramm.ShowDialog(this);

            //textBoxLimitRows.Text = pgrowslimit;
            textBoxLimitRows.Text = Settings.Default.pgrowslimit;
            checkBoxArcgis2PostgisWGS.Checked = Settings.Default.Arcgis2PostgisWGS84;
            checkBoxToESPG2039.Checked = Settings.Default.Postgis2ArcgisEPSG2039;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Soon there will be a Help", @"Information", MessageBoxButtons.OK,
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
            listBoxTablesGiscuitConvert.DataSource = WorkGiscuit.GetAllTablesWithGeometry();
            textBoxTotalTablesGiscuitConvert.Text = listBoxTablesGiscuitConvert.Items.Count.ToString();
            radioButtonSortByNameGiscuit.Enabled = true;
            radioButtonByDefaultGiscuit.Enabled = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                settingsBackgroundWorkerArcgisToPostgres();
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
            CallBackMy.callbackEventHandler("Refresh data arcgis");
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
            listBoxTablesGiscuitConvertToArcGIS.DataSource = WorkGiscuit.GetAllTablesWithGeometry();
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
            settingsBackgroundWorkerArcgisToPostgres(); // Задаем настройки backgroundWorker для запусмка
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            WorkGiscuit.TransferRowsFromArcGisToGiscuit(TablesArcGISConvert, TablesGiscuitConvert, checkBoxArcgis2PostgisWGS.Checked, ref backgroundWorker1);
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
            if ((backgroundWorker1.IsBusy) && (e.KeyChar == (char)Keys.Escape))
            {
                DialogResult dialogResult = MessageBox.Show(@"This operation will be canceled! Are you sure?", @"Cancel convert",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    backgroundWorker1.WorkerSupportsCancellation = true;
                    backgroundWorker1.CancelAsync();
                }
            }
            if ((backgroundWorkerPostgresToArcgis.IsBusy) && (e.KeyChar == (char)Keys.Escape))
            {
                DialogResult dialogResult = MessageBox.Show(@"This operation will be canceled! Are you sure?", @"Cancel convert",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    backgroundWorkerPostgresToArcgis.WorkerSupportsCancellation = true;
                    backgroundWorkerPostgresToArcgis.CancelAsync();
                }
            }
        }

        private void settingsBackgroundWorkerArcgisToPostgres()
        {
            CallBackMy.callbackEventHandler("settingsBackgroundWorkerArcgisToPostgres");

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
            CallBackMy.callbackEventHandler("Delete table arcgis");
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
            CallBackMy.callbackEventHandler("Clesr data - arcgistableconverttoarcgis");
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
            CallBackMy.callbackEventHandler("CreateTableFromGiscuitConvertToArcGIS");

            Cursor.Current = Cursors.WaitCursor;
            string geometry =
                WorkGiscuit.GetTableGeometryType(listBoxTablesGiscuitConvertToArcGIS.SelectedItem.ToString());
            var pgTableColumnsDef =
                WorkGiscuit.GetColumnsDefinition(listBoxTablesGiscuitConvertToArcGIS.SelectedItem.ToString());

            var srid = (checkBoxToESPG2039.Checked ? "2039" : "4326");
            CreateTableArcGISForm createTableArcGisForm = new CreateTableArcGISForm(geometry,
                listBoxTablesGiscuitConvertToArcGIS.SelectedItem.ToString(), pgTableColumnsDef, srid);
            createTableArcGisForm.ShowDialog();
            if (createTableArcGisForm.DialogResult == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                listBoxTablesArcGISConvertToArcGIS.DataSource = new WorkArcGIS().GetTableList();
                textBoxTotalTablesArcGISConvertToArcGIS.Text = listBoxTablesArcGISConvertToArcGIS.Items.Count.ToString();
                Cursor.Current = Cursors.WaitCursor;
                MessageBox.Show("Table has been created!");

                int index = listBoxConvertDomainsGiscuit.FindString(listBoxTablesGiscuitConvertToArcGIS.SelectedItem.ToString());
                if (index >= 0)
                {
                    //выделяем строку
                    listBoxTablesGiscuitConvertToArcGIS.SetSelected(index, true);
                }

            }
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAppendConvertToArcGIS_Click(object sender, EventArgs e)
        {
            CallBackMy.callbackEventHandler("AppendConvertToArcGIS");

            Cursor.Current = Cursors.WaitCursor;
            settingsBackgroundWorkerPostgresToArcgis();
            backgroundWorkerPostgresToArcgis.RunWorkerAsync();

            /*
            WorkArcGIS wokArcGis = new WorkArcGIS();
			wokArcGis.AddNewItemsToTable(listBoxTablesArcGISConvertToArcGIS.SelectedItem.ToString());
			Cursor.Current = Cursors.WaitCursor;
			MessageBox.Show(@"Has been added new rows!", @"Convert complete");
            */
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void brnOverwriteConvertToArcGIS_Click(object sender, EventArgs e)
        {
            CallBackMy.callbackEventHandler("OverwriteConvertToArcGIS");

            DialogResult dialogResult =
                MessageBox.Show(
                    @"Old records in table " + listBoxTablesArcGISConvertToArcGIS.SelectedItem + " will be overwrited. Are you sure?",
                    @"Overwrite data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                new WorkArcGIS().ClearDataCurrentTable(listBoxTablesArcGISConvertToArcGIS.SelectedItem.ToString());
                settingsBackgroundWorkerPostgresToArcgis();
                backgroundWorkerPostgresToArcgis.RunWorkerAsync();



                //				WorkArcGIS wokArcGis = new WorkArcGIS();
                //				wokArcGis.AddNewItemsToTable(listBoxTablesArcGISConvertToArcGIS.SelectedItem.ToString());
                //				Cursor.Current = Cursors.Default;
                //				MessageBox.Show(@"Has been added new rows!", @"Convert complete");
            }
        }

        private void settingsBackgroundWorkerPostgresToArcgis()
        {
            CallBackMy.callbackEventHandler("settingsBackgroundWorkerPostgresToArcgis");
            tabControlMain.Enabled = false;
            groupBoxPostressToArcgis.Enabled = false;
            /*
                    public static int TotalRowsConvertToArcGIS;
                    public static int CurrentRowConvertToArcGIS;
                    public static int NewRowsAddedToArcGIS;
            */
            StaticVariables.CurrentRowConvertToArcGIS = 0;
            StaticVariables.TotalRowsConvertToArcGIS = 0;
            _cancelConvertToArcGIS = false;
            StaticVariables.ErrorGeometryCount = 0;

            labelPostressToArcgis.ForeColor = Color.Red;
            labelPostressToArcgis.Text = @"For cancel convert press ESC...";
            labelPostressToArcgis.Visible = true;

            progressBarPostgresToArcgis.Visible = true;
            progressBarPostgresToArcgis.Value = 0;

            labelProgressPostressToArcgis.Text = "Rows processed " + StaticVariables.CurrentRowConvertToArcGIS + " of " + StaticVariables.TotalRowsConvertToArcGIS;

            TablesArcGISConvert = listBoxTablesArcGISConvertToArcGIS.SelectedItem.ToString();
            //            TablesGiscuitConvert = listBoxTablesGiscuitConvertToArcGIS.SelectedItem.ToString();

            /*
                        labelBackgroubndWorkerCompleteConvertToGiscuit.ForeColor = Color.Red;
                        labelBackgroubndWorkerCompleteConvertToGiscuit.Text = @"For cancel convert press ESC...";
                        labelBackgroubndWorkerCompleteConvertToGiscuit.Visible = true;
                        progressBarConvertToGiscuit.Visible = true;
                        progressBarConvertToGiscuit.Value = 0;
                        labelBackgroubndWorkerConvertToGiscuit.Text = "Rows processed " + StaticVariables.CurrentRowConvertToArcGIS + " of " +
                                                                      StaticVariables.TotalRowsConvertToArcGIS;
                        TablesArcGISConvert = listBoxTablesArcGISConvert.SelectedItem.ToString();
                        TablesGiscuitConvert = listBoxTablesGiscuitConvert.SelectedItem.ToString();
            */
        }

        private void backgroundWorkerPostgresToArcgis_DoWork(object sender, DoWorkEventArgs e)
        {
            CallBackMy.callbackEventHandler("backgroundWorkerPostgresToArcgis_DoWork");
            //            WorkArcGIS.TransferRowsFromArcGisToGiscuit(TablesArcGISConvert, TablesGiscuitConvert, ref backgroundWorker1);
            WorkArcGIS.AddNewItemsToTable(TablesArcGISConvert, checkBoxToESPG2039.Checked,  ref backgroundWorkerPostgresToArcgis);

            MessageBox.Show(@"Has been added " + StaticVariables.CurrentRowConvertToArcGIS + " new data from Postgres to ArcGIS.\nGeometry error: " + StaticVariables.ErrorGeometryCount,
                @"Added new data", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void backgroundWorkerPostgresToArcgis_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CallBackMy.callbackEventHandler("backgroundWorkerPostgresToArcgis_Completed");
            tabControlMain.Enabled = true;
            groupBoxPostressToArcgis.Enabled = true;
            labelProgressPostressToArcgis.Text = "";
            Cursor.Current = Cursors.Default;

            if (_cancelConvertToArcGIS)
            {
                labelPostressToArcgis.ForeColor = Color.Red;
                labelPostressToArcgis.Text = "Convert cancelled...";
                //                labelPostressToArcgis.Visible = true;
            }
            else
            {
                labelPostressToArcgis.ForeColor = Color.Green;
                labelPostressToArcgis.Text = "Convert completed...";
            }
        }
        private void backgroundWorkerPostgresToArcgis_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //            CallBackMy.callbackEventHandler("backgroundWorkerPostgresToArcgis_ProgressChanged");
            if (!backgroundWorkerPostgresToArcgis.CancellationPending)
            {
                progressBarPostgresToArcgis.Minimum = 0;
                progressBarPostgresToArcgis.Maximum = StaticVariables.TotalRowsConvertToArcGIS;
                progressBarPostgresToArcgis.Value = e.ProgressPercentage;
                labelProgressPostressToArcgis.Text = "Rows processed " + StaticVariables.CurrentRowConvertToArcGIS + " of " + StaticVariables.TotalRowsConvertToArcGIS;

            }
            else
            {
                CallBackMy.callbackEventHandler("backgroundWorkerPostgresToArcgis  - cancelled command");
                _cancelConvertToArcGIS = true;
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
            if ((listBoxConvertDomainsArcGIS.SelectedItem != null) && (listBoxConvertDomainsGiscuit.SelectedItem != null))
            {
                if (listBoxConvertDomainsArcGIS.SelectedItem.ToString() == listBoxConvertDomainsGiscuit.SelectedItem.ToString())
                {
                    btnInsertRowDomainGiscuit.Enabled = true;
                    btnOverwriteRowDomainGiscuit.Enabled = true;
                }
                else
                {
                    btnInsertRowDomainGiscuit.Enabled = false;
                    btnOverwriteRowDomainGiscuit.Enabled = false;
                }
            }
        }


        private void btnConvertDomainsCreateTableGiscuit_Click(object sender, EventArgs e)
        {
            CallBackMy.callbackEventHandler("Create Table for domain from arcgis into postgres");
            CreateTableDomainGiscuitForm createTableDomainGiscuit =
                new CreateTableDomainGiscuitForm(listBoxConvertDomainsArcGIS.SelectedItem.ToString());
            createTableDomainGiscuit.ShowDialog();
            if (createTableDomainGiscuit.DialogResult == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;

               var tmpGetData = new WorkArcGIS().GetDataForCurrentDomain(listBoxConvertDomainsArcGIS.SelectedItem.ToString());
               var codeType = tmpGetData.Item2;


                WorkGiscuit.CreateNewDomainTable(listBoxConvertDomainsArcGIS.SelectedItem.ToString(), codeType);  //здесь нужно анализировать тип домена аркгис
                
                listBoxConvertDomainsGiscuit.DataSource = WorkGiscuit.GetAllDomainNames();
                textBoxConvertDomainsTotalTablesGiscuit.Text = listBoxConvertDomainsGiscuit.Items.Count.ToString();

                int index = listBoxConvertDomainsGiscuit.FindString(listBoxConvertDomainsArcGIS.SelectedItem.ToString());
                if (index >= 0)
                {
                    //выделяем строку
                    listBoxConvertDomainsGiscuit.SetSelected(index, true);
                }

                Cursor.Current = Cursors.WaitCursor;
                MessageBox.Show("Table domain created!");
            }
        }

        private void btnInsertRowDomainGiscuit_Click(object sender, EventArgs e)
        {
            CallBackMy.callbackEventHandler("Insert data domain from arcgis into postgres");

            Cursor.Current = Cursors.WaitCursor;
            WorkGiscuit.InsertNewRowToDomain(listBoxConvertDomainsArcGIS.SelectedItem.ToString(),
                listBoxConvertDomainsGiscuit.SelectedItem.ToString());
            MessageBox.Show(@"Has been added new data from domain ArcGIS to PostGIS", @"Added new data", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnOverwriteRowDomainGiscuit_Click(object sender, EventArgs e)
        {
            CallBackMy.callbackEventHandler("Overwrite data domain from arcgis into postgres");
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

        #region Domain Postgres To Arcgis

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
            CallBackMy.callbackEventHandler("Create/overwrite domain from postgres into arcgis...");
            DialogResult dialogResult =
                MessageBox.Show(
                    @"Old records in table " + listBoxConvertDomainsFromPostGis.SelectedItem + " will be overwrited. Are you sure?",
                    @"Overwrite data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                Cursor.Current = Cursors.WaitCursor;
                string domaintype = WorkGiscuit.GetTableDomainType(listBoxConvertDomainsFromPostGis.SelectedItem.ToString());
                CallBackMy.callbackEventHandler("Domain type "+domaintype);
                Domain.CreateArcGisDomain(listBoxConvertDomainsFromPostGis.SelectedItem.ToString(), domaintype);

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

//                if (listBoxConvertDomainsToArcGis.Items.Count != 0)
                btnOverwriteConvertDomainToArcGIS.Enabled = true;
            }
            else
            {
                rdBtnDomainFromPostGisSortByName.Enabled = false;
                rdBtnDomainFromPostGisSortDefault.Enabled = false;
                btnOverwriteConvertDomainToArcGIS.Enabled = false;
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

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //добавление домена в аркгис
            /* проверить не пуст ли с
             */
            DialogResult dialogResult =
                MessageBox.Show(
                    @"Old records in table " + listBoxConvertDomainsFromPostGis.SelectedItem + " will be overwrited. Are you sure?",
                    @"Overwrite data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                Cursor.Current = Cursors.WaitCursor;
                string domaintype = WorkGiscuit.GetTableDomainType(listBoxConvertDomainsFromPostGis.SelectedItem.ToString());
                //создать или перезаписать домен
                Domain.CreateArcGisDomain(listBoxConvertDomainsFromPostGis.SelectedItem.ToString(), domaintype);

                Cursor.Current = Cursors.Default;
                MessageBox.Show(@"Domain has been overwriten!", @"Domain overwrite complete");
            }
        }

        private void listBoxConvertDomainsGiscuit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxConvertDomainsArcGIS.SelectedItem != null)
            {
                btnConvertDomainsCreateTableGiscuit.Enabled = true;
            }
            if ((listBoxConvertDomainsArcGIS.SelectedItem) != null && (listBoxConvertDomainsGiscuit.SelectedItem) != null)
            {
                if (listBoxConvertDomainsArcGIS.SelectedItem.ToString() == listBoxConvertDomainsGiscuit.SelectedItem.ToString())
                {
                    btnInsertRowDomainGiscuit.Enabled = true;
                    btnOverwriteRowDomainGiscuit.Enabled = true;
                }
                else
                {
                    btnInsertRowDomainGiscuit.Enabled = false;
                    btnOverwriteRowDomainGiscuit.Enabled = false;
                }
            }
        }

        #endregion

        private void buttonSystemMessages_Click(object sender, EventArgs e)
        {
            var messageform = new messageWindow();

            //            systemMessages.AppendFormat(Environment.NewLine+"sv");
            //            systemMessages.AppendLine();
            messageform.textBoxSystemMessages.Text = systemMessages.ToString();

            //            messageform.textBoxSystemMessages.Text = systemMessages.ToString();

            messageform.ShowDialog();
        }

        private void listBoxConvertDomainsFromPostGis_TabIndexChanged(object sender, EventArgs e)
        {
            if (listBoxConvertDomainsFromPostGis.SelectedItem != null)
            {
                btnOverwriteConvertDomainToArcGIS.Enabled = true;
            }
            else
            {
                btnOverwriteConvertDomainToArcGIS.Enabled = false;
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void tabControlMain_Selected(object sender, TabControlEventArgs e)
        {
            // CallBackMy.callbackEventHandler("tabControl - Selected");
        }



        private void textBoxLimitRows_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }

            }
        }

        private void checkBoxPgAllRows_CheckStateChanged(object sender, EventArgs e)
        {
            switch (checkBoxPgAllRows.CheckState)
            {
                case CheckState.Checked:
                    textBoxLimitRows.Text = "";
                    pgrowslimit = "null";
                    textBoxLimitRows.Enabled = false;
                    break;
                case CheckState.Unchecked:
                    textBoxLimitRows.Text = "100";
                    pgrowslimit = textBoxLimitRows.Text;
                    textBoxLimitRows.Enabled = true;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.
                    break;
            }
        }
    }
}