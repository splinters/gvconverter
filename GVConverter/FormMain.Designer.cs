namespace GVConverter
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.groupBoxLocationDB = new System.Windows.Forms.GroupBox();
			this.btnArcGISBrowseFolder = new System.Windows.Forms.Button();
			this.btnGetDataArcGISViewData = new System.Windows.Forms.Button();
			this.textBoxLocationFolderGDB = new System.Windows.Forms.TextBox();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.listBoxOfDomainsViewData = new System.Windows.Forms.ListBox();
			this.Domains = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxDescription = new System.Windows.Forms.TextBox();
			this.textBoxSplitPolicy = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxMergePolicy = new System.Windows.Forms.TextBox();
			this.textBoxFieldType = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnExportDomainToXML = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridViewDomains = new System.Windows.Forms.DataGridView();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageTables = new System.Windows.Forms.TabPage();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.listBoxOfTablesArcGISViewData = new System.Windows.Forms.ListBox();
			this.label7 = new System.Windows.Forms.Label();
			this.dataGridViewTablesArcGISViewData = new System.Windows.Forms.DataGridView();
			this.label8 = new System.Windows.Forms.Label();
			this.textBoxZmax = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.textBoxZmin = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.textBoxXmin = new System.Windows.Forms.TextBox();
			this.textBoxXmax = new System.Windows.Forms.TextBox();
			this.textBoxYmax = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.textBoxYmin = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.tabPageDomains = new System.Windows.Forms.TabPage();
			this.splitContainer3 = new System.Windows.Forms.SplitContainer();
			this.groupBoxData = new System.Windows.Forms.GroupBox();
			this.tabControlMain = new System.Windows.Forms.TabControl();
			this.tabPageArcGIS = new System.Windows.Forms.TabPage();
			this.tabPageGiscuit = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBoxTotalRowsGiscuitViewData = new System.Windows.Forms.TextBox();
			this.label32 = new System.Windows.Forms.Label();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.label16 = new System.Windows.Forms.Label();
			this.listBoxOfTablesGuscuit = new System.Windows.Forms.ListBox();
			this.dataGridViewGiscuitViewData = new System.Windows.Forms.DataGridView();
			this.label17 = new System.Windows.Forms.Label();
			this.btnGetDataGiscuitViewData = new System.Windows.Forms.Button();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.splitContainer4 = new System.Windows.Forms.SplitContainer();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.btbBrowseConvertTab = new System.Windows.Forms.Button();
			this.textBoxGDBLocation = new System.Windows.Forms.TextBox();
			this.radioButtonByDefaultArcGIS = new System.Windows.Forms.RadioButton();
			this.label23 = new System.Windows.Forms.Label();
			this.radioButtonSortByNameArcGIS = new System.Windows.Forms.RadioButton();
			this.label21 = new System.Windows.Forms.Label();
			this.textBoxTotalTablesArcGISConvert = new System.Windows.Forms.TextBox();
			this.textBoxTypeShapeArcGISConvert = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.listBoxTablesArcGISConvert = new System.Windows.Forms.ListBox();
			this.btnGetTablesArcGISConvert = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnClearDataGiscuitTable = new System.Windows.Forms.Button();
			this.radioButtonByDefaultGiscuit = new System.Windows.Forms.RadioButton();
			this.radioButtonSortByNameGiscuit = new System.Windows.Forms.RadioButton();
			this.label24 = new System.Windows.Forms.Label();
			this.btnDeleteTableGiscuit = new System.Windows.Forms.Button();
			this.textBoxTotalTablesGiscuitConvert = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.btnCreateTableFromArcGISConvert = new System.Windows.Forms.Button();
			this.textBoxTypeShapeGiscuitConvert = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.listBoxTablesGiscuitConvert = new System.Windows.Forms.ListBox();
			this.btnGetTablesGiscuitConvert = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.labelBackgroubndWorkerCompleteConvertToGiscuit = new System.Windows.Forms.Label();
			this.labelBackgroubndWorkerConvertToGiscuit = new System.Windows.Forms.Label();
			this.progressBarConvertToGiscuit = new System.Windows.Forms.ProgressBar();
			this.btnConvertOverwriteData = new System.Windows.Forms.Button();
			this.label18 = new System.Windows.Forms.Label();
			this.btnRunConvertArcGISToGiscuit = new System.Windows.Forms.Button();
			this.tabPageConvertDomainsToPostgis = new System.Windows.Forms.TabPage();
			this.groupBox13 = new System.Windows.Forms.GroupBox();
			this.btnOverwriteRowDomainGiscuit = new System.Windows.Forms.Button();
			this.btnInsertRowDomainGiscuit = new System.Windows.Forms.Button();
			this.splitContainer6 = new System.Windows.Forms.SplitContainer();
			this.groupBox10 = new System.Windows.Forms.GroupBox();
			this.radioBtnDomainArcGisSortDefault = new System.Windows.Forms.RadioButton();
			this.radioBtnDomainArcGisSortByName = new System.Windows.Forms.RadioButton();
			this.label33 = new System.Windows.Forms.Label();
			this.groupBox11 = new System.Windows.Forms.GroupBox();
			this.btbBrowseFileGDBConvertDoamins = new System.Windows.Forms.Button();
			this.textBoxGDBLocationConvertDomains = new System.Windows.Forms.TextBox();
			this.label34 = new System.Windows.Forms.Label();
			this.textBoxConvertDomainsTotalTablesArcGIS = new System.Windows.Forms.TextBox();
			this.listBoxConvertDomainsArcGIS = new System.Windows.Forms.ListBox();
			this.btnConvertDomainsRefreshArcGIS = new System.Windows.Forms.Button();
			this.groupBox12 = new System.Windows.Forms.GroupBox();
			this.radioBtnConvertDomainPostGisSortDefault = new System.Windows.Forms.RadioButton();
			this.radioBtnConvertDomainPostGisSortByName = new System.Windows.Forms.RadioButton();
			this.label35 = new System.Windows.Forms.Label();
			this.textBoxConvertDomainsTotalTablesGiscuit = new System.Windows.Forms.TextBox();
			this.label37 = new System.Windows.Forms.Label();
			this.btnConvertDomainsCreateTableGiscuit = new System.Windows.Forms.Button();
			this.listBoxConvertDomainsGiscuit = new System.Windows.Forms.ListBox();
			this.btnConvertDomainsRefreshGiscuit = new System.Windows.Forms.Button();
			this.tabPageConvertToArcGIS = new System.Windows.Forms.TabPage();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.brnOverwriteConvertToArcGIS = new System.Windows.Forms.Button();
			this.label25 = new System.Windows.Forms.Label();
			this.btnAppendConvertToArcGIS = new System.Windows.Forms.Button();
			this.splitContainer5 = new System.Windows.Forms.SplitContainer();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.radioButtonSortByDefaultGiscuitConvertToArcGIS = new System.Windows.Forms.RadioButton();
			this.radioButtonSortByNameGiscuitConvertToArcGIS = new System.Windows.Forms.RadioButton();
			this.label26 = new System.Windows.Forms.Label();
			this.textBoxTotalTablesGiscuitConvertToAcrGIS = new System.Windows.Forms.TextBox();
			this.label27 = new System.Windows.Forms.Label();
			this.textBoxTypeShapeGiscuitConvertToArcGIS = new System.Windows.Forms.TextBox();
			this.label28 = new System.Windows.Forms.Label();
			this.listBoxTablesGiscuitConvertToArcGIS = new System.Windows.Forms.ListBox();
			this.btnGetDataGiscuitConvertToArcGIS = new System.Windows.Forms.Button();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.btnClearDataArcGISTableConvertToArcGIS = new System.Windows.Forms.Button();
			this.groupBox9 = new System.Windows.Forms.GroupBox();
			this.btbBrowseFileGDBConvertToArcGIS = new System.Windows.Forms.Button();
			this.textBoxGDBLocationConvertToArcGIS = new System.Windows.Forms.TextBox();
			this.radioButtonSortByDefaultArcGISConvertToArcGIS = new System.Windows.Forms.RadioButton();
			this.btnDeleteTableArcGISConvetToArcGIS = new System.Windows.Forms.Button();
			this.label29 = new System.Windows.Forms.Label();
			this.radioButtonSortByNameArcGISConvertToArcGIS = new System.Windows.Forms.RadioButton();
			this.label30 = new System.Windows.Forms.Label();
			this.textBoxTotalTablesArcGISConvertToArcGIS = new System.Windows.Forms.TextBox();
			this.textBoxTypeShapeArcGISConvertToArcGIS = new System.Windows.Forms.TextBox();
			this.btnCreateTableFromGiscuitConvertToArcGIS = new System.Windows.Forms.Button();
			this.label31 = new System.Windows.Forms.Label();
			this.listBoxTablesArcGISConvertToArcGIS = new System.Windows.Forms.ListBox();
			this.btnGetTablesArcGISConvertToAcrGIS = new System.Windows.Forms.Button();
			this.tabPageConvertDomainsToArcGIS = new System.Windows.Forms.TabPage();
			this.groupBox14 = new System.Windows.Forms.GroupBox();
			this.btnOverwriteConvertDomainToArcGIS = new System.Windows.Forms.Button();
			this.label36 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.splitContainer7 = new System.Windows.Forms.SplitContainer();
			this.groupBox15 = new System.Windows.Forms.GroupBox();
			this.rdBtnDomainFromPostGisSortDefault = new System.Windows.Forms.RadioButton();
			this.rdBtnDomainFromPostGisSortByName = new System.Windows.Forms.RadioButton();
			this.label38 = new System.Windows.Forms.Label();
			this.txtBoxFromPostGisDomainsCount = new System.Windows.Forms.TextBox();
			this.label39 = new System.Windows.Forms.Label();
			this.listBoxConvertDomainsFromPostGis = new System.Windows.Forms.ListBox();
			this.btnRefreshPostGisDomains = new System.Windows.Forms.Button();
			this.groupBox16 = new System.Windows.Forms.GroupBox();
			this.groupBox17 = new System.Windows.Forms.GroupBox();
			this.button6 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.rdBtnDomainToArcGisSortDefault = new System.Windows.Forms.RadioButton();
			this.label41 = new System.Windows.Forms.Label();
			this.rdBtnDomainToArcGisSortByName = new System.Windows.Forms.RadioButton();
			this.label42 = new System.Windows.Forms.Label();
			this.txtBoxToArcGisDomainsCount = new System.Windows.Forms.TextBox();
			this.listBoxConvertDomainsToArcGis = new System.Windows.Forms.ListBox();
			this.btnRefreshArcGisDomains = new System.Windows.Forms.Button();
			this.splitContainerMain = new System.Windows.Forms.SplitContainer();
			this.button1 = new System.Windows.Forms.Button();
			this.btnHelp = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnSettingsProgramm = new System.Windows.Forms.Button();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.groupBoxLocationDB.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDomains)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPageTables.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablesArcGISViewData)).BeginInit();
			this.tabPageDomains.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
			this.splitContainer3.Panel1.SuspendLayout();
			this.splitContainer3.Panel2.SuspendLayout();
			this.splitContainer3.SuspendLayout();
			this.groupBoxData.SuspendLayout();
			this.tabControlMain.SuspendLayout();
			this.tabPageArcGIS.SuspendLayout();
			this.tabPageGiscuit.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewGiscuitViewData)).BeginInit();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
			this.splitContainer4.Panel1.SuspendLayout();
			this.splitContainer4.Panel2.SuspendLayout();
			this.splitContainer4.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.tabPageConvertDomainsToPostgis.SuspendLayout();
			this.groupBox13.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
			this.splitContainer6.Panel1.SuspendLayout();
			this.splitContainer6.Panel2.SuspendLayout();
			this.splitContainer6.SuspendLayout();
			this.groupBox10.SuspendLayout();
			this.groupBox11.SuspendLayout();
			this.groupBox12.SuspendLayout();
			this.tabPageConvertToArcGIS.SuspendLayout();
			this.groupBox6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
			this.splitContainer5.Panel1.SuspendLayout();
			this.splitContainer5.Panel2.SuspendLayout();
			this.splitContainer5.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupBox8.SuspendLayout();
			this.groupBox9.SuspendLayout();
			this.tabPageConvertDomainsToArcGIS.SuspendLayout();
			this.groupBox14.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
			this.splitContainer7.Panel1.SuspendLayout();
			this.splitContainer7.Panel2.SuspendLayout();
			this.splitContainer7.SuspendLayout();
			this.groupBox15.SuspendLayout();
			this.groupBox16.SuspendLayout();
			this.groupBox17.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
			this.splitContainerMain.Panel1.SuspendLayout();
			this.splitContainerMain.Panel2.SuspendLayout();
			this.splitContainerMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxLocationDB
			// 
			this.groupBoxLocationDB.Controls.Add(this.btnArcGISBrowseFolder);
			this.groupBoxLocationDB.Controls.Add(this.btnGetDataArcGISViewData);
			this.groupBoxLocationDB.Controls.Add(this.textBoxLocationFolderGDB);
			this.groupBoxLocationDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBoxLocationDB.Location = new System.Drawing.Point(8, 8);
			this.groupBoxLocationDB.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.groupBoxLocationDB.Name = "groupBoxLocationDB";
			this.groupBoxLocationDB.Size = new System.Drawing.Size(893, 77);
			this.groupBoxLocationDB.TabIndex = 0;
			this.groupBoxLocationDB.TabStop = false;
			this.groupBoxLocationDB.Text = "Geodatabase (gdb) location";
			// 
			// btnArcGISBrowseFolder
			// 
			this.btnArcGISBrowseFolder.Location = new System.Drawing.Point(807, 16);
			this.btnArcGISBrowseFolder.Name = "btnArcGISBrowseFolder";
			this.btnArcGISBrowseFolder.Size = new System.Drawing.Size(75, 23);
			this.btnArcGISBrowseFolder.TabIndex = 3;
			this.btnArcGISBrowseFolder.Text = "Browse...";
			this.btnArcGISBrowseFolder.UseVisualStyleBackColor = true;
			this.btnArcGISBrowseFolder.Click += new System.EventHandler(this.btnArcGISBrowseFolder_Click);
			// 
			// btnGetDataArcGISViewData
			// 
			this.btnGetDataArcGISViewData.Location = new System.Drawing.Point(9, 45);
			this.btnGetDataArcGISViewData.Name = "btnGetDataArcGISViewData";
			this.btnGetDataArcGISViewData.Size = new System.Drawing.Size(75, 23);
			this.btnGetDataArcGISViewData.TabIndex = 2;
			this.btnGetDataArcGISViewData.Text = "Get data";
			this.btnGetDataArcGISViewData.UseVisualStyleBackColor = true;
			this.btnGetDataArcGISViewData.Click += new System.EventHandler(this.btnGetData_Click);
			// 
			// textBoxLocationFolderGDB
			// 
			this.textBoxLocationFolderGDB.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.textBoxLocationFolderGDB.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GVConverter.Properties.Settings.Default, "PathToGDBFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textBoxLocationFolderGDB.Location = new System.Drawing.Point(9, 19);
			this.textBoxLocationFolderGDB.Name = "textBoxLocationFolderGDB";
			this.textBoxLocationFolderGDB.ReadOnly = true;
			this.textBoxLocationFolderGDB.Size = new System.Drawing.Size(792, 20);
			this.textBoxLocationFolderGDB.TabIndex = 0;
			this.textBoxLocationFolderGDB.Text = global::GVConverter.Properties.Settings.Default.PathToGDBFolder;
			// 
			// listBoxOfDomainsViewData
			// 
			this.listBoxOfDomainsViewData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBoxOfDomainsViewData.FormattingEnabled = true;
			this.listBoxOfDomainsViewData.Location = new System.Drawing.Point(0, 0);
			this.listBoxOfDomainsViewData.Name = "listBoxOfDomainsViewData";
			this.listBoxOfDomainsViewData.Size = new System.Drawing.Size(166, 399);
			this.listBoxOfDomainsViewData.Sorted = true;
			this.listBoxOfDomainsViewData.TabIndex = 1;
			this.listBoxOfDomainsViewData.SelectedIndexChanged += new System.EventHandler(this.listBoxOfDomains_SelectedIndexChanged);
			// 
			// Domains
			// 
			this.Domains.AutoSize = true;
			this.Domains.Location = new System.Drawing.Point(0, 0);
			this.Domains.Name = "Domains";
			this.Domains.Size = new System.Drawing.Size(48, 13);
			this.Domains.TabIndex = 0;
			this.Domains.Text = "Domains";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 82);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(70, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "CodedValues";
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.Location = new System.Drawing.Point(352, 45);
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.ReadOnly = true;
			this.textBoxDescription.Size = new System.Drawing.Size(204, 20);
			this.textBoxDescription.TabIndex = 11;
			// 
			// textBoxSplitPolicy
			// 
			this.textBoxSplitPolicy.Location = new System.Drawing.Point(63, 45);
			this.textBoxSplitPolicy.Name = "textBoxSplitPolicy";
			this.textBoxSplitPolicy.ReadOnly = true;
			this.textBoxSplitPolicy.Size = new System.Drawing.Size(212, 20);
			this.textBoxSplitPolicy.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(281, 48);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Description";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "SplitPolicy";
			// 
			// textBoxMergePolicy
			// 
			this.textBoxMergePolicy.Location = new System.Drawing.Point(352, 18);
			this.textBoxMergePolicy.Name = "textBoxMergePolicy";
			this.textBoxMergePolicy.ReadOnly = true;
			this.textBoxMergePolicy.Size = new System.Drawing.Size(204, 20);
			this.textBoxMergePolicy.TabIndex = 7;
			// 
			// textBoxFieldType
			// 
			this.textBoxFieldType.Location = new System.Drawing.Point(63, 18);
			this.textBoxFieldType.Name = "textBoxFieldType";
			this.textBoxFieldType.ReadOnly = true;
			this.textBoxFieldType.Size = new System.Drawing.Size(212, 20);
			this.textBoxFieldType.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(281, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "MergePolicy";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "FieldType";
			// 
			// btnExportDomainToXML
			// 
			this.btnExportDomainToXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnExportDomainToXML.Enabled = false;
			this.btnExportDomainToXML.Location = new System.Drawing.Point(6, 368);
			this.btnExportDomainToXML.Name = "btnExportDomainToXML";
			this.btnExportDomainToXML.Size = new System.Drawing.Size(106, 23);
			this.btnExportDomainToXML.TabIndex = 3;
			this.btnExportDomainToXML.Text = "Export to XML...";
			this.btnExportDomainToXML.UseVisualStyleBackColor = true;
			this.btnExportDomainToXML.Click += new System.EventHandler(this.btnExportDomainToXML_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Parameters";
			// 
			// dataGridViewDomains
			// 
			this.dataGridViewDomains.AllowUserToAddRows = false;
			this.dataGridViewDomains.AllowUserToDeleteRows = false;
			this.dataGridViewDomains.AllowUserToResizeRows = false;
			this.dataGridViewDomains.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewDomains.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewDomains.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewDomains.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewDomains.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewDomains.Location = new System.Drawing.Point(6, 98);
			this.dataGridViewDomains.Name = "dataGridViewDomains";
			this.dataGridViewDomains.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewDomains.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewDomains.Size = new System.Drawing.Size(862, 264);
			this.dataGridViewDomains.TabIndex = 0;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageTables);
			this.tabControl1.Controls.Add(this.tabPageDomains);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(3, 16);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1057, 431);
			this.tabControl1.TabIndex = 2;
			// 
			// tabPageTables
			// 
			this.tabPageTables.Controls.Add(this.splitContainer1);
			this.tabPageTables.Location = new System.Drawing.Point(4, 22);
			this.tabPageTables.Name = "tabPageTables";
			this.tabPageTables.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.tabPageTables.Size = new System.Drawing.Size(1049, 405);
			this.tabPageTables.TabIndex = 1;
			this.tabPageTables.Text = "Tables";
			this.tabPageTables.UseVisualStyleBackColor = true;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(3, 3);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.listBoxOfTablesArcGISViewData);
			this.splitContainer1.Panel1.Controls.Add(this.label7);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.dataGridViewTablesArcGISViewData);
			this.splitContainer1.Panel2.Controls.Add(this.label8);
			this.splitContainer1.Panel2.Controls.Add(this.textBoxZmax);
			this.splitContainer1.Panel2.Controls.Add(this.label13);
			this.splitContainer1.Panel2.Controls.Add(this.textBoxZmin);
			this.splitContainer1.Panel2.Controls.Add(this.label12);
			this.splitContainer1.Panel2.Controls.Add(this.label14);
			this.splitContainer1.Panel2.Controls.Add(this.label11);
			this.splitContainer1.Panel2.Controls.Add(this.label15);
			this.splitContainer1.Panel2.Controls.Add(this.textBoxXmin);
			this.splitContainer1.Panel2.Controls.Add(this.textBoxXmax);
			this.splitContainer1.Panel2.Controls.Add(this.textBoxYmax);
			this.splitContainer1.Panel2.Controls.Add(this.label10);
			this.splitContainer1.Panel2.Controls.Add(this.textBoxYmin);
			this.splitContainer1.Panel2.Controls.Add(this.label9);
			this.splitContainer1.Size = new System.Drawing.Size(1043, 399);
			this.splitContainer1.SplitterDistance = 156;
			this.splitContainer1.TabIndex = 3;
			// 
			// listBoxOfTablesArcGISViewData
			// 
			this.listBoxOfTablesArcGISViewData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBoxOfTablesArcGISViewData.FormattingEnabled = true;
			this.listBoxOfTablesArcGISViewData.Location = new System.Drawing.Point(0, 0);
			this.listBoxOfTablesArcGISViewData.Name = "listBoxOfTablesArcGISViewData";
			this.listBoxOfTablesArcGISViewData.Size = new System.Drawing.Size(156, 399);
			this.listBoxOfTablesArcGISViewData.Sorted = true;
			this.listBoxOfTablesArcGISViewData.TabIndex = 1;
			this.listBoxOfTablesArcGISViewData.SelectedIndexChanged += new System.EventHandler(this.listBoxOfTables_SelectedIndexChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(0, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(39, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "Tables";
			// 
			// dataGridViewTablesArcGISViewData
			// 
			this.dataGridViewTablesArcGISViewData.AllowUserToAddRows = false;
			this.dataGridViewTablesArcGISViewData.AllowUserToDeleteRows = false;
			this.dataGridViewTablesArcGISViewData.AllowUserToResizeRows = false;
			this.dataGridViewTablesArcGISViewData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewTablesArcGISViewData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTablesArcGISViewData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridViewTablesArcGISViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTablesArcGISViewData.DefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridViewTablesArcGISViewData.Location = new System.Drawing.Point(6, 122);
			this.dataGridViewTablesArcGISViewData.Name = "dataGridViewTablesArcGISViewData";
			this.dataGridViewTablesArcGISViewData.ReadOnly = true;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTablesArcGISViewData.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridViewTablesArcGISViewData.Size = new System.Drawing.Size(813, 268);
			this.dataGridViewTablesArcGISViewData.TabIndex = 0;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(3, 106);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(39, 13);
			this.label8.TabIndex = 12;
			this.label8.Text = "Values";
			// 
			// textBoxZmax
			// 
			this.textBoxZmax.Location = new System.Drawing.Point(319, 70);
			this.textBoxZmax.Name = "textBoxZmax";
			this.textBoxZmax.ReadOnly = true;
			this.textBoxZmax.Size = new System.Drawing.Size(204, 20);
			this.textBoxZmax.TabIndex = 16;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(3, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(37, 13);
			this.label13.TabIndex = 2;
			this.label13.Text = "Extent";
			// 
			// textBoxZmin
			// 
			this.textBoxZmin.Location = new System.Drawing.Point(38, 70);
			this.textBoxZmin.Name = "textBoxZmin";
			this.textBoxZmin.ReadOnly = true;
			this.textBoxZmin.Size = new System.Drawing.Size(212, 20);
			this.textBoxZmin.TabIndex = 15;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(3, 20);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(29, 13);
			this.label12.TabIndex = 4;
			this.label12.Text = "xMin";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(281, 73);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(32, 13);
			this.label14.TabIndex = 14;
			this.label14.Text = "zMax";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Location = new System.Drawing.Point(281, 20);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(32, 13);
			this.label11.TabIndex = 5;
			this.label11.Text = "xMax";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(3, 73);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(29, 13);
			this.label15.TabIndex = 13;
			this.label15.Text = "zMin";
			// 
			// textBoxXmin
			// 
			this.textBoxXmin.Location = new System.Drawing.Point(38, 17);
			this.textBoxXmin.Name = "textBoxXmin";
			this.textBoxXmin.ReadOnly = true;
			this.textBoxXmin.Size = new System.Drawing.Size(212, 20);
			this.textBoxXmin.TabIndex = 6;
			// 
			// textBoxXmax
			// 
			this.textBoxXmax.Location = new System.Drawing.Point(319, 18);
			this.textBoxXmax.Name = "textBoxXmax";
			this.textBoxXmax.ReadOnly = true;
			this.textBoxXmax.Size = new System.Drawing.Size(204, 20);
			this.textBoxXmax.TabIndex = 7;
			// 
			// textBoxYmax
			// 
			this.textBoxYmax.Location = new System.Drawing.Point(319, 44);
			this.textBoxYmax.Name = "textBoxYmax";
			this.textBoxYmax.ReadOnly = true;
			this.textBoxYmax.Size = new System.Drawing.Size(204, 20);
			this.textBoxYmax.TabIndex = 11;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(3, 47);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(29, 13);
			this.label10.TabIndex = 8;
			this.label10.Text = "yMin";
			// 
			// textBoxYmin
			// 
			this.textBoxYmin.Location = new System.Drawing.Point(38, 44);
			this.textBoxYmin.Name = "textBoxYmin";
			this.textBoxYmin.ReadOnly = true;
			this.textBoxYmin.Size = new System.Drawing.Size(212, 20);
			this.textBoxYmin.TabIndex = 10;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(281, 47);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(32, 13);
			this.label9.TabIndex = 9;
			this.label9.Text = "yMax";
			// 
			// tabPageDomains
			// 
			this.tabPageDomains.Controls.Add(this.splitContainer3);
			this.tabPageDomains.Location = new System.Drawing.Point(4, 22);
			this.tabPageDomains.Margin = new System.Windows.Forms.Padding(50, 50, 3, 3);
			this.tabPageDomains.Name = "tabPageDomains";
			this.tabPageDomains.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.tabPageDomains.Size = new System.Drawing.Size(1049, 405);
			this.tabPageDomains.TabIndex = 0;
			this.tabPageDomains.Text = "Domains";
			this.tabPageDomains.UseVisualStyleBackColor = true;
			// 
			// splitContainer3
			// 
			this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer3.Location = new System.Drawing.Point(3, 3);
			this.splitContainer3.Name = "splitContainer3";
			// 
			// splitContainer3.Panel1
			// 
			this.splitContainer3.Panel1.Controls.Add(this.listBoxOfDomainsViewData);
			this.splitContainer3.Panel1.Controls.Add(this.Domains);
			// 
			// splitContainer3.Panel2
			// 
			this.splitContainer3.Panel2.Controls.Add(this.btnExportDomainToXML);
			this.splitContainer3.Panel2.Controls.Add(this.label6);
			this.splitContainer3.Panel2.Controls.Add(this.dataGridViewDomains);
			this.splitContainer3.Panel2.Controls.Add(this.label1);
			this.splitContainer3.Panel2.Controls.Add(this.textBoxDescription);
			this.splitContainer3.Panel2.Controls.Add(this.label2);
			this.splitContainer3.Panel2.Controls.Add(this.textBoxSplitPolicy);
			this.splitContainer3.Panel2.Controls.Add(this.label3);
			this.splitContainer3.Panel2.Controls.Add(this.label5);
			this.splitContainer3.Panel2.Controls.Add(this.textBoxFieldType);
			this.splitContainer3.Panel2.Controls.Add(this.label4);
			this.splitContainer3.Panel2.Controls.Add(this.textBoxMergePolicy);
			this.splitContainer3.Size = new System.Drawing.Size(1043, 399);
			this.splitContainer3.SplitterDistance = 166;
			this.splitContainer3.TabIndex = 2;
			// 
			// groupBoxData
			// 
			this.groupBoxData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxData.Controls.Add(this.tabControl1);
			this.groupBoxData.Location = new System.Drawing.Point(8, 93);
			this.groupBoxData.Name = "groupBoxData";
			this.groupBoxData.Size = new System.Drawing.Size(1063, 450);
			this.groupBoxData.TabIndex = 3;
			this.groupBoxData.TabStop = false;
			this.groupBoxData.Text = "Getting data";
			// 
			// tabControlMain
			// 
			this.tabControlMain.Controls.Add(this.tabPageArcGIS);
			this.tabControlMain.Controls.Add(this.tabPageGiscuit);
			this.tabControlMain.Controls.Add(this.tabPage1);
			this.tabControlMain.Controls.Add(this.tabPageConvertDomainsToPostgis);
			this.tabControlMain.Controls.Add(this.tabPageConvertToArcGIS);
			this.tabControlMain.Controls.Add(this.tabPageConvertDomainsToArcGIS);
			this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlMain.Location = new System.Drawing.Point(0, 0);
			this.tabControlMain.Name = "tabControlMain";
			this.tabControlMain.SelectedIndex = 0;
			this.tabControlMain.Size = new System.Drawing.Size(1157, 572);
			this.tabControlMain.TabIndex = 4;
			// 
			// tabPageArcGIS
			// 
			this.tabPageArcGIS.Controls.Add(this.groupBoxData);
			this.tabPageArcGIS.Controls.Add(this.groupBoxLocationDB);
			this.tabPageArcGIS.Location = new System.Drawing.Point(4, 22);
			this.tabPageArcGIS.Name = "tabPageArcGIS";
			this.tabPageArcGIS.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.tabPageArcGIS.Size = new System.Drawing.Size(1149, 546);
			this.tabPageArcGIS.TabIndex = 0;
			this.tabPageArcGIS.Text = "ArcGIS View data";
			this.tabPageArcGIS.UseVisualStyleBackColor = true;
			// 
			// tabPageGiscuit
			// 
			this.tabPageGiscuit.Controls.Add(this.groupBox1);
			this.tabPageGiscuit.Location = new System.Drawing.Point(4, 22);
			this.tabPageGiscuit.Name = "tabPageGiscuit";
			this.tabPageGiscuit.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.tabPageGiscuit.Size = new System.Drawing.Size(1149, 546);
			this.tabPageGiscuit.TabIndex = 1;
			this.tabPageGiscuit.Text = "PostGIS View data";
			this.tabPageGiscuit.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.textBoxTotalRowsGiscuitViewData);
			this.groupBox1.Controls.Add(this.label32);
			this.groupBox1.Controls.Add(this.splitContainer2);
			this.groupBox1.Controls.Add(this.btnGetDataGiscuitViewData);
			this.groupBox1.Location = new System.Drawing.Point(7, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1135, 537);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Data from PostGIS";
			// 
			// textBoxTotalRowsGiscuitViewData
			// 
			this.textBoxTotalRowsGiscuitViewData.Location = new System.Drawing.Point(277, 22);
			this.textBoxTotalRowsGiscuitViewData.Name = "textBoxTotalRowsGiscuitViewData";
			this.textBoxTotalRowsGiscuitViewData.ReadOnly = true;
			this.textBoxTotalRowsGiscuitViewData.Size = new System.Drawing.Size(100, 20);
			this.textBoxTotalRowsGiscuitViewData.TabIndex = 6;
			// 
			// label32
			// 
			this.label32.AutoSize = true;
			this.label32.Location = new System.Drawing.Point(215, 25);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(56, 13);
			this.label32.TabIndex = 4;
			this.label32.Text = "Total rows";
			// 
			// splitContainer2
			// 
			this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer2.Location = new System.Drawing.Point(7, 49);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.label16);
			this.splitContainer2.Panel1.Controls.Add(this.listBoxOfTablesGuscuit);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.dataGridViewGiscuitViewData);
			this.splitContainer2.Panel2.Controls.Add(this.label17);
			this.splitContainer2.Size = new System.Drawing.Size(1122, 482);
			this.splitContainer2.SplitterDistance = 201;
			this.splitContainer2.TabIndex = 3;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(3, 0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(39, 13);
			this.label16.TabIndex = 2;
			this.label16.Text = "Tables";
			// 
			// listBoxOfTablesGuscuit
			// 
			this.listBoxOfTablesGuscuit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxOfTablesGuscuit.FormattingEnabled = true;
			this.listBoxOfTablesGuscuit.Location = new System.Drawing.Point(6, 16);
			this.listBoxOfTablesGuscuit.Name = "listBoxOfTablesGuscuit";
			this.listBoxOfTablesGuscuit.Size = new System.Drawing.Size(192, 446);
			this.listBoxOfTablesGuscuit.Sorted = true;
			this.listBoxOfTablesGuscuit.TabIndex = 1;
			this.listBoxOfTablesGuscuit.SelectedIndexChanged += new System.EventHandler(this.listBoxOfTablesGiscuit_SelectedIndexChanged);
			// 
			// dataGridViewGiscuitViewData
			// 
			this.dataGridViewGiscuitViewData.AllowUserToAddRows = false;
			this.dataGridViewGiscuitViewData.AllowUserToDeleteRows = false;
			this.dataGridViewGiscuitViewData.AllowUserToResizeRows = false;
			this.dataGridViewGiscuitViewData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewGiscuitViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewGiscuitViewData.Location = new System.Drawing.Point(6, 16);
			this.dataGridViewGiscuitViewData.Name = "dataGridViewGiscuitViewData";
			this.dataGridViewGiscuitViewData.Size = new System.Drawing.Size(902, 480);
			this.dataGridViewGiscuitViewData.TabIndex = 4;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(3, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(30, 13);
			this.label17.TabIndex = 3;
			this.label17.Text = "Data";
			// 
			// btnGetDataGiscuitViewData
			// 
			this.btnGetDataGiscuitViewData.Location = new System.Drawing.Point(7, 20);
			this.btnGetDataGiscuitViewData.Name = "btnGetDataGiscuitViewData";
			this.btnGetDataGiscuitViewData.Size = new System.Drawing.Size(75, 23);
			this.btnGetDataGiscuitViewData.TabIndex = 0;
			this.btnGetDataGiscuitViewData.Text = "Get data";
			this.btnGetDataGiscuitViewData.UseVisualStyleBackColor = true;
			this.btnGetDataGiscuitViewData.Click += new System.EventHandler(this.btnGetDataGiscuit_Click);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.splitContainer4);
			this.tabPage1.Controls.Add(this.groupBox4);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.tabPage1.Size = new System.Drawing.Size(1149, 546);
			this.tabPage1.TabIndex = 2;
			this.tabPage1.Text = "Convert ArcGIS -> PostGIS";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// splitContainer4
			// 
			this.splitContainer4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer4.Location = new System.Drawing.Point(6, 6);
			this.splitContainer4.Name = "splitContainer4";
			// 
			// splitContainer4.Panel1
			// 
			this.splitContainer4.Panel1.Controls.Add(this.groupBox2);
			// 
			// splitContainer4.Panel2
			// 
			this.splitContainer4.Panel2.Controls.Add(this.groupBox3);
			this.splitContainer4.Size = new System.Drawing.Size(1130, 438);
			this.splitContainer4.SplitterDistance = 552;
			this.splitContainer4.TabIndex = 3;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.groupBox5);
			this.groupBox2.Controls.Add(this.radioButtonByDefaultArcGIS);
			this.groupBox2.Controls.Add(this.label23);
			this.groupBox2.Controls.Add(this.radioButtonSortByNameArcGIS);
			this.groupBox2.Controls.Add(this.label21);
			this.groupBox2.Controls.Add(this.textBoxTotalTablesArcGISConvert);
			this.groupBox2.Controls.Add(this.textBoxTypeShapeArcGISConvert);
			this.groupBox2.Controls.Add(this.label19);
			this.groupBox2.Controls.Add(this.listBoxTablesArcGISConvert);
			this.groupBox2.Controls.Add(this.btnGetTablesArcGISConvert);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(0, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(552, 438);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "ArcGIS - Source";
			// 
			// groupBox5
			// 
			this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox5.Controls.Add(this.btbBrowseConvertTab);
			this.groupBox5.Controls.Add(this.textBoxGDBLocation);
			this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox5.Location = new System.Drawing.Point(7, 19);
			this.groupBox5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(538, 51);
			this.groupBox5.TabIndex = 4;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Geodatabase (gdb) location";
			// 
			// btbBrowseConvertTab
			// 
			this.btbBrowseConvertTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btbBrowseConvertTab.Location = new System.Drawing.Point(457, 17);
			this.btbBrowseConvertTab.Name = "btbBrowseConvertTab";
			this.btbBrowseConvertTab.Size = new System.Drawing.Size(75, 23);
			this.btbBrowseConvertTab.TabIndex = 3;
			this.btbBrowseConvertTab.Text = "Browse...";
			this.btbBrowseConvertTab.UseVisualStyleBackColor = true;
			this.btbBrowseConvertTab.Click += new System.EventHandler(this.btbBrowseConvertTab_Click);
			// 
			// textBoxGDBLocation
			// 
			this.textBoxGDBLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxGDBLocation.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.textBoxGDBLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GVConverter.Properties.Settings.Default, "PathToGDBFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textBoxGDBLocation.Location = new System.Drawing.Point(9, 19);
			this.textBoxGDBLocation.Name = "textBoxGDBLocation";
			this.textBoxGDBLocation.ReadOnly = true;
			this.textBoxGDBLocation.Size = new System.Drawing.Size(442, 20);
			this.textBoxGDBLocation.TabIndex = 0;
			this.textBoxGDBLocation.Text = global::GVConverter.Properties.Settings.Default.PathToGDBFolder;
			// 
			// radioButtonByDefaultArcGIS
			// 
			this.radioButtonByDefaultArcGIS.AutoSize = true;
			this.radioButtonByDefaultArcGIS.Enabled = false;
			this.radioButtonByDefaultArcGIS.Location = new System.Drawing.Point(112, 104);
			this.radioButtonByDefaultArcGIS.Name = "radioButtonByDefaultArcGIS";
			this.radioButtonByDefaultArcGIS.Size = new System.Drawing.Size(59, 17);
			this.radioButtonByDefaultArcGIS.TabIndex = 8;
			this.radioButtonByDefaultArcGIS.TabStop = true;
			this.radioButtonByDefaultArcGIS.Text = "Default";
			this.radioButtonByDefaultArcGIS.UseVisualStyleBackColor = true;
			this.radioButtonByDefaultArcGIS.CheckedChanged += new System.EventHandler(this.radioButtonByDefaultArcGIS_CheckedChanged);
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(4, 106);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(43, 13);
			this.label23.TabIndex = 6;
			this.label23.Text = "Sort by:";
			// 
			// radioButtonSortByNameArcGIS
			// 
			this.radioButtonSortByNameArcGIS.AutoSize = true;
			this.radioButtonSortByNameArcGIS.Enabled = false;
			this.radioButtonSortByNameArcGIS.Location = new System.Drawing.Point(53, 104);
			this.radioButtonSortByNameArcGIS.Name = "radioButtonSortByNameArcGIS";
			this.radioButtonSortByNameArcGIS.Size = new System.Drawing.Size(53, 17);
			this.radioButtonSortByNameArcGIS.TabIndex = 7;
			this.radioButtonSortByNameArcGIS.TabStop = true;
			this.radioButtonSortByNameArcGIS.Text = "Name";
			this.radioButtonSortByNameArcGIS.UseVisualStyleBackColor = true;
			this.radioButtonSortByNameArcGIS.CheckedChanged += new System.EventHandler(this.radioButtonSortByNameArcGIS_CheckedChanged);
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(295, 83);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(62, 13);
			this.label21.TabIndex = 5;
			this.label21.Text = "Total tables";
			// 
			// textBoxTotalTablesArcGISConvert
			// 
			this.textBoxTotalTablesArcGISConvert.Location = new System.Drawing.Point(363, 80);
			this.textBoxTotalTablesArcGISConvert.Name = "textBoxTotalTablesArcGISConvert";
			this.textBoxTotalTablesArcGISConvert.ReadOnly = true;
			this.textBoxTotalTablesArcGISConvert.Size = new System.Drawing.Size(100, 20);
			this.textBoxTotalTablesArcGISConvert.TabIndex = 4;
			// 
			// textBoxTypeShapeArcGISConvert
			// 
			this.textBoxTypeShapeArcGISConvert.Location = new System.Drawing.Point(159, 80);
			this.textBoxTypeShapeArcGISConvert.Name = "textBoxTypeShapeArcGISConvert";
			this.textBoxTypeShapeArcGISConvert.ReadOnly = true;
			this.textBoxTypeShapeArcGISConvert.Size = new System.Drawing.Size(130, 20);
			this.textBoxTypeShapeArcGISConvert.TabIndex = 3;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(90, 83);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(63, 13);
			this.label19.TabIndex = 2;
			this.label19.Text = "Type shape";
			// 
			// listBoxTablesArcGISConvert
			// 
			this.listBoxTablesArcGISConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxTablesArcGISConvert.FormattingEnabled = true;
			this.listBoxTablesArcGISConvert.Location = new System.Drawing.Point(7, 127);
			this.listBoxTablesArcGISConvert.Name = "listBoxTablesArcGISConvert";
			this.listBoxTablesArcGISConvert.Size = new System.Drawing.Size(538, 290);
			this.listBoxTablesArcGISConvert.TabIndex = 1;
			this.listBoxTablesArcGISConvert.SelectedIndexChanged += new System.EventHandler(this.listBoxTablesArcGIS_SelectedIndexChanged);
			// 
			// btnGetTablesArcGISConvert
			// 
			this.btnGetTablesArcGISConvert.Location = new System.Drawing.Point(7, 78);
			this.btnGetTablesArcGISConvert.Name = "btnGetTablesArcGISConvert";
			this.btnGetTablesArcGISConvert.Size = new System.Drawing.Size(75, 23);
			this.btnGetTablesArcGISConvert.TabIndex = 0;
			this.btnGetTablesArcGISConvert.Text = "Refresh";
			this.btnGetTablesArcGISConvert.UseVisualStyleBackColor = true;
			this.btnGetTablesArcGISConvert.Click += new System.EventHandler(this.btnGetTablesArcGIS_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnClearDataGiscuitTable);
			this.groupBox3.Controls.Add(this.radioButtonByDefaultGiscuit);
			this.groupBox3.Controls.Add(this.radioButtonSortByNameGiscuit);
			this.groupBox3.Controls.Add(this.label24);
			this.groupBox3.Controls.Add(this.btnDeleteTableGiscuit);
			this.groupBox3.Controls.Add(this.textBoxTotalTablesGiscuitConvert);
			this.groupBox3.Controls.Add(this.label22);
			this.groupBox3.Controls.Add(this.btnCreateTableFromArcGISConvert);
			this.groupBox3.Controls.Add(this.textBoxTypeShapeGiscuitConvert);
			this.groupBox3.Controls.Add(this.label20);
			this.groupBox3.Controls.Add(this.listBoxTablesGiscuitConvert);
			this.groupBox3.Controls.Add(this.btnGetTablesGiscuitConvert);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Location = new System.Drawing.Point(0, 0);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(574, 438);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "PostGIS - Destination";
			// 
			// btnClearDataGiscuitTable
			// 
			this.btnClearDataGiscuitTable.Enabled = false;
			this.btnClearDataGiscuitTable.Location = new System.Drawing.Point(100, 19);
			this.btnClearDataGiscuitTable.Name = "btnClearDataGiscuitTable";
			this.btnClearDataGiscuitTable.Size = new System.Drawing.Size(75, 23);
			this.btnClearDataGiscuitTable.TabIndex = 10;
			this.btnClearDataGiscuitTable.Text = "Clear data";
			this.btnClearDataGiscuitTable.UseVisualStyleBackColor = true;
			this.btnClearDataGiscuitTable.Click += new System.EventHandler(this.btnClearDataGiscuitTable_Click);
			// 
			// radioButtonByDefaultGiscuit
			// 
			this.radioButtonByDefaultGiscuit.AutoSize = true;
			this.radioButtonByDefaultGiscuit.Enabled = false;
			this.radioButtonByDefaultGiscuit.Location = new System.Drawing.Point(114, 47);
			this.radioButtonByDefaultGiscuit.Name = "radioButtonByDefaultGiscuit";
			this.radioButtonByDefaultGiscuit.Size = new System.Drawing.Size(59, 17);
			this.radioButtonByDefaultGiscuit.TabIndex = 9;
			this.radioButtonByDefaultGiscuit.TabStop = true;
			this.radioButtonByDefaultGiscuit.Text = "Default";
			this.radioButtonByDefaultGiscuit.UseVisualStyleBackColor = true;
			this.radioButtonByDefaultGiscuit.CheckedChanged += new System.EventHandler(this.radioButtonByDefaultGiscuit_CheckedChanged);
			// 
			// radioButtonSortByNameGiscuit
			// 
			this.radioButtonSortByNameGiscuit.AutoSize = true;
			this.radioButtonSortByNameGiscuit.Enabled = false;
			this.radioButtonSortByNameGiscuit.Location = new System.Drawing.Point(55, 47);
			this.radioButtonSortByNameGiscuit.Name = "radioButtonSortByNameGiscuit";
			this.radioButtonSortByNameGiscuit.Size = new System.Drawing.Size(53, 17);
			this.radioButtonSortByNameGiscuit.TabIndex = 9;
			this.radioButtonSortByNameGiscuit.TabStop = true;
			this.radioButtonSortByNameGiscuit.Text = "Name";
			this.radioButtonSortByNameGiscuit.UseVisualStyleBackColor = true;
			this.radioButtonSortByNameGiscuit.CheckedChanged += new System.EventHandler(this.radioButtonSortByNameGiscuit_CheckedChanged);
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(6, 49);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(43, 13);
			this.label24.TabIndex = 9;
			this.label24.Text = "Sort by:";
			// 
			// btnDeleteTableGiscuit
			// 
			this.btnDeleteTableGiscuit.Enabled = false;
			this.btnDeleteTableGiscuit.Location = new System.Drawing.Point(181, 19);
			this.btnDeleteTableGiscuit.Name = "btnDeleteTableGiscuit";
			this.btnDeleteTableGiscuit.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteTableGiscuit.TabIndex = 8;
			this.btnDeleteTableGiscuit.Text = "Delete table";
			this.btnDeleteTableGiscuit.UseVisualStyleBackColor = true;
			this.btnDeleteTableGiscuit.Click += new System.EventHandler(this.btnDeleteTableGiscuit_Click);
			// 
			// textBoxTotalTablesGiscuitConvert
			// 
			this.textBoxTotalTablesGiscuitConvert.Location = new System.Drawing.Point(505, 46);
			this.textBoxTotalTablesGiscuitConvert.Name = "textBoxTotalTablesGiscuitConvert";
			this.textBoxTotalTablesGiscuitConvert.ReadOnly = true;
			this.textBoxTotalTablesGiscuitConvert.Size = new System.Drawing.Size(50, 20);
			this.textBoxTotalTablesGiscuitConvert.TabIndex = 7;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(437, 49);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(62, 13);
			this.label22.TabIndex = 6;
			this.label22.Text = "Total tables";
			// 
			// btnCreateTableFromArcGISConvert
			// 
			this.btnCreateTableFromArcGISConvert.Enabled = false;
			this.btnCreateTableFromArcGISConvert.Location = new System.Drawing.Point(7, 19);
			this.btnCreateTableFromArcGISConvert.Name = "btnCreateTableFromArcGISConvert";
			this.btnCreateTableFromArcGISConvert.Size = new System.Drawing.Size(87, 23);
			this.btnCreateTableFromArcGISConvert.TabIndex = 5;
			this.btnCreateTableFromArcGISConvert.Text = "Create table...";
			this.btnCreateTableFromArcGISConvert.UseVisualStyleBackColor = true;
			this.btnCreateTableFromArcGISConvert.Click += new System.EventHandler(this.btnCreateTableFromArcGIS_Click);
			// 
			// textBoxTypeShapeGiscuitConvert
			// 
			this.textBoxTypeShapeGiscuitConvert.Location = new System.Drawing.Point(331, 46);
			this.textBoxTypeShapeGiscuitConvert.Name = "textBoxTypeShapeGiscuitConvert";
			this.textBoxTypeShapeGiscuitConvert.ReadOnly = true;
			this.textBoxTypeShapeGiscuitConvert.Size = new System.Drawing.Size(100, 20);
			this.textBoxTypeShapeGiscuitConvert.TabIndex = 4;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(262, 49);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(63, 13);
			this.label20.TabIndex = 3;
			this.label20.Text = "Type shape";
			// 
			// listBoxTablesGiscuitConvert
			// 
			this.listBoxTablesGiscuitConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxTablesGiscuitConvert.FormattingEnabled = true;
			this.listBoxTablesGiscuitConvert.Location = new System.Drawing.Point(6, 75);
			this.listBoxTablesGiscuitConvert.Name = "listBoxTablesGiscuitConvert";
			this.listBoxTablesGiscuitConvert.Size = new System.Drawing.Size(560, 342);
			this.listBoxTablesGiscuitConvert.TabIndex = 1;
			this.listBoxTablesGiscuitConvert.SelectedIndexChanged += new System.EventHandler(this.listBoxTablesGiscuit_SelectedIndexChanged);
			// 
			// btnGetTablesGiscuitConvert
			// 
			this.btnGetTablesGiscuitConvert.Location = new System.Drawing.Point(262, 19);
			this.btnGetTablesGiscuitConvert.Name = "btnGetTablesGiscuitConvert";
			this.btnGetTablesGiscuitConvert.Size = new System.Drawing.Size(75, 23);
			this.btnGetTablesGiscuitConvert.TabIndex = 0;
			this.btnGetTablesGiscuitConvert.Text = "Refresh";
			this.btnGetTablesGiscuitConvert.UseVisualStyleBackColor = true;
			this.btnGetTablesGiscuitConvert.Click += new System.EventHandler(this.getTablesGiscuit_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox4.Controls.Add(this.labelBackgroubndWorkerCompleteConvertToGiscuit);
			this.groupBox4.Controls.Add(this.labelBackgroubndWorkerConvertToGiscuit);
			this.groupBox4.Controls.Add(this.progressBarConvertToGiscuit);
			this.groupBox4.Controls.Add(this.btnConvertOverwriteData);
			this.groupBox4.Controls.Add(this.label18);
			this.groupBox4.Controls.Add(this.btnRunConvertArcGISToGiscuit);
			this.groupBox4.Location = new System.Drawing.Point(6, 450);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(1130, 68);
			this.groupBox4.TabIndex = 2;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Convert data from ArcGIS to PostGIS";
			// 
			// labelBackgroubndWorkerCompleteConvertToGiscuit
			// 
			this.labelBackgroubndWorkerCompleteConvertToGiscuit.AutoSize = true;
			this.labelBackgroubndWorkerCompleteConvertToGiscuit.Location = new System.Drawing.Point(902, 41);
			this.labelBackgroubndWorkerCompleteConvertToGiscuit.Name = "labelBackgroubndWorkerCompleteConvertToGiscuit";
			this.labelBackgroubndWorkerCompleteConvertToGiscuit.Size = new System.Drawing.Size(254, 13);
			this.labelBackgroubndWorkerCompleteConvertToGiscuit.TabIndex = 12;
			this.labelBackgroubndWorkerCompleteConvertToGiscuit.Text = "labelBackgroubndWorkerCompleteConvertToGiscuit";
			this.labelBackgroubndWorkerCompleteConvertToGiscuit.Visible = false;
			// 
			// labelBackgroubndWorkerConvertToGiscuit
			// 
			this.labelBackgroubndWorkerConvertToGiscuit.AutoSize = true;
			this.labelBackgroubndWorkerConvertToGiscuit.Location = new System.Drawing.Point(227, 17);
			this.labelBackgroubndWorkerConvertToGiscuit.Name = "labelBackgroubndWorkerConvertToGiscuit";
			this.labelBackgroubndWorkerConvertToGiscuit.Size = new System.Drawing.Size(210, 13);
			this.labelBackgroubndWorkerConvertToGiscuit.TabIndex = 11;
			this.labelBackgroubndWorkerConvertToGiscuit.Text = "labelBackgroubndWorkerConvertToGiscuit";
			// 
			// progressBarConvertToGiscuit
			// 
			this.progressBarConvertToGiscuit.Location = new System.Drawing.Point(227, 36);
			this.progressBarConvertToGiscuit.Name = "progressBarConvertToGiscuit";
			this.progressBarConvertToGiscuit.Size = new System.Drawing.Size(669, 23);
			this.progressBarConvertToGiscuit.TabIndex = 10;
			this.progressBarConvertToGiscuit.Visible = false;
			// 
			// btnConvertOverwriteData
			// 
			this.btnConvertOverwriteData.Enabled = false;
			this.btnConvertOverwriteData.Location = new System.Drawing.Point(87, 36);
			this.btnConvertOverwriteData.Name = "btnConvertOverwriteData";
			this.btnConvertOverwriteData.Size = new System.Drawing.Size(75, 23);
			this.btnConvertOverwriteData.TabIndex = 2;
			this.btnConvertOverwriteData.Text = "Overwrite";
			this.btnConvertOverwriteData.UseVisualStyleBackColor = true;
			this.btnConvertOverwriteData.Click += new System.EventHandler(this.btnConvertOverwriteData_Click);
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(6, 20);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(29, 13);
			this.label18.TabIndex = 1;
			this.label18.Text = "label";
			// 
			// btnRunConvertArcGISToGiscuit
			// 
			this.btnRunConvertArcGISToGiscuit.Enabled = false;
			this.btnRunConvertArcGISToGiscuit.Location = new System.Drawing.Point(6, 36);
			this.btnRunConvertArcGISToGiscuit.Name = "btnRunConvertArcGISToGiscuit";
			this.btnRunConvertArcGISToGiscuit.Size = new System.Drawing.Size(75, 23);
			this.btnRunConvertArcGISToGiscuit.TabIndex = 0;
			this.btnRunConvertArcGISToGiscuit.Text = "Append";
			this.btnRunConvertArcGISToGiscuit.UseVisualStyleBackColor = true;
			this.btnRunConvertArcGISToGiscuit.Click += new System.EventHandler(this.btnRunConvertArcGISToGiscuit_Click);
			// 
			// tabPageConvertDomainsToPostgis
			// 
			this.tabPageConvertDomainsToPostgis.Controls.Add(this.groupBox13);
			this.tabPageConvertDomainsToPostgis.Controls.Add(this.splitContainer6);
			this.tabPageConvertDomainsToPostgis.Location = new System.Drawing.Point(4, 22);
			this.tabPageConvertDomainsToPostgis.Name = "tabPageConvertDomainsToPostgis";
			this.tabPageConvertDomainsToPostgis.Size = new System.Drawing.Size(1149, 546);
			this.tabPageConvertDomainsToPostgis.TabIndex = 4;
			this.tabPageConvertDomainsToPostgis.Text = "Convert Domains ArcGIS -> PostGIS";
			this.tabPageConvertDomainsToPostgis.UseVisualStyleBackColor = true;
			// 
			// groupBox13
			// 
			this.groupBox13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox13.Controls.Add(this.btnOverwriteRowDomainGiscuit);
			this.groupBox13.Controls.Add(this.btnInsertRowDomainGiscuit);
			this.groupBox13.Location = new System.Drawing.Point(5, 471);
			this.groupBox13.Name = "groupBox13";
			this.groupBox13.Size = new System.Drawing.Size(1130, 68);
			this.groupBox13.TabIndex = 3;
			this.groupBox13.TabStop = false;
			this.groupBox13.Text = "Convert domain from ArcGIS to PostGIS";
			// 
			// btnOverwriteRowDomainGiscuit
			// 
			this.btnOverwriteRowDomainGiscuit.Location = new System.Drawing.Point(87, 36);
			this.btnOverwriteRowDomainGiscuit.Name = "btnOverwriteRowDomainGiscuit";
			this.btnOverwriteRowDomainGiscuit.Size = new System.Drawing.Size(75, 23);
			this.btnOverwriteRowDomainGiscuit.TabIndex = 2;
			this.btnOverwriteRowDomainGiscuit.Text = "Overwrite";
			this.btnOverwriteRowDomainGiscuit.UseVisualStyleBackColor = true;
			this.btnOverwriteRowDomainGiscuit.Click += new System.EventHandler(this.btnOverwriteRowDomainGiscuit_Click);
			// 
			// btnInsertRowDomainGiscuit
			// 
			this.btnInsertRowDomainGiscuit.Location = new System.Drawing.Point(6, 36);
			this.btnInsertRowDomainGiscuit.Name = "btnInsertRowDomainGiscuit";
			this.btnInsertRowDomainGiscuit.Size = new System.Drawing.Size(75, 23);
			this.btnInsertRowDomainGiscuit.TabIndex = 0;
			this.btnInsertRowDomainGiscuit.Text = "Append";
			this.btnInsertRowDomainGiscuit.UseVisualStyleBackColor = true;
			this.btnInsertRowDomainGiscuit.Click += new System.EventHandler(this.btnInsertRowDomainGiscuit_Click);
			// 
			// splitContainer6
			// 
			this.splitContainer6.Location = new System.Drawing.Point(5, 3);
			this.splitContainer6.Name = "splitContainer6";
			// 
			// splitContainer6.Panel1
			// 
			this.splitContainer6.Panel1.Controls.Add(this.groupBox10);
			// 
			// splitContainer6.Panel2
			// 
			this.splitContainer6.Panel2.Controls.Add(this.groupBox12);
			this.splitContainer6.Size = new System.Drawing.Size(1130, 462);
			this.splitContainer6.SplitterDistance = 536;
			this.splitContainer6.TabIndex = 0;
			// 
			// groupBox10
			// 
			this.groupBox10.Controls.Add(this.radioBtnDomainArcGisSortDefault);
			this.groupBox10.Controls.Add(this.radioBtnDomainArcGisSortByName);
			this.groupBox10.Controls.Add(this.label33);
			this.groupBox10.Controls.Add(this.groupBox11);
			this.groupBox10.Controls.Add(this.label34);
			this.groupBox10.Controls.Add(this.textBoxConvertDomainsTotalTablesArcGIS);
			this.groupBox10.Controls.Add(this.listBoxConvertDomainsArcGIS);
			this.groupBox10.Controls.Add(this.btnConvertDomainsRefreshArcGIS);
			this.groupBox10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox10.Location = new System.Drawing.Point(0, 0);
			this.groupBox10.Name = "groupBox10";
			this.groupBox10.Size = new System.Drawing.Size(536, 462);
			this.groupBox10.TabIndex = 1;
			this.groupBox10.TabStop = false;
			this.groupBox10.Text = "ArcGIS - Source";
			// 
			// radioBtnDomainArcGisSortDefault
			// 
			this.radioBtnDomainArcGisSortDefault.AutoSize = true;
			this.radioBtnDomainArcGisSortDefault.Enabled = false;
			this.radioBtnDomainArcGisSortDefault.Location = new System.Drawing.Point(115, 107);
			this.radioBtnDomainArcGisSortDefault.Name = "radioBtnDomainArcGisSortDefault";
			this.radioBtnDomainArcGisSortDefault.Size = new System.Drawing.Size(59, 17);
			this.radioBtnDomainArcGisSortDefault.TabIndex = 10;
			this.radioBtnDomainArcGisSortDefault.TabStop = true;
			this.radioBtnDomainArcGisSortDefault.Text = "Default";
			this.radioBtnDomainArcGisSortDefault.UseVisualStyleBackColor = true;
			this.radioBtnDomainArcGisSortDefault.CheckedChanged += new System.EventHandler(this.radioBtnDomainArcGisSortDefault_CheckedChanged);
			// 
			// radioBtnDomainArcGisSortByName
			// 
			this.radioBtnDomainArcGisSortByName.AutoSize = true;
			this.radioBtnDomainArcGisSortByName.Enabled = false;
			this.radioBtnDomainArcGisSortByName.Location = new System.Drawing.Point(56, 107);
			this.radioBtnDomainArcGisSortByName.Name = "radioBtnDomainArcGisSortByName";
			this.radioBtnDomainArcGisSortByName.Size = new System.Drawing.Size(53, 17);
			this.radioBtnDomainArcGisSortByName.TabIndex = 11;
			this.radioBtnDomainArcGisSortByName.TabStop = true;
			this.radioBtnDomainArcGisSortByName.Text = "Name";
			this.radioBtnDomainArcGisSortByName.UseVisualStyleBackColor = true;
			this.radioBtnDomainArcGisSortByName.CheckedChanged += new System.EventHandler(this.radioBtnDomainArcGisSortByName_CheckedChanged);
			// 
			// label33
			// 
			this.label33.AutoSize = true;
			this.label33.Location = new System.Drawing.Point(7, 109);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(43, 13);
			this.label33.TabIndex = 12;
			this.label33.Text = "Sort by:";
			// 
			// groupBox11
			// 
			this.groupBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox11.Controls.Add(this.btbBrowseFileGDBConvertDoamins);
			this.groupBox11.Controls.Add(this.textBoxGDBLocationConvertDomains);
			this.groupBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox11.Location = new System.Drawing.Point(7, 19);
			this.groupBox11.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.groupBox11.Name = "groupBox11";
			this.groupBox11.Size = new System.Drawing.Size(523, 51);
			this.groupBox11.TabIndex = 4;
			this.groupBox11.TabStop = false;
			this.groupBox11.Text = "Geodatabase (gdb) location";
			// 
			// btbBrowseFileGDBConvertDoamins
			// 
			this.btbBrowseFileGDBConvertDoamins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btbBrowseFileGDBConvertDoamins.Location = new System.Drawing.Point(442, 17);
			this.btbBrowseFileGDBConvertDoamins.Name = "btbBrowseFileGDBConvertDoamins";
			this.btbBrowseFileGDBConvertDoamins.Size = new System.Drawing.Size(75, 23);
			this.btbBrowseFileGDBConvertDoamins.TabIndex = 3;
			this.btbBrowseFileGDBConvertDoamins.Text = "Browse...";
			this.btbBrowseFileGDBConvertDoamins.UseVisualStyleBackColor = true;
			this.btbBrowseFileGDBConvertDoamins.Click += new System.EventHandler(this.btbBrowseFileGDBConvertDoamins_Click);
			// 
			// textBoxGDBLocationConvertDomains
			// 
			this.textBoxGDBLocationConvertDomains.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxGDBLocationConvertDomains.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.textBoxGDBLocationConvertDomains.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GVConverter.Properties.Settings.Default, "PathToGDBFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textBoxGDBLocationConvertDomains.Location = new System.Drawing.Point(9, 19);
			this.textBoxGDBLocationConvertDomains.Name = "textBoxGDBLocationConvertDomains";
			this.textBoxGDBLocationConvertDomains.ReadOnly = true;
			this.textBoxGDBLocationConvertDomains.Size = new System.Drawing.Size(427, 20);
			this.textBoxGDBLocationConvertDomains.TabIndex = 0;
			this.textBoxGDBLocationConvertDomains.Text = global::GVConverter.Properties.Settings.Default.PathToGDBFolder;
			// 
			// label34
			// 
			this.label34.AutoSize = true;
			this.label34.Location = new System.Drawing.Point(89, 83);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(62, 13);
			this.label34.TabIndex = 5;
			this.label34.Text = "Total tables";
			// 
			// textBoxConvertDomainsTotalTablesArcGIS
			// 
			this.textBoxConvertDomainsTotalTablesArcGIS.Location = new System.Drawing.Point(157, 80);
			this.textBoxConvertDomainsTotalTablesArcGIS.Name = "textBoxConvertDomainsTotalTablesArcGIS";
			this.textBoxConvertDomainsTotalTablesArcGIS.ReadOnly = true;
			this.textBoxConvertDomainsTotalTablesArcGIS.Size = new System.Drawing.Size(100, 20);
			this.textBoxConvertDomainsTotalTablesArcGIS.TabIndex = 4;
			// 
			// listBoxConvertDomainsArcGIS
			// 
			this.listBoxConvertDomainsArcGIS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxConvertDomainsArcGIS.FormattingEnabled = true;
			this.listBoxConvertDomainsArcGIS.Location = new System.Drawing.Point(7, 140);
			this.listBoxConvertDomainsArcGIS.Name = "listBoxConvertDomainsArcGIS";
			this.listBoxConvertDomainsArcGIS.Size = new System.Drawing.Size(523, 316);
			this.listBoxConvertDomainsArcGIS.TabIndex = 1;
			this.listBoxConvertDomainsArcGIS.SelectedIndexChanged += new System.EventHandler(this.listBoxConvertDomainsArcGIS_SelectedIndexChanged);
			// 
			// btnConvertDomainsRefreshArcGIS
			// 
			this.btnConvertDomainsRefreshArcGIS.Location = new System.Drawing.Point(7, 78);
			this.btnConvertDomainsRefreshArcGIS.Name = "btnConvertDomainsRefreshArcGIS";
			this.btnConvertDomainsRefreshArcGIS.Size = new System.Drawing.Size(75, 23);
			this.btnConvertDomainsRefreshArcGIS.TabIndex = 0;
			this.btnConvertDomainsRefreshArcGIS.Text = "Refresh";
			this.btnConvertDomainsRefreshArcGIS.UseVisualStyleBackColor = true;
			this.btnConvertDomainsRefreshArcGIS.Click += new System.EventHandler(this.btnConvertDomainsRefreshArcGIS_Click);
			// 
			// groupBox12
			// 
			this.groupBox12.Controls.Add(this.radioBtnConvertDomainPostGisSortDefault);
			this.groupBox12.Controls.Add(this.radioBtnConvertDomainPostGisSortByName);
			this.groupBox12.Controls.Add(this.label35);
			this.groupBox12.Controls.Add(this.textBoxConvertDomainsTotalTablesGiscuit);
			this.groupBox12.Controls.Add(this.label37);
			this.groupBox12.Controls.Add(this.btnConvertDomainsCreateTableGiscuit);
			this.groupBox12.Controls.Add(this.listBoxConvertDomainsGiscuit);
			this.groupBox12.Controls.Add(this.btnConvertDomainsRefreshGiscuit);
			this.groupBox12.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox12.Location = new System.Drawing.Point(0, 0);
			this.groupBox12.Name = "groupBox12";
			this.groupBox12.Size = new System.Drawing.Size(590, 462);
			this.groupBox12.TabIndex = 2;
			this.groupBox12.TabStop = false;
			this.groupBox12.Text = "PostGIS - Destination";
			// 
			// radioBtnConvertDomainPostGisSortDefault
			// 
			this.radioBtnConvertDomainPostGisSortDefault.AutoSize = true;
			this.radioBtnConvertDomainPostGisSortDefault.Enabled = false;
			this.radioBtnConvertDomainPostGisSortDefault.Location = new System.Drawing.Point(114, 44);
			this.radioBtnConvertDomainPostGisSortDefault.Name = "radioBtnConvertDomainPostGisSortDefault";
			this.radioBtnConvertDomainPostGisSortDefault.Size = new System.Drawing.Size(59, 17);
			this.radioBtnConvertDomainPostGisSortDefault.TabIndex = 13;
			this.radioBtnConvertDomainPostGisSortDefault.TabStop = true;
			this.radioBtnConvertDomainPostGisSortDefault.Text = "Default";
			this.radioBtnConvertDomainPostGisSortDefault.UseVisualStyleBackColor = true;
			this.radioBtnConvertDomainPostGisSortDefault.CheckedChanged += new System.EventHandler(this.radioBtnConvertDomainPostGisSortDefault_CheckedChanged);
			// 
			// radioBtnConvertDomainPostGisSortByName
			// 
			this.radioBtnConvertDomainPostGisSortByName.AutoSize = true;
			this.radioBtnConvertDomainPostGisSortByName.Enabled = false;
			this.radioBtnConvertDomainPostGisSortByName.Location = new System.Drawing.Point(55, 44);
			this.radioBtnConvertDomainPostGisSortByName.Name = "radioBtnConvertDomainPostGisSortByName";
			this.radioBtnConvertDomainPostGisSortByName.Size = new System.Drawing.Size(53, 17);
			this.radioBtnConvertDomainPostGisSortByName.TabIndex = 14;
			this.radioBtnConvertDomainPostGisSortByName.TabStop = true;
			this.radioBtnConvertDomainPostGisSortByName.Text = "Name";
			this.radioBtnConvertDomainPostGisSortByName.UseVisualStyleBackColor = true;
			this.radioBtnConvertDomainPostGisSortByName.CheckedChanged += new System.EventHandler(this.radioBtnConvertDomainPostGisSortByName_CheckedChanged);
			// 
			// label35
			// 
			this.label35.AutoSize = true;
			this.label35.Location = new System.Drawing.Point(6, 46);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(43, 13);
			this.label35.TabIndex = 15;
			this.label35.Text = "Sort by:";
			// 
			// textBoxConvertDomainsTotalTablesGiscuit
			// 
			this.textBoxConvertDomainsTotalTablesGiscuit.Location = new System.Drawing.Point(249, 22);
			this.textBoxConvertDomainsTotalTablesGiscuit.Name = "textBoxConvertDomainsTotalTablesGiscuit";
			this.textBoxConvertDomainsTotalTablesGiscuit.ReadOnly = true;
			this.textBoxConvertDomainsTotalTablesGiscuit.Size = new System.Drawing.Size(50, 20);
			this.textBoxConvertDomainsTotalTablesGiscuit.TabIndex = 7;
			// 
			// label37
			// 
			this.label37.AutoSize = true;
			this.label37.Location = new System.Drawing.Point(181, 24);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(62, 13);
			this.label37.TabIndex = 6;
			this.label37.Text = "Total tables";
			// 
			// btnConvertDomainsCreateTableGiscuit
			// 
			this.btnConvertDomainsCreateTableGiscuit.Enabled = false;
			this.btnConvertDomainsCreateTableGiscuit.Location = new System.Drawing.Point(7, 20);
			this.btnConvertDomainsCreateTableGiscuit.Name = "btnConvertDomainsCreateTableGiscuit";
			this.btnConvertDomainsCreateTableGiscuit.Size = new System.Drawing.Size(87, 23);
			this.btnConvertDomainsCreateTableGiscuit.TabIndex = 5;
			this.btnConvertDomainsCreateTableGiscuit.Text = "Create table...";
			this.btnConvertDomainsCreateTableGiscuit.UseVisualStyleBackColor = true;
			this.btnConvertDomainsCreateTableGiscuit.Click += new System.EventHandler(this.btnConvertDomainsCreateTableGiscuit_Click);
			// 
			// listBoxConvertDomainsGiscuit
			// 
			this.listBoxConvertDomainsGiscuit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxConvertDomainsGiscuit.FormattingEnabled = true;
			this.listBoxConvertDomainsGiscuit.Location = new System.Drawing.Point(6, 75);
			this.listBoxConvertDomainsGiscuit.Name = "listBoxConvertDomainsGiscuit";
			this.listBoxConvertDomainsGiscuit.Size = new System.Drawing.Size(577, 381);
			this.listBoxConvertDomainsGiscuit.TabIndex = 1;
			// 
			// btnConvertDomainsRefreshGiscuit
			// 
			this.btnConvertDomainsRefreshGiscuit.Location = new System.Drawing.Point(100, 20);
			this.btnConvertDomainsRefreshGiscuit.Name = "btnConvertDomainsRefreshGiscuit";
			this.btnConvertDomainsRefreshGiscuit.Size = new System.Drawing.Size(75, 23);
			this.btnConvertDomainsRefreshGiscuit.TabIndex = 0;
			this.btnConvertDomainsRefreshGiscuit.Text = "Refresh";
			this.btnConvertDomainsRefreshGiscuit.UseVisualStyleBackColor = true;
			this.btnConvertDomainsRefreshGiscuit.Click += new System.EventHandler(this.btnConvertDomainsRefreshGiscuit_Click);
			// 
			// tabPageConvertToArcGIS
			// 
			this.tabPageConvertToArcGIS.Controls.Add(this.groupBox6);
			this.tabPageConvertToArcGIS.Controls.Add(this.splitContainer5);
			this.tabPageConvertToArcGIS.Location = new System.Drawing.Point(4, 22);
			this.tabPageConvertToArcGIS.Name = "tabPageConvertToArcGIS";
			this.tabPageConvertToArcGIS.Size = new System.Drawing.Size(1149, 564);
			this.tabPageConvertToArcGIS.TabIndex = 3;
			this.tabPageConvertToArcGIS.Text = "Convert PostGIS -> ArcGIS";
			this.tabPageConvertToArcGIS.UseVisualStyleBackColor = true;
			// 
			// groupBox6
			// 
			this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox6.Controls.Add(this.brnOverwriteConvertToArcGIS);
			this.groupBox6.Controls.Add(this.label25);
			this.groupBox6.Controls.Add(this.btnAppendConvertToArcGIS);
			this.groupBox6.Location = new System.Drawing.Point(5, 489);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(1130, 68);
			this.groupBox6.TabIndex = 3;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Convert data from PostGIS to ArcGIS";
			// 
			// brnOverwriteConvertToArcGIS
			// 
			this.brnOverwriteConvertToArcGIS.Enabled = false;
			this.brnOverwriteConvertToArcGIS.Location = new System.Drawing.Point(87, 36);
			this.brnOverwriteConvertToArcGIS.Name = "brnOverwriteConvertToArcGIS";
			this.brnOverwriteConvertToArcGIS.Size = new System.Drawing.Size(75, 23);
			this.brnOverwriteConvertToArcGIS.TabIndex = 2;
			this.brnOverwriteConvertToArcGIS.Text = "Overwrite";
			this.brnOverwriteConvertToArcGIS.UseVisualStyleBackColor = true;
			this.brnOverwriteConvertToArcGIS.Click += new System.EventHandler(this.brnOverwriteConvertToArcGIS_Click);
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(6, 20);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(29, 13);
			this.label25.TabIndex = 1;
			this.label25.Text = "label";
			// 
			// btnAppendConvertToArcGIS
			// 
			this.btnAppendConvertToArcGIS.Enabled = false;
			this.btnAppendConvertToArcGIS.Location = new System.Drawing.Point(6, 36);
			this.btnAppendConvertToArcGIS.Name = "btnAppendConvertToArcGIS";
			this.btnAppendConvertToArcGIS.Size = new System.Drawing.Size(75, 23);
			this.btnAppendConvertToArcGIS.TabIndex = 0;
			this.btnAppendConvertToArcGIS.Text = "Append";
			this.btnAppendConvertToArcGIS.UseVisualStyleBackColor = true;
			this.btnAppendConvertToArcGIS.Click += new System.EventHandler(this.btnAppendConvertToArcGIS_Click);
			// 
			// splitContainer5
			// 
			this.splitContainer5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer5.Location = new System.Drawing.Point(5, 3);
			this.splitContainer5.Name = "splitContainer5";
			// 
			// splitContainer5.Panel1
			// 
			this.splitContainer5.Panel1.Controls.Add(this.groupBox7);
			// 
			// splitContainer5.Panel2
			// 
			this.splitContainer5.Panel2.Controls.Add(this.groupBox8);
			this.splitContainer5.Size = new System.Drawing.Size(1130, 480);
			this.splitContainer5.SplitterDistance = 559;
			this.splitContainer5.TabIndex = 4;
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.radioButtonSortByDefaultGiscuitConvertToArcGIS);
			this.groupBox7.Controls.Add(this.radioButtonSortByNameGiscuitConvertToArcGIS);
			this.groupBox7.Controls.Add(this.label26);
			this.groupBox7.Controls.Add(this.textBoxTotalTablesGiscuitConvertToAcrGIS);
			this.groupBox7.Controls.Add(this.label27);
			this.groupBox7.Controls.Add(this.textBoxTypeShapeGiscuitConvertToArcGIS);
			this.groupBox7.Controls.Add(this.label28);
			this.groupBox7.Controls.Add(this.listBoxTablesGiscuitConvertToArcGIS);
			this.groupBox7.Controls.Add(this.btnGetDataGiscuitConvertToArcGIS);
			this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox7.Location = new System.Drawing.Point(0, 0);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(559, 480);
			this.groupBox7.TabIndex = 2;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "PostGIS - Source";
			// 
			// radioButtonSortByDefaultGiscuitConvertToArcGIS
			// 
			this.radioButtonSortByDefaultGiscuitConvertToArcGIS.AutoSize = true;
			this.radioButtonSortByDefaultGiscuitConvertToArcGIS.Enabled = false;
			this.radioButtonSortByDefaultGiscuitConvertToArcGIS.Location = new System.Drawing.Point(114, 47);
			this.radioButtonSortByDefaultGiscuitConvertToArcGIS.Name = "radioButtonSortByDefaultGiscuitConvertToArcGIS";
			this.radioButtonSortByDefaultGiscuitConvertToArcGIS.Size = new System.Drawing.Size(59, 17);
			this.radioButtonSortByDefaultGiscuitConvertToArcGIS.TabIndex = 9;
			this.radioButtonSortByDefaultGiscuitConvertToArcGIS.TabStop = true;
			this.radioButtonSortByDefaultGiscuitConvertToArcGIS.Text = "Default";
			this.radioButtonSortByDefaultGiscuitConvertToArcGIS.UseVisualStyleBackColor = true;
			this.radioButtonSortByDefaultGiscuitConvertToArcGIS.CheckedChanged += new System.EventHandler(this.radioButtonSortByDefaultGiscuitConvertToArcGIS_CheckedChanged);
			// 
			// radioButtonSortByNameGiscuitConvertToArcGIS
			// 
			this.radioButtonSortByNameGiscuitConvertToArcGIS.AutoSize = true;
			this.radioButtonSortByNameGiscuitConvertToArcGIS.Enabled = false;
			this.radioButtonSortByNameGiscuitConvertToArcGIS.Location = new System.Drawing.Point(55, 47);
			this.radioButtonSortByNameGiscuitConvertToArcGIS.Name = "radioButtonSortByNameGiscuitConvertToArcGIS";
			this.radioButtonSortByNameGiscuitConvertToArcGIS.Size = new System.Drawing.Size(53, 17);
			this.radioButtonSortByNameGiscuitConvertToArcGIS.TabIndex = 9;
			this.radioButtonSortByNameGiscuitConvertToArcGIS.TabStop = true;
			this.radioButtonSortByNameGiscuitConvertToArcGIS.Text = "Name";
			this.radioButtonSortByNameGiscuitConvertToArcGIS.UseVisualStyleBackColor = true;
			this.radioButtonSortByNameGiscuitConvertToArcGIS.CheckedChanged += new System.EventHandler(this.radioButtonSortByNameGiscuitConvertToArcGIS_CheckedChanged);
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Location = new System.Drawing.Point(6, 49);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(43, 13);
			this.label26.TabIndex = 9;
			this.label26.Text = "Sort by:";
			// 
			// textBoxTotalTablesGiscuitConvertToAcrGIS
			// 
			this.textBoxTotalTablesGiscuitConvertToAcrGIS.Location = new System.Drawing.Point(505, 46);
			this.textBoxTotalTablesGiscuitConvertToAcrGIS.Name = "textBoxTotalTablesGiscuitConvertToAcrGIS";
			this.textBoxTotalTablesGiscuitConvertToAcrGIS.ReadOnly = true;
			this.textBoxTotalTablesGiscuitConvertToAcrGIS.Size = new System.Drawing.Size(50, 20);
			this.textBoxTotalTablesGiscuitConvertToAcrGIS.TabIndex = 7;
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Location = new System.Drawing.Point(437, 49);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(62, 13);
			this.label27.TabIndex = 6;
			this.label27.Text = "Total tables";
			// 
			// textBoxTypeShapeGiscuitConvertToArcGIS
			// 
			this.textBoxTypeShapeGiscuitConvertToArcGIS.Location = new System.Drawing.Point(331, 46);
			this.textBoxTypeShapeGiscuitConvertToArcGIS.Name = "textBoxTypeShapeGiscuitConvertToArcGIS";
			this.textBoxTypeShapeGiscuitConvertToArcGIS.ReadOnly = true;
			this.textBoxTypeShapeGiscuitConvertToArcGIS.Size = new System.Drawing.Size(100, 20);
			this.textBoxTypeShapeGiscuitConvertToArcGIS.TabIndex = 4;
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Location = new System.Drawing.Point(262, 49);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(63, 13);
			this.label28.TabIndex = 3;
			this.label28.Text = "Type shape";
			// 
			// listBoxTablesGiscuitConvertToArcGIS
			// 
			this.listBoxTablesGiscuitConvertToArcGIS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxTablesGiscuitConvertToArcGIS.FormattingEnabled = true;
			this.listBoxTablesGiscuitConvertToArcGIS.Location = new System.Drawing.Point(6, 75);
			this.listBoxTablesGiscuitConvertToArcGIS.Name = "listBoxTablesGiscuitConvertToArcGIS";
			this.listBoxTablesGiscuitConvertToArcGIS.Size = new System.Drawing.Size(545, 394);
			this.listBoxTablesGiscuitConvertToArcGIS.TabIndex = 1;
			this.listBoxTablesGiscuitConvertToArcGIS.SelectedIndexChanged += new System.EventHandler(this.listBoxTablesGiscuitConvertToArcGIS_SelectedIndexChanged);
			// 
			// btnGetDataGiscuitConvertToArcGIS
			// 
			this.btnGetDataGiscuitConvertToArcGIS.Location = new System.Drawing.Point(6, 18);
			this.btnGetDataGiscuitConvertToArcGIS.Name = "btnGetDataGiscuitConvertToArcGIS";
			this.btnGetDataGiscuitConvertToArcGIS.Size = new System.Drawing.Size(75, 23);
			this.btnGetDataGiscuitConvertToArcGIS.TabIndex = 0;
			this.btnGetDataGiscuitConvertToArcGIS.Text = "Refresh";
			this.btnGetDataGiscuitConvertToArcGIS.UseVisualStyleBackColor = true;
			this.btnGetDataGiscuitConvertToArcGIS.Click += new System.EventHandler(this.btnGetDataGiscuitConvertToArcGIS_Click);
			// 
			// groupBox8
			// 
			this.groupBox8.Controls.Add(this.btnClearDataArcGISTableConvertToArcGIS);
			this.groupBox8.Controls.Add(this.groupBox9);
			this.groupBox8.Controls.Add(this.radioButtonSortByDefaultArcGISConvertToArcGIS);
			this.groupBox8.Controls.Add(this.btnDeleteTableArcGISConvetToArcGIS);
			this.groupBox8.Controls.Add(this.label29);
			this.groupBox8.Controls.Add(this.radioButtonSortByNameArcGISConvertToArcGIS);
			this.groupBox8.Controls.Add(this.label30);
			this.groupBox8.Controls.Add(this.textBoxTotalTablesArcGISConvertToArcGIS);
			this.groupBox8.Controls.Add(this.textBoxTypeShapeArcGISConvertToArcGIS);
			this.groupBox8.Controls.Add(this.btnCreateTableFromGiscuitConvertToArcGIS);
			this.groupBox8.Controls.Add(this.label31);
			this.groupBox8.Controls.Add(this.listBoxTablesArcGISConvertToArcGIS);
			this.groupBox8.Controls.Add(this.btnGetTablesArcGISConvertToAcrGIS);
			this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox8.Location = new System.Drawing.Point(0, 0);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(567, 480);
			this.groupBox8.TabIndex = 1;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "ArcGIS - Destination";
			// 
			// btnClearDataArcGISTableConvertToArcGIS
			// 
			this.btnClearDataArcGISTableConvertToArcGIS.Enabled = false;
			this.btnClearDataArcGISTableConvertToArcGIS.Location = new System.Drawing.Point(100, 78);
			this.btnClearDataArcGISTableConvertToArcGIS.Name = "btnClearDataArcGISTableConvertToArcGIS";
			this.btnClearDataArcGISTableConvertToArcGIS.Size = new System.Drawing.Size(75, 23);
			this.btnClearDataArcGISTableConvertToArcGIS.TabIndex = 10;
			this.btnClearDataArcGISTableConvertToArcGIS.Text = "Clear data";
			this.btnClearDataArcGISTableConvertToArcGIS.UseVisualStyleBackColor = true;
			this.btnClearDataArcGISTableConvertToArcGIS.Click += new System.EventHandler(this.btnClearDataArcGISTableConvertToArcGIS_Click);
			// 
			// groupBox9
			// 
			this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox9.Controls.Add(this.btbBrowseFileGDBConvertToArcGIS);
			this.groupBox9.Controls.Add(this.textBoxGDBLocationConvertToArcGIS);
			this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox9.Location = new System.Drawing.Point(7, 19);
			this.groupBox9.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.groupBox9.Name = "groupBox9";
			this.groupBox9.Size = new System.Drawing.Size(554, 51);
			this.groupBox9.TabIndex = 4;
			this.groupBox9.TabStop = false;
			this.groupBox9.Text = "Geodatabase (gdb) location";
			// 
			// btbBrowseFileGDBConvertToArcGIS
			// 
			this.btbBrowseFileGDBConvertToArcGIS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btbBrowseFileGDBConvertToArcGIS.Location = new System.Drawing.Point(472, 17);
			this.btbBrowseFileGDBConvertToArcGIS.Name = "btbBrowseFileGDBConvertToArcGIS";
			this.btbBrowseFileGDBConvertToArcGIS.Size = new System.Drawing.Size(75, 23);
			this.btbBrowseFileGDBConvertToArcGIS.TabIndex = 3;
			this.btbBrowseFileGDBConvertToArcGIS.Text = "Browse...";
			this.btbBrowseFileGDBConvertToArcGIS.UseVisualStyleBackColor = true;
			this.btbBrowseFileGDBConvertToArcGIS.Click += new System.EventHandler(this.btbBrowseFileGDBConvertToArcGIS_Click);
			// 
			// textBoxGDBLocationConvertToArcGIS
			// 
			this.textBoxGDBLocationConvertToArcGIS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxGDBLocationConvertToArcGIS.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.textBoxGDBLocationConvertToArcGIS.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GVConverter.Properties.Settings.Default, "PathToGDBFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textBoxGDBLocationConvertToArcGIS.Location = new System.Drawing.Point(9, 19);
			this.textBoxGDBLocationConvertToArcGIS.Name = "textBoxGDBLocationConvertToArcGIS";
			this.textBoxGDBLocationConvertToArcGIS.ReadOnly = true;
			this.textBoxGDBLocationConvertToArcGIS.Size = new System.Drawing.Size(458, 20);
			this.textBoxGDBLocationConvertToArcGIS.TabIndex = 0;
			this.textBoxGDBLocationConvertToArcGIS.Text = global::GVConverter.Properties.Settings.Default.PathToGDBFolder;
			// 
			// radioButtonSortByDefaultArcGISConvertToArcGIS
			// 
			this.radioButtonSortByDefaultArcGISConvertToArcGIS.AutoSize = true;
			this.radioButtonSortByDefaultArcGISConvertToArcGIS.Enabled = false;
			this.radioButtonSortByDefaultArcGISConvertToArcGIS.Location = new System.Drawing.Point(112, 134);
			this.radioButtonSortByDefaultArcGISConvertToArcGIS.Name = "radioButtonSortByDefaultArcGISConvertToArcGIS";
			this.radioButtonSortByDefaultArcGISConvertToArcGIS.Size = new System.Drawing.Size(59, 17);
			this.radioButtonSortByDefaultArcGISConvertToArcGIS.TabIndex = 8;
			this.radioButtonSortByDefaultArcGISConvertToArcGIS.TabStop = true;
			this.radioButtonSortByDefaultArcGISConvertToArcGIS.Text = "Default";
			this.radioButtonSortByDefaultArcGISConvertToArcGIS.UseVisualStyleBackColor = true;
			this.radioButtonSortByDefaultArcGISConvertToArcGIS.CheckedChanged += new System.EventHandler(this.radioButtonSortByDefaultArcGISConvertToArcGIS_CheckedChanged);
			// 
			// btnDeleteTableArcGISConvetToArcGIS
			// 
			this.btnDeleteTableArcGISConvetToArcGIS.Enabled = false;
			this.btnDeleteTableArcGISConvetToArcGIS.Location = new System.Drawing.Point(181, 78);
			this.btnDeleteTableArcGISConvetToArcGIS.Name = "btnDeleteTableArcGISConvetToArcGIS";
			this.btnDeleteTableArcGISConvetToArcGIS.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteTableArcGISConvetToArcGIS.TabIndex = 8;
			this.btnDeleteTableArcGISConvetToArcGIS.Text = "Delete table";
			this.btnDeleteTableArcGISConvetToArcGIS.UseVisualStyleBackColor = true;
			this.btnDeleteTableArcGISConvetToArcGIS.Click += new System.EventHandler(this.btnDeleteTableArcGISConvetToArcGIS_Click);
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Location = new System.Drawing.Point(4, 136);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(43, 13);
			this.label29.TabIndex = 6;
			this.label29.Text = "Sort by:";
			// 
			// radioButtonSortByNameArcGISConvertToArcGIS
			// 
			this.radioButtonSortByNameArcGISConvertToArcGIS.AutoSize = true;
			this.radioButtonSortByNameArcGISConvertToArcGIS.Enabled = false;
			this.radioButtonSortByNameArcGISConvertToArcGIS.Location = new System.Drawing.Point(53, 134);
			this.radioButtonSortByNameArcGISConvertToArcGIS.Name = "radioButtonSortByNameArcGISConvertToArcGIS";
			this.radioButtonSortByNameArcGISConvertToArcGIS.Size = new System.Drawing.Size(53, 17);
			this.radioButtonSortByNameArcGISConvertToArcGIS.TabIndex = 7;
			this.radioButtonSortByNameArcGISConvertToArcGIS.TabStop = true;
			this.radioButtonSortByNameArcGISConvertToArcGIS.Text = "Name";
			this.radioButtonSortByNameArcGISConvertToArcGIS.UseVisualStyleBackColor = true;
			this.radioButtonSortByNameArcGISConvertToArcGIS.CheckedChanged += new System.EventHandler(this.radioButtonSortByNameArcGISConvertToArcGIS_CheckedChanged);
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Location = new System.Drawing.Point(209, 110);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(62, 13);
			this.label30.TabIndex = 5;
			this.label30.Text = "Total tables";
			// 
			// textBoxTotalTablesArcGISConvertToArcGIS
			// 
			this.textBoxTotalTablesArcGISConvertToArcGIS.Location = new System.Drawing.Point(277, 107);
			this.textBoxTotalTablesArcGISConvertToArcGIS.Name = "textBoxTotalTablesArcGISConvertToArcGIS";
			this.textBoxTotalTablesArcGISConvertToArcGIS.ReadOnly = true;
			this.textBoxTotalTablesArcGISConvertToArcGIS.Size = new System.Drawing.Size(100, 20);
			this.textBoxTotalTablesArcGISConvertToArcGIS.TabIndex = 4;
			// 
			// textBoxTypeShapeArcGISConvertToArcGIS
			// 
			this.textBoxTypeShapeArcGISConvertToArcGIS.Location = new System.Drawing.Point(73, 107);
			this.textBoxTypeShapeArcGISConvertToArcGIS.Name = "textBoxTypeShapeArcGISConvertToArcGIS";
			this.textBoxTypeShapeArcGISConvertToArcGIS.ReadOnly = true;
			this.textBoxTypeShapeArcGISConvertToArcGIS.Size = new System.Drawing.Size(130, 20);
			this.textBoxTypeShapeArcGISConvertToArcGIS.TabIndex = 3;
			// 
			// btnCreateTableFromGiscuitConvertToArcGIS
			// 
			this.btnCreateTableFromGiscuitConvertToArcGIS.Enabled = false;
			this.btnCreateTableFromGiscuitConvertToArcGIS.Location = new System.Drawing.Point(7, 78);
			this.btnCreateTableFromGiscuitConvertToArcGIS.Name = "btnCreateTableFromGiscuitConvertToArcGIS";
			this.btnCreateTableFromGiscuitConvertToArcGIS.Size = new System.Drawing.Size(87, 23);
			this.btnCreateTableFromGiscuitConvertToArcGIS.TabIndex = 5;
			this.btnCreateTableFromGiscuitConvertToArcGIS.Text = "Create table...";
			this.btnCreateTableFromGiscuitConvertToArcGIS.UseVisualStyleBackColor = true;
			this.btnCreateTableFromGiscuitConvertToArcGIS.Click += new System.EventHandler(this.btnCreateTableFromGiscuitConvertToArcGIS_Click);
			// 
			// label31
			// 
			this.label31.AutoSize = true;
			this.label31.Location = new System.Drawing.Point(4, 110);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(63, 13);
			this.label31.TabIndex = 2;
			this.label31.Text = "Type shape";
			// 
			// listBoxTablesArcGISConvertToArcGIS
			// 
			this.listBoxTablesArcGISConvertToArcGIS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxTablesArcGISConvertToArcGIS.FormattingEnabled = true;
			this.listBoxTablesArcGISConvertToArcGIS.Location = new System.Drawing.Point(7, 166);
			this.listBoxTablesArcGISConvertToArcGIS.Name = "listBoxTablesArcGISConvertToArcGIS";
			this.listBoxTablesArcGISConvertToArcGIS.Size = new System.Drawing.Size(554, 303);
			this.listBoxTablesArcGISConvertToArcGIS.TabIndex = 1;
			this.listBoxTablesArcGISConvertToArcGIS.SelectedIndexChanged += new System.EventHandler(this.listBoxTablesArcGISConvertToArcGIS_SelectedIndexChanged);
			// 
			// btnGetTablesArcGISConvertToAcrGIS
			// 
			this.btnGetTablesArcGISConvertToAcrGIS.Location = new System.Drawing.Point(262, 78);
			this.btnGetTablesArcGISConvertToAcrGIS.Name = "btnGetTablesArcGISConvertToAcrGIS";
			this.btnGetTablesArcGISConvertToAcrGIS.Size = new System.Drawing.Size(75, 23);
			this.btnGetTablesArcGISConvertToAcrGIS.TabIndex = 0;
			this.btnGetTablesArcGISConvertToAcrGIS.Text = "Refresh";
			this.btnGetTablesArcGISConvertToAcrGIS.UseVisualStyleBackColor = true;
			this.btnGetTablesArcGISConvertToAcrGIS.Click += new System.EventHandler(this.btnGetTablesArcGISConvertToAcrGIS_Click);
			// 
			// tabPageConvertDomainsToArcGIS
			// 
			this.tabPageConvertDomainsToArcGIS.Controls.Add(this.groupBox14);
			this.tabPageConvertDomainsToArcGIS.Controls.Add(this.splitContainer7);
			this.tabPageConvertDomainsToArcGIS.Location = new System.Drawing.Point(4, 22);
			this.tabPageConvertDomainsToArcGIS.Name = "tabPageConvertDomainsToArcGIS";
			this.tabPageConvertDomainsToArcGIS.Size = new System.Drawing.Size(1149, 564);
			this.tabPageConvertDomainsToArcGIS.TabIndex = 6;
			this.tabPageConvertDomainsToArcGIS.Text = "Convert Domains PostGIS -> ArcGIS";
			this.tabPageConvertDomainsToArcGIS.UseVisualStyleBackColor = true;
			// 
			// groupBox14
			// 
			this.groupBox14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox14.Controls.Add(this.btnOverwriteConvertDomainToArcGIS);
			this.groupBox14.Controls.Add(this.label36);
			this.groupBox14.Controls.Add(this.button3);
			this.groupBox14.Location = new System.Drawing.Point(5, 461);
			this.groupBox14.Name = "groupBox14";
			this.groupBox14.Size = new System.Drawing.Size(1136, 68);
			this.groupBox14.TabIndex = 3;
			this.groupBox14.TabStop = false;
			this.groupBox14.Text = "Convert data from PostGIS to ArcGIS";
			// 
			// btnOverwriteConvertDomainToArcGIS
			// 
			this.btnOverwriteConvertDomainToArcGIS.Location = new System.Drawing.Point(87, 36);
			this.btnOverwriteConvertDomainToArcGIS.Name = "btnOverwriteConvertDomainToArcGIS";
			this.btnOverwriteConvertDomainToArcGIS.Size = new System.Drawing.Size(75, 23);
			this.btnOverwriteConvertDomainToArcGIS.TabIndex = 2;
			this.btnOverwriteConvertDomainToArcGIS.Text = "Overwrite";
			this.btnOverwriteConvertDomainToArcGIS.UseVisualStyleBackColor = true;
			this.btnOverwriteConvertDomainToArcGIS.Click += new System.EventHandler(this.btnOverwriteConvertDomainToArcGIS_Click);
			// 
			// label36
			// 
			this.label36.AutoSize = true;
			this.label36.Location = new System.Drawing.Point(6, 20);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(29, 13);
			this.label36.TabIndex = 1;
			this.label36.Text = "label";
			// 
			// button3
			// 
			this.button3.Enabled = false;
			this.button3.Location = new System.Drawing.Point(6, 36);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 0;
			this.button3.Text = "Append";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// splitContainer7
			// 
			this.splitContainer7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer7.Location = new System.Drawing.Point(5, 3);
			this.splitContainer7.Name = "splitContainer7";
			// 
			// splitContainer7.Panel1
			// 
			this.splitContainer7.Panel1.Controls.Add(this.groupBox15);
			// 
			// splitContainer7.Panel2
			// 
			this.splitContainer7.Panel2.Controls.Add(this.groupBox16);
			this.splitContainer7.Size = new System.Drawing.Size(1136, 452);
			this.splitContainer7.SplitterDistance = 562;
			this.splitContainer7.TabIndex = 4;
			// 
			// groupBox15
			// 
			this.groupBox15.Controls.Add(this.rdBtnDomainFromPostGisSortDefault);
			this.groupBox15.Controls.Add(this.rdBtnDomainFromPostGisSortByName);
			this.groupBox15.Controls.Add(this.label38);
			this.groupBox15.Controls.Add(this.txtBoxFromPostGisDomainsCount);
			this.groupBox15.Controls.Add(this.label39);
			this.groupBox15.Controls.Add(this.listBoxConvertDomainsFromPostGis);
			this.groupBox15.Controls.Add(this.btnRefreshPostGisDomains);
			this.groupBox15.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox15.Location = new System.Drawing.Point(0, 0);
			this.groupBox15.Name = "groupBox15";
			this.groupBox15.Size = new System.Drawing.Size(562, 452);
			this.groupBox15.TabIndex = 2;
			this.groupBox15.TabStop = false;
			this.groupBox15.Text = "PostGIS - Source";
			// 
			// rdBtnDomainFromPostGisSortDefault
			// 
			this.rdBtnDomainFromPostGisSortDefault.AutoSize = true;
			this.rdBtnDomainFromPostGisSortDefault.Enabled = false;
			this.rdBtnDomainFromPostGisSortDefault.Location = new System.Drawing.Point(114, 47);
			this.rdBtnDomainFromPostGisSortDefault.Name = "rdBtnDomainFromPostGisSortDefault";
			this.rdBtnDomainFromPostGisSortDefault.Size = new System.Drawing.Size(59, 17);
			this.rdBtnDomainFromPostGisSortDefault.TabIndex = 9;
			this.rdBtnDomainFromPostGisSortDefault.TabStop = true;
			this.rdBtnDomainFromPostGisSortDefault.Text = "Default";
			this.rdBtnDomainFromPostGisSortDefault.UseVisualStyleBackColor = true;
			this.rdBtnDomainFromPostGisSortDefault.CheckedChanged += new System.EventHandler(this.rdBtnDomainFromPostGisSortDefault_CheckedChanged);
			// 
			// rdBtnDomainFromPostGisSortByName
			// 
			this.rdBtnDomainFromPostGisSortByName.AutoSize = true;
			this.rdBtnDomainFromPostGisSortByName.Enabled = false;
			this.rdBtnDomainFromPostGisSortByName.Location = new System.Drawing.Point(55, 47);
			this.rdBtnDomainFromPostGisSortByName.Name = "rdBtnDomainFromPostGisSortByName";
			this.rdBtnDomainFromPostGisSortByName.Size = new System.Drawing.Size(53, 17);
			this.rdBtnDomainFromPostGisSortByName.TabIndex = 9;
			this.rdBtnDomainFromPostGisSortByName.TabStop = true;
			this.rdBtnDomainFromPostGisSortByName.Text = "Name";
			this.rdBtnDomainFromPostGisSortByName.UseVisualStyleBackColor = true;
			this.rdBtnDomainFromPostGisSortByName.CheckedChanged += new System.EventHandler(this.rdBtnDomainFromPostGisSortByName_CheckedChanged);
			// 
			// label38
			// 
			this.label38.AutoSize = true;
			this.label38.Location = new System.Drawing.Point(6, 49);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(43, 13);
			this.label38.TabIndex = 9;
			this.label38.Text = "Sort by:";
			// 
			// txtBoxFromPostGisDomainsCount
			// 
			this.txtBoxFromPostGisDomainsCount.Location = new System.Drawing.Point(505, 46);
			this.txtBoxFromPostGisDomainsCount.Name = "txtBoxFromPostGisDomainsCount";
			this.txtBoxFromPostGisDomainsCount.ReadOnly = true;
			this.txtBoxFromPostGisDomainsCount.Size = new System.Drawing.Size(50, 20);
			this.txtBoxFromPostGisDomainsCount.TabIndex = 7;
			// 
			// label39
			// 
			this.label39.AutoSize = true;
			this.label39.Location = new System.Drawing.Point(437, 49);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(62, 13);
			this.label39.TabIndex = 6;
			this.label39.Text = "Total tables";
			// 
			// listBoxConvertDomainsFromPostGis
			// 
			this.listBoxConvertDomainsFromPostGis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxConvertDomainsFromPostGis.FormattingEnabled = true;
			this.listBoxConvertDomainsFromPostGis.Location = new System.Drawing.Point(6, 75);
			this.listBoxConvertDomainsFromPostGis.Name = "listBoxConvertDomainsFromPostGis";
			this.listBoxConvertDomainsFromPostGis.Size = new System.Drawing.Size(549, 368);
			this.listBoxConvertDomainsFromPostGis.TabIndex = 1;
			// 
			// btnRefreshPostGisDomains
			// 
			this.btnRefreshPostGisDomains.Location = new System.Drawing.Point(6, 18);
			this.btnRefreshPostGisDomains.Name = "btnRefreshPostGisDomains";
			this.btnRefreshPostGisDomains.Size = new System.Drawing.Size(75, 23);
			this.btnRefreshPostGisDomains.TabIndex = 0;
			this.btnRefreshPostGisDomains.Text = "Refresh";
			this.btnRefreshPostGisDomains.UseVisualStyleBackColor = true;
			this.btnRefreshPostGisDomains.Click += new System.EventHandler(this.btnRefreshPostGisDomains_Click);
			// 
			// groupBox16
			// 
			this.groupBox16.Controls.Add(this.groupBox17);
			this.groupBox16.Controls.Add(this.rdBtnDomainToArcGisSortDefault);
			this.groupBox16.Controls.Add(this.label41);
			this.groupBox16.Controls.Add(this.rdBtnDomainToArcGisSortByName);
			this.groupBox16.Controls.Add(this.label42);
			this.groupBox16.Controls.Add(this.txtBoxToArcGisDomainsCount);
			this.groupBox16.Controls.Add(this.listBoxConvertDomainsToArcGis);
			this.groupBox16.Controls.Add(this.btnRefreshArcGisDomains);
			this.groupBox16.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox16.Location = new System.Drawing.Point(0, 0);
			this.groupBox16.Name = "groupBox16";
			this.groupBox16.Size = new System.Drawing.Size(570, 452);
			this.groupBox16.TabIndex = 1;
			this.groupBox16.TabStop = false;
			this.groupBox16.Text = "ArcGIS - Destination";
			// 
			// groupBox17
			// 
			this.groupBox17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox17.Controls.Add(this.button6);
			this.groupBox17.Controls.Add(this.textBox3);
			this.groupBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox17.Location = new System.Drawing.Point(7, 19);
			this.groupBox17.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.groupBox17.Name = "groupBox17";
			this.groupBox17.Size = new System.Drawing.Size(556, 51);
			this.groupBox17.TabIndex = 4;
			this.groupBox17.TabStop = false;
			this.groupBox17.Text = "Geodatabase (gdb) location";
			// 
			// button6
			// 
			this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button6.Location = new System.Drawing.Point(476, 17);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 23);
			this.button6.TabIndex = 3;
			this.button6.Text = "Browse...";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// textBox3
			// 
			this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GVConverter.Properties.Settings.Default, "PathToGDBFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textBox3.Location = new System.Drawing.Point(9, 19);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(461, 20);
			this.textBox3.TabIndex = 0;
			this.textBox3.Text = global::GVConverter.Properties.Settings.Default.PathToGDBFolder;
			// 
			// rdBtnDomainToArcGisSortDefault
			// 
			this.rdBtnDomainToArcGisSortDefault.AutoSize = true;
			this.rdBtnDomainToArcGisSortDefault.Enabled = false;
			this.rdBtnDomainToArcGisSortDefault.Location = new System.Drawing.Point(112, 111);
			this.rdBtnDomainToArcGisSortDefault.Name = "rdBtnDomainToArcGisSortDefault";
			this.rdBtnDomainToArcGisSortDefault.Size = new System.Drawing.Size(59, 17);
			this.rdBtnDomainToArcGisSortDefault.TabIndex = 8;
			this.rdBtnDomainToArcGisSortDefault.TabStop = true;
			this.rdBtnDomainToArcGisSortDefault.Text = "Default";
			this.rdBtnDomainToArcGisSortDefault.UseVisualStyleBackColor = true;
			this.rdBtnDomainToArcGisSortDefault.CheckedChanged += new System.EventHandler(this.rdBtnDomainToArcGisSortDefault_CheckedChanged);
			// 
			// label41
			// 
			this.label41.AutoSize = true;
			this.label41.Location = new System.Drawing.Point(4, 113);
			this.label41.Name = "label41";
			this.label41.Size = new System.Drawing.Size(43, 13);
			this.label41.TabIndex = 6;
			this.label41.Text = "Sort by:";
			// 
			// rdBtnDomainToArcGisSortByName
			// 
			this.rdBtnDomainToArcGisSortByName.AutoSize = true;
			this.rdBtnDomainToArcGisSortByName.Enabled = false;
			this.rdBtnDomainToArcGisSortByName.Location = new System.Drawing.Point(53, 111);
			this.rdBtnDomainToArcGisSortByName.Name = "rdBtnDomainToArcGisSortByName";
			this.rdBtnDomainToArcGisSortByName.Size = new System.Drawing.Size(53, 17);
			this.rdBtnDomainToArcGisSortByName.TabIndex = 7;
			this.rdBtnDomainToArcGisSortByName.TabStop = true;
			this.rdBtnDomainToArcGisSortByName.Text = "Name";
			this.rdBtnDomainToArcGisSortByName.UseVisualStyleBackColor = true;
			this.rdBtnDomainToArcGisSortByName.CheckedChanged += new System.EventHandler(this.rdBtnDomainToArcGisSortByName_CheckedChanged);
			// 
			// label42
			// 
			this.label42.AutoSize = true;
			this.label42.Location = new System.Drawing.Point(92, 83);
			this.label42.Name = "label42";
			this.label42.Size = new System.Drawing.Size(62, 13);
			this.label42.TabIndex = 5;
			this.label42.Text = "Total tables";
			// 
			// txtBoxToArcGisDomainsCount
			// 
			this.txtBoxToArcGisDomainsCount.Location = new System.Drawing.Point(159, 80);
			this.txtBoxToArcGisDomainsCount.Name = "txtBoxToArcGisDomainsCount";
			this.txtBoxToArcGisDomainsCount.ReadOnly = true;
			this.txtBoxToArcGisDomainsCount.Size = new System.Drawing.Size(102, 20);
			this.txtBoxToArcGisDomainsCount.TabIndex = 4;
			// 
			// listBoxConvertDomainsToArcGis
			// 
			this.listBoxConvertDomainsToArcGis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxConvertDomainsToArcGis.FormattingEnabled = true;
			this.listBoxConvertDomainsToArcGis.Location = new System.Drawing.Point(7, 140);
			this.listBoxConvertDomainsToArcGis.Name = "listBoxConvertDomainsToArcGis";
			this.listBoxConvertDomainsToArcGis.Size = new System.Drawing.Size(557, 303);
			this.listBoxConvertDomainsToArcGis.TabIndex = 1;
			// 
			// btnRefreshArcGisDomains
			// 
			this.btnRefreshArcGisDomains.Location = new System.Drawing.Point(10, 78);
			this.btnRefreshArcGisDomains.Name = "btnRefreshArcGisDomains";
			this.btnRefreshArcGisDomains.Size = new System.Drawing.Size(75, 23);
			this.btnRefreshArcGisDomains.TabIndex = 0;
			this.btnRefreshArcGisDomains.Text = "Refresh";
			this.btnRefreshArcGisDomains.UseVisualStyleBackColor = true;
			this.btnRefreshArcGisDomains.Click += new System.EventHandler(this.btnRefreshArcGisDomains_Click);
			// 
			// splitContainerMain
			// 
			this.splitContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainerMain.IsSplitterFixed = true;
			this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
			this.splitContainerMain.Name = "splitContainerMain";
			this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainerMain.Panel1
			// 
			this.splitContainerMain.Panel1.Controls.Add(this.button1);
			this.splitContainerMain.Panel1.Controls.Add(this.btnHelp);
			this.splitContainerMain.Panel1.Controls.Add(this.btnExit);
			this.splitContainerMain.Panel1.Controls.Add(this.btnSettingsProgramm);
			// 
			// splitContainerMain.Panel2
			// 
			this.splitContainerMain.Panel2.Controls.Add(this.tabControlMain);
			this.splitContainerMain.Size = new System.Drawing.Size(1159, 670);
			this.splitContainerMain.SplitterDistance = 92;
			this.splitContainerMain.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.Dock = System.Windows.Forms.DockStyle.Left;
			this.button1.Font = global::GVConverter.Properties.Settings.Default.FontButtonMenu;
			this.button1.Image = global::GVConverter.Properties.Resources.phong_shading_info_48;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button1.Location = new System.Drawing.Point(210, 0);
			this.button1.Name = "button1";
			this.button1.Size = global::GVConverter.Properties.Settings.Default.SizeOfButtonMenu;
			this.button1.TabIndex = 7;
			this.button1.Text = "About";
			this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnHelp
			// 
			this.btnHelp.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnHelp.Font = global::GVConverter.Properties.Settings.Default.FontButtonMenu;
			this.btnHelp.Image = global::GVConverter.Properties.Resources.phong_shading_help_48;
			this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnHelp.Location = new System.Drawing.Point(140, 0);
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.Size = global::GVConverter.Properties.Settings.Default.SizeOfButtonMenu;
			this.btnHelp.TabIndex = 6;
			this.btnHelp.Text = "Help";
			this.btnHelp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnHelp.UseVisualStyleBackColor = true;
			this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
			// 
			// btnExit
			// 
			this.btnExit.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnExit.Font = global::GVConverter.Properties.Settings.Default.FontButtonMenu;
			this.btnExit.Image = global::GVConverter.Properties.Resources.phong_shading_close_48;
			this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnExit.Location = new System.Drawing.Point(70, 0);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = global::GVConverter.Properties.Settings.Default.SizeOfButtonMenu;
			this.btnExit.TabIndex = 5;
			this.btnExit.Text = "Exit";
			this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnSettingsProgramm
			// 
			this.btnSettingsProgramm.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnSettingsProgramm.Font = global::GVConverter.Properties.Settings.Default.FontButtonMenu;
			this.btnSettingsProgramm.Image = global::GVConverter.Properties.Resources.phong_shading_config_48;
			this.btnSettingsProgramm.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnSettingsProgramm.Location = new System.Drawing.Point(0, 0);
			this.btnSettingsProgramm.Name = "btnSettingsProgramm";
			this.btnSettingsProgramm.Size = global::GVConverter.Properties.Settings.Default.SizeOfButtonMenu;
			this.btnSettingsProgramm.TabIndex = 4;
			this.btnSettingsProgramm.Text = "Settings";
			this.btnSettingsProgramm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSettingsProgramm.UseVisualStyleBackColor = true;
			this.btnSettingsProgramm.Click += new System.EventHandler(this.btnSettingsProgramm_Click);
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.WorkerReportsProgress = true;
			this.backgroundWorker1.WorkerSupportsCancellation = true;
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
			this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1159, 670);
			this.Controls.Add(this.splitContainerMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "FormMain";
			this.Text = "GeoView Converter";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormMain_KeyPress);
			this.groupBoxLocationDB.ResumeLayout(false);
			this.groupBoxLocationDB.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDomains)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPageTables.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablesArcGISViewData)).EndInit();
			this.tabPageDomains.ResumeLayout(false);
			this.splitContainer3.Panel1.ResumeLayout(false);
			this.splitContainer3.Panel1.PerformLayout();
			this.splitContainer3.Panel2.ResumeLayout(false);
			this.splitContainer3.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
			this.splitContainer3.ResumeLayout(false);
			this.groupBoxData.ResumeLayout(false);
			this.tabControlMain.ResumeLayout(false);
			this.tabPageArcGIS.ResumeLayout(false);
			this.tabPageGiscuit.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.PerformLayout();
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewGiscuitViewData)).EndInit();
			this.tabPage1.ResumeLayout(false);
			this.splitContainer4.Panel1.ResumeLayout(false);
			this.splitContainer4.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
			this.splitContainer4.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.tabPageConvertDomainsToPostgis.ResumeLayout(false);
			this.groupBox13.ResumeLayout(false);
			this.splitContainer6.Panel1.ResumeLayout(false);
			this.splitContainer6.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
			this.splitContainer6.ResumeLayout(false);
			this.groupBox10.ResumeLayout(false);
			this.groupBox10.PerformLayout();
			this.groupBox11.ResumeLayout(false);
			this.groupBox11.PerformLayout();
			this.groupBox12.ResumeLayout(false);
			this.groupBox12.PerformLayout();
			this.tabPageConvertToArcGIS.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.splitContainer5.Panel1.ResumeLayout(false);
			this.splitContainer5.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
			this.splitContainer5.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.groupBox7.PerformLayout();
			this.groupBox8.ResumeLayout(false);
			this.groupBox8.PerformLayout();
			this.groupBox9.ResumeLayout(false);
			this.groupBox9.PerformLayout();
			this.tabPageConvertDomainsToArcGIS.ResumeLayout(false);
			this.groupBox14.ResumeLayout(false);
			this.groupBox14.PerformLayout();
			this.splitContainer7.Panel1.ResumeLayout(false);
			this.splitContainer7.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
			this.splitContainer7.ResumeLayout(false);
			this.groupBox15.ResumeLayout(false);
			this.groupBox15.PerformLayout();
			this.groupBox16.ResumeLayout(false);
			this.groupBox16.PerformLayout();
			this.groupBox17.ResumeLayout(false);
			this.groupBox17.PerformLayout();
			this.splitContainerMain.Panel1.ResumeLayout(false);
			this.splitContainerMain.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
			this.splitContainerMain.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLocationDB;
        private System.Windows.Forms.TextBox textBoxLocationFolderGDB;
        private System.Windows.Forms.Button btnGetDataArcGISViewData;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label Domains;
        private System.Windows.Forms.ListBox listBoxOfDomainsViewData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDomains;
        private System.Windows.Forms.Button btnExportDomainToXML;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxSplitPolicy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMergePolicy;
        private System.Windows.Forms.TextBox textBoxFieldType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDomains;
        private System.Windows.Forms.TabPage tabPageTables;
        private System.Windows.Forms.ListBox listBoxOfTablesArcGISViewData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxYmax;
        private System.Windows.Forms.TextBox textBoxYmin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxXmax;
        private System.Windows.Forms.TextBox textBoxXmin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridViewTablesArcGISViewData;
        private System.Windows.Forms.TextBox textBoxZmax;
        private System.Windows.Forms.TextBox textBoxZmin;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageArcGIS;
        private System.Windows.Forms.TabPage tabPageGiscuit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGetDataGiscuitViewData;
        private System.Windows.Forms.ListBox listBoxOfTablesGuscuit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridViewGiscuitViewData;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnSettingsProgramm;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Button btnGetTablesArcGISConvert;
        private System.Windows.Forms.Button btnGetTablesGiscuitConvert;
        private System.Windows.Forms.ListBox listBoxTablesArcGISConvert;
        private System.Windows.Forms.ListBox listBoxTablesGiscuitConvert;
        private System.Windows.Forms.Button btnRunConvertArcGISToGiscuit;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxTypeShapeArcGISConvert;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxTypeShapeGiscuitConvert;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnCreateTableFromArcGISConvert;
        private System.Windows.Forms.TextBox textBoxTotalTablesArcGISConvert;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxTotalTablesGiscuitConvert;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnArcGISBrowseFolder;
        private System.Windows.Forms.Button btnDeleteTableGiscuit;
        private System.Windows.Forms.Button btnConvertOverwriteData;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btbBrowseConvertTab;
        private System.Windows.Forms.TextBox textBoxGDBLocation;
        private System.Windows.Forms.RadioButton radioButtonByDefaultArcGIS;
        private System.Windows.Forms.RadioButton radioButtonSortByNameArcGIS;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.RadioButton radioButtonByDefaultGiscuit;
        private System.Windows.Forms.RadioButton radioButtonSortByNameGiscuit;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnClearDataGiscuitTable;
        private System.Windows.Forms.TabPage tabPageConvertToArcGIS;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button brnOverwriteConvertToArcGIS;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnAppendConvertToArcGIS;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnClearDataArcGISTableConvertToArcGIS;
        private System.Windows.Forms.RadioButton radioButtonSortByDefaultGiscuitConvertToArcGIS;
        private System.Windows.Forms.RadioButton radioButtonSortByNameGiscuitConvertToArcGIS;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnDeleteTableArcGISConvetToArcGIS;
        private System.Windows.Forms.TextBox textBoxTotalTablesGiscuitConvertToAcrGIS;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnCreateTableFromGiscuitConvertToArcGIS;
        private System.Windows.Forms.TextBox textBoxTypeShapeGiscuitConvertToArcGIS;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ListBox listBoxTablesGiscuitConvertToArcGIS;
        private System.Windows.Forms.Button btnGetDataGiscuitConvertToArcGIS;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btbBrowseFileGDBConvertToArcGIS;
        private System.Windows.Forms.TextBox textBoxGDBLocationConvertToArcGIS;
        private System.Windows.Forms.RadioButton radioButtonSortByDefaultArcGISConvertToArcGIS;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.RadioButton radioButtonSortByNameArcGISConvertToArcGIS;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBoxTotalTablesArcGISConvertToArcGIS;
        private System.Windows.Forms.TextBox textBoxTypeShapeArcGISConvertToArcGIS;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ListBox listBoxTablesArcGISConvertToArcGIS;
        private System.Windows.Forms.Button btnGetTablesArcGISConvertToAcrGIS;
        private System.Windows.Forms.ProgressBar progressBarConvertToGiscuit;
        private System.Windows.Forms.Label labelBackgroubndWorkerConvertToGiscuit;
        private System.Windows.Forms.Label labelBackgroubndWorkerCompleteConvertToGiscuit;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxTotalRowsGiscuitViewData;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TabPage tabPageConvertDomainsToPostgis;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Button btnOverwriteRowDomainGiscuit;
        private System.Windows.Forms.Button btnInsertRowDomainGiscuit;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button btbBrowseFileGDBConvertDoamins;
        private System.Windows.Forms.TextBox textBoxGDBLocationConvertDomains;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox textBoxConvertDomainsTotalTablesArcGIS;
        private System.Windows.Forms.ListBox listBoxConvertDomainsArcGIS;
        private System.Windows.Forms.Button btnConvertDomainsRefreshArcGIS;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TextBox textBoxConvertDomainsTotalTablesGiscuit;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Button btnConvertDomainsCreateTableGiscuit;
        private System.Windows.Forms.ListBox listBoxConvertDomainsGiscuit;
        private System.Windows.Forms.Button btnConvertDomainsRefreshGiscuit;
        private System.Windows.Forms.RadioButton radioBtnDomainArcGisSortDefault;
        private System.Windows.Forms.RadioButton radioBtnDomainArcGisSortByName;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.RadioButton radioBtnConvertDomainPostGisSortDefault;
        private System.Windows.Forms.RadioButton radioBtnConvertDomainPostGisSortByName;
        private System.Windows.Forms.Label label35;
		private System.Windows.Forms.TabPage tabPageConvertDomainsToArcGIS;
		private System.Windows.Forms.GroupBox groupBox14;
		private System.Windows.Forms.Button btnOverwriteConvertDomainToArcGIS;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.SplitContainer splitContainer7;
		private System.Windows.Forms.GroupBox groupBox15;
		private System.Windows.Forms.RadioButton rdBtnDomainFromPostGisSortDefault;
		private System.Windows.Forms.RadioButton rdBtnDomainFromPostGisSortByName;
		private System.Windows.Forms.Label label38;
		private System.Windows.Forms.TextBox txtBoxFromPostGisDomainsCount;
		private System.Windows.Forms.Label label39;
		private System.Windows.Forms.ListBox listBoxConvertDomainsFromPostGis;
		private System.Windows.Forms.Button btnRefreshPostGisDomains;
		private System.Windows.Forms.GroupBox groupBox16;
		private System.Windows.Forms.GroupBox groupBox17;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.RadioButton rdBtnDomainToArcGisSortDefault;
		private System.Windows.Forms.Label label41;
		private System.Windows.Forms.RadioButton rdBtnDomainToArcGisSortByName;
		private System.Windows.Forms.Label label42;
		private System.Windows.Forms.TextBox txtBoxToArcGisDomainsCount;
		private System.Windows.Forms.ListBox listBoxConvertDomainsToArcGis;
		private System.Windows.Forms.Button btnRefreshArcGisDomains;
	}
}

