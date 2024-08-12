namespace PresentationLayer
{
    partial class PersonDetails
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
            this.lbPersonInformation = new System.Windows.Forms.Label();
            this.ctrlPersonDetails1 = new PresentationLayer.ctrlPersonDetails();
            this.SuspendLayout();
            // 
            // lbPersonInformation
            // 
            this.lbPersonInformation.AutoSize = true;
            this.lbPersonInformation.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbPersonInformation.Location = new System.Drawing.Point(28, 27);
            this.lbPersonInformation.Name = "lbPersonInformation";
            this.lbPersonInformation.Size = new System.Drawing.Size(664, 77);
            this.lbPersonInformation.TabIndex = 3;
            this.lbPersonInformation.Text = "Person Information";
            // 
            // ctrlPersonDetails1
            // 
            this.ctrlPersonDetails1.Location = new System.Drawing.Point(12, 128);
            this.ctrlPersonDetails1.Name = "ctrlPersonDetails1";
            this.ctrlPersonDetails1.Size = new System.Drawing.Size(712, 281);
            this.ctrlPersonDetails1.TabIndex = 2;
            // 
            // PersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.lbPersonInformation);
            this.Controls.Add(this.ctrlPersonDetails1);
            this.Name = "PersonDetails";
            this.Text = "PersonDetails";
            this.Load += new System.EventHandler(this.PersonDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ctrlPersonDetails ctrlPersonDetails1;
        private System.Windows.Forms.Label lbPersonInformation;
    }
}