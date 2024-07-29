using BusinessLayer;
using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class TakeVisionTest : Form
    {
        clsTestAppointment testAppointment { get; set; }
        public TakeVisionTest(clsTestAppointment testAppointment)
        {
            InitializeComponent();
            this.testAppointment = testAppointment;
            ctrlTestAppointmentInfos1.PutItems(testAppointment);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            clsTestType testType = clsTestType.GetTestType(1);


            clsTest test = new clsTest(testAppointment, rbPass.Checked, tbNotes.Text, CurrentLogedinUser.currentUser,
                testType);

            if (test.Save())
            {

                MessageBox.Show("The Test has been Updated successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Somthing went wrong,please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

            }

        }
    }
}
