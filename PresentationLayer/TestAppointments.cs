using BusinessLayer;
using PresentationLayer.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class TestAppointments : Form
    {

        public enum enTestType { Vision = 1, Written = 2, Driving = 3 };

        enTestType testType = enTestType.Vision;

        public clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication { get; set; }
        public TestAppointments(int LocalAppId, enTestType testType)
        {
            InitializeComponent();
            LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.GetLocalDrivingApp(LocalAppId);
            this.drivingLicenseApplicationInfo1._PutDLDItems(LocalDrivingLicenseApplication);
            this.testType = testType;
            _putTitle();
        }

        private void _putTitle()
        {
            switch (testType)
            {
                case enTestType.Vision:
                    lbTitle.Text = "Vision Test Appointments";
                    pictureBox1.Image = Resources.eye_test;
                    break;
                case enTestType.Written:
                    lbTitle.Text = "Written Test Appointments";
                    pictureBox1.Image = Resources.content_writing;
                    break;
                case enTestType.Driving:
                    lbTitle.Text = "Driving Test Appointments";
                    pictureBox1.Image = Resources.driving_test;

                    break;
                default:
                    break;
            }
        }



        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            if (LocalDrivingLicenseApplication.Person.HasOpenedAppointment(LocalDrivingLicenseApplication.ApplicationID, (int)testType))
            {
                MessageBox.Show("This Person Already has an Opened Appointment!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isReTest = LocalDrivingLicenseApplication.HasFaledTest((int)testType);


            ScheduleTest schedule = new ScheduleTest((ScheduleTest.enTestType)(int)testType, LocalDrivingLicenseApplication, isReTest);


            schedule.ShowDialog();
            _setdgvAppointmentsTable("");
        }
        private void _setdgvAppointmentsTable(string query)
        {
            DataView dv = new DataView(clsTestAppointment.GetAllPersonAppointment(LocalDrivingLicenseApplication.Person.getPersonID(), (int)testType));
            if (!String.IsNullOrEmpty(query))
            {
                dgvAppointments.DataSource = dv.RowFilter = query;
            }

            dgvAppointments.DataSource = dv;
        }

        private void VisionTestAppointments_Load(object sender, EventArgs e)
        {
            _setdgvAppointmentsTable("");
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selecedID = Convert.ToInt32(dgvAppointments.Rows[dgvAppointments.CurrentRow.Index].Cells[0].Value);

            clsTestAppointment testAppointment = clsTestAppointment.getTestAppointment(selecedID);
            ScheduleTest schedule = new ScheduleTest((ScheduleTest.enTestType)(int)testType, testAppointment);
            schedule.ShowDialog();
            _setdgvAppointmentsTable("");
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            bool IsLocked = 0 == Convert.ToInt32(dgvAppointments.Rows[dgvAppointments.CurrentRow.Index].Cells["IsLocked"].Value);

            takeTestToolStripMenuItem.Enabled = IsLocked;
            editToolStripMenuItem.Enabled = IsLocked;
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selecedID = Convert.ToInt32(dgvAppointments.Rows[dgvAppointments.CurrentRow.Index].Cells[0].Value);

            clsTestAppointment testAppointment = clsTestAppointment.getTestAppointment(selecedID);
            TakeVisionTest takeVisionTest = new TakeVisionTest(testAppointment);
            takeVisionTest.ShowDialog();
            _setdgvAppointmentsTable("");
        }
    }
}
