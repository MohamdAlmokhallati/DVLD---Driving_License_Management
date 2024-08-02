namespace PresentationLayer
{
    partial class DetainLicense
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
            this.lbTItle = new System.Windows.Forms.Label();
            this.gpDetainInfos = new System.Windows.Forms.GroupBox();
            this.lableEURImage = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.lbCreatedByTitle = new System.Windows.Forms.Label();
            this.lbLicenseID = new System.Windows.Forms.Label();
            this.lbLicenseIDTitle = new System.Windows.Forms.Label();
            this.lbFineFeesTitle = new System.Windows.Forms.Label();
            this.lbDetainDate = new System.Windows.Forms.Label();
            this.lbDetainDateTitle = new System.Windows.Forms.Label();
            this.lbDetainID = new System.Windows.Forms.Label();
            this.lbDetainIDTitle = new System.Windows.Forms.Label();
            this.btnDetain = new System.Windows.Forms.Button();
            this.ctrlLicensesFinder1 = new PresentationLayer.ctrlLicensesFinder();
            this.gpDetainInfos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTItle
            // 
            this.lbTItle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTItle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTItle.Location = new System.Drawing.Point(0, 0);
            this.lbTItle.Name = "lbTItle";
            this.lbTItle.Size = new System.Drawing.Size(600, 49);
            this.lbTItle.TabIndex = 0;
            this.lbTItle.Text = "Detain License";
            this.lbTItle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpDetainInfos
            // 
            this.gpDetainInfos.Controls.Add(this.lableEURImage);
            this.gpDetainInfos.Controls.Add(this.textBox1);
            this.gpDetainInfos.Controls.Add(this.lbCreatedBy);
            this.gpDetainInfos.Controls.Add(this.lbCreatedByTitle);
            this.gpDetainInfos.Controls.Add(this.lbLicenseID);
            this.gpDetainInfos.Controls.Add(this.lbLicenseIDTitle);
            this.gpDetainInfos.Controls.Add(this.lbFineFeesTitle);
            this.gpDetainInfos.Controls.Add(this.lbDetainDate);
            this.gpDetainInfos.Controls.Add(this.lbDetainDateTitle);
            this.gpDetainInfos.Controls.Add(this.lbDetainID);
            this.gpDetainInfos.Controls.Add(this.lbDetainIDTitle);
            this.gpDetainInfos.Location = new System.Drawing.Point(12, 349);
            this.gpDetainInfos.Name = "gpDetainInfos";
            this.gpDetainInfos.Size = new System.Drawing.Size(580, 109);
            this.gpDetainInfos.TabIndex = 2;
            this.gpDetainInfos.TabStop = false;
            this.gpDetainInfos.Text = "Detain Infos";
            // 
            // lableEURImage
            // 
            this.lableEURImage.AutoSize = true;
            this.lableEURImage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableEURImage.Location = new System.Drawing.Point(199, 77);
            this.lableEURImage.Name = "lableEURImage";
            this.lableEURImage.Size = new System.Drawing.Size(13, 13);
            this.lableEURImage.TabIndex = 13;
            this.lableEURImage.Text = "€";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
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
            this.lbFineFeesTitle.Location = new System.Drawing.Point(20, 75);
            this.lbFineFeesTitle.Name = "lbFineFeesTitle";
            this.lbFineFeesTitle.Size = new System.Drawing.Size(70, 16);
            this.lbFineFeesTitle.TabIndex = 4;
            this.lbFineFeesTitle.Text = "Fine Fees:";
            // 
            // lbDetainDate
            // 
            this.lbDetainDate.AutoSize = true;
            this.lbDetainDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetainDate.Location = new System.Drawing.Point(122, 53);
            this.lbDetainDate.Name = "lbDetainDate";
            this.lbDetainDate.Size = new System.Drawing.Size(30, 13);
            this.lbDetainDate.TabIndex = 3;
            this.lbDetainDate.Text = "[???]";
            // 
            // lbDetainDateTitle
            // 
            this.lbDetainDateTitle.AutoSize = true;
            this.lbDetainDateTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetainDateTitle.Location = new System.Drawing.Point(20, 50);
            this.lbDetainDateTitle.Name = "lbDetainDateTitle";
            this.lbDetainDateTitle.Size = new System.Drawing.Size(89, 16);
            this.lbDetainDateTitle.TabIndex = 2;
            this.lbDetainDateTitle.Text = "Detain Date:";
            // 
            // lbDetainID
            // 
            this.lbDetainID.AutoSize = true;
            this.lbDetainID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetainID.Location = new System.Drawing.Point(122, 28);
            this.lbDetainID.Name = "lbDetainID";
            this.lbDetainID.Size = new System.Drawing.Size(30, 13);
            this.lbDetainID.TabIndex = 1;
            this.lbDetainID.Text = "[???]";
            // 
            // lbDetainIDTitle
            // 
            this.lbDetainIDTitle.AutoSize = true;
            this.lbDetainIDTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetainIDTitle.Location = new System.Drawing.Point(20, 25);
            this.lbDetainIDTitle.Name = "lbDetainIDTitle";
            this.lbDetainIDTitle.Size = new System.Drawing.Size(72, 16);
            this.lbDetainIDTitle.TabIndex = 0;
            this.lbDetainIDTitle.Text = "Detain ID:";
            // 
            // btnDetain
            // 
            this.btnDetain.Location = new System.Drawing.Point(517, 464);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(75, 23);
            this.btnDetain.TabIndex = 3;
            this.btnDetain.Text = "Detain";
            this.btnDetain.UseVisualStyleBackColor = true;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // ctrlLicensesFinder1
            // 
            this.ctrlLicensesFinder1.license = null;
            this.ctrlLicensesFinder1.Location = new System.Drawing.Point(4, 39);
            this.ctrlLicensesFinder1.Name = "ctrlLicensesFinder1";
            this.ctrlLicensesFinder1.Size = new System.Drawing.Size(598, 304);
            this.ctrlLicensesFinder1.TabIndex = 4;
            this.ctrlLicensesFinder1.OnDrivingLicenseSelected += new System.Action<BusinessLayer.clsLicense>(this.ctrlLicensesFinder1_OnDrivingLicenseSelected_1);
            // 
            // DetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.ctrlLicensesFinder1);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.gpDetainInfos);
            this.Controls.Add(this.lbTItle);
            this.Name = "DetainLicense";
            this.Text = "Detain License";
            this.gpDetainInfos.ResumeLayout(false);
            this.gpDetainInfos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTItle;
        private System.Windows.Forms.GroupBox gpDetainInfos;
        private System.Windows.Forms.Label lbDetainIDTitle;
        private System.Windows.Forms.Button btnDetain;
        private System.Windows.Forms.Label lbDetainID;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label lbCreatedByTitle;
        private System.Windows.Forms.Label lbLicenseID;
        private System.Windows.Forms.Label lbLicenseIDTitle;
        private System.Windows.Forms.Label lbFineFeesTitle;
        private System.Windows.Forms.Label lbDetainDate;
        private System.Windows.Forms.Label lbDetainDateTitle;
        private System.Windows.Forms.Label lableEURImage;
        private System.Windows.Forms.TextBox textBox1;
        private ctrlLicensesFinder ctrlLicensesFinder1;
    }
}