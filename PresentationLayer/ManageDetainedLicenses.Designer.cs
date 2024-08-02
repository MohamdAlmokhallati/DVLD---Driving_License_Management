namespace PresentationLayer
{
    partial class ManageDetainedLicenses
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
            this.dgvDetainedLicense = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicense)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(10, 10);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(797, 74);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Manage Detained Licenses";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDetainedLicense
            // 
            this.dgvDetainedLicense.AllowUserToAddRows = false;
            this.dgvDetainedLicense.AllowUserToDeleteRows = false;
            this.dgvDetainedLicense.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetainedLicense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetainedLicense.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDetainedLicense.Location = new System.Drawing.Point(10, 118);
            this.dgvDetainedLicense.Name = "dgvDetainedLicense";
            this.dgvDetainedLicense.ReadOnly = true;
            this.dgvDetainedLicense.Size = new System.Drawing.Size(797, 308);
            this.dgvDetainedLicense.TabIndex = 3;
            // 
            // ManageDetainedLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 436);
            this.Controls.Add(this.dgvDetainedLicense);
            this.Controls.Add(this.lbTitle);
            this.Name = "ManageDetainedLicenses";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Manage Detained Licenses";
            this.Load += new System.EventHandler(this.ManageDetainedLicenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicense)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridView dgvDetainedLicense;
    }
}