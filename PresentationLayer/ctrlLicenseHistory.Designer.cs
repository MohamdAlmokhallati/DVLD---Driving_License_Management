namespace PresentationLayer
{
    partial class ctrlLicenseHistory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpDriverLicense = new System.Windows.Forms.GroupBox();
            this.tcLicenses = new System.Windows.Forms.TabControl();
            this.tbLocal = new System.Windows.Forms.TabPage();
            this.tpInternational = new System.Windows.Forms.TabPage();
            this.dgvLocalLicenses = new System.Windows.Forms.DataGridView();
            this.dgvInternationalLicenses = new System.Windows.Forms.DataGridView();
            this.gpDriverLicense.SuspendLayout();
            this.tcLicenses.SuspendLayout();
            this.tbLocal.SuspendLayout();
            this.tpInternational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).BeginInit();
            this.SuspendLayout();
            // 
            // gpDriverLicense
            // 
            this.gpDriverLicense.Controls.Add(this.tcLicenses);
            this.gpDriverLicense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpDriverLicense.Location = new System.Drawing.Point(10, 10);
            this.gpDriverLicense.Name = "gpDriverLicense";
            this.gpDriverLicense.Padding = new System.Windows.Forms.Padding(5);
            this.gpDriverLicense.Size = new System.Drawing.Size(730, 260);
            this.gpDriverLicense.TabIndex = 0;
            this.gpDriverLicense.TabStop = false;
            this.gpDriverLicense.Text = "Driver License";
            // 
            // tcLicenses
            // 
            this.tcLicenses.Controls.Add(this.tbLocal);
            this.tcLicenses.Controls.Add(this.tpInternational);
            this.tcLicenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcLicenses.Location = new System.Drawing.Point(5, 18);
            this.tcLicenses.Margin = new System.Windows.Forms.Padding(10);
            this.tcLicenses.Name = "tcLicenses";
            this.tcLicenses.SelectedIndex = 0;
            this.tcLicenses.Size = new System.Drawing.Size(720, 237);
            this.tcLicenses.TabIndex = 0;
            // 
            // tbLocal
            // 
            this.tbLocal.Controls.Add(this.dgvLocalLicenses);
            this.tbLocal.Location = new System.Drawing.Point(4, 22);
            this.tbLocal.Name = "tbLocal";
            this.tbLocal.Padding = new System.Windows.Forms.Padding(3);
            this.tbLocal.Size = new System.Drawing.Size(712, 211);
            this.tbLocal.TabIndex = 0;
            this.tbLocal.Text = "Local";
            this.tbLocal.UseVisualStyleBackColor = true;
            // 
            // tpInternational
            // 
            this.tpInternational.Controls.Add(this.dgvInternationalLicenses);
            this.tpInternational.Location = new System.Drawing.Point(4, 22);
            this.tpInternational.Name = "tpInternational";
            this.tpInternational.Padding = new System.Windows.Forms.Padding(3);
            this.tpInternational.Size = new System.Drawing.Size(712, 211);
            this.tpInternational.TabIndex = 1;
            this.tpInternational.Text = "International";
            this.tpInternational.UseVisualStyleBackColor = true;
            // 
            // dgvLocalLicenses
            // 
            this.dgvLocalLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLocalLicenses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLocalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalLicenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLocalLicenses.Location = new System.Drawing.Point(3, 3);
            this.dgvLocalLicenses.Margin = new System.Windows.Forms.Padding(10);
            this.dgvLocalLicenses.Name = "dgvLocalLicenses";
            this.dgvLocalLicenses.Size = new System.Drawing.Size(706, 205);
            this.dgvLocalLicenses.TabIndex = 0;
            // 
            // dgvInternationalLicenses
            // 
            this.dgvInternationalLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInternationalLicenses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInternationalLicenses.CausesValidation = false;
            this.dgvInternationalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternationalLicenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInternationalLicenses.Location = new System.Drawing.Point(3, 3);
            this.dgvInternationalLicenses.Name = "dgvInternationalLicenses";
            this.dgvInternationalLicenses.Size = new System.Drawing.Size(706, 205);
            this.dgvInternationalLicenses.TabIndex = 0;
            // 
            // ctrlLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpDriverLicense);
            this.Name = "ctrlLicenseHistory";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(750, 280);
            this.gpDriverLicense.ResumeLayout(false);
            this.tcLicenses.ResumeLayout(false);
            this.tbLocal.ResumeLayout(false);
            this.tpInternational.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpDriverLicense;
        private System.Windows.Forms.TabControl tcLicenses;
        private System.Windows.Forms.TabPage tbLocal;
        private System.Windows.Forms.DataGridView dgvLocalLicenses;
        private System.Windows.Forms.TabPage tpInternational;
        private System.Windows.Forms.DataGridView dgvInternationalLicenses;
    }
}
