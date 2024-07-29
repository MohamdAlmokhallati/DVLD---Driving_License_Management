using BusinessLayer;
using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class LicenseHistory : Form
    {
        clsPerson Person;
        public LicenseHistory(clsPerson person)
        {
            InitializeComponent();
            this.Person = person;
        }

        private void LicenseHistory_Load(object sender, EventArgs e)
        {
            ctrlPersonDetails1.SetPersonData(Person);
            ctrlLicenseHistory1.SetTables(Person.getPersonID());
        }
    }
}
