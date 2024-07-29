namespace PresentationLayer
{
    partial class DrivingLicense
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
            this.ctrlDrivierLicense1 = new PresentationLayer.ctrlDrivingLicense();
            this.SuspendLayout();
            // 
            // ctrlDrivierLicense1
            // 
            this.ctrlDrivierLicense1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlDrivierLicense1.Location = new System.Drawing.Point(0, 0);
            this.ctrlDrivierLicense1.Name = "ctrlDrivierLicense1";
            this.ctrlDrivierLicense1.Padding = new System.Windows.Forms.Padding(15);
            this.ctrlDrivierLicense1.Size = new System.Drawing.Size(590, 240);
            this.ctrlDrivierLicense1.TabIndex = 0;
            // 
            // DrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 240);
            this.Controls.Add(this.ctrlDrivierLicense1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DrivingLicense";
            this.Text = "DrivingLicense";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlDrivingLicense ctrlDrivierLicense1;
    }
}