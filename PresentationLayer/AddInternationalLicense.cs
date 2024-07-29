using BusinessLayer;
using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class AddInternationalLicense : Form
    {
        public AddInternationalLicense()
        {
            InitializeComponent();
        }
        
        private void AddInternationalLicense_Load(object sender, EventArgs e)
        {


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsApplicationType applicationType = clsApplicationType.GetApplicationType(6);


            clsApplication application = new clsApplication(ctrlLicenseFinder1.license.Driver, DateTime.Now,
        applicationType, DateTime.Now, "Completed", applicationType.ApplicationTypFees, CurrentLogedinUser.currentUser);

            if((!ctrlLicenseFinder1.license.IsActive) || ctrlLicenseFinder1.license.ExpirationDate < DateTime.Now)
            {
                MessageBox.Show("this License is not Active!");
                return;
            }



            if(application.SaveApp())
            {
                clsInternationalLicense internationalLicense = new clsInternationalLicense(ctrlLicenseFinder1.license.Driver,
                    ctrlLicenseFinder1.license.LicenseId, application.ApplicationDate, application.ApplicationDate.AddYears(1),
                    true, CurrentLogedinUser.currentUser, application);
                if(internationalLicense.SaveLicense())
                {
                    MessageBox.Show($"International License has been Issued with ID {internationalLicense.InternationalLicenseID}");
                }
                else
                {
                    MessageBox.Show("Somthing went worng please try again later!","",MessageBoxButtons.OK,MessageBoxIcon.Error);

                }



            }
        }
    }
}
