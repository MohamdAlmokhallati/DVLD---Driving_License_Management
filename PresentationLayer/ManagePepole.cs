using BusinessLayer;
using PresentationLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ManagePepole : Form
    {
        public ManagePepole()
        {
            InitializeComponent();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            AddNewPerson addNewPerson = new AddNewPerson();
            addNewPerson.Show();
        }

        private void _setdgvPepoleTable(string query)
        {
            DataView dv = new DataView(clsPerson.GetAllPepole());
            if (!String.IsNullOrEmpty(query))
            {
                dgvPepoleTable.DataSource = dv.RowFilter = query;
            }

            dgvPepoleTable.DataSource = dv;
        }

        private void ManagePepole_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
            _setdgvPepoleTable("");
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex != 0)
            {
                tbFileterInput.Visible = true;
            }
            else
            {
                tbFileterInput.Visible = false;
            }
        }




        private void tbFileterInput_TextChanged(object sender, EventArgs e)
        {
            string query = "";

            //MessageBox.Show(cbFilter.SelectedItem.ToString());
            switch (cbFilter.SelectedItem.ToString())
            {
                case "Person ID":
                    query = clsPerson.WriteDataViewFilterQuery(clsPerson.enFilterby.PersonID, tbFileterInput.Text);
                    break;
                case "National No.":
                    query = clsPerson.WriteDataViewFilterQuery(clsPerson.enFilterby.NationalNo, tbFileterInput.Text);
                    break;
                case "First Name":
                    query = clsPerson.WriteDataViewFilterQuery(clsPerson.enFilterby.FirstName, tbFileterInput.Text);
                    break;
                case "Second Name":
                    query = clsPerson.WriteDataViewFilterQuery(clsPerson.enFilterby.SecondName, tbFileterInput.Text);
                    break;
                case "Third Name":
                    query = clsPerson.WriteDataViewFilterQuery(clsPerson.enFilterby.ThirdName, tbFileterInput.Text);
                    break;
                case "Nationality":
                    query = clsPerson.WriteDataViewFilterQuery(clsPerson.enFilterby.Nationality, tbFileterInput.Text);
                    break;
                case "Gender":
                    query = clsPerson.WriteDataViewFilterQuery(clsPerson.enFilterby.Gender, tbFileterInput.Text);
                    break;
                case "Phone":
                    query = clsPerson.WriteDataViewFilterQuery(clsPerson.enFilterby.Phone, tbFileterInput.Text);
                    break;
                case "Email":
                    query = clsPerson.WriteDataViewFilterQuery(clsPerson.enFilterby.Email, tbFileterInput.Text);
                    break;
                default:
                    query = "";
                    break;
            }

            _setdgvPepoleTable(query);
        }

        private void tbFileterInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<string> onlyNumbers = new List<string> { "Person ID", "Phone" };
            if (onlyNumbers.Contains(cbFilter.SelectedItem.ToString()))
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    // If the key is not a digit, consume the event (prevent the character from being entered)
                    e.Handled = true;
                }
            }
        }

        private void cmsAddPerson_Click(object sender, EventArgs e)
        {
            AddNewPerson addNewPerson = new AddNewPerson();
            addNewPerson.ShowDialog();
        }

        private void cmsSendEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will Work soon :)");
        }

        private void cmsPhoneCall_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will Work soon :)");
        }

        private void cmsShowDetails_Click(object sender, EventArgs e)
        {
            int selecedPersonID = Convert.ToInt32(dgvPepoleTable.Rows[dgvPepoleTable.CurrentRow.Index].Cells[0].Value);
            PersonDetails personDetails = new PersonDetails(selecedPersonID);
            personDetails.ShowDialog();
        }

        private void cmsEdit_Click(object sender, EventArgs e)
        {
            int selecedPersonID = Convert.ToInt32(dgvPepoleTable.Rows[dgvPepoleTable.CurrentRow.Index].Cells[0].Value);
            AddNewPerson addNewPerson = new AddNewPerson(clsPerson.GetPerson(selecedPersonID));
            addNewPerson.Show();

        }

        private void cmsDelete_Click(object sender, EventArgs e)
        {
            int selecedPersonID = Convert.ToInt32(dgvPepoleTable.Rows[dgvPepoleTable.CurrentRow.Index].Cells[0].Value);
            DialogResult res = MessageBox.Show($"Are you sure you want to Delete Person with ID {selecedPersonID}", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                if (clsPerson.Delete(selecedPersonID))
                    MessageBox.Show("Person Deleted Successfully");
                _setdgvPepoleTable("");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
