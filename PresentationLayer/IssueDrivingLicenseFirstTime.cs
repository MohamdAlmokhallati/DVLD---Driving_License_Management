using BusinessLayer;
using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class IssueDrivingLicenseFirstTime : Form
    {

        clsLocalDrivingLicenseApplication ldla;

        public IssueDrivingLicenseFirstTime(clsLocalDrivingLicenseApplication ldla)
        {
            InitializeComponent();
            this.ldla = ldla;
            drivingLicenseApplicationInfo1._PutDLDItems(ldla);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (ldla.Person.IsDriver())
            {
                clsDriver driver1 = clsDriver.GetDriverByPersonID(ldla.Person.getPersonID());
                clsLicense license = new clsLicense(ldla, driver1, ldla.LicenseClass, DateTime.Now,
            DateTime.Now.AddYears(ldla.LicenseClass.DefaultValidityLength), tbNotes.Text, 0, true, 1, CurrentLogedinUser.currentUser);

                if (license.Save())
                {
                    clsApplication.ChangeApplicationStatus(ldla.ApplicationID, 3);
                    MessageBox.Show($"License Has been issued with ID {license.LicenseId} !");
                }
                else
                {
                    MessageBox.Show("Somthing went wrong!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
                return;
            }


            clsDriver driver = new clsDriver(CurrentLogedinUser.currentUser, DateTime.Now, ldla.Person);

            if (driver.Save())
            {


                clsLicense license = new clsLicense(ldla, driver, ldla.LicenseClass, DateTime.Now,
                    DateTime.Now.AddYears(ldla.LicenseClass.DefaultValidityLength), tbNotes.Text, 0, true, 1, CurrentLogedinUser.currentUser);

                if (license.Save())
                {
                    clsApplication.ChangeApplicationStatus(ldla.ApplicationID, 3);
                    MessageBox.Show($"License Has been issued with ID {license.LicenseId} !");
                }
                else
                {
                    MessageBox.Show("Somthing went wrong!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Somthing went wrong!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
