using BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ctrlLicenseHistory : UserControl
    {

        public ctrlLicenseHistory()
        {
            InitializeComponent();
        }

        public void SetTables(int personID)
        {
            _setdgvLocalLicenseTable(personID);
            _setdgvIntarnasionalLicenseTable(personID);
        }

        private void _setdgvLocalLicenseTable(int personID)
        {
            DataView dv = new DataView(clsLicense.GetAllLocalLicenseOfPerson(personID));

            dgvLocalLicenses.DataSource = dv;
        }



        private void _setdgvIntarnasionalLicenseTable(int personID)
        {
            DataView dv = new DataView(clsLicense.GetAllInternationalLicenseOfPerson(personID));


            dgvInternationalLicenses.DataSource = dv;
        }

        private void showLicenseToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            int selecedID = Convert.ToInt32(dgvLocalLicenses.Rows[dgvLocalLicenses.CurrentRow.Index].Cells[0].Value);
            clsLicense license = clsLicense.GetLicense(selecedID);
            DrivingLicense drivingLicense = new DrivingLicense(license);
            drivingLicense.ShowDialog();
        }
    }
}
