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
            if (tbOldPassword.Text != CurrentLogedinUser.currentUser.Password)
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
            if (tbNewPassword.Text != tbConfirmNewPassword.Text)
            {
                lbWrungInputs.Visible = true;
            }
            else
            {
                CurrentLogedinUser.currentUser.Password = tbNewPassword.Text;
                if (CurrentLogedinUser.currentUser.Save())
                {
                    MessageBox.Show("Password Changed Successfully");
                    this.Close();
                }
            }
        }
    }
}
