namespace PresentationLayer
{
    partial class ManageUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUsers));
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvUsersTable = new System.Windows.Forms.DataGridView();
            this.cmsEditUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.lbFilterBy = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.cbFilterByIsActive = new System.Windows.Forms.ComboBox();
            this.cmsShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsAddPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsActive = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPhoneCall = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersTable)).BeginInit();
            this.cmsEditUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(266, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(432, 77);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Manage Users";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvUsersTable);
            this.panel1.Location = new System.Drawing.Point(12, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 310);
            this.panel1.TabIndex = 1;
            // 
            // dgvUsersTable
            // 
            this.dgvUsersTable.AllowUserToAddRows = false;
            this.dgvUsersTable.AllowUserToDeleteRows = false;
            this.dgvUsersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersTable.ContextMenuStrip = this.cmsEditUsers;
            this.dgvUsersTable.Location = new System.Drawing.Point(0, 0);
            this.dgvUsersTable.Name = "dgvUsersTable";
            this.dgvUsersTable.ReadOnly = true;
            this.dgvUsersTable.Size = new System.Drawing.Size(974, 310);
            this.dgvUsersTable.TabIndex = 0;
            // 
            // cmsEditUsers
            // 
            this.cmsEditUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsShowDetails,
            this.toolStripMenuItem1,
            this.cmsAddPerson,
            this.cmsEdit,
            this.cmsActive,
            this.toolStripMenuItem2,
            this.cmsSendEmail,
            this.cmsPhoneCall});
            this.cmsEditUsers.Name = "cmsEditPepole";
            this.cmsEditUsers.Size = new System.Drawing.Size(158, 244);
            this.cmsEditUsers.Opening += new System.ComponentModel.CancelEventHandler(this.cmsEditUsers_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(154, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(154, 6);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Location = new System.Drawing.Point(908, 103);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewUser.TabIndex = 0;
            this.btnAddNewUser.Text = "Add New User";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // lbFilterBy
            // 
            this.lbFilterBy.AutoSize = true;
            this.lbFilterBy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilterBy.Location = new System.Drawing.Point(12, 103);
            this.lbFilterBy.Name = "lbFilterBy";
            this.lbFilterBy.Size = new System.Drawing.Size(64, 16);
            this.lbFilterBy.TabIndex = 2;
            this.lbFilterBy.Text = "Filter By:";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.ItemHeight = 13;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "User ID",
            "Username",
            "Full Name",
            "Is Active"});
            this.cbFilterBy.Location = new System.Drawing.Point(82, 99);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(121, 21);
            this.cbFilterBy.TabIndex = 3;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(209, 99);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(151, 20);
            this.tbFilter.TabIndex = 4;
            this.tbFilter.Visible = false;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // cbFilterByIsActive
            // 
            this.cbFilterByIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterByIsActive.FormattingEnabled = true;
            this.cbFilterByIsActive.Items.AddRange(new object[] {
            "Active",
            "Not Active"});
            this.cbFilterByIsActive.Location = new System.Drawing.Point(209, 99);
            this.cbFilterByIsActive.Name = "cbFilterByIsActive";
            this.cbFilterByIsActive.Size = new System.Drawing.Size(130, 21);
            this.cbFilterByIsActive.TabIndex = 5;
            this.cbFilterByIsActive.Visible = false;
            this.cbFilterByIsActive.SelectedIndexChanged += new System.EventHandler(this.cbFilterByIsActive_SelectedIndexChanged);
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
            // cmsAddPerson
            // 
            this.cmsAddPerson.Image = ((System.Drawing.Image)(resources.GetObject("cmsAddPerson.Image")));
            this.cmsAddPerson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmsAddPerson.Name = "cmsAddPerson";
            this.cmsAddPerson.Size = new System.Drawing.Size(157, 38);
            this.cmsAddPerson.Text = "Add Person";
            // 
            // cmsEdit
            // 
            this.cmsEdit.Image = ((System.Drawing.Image)(resources.GetObject("cmsEdit.Image")));
            this.cmsEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmsEdit.Name = "cmsEdit";
            this.cmsEdit.Size = new System.Drawing.Size(157, 38);
            this.cmsEdit.Text = "Edit";
            // 
            // cmsActive
            // 
            this.cmsActive.Image = global::PresentationLayer.Properties.Resources.switch_off;
            this.cmsActive.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmsActive.Name = "cmsActive";
            this.cmsActive.Size = new System.Drawing.Size(157, 38);
            this.cmsActive.Text = "Deactivate";
            this.cmsActive.Click += new System.EventHandler(this.cmsDelete_Click);
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
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 450);
            this.Controls.Add(this.cbFilterByIsActive);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.lbFilterBy);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTitle);
            this.Name = "ManageUsers";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersTable)).EndInit();
            this.cmsEditUsers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvUsersTable;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Label lbFilterBy;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.ComboBox cbFilterByIsActive;
        private System.Windows.Forms.ContextMenuStrip cmsEditUsers;
        private System.Windows.Forms.ToolStripMenuItem cmsShowDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cmsAddPerson;
        private System.Windows.Forms.ToolStripMenuItem cmsEdit;
        private System.Windows.Forms.ToolStripMenuItem cmsActive;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cmsSendEmail;
        private System.Windows.Forms.ToolStripMenuItem cmsPhoneCall;
    }
}