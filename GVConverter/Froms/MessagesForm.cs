using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GVConverter.Froms
{
    public partial class messageWindow : Form
    {
        public messageWindow()
        {
            InitializeComponent();
        }

        private void clearBox_Click(object sender, EventArgs e)
        {
            textBoxSystemMessages.Clear();
            CallBackMy.callbackClearHandler(null);

            //var mainform = new FormMain();
            //textBoxSystemMessages.Text = mainform.systemMessages.ToString();

            //            this.textBoxSystemMessages.Text
        }
    }
}
