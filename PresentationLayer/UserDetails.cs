using BusinessLayer;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class UserDetails : Form
    {
        public UserDetails(int UserID)
        {
            InitializeComponent();
            setUserInfos(UserID);
        }

        private void setUserInfos(int UserID)
        {
            clsUser user = clsUser.getUser(UserID);
            if (user != null)
            {
                this.ctrlPersonDetails1.SetPersonData(user.getPersonID());
                lbUserID.Text = user.getUserID().ToString();
                lbIsActive.Text = user.IsActive ? "Yes" : "No";
                lbUsername.Text = user.UserName;


            }
        }

    }
}
