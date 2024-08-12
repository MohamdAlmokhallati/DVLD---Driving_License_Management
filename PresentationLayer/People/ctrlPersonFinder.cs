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
                    if (!Utils.IsNumber(tbFilter.Text))
                    {                        
                        MessageBox.Show("This is not Valid Input!","Error",
                            MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return;
                    }
                    person = clsPerson.GetPerson(Int32.Parse(tbFilter.Text));
                    break;

            }
            if(person !=null)
                this.ctrlPersonDetails1.SetPersonData(person);
            else
                MessageBox.Show($"No Person with {cbFilterBy.Text} {tbFilter.Text}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text != "Person ID")
                return;
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

        private void InitializeComponent()
        {
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.lbFindByTitle = new System.Windows.Forms.Label();
            this.ctrlPersonDetails1 = new PresentationLayer.ctrlPersonDetails();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.tbFilter);
            this.gbFilter.Controls.Add(this.btnFind);
            this.gbFilter.Controls.Add(this.btnAddPerson);
            this.gbFilter.Controls.Add(this.cbFilterBy);
            this.gbFilter.Controls.Add(this.lbFindByTitle);
            this.gbFilter.Location = new System.Drawing.Point(6, 3);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(704, 54);
            this.gbFilter.TabIndex = 1;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(232, 19);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(132, 20);
            this.tbFilter.TabIndex = 4;
            this.tbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilter_KeyPress);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(542, 18);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(623, 18);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(75, 23);
            this.btnAddPerson.TabIndex = 2;
            this.btnAddPerson.Text = "Add Person";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "National No",
            "Person ID"});
            this.cbFilterBy.Location = new System.Drawing.Point(95, 19);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(121, 21);
            this.cbFilterBy.TabIndex = 1;
            // 
            // lbFindByTitle
            // 
            this.lbFindByTitle.AutoSize = true;
            this.lbFindByTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFindByTitle.Location = new System.Drawing.Point(6, 20);
            this.lbFindByTitle.Name = "lbFindByTitle";
            this.lbFindByTitle.Size = new System.Drawing.Size(74, 19);
            this.lbFindByTitle.TabIndex = 0;
            this.lbFindByTitle.Text = "Find By:";
            // 
            // ctrlPersonDetails1
            // 
            this.ctrlPersonDetails1.Location = new System.Drawing.Point(2, 60);
            this.ctrlPersonDetails1.Name = "ctrlPersonDetails1";
            this.ctrlPersonDetails1.Size = new System.Drawing.Size(712, 274);
            this.ctrlPersonDetails1.TabIndex = 2;
            // 
            // ctrlPersonFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlPersonDetails1);
            this.Controls.Add(this.gbFilter);
            this.Name = "ctrlPersonFinder";
            this.Size = new System.Drawing.Size(717, 337);
            this.Load += new System.EventHandler(this.ctrlPersonFinder_Load);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
