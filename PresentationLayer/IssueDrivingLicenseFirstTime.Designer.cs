namespace PresentationLayer
{
    partial class IssueDrivingLicenseFirstTime
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
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.lbNotesTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.drivingLicenseApplicationInfo1 = new PresentationLayer.DrivingLicenseApplicationInfo();
            this.SuspendLayout();
            // 
            // tbNotes
            // 
            this.tbNotes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbNotes.Location = new System.Drawing.Point(10, 420);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(604, 138);
            this.tbNotes.TabIndex = 1;
            // 
            // lbNotesTitle
            // 
            this.lbNotesTitle.AutoSize = true;
            this.lbNotesTitle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotesTitle.Location = new System.Drawing.Point(13, 399);
            this.lbNotesTitle.Name = "lbNotesTitle";
            this.lbNotesTitle.Size = new System.Drawing.Size(51, 18);
            this.lbNotesTitle.TabIndex = 2;
            this.lbNotesTitle.Text = "Notes:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(529, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Issue License";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // drivingLicenseApplicationInfo1
            // 
            this.drivingLicenseApplicationInfo1.Location = new System.Drawing.Point(1, 13);
            this.drivingLicenseApplicationInfo1.Name = "drivingLicenseApplicationInfo1";
            this.drivingLicenseApplicationInfo1.Size = new System.Drawing.Size(627, 365);
            this.drivingLicenseApplicationInfo1.TabIndex = 0;
            // 
            // IssueDrivingLicenseFirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 568);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbNotesTitle);
            this.Controls.Add(this.tbNotes);
            this.Controls.Add(this.drivingLicenseApplicationInfo1);
            this.Name = "IssueDrivingLicenseFirstTime";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Issue Driving License For First Time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DrivingLicenseApplicationInfo drivingLicenseApplicationInfo1;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.Label lbNotesTitle;
        private System.Windows.Forms.Button button1;
    }
}