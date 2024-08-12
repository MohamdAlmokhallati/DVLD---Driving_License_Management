using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class DetainLicense : Form
    {
        public DetainLicense()
        {
            InitializeComponent();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {

            if(String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("You cant Detain License With 0 Fine Fees!");
                return;
            }



            DialogResult dialogResult = MessageBox.Show($"Are You Sure you want to detain License with ID {ctrlLicensesFinder1.license.LicenseId} ?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                clsDetainedLicense detainedLicense = new clsDetainedLicense(DateTime.Now,
                    decimal.Parse(textBox1.Text), CurrentLogedinUser.currentUser, false,
                    default(DateTime), null, null, ctrlLicensesFinder1.license);


                if(detainedLicense.SaveDetainedLicense())
                {
                    MessageBox.Show($"License has been detained with ID {detainedLicense.DetainedLicenseID}");
                    return;
                }

                MessageBox.Show("Somthing went Wrong!");

            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ctrlLicensesFinder1_OnDrivingLicenseSelected_1(BusinessLayer.clsLicense obj)
        {
            if (clsDetainedLicense.IsDetained(obj.LicenseId))
            {
                MessageBox.Show("This License is orady Detained!");
                btnDetain.Enabled = false;
            }
            else
            {
                btnDetain.Enabled = true;
            }
        }
    }
}
