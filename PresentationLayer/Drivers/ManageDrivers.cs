using BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ManageDrivers : Form
    {
        public ManageDrivers()
        {
            InitializeComponent();
        }
        private void _setdgvApplicationTable(string query)
        {
            DataView dv = new DataView(clsDriver.GetAllDrivers());
            if (!String.IsNullOrEmpty(query))
            {
                dgvDrivers.DataSource = dv.RowFilter = query;
            }

            dgvDrivers.DataSource = dv;
        }
        private void ManageDrivers_Load(object sender, EventArgs e)
        {
            _setdgvApplicationTable("");
        }
    }
}
