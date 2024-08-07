using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static BusinessLayer.clsLicense;

namespace PresentationLayer
{
    public partial class RenewLicense : Form
    {
        public RenewLicense()
        {
            InitializeComponent();
        }

        private void RenewLicense_Load(object sender, EventArgs e)
        {
            clsApplicationType applicationType = clsApplicationType.GetApplicationType(2);
            lbApplicationDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
            lbIssueDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
            lbApplicationFees.Text = applicationType.ApplicationTypFees.ToString("0.##€");
            lbApplicationFees.Tag = applicationType.ApplicationTypFees;

            lbCreatedBy.Text = CurrentLogedinUser.currentUser.UserName;

        }

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTotalFees = new System.Windows.Forms.Label();
            this.lbTotalFeesTitle = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.lbCreatedByTitle = new System.Windows.Forms.Label();
            this.lbExpirationDate = new System.Windows.Forms.Label();
            this.lbExpirationDateTitle = new System.Windows.Forms.Label();
            this.lbOldLicenseID = new System.Windows.Forms.Label();
            this.lbOldLicenseIDTitle = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lbRenewedLicenseIDTItle = new System.Windows.Forms.Label();
            this.lbLicenseFees = new System.Windows.Forms.Label();
            this.lbLicenseFeesTitle = new System.Windows.Forms.Label();
            this.lbApplicationFees = new System.Windows.Forms.Label();
            this.lbApplicationFeesTilte = new System.Windows.Forms.Label();
            this.lbIssueDate = new System.Windows.Forms.Label();
            this.lbIssueDateTitle = new System.Windows.Forms.Label();
            this.lbApplicationDate = new System.Windows.Forms.Label();
            this.lbApplicationDateTitle = new System.Windows.Forms.Label();
            this.lbApplicationID = new System.Windows.Forms.Label();
            this.lbApplicationIDTitle = new System.Windows.Forms.Label();
            this.btnRenew = new System.Windows.Forms.Button();
            this.ctrlLicensesFinder1 = new PresentationLayer.ctrlLicensesFinder();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTotalFees);
            this.groupBox1.Controls.Add(this.lbTotalFeesTitle);
            this.groupBox1.Controls.Add(this.lbCreatedBy);
            this.groupBox1.Controls.Add(this.lbCreatedByTitle);
            this.groupBox1.Controls.Add(this.lbExpirationDate);
            this.groupBox1.Controls.Add(this.lbExpirationDateTitle);
            this.groupBox1.Controls.Add(this.lbOldLicenseID);
            this.groupBox1.Controls.Add(this.lbOldLicenseIDTitle);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.lbRenewedLicenseIDTItle);
            this.groupBox1.Controls.Add(this.lbLicenseFees);
            this.groupBox1.Controls.Add(this.lbLicenseFeesTitle);
            this.groupBox1.Controls.Add(this.lbApplicationFees);
            this.groupBox1.Controls.Add(this.lbApplicationFeesTilte);
            this.groupBox1.Controls.Add(this.lbIssueDate);
            this.groupBox1.Controls.Add(this.lbIssueDateTitle);
            this.groupBox1.Controls.Add(this.lbApplicationDate);
            this.groupBox1.Controls.Add(this.lbApplicationDateTitle);
            this.groupBox1.Controls.Add(this.lbApplicationID);
            this.groupBox1.Controls.Add(this.lbApplicationIDTitle);
            this.groupBox1.Location = new System.Drawing.Point(12, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 171);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application Infos";
            // 
            // lbTotalFees
            // 
            this.lbTotalFees.AutoSize = true;
            this.lbTotalFees.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalFees.Location = new System.Drawing.Point(450, 139);
            this.lbTotalFees.Name = "lbTotalFees";
            this.lbTotalFees.Size = new System.Drawing.Size(33, 13);
            this.lbTotalFees.TabIndex = 21;
            this.lbTotalFees.Text = "[€€€]";
            // 
            // lbTotalFeesTitle
            // 
            this.lbTotalFeesTitle.AutoSize = true;
            this.lbTotalFeesTitle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalFeesTitle.Location = new System.Drawing.Point(313, 138);
            this.lbTotalFeesTitle.Name = "lbTotalFeesTitle";
            this.lbTotalFeesTitle.Size = new System.Drawing.Size(72, 14);
            this.lbTotalFeesTitle.TabIndex = 20;
            this.lbTotalFeesTitle.Text = "Total Fees:";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedBy.Location = new System.Drawing.Point(450, 111);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(30, 13);
            this.lbCreatedBy.TabIndex = 19;
            this.lbCreatedBy.Text = "[???]";
            // 
            // lbCreatedByTitle
            // 
            this.lbCreatedByTitle.AutoSize = true;
            this.lbCreatedByTitle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedByTitle.Location = new System.Drawing.Point(313, 110);
            this.lbCreatedByTitle.Name = "lbCreatedByTitle";
            this.lbCreatedByTitle.Size = new System.Drawing.Size(78, 14);
            this.lbCreatedByTitle.TabIndex = 18;
            this.lbCreatedByTitle.Text = "Created By:";
            // 
            // lbExpirationDate
            // 
            this.lbExpirationDate.AutoSize = true;
            this.lbExpirationDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExpirationDate.Location = new System.Drawing.Point(450, 83);
            this.lbExpirationDate.Name = "lbExpirationDate";
            this.lbExpirationDate.Size = new System.Drawing.Size(30, 13);
            this.lbExpirationDate.TabIndex = 17;
            this.lbExpirationDate.Text = "[???]";
            // 
            // lbExpirationDateTitle
            // 
            this.lbExpirationDateTitle.AutoSize = true;
            this.lbExpirationDateTitle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExpirationDateTitle.Location = new System.Drawing.Point(313, 82);
            this.lbExpirationDateTitle.Name = "lbExpirationDateTitle";
            this.lbExpirationDateTitle.Size = new System.Drawing.Size(106, 14);
            this.lbExpirationDateTitle.TabIndex = 16;
            this.lbExpirationDateTitle.Text = "Expiration Date:";
            // 
            // lbOldLicenseID
            // 
            this.lbOldLicenseID.AutoSize = true;
            this.lbOldLicenseID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOldLicenseID.Location = new System.Drawing.Point(450, 55);
            this.lbOldLicenseID.Name = "lbOldLicenseID";
            this.lbOldLicenseID.Size = new System.Drawing.Size(30, 13);
            this.lbOldLicenseID.TabIndex = 15;
            this.lbOldLicenseID.Text = "[???]";
            // 
            // lbOldLicenseIDTitle
            // 
            this.lbOldLicenseIDTitle.AutoSize = true;
            this.lbOldLicenseIDTitle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOldLicenseIDTitle.Location = new System.Drawing.Point(313, 54);
            this.lbOldLicenseIDTitle.Name = "lbOldLicenseIDTitle";
            this.lbOldLicenseIDTitle.Size = new System.Drawing.Size(97, 14);
            this.lbOldLicenseIDTitle.TabIndex = 14;
            this.lbOldLicenseIDTitle.Text = "Old License ID:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(450, 27);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(30, 13);
            this.label23.TabIndex = 13;
            this.label23.Text = "[???]";
            // 
            // lbRenewedLicenseIDTItle
            // 
            this.lbRenewedLicenseIDTItle.AutoSize = true;
            this.lbRenewedLicenseIDTItle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRenewedLicenseIDTItle.Location = new System.Drawing.Point(313, 26);
            this.lbRenewedLicenseIDTItle.Name = "lbRenewedLicenseIDTItle";
            this.lbRenewedLicenseIDTItle.Size = new System.Drawing.Size(134, 14);
            this.lbRenewedLicenseIDTItle.TabIndex = 12;
            this.lbRenewedLicenseIDTItle.Text = "Renewed License ID:";
            // 
            // lbLicenseFees
            // 
            this.lbLicenseFees.AutoSize = true;
            this.lbLicenseFees.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicenseFees.Location = new System.Drawing.Point(151, 139);
            this.lbLicenseFees.Name = "lbLicenseFees";
            this.lbLicenseFees.Size = new System.Drawing.Size(33, 13);
            this.lbLicenseFees.TabIndex = 9;
            this.lbLicenseFees.Text = "[€€€]";
            // 
            // lbLicenseFeesTitle
            // 
            this.lbLicenseFeesTitle.AutoSize = true;
            this.lbLicenseFeesTitle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicenseFeesTitle.Location = new System.Drawing.Point(23, 138);
            this.lbLicenseFeesTitle.Name = "lbLicenseFeesTitle";
            this.lbLicenseFeesTitle.Size = new System.Drawing.Size(85, 14);
            this.lbLicenseFeesTitle.TabIndex = 8;
            this.lbLicenseFeesTitle.Text = "License Fees:";
            // 
            // lbApplicationFees
            // 
            this.lbApplicationFees.AutoSize = true;
            this.lbApplicationFees.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationFees.Location = new System.Drawing.Point(151, 111);
            this.lbApplicationFees.Name = "lbApplicationFees";
            this.lbApplicationFees.Size = new System.Drawing.Size(30, 13);
            this.lbApplicationFees.TabIndex = 7;
            this.lbApplicationFees.Text = "[???]";
            // 
            // lbApplicationFeesTilte
            // 
            this.lbApplicationFeesTilte.AutoSize = true;
            this.lbApplicationFeesTilte.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationFeesTilte.Location = new System.Drawing.Point(23, 110);
            this.lbApplicationFeesTilte.Name = "lbApplicationFeesTilte";
            this.lbApplicationFeesTilte.Size = new System.Drawing.Size(110, 14);
            this.lbApplicationFeesTilte.TabIndex = 6;
            this.lbApplicationFeesTilte.Text = "Application Fees:";
            // 
            // lbIssueDate
            // 
            this.lbIssueDate.AutoSize = true;
            this.lbIssueDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIssueDate.Location = new System.Drawing.Point(151, 83);
            this.lbIssueDate.Name = "lbIssueDate";
            this.lbIssueDate.Size = new System.Drawing.Size(30, 13);
            this.lbIssueDate.TabIndex = 5;
            this.lbIssueDate.Text = "[???]";
            // 
            // lbIssueDateTitle
            // 
            this.lbIssueDateTitle.AutoSize = true;
            this.lbIssueDateTitle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIssueDateTitle.Location = new System.Drawing.Point(23, 82);
            this.lbIssueDateTitle.Name = "lbIssueDateTitle";
            this.lbIssueDateTitle.Size = new System.Drawing.Size(76, 14);
            this.lbIssueDateTitle.TabIndex = 4;
            this.lbIssueDateTitle.Text = "Issue Date:";
            // 
            // lbApplicationDate
            // 
            this.lbApplicationDate.AutoSize = true;
            this.lbApplicationDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationDate.Location = new System.Drawing.Point(151, 55);
            this.lbApplicationDate.Name = "lbApplicationDate";
            this.lbApplicationDate.Size = new System.Drawing.Size(30, 13);
            this.lbApplicationDate.TabIndex = 3;
            this.lbApplicationDate.Text = "[???]";
            // 
            // lbApplicationDateTitle
            // 
            this.lbApplicationDateTitle.AutoSize = true;
            this.lbApplicationDateTitle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationDateTitle.Location = new System.Drawing.Point(23, 54);
            this.lbApplicationDateTitle.Name = "lbApplicationDateTitle";
            this.lbApplicationDateTitle.Size = new System.Drawing.Size(113, 14);
            this.lbApplicationDateTitle.TabIndex = 2;
            this.lbApplicationDateTitle.Text = "Application Date:";
            // 
            // lbApplicationID
            // 
            this.lbApplicationID.AutoSize = true;
            this.lbApplicationID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationID.Location = new System.Drawing.Point(151, 27);
            this.lbApplicationID.Name = "lbApplicationID";
            this.lbApplicationID.Size = new System.Drawing.Size(30, 13);
            this.lbApplicationID.TabIndex = 1;
            this.lbApplicationID.Text = "[???]";
            // 
            // lbApplicationIDTitle
            // 
            this.lbApplicationIDTitle.AutoSize = true;
            this.lbApplicationIDTitle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationIDTitle.Location = new System.Drawing.Point(23, 26);
            this.lbApplicationIDTitle.Name = "lbApplicationIDTitle";
            this.lbApplicationIDTitle.Size = new System.Drawing.Size(122, 14);
            this.lbApplicationIDTitle.TabIndex = 0;
            this.lbApplicationIDTitle.Text = "R.L Application ID:";
            // 
            // btnRenew
            // 
            this.btnRenew.Location = new System.Drawing.Point(517, 493);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(75, 23);
            this.btnRenew.TabIndex = 2;
            this.btnRenew.Text = "Renew";
            this.btnRenew.UseVisualStyleBackColor = true;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // ctrlLicensesFinder1
            // 
            this.ctrlLicensesFinder1.license = null;
            this.ctrlLicensesFinder1.Location = new System.Drawing.Point(0, 0);
            this.ctrlLicensesFinder1.Name = "ctrlLicensesFinder1";
            this.ctrlLicensesFinder1.Size = new System.Drawing.Size(598, 304);
            this.ctrlLicensesFinder1.TabIndex = 3;
            this.ctrlLicensesFinder1.OnDrivingLicenseSelected += new System.Action<clsLicense>(this.ctrlLicensesFinder1_OnDrivingLicenseSelected);
            // 
            // RenewLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 528);
            this.Controls.Add(this.ctrlLicensesFinder1);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RenewLicense";
            this.Text = "Renew License";
            this.Load += new System.EventHandler(this.RenewLicense_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void btnRenew_Click(object sender, EventArgs e)
        {


            clsLicense license = ctrlLicensesFinder1.license;
            if(license.LicenseId < 0)
            {
                MessageBox.Show($"There is no License Picked, please try again!","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            license.IsActive = false;
            if(license.Save())
            {
                clsApplicationType applicationType = clsApplicationType.GetApplicationType(2);
                clsApplication application = new clsApplication(license.Driver,DateTime.Now,
                    applicationType,DateTime.Now,clsApplication.enApplicationStatus.New,(decimal)lbTotalFees.Tag,CurrentLogedinUser.currentUser
                    );


                if(application.SaveApp())
                {
                    clsLicense newLicense = new clsLicense(application,license.Driver,
                        license.LicenseClass,DateTime.Now,DateTime.Now.AddYears(license.LicenseClass.DefaultValidityLength),
                        "",application.PaidFees,true, enIssueReason.Renew, CurrentLogedinUser.currentUser);

                    if(newLicense.Save())
                    {
                        MessageBox.Show($"New License Has been Issued with ID{newLicense.LicenseId}");
                        return;
                    }
                }

            }

            MessageBox.Show($"An Error,Try Again!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void ctrlLicensesFinder1_OnDrivingLicenseSelected(clsLicense obj)
        {
            if (obj == null)
                return;

            if(ctrlLicensesFinder1.license.ExpirationDate > DateTime.Now)
                MessageBox.Show("This License Is not Expired, are you sure you want to renew it!");
            


            lbLicenseFees.Text = ctrlLicensesFinder1.license.PaidFees.ToString("0.##€");
            lbLicenseFees.Tag = ctrlLicensesFinder1.license.PaidFees;

            lbOldLicenseID.Text = ctrlLicensesFinder1.license.LicenseId.ToString();
            lbExpirationDate.Text = DateTime.Now.AddYears(ctrlLicensesFinder1.license.LicenseClass.DefaultValidityLength).ToString("dd.MM.yyyy");



            lbTotalFees.Text = (ctrlLicensesFinder1.license.PaidFees + (decimal)lbApplicationFees.Tag).ToString("0.##€");
            lbTotalFees.Tag = (ctrlLicensesFinder1.license.PaidFees + (decimal)lbApplicationFees.Tag);


        }
    }
}
