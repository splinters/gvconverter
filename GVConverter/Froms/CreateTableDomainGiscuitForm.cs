using System;
using System.Windows.Forms;
using GVConverter.Classes;

namespace GVConverter.Froms
{
    public partial class CreateTableDomainGiscuitForm : Form
    {
        public CreateTableDomainGiscuitForm(string tableName)
        {
            InitializeComponent();
            textBoxNameTable.Text = tableName;
        }

        private void btnCrateTable_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            WorkGiscuit.CreateNewDomainTable(textBoxNameTable.Text);
            Cursor.Current = Cursors.Default;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
