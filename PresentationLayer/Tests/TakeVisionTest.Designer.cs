namespace PresentationLayer
{
    partial class TakeVisionTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakeVisionTest));
            this.lbResult = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbFail = new System.Windows.Forms.RadioButton();
            this.rbPass = new System.Windows.Forms.RadioButton();
            this.lbNotes = new System.Windows.Forms.Label();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ctrlTestAppointmentInfos1 = new PresentationLayer.ctrlTestAppointmentInfos();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(12, 421);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(56, 18);
            this.lbResult.TabIndex = 1;
            this.lbResult.Text = "Result";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbFail);
            this.panel1.Controls.Add(this.rbPass);
            this.panel1.Location = new System.Drawing.Point(119, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(99, 22);
            this.panel1.TabIndex = 2;
            // 
            // rbFail
            // 
            this.rbFail.AutoSize = true;
            this.rbFail.Checked = true;
            this.rbFail.Location = new System.Drawing.Point(56, 3);
            this.rbFail.Name = "rbFail";
            this.rbFail.Size = new System.Drawing.Size(41, 17);
            this.rbFail.TabIndex = 1;
            this.rbFail.TabStop = true;
            this.rbFail.Text = "Fail";
            this.rbFail.UseVisualStyleBackColor = true;
            // 
            // rbPass
            // 
            this.rbPass.AutoSize = true;
            this.rbPass.Location = new System.Drawing.Point(3, 3);
            this.rbPass.Name = "rbPass";
            this.rbPass.Size = new System.Drawing.Size(47, 17);
            this.rbPass.TabIndex = 0;
            this.rbPass.Text = "Pass";
            this.rbPass.UseVisualStyleBackColor = true;
            // 
            // lbNotes
            // 
            this.lbNotes.AutoSize = true;
            this.lbNotes.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotes.Location = new System.Drawing.Point(12, 458);
            this.lbNotes.Name = "lbNotes";
            this.lbNotes.Size = new System.Drawing.Size(52, 18);
            this.lbNotes.TabIndex = 3;
            this.lbNotes.Text = "Notes";
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(12, 479);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(465, 93);
            this.tbNotes.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(374, 579);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(116, 140);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(236, 33);
            this.lbTitle.TabIndex = 7;
            this.lbTitle.Text = "Take Vision Test";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(175, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // ctrlTestAppointmentInfos1
            // 
            this.ctrlTestAppointmentInfos1.Location = new System.Drawing.Point(-2, 174);
            this.ctrlTestAppointmentInfos1.Name = "ctrlTestAppointmentInfos1";
            this.ctrlTestAppointmentInfos1.Padding = new System.Windows.Forms.Padding(15);
            this.ctrlTestAppointmentInfos1.Size = new System.Drawing.Size(495, 241);
            this.ctrlTestAppointmentInfos1.TabIndex = 8;
            // 
            // TakeVisionTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 638);
            this.Controls.Add(this.ctrlTestAppointmentInfos1);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbNotes);
            this.Controls.Add(this.lbNotes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TakeVisionTest";
            this.Text = "TakeVisionTest";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbFail;
        private System.Windows.Forms.RadioButton rbPass;
        private System.Windows.Forms.Label lbNotes;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTitle;
        private ctrlTestAppointmentInfos ctrlTestAppointmentInfos1;
    }
}