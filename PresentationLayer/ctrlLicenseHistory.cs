using BusinessLayer;
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


    }
}
