namespace PresentationLayer
{
    partial class UserDetails
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
            this.ctrlPersonDetails1 = new PresentationLayer.ctrlPersonDetails();
            this.gbUserInfos = new System.Windows.Forms.GroupBox();
            this.lbUserID = new System.Windows.Forms.Label();
            this.lbUserIDTitle = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbUsernametitle = new System.Windows.Forms.Label();
            this.lbIsActive = new System.Windows.Forms.Label();
            this.lbIsActiveTitle = new System.Windows.Forms.Label();
            this.gbUserInfos.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlPersonDetails1
            // 
            this.ctrlPersonDetails1.Location = new System.Drawing.Point(43, 12);
            this.ctrlPersonDetails1.Name = "ctrlPersonDetails1";
            this.ctrlPersonDetails1.Size = new System.Drawing.Size(712, 274);
            this.ctrlPersonDetails1.TabIndex = 0;
            // 
            // gbUserInfos
            // 
            this.gbUserInfos.Controls.Add(this.lbIsActive);
            this.gbUserInfos.Controls.Add(this.lbIsActiveTitle);
            this.gbUserInfos.Controls.Add(this.lbUsername);
            this.gbUserInfos.Controls.Add(this.lbUsernametitle);
            this.gbUserInfos.Controls.Add(this.lbUserID);
            this.gbUserInfos.Controls.Add(this.lbUserIDTitle);
            this.gbUserInfos.Location = new System.Drawing.Point(43, 315);
            this.gbUserInfos.Name = "gbUserInfos";
            this.gbUserInfos.Size = new System.Drawing.Size(712, 115);
            this.gbUserInfos.TabIndex = 1;
            this.gbUserInfos.TabStop = false;
            this.gbUserInfos.Text = "Login User infos";
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserID.Location = new System.Drawing.Point(150, 54);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(25, 16);
            this.lbUserID.TabIndex = 13;
            this.lbUserID.Text = "???";
            // 
            // lbUserIDTitle
            // 
            this.lbUserIDTitle.AutoSize = true;
            this.lbUserIDTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserIDTitle.Location = new System.Drawing.Point(35, 54);
            this.lbUserIDTitle.Name = "lbUserIDTitle";
            this.lbUserIDTitle.Size = new System.Drawing.Size(76, 19);
            this.lbUserIDTitle.TabIndex = 12;
            this.lbUserIDTitle.Text = "User ID:";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(391, 54);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(25, 16);
            this.lbUsername.TabIndex = 15;
            this.lbUsername.Text = "???";
            // 
            // lbUsernametitle
            // 
            this.lbUsernametitle.AutoSize = true;
            this.lbUsernametitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsernametitle.Location = new System.Drawing.Point(276, 54);
            this.lbUsernametitle.Name = "lbUsernametitle";
            this.lbUsernametitle.Size = new System.Drawing.Size(97, 19);
            this.lbUsernametitle.TabIndex = 14;
            this.lbUsernametitle.Text = "Username:";
            // 
            // lbIsActive
            // 
            this.lbIsActive.AutoSize = true;
            this.lbIsActive.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIsActive.Location = new System.Drawing.Point(621, 54);
            this.lbIsActive.Name = "lbIsActive";
            this.lbIsActive.Size = new System.Drawing.Size(25, 16);
            this.lbIsActive.TabIndex = 17;
            this.lbIsActive.Text = "???";
            // 
            // lbIsActiveTitle
            // 
            this.lbIsActiveTitle.AutoSize = true;
            this.lbIsActiveTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIsActiveTitle.Location = new System.Drawing.Point(506, 54);
            this.lbIsActiveTitle.Name = "lbIsActiveTitle";
            this.lbIsActiveTitle.Size = new System.Drawing.Size(81, 19);
            this.lbIsActiveTitle.TabIndex = 16;
            this.lbIsActiveTitle.Text = "IsActive:";
            // 
            // UserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbUserInfos);
            this.Controls.Add(this.ctrlPersonDetails1);
            this.Name = "UserDetails";
            this.Text = "UserDetails";
            this.gbUserInfos.ResumeLayout(false);
            this.gbUserInfos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonDetails ctrlPersonDetails1;
        private System.Windows.Forms.GroupBox gbUserInfos;
        private System.Windows.Forms.Label lbIsActive;
        private System.Windows.Forms.Label lbIsActiveTitle;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbUsernametitle;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label lbUserIDTitle;
    }
}