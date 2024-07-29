namespace PresentationLayer
{
    partial class LicenseHistory
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
            this.ctrlLicenseHistory1 = new PresentationLayer.ctrlLicenseHistory();
            this.ctrlPersonDetails1 = new PresentationLayer.ctrlPersonDetails();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(714, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "License History";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrlLicenseHistory1
            // 
            this.ctrlLicenseHistory1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctrlLicenseHistory1.Location = new System.Drawing.Point(10, 326);
            this.ctrlLicenseHistory1.Name = "ctrlLicenseHistory1";
            this.ctrlLicenseHistory1.Padding = new System.Windows.Forms.Padding(10);
            this.ctrlLicenseHistory1.Size = new System.Drawing.Size(714, 170);
            this.ctrlLicenseHistory1.TabIndex = 2;
            // 
            // ctrlPersonDetails1
            // 
            this.ctrlPersonDetails1.Location = new System.Drawing.Point(14, 46);
            this.ctrlPersonDetails1.Name = "ctrlPersonDetails1";
            this.ctrlPersonDetails1.Size = new System.Drawing.Size(717, 274);
            this.ctrlPersonDetails1.TabIndex = 1;
            // 
            // LicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 506);
            this.Controls.Add(this.ctrlLicenseHistory1);
            this.Controls.Add(this.ctrlPersonDetails1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LicenseHistory";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "License History";
            this.Load += new System.EventHandler(this.LicenseHistory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ctrlPersonDetails ctrlPersonDetails1;
        private ctrlLicenseHistory ctrlLicenseHistory1;
    }
}