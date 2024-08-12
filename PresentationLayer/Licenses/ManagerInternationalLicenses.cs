using BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ManagerInternationalLicenses : Form
    {
        public ManagerInternationalLicenses()
        {
            InitializeComponent();
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilters.SelectedIndex == 0)
            {
                tbFilter.Visible = false;
                return;
            }
            if (cbFilters.SelectedIndex == cbFilters.FindString("Status"))
            {
                tbFilter.Visible = false;
                cbStatusFiltes.SelectedIndex = 0;
                cbStatusFiltes.Visible = true;
                return;
            }
            cbStatusFiltes.Visible = false;
            tbFilter.Visible = true;
        }
        private void _setdgvUsersTable(string query)
        {
            DataView dv = new DataView(clsInternationalLicense.GetAllInternationalLicenses());
            if (!String.IsNullOrEmpty(query))
            {
                dgvApplicationsTable.DataSource = dv.RowFilter = query;
            }

            dgvApplicationsTable.DataSource = dv;
        }
        private void ManagerInternationalLicenses_Load(object sender, EventArgs e)
        {
            _setdgvUsersTable("");
        }

        private void btnAddNewApplication_Click(object sender, EventArgs e)
        {
            AddInternationalLicense addInternationalLicense = new AddInternationalLicense();
            addInternationalLicense.ShowDialog();
        }
    }
}
