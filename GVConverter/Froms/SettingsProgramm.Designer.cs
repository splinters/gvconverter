namespace GVConverter.Froms
{
    partial class SettingsProgramm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnArcGISBrowseFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPathGDBFolder = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxLogMessage = new System.Windows.Forms.CheckBox();
            this.textBoxRowsLimit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBoxPortSSH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxIPDataBase = new System.Windows.Forms.TextBox();
            this.textBoxNameDataBasePostgreSQL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnResetSettingsDefault = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnArcGISBrowseFolder);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxPathGDBFolder);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(590, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ArcGIS";
            // 
            // btnArcGISBrowseFolder
            // 
            this.btnArcGISBrowseFolder.Location = new System.Drawing.Point(464, 46);
            this.btnArcGISBrowseFolder.Margin = new System.Windows.Forms.Padding(4);
            this.btnArcGISBrowseFolder.Name = "btnArcGISBrowseFolder";
            this.btnArcGISBrowseFolder.Size = new System.Drawing.Size(100, 28);
            this.btnArcGISBrowseFolder.TabIndex = 1;
            this.btnArcGISBrowseFolder.Text = "Browse...";
            this.btnArcGISBrowseFolder.UseVisualStyleBackColor = true;
            this.btnArcGISBrowseFolder.Click += new System.EventHandler(this.btnArcGISBrowseFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Geodatabase (gdb) location";
            // 
            // textBoxPathGDBFolder
            // 
            this.textBoxPathGDBFolder.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GVConverter.Properties.Settings.Default, "PathToGDBFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxPathGDBFolder.Location = new System.Drawing.Point(12, 46);
            this.textBoxPathGDBFolder.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPathGDBFolder.Name = "textBoxPathGDBFolder";
            this.textBoxPathGDBFolder.Size = new System.Drawing.Size(432, 22);
            this.textBoxPathGDBFolder.TabIndex = 0;
            this.textBoxPathGDBFolder.Text = global::GVConverter.Properties.Settings.Default.PathToGDBFolder;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(16, 123);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(590, 203);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PostGIS";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxLogMessage);
            this.groupBox4.Controls.Add(this.textBoxRowsLimit);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.textBoxPortSSH);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.textBoxIPDataBase);
            this.groupBox4.Controls.Add(this.textBoxNameDataBasePostgreSQL);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(12, 23);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(570, 172);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data base";
            // 
            // checkBoxLogMessage
            // 
            this.checkBoxLogMessage.AutoSize = true;
            this.checkBoxLogMessage.Checked = global::GVConverter.Properties.Settings.Default.LogMessage;
            this.checkBoxLogMessage.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::GVConverter.Properties.Settings.Default, "LogMessage", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxLogMessage.Location = new System.Drawing.Point(446, 137);
            this.checkBoxLogMessage.Name = "checkBoxLogMessage";
            this.checkBoxLogMessage.Size = new System.Drawing.Size(122, 21);
            this.checkBoxLogMessage.TabIndex = 20;
            this.checkBoxLogMessage.Text = "Log Messages";
            this.checkBoxLogMessage.UseVisualStyleBackColor = true;
            // 
            // textBoxRowsLimit
            // 
            this.textBoxRowsLimit.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GVConverter.Properties.Settings.Default, "pgrowslimit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxRowsLimit.Location = new System.Drawing.Point(95, 138);
            this.textBoxRowsLimit.Name = "textBoxRowsLimit";
            this.textBoxRowsLimit.Size = new System.Drawing.Size(154, 22);
            this.textBoxRowsLimit.TabIndex = 19;
            this.textBoxRowsLimit.Text = global::GVConverter.Properties.Settings.Default.pgrowslimit;
            this.textBoxRowsLimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRowsLimit_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Rows limit";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.checkBox2);
            this.groupBox5.Controls.Add(this.checkBox1);
            this.groupBox5.Location = new System.Drawing.Point(291, 18);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(261, 85);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Transform";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "To PostGIS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(169, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "To ArcGIS";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = global::GVConverter.Properties.Settings.Default.Postgis2ArcgisEPSG2039;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::GVConverter.Properties.Settings.Default, "Postgis2ArcgisEPSG2039", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox2.Location = new System.Drawing.Point(151, 46);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(104, 21);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "EPSG:2039";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = global::GVConverter.Properties.Settings.Default.Arcgis2PostgisWGS84;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::GVConverter.Properties.Settings.Default, "Arcgis2PostgisWGS84", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox1.Location = new System.Drawing.Point(6, 46);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(105, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "To WGS-84";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBoxPortSSH
            // 
            this.textBoxPortSSH.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GVConverter.Properties.Settings.Default, "PortSSH", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxPortSSH.Location = new System.Drawing.Point(95, 58);
            this.textBoxPortSSH.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPortSSH.Name = "textBoxPortSSH";
            this.textBoxPortSSH.Size = new System.Drawing.Size(153, 22);
            this.textBoxPortSSH.TabIndex = 3;
            this.textBoxPortSSH.Text = "5432";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Port";
            // 
            // textBoxIPDataBase
            // 
            this.textBoxIPDataBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GVConverter.Properties.Settings.Default, "IPDataBasePostrgeSQL", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxIPDataBase.Location = new System.Drawing.Point(95, 18);
            this.textBoxIPDataBase.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIPDataBase.Name = "textBoxIPDataBase";
            this.textBoxIPDataBase.Size = new System.Drawing.Size(153, 22);
            this.textBoxIPDataBase.TabIndex = 16;
            this.textBoxIPDataBase.Text = global::GVConverter.Properties.Settings.Default.IPDataBasePostrgeSQL;
            // 
            // textBoxNameDataBasePostgreSQL
            // 
            this.textBoxNameDataBasePostgreSQL.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GVConverter.Properties.Settings.Default, "NameDataBasePostgreSQL", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxNameDataBasePostgreSQL.Location = new System.Drawing.Point(96, 98);
            this.textBoxNameDataBasePostgreSQL.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNameDataBasePostgreSQL.Name = "textBoxNameDataBasePostgreSQL";
            this.textBoxNameDataBasePostgreSQL.Size = new System.Drawing.Size(153, 22);
            this.textBoxNameDataBasePostgreSQL.TabIndex = 9;
            this.textBoxNameDataBasePostgreSQL.Text = global::GVConverter.Properties.Settings.Default.NameDataBasePostgreSQL;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(8, 98);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 22);
            this.label9.TabIndex = 15;
            this.label9.Text = "Name";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "IP";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(16, 350);
            this.btnSaveSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(100, 28);
            this.btnSaveSettings.TabIndex = 10;
            this.btnSaveSettings.Text = "Save";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(124, 350);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnResetSettingsDefault
            // 
            this.btnResetSettingsDefault.Location = new System.Drawing.Point(498, 350);
            this.btnResetSettingsDefault.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetSettingsDefault.Name = "btnResetSettingsDefault";
            this.btnResetSettingsDefault.Size = new System.Drawing.Size(100, 28);
            this.btnResetSettingsDefault.TabIndex = 12;
            this.btnResetSettingsDefault.Text = "Default";
            this.btnResetSettingsDefault.UseVisualStyleBackColor = true;
            this.btnResetSettingsDefault.Click += new System.EventHandler(this.btnResetSettingsDefault_Click);
            // 
            // SettingsProgramm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 391);
            this.Controls.Add(this.btnResetSettingsDefault);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingsProgramm";
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPathGDBFolder;
        private System.Windows.Forms.Button btnArcGISBrowseFolder;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBoxPortSSH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNameDataBasePostgreSQL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxIPDataBase;
        private System.Windows.Forms.Button btnResetSettingsDefault;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBoxRowsLimit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxLogMessage;
    }
}