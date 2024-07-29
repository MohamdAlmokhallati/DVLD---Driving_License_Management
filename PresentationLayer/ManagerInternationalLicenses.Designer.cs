namespace PresentationLayer
{
    partial class ManagerInternationalLicenses
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.dgvApplicationsTable = new System.Windows.Forms.DataGridView();
            this.btnAddNewApplication = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbStatusFiltes = new System.Windows.Forms.ComboBox();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.lbFilterByTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationsTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(10, 10);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(780, 39);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "International Licenses";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvApplicationsTable
            // 
            this.dgvApplicationsTable.AllowUserToAddRows = false;
            this.dgvApplicationsTable.AllowUserToDeleteRows = false;
            this.dgvApplicationsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvApplicationsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvApplicationsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplicationsTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvApplicationsTable.Location = new System.Drawing.Point(10, 116);
            this.dgvApplicationsTable.Name = "dgvApplicationsTable";
            this.dgvApplicationsTable.ReadOnly = true;
            this.dgvApplicationsTable.Size = new System.Drawing.Size(780, 274);
            this.dgvApplicationsTable.TabIndex = 1;
            // 
            // btnAddNewApplication
            // 
            this.btnAddNewApplication.Location = new System.Drawing.Point(692, 81);
            this.btnAddNewApplication.Name = "btnAddNewApplication";
            this.btnAddNewApplication.Size = new System.Drawing.Size(98, 29);
            this.btnAddNewApplication.TabIndex = 2;
            this.btnAddNewApplication.Text = "Issue New";
            this.btnAddNewApplication.UseVisualStyleBackColor = true;
            this.btnAddNewApplication.Click += new System.EventHandler(this.btnAddNewApplication_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbStatusFiltes);
            this.panel1.Controls.Add(this.tbFilter);
            this.panel1.Controls.Add(this.cbFilters);
            this.panel1.Controls.Add(this.lbFilterByTitle);
            this.panel1.Location = new System.Drawing.Point(10, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 30);
            this.panel1.TabIndex = 3;
            // 
            // cbStatusFiltes
            // 
            this.cbStatusFiltes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusFiltes.FormattingEnabled = true;
            this.cbStatusFiltes.Items.AddRange(new object[] {
            "Active",
            "Expired"});
            this.cbStatusFiltes.Location = new System.Drawing.Point(244, 6);
            this.cbStatusFiltes.Name = "cbStatusFiltes";
            this.cbStatusFiltes.Size = new System.Drawing.Size(137, 21);
            this.cbStatusFiltes.TabIndex = 3;
            this.cbStatusFiltes.Visible = false;
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(244, 7);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(161, 20);
            this.tbFilter.TabIndex = 2;
            this.tbFilter.Visible = false;
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
            // ManagerInternationalLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddNewApplication);
            this.Controls.Add(this.dgvApplicationsTable);
            this.Controls.Add(this.lbTitle);
            this.Name = "ManagerInternationalLicenses";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Manage International Licenses";
            this.Load += new System.EventHandler(this.ManagerInternationalLicenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationsTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridView dgvApplicationsTable;
        private System.Windows.Forms.Button btnAddNewApplication;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbStatusFiltes;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.Label lbFilterByTitle;
    }
}