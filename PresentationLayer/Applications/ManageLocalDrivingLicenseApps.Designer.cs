namespace PresentationLayer
{
    partial class ManageLocalDrivingLicenseApps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageLocalDrivingLicenseApps));
            this.lbTitle = new System.Windows.Forms.Label();
            this.dgvLicense = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiEditApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCancelApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSechduleTests = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleVisionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleWrittenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleStreetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiIssueDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiShowPersonLicenseHistiory = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbStatusFiltes = new System.Windows.Forms.ComboBox();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.lbFilterByTitle = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicense)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbTitle.Location = new System.Drawing.Point(118, 34);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(764, 42);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Manage Local Driving License Applications";
            // 
            // dgvLicense
            // 
            this.dgvLicense.AllowUserToAddRows = false;
            this.dgvLicense.AllowUserToDeleteRows = false;
            this.dgvLicense.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLicense.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLicense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLicense.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLicense.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLicense.Location = new System.Drawing.Point(15, 171);
            this.dgvLicense.Name = "dgvLicense";
            this.dgvLicense.ReadOnly = true;
            this.dgvLicense.Size = new System.Drawing.Size(954, 280);
            this.dgvLicense.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator2,
            this.tsmiEditApplication,
            this.tsmiCancelApplication,
            this.toolStripSeparator3,
            this.tsmiSechduleTests,
            this.toolStripSeparator5,
            this.tsmiIssueDrivingLicense,
            this.toolStripSeparator4,
            this.tsmiShowLicense,
            this.toolStripSeparator6,
            this.tsmiShowPersonLicenseHistiory});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(262, 322);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(261, 38);
            this.toolStripMenuItem1.Text = "Show Application Detalis";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(258, 6);
            // 
            // tsmiEditApplication
            // 
            this.tsmiEditApplication.Image = ((System.Drawing.Image)(resources.GetObject("tsmiEditApplication.Image")));
            this.tsmiEditApplication.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiEditApplication.Name = "tsmiEditApplication";
            this.tsmiEditApplication.Size = new System.Drawing.Size(261, 38);
            this.tsmiEditApplication.Text = "Edit Application";
            // 
            // tsmiCancelApplication
            // 
            this.tsmiCancelApplication.Image = ((System.Drawing.Image)(resources.GetObject("tsmiCancelApplication.Image")));
            this.tsmiCancelApplication.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiCancelApplication.Name = "tsmiCancelApplication";
            this.tsmiCancelApplication.Size = new System.Drawing.Size(261, 38);
            this.tsmiCancelApplication.Text = "Cancel Application";
            this.tsmiCancelApplication.Click += new System.EventHandler(this.tsmiCancelApplication_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(258, 6);
            // 
            // tsmiSechduleTests
            // 
            this.tsmiSechduleTests.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleVisionTestToolStripMenuItem,
            this.scheduleWrittenTestToolStripMenuItem,
            this.scheduleStreetTestToolStripMenuItem});
            this.tsmiSechduleTests.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSechduleTests.Image")));
            this.tsmiSechduleTests.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSechduleTests.Name = "tsmiSechduleTests";
            this.tsmiSechduleTests.Size = new System.Drawing.Size(261, 38);
            this.tsmiSechduleTests.Text = "Sechdule Tests";
            // 
            // scheduleVisionTestToolStripMenuItem
            // 
            this.scheduleVisionTestToolStripMenuItem.Enabled = false;
            this.scheduleVisionTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("scheduleVisionTestToolStripMenuItem.Image")));
            this.scheduleVisionTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.scheduleVisionTestToolStripMenuItem.Name = "scheduleVisionTestToolStripMenuItem";
            this.scheduleVisionTestToolStripMenuItem.Size = new System.Drawing.Size(203, 38);
            this.scheduleVisionTestToolStripMenuItem.Text = "Schedule Vision Test";
            this.scheduleVisionTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleVisionTestToolStripMenuItem_Click);
            // 
            // scheduleWrittenTestToolStripMenuItem
            // 
            this.scheduleWrittenTestToolStripMenuItem.Enabled = false;
            this.scheduleWrittenTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("scheduleWrittenTestToolStripMenuItem.Image")));
            this.scheduleWrittenTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.scheduleWrittenTestToolStripMenuItem.Name = "scheduleWrittenTestToolStripMenuItem";
            this.scheduleWrittenTestToolStripMenuItem.Size = new System.Drawing.Size(203, 38);
            this.scheduleWrittenTestToolStripMenuItem.Text = "Schedule Written Test";
            this.scheduleWrittenTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleWrittenTestToolStripMenuItem_Click);
            // 
            // scheduleStreetTestToolStripMenuItem
            // 
            this.scheduleStreetTestToolStripMenuItem.Enabled = false;
            this.scheduleStreetTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("scheduleStreetTestToolStripMenuItem.Image")));
            this.scheduleStreetTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.scheduleStreetTestToolStripMenuItem.Name = "scheduleStreetTestToolStripMenuItem";
            this.scheduleStreetTestToolStripMenuItem.Size = new System.Drawing.Size(203, 38);
            this.scheduleStreetTestToolStripMenuItem.Text = "Schedule Street Test";
            this.scheduleStreetTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleStreetTestToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(258, 6);
            // 
            // tsmiIssueDrivingLicense
            // 
            this.tsmiIssueDrivingLicense.Image = ((System.Drawing.Image)(resources.GetObject("tsmiIssueDrivingLicense.Image")));
            this.tsmiIssueDrivingLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiIssueDrivingLicense.Name = "tsmiIssueDrivingLicense";
            this.tsmiIssueDrivingLicense.Size = new System.Drawing.Size(261, 38);
            this.tsmiIssueDrivingLicense.Text = "Issue Driving License (First Time)";
            this.tsmiIssueDrivingLicense.Click += new System.EventHandler(this.tsmiIssueDrivingLicense_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(258, 6);
            // 
            // tsmiShowLicense
            // 
            this.tsmiShowLicense.Enabled = false;
            this.tsmiShowLicense.Image = ((System.Drawing.Image)(resources.GetObject("tsmiShowLicense.Image")));
            this.tsmiShowLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiShowLicense.Name = "tsmiShowLicense";
            this.tsmiShowLicense.Size = new System.Drawing.Size(261, 38);
            this.tsmiShowLicense.Text = "Show License";
            this.tsmiShowLicense.Click += new System.EventHandler(this.tsmiShowLicense_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(258, 6);
            // 
            // tsmiShowPersonLicenseHistiory
            // 
            this.tsmiShowPersonLicenseHistiory.Image = ((System.Drawing.Image)(resources.GetObject("tsmiShowPersonLicenseHistiory.Image")));
            this.tsmiShowPersonLicenseHistiory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiShowPersonLicenseHistiory.Name = "tsmiShowPersonLicenseHistiory";
            this.tsmiShowPersonLicenseHistiory.Size = new System.Drawing.Size(261, 38);
            this.tsmiShowPersonLicenseHistiory.Text = "Show Person License Histiory";
            this.tsmiShowPersonLicenseHistiory.Click += new System.EventHandler(this.tsmiShowPersonLicenseHistiory_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbStatusFiltes);
            this.panel1.Controls.Add(this.tbFilter);
            this.panel1.Controls.Add(this.cbFilters);
            this.panel1.Controls.Add(this.lbFilterByTitle);
            this.panel1.Location = new System.Drawing.Point(15, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 30);
            this.panel1.TabIndex = 2;
            // 
            // cbStatusFiltes
            // 
            this.cbStatusFiltes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusFiltes.FormattingEnabled = true;
            this.cbStatusFiltes.Items.AddRange(new object[] {
            "New",
            "Cancelled",
            "Completed"});
            this.cbStatusFiltes.Location = new System.Drawing.Point(244, 6);
            this.cbStatusFiltes.Name = "cbStatusFiltes";
            this.cbStatusFiltes.Size = new System.Drawing.Size(137, 21);
            this.cbStatusFiltes.TabIndex = 3;
            this.cbStatusFiltes.Visible = false;
            this.cbStatusFiltes.SelectedIndexChanged += new System.EventHandler(this.cbStatusFiltes_SelectedIndexChanged);
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(244, 7);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(161, 20);
            this.tbFilter.TabIndex = 2;
            this.tbFilter.Visible = false;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            this.tbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilter_KeyPress);
            // 
            // cbFilters
            // 
            this.cbFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Items.AddRange(new object[] {
            "None",
            "LDL AppID",
            "National No",
            "Full Name",
            "Status"});
            this.cbFilters.Location = new System.Drawing.Point(77, 7);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(161, 21);
            this.cbFilters.TabIndex = 1;
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            // 
            // lbFilterByTitle
            // 
            this.lbFilterByTitle.AutoSize = true;
            this.lbFilterByTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilterByTitle.Location = new System.Drawing.Point(3, 9);
            this.lbFilterByTitle.Name = "lbFilterByTitle";
            this.lbFilterByTitle.Size = new System.Drawing.Size(64, 16);
            this.lbFilterByTitle.TabIndex = 0;
            this.lbFilterByTitle.Text = "Filter By:";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(891, 135);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 30);
            this.btnAddNew.TabIndex = 3;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // ManageLocalDrivingLicenseApps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvLicense);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageLocalDrivingLicenseApps";
            this.Padding = new System.Windows.Forms.Padding(15, 0, 15, 10);
            this.Text = "Manage Local Driving License Apps";
            this.Load += new System.EventHandler(this.ManageLocalDrivingLicenseApps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicense)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridView dgvLicense;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.Label lbFilterByTitle;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditApplication;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiCancelApplication;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiSechduleTests;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tsmiIssueDrivingLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowPersonLicenseHistiory;
        private System.Windows.Forms.ComboBox cbStatusFiltes;
        private System.Windows.Forms.ToolStripMenuItem scheduleVisionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleWrittenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleStreetTestToolStripMenuItem;
    }
}