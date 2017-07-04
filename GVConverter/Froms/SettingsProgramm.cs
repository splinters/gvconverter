using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using GVConverter.Classes;

namespace GVConverter.Froms
{
    public partial class SettingsProgramm : Form
    {
        public SettingsProgramm()
        {
            InitializeComponent();
            Properties.Settings.Default.Reload();
        }

        private void btnArcGISBrowseFolder_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = folderBrowserDialog1.ShowDialog();
            folderBrowserDialog1.Description = @"Select Geodatabase folder";
            if (dialogResult == DialogResult.OK)
                textBoxPathGDBFolder.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            Close();
            CallBackMy.callbackEventHandler("save config");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnResetSettingsDefault_Click(object sender, EventArgs e)
        {
            
            Properties.Settings.Default.Reset();
        }

        private void textBoxRowsLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }

            }
        }
    }
}
