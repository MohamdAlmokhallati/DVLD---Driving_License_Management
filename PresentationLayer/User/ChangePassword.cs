using BusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        

        private void tbOldPassword_Validating(object sender, CancelEventArgs e)
        {
            if (!CurrentLogedinUser.currentUser.IsPasswordCurrect(tbOldPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbOldPassword, "Wrong Password!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbOldPassword, "");
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if(tbNewPassword.Text != tbConfirmNewPassword.Text)
            {
                lbWrungInputs.Text = "Passwords don't match";
                lbWrungInputs.Visible = true;
            }


            string wrongMessage = "";
            if (!Utils.isValidPass(tbNewPassword.Text,ref wrongMessage))
            {
                lbWrungInputs.Text = wrongMessage;
                lbWrungInputs.Visible = true;
                return;
            }
                        
            CurrentLogedinUser.currentUser.Password = tbNewPassword.Text.Trim();
            if (CurrentLogedinUser.currentUser.Save())
            {
                MessageBox.Show("Password Changed Successfully");
                this.Close();
            }
            
        }
    }
}
