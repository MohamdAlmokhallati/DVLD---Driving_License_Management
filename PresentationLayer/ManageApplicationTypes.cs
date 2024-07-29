using BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ManageApplicationTypes : Form
    {
        public ManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void _setdgvApplicationTable(string query)
        {
            DataView dv = new DataView(clsApplicationType.GetAllApplicationTypes());
            if (!String.IsNullOrEmpty(query))
            {
                dgvApplicationTypesTable.DataSource = dv.RowFilter = query;
            }

            dgvApplicationTypesTable.DataSource = dv;
        }

        private void ManageApplicationTypes_Load(object sender, EventArgs e)
        {
            _setdgvApplicationTable("");
        }
    }
}
