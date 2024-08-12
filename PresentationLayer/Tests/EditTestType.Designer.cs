namespace PresentationLayer
{
    partial class EditTestType
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
            this.lbTitleTitle = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lbDescriptionTitle = new System.Windows.Forms.Label();
            this.tbFees = new System.Windows.Forms.TextBox();
            this.lbFees = new System.Windows.Forms.Label();
            this.lbIDTitle = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbTitle.Location = new System.Drawing.Point(114, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(294, 35);
            this.lbTitle.TabIndex = 5;
            this.lbTitle.Text = "Manage Test Types";
            // 
            // lbTitleTitle
            // 
            this.lbTitleTitle.AutoSize = true;
            this.lbTitleTitle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleTitle.Location = new System.Drawing.Point(81, 105);
            this.lbTitleTitle.Name = "lbTitleTitle";
            this.lbTitleTitle.Size = new System.Drawing.Size(66, 25);
            this.lbTitleTitle.TabIndex = 6;
            this.lbTitleTitle.Text = "Title:";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(153, 110);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(376, 20);
            this.tbTitle.TabIndex = 7;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(153, 136);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(376, 81);
            this.tbDescription.TabIndex = 9;
            // 
            // lbDescriptionTitle
            // 
            this.lbDescriptionTitle.AutoSize = true;
            this.lbDescriptionTitle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescriptionTitle.Location = new System.Drawing.Point(8, 136);
            this.lbDescriptionTitle.Name = "lbDescriptionTitle";
            this.lbDescriptionTitle.Size = new System.Drawing.Size(139, 25);
            this.lbDescriptionTitle.TabIndex = 8;
            this.lbDescriptionTitle.Text = "Description:";
            // 
            // tbFees
            // 
            this.tbFees.Location = new System.Drawing.Point(153, 223);
            this.tbFees.Name = "tbFees";
            this.tbFees.Size = new System.Drawing.Size(376, 20);
            this.tbFees.TabIndex = 11;
            // 
            // lbFees
            // 
            this.lbFees.AutoSize = true;
            this.lbFees.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFees.Location = new System.Drawing.Point(81, 216);
            this.lbFees.Name = "lbFees";
            this.lbFees.Size = new System.Drawing.Size(67, 25);
            this.lbFees.TabIndex = 10;
            this.lbFees.Text = "Fees:";
            // 
            // lbIDTitle
            // 
            this.lbIDTitle.AutoSize = true;
            this.lbIDTitle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDTitle.Location = new System.Drawing.Point(101, 70);
            this.lbIDTitle.Name = "lbIDTitle";
            this.lbIDTitle.Size = new System.Drawing.Size(46, 25);
            this.lbIDTitle.TabIndex = 12;
            this.lbIDTitle.Text = "ID:";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(153, 70);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(52, 23);
            this.lbID.TabIndex = 13;
            this.lbID.Text = "===";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(287, 278);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(242, 41);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EditTestType
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 351);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbIDTitle);
            this.Controls.Add(this.tbFees);
            this.Controls.Add(this.lbFees);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lbDescriptionTitle);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.lbTitleTitle);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditTestType";
            this.Padding = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.Text = "Edit Test Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbTitleTitle;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lbDescriptionTitle;
        private System.Windows.Forms.TextBox tbFees;
        private System.Windows.Forms.Label lbFees;
        private System.Windows.Forms.Label lbIDTitle;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btnSave;
    }
}