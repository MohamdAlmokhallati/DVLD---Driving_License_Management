using BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ManageTestTypes : Form
    {
        public ManageTestTypes()
        {
            InitializeComponent();
        }

        private void _setdgvTestTypesTable(string query)
        {
            DataView dv = new DataView(clsTestType.GetAllTestTypes());
            if (!String.IsNullOrEmpty(query))
            {
                dgvTestTypesTable.DataSource = dv.RowFilter = query;
            }

            dgvTestTypesTable.DataSource = dv;
        }

        private void ManageTestTypes_Load(object sender, EventArgs e)
        {
            _setdgvTestTypesTable("");
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selecedTestTypeID = Convert.ToInt32(dgvTestTypesTable.Rows[dgvTestTypesTable.CurrentRow.Index].Cells[0].Value);
            EditTestType editTestType = new EditTestType(selecedTestTypeID);

            editTestType.ShowDialog();
            _setdgvTestTypesTable("");
        }
    }
}
