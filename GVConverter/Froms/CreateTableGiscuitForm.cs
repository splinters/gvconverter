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
    public partial class CreateTableGiscuitForm : Form
    {
        private readonly string _shapeTypeArcGis;
        private readonly string _tableName;

        public CreateTableGiscuitForm(string shapeTypeArcGis, string tableName)
        {
            InitializeComponent();
            textBoxNameTable.Text = tableName;
            _shapeTypeArcGis = shapeTypeArcGis;
            _tableName = tableName;
        }

        private void btnCrateTable_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            WorkGiscuit.CreateNewTable(_shapeTypeArcGis, _tableName, textBoxNameTable.Text);
            Cursor.Current = Cursors.Default;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
