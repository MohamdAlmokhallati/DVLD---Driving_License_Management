using BusinessLayer;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ctrlTestAppointmentInfos : UserControl
    {



        public ctrlTestAppointmentInfos()
        {
            InitializeComponent();
        }


        public void PutItems(clsTestAppointment testAppointment)
        {
            lbAppointmentID.Text = testAppointment.TestAppointmentID.ToString();
            lbClass.Text = testAppointment.LocalDrivingLicenseApplication.LicenseClass.Name;
            lbDate.Text = testAppointment.AppointmentDate.ToString("dd/MM/yyyy");
            lbFees.Text = testAppointment.PaidFees.ToString("0.##€");
            lbName.Text = testAppointment.LocalDrivingLicenseApplication.Person.FullName();
            lbTestID.Text = "Not Done Yet!";
        }


    }
}
