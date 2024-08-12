namespace PresentationLayer
{
    partial class ReleaseDetainedLicense
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
            this.btnDetain = new System.Windows.Forms.Button();
            this.gpDetainInfos = new System.Windows.Forms.GroupBox();
            this.lbApplicatioId = new System.Windows.Forms.Label();
            this.lbApplicatioIdTitle = new System.Windows.Forms.Label();
            this.lbTotalFees = new System.Windows.Forms.Label();
            this.lbTotalFeesTitle = new System.Windows.Forms.Label();
            this.lbApplicationFees = new System.Windows.Forms.Label();
            this.lbApplicationFeesTitle = new System.Windows.Forms.Label();
            this.lbFineFees = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.lbCreatedByTitle = new System.Windows.Forms.Label();
            this.lbLicenseID = new System.Windows.Forms.Label();
            this.lbLicenseIDTitle = new System.Windows.Forms.Label();
            this.lbFineFeesTitle = new System.Windows.Forms.Label();
            this.lbDetainDate = new System.Windows.Forms.Label();
            this.lbDetainDateTitle = new System.Windows.Forms.Label();
            this.lbDetainID = new System.Windows.Forms.Label();
            this.lbDetainIDTitle = new System.Windows.Forms.Label();
            this.ctrlLicensesFinder1 = new PresentationLayer.ctrlLicensesFinder();
            this.gpDetainInfos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(604, 36);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Release Detained License";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDetain
            // 
            this.btnDetain.Location = new System.Drawing.Point(517, 534);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(75, 23);
            this.btnDetain.TabIndex = 0;
            this.btnDetain.Text = "Save";
            this.btnDetain.UseVisualStyleBackColor = true;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // gpDetainInfos
            // 
            this.gpDetainInfos.Controls.Add(this.lbApplicatioId);
            this.gpDetainInfos.Controls.Add(this.lbApplicatioIdTitle);
            this.gpDetainInfos.Controls.Add(this.lbTotalFees);
            this.gpDetainInfos.Controls.Add(this.lbTotalFeesTitle);
            this.gpDetainInfos.Controls.Add(this.lbApplicationFees);
            this.gpDetainInfos.Controls.Add(this.lbApplicationFeesTitle);
            this.gpDetainInfos.Controls.Add(this.lbFineFees);
            this.gpDetainInfos.Controls.Add(this.lbCreatedBy);
            this.gpDetainInfos.Controls.Add(this.lbCreatedByTitle);
            this.gpDetainInfos.Controls.Add(this.lbLicenseID);
            this.gpDetainInfos.Controls.Add(this.lbLicenseIDTitle);
            this.gpDetainInfos.Controls.Add(this.lbFineFeesTitle);
            this.gpDetainInfos.Controls.Add(this.lbDetainDate);
            this.gpDetainInfos.Controls.Add(this.lbDetainDateTitle);
            this.gpDetainInfos.Controls.Add(this.lbDetainID);
            this.gpDetainInfos.Controls.Add(this.lbDetainIDTitle);
            this.gpDetainInfos.Location = new System.Drawing.Point(12, 369);
            this.gpDetainInfos.Name = "gpDetainInfos";
            this.gpDetainInfos.Size = new System.Drawing.Size(580, 159);
            this.gpDetainInfos.TabIndex = 3;
            this.gpDetainInfos.TabStop = false;
            this.gpDetainInfos.Text = "Detain Infos";
            // 
            // lbApplicatioId
            // 
            this.lbApplicatioId.AutoSize = true;
            this.lbApplicatioId.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicatioId.Location = new System.Drawing.Point(446, 136);
            this.lbApplicatioId.Name = "lbApplicatioId";
            this.lbApplicatioId.Size = new System.Drawing.Size(30, 13);
            this.lbApplicatioId.TabIndex = 18;
            this.lbApplicatioId.Text = "[???]";
            // 
            // lbApplicatioIdTitle
            // 
            this.lbApplicatioIdTitle.AutoSize = true;
            this.lbApplicatioIdTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicatioIdTitle.Location = new System.Drawing.Point(346, 134);
            this.lbApplicatioIdTitle.Name = "lbApplicatioIdTitle";
            this.lbApplicatioIdTitle.Size = new System.Drawing.Size(94, 16);
            this.lbApplicatioIdTitle.TabIndex = 17;
            this.lbApplicatioIdTitle.Text = "Applicatio ID:";
            // 
            // lbTotalFees
            // 
            this.lbTotalFees.AutoSize = true;
            this.lbTotalFees.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalFees.Location = new System.Drawing.Point(145, 134);
            this.lbTotalFees.Name = "lbTotalFees";
            this.lbTotalFees.Size = new System.Drawing.Size(30, 13);
            this.lbTotalFees.TabIndex = 16;
            this.lbTotalFees.Text = "[???]";
            // 
            // lbTotalFeesTitle
            // 
            this.lbTotalFeesTitle.AutoSize = true;
            this.lbTotalFeesTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalFeesTitle.Location = new System.Drawing.Point(22, 129);
            this.lbTotalFeesTitle.Name = "lbTotalFeesTitle";
            this.lbTotalFeesTitle.Size = new System.Drawing.Size(77, 16);
            this.lbTotalFeesTitle.TabIndex = 15;
            this.lbTotalFeesTitle.Text = "Total Fees:";
            // 
            // lbApplicationFees
            // 
            this.lbApplicationFees.AutoSize = true;
            this.lbApplicationFees.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationFees.Location = new System.Drawing.Point(145, 106);
            this.lbApplicationFees.Name = "lbApplicationFees";
            this.lbApplicationFees.Size = new System.Drawing.Size(30, 13);
            this.lbApplicationFees.TabIndex = 14;
            this.lbApplicationFees.Text = "[???]";
            // 
            // lbApplicationFeesTitle
            // 
            this.lbApplicationFeesTitle.AutoSize = true;
            this.lbApplicationFeesTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationFeesTitle.Location = new System.Drawing.Point(22, 103);
            this.lbApplicationFeesTitle.Name = "lbApplicationFeesTitle";
            this.lbApplicationFeesTitle.Size = new System.Drawing.Size(117, 16);
            this.lbApplicationFeesTitle.TabIndex = 13;
            this.lbApplicationFeesTitle.Text = "Application Fees:";
            // 
            // lbFineFees
            // 
            this.lbFineFees.AutoSize = true;
            this.lbFineFees.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFineFees.Location = new System.Drawing.Point(145, 80);
            this.lbFineFees.Name = "lbFineFees";
            this.lbFineFees.Size = new System.Drawing.Size(30, 13);
            this.lbFineFees.TabIndex = 12;
            this.lbFineFees.Text = "[???]";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedBy.Location = new System.Drawing.Point(430, 53);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(30, 13);
            this.lbCreatedBy.TabIndex = 11;
            this.lbCreatedBy.Text = "[???]";
            // 
            // lbCreatedByTitle
            // 
            this.lbCreatedByTitle.AutoSize = true;
            this.lbCreatedByTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedByTitle.Location = new System.Drawing.Point(346, 50);
            this.lbCreatedByTitle.Name = "lbCreatedByTitle";
            this.lbCreatedByTitle.Size = new System.Drawing.Size(84, 16);
            this.lbCreatedByTitle.TabIndex = 10;
            this.lbCreatedByTitle.Text = "Created By:";
            // 
            // lbLicenseID
            // 
            this.lbLicenseID.AutoSize = true;
            this.lbLicenseID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicenseID.Location = new System.Drawing.Point(430, 28);
            this.lbLicenseID.Name = "lbLicenseID";
            this.lbLicenseID.Size = new System.Drawing.Size(30, 13);
            this.lbLicenseID.TabIndex = 9;
            this.lbLicenseID.Text = "[???]";
            // 
            // lbLicenseIDTitle
            // 
            this.lbLicenseIDTitle.AutoSize = true;
            this.lbLicenseIDTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicenseIDTitle.Location = new System.Drawing.Point(346, 25);
            this.lbLicenseIDTitle.Name = "lbLicenseIDTitle";
            this.lbLicenseIDTitle.Size = new System.Drawing.Size(78, 16);
            this.lbLicenseIDTitle.TabIndex = 8;
            this.lbLicenseIDTitle.Text = "License ID:";
            // 
            // lbFineFeesTitle
            // 
            this.lbFineFeesTitle.AutoSize = true;
            this.lbFineFeesTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFineFeesTitle.Location = new System.Drawing.Point(22, 77);
            this.lbFineFeesTitle.Name = "lbFineFeesTitle";
            this.lbFineFeesTitle.Size = new System.Drawing.Size(70, 16);
            this.lbFineFeesTitle.TabIndex = 4;
            this.lbFineFeesTitle.Text = "Fine Fees:";
            // 
            // lbDetainDate
            // 
            this.lbDetainDate.AutoSize = true;
            this.lbDetainDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetainDate.Location = new System.Drawing.Point(145, 52);
            this.lbDetainDate.Name = "lbDetainDate";
            this.lbDetainDate.Size = new System.Drawing.Size(30, 13);
            this.lbDetainDate.TabIndex = 3;
            this.lbDetainDate.Text = "[???]";
            // 
            // lbDetainDateTitle
            // 
            this.lbDetainDateTitle.AutoSize = true;
            this.lbDetainDateTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetainDateTitle.Location = new System.Drawing.Point(22, 51);
            this.lbDetainDateTitle.Name = "lbDetainDateTitle";
            this.lbDetainDateTitle.Size = new System.Drawing.Size(89, 16);
            this.lbDetainDateTitle.TabIndex = 2;
            this.lbDetainDateTitle.Text = "Detain Date:";
            // 
            // lbDetainID
            // 
            this.lbDetainID.AutoSize = true;
            this.lbDetainID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetainID.Location = new System.Drawing.Point(145, 28);
            this.lbDetainID.Name = "lbDetainID";
            this.lbDetainID.Size = new System.Drawing.Size(30, 13);
            this.lbDetainID.TabIndex = 1;
            this.lbDetainID.Text = "[???]";
            // 
            // lbDetainIDTitle
            // 
            this.lbDetainIDTitle.AutoSize = true;
            this.lbDetainIDTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetainIDTitle.Location = new System.Drawing.Point(22, 25);
            this.lbDetainIDTitle.Name = "lbDetainIDTitle";
            this.lbDetainIDTitle.Size = new System.Drawing.Size(72, 16);
            this.lbDetainIDTitle.TabIndex = 0;
            this.lbDetainIDTitle.Text = "Detain ID:";
            // 
            // ctrlLicensesFinder1
            // 
            this.ctrlLicensesFinder1.license = null;
            this.ctrlLicensesFinder1.Location = new System.Drawing.Point(4, 59);
            this.ctrlLicensesFinder1.Name = "ctrlLicensesFinder1";
            this.ctrlLicensesFinder1.Size = new System.Drawing.Size(598, 304);
            this.ctrlLicensesFinder1.TabIndex = 4;
            this.ctrlLicensesFinder1.OnDrivingLicenseSelected += new System.Action<BusinessLayer.clsLicense>(this.ctrlLicensesFinder1_OnDrivingLicenseSelected_1);
            // 
            // ReleaseDetainedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 569);
            this.Controls.Add(this.ctrlLicensesFinder1);
            this.Controls.Add(this.gpDetainInfos);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReleaseDetainedLicense";
            this.Text = "Release Detained License";
            this.Load += new System.EventHandler(this.ReleaseDetainedLicense_Load_1);
            this.gpDetainInfos.ResumeLayout(false);
            this.gpDetainInfos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnDetain;
        private System.Windows.Forms.GroupBox gpDetainInfos;
        private System.Windows.Forms.Label lbApplicatioId;
        private System.Windows.Forms.Label lbApplicatioIdTitle;
        private System.Windows.Forms.Label lbTotalFees;
        private System.Windows.Forms.Label lbTotalFeesTitle;
        private System.Windows.Forms.Label lbApplicationFees;
        private System.Windows.Forms.Label lbApplicationFeesTitle;
        private System.Windows.Forms.Label lbFineFees;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label lbCreatedByTitle;
        private System.Windows.Forms.Label lbLicenseID;
        private System.Windows.Forms.Label lbLicenseIDTitle;
        private System.Windows.Forms.Label lbFineFeesTitle;
        private System.Windows.Forms.Label lbDetainDate;
        private System.Windows.Forms.Label lbDetainDateTitle;
        private System.Windows.Forms.Label lbDetainID;
        private System.Windows.Forms.Label lbDetainIDTitle;
        private ctrlLicensesFinder ctrlLicensesFinder1;
    }
}