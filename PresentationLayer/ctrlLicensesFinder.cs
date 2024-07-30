using BusinessLayer;
using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ctrlLicensesFinder : UserControl
    {
        public event Action<int> OnDrivingLicenseSelected;

        protected virtual void DrivingLicenseSeleted(int licenseId)
        {
            Action<int> handler = OnDrivingLicenseSelected;
            if (handler != null)
            {
                handler(licenseId);

            }

        }














        public clsLicense license {  get; set; }
        public ctrlLicensesFinder()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            clsLicense license = clsLicense.GetLicense(Convert.ToInt32(tbID.Text));
            if (license.LicenseId > 0)
            {
                this.license = license;
                licens.PutItems(license);
            }
            else
            {
                MessageBox.Show($"There Is No License With ID {tbID.Text}");
                return;
            }
            if(OnDrivingLicenseSelected != null)
            {
                OnDrivingLicenseSelected(this.license.LicenseId);
            }


        }

        private void InitializeComponent()
        {
            this.gpFilter = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lbLicenseID = new System.Windows.Forms.Label();
            this.licens = new PresentationLayer.ctrlDrivingLicense();
            this.gpFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpFilter
            // 
            this.gpFilter.Controls.Add(this.btnFind);
            this.gpFilter.Controls.Add(this.tbID);
            this.gpFilter.Controls.Add(this.lbLicenseID);
            this.gpFilter.Location = new System.Drawing.Point(16, 3);
            this.gpFilter.Name = "gpFilter";
            this.gpFilter.Size = new System.Drawing.Size(569, 49);
            this.gpFilter.TabIndex = 1;
            this.gpFilter.TabStop = false;
            this.gpFilter.Text = "Filter";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(488, 16);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(74, 17);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(408, 20);
            this.tbID.TabIndex = 1;
            // 
            // lbLicenseID
            // 
            this.lbLicenseID.AutoSize = true;
            this.lbLicenseID.Location = new System.Drawing.Point(6, 21);
            this.lbLicenseID.Name = "lbLicenseID";
            this.lbLicenseID.Size = new System.Drawing.Size(60, 13);
            this.lbLicenseID.TabIndex = 0;
            this.lbLicenseID.Text = "License ID:";
            // 
            // licens
            // 
            this.licens.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.licens.Location = new System.Drawing.Point(0, 54);
            this.licens.Name = "licens";
            this.licens.Padding = new System.Windows.Forms.Padding(15);
            this.licens.Size = new System.Drawing.Size(598, 250);
            this.licens.TabIndex = 2;
            // 
            // ctrlLicensesFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.licens);
            this.Controls.Add(this.gpFilter);
            this.Name = "ctrlLicensesFinder";
            this.Size = new System.Drawing.Size(598, 304);
            this.gpFilter.ResumeLayout(false);
            this.gpFilter.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
