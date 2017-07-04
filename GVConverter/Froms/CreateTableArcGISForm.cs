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
    public partial class CreateTableArcGISForm : Form
    {
        private readonly string _shapeTypeGiscuit;
        private readonly string _tableName;
        private readonly string _srid;
        private readonly DataTable _dataTable;

        public CreateTableArcGISForm(string shapeTypeGiscuit, string tableName, DataTable dataTable, string srid)
        {
            InitializeComponent();
            _shapeTypeGiscuit = shapeTypeGiscuit;
            _tableName = tableName;
            textBoxNameTable.Text = _tableName;
            _dataTable = dataTable;
            _srid = srid;
        }

        private void btnCrateTable_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            new WorkArcGIS().CreateNewTable(_shapeTypeGiscuit, textBoxNameTable.Text, _srid);
            new WorkArcGIS().AddFieldToNewTable(_dataTable, textBoxNameTable.Text);
            Cursor.Current = Cursors.Default;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
