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
    public partial class ReplacementForDamgaedLicense : Form
    {
        public ReplacementForDamgaedLicense()
        {
            InitializeComponent();
        }

        private void ReplacementForDamgaedLicense_Load(object sender, EventArgs e)
        {
            clsApplicationType applicationType = clsApplicationType.GetApplicationType(4);
            lbApplicationDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
            lbApplicatinoFees.Text = applicationType.ApplicationTypFees.ToString("0.##€");
            lbApplicatinoFees.Tag = applicationType.ApplicationTypFees;

            lbCreatedBy.Text = CurrentLogedinUser.currentUser.UserName;
        }

        private void btnIssueReplacement_Click(object sender, EventArgs e)
        {
            if(ctrlLicensesFinder1.license == null)
            {
                MessageBox.Show("You have no License Selected!");
                return;
            }
            if(!ctrlLicensesFinder1.license.IsActive)
            {
                MessageBox.Show("This License is no Active!");
                return;
            }

            clsLicense license = ctrlLicensesFinder1.license;

            license.IsActive = false;
            if (license.Save())
            {
                clsApplicationType applicationType = clsApplicationType.GetApplicationType(4);

                clsApplication application = new clsApplication(license.Driver, DateTime.Now,
                    applicationType, DateTime.Now, "New", (decimal)lbApplicatinoFees.Tag, CurrentLogedinUser.currentUser
                    );


                if (application.SaveApp())
                {
                    int issueResun = rbDamagedLicense.Checked ? 3 : 4;



                    clsLicense newLicense = new clsLicense(application, license.Driver,
                        license.LicenseClass, DateTime.Now, license.ExpirationDate,
                        "", application.PaidFees, true, issueResun, CurrentLogedinUser.currentUser);

                    if (newLicense.Save())
                    {
                        MessageBox.Show($"New License Has been Issued with ID {newLicense.LicenseId}");
                        return;
                    }
                }

            }

            MessageBox.Show($"An Error,Try Again!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }

        private void ctrlLicensesFinder1_OnDrivingLicenseSelected(clsLicense obj)
        {
            
            if(!obj.IsActive)
            {
                MessageBox.Show("This License is no Active!");
            }
        }
    }
}
