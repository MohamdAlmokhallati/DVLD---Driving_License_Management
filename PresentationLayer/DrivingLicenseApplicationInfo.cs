using BusinessLayer;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class DrivingLicenseApplicationInfo : UserControl
    {
        public DrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }


        public void _PutDLDItems(clsLocalDrivingLicenseApplication ldla)
        {
            lbDLAppID.Text = ldla.LDLid.ToString();
            lbPassedTests.Text = $"{ldla.PassedTets}/3";
            lbApplicedForLicense.Text = ldla.LicenseClass.Name;

        }




    }
}
