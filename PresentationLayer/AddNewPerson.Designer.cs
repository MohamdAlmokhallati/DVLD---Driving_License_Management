

namespace DVLD
{
    partial class AddNewPerson
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lkSetImage = new System.Windows.Forms.LinkLabel();
            this.pbSelfPhoto = new System.Windows.Forms.PictureBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbNationalNo = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lbLast = new System.Windows.Forms.Label();
            this.tbThirdName = new System.Windows.Forms.TextBox();
            this.lbThird = new System.Windows.Forms.Label();
            this.tbSecondName = new System.Windows.Forms.TextBox();
            this.lbSecond = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbDateOfBirth = new System.Windows.Forms.Label();
            this.lbGendor = new System.Windows.Forms.Label();
            this.lbNationalNo = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPersonID = new System.Windows.Forms.Label();
            this.ofdSelfPhoto = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lkRemovePhoto = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelfPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(198, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(392, 65);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Add New Person";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lkRemovePhoto);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dtpDateOfBirth);
            this.panel1.Controls.Add(this.cbCountry);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lkSetImage);
            this.panel1.Controls.Add(this.pbSelfPhoto);
            this.panel1.Controls.Add(this.tbPhone);
            this.panel1.Controls.Add(this.tbAddress);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.tbNationalNo);
            this.panel1.Controls.Add(this.tbLastName);
            this.panel1.Controls.Add(this.lbLast);
            this.panel1.Controls.Add(this.tbThirdName);
            this.panel1.Controls.Add(this.lbThird);
            this.panel1.Controls.Add(this.tbSecondName);
            this.panel1.Controls.Add(this.lbSecond);
            this.panel1.Controls.Add(this.tbFirstName);
            this.panel1.Controls.Add(this.lbFirstName);
            this.panel1.Controls.Add(this.lbCountry);
            this.panel1.Controls.Add(this.lbPhone);
            this.panel1.Controls.Add(this.lbAddress);
            this.panel1.Controls.Add(this.lbEmail);
            this.panel1.Controls.Add(this.lbDateOfBirth);
            this.panel1.Controls.Add(this.lbGendor);
            this.panel1.Controls.Add(this.lbNationalNo);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Location = new System.Drawing.Point(12, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 345);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbFemale);
            this.panel2.Controls.Add(this.rbMale);
            this.panel2.Location = new System.Drawing.Point(126, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(137, 19);
            this.panel2.TabIndex = 18;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(78, 1);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 19;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbFemale_CheckedChanged);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(0, 1);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(47, 17);
            this.rbMale.TabIndex = 18;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CustomFormat = "";
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(444, 83);
            this.dtpDateOfBirth.MaxDate = new System.DateTime(2024, 6, 18, 0, 0, 0, 0);
            this.dtpDateOfBirth.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(137, 20);
            this.dtpDateOfBirth.TabIndex = 17;
            this.dtpDateOfBirth.Value = new System.DateTime(2024, 6, 18, 0, 0, 0, 0);
            // 
            // cbCountry
            // 
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.ItemHeight = 13;
            this.cbCountry.Location = new System.Drawing.Point(444, 159);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(137, 21);
            this.cbCountry.TabIndex = 22;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(506, 319);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(425, 319);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lkSetImage
            // 
            this.lkSetImage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkSetImage.Location = new System.Drawing.Point(603, 217);
            this.lkSetImage.Name = "lkSetImage";
            this.lkSetImage.Size = new System.Drawing.Size(137, 19);
            this.lkSetImage.TabIndex = 24;
            this.lkSetImage.TabStop = true;
            this.lkSetImage.Text = "Set Image";
            this.lkSetImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lkSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkSetImage_LinkClicked);
            // 
            // pbSelfPhoto
            // 
            this.pbSelfPhoto.Image = global::PresentationLayer.Properties.Resources.Male;
            this.pbSelfPhoto.Location = new System.Drawing.Point(603, 83);
            this.pbSelfPhoto.Name = "pbSelfPhoto";
            this.pbSelfPhoto.Size = new System.Drawing.Size(137, 131);
            this.pbSelfPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSelfPhoto.TabIndex = 23;
            this.pbSelfPhoto.TabStop = false;
            this.pbSelfPhoto.Click += new System.EventHandler(this.pbSelfPhoto_Click);
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(444, 118);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(137, 20);
            this.tbPhone.TabIndex = 20;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(126, 197);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(455, 114);
            this.tbAddress.TabIndex = 23;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(126, 159);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(137, 20);
            this.tbEmail.TabIndex = 21;
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textBox7_Validating);
            // 
            // tbNationalNo
            // 
            this.tbNationalNo.Location = new System.Drawing.Point(126, 80);
            this.tbNationalNo.Name = "tbNationalNo";
            this.tbNationalNo.Size = new System.Drawing.Size(137, 20);
            this.tbNationalNo.TabIndex = 16;
            this.tbNationalNo.Validating += new System.ComponentModel.CancelEventHandler(this.tbNationalNo_Validating);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(603, 40);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(137, 20);
            this.tbLastName.TabIndex = 15;
            // 
            // lbLast
            // 
            this.lbLast.AutoSize = true;
            this.lbLast.Location = new System.Drawing.Point(657, 24);
            this.lbLast.Name = "lbLast";
            this.lbLast.Size = new System.Drawing.Size(27, 13);
            this.lbLast.TabIndex = 14;
            this.lbLast.Text = "Last";
            // 
            // tbThirdName
            // 
            this.tbThirdName.Location = new System.Drawing.Point(444, 40);
            this.tbThirdName.Name = "tbThirdName";
            this.tbThirdName.Size = new System.Drawing.Size(137, 20);
            this.tbThirdName.TabIndex = 13;
            // 
            // lbThird
            // 
            this.lbThird.AutoSize = true;
            this.lbThird.Location = new System.Drawing.Point(498, 24);
            this.lbThird.Name = "lbThird";
            this.lbThird.Size = new System.Drawing.Size(31, 13);
            this.lbThird.TabIndex = 12;
            this.lbThird.Text = "Third";
            // 
            // tbSecondName
            // 
            this.tbSecondName.Location = new System.Drawing.Point(285, 40);
            this.tbSecondName.Name = "tbSecondName";
            this.tbSecondName.Size = new System.Drawing.Size(137, 20);
            this.tbSecondName.TabIndex = 11;
            // 
            // lbSecond
            // 
            this.lbSecond.AutoSize = true;
            this.lbSecond.Location = new System.Drawing.Point(339, 24);
            this.lbSecond.Name = "lbSecond";
            this.lbSecond.Size = new System.Drawing.Size(42, 13);
            this.lbSecond.TabIndex = 10;
            this.lbSecond.Text = "Second";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(126, 40);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(137, 20);
            this.tbFirstName.TabIndex = 9;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(180, 24);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(28, 13);
            this.lbFirstName.TabIndex = 8;
            this.lbFirstName.Text = "First";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbCountry.Location = new System.Drawing.Point(281, 157);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(79, 19);
            this.lbCountry.TabIndex = 7;
            this.lbCountry.Text = "Country:";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(280, 119);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(66, 19);
            this.lbPhone.TabIndex = 6;
            this.lbPhone.Text = "Phone:";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(3, 195);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(80, 19);
            this.lbAddress.TabIndex = 5;
            this.lbAddress.Text = "Address:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(3, 157);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(60, 19);
            this.lbEmail.TabIndex = 4;
            this.lbEmail.Text = "Email:";
            // 
            // lbDateOfBirth
            // 
            this.lbDateOfBirth.AutoSize = true;
            this.lbDateOfBirth.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateOfBirth.Location = new System.Drawing.Point(280, 81);
            this.lbDateOfBirth.Name = "lbDateOfBirth";
            this.lbDateOfBirth.Size = new System.Drawing.Size(122, 19);
            this.lbDateOfBirth.TabIndex = 3;
            this.lbDateOfBirth.Text = "Date Of Birth:";
            // 
            // lbGendor
            // 
            this.lbGendor.AutoSize = true;
            this.lbGendor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGendor.Location = new System.Drawing.Point(3, 119);
            this.lbGendor.Name = "lbGendor";
            this.lbGendor.Size = new System.Drawing.Size(74, 19);
            this.lbGendor.TabIndex = 2;
            this.lbGendor.Text = "Gendor:";
            // 
            // lbNationalNo
            // 
            this.lbNationalNo.AutoSize = true;
            this.lbNationalNo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNationalNo.Location = new System.Drawing.Point(3, 81);
            this.lbNationalNo.Name = "lbNationalNo";
            this.lbNationalNo.Size = new System.Drawing.Size(111, 19);
            this.lbNationalNo.TabIndex = 1;
            this.lbNationalNo.Text = "National No:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(3, 43);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(62, 19);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name:";
            // 
            // lbPersonID
            // 
            this.lbPersonID.AutoSize = true;
            this.lbPersonID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonID.Location = new System.Drawing.Point(12, 68);
            this.lbPersonID.Name = "lbPersonID";
            this.lbPersonID.Size = new System.Drawing.Size(85, 19);
            this.lbPersonID.TabIndex = 2;
            this.lbPersonID.Text = "Person ID:";
            // 
            // ofdSelfPhoto
            // 
            this.ofdSelfPhoto.FileName = "openFileDialog1";
            this.ofdSelfPhoto.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            this.ofdSelfPhoto.Title = "Select a Photo";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lkRemovePhoto
            // 
            this.lkRemovePhoto.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lkRemovePhoto.Location = new System.Drawing.Point(603, 247);
            this.lkRemovePhoto.Name = "lkRemovePhoto";
            this.lkRemovePhoto.Size = new System.Drawing.Size(137, 23);
            this.lkRemovePhoto.TabIndex = 3;
            this.lkRemovePhoto.TabStop = true;
            this.lkRemovePhoto.Text = "Remove Photo";
            this.lkRemovePhoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lkRemovePhoto.Visible = false;
            this.lkRemovePhoto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkRemovePhoto_LinkClicked);
            // 
            // AddNewPerson
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbPersonID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTitle);
            this.Name = "AddNewPerson";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AddNewPerson_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelfPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbDateOfBirth;
        private System.Windows.Forms.Label lbGendor;
        private System.Windows.Forms.Label lbNationalNo;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPersonID;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.LinkLabel lkSetImage;
        private System.Windows.Forms.PictureBox pbSelfPhoto;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbNationalNo;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lbLast;
        private System.Windows.Forms.TextBox tbThirdName;
        private System.Windows.Forms.Label lbThird;
        private System.Windows.Forms.TextBox tbSecondName;
        private System.Windows.Forms.Label lbSecond;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.OpenFileDialog ofdSelfPhoto;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.LinkLabel lkRemovePhoto;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}