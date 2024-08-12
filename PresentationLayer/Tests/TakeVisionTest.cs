using BusinessLayer;
using PresentationLayer.Properties;
using System;
using System.Resources;
using System.Runtime.Versioning;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class TakeVisionTest : Form
    {

        clsTestAppointment testAppointment { get; set; }
        public TakeVisionTest(clsTestAppointment testAppointment, clsTestType.TestType testsTypes)
        {
            InitializeComponent();
            this.testAppointment = testAppointment;
            ctrlTestAppointmentInfos1.PutItems(testAppointment);
            _setTitleAndImage(testsTypes);
        }
        private void _setTitleAndImage(clsTestType.TestType testsTypes)
        {
            switch (testsTypes)
            {
                case clsTestType.TestType.Vision:
                    lbTitle.Text = "Take Vision Test";
                    pictureBox1.Image = Resources.eye_test;
                    break;
                case clsTestType.TestType.Written:
                    lbTitle.Text = "Take Written Test";
                    pictureBox1.Image = Resources.content_writing;
                    break;
                case clsTestType.TestType.Driving:
                    lbTitle.Text = "Take Driving Test";
                    pictureBox1.Image = Resources.driving_test;
                    break;
                default:
                    break;
            }
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
