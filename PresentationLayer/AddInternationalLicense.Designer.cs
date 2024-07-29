namespace PresentationLayer
{
    partial class AddInternationalLicense
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.ctrlLicenseFinder1 = new PresentationLayer.ctrlLicensesFinder();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(630, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "International License ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(543, 570);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ctrlLicenseFinder1
            // 
            this.ctrlLicenseFinder1.license = null;
            this.ctrlLicenseFinder1.Location = new System.Drawing.Point(12, 48);
            this.ctrlLicenseFinder1.Name = "ctrlLicenseFinder1";
            this.ctrlLicenseFinder1.Size = new System.Drawing.Size(598, 304);
            this.ctrlLicenseFinder1.TabIndex = 4;
            // 
            // AddInternationalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 605);
            this.Controls.Add(this.ctrlLicenseFinder1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Name = "AddInternationalLicense";
            this.Text = "Add International License";
            this.Load += new System.EventHandler(this.AddInternationalLicense_Load);
            this.ResumeLayout(false);

        }

        #endregion



        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private ctrlLicensesFinder ctrlLicenseFinder1;
    }
}