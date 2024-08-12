using BusinessLayer;
using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class EditTestType : Form
    {
        clsTestType testType;
        public EditTestType(int testTypeID)
        {
            InitializeComponent();
            testType = clsTestType.GetTestType(testTypeID);
            _SetAllFields();
        }

        private void _SetAllFields()
        {
            lbID.Text = testType.TestTypeID.ToString();
            tbTitle.Text = testType.Title;
            tbDescription.Text = testType.Description;
            tbFees.Text = testType.Fees.ToString();
        }
        private void _MakeTestType()
        {
            testType.Title = tbTitle.Text;
            testType.Description = tbDescription.Text;
            testType.Fees = decimal.Parse(tbFees.Text.ToString());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _MakeTestType();

            if (testType.Save())
            {
                MessageBox.Show("Test Saved Successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error Please Try Again later!");
            }
        }
    }
}
