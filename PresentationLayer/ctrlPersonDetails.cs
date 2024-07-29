using BusinessLayer;
using DVLD;
using PresentationLayer.Properties;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ctrlPersonDetails : UserControl
    {
        public clsPerson person = null;


        public ctrlPersonDetails()
        {
            InitializeComponent();
            //this.Tag = PersonID;
        }




        private void _PutPersonDetails()
        {
            if (person.getPersonID() < 0)
            {
                return;
            }

            lbPersonID.Text = person.getPersonID().ToString();
            lbName.Text = person.FirstName;
            lbNationalNo.Text = person.NationalNo;


            if (person.Gender)
            {
                lbGender.Text = "Female";
            }
            else
            {
                lbGender.Text = "Male";
            }

            lbEmail.Text = person.Email;
            lbAddress.Text = person.Address;
            lbDateOfBirth.Text = person.DateOfBirth.ToString("yyyy-mm-dd");
            lbPhone.Text = person.Phone;
            lbCountry.Text = person.Country;

            if (!String.IsNullOrEmpty(person.ImagePath))
            {
                pbSelfPhoto.ImageLocation = person.ImagePath;
            }
            else
            {
                defultPhoto();
            }





        }
        public void SetPersonData(clsPerson personData)
        {
            person = personData;
            _PutPersonDetails();
        }
        public void SetPersonData(int personId)
        {
            person = clsPerson.GetPerson(personId);
            _PutPersonDetails();
        }

        private void defultPhoto()
        {
            if (person.Gender)
            {
                pbSelfPhoto.Image = Resources.Female;
            }
            else
            {
                pbSelfPhoto.Image = Resources.Male;
            }
        }


        private void pbSelfPhoto_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                defultPhoto();
            }
        }

        private void lkEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddNewPerson addNewPerson = new AddNewPerson(person);
            addNewPerson.Show();
        }
    }
}
