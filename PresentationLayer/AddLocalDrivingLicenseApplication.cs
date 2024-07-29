using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class AddLocalDrivingLicenseApplication : Form
    {
        List<clsLicenseClass> licenseClasses = clsLicenseClass.getAllLicenseClasses();

        public AddLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }
        private void AddComboBoxItmes()
        {
            foreach (clsLicenseClass licenseClass in licenseClasses)
            {
                cbLicenseClass.Items.Add(licenseClass.Name);
            }
            cbLicenseClass.SelectedIndex = 0;
            decimal fees = clsApplicationType.GetFees("New Local Driving License Service");
            lbFees.Text = fees.ToString("0.##€");
            lbFees.Tag = fees;
        }


        private void NewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            AddComboBoxItmes();
            lbApplicationDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbCreatedBy.Text = CurrentLogedinUser.currentUser.UserName;
        }

        private string _ErrorMessage()
        {

            if (this.ctrlPersonFinder1.ctrlPersonDetails1.person == null)
            {
                return "You must pick a Person!";
            }



            return string.Empty;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string ErrorMessage = _ErrorMessage();
            if (!String.IsNullOrEmpty(ErrorMessage))
            {
                MessageBox.Show(ErrorMessage, "",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                tcApplicatinoInfo_Selecting(null, null);
            }



        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.ctrlPersonFinder1.ctrlPersonDetails1.person.HasActiveApp(licenseClasses[cbLicenseClass.SelectedIndex].LicenseClassID))
            {
                MessageBox.Show("This Person Has orady app!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            clsLocalDrivingLicenseApplication ldla = new clsLocalDrivingLicenseApplication
                (this.ctrlPersonFinder1.ctrlPersonDetails1.person,
                DateTime.Parse(lbApplicationDate.Text), clsApplicationType.GetApplicationType(1),
                DateTime.Now, "New", (decimal)lbFees.Tag, CurrentLogedinUser.currentUser,
                licenseClasses[cbLicenseClass.SelectedIndex]
                , 0);
            if (ldla.Save())
            {
                MessageBox.Show("Local Driving License Application has been issued!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Somthing went wrong, please try again");
            }
        }

        private void tcApplicatinoInfo_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (String.IsNullOrEmpty(_ErrorMessage()))
            {
                tcApplicatinoInfo.SelectedIndex = tcApplicatinoInfo.SelectedIndex + 1;
                return;
            }
            e.Cancel = true;
        }
    }
}
