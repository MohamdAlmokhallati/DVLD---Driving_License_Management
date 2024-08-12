namespace DVLD
{
    partial class LoginForm
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
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.lbWrungInputs = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.cbIsRememberMe = new System.Windows.Forms.CheckBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lbLoginTitle = new System.Windows.Forms.Label();
            this.gbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.lbWrungInputs);
            this.gbLogin.Controls.Add(this.lbPassword);
            this.gbLogin.Controls.Add(this.tbPassword);
            this.gbLogin.Controls.Add(this.lbUsername);
            this.gbLogin.Controls.Add(this.btnLogin);
            this.gbLogin.Controls.Add(this.cbIsRememberMe);
            this.gbLogin.Controls.Add(this.tbUsername);
            this.gbLogin.Controls.Add(this.lbLoginTitle);
            this.gbLogin.ForeColor = System.Drawing.Color.White;
            this.gbLogin.Location = new System.Drawing.Point(89, 69);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(442, 445);
            this.gbLogin.TabIndex = 0;
            this.gbLogin.TabStop = false;
            // 
            // lbWrungInputs
            // 
            this.lbWrungInputs.AutoSize = true;
            this.lbWrungInputs.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWrungInputs.ForeColor = System.Drawing.Color.Red;
            this.lbWrungInputs.Location = new System.Drawing.Point(114, 361);
            this.lbWrungInputs.Name = "lbWrungInputs";
            this.lbWrungInputs.Size = new System.Drawing.Size(182, 16);
            this.lbWrungInputs.TabIndex = 8;
            this.lbWrungInputs.Text = "Wrung Password or Username";
            this.lbWrungInputs.Visible = false;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("TheSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(112, 230);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(84, 27);
            this.lbPassword.TabIndex = 7;
            this.lbPassword.Text = "Password:";
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPassword.Location = new System.Drawing.Point(117, 260);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(206, 20);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("TheSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(112, 171);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(88, 27);
            this.lbUsername.TabIndex = 5;
            this.lbUsername.Text = "Username:";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(65)))), ((int)(((byte)(134)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("TheSans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(117, 309);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(206, 49);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnLogin_MouseUp);
            // 
            // cbIsRememberMe
            // 
            this.cbIsRememberMe.AutoSize = true;
            this.cbIsRememberMe.Checked = true;
            this.cbIsRememberMe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIsRememberMe.ForeColor = System.Drawing.Color.White;
            this.cbIsRememberMe.Location = new System.Drawing.Point(117, 286);
            this.cbIsRememberMe.Name = "cbIsRememberMe";
            this.cbIsRememberMe.Size = new System.Drawing.Size(94, 17);
            this.cbIsRememberMe.TabIndex = 4;
            this.cbIsRememberMe.Text = "Remember me";
            this.cbIsRememberMe.UseVisualStyleBackColor = true;
            // 
            // tbUsername
            // 
            this.tbUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbUsername.Location = new System.Drawing.Point(117, 201);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(206, 20);
            this.tbUsername.TabIndex = 1;
            // 
            // lbLoginTitle
            // 
            this.lbLoginTitle.AutoSize = true;
            this.lbLoginTitle.Font = new System.Drawing.Font("Yu Gothic UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginTitle.ForeColor = System.Drawing.Color.White;
            this.lbLoginTitle.Location = new System.Drawing.Point(72, 16);
            this.lbLoginTitle.Name = "lbLoginTitle";
            this.lbLoginTitle.Size = new System.Drawing.Size(297, 128);
            this.lbLoginTitle.TabIndex = 0;
            this.lbLoginTitle.Text = "Login";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(610, 587);
            this.Controls.Add(this.gbLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Label lbLoginTitle;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox cbIsRememberMe;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbWrungInputs;
    }
}

