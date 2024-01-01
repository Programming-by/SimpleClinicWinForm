namespace SimpleClinicWinForm.Doctors
{
    partial class frmListDoctors
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
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblDoctorsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddNewDoctor = new System.Windows.Forms.Button();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDoctorDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtFilter1 = new System.Windows.Forms.TextBox();
            this.dgvDoctors = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFilters
            // 
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Items.AddRange(new object[] {
            "None",
            "DoctorID",
            "Doctor Name",
            "Gender",
            "Phone Number",
            "Email"});
            this.cbFilters.Location = new System.Drawing.Point(140, 94);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(168, 24);
            this.cbFilters.TabIndex = 44;
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 29);
            this.label3.TabIndex = 43;
            this.label3.Text = "Filter By:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1047, 459);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 47);
            this.btnClose.TabIndex = 42;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblDoctorsCount
            // 
            this.lblDoctorsCount.AutoSize = true;
            this.lblDoctorsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorsCount.Location = new System.Drawing.Point(129, 467);
            this.lblDoctorsCount.Name = "lblDoctorsCount";
            this.lblDoctorsCount.Size = new System.Drawing.Size(23, 25);
            this.lblDoctorsCount.TabIndex = 41;
            this.lblDoctorsCount.Text = "#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 467);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "# Records: ";
            // 
            // btnAddNewDoctor
            // 
            this.btnAddNewDoctor.Location = new System.Drawing.Point(1047, 72);
            this.btnAddNewDoctor.Name = "btnAddNewDoctor";
            this.btnAddNewDoctor.Size = new System.Drawing.Size(111, 73);
            this.btnAddNewDoctor.TabIndex = 39;
            this.btnAddNewDoctor.UseVisualStyleBackColor = true;
            this.btnAddNewDoctor.Click += new System.EventHandler(this.btnAddNewDoctor_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // addNewDoctorToolStripMenuItem
            // 
            this.addNewDoctorToolStripMenuItem.Name = "addNewDoctorToolStripMenuItem";
            this.addNewDoctorToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.addNewDoctorToolStripMenuItem.Text = "Add New Doctor";
            this.addNewDoctorToolStripMenuItem.Click += new System.EventHandler(this.addNewDoctorToolStripMenuItem_Click);
            // 
            // showDoctorDetailsToolStripMenuItem
            // 
            this.showDoctorDetailsToolStripMenuItem.Name = "showDoctorDetailsToolStripMenuItem";
            this.showDoctorDetailsToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.showDoctorDetailsToolStripMenuItem.Text = "Show Doctor Details";
            this.showDoctorDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDoctorDetailsToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDoctorDetailsToolStripMenuItem,
            this.addNewDoctorToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(215, 100);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // txtFilter1
            // 
            this.txtFilter1.Location = new System.Drawing.Point(335, 94);
            this.txtFilter1.Multiline = true;
            this.txtFilter1.Name = "txtFilter1";
            this.txtFilter1.Size = new System.Drawing.Size(161, 31);
            this.txtFilter1.TabIndex = 45;
            this.txtFilter1.TextChanged += new System.EventHandler(this.txtFilter1_TextChanged);
            this.txtFilter1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter1_KeyPress);
            // 
            // dgvDoctors
            // 
            this.dgvDoctors.AllowUserToAddRows = false;
            this.dgvDoctors.AllowUserToDeleteRows = false;
            this.dgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctors.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvDoctors.Location = new System.Drawing.Point(12, 151);
            this.dgvDoctors.Name = "dgvDoctors";
            this.dgvDoctors.ReadOnly = true;
            this.dgvDoctors.RowHeadersWidth = 51;
            this.dgvDoctors.RowTemplate.Height = 24;
            this.dgvDoctors.Size = new System.Drawing.Size(1146, 295);
            this.dgvDoctors.TabIndex = 38;
            this.dgvDoctors.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoctors_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(529, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 29);
            this.label1.TabIndex = 37;
            this.label1.Text = "Manage Doctors";
            // 
            // frmListDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 536);
            this.Controls.Add(this.cbFilters);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblDoctorsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddNewDoctor);
            this.Controls.Add(this.txtFilter1);
            this.Controls.Add(this.dgvDoctors);
            this.Controls.Add(this.label1);
            this.Name = "frmListDoctors";
            this.Text = "frmListDoctors";
            this.Load += new System.EventHandler(this.frmListDoctors_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDoctorsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddNewDoctor;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDoctorDetailsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtFilter1;
        private System.Windows.Forms.DataGridView dgvDoctors;
        private System.Windows.Forms.Label label1;
    }
}