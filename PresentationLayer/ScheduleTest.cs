using BusinessLayer;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ScheduleTest : Form
    {
        enum enMode { AddNew, Edit, ReTest };

        enMode mode = enMode.AddNew;


        public clsTestType.TestType testType { get; set; }



        clsLocalDrivingLicenseApplication ldla = null;
        clsTestAppointment TestAppointment = null;
        private ScheduleTest(clsTestType.TestType testType, clsLocalDrivingLicenseApplication ldla, clsTestAppointment testAppointment)
        {
            InitializeComponent();
            this.ldla = ldla;
            this.TestAppointment = testAppointment;
            _PutItems();

            ctrlTestInfos1.gpTestInfos.ForeColor = Color.White;

            this.testType = testType;

        }

        public ScheduleTest(clsTestType.TestType testType, clsLocalDrivingLicenseApplication ldla, bool isReTest)
            : this(testType, ldla, null)
        {
            if (isReTest)
            {
                mode = enMode.ReTest;
                _PutItmesInRetakeMode();

            }
            else
            {
                mode = enMode.AddNew;
                lbTitle.Text = "Add New Appointment";
                ctrlTestInfos1.Visible = false;

            }


        }
        public ScheduleTest(clsTestType.TestType testType, clsTestAppointment testAppointment)
            : this(testType, null, testAppointment)
        {
            mode = enMode.Edit;
            lbTitle.Text = "Edit Appointment";
            ctrlTestInfos1.Visible = false;

        }


        private void _PutItmesInRetakeMode()
        {
            clsApplicationType applicationType = clsApplicationType.GetApplicationType(2);

            lbTitle.Text = $"{applicationType.ApplicationTypTitle}\nRetake Test Appointment";
            ctrlTestInfos1.lbFees.Text = applicationType.ApplicationTypFees.ToString("0.##€");
            ctrlTestInfos1.lbTotalFees.Text = (applicationType.ApplicationTypFees + ldla.PaidFees).ToString("0.##€");
            ctrlTestInfos1.lbTetsID.Text = "N/M";

        }

        private void _PutItems()
        {
            if (ldla != null)
            {
                lbDLAppID.Text = ldla.ApplicationID.ToString();
                lbClass.Text = ldla.LicenseClass.Name;
                lbName.Text = ldla.Person.FullName();
                lbTrial.Text = "0";
                lbFees.Text = ldla.PaidFees.ToString("0.##€");
                return;
            }

            if (TestAppointment != null)
            {
                lbDLAppID.Text = TestAppointment.LocalDrivingLicenseApplication.ApplicationID.ToString();
                lbClass.Text = TestAppointment.LocalDrivingLicenseApplication.LicenseClass.Name;
                lbName.Text = TestAppointment.LocalDrivingLicenseApplication.Person.FullName();
                lbTrial.Text = "0";
                lbFees.Text = TestAppointment.LocalDrivingLicenseApplication.PaidFees.ToString("0.##€");
                return;
            }

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (mode == enMode.Edit)
            {
                TestAppointment.AppointmentDate = dtpAppointmentDate.Value;
                if (TestAppointment.Save())
                {
                    MessageBox.Show("The appointment has been Updated successfully!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Somthing went wrong,please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();

                }
                return;
            }

            if (mode == enMode.ReTest)
            {
                ldla.ApplicationType = clsApplicationType.GetApplicationType(2);

                if (!ldla.SaveApp())
                {
                    MessageBox.Show("Somthing went wrong,please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }

            }



            clsTestType visionTest = clsTestType.GetTestType((int)testType);

            clsTestAppointment testAppointment = new clsTestAppointment(visionTest, ldla,
                dtpAppointmentDate.Value, visionTest.Fees, CurrentLogedinUser.currentUser, false);


            if (testAppointment.Save())
            {
                MessageBox.Show("The appointment has been booked successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Somthing went wrong,please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

            }
        }

        private void ScheduleTest_Load(object sender, EventArgs e)
        {

        }
    }
}
