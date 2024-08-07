using BusinessLayer;
using PresentationLayer.Properties;
using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;




namespace DVLD
{
    public partial class AddNewPerson : Form
    {

        public delegate void DataBackEventHandler(object sender, int PersonID);
        public event DataBackEventHandler DataBack;

        private void SendDataBack_Click(object sender, EventArgs e)
        {
            int PersonID = int.Parse(lbPersonID.Text);


            DataBack?.Invoke(this, PersonID);
        }




        enum Mode { enAddNew, enUpdate };
        Mode mode = Mode.enAddNew;

        clsPerson person = null;
        bool RemoverCurrentPhoto = false;
        public AddNewPerson(clsPerson person)
        {
            InitializeComponent();
            if (person != null)
            {
                this.person = person;
                mode = Mode.enUpdate;
                _FillFieldsWithValues();
            }
        }
        public AddNewPerson() : this(null)
        {

        }




        private void _FillFieldsWithValues()
        {
            lbTitle.Text = "Update Person's Data";
            lbPersonID.Text += person.PersonID;

            tbFirstName.Text = person.FirstName;
            tbSecondName.Text = person.SecondName;
            tbThirdName.Text = person.ThirdName;
            tbLastName.Text = person.LastName;
            tbEmail.Text = person.Email;
            tbPhone.Text = person.Phone;
            tbNationalNo.Text = person.NationalNo;
            _setDefualtImage();
            dtpDateOfBirth.Value = person.DateOfBirth;
            tbAddress.Text = person.Address;
            cbCountry.SelectedIndex = cbCountry.FindString(person.Country);

            if (person.Gender)
            {
                rbFemale.Checked = true;
            }
            else
            {
                rbMale.Checked = true;
            }


        }


        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if(rbMale.Checked)
                pbSelfPhoto.Image = Resources.Male;
            else
                pbSelfPhoto.Image = Resources.Female;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if(rbFemale.Checked)
                pbSelfPhoto.Image = Resources.Female;
            else
                pbSelfPhoto.Image = Resources.Male;
        }



        private void _setComboBoxCountryItems()
        {
            string[] items = clsCountry.GetAllCountrys();
            cbCountry.Items.AddRange(items);
            if (mode == Mode.enAddNew)
                cbCountry.SelectedIndex = cbCountry.FindString("Germany");
            else
                cbCountry.SelectedIndex = cbCountry.FindString(person.Country);
        }


        private void _setdtpDateOfBirth()
        {

            dtpDateOfBirth.MaxDate = DateTime.Today.AddYears(-18);

        }
        private void _setDefualtImage()
        {
            if (!File.Exists((PATHES.SELF_PHOTOS_FOLDER + person.ImagePath)))
            {                
                rbFemale_CheckedChanged(null, null);
                toolTip1.SetToolTip(pbSelfPhoto, "Photo Not Found!");
            }
            else
                pbSelfPhoto.ImageLocation = (PATHES.SELF_PHOTOS_FOLDER + person.ImagePath);
        }


        private void AddNewPerson_Load(object sender, EventArgs e)
        {
            _setdtpDateOfBirth();
            _setComboBoxCountryItems();
            _setDefualtImage();



            //TODO: Find Good Condtion for the visible of this
            lkRemovePhoto.Visible =!( pbSelfPhoto == null || pbSelfPhoto.Image == null) ;
        }

        private void lkSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            if (ofdSelfPhoto.ShowDialog() == DialogResult.OK)
            {
                string newImageLocation = null;
                if (mode == Mode.enAddNew)
                {
                    newImageLocation = clsImage.SaveImageToFile(ofdSelfPhoto.FileName);
                }
                else
                {
                    newImageLocation = clsImage.ChangeImage(ofdSelfPhoto.FileName, (PATHES.SELF_PHOTOS_FOLDER + person.ImagePath));
                }

                if (!String.IsNullOrEmpty(newImageLocation))
                {
                    pbSelfPhoto.ImageLocation = (PATHES.SELF_PHOTOS_FOLDER + person.ImagePath);

                }
                else
                {
                    MessageBox.Show("Iamge Error,please try again");
                }

            }
        }

        private void textBox7_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //if string is not empty then check if email is valid! 
            if ((!Utils.IsValidEmail(tbEmail.Text)) && !String.IsNullOrEmpty(tbEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbEmail, "Not valid Email!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbEmail, "");
            }
        }

        private void pbSelfPhoto_Click(object sender, EventArgs e)
        {

        }

        private void _FillPersonDataToUpdate()
        {
            string imageLocation = person.ImagePath;
            if (pbSelfPhoto.ImageLocation != null && !RemoverCurrentPhoto)
            {
                imageLocation = Path.GetFileName(pbSelfPhoto.ImageLocation);
            }

            person.FirstName = tbFirstName.Text.Trim();
            person.SecondName = tbSecondName.Text.Trim();
            person.ThirdName = tbThirdName.Text.Trim();
            person.LastName = tbLastName.Text.Trim();
            person.DateOfBirth = dtpDateOfBirth.Value;
            person.Gender = rbFemale.Checked;
            person.Address = tbAddress.Text.Trim();
            person.NationalNo = tbNationalNo.Text.Trim();
            person.Phone = tbPhone.Text.Trim();
            person.Email = tbEmail.Text.Trim();
            person.Country = cbCountry.SelectedItem.ToString();
            person.ImagePath = imageLocation;
        }
        private clsPerson _MakeObjectFromInputs()
        {
            string imageLocation = "";
            if (pbSelfPhoto.ImageLocation != null)
            {
                imageLocation = Path.GetFileName(pbSelfPhoto.ImageLocation);
            }

            return new clsPerson(tbFirstName.Text.Trim(), tbSecondName.Text.Trim(),
                tbThirdName.Text.Trim(), tbLastName.Text.Trim(), dtpDateOfBirth.Value,
                rbFemale.Checked, tbAddress.Text.Trim(), tbNationalNo.Text.Trim(),
                tbPhone.Text.Trim(), tbEmail.Text.Trim(),
                cbCountry.SelectedItem.ToString(), imageLocation);
        }

        private bool isAllInputsValid()
        {
            if (String.IsNullOrEmpty(tbFirstName.Text))
            {
                errorProviderEmpty(tbFirstName);
                return false;
            }

            if (String.IsNullOrEmpty(tbSecondName.Text))
            {
                errorProviderEmpty(tbSecondName);
                return false;
            }

            if (String.IsNullOrEmpty(tbThirdName.Text))
            {
                errorProviderEmpty(tbThirdName);
                return false;
            }

            if (String.IsNullOrEmpty(tbLastName.Text.Trim()))
            {
                errorProviderEmpty(tbLastName);
                return false;
            }

            if (String.IsNullOrEmpty(tbAddress.Text.Trim()))
            {
                errorProviderEmpty(tbAddress);
                return false;
            }

            if (String.IsNullOrEmpty(tbNationalNo.Text.Trim()))
            {
                errorProviderEmpty(tbNationalNo);
                return false;
            }


            if (String.IsNullOrEmpty(tbPhone.Text.Trim()))
            {
                errorProviderEmpty(tbPhone);
                return false;
            }


            if (String.IsNullOrEmpty(tbEmail.Text.Trim()))
            {
                errorProviderEmpty(tbEmail);
                return false;
            }




            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {



            if (isAllInputsValid())
            {
                if (mode == Mode.enAddNew)
                {
                    //Add New 
                    clsPerson person = _MakeObjectFromInputs();

                    person.Save();
                    lbTitle.Text = "ID = " + person.getPersonID();
                    lbPersonID.Text = person.getPersonID().ToString();

                }
                else
                {
                    //Update 
                    _FillPersonDataToUpdate();
                    if(RemoverCurrentPhoto)
                    {
                        if (clsImage.RemoveImage((PATHES.SELF_PHOTOS_FOLDER + person.ImagePath)))
                            person.ImagePath = "";

                    }
                    person.Save();
                    this.Close();

                }
            }



        }

        private void errorProviderEmpty(object sender)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;
            if (textBox != null)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    errorProvider1.SetError(textBox, "This can't be empty!");
                }
                else if (!clsPerson.IsNationalNoValid(textBox.Text.Trim()))
                {
                    errorProvider1.SetError(textBox, "Invalid national number!");
                }
                else
                {
                    errorProvider1.SetError(textBox, string.Empty); 
                }
            }
        }

        private void tbNationalNo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!clsPerson.IsNationalNoValid(tbNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbNationalNo, "This number is already used!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbNationalNo, "");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lkRemovePhoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbSelfPhoto.ImageLocation = null;
            //just calling the function so that some photo be puted there
            rbMale_CheckedChanged(null,null);
            RemoverCurrentPhoto = true;
        }
    }
}
