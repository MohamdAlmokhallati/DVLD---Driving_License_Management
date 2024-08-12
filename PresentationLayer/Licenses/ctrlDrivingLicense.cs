using BusinessLayer;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ctrlDrivingLicense : UserControl
    {
        public ctrlDrivingLicense()
        {
            InitializeComponent();
        }

        public void PutItems(clsLicense lisLicense)
        {
            lbClass.Text = lisLicense.LicenseClass.Name;
            lbName.Text = lisLicense.Driver.FullName();
            lbLicenseID.Text = lisLicense.LicenseId.ToString();
            lbNationalNo.Text = lisLicense.Driver.NationalNo;
            lbGender.Text = lisLicense.Driver.Gender ? "Female" : "Male";
            lbIssueDate.Text = lisLicense.IssueDate.ToString("dd.MM.yyyy");
            lbExpirationDate.Text = lisLicense.ExpirationDate.ToString("dd.MM.yyyy");
            lbDriverID.Text = lisLicense.Driver.DriverID.ToString();
            pictureBox1.ImageLocation = lisLicense.Driver.ImagePath;
            lbStatus.Text = lisLicense.IsActive ? "Active" : "Not Active";


            lbIssueReson.Text = lisLicense.IssueReason.ToString();


        }



    }
}
