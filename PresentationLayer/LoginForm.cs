using BusinessLayer;
using System;
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
            if (clsUser.IsExist(tbUsername.Text, tbPassword.Text))
            {
                CurrentLogedinUser.currentUser = clsUser.getUser(tbUsername.Text, tbPassword.Text);

                if (!CurrentLogedinUser.currentUser.IsActive)
                {
                    MessageBox.Show("You are not Active,Please Contact your Admin!");
                    return;
                }

                MainClient mainClient = new MainClient();
                mainClient.FormClosed += (s, args) => this.Close();
                mainClient.Show();
                this.Hide();

            }
            else
            {
                lbWrungInputs.Visible = true;
            }
            if (cbIsRememberMe.Checked)
            {
                _RememberMe();
            }
            else
            {
                CurrentLogedinUser.ClearFile();
            }
        }

        private void _RememberMe()
        {
            CurrentLogedinUser.SaveCurrentUserDataToFile();
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
