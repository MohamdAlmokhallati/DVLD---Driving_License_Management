namespace PresentationLayer
{
    partial class ctrlTestInfos
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
            this.gpTestInfos = new System.Windows.Forms.GroupBox();
            this.lbTotalFees = new System.Windows.Forms.Label();
            this.lbTotalFeesTitle = new System.Windows.Forms.Label();
            this.lbTetsID = new System.Windows.Forms.Label();
            this.lbTetsIDTitle = new System.Windows.Forms.Label();
            this.lbFees = new System.Windows.Forms.Label();
            this.lbFeesTilte = new System.Windows.Forms.Label();
            this.gpTestInfos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpTestInfos
            // 
            this.gpTestInfos.Controls.Add(this.lbTotalFees);
            this.gpTestInfos.Controls.Add(this.lbTotalFeesTitle);
            this.gpTestInfos.Controls.Add(this.lbTetsID);
            this.gpTestInfos.Controls.Add(this.lbTetsIDTitle);
            this.gpTestInfos.Controls.Add(this.lbFees);
            this.gpTestInfos.Controls.Add(this.lbFeesTilte);
            this.gpTestInfos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpTestInfos.Location = new System.Drawing.Point(10, 10);
            this.gpTestInfos.Name = "gpTestInfos";
            this.gpTestInfos.Size = new System.Drawing.Size(440, 107);
            this.gpTestInfos.TabIndex = 0;
            this.gpTestInfos.TabStop = false;
            this.gpTestInfos.Text = "Test Infos";
            // 
            // lbTotalFees
            // 
            this.lbTotalFees.AutoSize = true;
            this.lbTotalFees.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalFees.Location = new System.Drawing.Point(132, 74);
            this.lbTotalFees.Name = "lbTotalFees";
            this.lbTotalFees.Size = new System.Drawing.Size(36, 19);
            this.lbTotalFees.TabIndex = 8;
            this.lbTotalFees.Text = "000";
            // 
            // lbTotalFeesTitle
            // 
            this.lbTotalFeesTitle.AutoSize = true;
            this.lbTotalFeesTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalFeesTitle.Location = new System.Drawing.Point(19, 74);
            this.lbTotalFeesTitle.Name = "lbTotalFeesTitle";
            this.lbTotalFeesTitle.Size = new System.Drawing.Size(58, 19);
            this.lbTotalFeesTitle.TabIndex = 7;
            this.lbTotalFeesTitle.Text = "Total:";
            // 
            // lbTetsID
            // 
            this.lbTetsID.AutoSize = true;
            this.lbTetsID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTetsID.Location = new System.Drawing.Point(132, 45);
            this.lbTetsID.Name = "lbTetsID";
            this.lbTetsID.Size = new System.Drawing.Size(36, 19);
            this.lbTetsID.TabIndex = 6;
            this.lbTetsID.Text = "000";
            // 
            // lbTetsIDTitle
            // 
            this.lbTetsIDTitle.AutoSize = true;
            this.lbTetsIDTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTetsIDTitle.Location = new System.Drawing.Point(19, 45);
            this.lbTetsIDTitle.Name = "lbTetsIDTitle";
            this.lbTetsIDTitle.Size = new System.Drawing.Size(70, 19);
            this.lbTetsIDTitle.TabIndex = 5;
            this.lbTetsIDTitle.Text = "TestID:";
            // 
            // lbFees
            // 
            this.lbFees.AutoSize = true;
            this.lbFees.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFees.Location = new System.Drawing.Point(132, 17);
            this.lbFees.Name = "lbFees";
            this.lbFees.Size = new System.Drawing.Size(36, 19);
            this.lbFees.TabIndex = 4;
            this.lbFees.Text = "000";
            // 
            // lbFeesTilte
            // 
            this.lbFeesTilte.AutoSize = true;
            this.lbFeesTilte.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFeesTilte.Location = new System.Drawing.Point(19, 16);
            this.lbFeesTilte.Name = "lbFeesTilte";
            this.lbFeesTilte.Size = new System.Drawing.Size(106, 19);
            this.lbFeesTilte.TabIndex = 3;
            this.lbFeesTilte.Text = "R.App.Fees:";
            // 
            // ctrlTestInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpTestInfos);
            this.Name = "ctrlTestInfos";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(460, 127);
            this.gpTestInfos.ResumeLayout(false);
            this.gpTestInfos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbTotalFeesTitle;
        private System.Windows.Forms.Label lbTetsIDTitle;
        private System.Windows.Forms.Label lbFeesTilte;
        public System.Windows.Forms.GroupBox gpTestInfos;
        public System.Windows.Forms.Label lbTotalFees;
        public System.Windows.Forms.Label lbTetsID;
        public System.Windows.Forms.Label lbFees;
    }
}
