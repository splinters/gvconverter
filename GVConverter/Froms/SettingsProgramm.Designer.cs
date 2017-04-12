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
            this.textBoxIPDataBase = new System.Windows.Forms.TextBox();
            this.textBoxNameDataBasePostgreSQL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxLoginPostgreSQL = new System.Windows.Forms.TextBox();
            this.textBoxPasswordPostgreSQL = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxIPSSH = new System.Windows.Forms.TextBox();
            this.textBoxPortSSH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPasswordSSH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLoginSSH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnResetSettingsDefault = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnArcGISBrowseFolder);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxPathGDBFolder);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ArcGIS";
            // 
            // btnArcGISBrowseFolder
            // 
            this.btnArcGISBrowseFolder.Location = new System.Drawing.Point(621, 35);
            this.btnArcGISBrowseFolder.Name = "btnArcGISBrowseFolder";
            this.btnArcGISBrowseFolder.Size = new System.Drawing.Size(75, 23);
            this.btnArcGISBrowseFolder.TabIndex = 1;
            this.btnArcGISBrowseFolder.Text = "Browse...";
            this.btnArcGISBrowseFolder.UseVisualStyleBackColor = true;
            this.btnArcGISBrowseFolder.Click += new System.EventHandler(this.btnArcGISBrowseFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Geodatabase (gdb) location";
            // 
            // textBoxPathGDBFolder
            // 
            this.textBoxPathGDBFolder.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GVConverter.Properties.Settings.Default, "PathToGDBFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxPathGDBFolder.Location = new System.Drawing.Point(9, 37);
            this.textBoxPathGDBFolder.Name = "textBoxPathGDBFolder";
            this.textBoxPathGDBFolder.Size = new System.Drawing.Size(606, 20);
            this.textBoxPathGDBFolder.TabIndex = 0;
            this.textBoxPathGDBFolder.Text = global::GVConverter.Properties.Settings.Default.PathToGDBFolder;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(702, 134);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PostGIS";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxIPDataBase);
            this.groupBox4.Controls.Add(this.textBoxNameDataBasePostgreSQL);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.textBoxLoginPostgreSQL);
            this.groupBox4.Controls.Add(this.textBoxPasswordPostgreSQL);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(295, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(401, 100);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data base";
            // 
            // textBoxIPDataBase
            // 
            this.textBoxIPDataBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GVConverter.Properties.Settings.Default, "IPDataBasePostrgeSQL", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxIPDataBase.Location = new System.Drawing.Point(71, 15);
            this.textBoxIPDataBase.Name = "textBoxIPDataBase";
            this.textBoxIPDataBase.Size = new System.Drawing.Size(100, 20);
            this.textBoxIPDataBase.TabIndex = 16;
            this.textBoxIPDataBase.Text = global::GVConverter.Properties.Settings.Default.IPDataBasePostrgeSQL;
            // 
            // textBoxNameDataBasePostgreSQL
            // 
            this.textBoxNameDataBasePostgreSQL.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GVConverter.Properties.Settings.Default, "NameDataBasePostgreSQL", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxNameDataBasePostgreSQL.Location = new System.Drawing.Point(196, 42);
            this.textBoxNameDataBasePostgreSQL.Name = "textBoxNameDataBasePostgreSQL";
            this.textBoxNameDataBasePostgreSQL.Size = new System.Drawing.Size(199, 20);
            this.textBoxNameDataBasePostgreSQL.TabIndex = 9;
            this.textBoxNameDataBasePostgreSQL.Text = global::GVConverter.Properties.Settings.Default.NameDataBasePostgreSQL;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(193, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Name data base";
            // 
            // textBoxLoginPostgreSQL
            // 
            this.textBoxLoginPostgreSQL.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GVConverter.Properties.Settings.Default, "LoginDataBasePostgreSQL", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxLoginPostgreSQL.Location = new System.Drawing.Point(71, 42);
            this.textBoxLoginPostgreSQL.Name = "textBoxLoginPostgreSQL";
            this.textBoxLoginPostgreSQL.Size = new System.Drawing.Size(100, 20);
            this.textBoxLoginPostgreSQL.TabIndex = 7;
            this.textBoxLoginPostgreSQL.Text = global::GVConverter.Properties.Settings.Default.LoginDataBasePostgreSQL;
            // 
            // textBoxPasswordPostgreSQL
            // 
            this.textBoxPasswordPostgreSQL.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GVConverter.Properties.Settings.Default, "PasswordDataBasePostgreSQL", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxPasswordPostgreSQL.Location = new System.Drawing.Point(70, 69);
            this.textBoxPasswordPostgreSQL.Name = "textBoxPasswordPostgreSQL";
            this.textBoxPasswordPostgreSQL.Size = new System.Drawing.Size(100, 20);
            this.textBoxPasswordPostgreSQL.TabIndex = 8;
            this.textBoxPasswordPostgreSQL.Text = global::GVConverter.Properties.Settings.Default.PasswordDataBasePostgreSQL;
            this.textBoxPasswordPostgreSQL.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Login";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Password";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "IP";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxIPSSH);
            this.groupBox3.Controls.Add(this.textBoxPortSSH);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBoxPasswordSSH);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBoxLoginSSH);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(9, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SSH Tunnel";
            // 
            // textBoxIPSSH
            // 
            this.textBoxIPSSH.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GVConverter.Properties.Settings.Default, "IPSSH", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxIPSSH.Location = new System.Drawing.Point(70, 16);
            this.textBoxIPSSH.Name = "textBoxIPSSH";
            this.textBoxIPSSH.Size = new System.Drawing.Size(100, 20);
            this.textBoxIPSSH.TabIndex = 8;
            this.textBoxIPSSH.Text = global::GVConverter.Properties.Settings.Default.IPSSH;
            // 
            // textBoxPortSSH
            // 
            this.textBoxPortSSH.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GVConverter.Properties.Settings.Default, "PortSSH", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxPortSSH.Location = new System.Drawing.Point(209, 16);
            this.textBoxPortSSH.Name = "textBoxPortSSH";
            this.textBoxPortSSH.Size = new System.Drawing.Size(65, 20);
            this.textBoxPortSSH.TabIndex = 3;
            this.textBoxPortSSH.Text = "5432";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(176, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Port";
            // 
            // textBoxPasswordSSH
            // 
            this.textBoxPasswordSSH.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GVConverter.Properties.Settings.Default, "PasswordSSH", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxPasswordSSH.Location = new System.Drawing.Point(70, 70);
            this.textBoxPasswordSSH.Name = "textBoxPasswordSSH";
            this.textBoxPasswordSSH.Size = new System.Drawing.Size(204, 20);
            this.textBoxPasswordSSH.TabIndex = 5;
            this.textBoxPasswordSSH.Text = global::GVConverter.Properties.Settings.Default.PasswordSSH;
            this.textBoxPasswordSSH.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Login";
            // 
            // textBoxLoginSSH
            // 
            this.textBoxLoginSSH.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GVConverter.Properties.Settings.Default, "LoginSSH", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxLoginSSH.Location = new System.Drawing.Point(70, 43);
            this.textBoxLoginSSH.Name = "textBoxLoginSSH";
            this.textBoxLoginSSH.Size = new System.Drawing.Size(204, 20);
            this.textBoxLoginSSH.TabIndex = 4;
            this.textBoxLoginSSH.Text = global::GVConverter.Properties.Settings.Default.LoginSSH;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "IP";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(285, 241);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSettings.TabIndex = 10;
            this.btnSaveSettings.Text = "Save";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(366, 241);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnResetSettingsDefault
            // 
            this.btnResetSettingsDefault.Location = new System.Drawing.Point(633, 241);
            this.btnResetSettingsDefault.Name = "btnResetSettingsDefault";
            this.btnResetSettingsDefault.Size = new System.Drawing.Size(75, 23);
            this.btnResetSettingsDefault.TabIndex = 12;
            this.btnResetSettingsDefault.Text = "Default";
            this.btnResetSettingsDefault.UseVisualStyleBackColor = true;
            this.btnResetSettingsDefault.Click += new System.EventHandler(this.btnResetSettingsDefault_Click);
            // 
            // SettingsProgramm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 273);
            this.Controls.Add(this.btnResetSettingsDefault);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsProgramm";
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPathGDBFolder;
        private System.Windows.Forms.Button btnArcGISBrowseFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxPasswordSSH;
        private System.Windows.Forms.TextBox textBoxLoginSSH;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBoxPortSSH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLoginPostgreSQL;
        private System.Windows.Forms.TextBox textBoxPasswordPostgreSQL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNameDataBasePostgreSQL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxIPSSH;
        private System.Windows.Forms.TextBox textBoxIPDataBase;
        private System.Windows.Forms.Button btnResetSettingsDefault;
    }
}