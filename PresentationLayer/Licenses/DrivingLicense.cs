using BusinessLayer;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class DrivingLicense : Form
    {
        public DrivingLicense(clsLicense license)
        {
            InitializeComponent();
            ctrlDrivierLicense1.PutItems(license);
        }
    }
}
