namespace PresentationLayer
{
    partial class ChangePassword
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
            this.components = new System.ComponentModel.Container();
            this.lbChangePasswordTitle = new System.Windows.Forms.Label();
            this.lbOldPassword = new System.Windows.Forms.Label();
            this.tbOldPassword = new System.Windows.Forms.TextBox();
            this.lbNewPassword = new System.Windows.Forms.Label();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.lbConfirmNewPassword = new System.Windows.Forms.Label();
            this.tbConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbWrungInputs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbChangePasswordTitle
            // 
            this.lbChangePasswordTitle.AutoSize = true;
            this.lbChangePasswordTitle.Font = new System.Drawing.Font("Yu Gothic UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChangePasswordTitle.ForeColor = System.Drawing.Color.White;
            this.lbChangePasswordTitle.Location = new System.Drawing.Point(30, 9);
            this.lbChangePasswordTitle.Name = "lbChangePasswordTitle";
            this.lbChangePasswordTitle.Size = new System.Drawing.Size(318, 50);
            this.lbChangePasswordTitle.TabIndex = 1;
            this.lbChangePasswordTitle.Text = "Change Password";
            // 
            // lbOldPassword
            // 
            this.lbOldPassword.AutoSize = true;
            this.lbOldPassword.Font = new System.Drawing.Font("TheSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOldPassword.ForeColor = System.Drawing.Color.White;
            this.lbOldPassword.Location = new System.Drawing.Point(77, 80);
            this.lbOldPassword.Name = "lbOldPassword";
            this.lbOldPassword.Size = new System.Drawing.Size(112, 27);
            this.lbOldPassword.TabIndex = 7;
            this.lbOldPassword.Text = "Old Password:";
            // 
            // tbOldPassword
            // 
            this.tbOldPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbOldPassword.Location = new System.Drawing.Point(82, 110);
            this.tbOldPassword.Name = "tbOldPassword";
            this.tbOldPassword.PasswordChar = '*';
            this.tbOldPassword.Size = new System.Drawing.Size(206, 20);
            this.tbOldPassword.TabIndex = 6;
            this.tbOldPassword.UseSystemPasswordChar = true;
            this.tbOldPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbOldPassword_Validating);
            // 
            // lbNewPassword
            // 
            this.lbNewPassword.AutoSize = true;
            this.lbNewPassword.Font = new System.Drawing.Font("TheSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewPassword.ForeColor = System.Drawing.Color.White;
            this.lbNewPassword.Location = new System.Drawing.Point(77, 133);
            this.lbNewPassword.Name = "lbNewPassword";
            this.lbNewPassword.Size = new System.Drawing.Size(120, 27);
            this.lbNewPassword.TabIndex = 9;
            this.lbNewPassword.Text = "New Password:";
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbNewPassword.Location = new System.Drawing.Point(82, 163);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.PasswordChar = '*';
            this.tbNewPassword.Size = new System.Drawing.Size(206, 20);
            this.tbNewPassword.TabIndex = 8;
            this.tbNewPassword.UseSystemPasswordChar = true;
            // 
            // lbConfirmNewPassword
            // 
            this.lbConfirmNewPassword.AutoSize = true;
            this.lbConfirmNewPassword.Font = new System.Drawing.Font("TheSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmNewPassword.ForeColor = System.Drawing.Color.White;
            this.lbConfirmNewPassword.Location = new System.Drawing.Point(77, 186);
            this.lbConfirmNewPassword.Name = "lbConfirmNewPassword";
            this.lbConfirmNewPassword.Size = new System.Drawing.Size(180, 27);
            this.lbConfirmNewPassword.TabIndex = 11;
            this.lbConfirmNewPassword.Text = "Confirm new password:";
            // 
            // tbConfirmNewPassword
            // 
            this.tbConfirmNewPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbConfirmNewPassword.Location = new System.Drawing.Point(82, 216);
            this.tbConfirmNewPassword.Name = "tbConfirmNewPassword";
            this.tbConfirmNewPassword.PasswordChar = '*';
            this.tbConfirmNewPassword.Size = new System.Drawing.Size(206, 20);
            this.tbConfirmNewPassword.TabIndex = 10;
            this.tbConfirmNewPassword.UseSystemPasswordChar = true;
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(65)))), ((int)(((byte)(134)))));
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("TheSans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Location = new System.Drawing.Point(82, 256);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(206, 49);
            this.btnChange.TabIndex = 12;
            this.btnChange.Text = "CHANGE";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbWrungInputs
            // 
            this.lbWrungInputs.AutoSize = true;
            this.lbWrungInputs.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWrungInputs.ForeColor = System.Drawing.Color.Red;
            this.lbWrungInputs.Location = new System.Drawing.Point(79, 319);
            this.lbWrungInputs.Name = "lbWrungInputs";
            this.lbWrungInputs.Size = new System.Drawing.Size(139, 16);
            this.lbWrungInputs.TabIndex = 13;
            this.lbWrungInputs.Text = "Passwords don\'t match";
            this.lbWrungInputs.Visible = false;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.lbWrungInputs);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lbConfirmNewPassword);
            this.Controls.Add(this.tbConfirmNewPassword);
            this.Controls.Add(this.lbNewPassword);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.lbOldPassword);
            this.Controls.Add(this.tbOldPassword);
            this.Controls.Add(this.lbChangePasswordTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbChangePasswordTitle;
        private System.Windows.Forms.Label lbOldPassword;
        private System.Windows.Forms.TextBox tbOldPassword;
        private System.Windows.Forms.Label lbNewPassword;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Label lbConfirmNewPassword;
        private System.Windows.Forms.TextBox tbConfirmNewPassword;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbWrungInputs;
    }
}