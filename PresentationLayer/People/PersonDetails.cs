using BusinessLayer;
using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class PersonDetails : Form
    {
        public PersonDetails(int PersonID)
        {
            InitializeComponent();
            this.ctrlPersonDetails1.SetPersonData(PersonID);
        }
        public PersonDetails(clsPerson Person)
        {
            InitializeComponent();
            this.ctrlPersonDetails1.SetPersonData(Person);
        }
        private void PersonDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
