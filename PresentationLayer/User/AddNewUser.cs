using BusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class AddNewUser : Form
    {
        public AddNewUser()
        {
            InitializeComponent();

        }

        private void AddNewUser_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.ctrlPersonFinder1.btnFind;
        }






        private string _ErrorMessage()
        {
            if (this.ctrlPersonFinder1.ctrlPersonDetails1.person == null)
            {

                return "You must pick a Person!";
            }

            if (this.ctrlPersonFinder1.ctrlPersonDetails1.person.IsUser())
            {
                return "This Person Is Orady an User";
            }
            return string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ErrorMessage = _ErrorMessage();
            if (!String.IsNullOrEmpty(ErrorMessage))
            {
                MessageBox.Show(ErrorMessage, "",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                tcPersonInfos.SelectedIndex = tcPersonInfos.SelectedIndex + 1;

            }
        }

        private void tcPersonInfos_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (String.IsNullOrEmpty(_ErrorMessage()))
            {
                button1_Click(null, null);
                return;
            }
            e.Cancel = true;
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbUserName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbUserName, "User Name cant be empty!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbUserName, "");
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (tbConfirmPassword.Text != tbPassword.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbConfirmPassword, "Passwords are not match!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbConfirmPassword, "");
            }
        }
        private bool IsAllInputValed()
        {
            return true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsAllInputValed())
            {
                clsUser user = new clsUser(tbUserName.Text, tbPassword.Text, true, this.ctrlPersonFinder1.ctrlPersonDetails1.person);
                user.Save();
                lbUserID.Text = user.UserID.ToString();
            }
        }
    }
}
