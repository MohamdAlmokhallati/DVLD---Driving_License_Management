using BusinessLayer;
using PresentationLayer;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class MainClient : Form
    {
        public MainClient()
        {
            InitializeComponent();
        }

        private void managePeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagePepole managePepole = new ManagePepole();
            managePepole.Show();
        }

        private void myInfosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserDetails userDetails = new UserDetails(CurrentLogedinUser.currentUser.UserID);
            userDetails.Show();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentLogedinUser.currentUser = null;
            this.Close();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageUsers manageUsers = new ManageUsers();
            manageUsers.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.ShowDialog();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageApplicationTypes manageApplicationTypes = new ManageApplicationTypes();
            manageApplicationTypes.Show();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageTestTypes manageTestTypes = new ManageTestTypes();
            manageTestTypes.Show();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLocalDrivingLicenseApplication form = new AddLocalDrivingLicenseApplication();
            form.ShowDialog();
        }


        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageLocalDrivingLicenseApps manageLocalDrivingLicenseApps = new ManageLocalDrivingLicenseApps();
            manageLocalDrivingLicenseApps.Show();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageDrivers manageDrivers = new ManageDrivers();
            manageDrivers.Show();
        }

        private void internationalLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerInternationalLicenses managerInternationalLicenses = new ManagerInternationalLicenses();
            managerInternationalLicenses.Show();
        }

        private void replacementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReplacementForDamgaedLicense replacementForDamgaedLicense = new ReplacementForDamgaedLicense();
            replacementForDamgaedLicense.Show();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenewLicense renewLicense = new RenewLicense();
            renewLicense.Show();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetainLicense detainLicense = new DetainLicense();
            detainLicense.Show();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicense releaseDetainedLicense = new ReleaseDetainedLicense();
            releaseDetainedLicense.Show();
        }

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageDetainedLicenses manageDetainedLicenses = new ManageDetainedLicenses();
            manageDetainedLicenses.Show();
        }
    }
}
