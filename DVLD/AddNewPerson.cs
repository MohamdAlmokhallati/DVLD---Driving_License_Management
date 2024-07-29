using DVLD.Properties;
using System;
using System.Windows.Forms;
//using businessLayer;

namespace DVLD
{
    public partial class AddNewPerson : Form
    {
        public AddNewPerson()
        {
            InitializeComponent();
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            pbSelfPhoto.Image = Resources.Male ;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            pbSelfPhoto.Image = Resources.Female;

        }



        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

            

            // Split the string into individual items
           //string[] items = clsCountry.GetAllCountrys();

            //cbCountry.Items = ComboBox.ObjectCollection();
        }
    }
}
