namespace PresentationLayer
{
    partial class AddLocalDrivingLicenseApplication
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
            this.tcApplicatinoInfo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlPersonFinder1 = new PresentationLayer.ctrlPersonFinder();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbLicenseClass = new System.Windows.Forms.ComboBox();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.lbCreatedByTitle = new System.Windows.Forms.Label();
            this.lbFees = new System.Windows.Forms.Label();
            this.lbApplicationFeesTitle = new System.Windows.Forms.Label();
            this.lbLicenseClassTitle = new System.Windows.Forms.Label();
            this.lbApplicationDate = new System.Windows.Forms.Label();
            this.lbApplicationDateTitle = new System.Windows.Forms.Label();
            this.lbDLApplication = new System.Windows.Forms.Label();
            this.lbDLApplicationTitle = new System.Windows.Forms.Label();
            this.tcApplicatinoInfo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbTitle.Location = new System.Drawing.Point(72, 10);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(572, 35);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "New Local Driving License Application";
            // 
            // tcApplicatinoInfo
            // 
            this.tcApplicatinoInfo.Controls.Add(this.tabPage1);
            this.tcApplicatinoInfo.Controls.Add(this.tabPage2);
            this.tcApplicatinoInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tcApplicatinoInfo.Location = new System.Drawing.Point(15, 70);
            this.tcApplicatinoInfo.Name = "tcApplicatinoInfo";
            this.tcApplicatinoInfo.SelectedIndex = 0;
            this.tcApplicatinoInfo.Size = new System.Drawing.Size(731, 373);
            this.tcApplicatinoInfo.TabIndex = 3;
            this.tcApplicatinoInfo.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tcApplicatinoInfo_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Controls.Add(this.ctrlPersonFinder1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(723, 347);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personal Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(631, 308);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlPersonFinder1
            // 
            this.ctrlPersonFinder1.Location = new System.Drawing.Point(3, 3);
            this.ctrlPersonFinder1.Name = "ctrlPersonFinder1";
            this.ctrlPersonFinder1.Size = new System.Drawing.Size(717, 337);
            this.ctrlPersonFinder1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Controls.Add(this.cbLicenseClass);
            this.tabPage2.Controls.Add(this.lbCreatedBy);
            this.tabPage2.Controls.Add(this.lbCreatedByTitle);
            this.tabPage2.Controls.Add(this.lbFees);
            this.tabPage2.Controls.Add(this.lbApplicationFeesTitle);
            this.tabPage2.Controls.Add(this.lbLicenseClassTitle);
            this.tabPage2.Controls.Add(this.lbApplicationDate);
            this.tabPage2.Controls.Add(this.lbApplicationDateTitle);
            this.tabPage2.Controls.Add(this.lbDLApplication);
            this.tabPage2.Controls.Add(this.lbDLApplicationTitle);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(723, 347);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Application Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(642, 318);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbLicenseClass
            // 
            this.cbLicenseClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLicenseClass.FormattingEnabled = true;
            this.cbLicenseClass.Location = new System.Drawing.Point(244, 106);
            this.cbLicenseClass.Name = "cbLicenseClass";
            this.cbLicenseClass.Size = new System.Drawing.Size(253, 21);
            this.cbLicenseClass.TabIndex = 10;
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedBy.Location = new System.Drawing.Point(240, 169);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(57, 19);
            this.lbCreatedBy.TabIndex = 9;
            this.lbCreatedBy.Text = "[===]";
            // 
            // lbCreatedByTitle
            // 
            this.lbCreatedByTitle.AutoSize = true;
            this.lbCreatedByTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedByTitle.Location = new System.Drawing.Point(55, 169);
            this.lbCreatedByTitle.Name = "lbCreatedByTitle";
            this.lbCreatedByTitle.Size = new System.Drawing.Size(105, 19);
            this.lbCreatedByTitle.TabIndex = 8;
            this.lbCreatedByTitle.Text = "Created By:";
            // 
            // lbFees
            // 
            this.lbFees.AutoSize = true;
            this.lbFees.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFees.Location = new System.Drawing.Point(240, 138);
            this.lbFees.Name = "lbFees";
            this.lbFees.Size = new System.Drawing.Size(57, 19);
            this.lbFees.TabIndex = 7;
            this.lbFees.Text = "[===]";
            // 
            // lbApplicationFeesTitle
            // 
            this.lbApplicationFeesTitle.AutoSize = true;
            this.lbApplicationFeesTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationFeesTitle.Location = new System.Drawing.Point(55, 138);
            this.lbApplicationFeesTitle.Name = "lbApplicationFeesTitle";
            this.lbApplicationFeesTitle.Size = new System.Drawing.Size(149, 19);
            this.lbApplicationFeesTitle.TabIndex = 6;
            this.lbApplicationFeesTitle.Text = "Application Fees:";
            // 
            // lbLicenseClassTitle
            // 
            this.lbLicenseClassTitle.AutoSize = true;
            this.lbLicenseClassTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicenseClassTitle.Location = new System.Drawing.Point(55, 107);
            this.lbLicenseClassTitle.Name = "lbLicenseClassTitle";
            this.lbLicenseClassTitle.Size = new System.Drawing.Size(122, 19);
            this.lbLicenseClassTitle.TabIndex = 4;
            this.lbLicenseClassTitle.Text = "License Class:";
            // 
            // lbApplicationDate
            // 
            this.lbApplicationDate.AutoSize = true;
            this.lbApplicationDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationDate.Location = new System.Drawing.Point(240, 76);
            this.lbApplicationDate.Name = "lbApplicationDate";
            this.lbApplicationDate.Size = new System.Drawing.Size(99, 19);
            this.lbApplicationDate.TabIndex = 3;
            this.lbApplicationDate.Text = "dd/mm/yyyy";
            // 
            // lbApplicationDateTitle
            // 
            this.lbApplicationDateTitle.AutoSize = true;
            this.lbApplicationDateTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationDateTitle.Location = new System.Drawing.Point(55, 76);
            this.lbApplicationDateTitle.Name = "lbApplicationDateTitle";
            this.lbApplicationDateTitle.Size = new System.Drawing.Size(151, 19);
            this.lbApplicationDateTitle.TabIndex = 2;
            this.lbApplicationDateTitle.Text = "Application Date:";
            // 
            // lbDLApplication
            // 
            this.lbDLApplication.AutoSize = true;
            this.lbDLApplication.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDLApplication.Location = new System.Drawing.Point(240, 46);
            this.lbDLApplication.Name = "lbDLApplication";
            this.lbDLApplication.Size = new System.Drawing.Size(57, 19);
            this.lbDLApplication.TabIndex = 1;
            this.lbDLApplication.Text = "[===]";
            // 
            // lbDLApplicationTitle
            // 
            this.lbDLApplicationTitle.AutoSize = true;
            this.lbDLApplicationTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDLApplicationTitle.Location = new System.Drawing.Point(55, 46);
            this.lbDLApplicationTitle.Name = "lbDLApplicationTitle";
            this.lbDLApplicationTitle.Size = new System.Drawing.Size(162, 19);
            this.lbDLApplicationTitle.TabIndex = 0;
            this.lbDLApplicationTitle.Text = "D.L.Application ID:";
            // 
            // AddLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 453);
            this.Controls.Add(this.tcApplicatinoInfo);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddLocalDrivingLicenseApplication";
            this.Padding = new System.Windows.Forms.Padding(15, 0, 15, 10);
            this.Text = "-";
            this.Load += new System.EventHandler(this.NewLocalDrivingLicenseApplication_Load);
            this.tcApplicatinoInfo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TabControl tcApplicatinoInfo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ctrlPersonFinder ctrlPersonFinder1;
        private System.Windows.Forms.Label lbDLApplication;
        private System.Windows.Forms.Label lbDLApplicationTitle;
        private System.Windows.Forms.Label lbLicenseClassTitle;
        private System.Windows.Forms.Label lbApplicationDate;
        private System.Windows.Forms.Label lbApplicationDateTitle;
        private System.Windows.Forms.Label lbFees;
        private System.Windows.Forms.Label lbApplicationFeesTitle;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label lbCreatedByTitle;
        private System.Windows.Forms.ComboBox cbLicenseClass;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSave;
    }
}