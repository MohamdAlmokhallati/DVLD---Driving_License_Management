namespace DVLD
{
    partial class ManagePepole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagePepole));
            this.btnTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.lbFilter = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbFileterInput = new System.Windows.Forms.TextBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.dgvPepoleTable = new System.Windows.Forms.DataGridView();
            this.cmsEditPepole = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsAddPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPhoneCall = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPepoleTable)).BeginInit();
            this.cmsEditPepole.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTitle
            // 
            this.btnTitle.AutoSize = true;
            this.btnTitle.Font = new System.Drawing.Font("Yu Gothic UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitle.Location = new System.Drawing.Point(248, 9);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(488, 86);
            this.btnTitle.TabIndex = 1;
            this.btnTitle.Text = "Manage Pepole";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(812, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National No.",
            "First Name",
            "Second Name",
            "Third Name",
            "Last Name",
            "Nationality",
            "Gender",
            "Phone",
            "Email"});
            this.cbFilter.Location = new System.Drawing.Point(42, 3);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(121, 21);
            this.cbFilter.TabIndex = 3;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // lbFilter
            // 
            this.lbFilter.AutoSize = true;
            this.lbFilter.Location = new System.Drawing.Point(4, 7);
            this.lbFilter.Name = "lbFilter";
            this.lbFilter.Size = new System.Drawing.Size(35, 13);
            this.lbFilter.TabIndex = 4;
            this.lbFilter.Text = "Filter:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbFileterInput);
            this.panel1.Controls.Add(this.lbFilter);
            this.panel1.Controls.Add(this.cbFilter);
            this.panel1.Location = new System.Drawing.Point(12, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 26);
            this.panel1.TabIndex = 5;
            // 
            // tbFileterInput
            // 
            this.tbFileterInput.Location = new System.Drawing.Point(169, 3);
            this.tbFileterInput.Name = "tbFileterInput";
            this.tbFileterInput.Size = new System.Drawing.Size(161, 20);
            this.tbFileterInput.TabIndex = 5;
            this.tbFileterInput.Visible = false;
            this.tbFileterInput.TextChanged += new System.EventHandler(this.tbFileterInput_TextChanged);
            this.tbFileterInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFileterInput_KeyPress);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(812, 114);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(75, 23);
            this.btnAddPerson.TabIndex = 6;
            this.btnAddPerson.Text = "Add Person";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // dgvPepoleTable
            // 
            this.dgvPepoleTable.AllowUserToAddRows = false;
            this.dgvPepoleTable.AllowUserToDeleteRows = false;
            this.dgvPepoleTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPepoleTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPepoleTable.ContextMenuStrip = this.cmsEditPepole;
            this.dgvPepoleTable.Location = new System.Drawing.Point(12, 143);
            this.dgvPepoleTable.Name = "dgvPepoleTable";
            this.dgvPepoleTable.ReadOnly = true;
            this.dgvPepoleTable.Size = new System.Drawing.Size(875, 266);
            this.dgvPepoleTable.TabIndex = 7;
            // 
            // cmsEditPepole
            // 
            this.cmsEditPepole.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsShowDetails,
            this.toolStripMenuItem1,
            this.cmsAddPerson,
            this.cmsEdit,
            this.cmsDelete,
            this.toolStripMenuItem2,
            this.cmsSendEmail,
            this.cmsPhoneCall});
            this.cmsEditPepole.Name = "cmsEditPepole";
            this.cmsEditPepole.Size = new System.Drawing.Size(158, 244);
            // 
            // cmsShowDetails
            // 
            this.cmsShowDetails.Image = ((System.Drawing.Image)(resources.GetObject("cmsShowDetails.Image")));
            this.cmsShowDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmsShowDetails.Name = "cmsShowDetails";
            this.cmsShowDetails.Size = new System.Drawing.Size(157, 38);
            this.cmsShowDetails.Text = "Show Details";
            this.cmsShowDetails.Click += new System.EventHandler(this.cmsShowDetails_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(154, 6);
            // 
            // cmsAddPerson
            // 
            this.cmsAddPerson.Image = ((System.Drawing.Image)(resources.GetObject("cmsAddPerson.Image")));
            this.cmsAddPerson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmsAddPerson.Name = "cmsAddPerson";
            this.cmsAddPerson.Size = new System.Drawing.Size(157, 38);
            this.cmsAddPerson.Text = "Add Person";
            this.cmsAddPerson.Click += new System.EventHandler(this.cmsAddPerson_Click);
            // 
            // cmsEdit
            // 
            this.cmsEdit.Image = ((System.Drawing.Image)(resources.GetObject("cmsEdit.Image")));
            this.cmsEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmsEdit.Name = "cmsEdit";
            this.cmsEdit.Size = new System.Drawing.Size(157, 38);
            this.cmsEdit.Text = "Edit";
            this.cmsEdit.Click += new System.EventHandler(this.cmsEdit_Click);
            // 
            // cmsDelete
            // 
            this.cmsDelete.Image = ((System.Drawing.Image)(resources.GetObject("cmsDelete.Image")));
            this.cmsDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmsDelete.Name = "cmsDelete";
            this.cmsDelete.Size = new System.Drawing.Size(157, 38);
            this.cmsDelete.Text = "Delete";
            this.cmsDelete.Click += new System.EventHandler(this.cmsDelete_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(154, 6);
            // 
            // cmsSendEmail
            // 
            this.cmsSendEmail.Image = ((System.Drawing.Image)(resources.GetObject("cmsSendEmail.Image")));
            this.cmsSendEmail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmsSendEmail.Name = "cmsSendEmail";
            this.cmsSendEmail.Size = new System.Drawing.Size(157, 38);
            this.cmsSendEmail.Text = "Send Email";
            this.cmsSendEmail.Click += new System.EventHandler(this.cmsSendEmail_Click);
            // 
            // cmsPhoneCall
            // 
            this.cmsPhoneCall.Image = ((System.Drawing.Image)(resources.GetObject("cmsPhoneCall.Image")));
            this.cmsPhoneCall.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmsPhoneCall.Name = "cmsPhoneCall";
            this.cmsPhoneCall.Size = new System.Drawing.Size(157, 38);
            this.cmsPhoneCall.Text = "Phone Call";
            this.cmsPhoneCall.Click += new System.EventHandler(this.cmsPhoneCall_Click);
            // 
            // ManagePepole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 450);
            this.Controls.Add(this.dgvPepoleTable);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnTitle);
            this.Name = "ManagePepole";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ManagePepole_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPepoleTable)).EndInit();
            this.cmsEditPepole.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label btnTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label lbFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.TextBox tbFileterInput;
        private System.Windows.Forms.DataGridView dgvPepoleTable;
        private System.Windows.Forms.ContextMenuStrip cmsEditPepole;
        private System.Windows.Forms.ToolStripMenuItem cmsShowDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cmsAddPerson;
        private System.Windows.Forms.ToolStripMenuItem cmsEdit;
        private System.Windows.Forms.ToolStripMenuItem cmsDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cmsSendEmail;
        private System.Windows.Forms.ToolStripMenuItem cmsPhoneCall;
    }
}