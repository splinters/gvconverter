using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GVConverter.Classes;

namespace GVConverter.Froms
{
    public partial class Connect : Form
    {
        public Connect()
        {
            InitializeComponent();

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            StaticVariables.LoginDataBasePostgreSQL = this.LoginName.Text;
            StaticVariables.PasswordDataBasePostgreSQL = this.Password.Text;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
