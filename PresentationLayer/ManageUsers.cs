using BusinessLayer;
using PresentationLayer.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }
        private void _setdgvUsersTable(string query)
        {
            DataView dv = new DataView(clsUser.GetAllUsers());
            if (!String.IsNullOrEmpty(query))
            {
                dgvUsersTable.DataSource = dv.RowFilter = query;
            }

            dgvUsersTable.DataSource = dv;
        }





        private void ManageUsers_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            _setdgvUsersTable("");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbFilterBy.SelectedIndex == 0)
            {
                cbFilterByIsActive.Visible = false;
                tbFilter.Visible = false;
                return;
            }

            if (cbFilterBy.SelectedIndex == cbFilterBy.FindString("Is Active"))
            {
                tbFilter.Visible = false;
                cbFilterByIsActive.SelectedIndex = 0;
                cbFilterByIsActive.Visible = true;
                return;
            }


            cbFilterByIsActive.Visible = false;
            tbFilter.Visible = true;

        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string query = "";

            switch (cbFilterBy.SelectedItem.ToString())
            {
                case "User ID":
                    query = clsUser.WriteDataViewFilterQuery(clsUser.enFilterby.UserID, tbFilter.Text);
                    break;
                case "Username":
                    query = clsUser.WriteDataViewFilterQuery(clsUser.enFilterby.Username, tbFilter.Text);
                    break;
                case "Full Name":
                    query = clsUser.WriteDataViewFilterQuery(clsUser.enFilterby.FullName, tbFilter.Text);
                    break;
                case "Is Active":
                    string IsActive = cbFilterByIsActive.Text == "Active" ? "1" : "0";
                    query = clsUser.WriteDataViewFilterQuery(clsUser.enFilterby.IsActive, IsActive);
                    break;
                default:
                    query = "";
                    break;
            }
            _setdgvUsersTable(query);
        }

        private void cbFilterByIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilter_TextChanged(null, null);
        }

        private void cmsShowDetails_Click(object sender, EventArgs e)
        {
            int selecedUserID = Convert.ToInt32(dgvUsersTable.Rows[dgvUsersTable.CurrentRow.Index].Cells[0].Value);
            UserDetails userDetails = new UserDetails(selecedUserID);
            userDetails.ShowDialog();
        }

        private void cmsDelete_Click(object sender, EventArgs e)
        {
            int selecedUserID = Convert.ToInt32(dgvUsersTable.Rows[dgvUsersTable.CurrentRow.Index].Cells[0].Value);
            DialogResult res = MessageBox.Show($"Are you sure you want to {cmsActive.Text} User with ID {selecedUserID}", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                if (clsUser.ChangeActive(selecedUserID, cmsActive.Text == "Activate"))
                    MessageBox.Show($"User {cmsActive.Text}d Successfully");
                _setdgvUsersTable("");
            }
        }

        private void cmsEditUsers_Opening(object sender, CancelEventArgs e)
        {
            int lastIndex = dgvUsersTable.Rows[dgvUsersTable.CurrentRow.Index].Cells.Count - 1;
            bool IsActive = Convert.ToInt32(dgvUsersTable.Rows[dgvUsersTable.CurrentRow.Index].Cells[lastIndex].Value) != 0;

            if (IsActive)
            {
                cmsActive.Text = "Deactivate";
                cmsActive.Image = Resources.switch_off;
            }
            else
            {
                cmsActive.Text = "Activate";
                cmsActive.Image = Resources.switch_on;

            }

        }

        private void cmsSendEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will Work soon :)");
        }

        private void cmsPhoneCall_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will Work soon :)");
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            AddNewUser addNewUser = new AddNewUser();
            addNewUser.ShowDialog();
        }
    }
}
