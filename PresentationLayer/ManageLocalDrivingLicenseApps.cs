using BusinessLayer;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ManageLocalDrivingLicenseApps : Form
    {
        public ManageLocalDrivingLicenseApps()
        {
            InitializeComponent();
        }

        private void _setdgvLicenseTable(string query)
        {
            DataView dv = new DataView(clsLocalDrivingLicenseApplication.GetAllLocalApps());
            if (!String.IsNullOrEmpty(query))
            {
                dgvLicense.DataSource = dv.RowFilter = query;
            }

            dgvLicense.DataSource = dv;
        }


        private void ManageLocalDrivingLicenseApps_Load(object sender, EventArgs e)
        {
            _setdgvLicenseTable("");
            cbFilters.SelectedIndex = 0;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddLocalDrivingLicenseApplication form = new AddLocalDrivingLicenseApplication();
            form.ShowDialog();
            _setdgvLicenseTable("");
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilters.SelectedIndex == 0)
            {
                tbFilter.Visible = false;
                return;
            }
            if (cbFilters.SelectedIndex == cbFilters.FindString("Status"))
            {
                tbFilter.Visible = false;
                cbStatusFiltes.SelectedIndex = 0;
                cbStatusFiltes.Visible = true;
                return;
            }
            cbStatusFiltes.Visible = false;
            tbFilter.Visible = true;

        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string query = "";




            //MessageBox.Show(cbFilter.SelectedItem.ToString());
            switch (cbFilters.SelectedItem.ToString())
            {
                case "LDL AppID":
                    query = clsLocalDrivingLicenseApplication.WriteDataViewFilterQuery(clsLocalDrivingLicenseApplication.enFilterby.LDLAppID, tbFilter.Text);
                    break;
                case "National No":
                    query = clsLocalDrivingLicenseApplication.WriteDataViewFilterQuery(clsLocalDrivingLicenseApplication.enFilterby.NationalNo, tbFilter.Text);
                    break;
                case "Full Name":
                    query = clsLocalDrivingLicenseApplication.WriteDataViewFilterQuery(clsLocalDrivingLicenseApplication.enFilterby.FullName, tbFilter.Text);
                    break;
                case "Status":
                    query = clsLocalDrivingLicenseApplication.WriteDataViewFilterQuery(clsLocalDrivingLicenseApplication.enFilterby.Status, cbStatusFiltes.SelectedItem.ToString());
                    break;
                default:
                    query = "";
                    break;
            }

            _setdgvLicenseTable(query);
        }

        private void cbStatusFiltes_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilter_TextChanged(null, null);
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilters.SelectedIndex != 1)
            {
                return;
            }


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

        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selecedLocalAppID = Convert.ToInt32(dgvLicense.Rows[dgvLicense.CurrentRow.Index].Cells[0].Value);

            TestAppointments visionTestAppointments = new TestAppointments(selecedLocalAppID, clsTestType.TestType.Vision);
            visionTestAppointments.ShowDialog();
            _setdgvLicenseTable("");
        }


        private void SetAllTests(int passedTetsNumber)
        {

            switch (passedTetsNumber)
            {
                case 0:
                    scheduleVisionTestToolStripMenuItem.Enabled = true;
                    scheduleWrittenTestToolStripMenuItem.Enabled = false;
                    scheduleStreetTestToolStripMenuItem.Enabled = false;
                    break;
                case 1:
                    scheduleVisionTestToolStripMenuItem.Enabled = false;
                    scheduleWrittenTestToolStripMenuItem.Enabled = true;
                    scheduleStreetTestToolStripMenuItem.Enabled = false;
                    break;
                case 2:
                    scheduleVisionTestToolStripMenuItem.Enabled = false;
                    scheduleWrittenTestToolStripMenuItem.Enabled = false;
                    scheduleStreetTestToolStripMenuItem.Enabled = true;
                    break;
                case 3:
                    tsmiShowLicense.Enabled = true;
                    break;
                default:
                    break;
            }
        }



        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            bool IsNewAppStatus = "New" == dgvLicense.Rows[dgvLicense.CurrentRow.Index].Cells["Status"].Value.ToString();

            tsmiEditApplication.Enabled = IsNewAppStatus;
            tsmiCancelApplication.Enabled = IsNewAppStatus;
            tsmiSechduleTests.Enabled = IsNewAppStatus;



            int passedTests = Convert.ToInt32(dgvLicense.Rows[dgvLicense.CurrentRow.Index].Cells["PassedTests"].Value);
            SetAllTests(passedTests);
            clsLocalDrivingLicenseApplication ldla = clsLocalDrivingLicenseApplication.GetLocalDrivingApp(Convert.ToInt32(dgvLicense.Rows[dgvLicense.CurrentRow.Index].Cells[0].Value));

            bool hasLicense = ldla.Person.HasLicense(ldla.LicenseClass.LicenseClassID);
            tsmiIssueDrivingLicense.Enabled = (!hasLicense) && passedTests == 3;
            
            tsmiShowLicense.Enabled = hasLicense;

        }

        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selecedLocalAppID = Convert.ToInt32(dgvLicense.Rows[dgvLicense.CurrentRow.Index].Cells[0].Value);

            TestAppointments visionTestAppointments = new TestAppointments(selecedLocalAppID, clsTestType.TestType.Written);
            visionTestAppointments.ShowDialog();
            _setdgvLicenseTable("");

        }

        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selecedLocalAppID = Convert.ToInt32(dgvLicense.Rows[dgvLicense.CurrentRow.Index].Cells[0].Value);

            TestAppointments visionTestAppointments = new TestAppointments(selecedLocalAppID, clsTestType.TestType.Driving);
            visionTestAppointments.ShowDialog();
            _setdgvLicenseTable("");
        }



        private void tsmiCancelApplication_Click(object sender, EventArgs e)
        {

            int selecedID = Convert.ToInt32(dgvLicense.Rows[dgvLicense.CurrentRow.Index].Cells[0].Value);
            DialogResult res = MessageBox.Show($"Are you sure you want to Cancle Application with ID {selecedID}", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                clsLocalDrivingLicenseApplication ldla = clsLocalDrivingLicenseApplication.GetLocalDrivingApp(selecedID);


                if (clsApplication.CancleApplication(ldla.ApplicationID))
                    MessageBox.Show("Application Cancled Successfully");
                _setdgvLicenseTable("");
            }
        }

        private void tsmiIssueDrivingLicense_Click(object sender, EventArgs e)
        {
            clsLocalDrivingLicenseApplication ldla = clsLocalDrivingLicenseApplication.GetLocalDrivingApp(Convert.ToInt32(dgvLicense.Rows[dgvLicense.CurrentRow.Index].Cells[0].Value));

            IssueDrivingLicenseFirstTime idlft = new IssueDrivingLicenseFirstTime(ldla);
            idlft.ShowDialog();

        }

        private void tsmiShowLicense_Click(object sender, EventArgs e)
        {
            clsLicense license = clsLicense.GetLicenseByLocalApplicationID(Convert.ToInt32(dgvLicense.Rows[dgvLicense.CurrentRow.Index].Cells[0].Value));
            DrivingLicense drivingLicense = new DrivingLicense(license);
            drivingLicense.ShowDialog();
        }

        private void tsmiShowPersonLicenseHistiory_Click(object sender, EventArgs e)
        {
            string selecedID = (dgvLicense.Rows[dgvLicense.CurrentRow.Index].Cells["NationalNo"].Value).ToString();

            clsPerson person = clsPerson.GetPerson(selecedID);
            LicenseHistory licenseHistory = new LicenseHistory(person);
            licenseHistory.ShowDialog();
        }
    }
}
