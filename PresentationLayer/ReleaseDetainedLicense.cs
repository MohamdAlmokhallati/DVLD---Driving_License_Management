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
    public partial class ReleaseDetainedLicense : Form
    {
        clsApplicationType ApplicationType {  get; set; }
        clsDetainedLicense DetainedLicense { get; set; }
        public ReleaseDetainedLicense()
        {
            InitializeComponent();
            ApplicationType = clsApplicationType.GetApplicationType(5);
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (DetainedLicense == null)
            {
                MessageBox.Show("There Is No License Selected!","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            clsApplication application = new clsApplication(DetainedLicense.Driver,
                DateTime.Now,ApplicationType,DateTime.Now, clsApplication.enApplicationStatus.Completed, (decimal)lbTotalFees.Tag,
                CurrentLogedinUser.currentUser);
            if(application.SaveApp())
            {
                DetainedLicense.ReleaseApplication = application;
                DetainedLicense.IsReleased = true;
                DetainedLicense.ReleaseDate = DateTime.Now;
                if(DetainedLicense.SaveDetainedLicense())
                {
                    MessageBox.Show("License Is Released");
                    return;
                }
            }
            MessageBox.Show("Somthing Went wrong! Try Again Late", "", MessageBoxButtons.OK, MessageBoxIcon.Error);





        }

        private void ctrlLicensesFinder1_OnDrivingLicenseSelected(BusinessLayer.clsLicense obj)
        {
            if(!clsDetainedLicense.IsDetained(obj.LicenseId))
            {
                MessageBox.Show("This License Is Not Detained!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnDetain.Enabled = false;
            }
            else
            {
                btnDetain.Enabled = true;
            }
        }

        private void _SetItems(clsDetainedLicense detainedLicense)
        {
            if (detainedLicense == null)
                return;
            
            lbDetainID.Text = detainedLicense.DetainedLicenseID.ToString();
            lbDetainDate.Text = detainedLicense.DetainDate.ToString("dd.MM.yyyy");

            lbApplicationFees.Text = ApplicationType.ApplicationTypFees.ToString("0.##€");
            lbApplicationFees.Tag = ApplicationType.ApplicationTypFees;

            lbFineFees.Text = detainedLicense.FineFees.ToString("0.##€");
            lbFineFees.Tag = detainedLicense.FineFees;

            lbTotalFees.Text = ((decimal)lbFineFees.Tag + (decimal)lbApplicationFees.Tag).ToString("0.##€");
            lbTotalFees.Tag = ((decimal)lbFineFees.Tag + (decimal)lbApplicationFees.Tag);

            lbCreatedBy.Text = detainedLicense.DetainBy.UserName.ToString();
            lbLicenseID.Text = detainedLicense.LicenseId.ToString();


        }

        private void ReleaseDetainedLicense_Load_1(object sender, EventArgs e)
        {

        }

        private void ctrlLicensesFinder1_OnDrivingLicenseSelected_1(clsLicense obj)
        {
            if (!clsDetainedLicense.IsDetained(obj.LicenseId))
            {
                MessageBox.Show("This License Is Not Detained!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnDetain.Enabled = false;
            }
            else
            {
                btnDetain.Enabled = true;
            }
            clsDetainedLicense detainedLicense = clsDetainedLicense.GetDetainedLicense(obj.LicenseId);
            DetainedLicense = detainedLicense;
            _SetItems(detainedLicense);
        }
    }
}
