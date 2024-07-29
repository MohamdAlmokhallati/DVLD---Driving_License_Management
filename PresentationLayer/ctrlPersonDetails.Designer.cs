namespace PresentationLayer
{
    partial class ctrlPersonDetails
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lkEditPersonInfo = new System.Windows.Forms.LinkLabel();
            this.pbSelfPhoto = new System.Windows.Forms.PictureBox();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbDateOfBirth = new System.Windows.Forms.Label();
            this.lbCountryTitle = new System.Windows.Forms.Label();
            this.lbPhoneTitle = new System.Windows.Forms.Label();
            this.lbDateOfBirthTitle = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbNationalNo = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPersonID = new System.Windows.Forms.Label();
            this.lbAddressTitle = new System.Windows.Forms.Label();
            this.lbEmailTitle = new System.Windows.Forms.Label();
            this.lbGenderTitle = new System.Windows.Forms.Label();
            this.lbNationalNoTitle = new System.Windows.Forms.Label();
            this.lbNameTitle = new System.Windows.Forms.Label();
            this.lbPersonIDTitle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelfPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lkEditPersonInfo);
            this.groupBox1.Controls.Add(this.pbSelfPhoto);
            this.groupBox1.Controls.Add(this.lbCountry);
            this.groupBox1.Controls.Add(this.lbPhone);
            this.groupBox1.Controls.Add(this.lbDateOfBirth);
            this.groupBox1.Controls.Add(this.lbCountryTitle);
            this.groupBox1.Controls.Add(this.lbPhoneTitle);
            this.groupBox1.Controls.Add(this.lbDateOfBirthTitle);
            this.groupBox1.Controls.Add(this.lbAddress);
            this.groupBox1.Controls.Add(this.lbEmail);
            this.groupBox1.Controls.Add(this.lbGender);
            this.groupBox1.Controls.Add(this.lbNationalNo);
            this.groupBox1.Controls.Add(this.lbName);
            this.groupBox1.Controls.Add(this.lbPersonID);
            this.groupBox1.Controls.Add(this.lbAddressTitle);
            this.groupBox1.Controls.Add(this.lbEmailTitle);
            this.groupBox1.Controls.Add(this.lbGenderTitle);
            this.groupBox1.Controls.Add(this.lbNationalNoTitle);
            this.groupBox1.Controls.Add(this.lbNameTitle);
            this.groupBox1.Controls.Add(this.lbPersonIDTitle);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Person Information";
            // 
            // lkEditPersonInfo
            // 
            this.lkEditPersonInfo.AutoSize = true;
            this.lkEditPersonInfo.Location = new System.Drawing.Point(583, 22);
            this.lkEditPersonInfo.Name = "lkEditPersonInfo";
            this.lkEditPersonInfo.Size = new System.Drawing.Size(84, 13);
            this.lkEditPersonInfo.TabIndex = 19;
            this.lkEditPersonInfo.TabStop = true;
            this.lkEditPersonInfo.Text = "Edit Person Info";
            this.lkEditPersonInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkEditPersonInfo_LinkClicked);
            // 
            // pbSelfPhoto
            // 
//            this.pbSelfPhoto.ErrorImage = global::PresentationLayer.Properties.Resources.Male;
            this.pbSelfPhoto.Location = new System.Drawing.Point(547, 49);
            this.pbSelfPhoto.Name = "pbSelfPhoto";
            this.pbSelfPhoto.Size = new System.Drawing.Size(150, 150);
            this.pbSelfPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSelfPhoto.TabIndex = 18;
            this.pbSelfPhoto.TabStop = false;
            this.pbSelfPhoto.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pbSelfPhoto_LoadCompleted);
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountry.Location = new System.Drawing.Point(434, 238);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(25, 16);
            this.lbCountry.TabIndex = 17;
            this.lbCountry.Text = "???";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(434, 195);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(25, 16);
            this.lbPhone.TabIndex = 16;
            this.lbPhone.Text = "???";
            // 
            // lbDateOfBirth
            // 
            this.lbDateOfBirth.AutoSize = true;
            this.lbDateOfBirth.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateOfBirth.Location = new System.Drawing.Point(434, 152);
            this.lbDateOfBirth.Name = "lbDateOfBirth";
            this.lbDateOfBirth.Size = new System.Drawing.Size(25, 16);
            this.lbDateOfBirth.TabIndex = 15;
            this.lbDateOfBirth.Text = "???";
            // 
            // lbCountryTitle
            // 
            this.lbCountryTitle.AutoSize = true;
            this.lbCountryTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountryTitle.Location = new System.Drawing.Point(297, 235);
            this.lbCountryTitle.Name = "lbCountryTitle";
            this.lbCountryTitle.Size = new System.Drawing.Size(79, 19);
            this.lbCountryTitle.TabIndex = 14;
            this.lbCountryTitle.Text = "Country:";
            // 
            // lbPhoneTitle
            // 
            this.lbPhoneTitle.AutoSize = true;
            this.lbPhoneTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoneTitle.Location = new System.Drawing.Point(297, 192);
            this.lbPhoneTitle.Name = "lbPhoneTitle";
            this.lbPhoneTitle.Size = new System.Drawing.Size(66, 19);
            this.lbPhoneTitle.TabIndex = 13;
            this.lbPhoneTitle.Text = "Phone:";
            // 
            // lbDateOfBirthTitle
            // 
            this.lbDateOfBirthTitle.AutoSize = true;
            this.lbDateOfBirthTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateOfBirthTitle.Location = new System.Drawing.Point(297, 149);
            this.lbDateOfBirthTitle.Name = "lbDateOfBirthTitle";
            this.lbDateOfBirthTitle.Size = new System.Drawing.Size(122, 19);
            this.lbDateOfBirthTitle.TabIndex = 12;
            this.lbDateOfBirthTitle.Text = "Date Of Birth:";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(134, 235);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(25, 16);
            this.lbAddress.TabIndex = 11;
            this.lbAddress.Text = "???";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(134, 192);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(25, 16);
            this.lbEmail.TabIndex = 10;
            this.lbEmail.Text = "???";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(134, 149);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(25, 16);
            this.lbGender.TabIndex = 9;
            this.lbGender.Text = "???";
            // 
            // lbNationalNo
            // 
            this.lbNationalNo.AutoSize = true;
            this.lbNationalNo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNationalNo.Location = new System.Drawing.Point(134, 106);
            this.lbNationalNo.Name = "lbNationalNo";
            this.lbNationalNo.Size = new System.Drawing.Size(25, 16);
            this.lbNationalNo.TabIndex = 8;
            this.lbNationalNo.Text = "???";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbName.Location = new System.Drawing.Point(134, 63);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(25, 16);
            this.lbName.TabIndex = 7;
            this.lbName.Text = "???";
            // 
            // lbPersonID
            // 
            this.lbPersonID.AutoSize = true;
            this.lbPersonID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonID.Location = new System.Drawing.Point(134, 20);
            this.lbPersonID.Name = "lbPersonID";
            this.lbPersonID.Size = new System.Drawing.Size(25, 16);
            this.lbPersonID.TabIndex = 6;
            this.lbPersonID.Text = "???";
            // 
            // lbAddressTitle
            // 
            this.lbAddressTitle.AutoSize = true;
            this.lbAddressTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddressTitle.Location = new System.Drawing.Point(19, 235);
            this.lbAddressTitle.Name = "lbAddressTitle";
            this.lbAddressTitle.Size = new System.Drawing.Size(80, 19);
            this.lbAddressTitle.TabIndex = 5;
            this.lbAddressTitle.Text = "Address:";
            // 
            // lbEmailTitle
            // 
            this.lbEmailTitle.AutoSize = true;
            this.lbEmailTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmailTitle.Location = new System.Drawing.Point(19, 192);
            this.lbEmailTitle.Name = "lbEmailTitle";
            this.lbEmailTitle.Size = new System.Drawing.Size(60, 19);
            this.lbEmailTitle.TabIndex = 4;
            this.lbEmailTitle.Text = "Email:";
            // 
            // lbGenderTitle
            // 
            this.lbGenderTitle.AutoSize = true;
            this.lbGenderTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenderTitle.Location = new System.Drawing.Point(19, 149);
            this.lbGenderTitle.Name = "lbGenderTitle";
            this.lbGenderTitle.Size = new System.Drawing.Size(74, 19);
            this.lbGenderTitle.TabIndex = 3;
            this.lbGenderTitle.Text = "Gender:";
            // 
            // lbNationalNoTitle
            // 
            this.lbNationalNoTitle.AutoSize = true;
            this.lbNationalNoTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNationalNoTitle.Location = new System.Drawing.Point(19, 106);
            this.lbNationalNoTitle.Name = "lbNationalNoTitle";
            this.lbNationalNoTitle.Size = new System.Drawing.Size(111, 19);
            this.lbNationalNoTitle.TabIndex = 2;
            this.lbNationalNoTitle.Text = "National No:";
            // 
            // lbNameTitle
            // 
            this.lbNameTitle.AutoSize = true;
            this.lbNameTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameTitle.Location = new System.Drawing.Point(19, 63);
            this.lbNameTitle.Name = "lbNameTitle";
            this.lbNameTitle.Size = new System.Drawing.Size(62, 19);
            this.lbNameTitle.TabIndex = 1;
            this.lbNameTitle.Text = "Name:";
            // 
            // lbPersonIDTitle
            // 
            this.lbPersonIDTitle.AutoSize = true;
            this.lbPersonIDTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonIDTitle.Location = new System.Drawing.Point(19, 20);
            this.lbPersonIDTitle.Name = "lbPersonIDTitle";
            this.lbPersonIDTitle.Size = new System.Drawing.Size(95, 19);
            this.lbPersonIDTitle.TabIndex = 0;
            this.lbPersonIDTitle.Text = "Person ID:";
            // 
            // ctrlPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrlPersonDetails";
            this.Size = new System.Drawing.Size(712, 274);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelfPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbAddressTitle;
        private System.Windows.Forms.Label lbEmailTitle;
        private System.Windows.Forms.Label lbGenderTitle;
        private System.Windows.Forms.Label lbNationalNoTitle;
        private System.Windows.Forms.Label lbNameTitle;
        private System.Windows.Forms.Label lbPersonIDTitle;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbNationalNo;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPersonID;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbDateOfBirth;
        private System.Windows.Forms.Label lbCountryTitle;
        private System.Windows.Forms.Label lbPhoneTitle;
        private System.Windows.Forms.Label lbDateOfBirthTitle;
        private System.Windows.Forms.LinkLabel lkEditPersonInfo;
        private System.Windows.Forms.PictureBox pbSelfPhoto;
    }
}
