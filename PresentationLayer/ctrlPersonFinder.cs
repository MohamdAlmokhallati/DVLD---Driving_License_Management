using BusinessLayer;
using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ctrlPersonFinder : UserControl
    {
        public ctrlPersonFinder()
        {
            InitializeComponent();
        }

        private void ctrlPersonFinder_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            clsPerson person = null;
            switch (cbFilterBy.Text)
            {
                case "National No":
                    person = clsPerson.GetPerson(tbFilter.Text);
                    break;
                case "Person ID":
                    person = clsPerson.GetPerson(Int32.Parse(tbFilter.Text));
                    break;

            }

            this.ctrlPersonDetails1.SetPersonData(person);

        }








    }
}
