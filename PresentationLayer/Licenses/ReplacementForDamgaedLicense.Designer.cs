using BusinessLayer;

namespace PresentationLayer
{
    partial class ReplacementForDamgaedLicense
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitle = new System.Windows.Forms.Label();
            this.gpApplicationInfo = new System.Windows.Forms.GroupBox();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.lbCreatedByTitle = new System.Windows.Forms.Label();
            this.lbOldLicenseID = new System.Windows.Forms.Label();
            this.lbOldLicenseIDTitle = new System.Windows.Forms.Label();
            this.lbReplacedLicenseID = new System.Windows.Forms.Label();
            this.lbReplacedLicenseIDTitle = new System.Windows.Forms.Label();
            this.lbApplicatinoFees = new System.Windows.Forms.Label();
            this.lbApplicatinoFeesTitle = new System.Windows.Forms.Label();
            this.lbApplicationDate = new System.Windows.Forms.Label();
            this.lbApplicationDateTitle = new System.Windows.Forms.Label();
            this.lbLRApplcationID = new System.Windows.Forms.Label();
            this.lbLRApplcationIDTitle = new System.Windows.Forms.Label();
            this.btnIssueReplacement = new System.Windows.Forms.Button();
            this.ctrlLicensesFinder1 = new PresentationLayer.ctrlLicensesFinder();
            this.gpReplacementFor = new System.Windows.Forms.GroupBox();
            this.rbLostLicense = new System.Windows.Forms.RadioButton();
            this.rbDamagedLicense = new System.Windows.Forms.RadioButton();
            this.gpApplicationInfo.SuspendLayout();
            this.gpReplacementFor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(743, 47);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Replacement For Damgaed License";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpApplicationInfo
            // 
            this.gpApplicationInfo.Controls.Add(this.lbCreatedBy);
            this.gpApplicationInfo.Controls.Add(this.lbCreatedByTitle);
            this.gpApplicationInfo.Controls.Add(this.lbOldLicenseID);
            this.gpApplicationInfo.Controls.Add(this.lbOldLicenseIDTitle);
            this.gpApplicationInfo.Controls.Add(this.lbReplacedLicenseID);
            this.gpApplicationInfo.Controls.Add(this.lbReplacedLicenseIDTitle);
            this.gpApplicationInfo.Controls.Add(this.lbApplicatinoFees);
            this.gpApplicationInfo.Controls.Add(this.lbApplicatinoFeesTitle);
            this.gpApplicationInfo.Controls.Add(this.lbApplicationDate);
            this.gpApplicationInfo.Controls.Add(this.lbApplicationDateTitle);
            this.gpApplicationInfo.Controls.Add(this.lbLRApplcationID);
            this.gpApplicationInfo.Controls.Add(this.lbLRApplcationIDTitle);
            this.gpApplicationInfo.Location = new System.Drawing.Point(21, 347);
            this.gpApplicationInfo.Name = "gpApplicationInfo";
            this.gpApplicationInfo.Size = new System.Drawing.Size(710, 131);
            this.gpApplicationInfo.TabIndex = 3;
            this.gpApplicationInfo.TabStop = false;
            this.gpApplicationInfo.Text = "Application Info";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedBy.Location = new System.Drawing.Point(595, 94);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(35, 14);
            this.lbCreatedBy.TabIndex = 11;
            this.lbCreatedBy.Text = "[???]";
            // 
            // lbCreatedByTitle
            // 
            this.lbCreatedByTitle.AutoSize = true;
            this.lbCreatedByTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedByTitle.Location = new System.Drawing.Point(448, 94);
            this.lbCreatedByTitle.Name = "lbCreatedByTitle";
            this.lbCreatedByTitle.Size = new System.Drawing.Size(99, 16);
            this.lbCreatedByTitle.TabIndex = 10;
            this.lbCreatedByTitle.Text = "lb Created By:";
            // 
            // lbOldLicenseID
            // 
            this.lbOldLicenseID.AutoSize = true;
            this.lbOldLicenseID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOldLicenseID.Location = new System.Drawing.Point(595, 63);
            this.lbOldLicenseID.Name = "lbOldLicenseID";
            this.lbOldLicenseID.Size = new System.Drawing.Size(35, 14);
            this.lbOldLicenseID.TabIndex = 9;
            this.lbOldLicenseID.Text = "[???]";
            // 
            // lbOldLicenseIDTitle
            // 
            this.lbOldLicenseIDTitle.AutoSize = true;
            this.lbOldLicenseIDTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOldLicenseIDTitle.Location = new System.Drawing.Point(448, 63);
            this.lbOldLicenseIDTitle.Name = "lbOldLicenseIDTitle";
            this.lbOldLicenseIDTitle.Size = new System.Drawing.Size(102, 16);
            this.lbOldLicenseIDTitle.TabIndex = 8;
            this.lbOldLicenseIDTitle.Text = "Old License ID:";
            // 
            // lbReplacedLicenseID
            // 
            this.lbReplacedLicenseID.AutoSize = true;
            this.lbReplacedLicenseID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReplacedLicenseID.Location = new System.Drawing.Point(595, 35);
            this.lbReplacedLicenseID.Name = "lbReplacedLicenseID";
            this.lbReplacedLicenseID.Size = new System.Drawing.Size(35, 14);
            this.lbReplacedLicenseID.TabIndex = 7;
            this.lbReplacedLicenseID.Text = "[???]";
            // 
            // lbReplacedLicenseIDTitle
            // 
            this.lbReplacedLicenseIDTitle.AutoSize = true;
            this.lbReplacedLicenseIDTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReplacedLicenseIDTitle.Location = new System.Drawing.Point(448, 35);
            this.lbReplacedLicenseIDTitle.Name = "lbReplacedLicenseIDTitle";
            this.lbReplacedLicenseIDTitle.Size = new System.Drawing.Size(141, 16);
            this.lbReplacedLicenseIDTitle.TabIndex = 6;
            this.lbReplacedLicenseIDTitle.Text = "Replaced License ID:";
            // 
            // lbApplicatinoFees
            // 
            this.lbApplicatinoFees.AutoSize = true;
            this.lbApplicatinoFees.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicatinoFees.Location = new System.Drawing.Point(152, 96);
            this.lbApplicatinoFees.Name = "lbApplicatinoFees";
            this.lbApplicatinoFees.Size = new System.Drawing.Size(35, 14);
            this.lbApplicatinoFees.TabIndex = 5;
            this.lbApplicatinoFees.Text = "[???]";
            // 
            // lbApplicatinoFeesTitle
            // 
            this.lbApplicatinoFeesTitle.AutoSize = true;
            this.lbApplicatinoFeesTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicatinoFeesTitle.Location = new System.Drawing.Point(23, 96);
            this.lbApplicatinoFeesTitle.Name = "lbApplicatinoFeesTitle";
            this.lbApplicatinoFeesTitle.Size = new System.Drawing.Size(117, 16);
            this.lbApplicatinoFeesTitle.TabIndex = 4;
            this.lbApplicatinoFeesTitle.Text = "Applicatino Fees:";
            // 
            // lbApplicationDate
            // 
            this.lbApplicationDate.AutoSize = true;
            this.lbApplicationDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationDate.Location = new System.Drawing.Point(152, 65);
            this.lbApplicationDate.Name = "lbApplicationDate";
            this.lbApplicationDate.Size = new System.Drawing.Size(35, 14);
            this.lbApplicationDate.TabIndex = 3;
            this.lbApplicationDate.Text = "[???]";
            // 
            // lbApplicationDateTitle
            // 
            this.lbApplicationDateTitle.AutoSize = true;
            this.lbApplicationDateTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationDateTitle.Location = new System.Drawing.Point(23, 65);
            this.lbApplicationDateTitle.Name = "lbApplicationDateTitle";
            this.lbApplicationDateTitle.Size = new System.Drawing.Size(119, 16);
            this.lbApplicationDateTitle.TabIndex = 2;
            this.lbApplicationDateTitle.Text = "Application Date:";
            // 
            // lbLRApplcationID
            // 
            this.lbLRApplcationID.AutoSize = true;
            this.lbLRApplcationID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLRApplcationID.Location = new System.Drawing.Point(152, 37);
            this.lbLRApplcationID.Name = "lbLRApplcationID";
            this.lbLRApplcationID.Size = new System.Drawing.Size(35, 14);
            this.lbLRApplcationID.TabIndex = 1;
            this.lbLRApplcationID.Text = "[???]";
            // 
            // lbLRApplcationIDTitle
            // 
            this.lbLRApplcationIDTitle.AutoSize = true;
            this.lbLRApplcationIDTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLRApplcationIDTitle.Location = new System.Drawing.Point(23, 37);
            this.lbLRApplcationIDTitle.Name = "lbLRApplcationIDTitle";
            this.lbLRApplcationIDTitle.Size = new System.Drawing.Size(123, 16);
            this.lbLRApplcationIDTitle.TabIndex = 0;
            this.lbLRApplcationIDTitle.Text = "L.R Applcation ID:";
            // 
            // btnIssueReplacement
            // 
            this.btnIssueReplacement.Location = new System.Drawing.Point(623, 484);
            this.btnIssueReplacement.Name = "btnIssueReplacement";
            this.btnIssueReplacement.Size = new System.Drawing.Size(108, 34);
            this.btnIssueReplacement.TabIndex = 4;
            this.btnIssueReplacement.Text = "Issue Replacement";
            this.btnIssueReplacement.UseVisualStyleBackColor = true;
            this.btnIssueReplacement.Click += new System.EventHandler(this.btnIssueReplacement_Click);
            // 
            // ctrlLicensesFinder1
            // 
            this.ctrlLicensesFinder1.license = null;
            this.ctrlLicensesFinder1.Location = new System.Drawing.Point(21, 37);
            this.ctrlLicensesFinder1.Name = "ctrlLicensesFinder1";
            this.ctrlLicensesFinder1.Size = new System.Drawing.Size(722, 304);
            this.ctrlLicensesFinder1.TabIndex = 1;
            this.ctrlLicensesFinder1.OnDrivingLicenseSelected += new System.Action<clsLicense>(this.ctrlLicensesFinder1_OnDrivingLicenseSelected);
            // 
            // gpReplacementFor
            // 
            this.gpReplacementFor.Controls.Add(this.rbLostLicense);
            this.gpReplacementFor.Controls.Add(this.rbDamagedLicense);
            this.gpReplacementFor.Location = new System.Drawing.Point(611, 37);
            this.gpReplacementFor.Name = "gpReplacementFor";
            this.gpReplacementFor.Size = new System.Drawing.Size(117, 71);
            this.gpReplacementFor.TabIndex = 5;
            this.gpReplacementFor.TabStop = false;
            this.gpReplacementFor.Text = "Replacement For";
            // 
            // rbLostLicense
            // 
            this.rbLostLicense.AutoSize = true;
            this.rbLostLicense.Location = new System.Drawing.Point(6, 39);
            this.rbLostLicense.Name = "rbLostLicense";
            this.rbLostLicense.Size = new System.Drawing.Size(83, 17);
            this.rbLostLicense.TabIndex = 1;
            this.rbLostLicense.TabStop = true;
            this.rbLostLicense.Text = "Lost License";
            this.rbLostLicense.UseVisualStyleBackColor = true;
            // 
            // rbDamagedLicense
            // 
            this.rbDamagedLicense.AutoSize = true;
            this.rbDamagedLicense.Checked = true;
            this.rbDamagedLicense.Location = new System.Drawing.Point(6, 19);
            this.rbDamagedLicense.Name = "rbDamagedLicense";
            this.rbDamagedLicense.Size = new System.Drawing.Size(108, 17);
            this.rbDamagedLicense.TabIndex = 0;
            this.rbDamagedLicense.TabStop = true;
            this.rbDamagedLicense.Text = "Damaged License";
            this.rbDamagedLicense.UseVisualStyleBackColor = true;
            // 
            // ReplacementForDamgaedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 531);
            this.Controls.Add(this.gpReplacementFor);
            this.Controls.Add(this.ctrlLicensesFinder1);
            this.Controls.Add(this.btnIssueReplacement);
            this.Controls.Add(this.gpApplicationInfo);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReplacementForDamgaedLicense";
            this.Text = "Replacement For Damgaed License";
            this.Load += new System.EventHandler(this.ReplacementForDamgaedLicense_Load);
            this.gpApplicationInfo.ResumeLayout(false);
            this.gpApplicationInfo.PerformLayout();
            this.gpReplacementFor.ResumeLayout(false);
            this.gpReplacementFor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private ctrlLicensesFinder ctrlLicensesFinder1;
        private System.Windows.Forms.GroupBox gpApplicationInfo;
        private System.Windows.Forms.Button btnIssueReplacement;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label lbCreatedByTitle;
        private System.Windows.Forms.Label lbOldLicenseID;
        private System.Windows.Forms.Label lbOldLicenseIDTitle;
        private System.Windows.Forms.Label lbReplacedLicenseID;
        private System.Windows.Forms.Label lbReplacedLicenseIDTitle;
        private System.Windows.Forms.Label lbApplicatinoFees;
        private System.Windows.Forms.Label lbApplicatinoFeesTitle;
        private System.Windows.Forms.Label lbApplicationDate;
        private System.Windows.Forms.Label lbApplicationDateTitle;
        private System.Windows.Forms.Label lbLRApplcationID;
        private System.Windows.Forms.Label lbLRApplcationIDTitle;
        private System.Windows.Forms.GroupBox gpReplacementFor;
        private System.Windows.Forms.RadioButton rbLostLicense;
        private System.Windows.Forms.RadioButton rbDamagedLicense;
    }
}