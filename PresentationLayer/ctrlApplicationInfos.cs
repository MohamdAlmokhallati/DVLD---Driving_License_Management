using BusinessLayer;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ctrlApplicationInfos : UserControl
    {
        public ctrlApplicationInfos()
        {
            InitializeComponent();
        }

        public void putItmes(clsLocalDrivingLicenseApplication ldla)
        {
            lbDLAppID.Text = ldla.ApplicationID.ToString();
            lbClass.Text = ldla.LicenseClass.Name;
            lbName.Text = ldla.Person.FullName();
            lbTrial.Text = "0";
            lbFees.Text = ldla.PaidFees.ToString("0.##€");
        }

    }
}
