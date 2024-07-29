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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lkSetImage = new System.Windows.Forms.LinkLabel();
            this.pbSelfPhoto = new System.Windows.Forms.PictureBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lbLast = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbThird = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbSecond = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countriesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelfPhoto)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
           
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource1)).BeginInit();
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
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.cbCountry);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lkSetImage);
            this.panel1.Controls.Add(this.pbSelfPhoto);
            this.panel1.Controls.Add(this.textBox10);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.lbLast);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.lbThird);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.lbSecond);
            this.panel1.Controls.Add(this.textBox1);
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
            this.panel2.TabIndex = 30;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(78, 1);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbFemale_CheckedChanged);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(0, 1);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(47, 17);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(444, 83);
            this.dateTimePicker1.MaxDate = new System.DateTime(2024, 6, 18, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2024, 6, 18, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(137, 20);
            this.dateTimePicker1.TabIndex = 29;
            this.dateTimePicker1.Value = new System.DateTime(2024, 6, 18, 0, 0, 0, 0);
            // 
            // cbCountry
            // 
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(444, 159);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(137, 21);
            this.cbCountry.TabIndex = 28;
            this.cbCountry.SelectedIndexChanged += new System.EventHandler(this.cbCountry_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(506, 319);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(425, 319);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lkSetImage
            // 
            this.lkSetImage.AutoSize = true;
            this.lkSetImage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkSetImage.Location = new System.Drawing.Point(633, 217);
            this.lkSetImage.Name = "lkSetImage";
            this.lkSetImage.Size = new System.Drawing.Size(81, 19);
            this.lkSetImage.TabIndex = 25;
            this.lkSetImage.TabStop = true;
            this.lkSetImage.Text = "Set Image";
            // 
            // pbSelfPhoto
            // 
            this.pbSelfPhoto.Image = global::DVLD.Properties.Resources.Male;
            this.pbSelfPhoto.Location = new System.Drawing.Point(603, 83);
            this.pbSelfPhoto.Name = "pbSelfPhoto";
            this.pbSelfPhoto.Size = new System.Drawing.Size(137, 131);
            this.pbSelfPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSelfPhoto.TabIndex = 23;
            this.pbSelfPhoto.TabStop = false;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(444, 118);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(137, 20);
            this.textBox10.TabIndex = 21;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(126, 197);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(455, 114);
            this.textBox8.TabIndex = 19;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(126, 159);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(137, 20);
            this.textBox7.TabIndex = 18;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(126, 80);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(137, 20);
            this.textBox5.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(603, 40);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(137, 20);
            this.textBox4.TabIndex = 15;
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(444, 40);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(137, 20);
            this.textBox3.TabIndex = 13;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(285, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 20);
            this.textBox2.TabIndex = 11;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 9;
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
            // dVLDDataSet
            // 

            // countriesBindingSource
            // 
            this.countriesBindingSource.DataMember = "Countries";
            // 
            // countriesTableAdapter
            // 

            // dVLDDataSet1
            // 

            // countriesBindingSource1
            // 
            this.countriesBindingSource1.DataMember = "Countries";

            // 
            // AddNewPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbPersonID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTitle);
            this.Name = "AddNewPerson";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelfPhoto)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource1)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.LinkLabel lkSetImage;
        private System.Windows.Forms.PictureBox pbSelfPhoto;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lbLast;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbThird;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbSecond;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;

        private System.Windows.Forms.BindingSource countriesBindingSource;
        

        private System.Windows.Forms.BindingSource countriesBindingSource1;

    }
}