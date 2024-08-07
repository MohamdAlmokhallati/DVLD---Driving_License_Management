using BusinessLayer;
using System;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool isUserNotActive = false;

            if (clsUser.IsExist(tbUsername.Text.Trim(), tbPassword.Text.Trim()))
            {
                CurrentLogedinUser.currentUser = clsUser.getUser(tbUsername.Text, tbPassword.Text);

                if (!CurrentLogedinUser.currentUser.IsActive)
                {
                    MessageBox.Show("This User is not Active,Please Contact your Admin!","Error",
                        MessageBoxButtons.OK,MessageBoxIcon.Error);
                    isUserNotActive = true;
                }

                if(!isUserNotActive)
                {
                    MainClient mainClient = new MainClient();
                    mainClient.FormClosed += (s, args) => this.Close();
                    mainClient.Show();
                    this.Hide();
                }


            }
            else
            {
                lbWrungInputs.Visible = true;
            }


            if (cbIsRememberMe.Checked)
            {
                _RememberMe(tbPassword.Text);
            }
            else
            {
                CurrentLogedinUser.ClearFile();
            }
        }

        private void _RememberMe(string password)
        {
            CurrentLogedinUser.SaveCurrentUserDataToFile(password);
        }



        private void btnLogin_MouseUp(object sender, MouseEventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(200, 65, 134);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            string[] userData = CurrentLogedinUser.ReadRememberMeUserData();
            tbUsername.Text = userData[0];
            tbPassword.Text = userData[1];

        }
    }
}
