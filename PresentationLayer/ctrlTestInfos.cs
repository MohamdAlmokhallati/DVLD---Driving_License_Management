using BusinessLayer;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ctrlTestInfos : UserControl
    {


        public ctrlTestInfos()
        {
            InitializeComponent();

        }




        public void PutItmes(clsTestAppointment testAppointment)
        {

            lbTetsID.Text = testAppointment.TestAppointmentID.ToString();
            lbFees.Text = testAppointment.PaidFees.ToString("0.##€");
            lbTotalFees.Text = "idk what this is";
        }


    }
}
