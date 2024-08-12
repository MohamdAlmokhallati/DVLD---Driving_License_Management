using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ManageDetainedLicenses : Form
    {
        public ManageDetainedLicenses()
        {
            InitializeComponent();
        }
        private void _setdgvApplicationTable(string query)
        {
            DataView dv = new DataView(clsDetainedLicense.GetAllDetainedLicense());
            if (!String.IsNullOrEmpty(query))
            {
                dgvDetainedLicense.DataSource = dv.RowFilter = query;
            }

            dgvDetainedLicense.DataSource = dv;
        }
        private void ManageDetainedLicenses_Load(object sender, EventArgs e)
        {
            _setdgvApplicationTable("");
        }
    }
}
