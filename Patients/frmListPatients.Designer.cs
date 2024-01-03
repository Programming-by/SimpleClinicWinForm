namespace SimpleClinicWinForm.Patients
{
    partial class frmListPatients
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
            this.lblPatientsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddNewPatient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPatientDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtFilter1 = new System.Windows.Forms.TextBox();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFilters
            // 
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Items.AddRange(new object[] {
            "None",
            "PatientID",
            "Patient Name",
            "Gender",
            "Phone Number",
            "Email"});
            this.cbFilters.Location = new System.Drawing.Point(130, 65);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(168, 24);
            this.cbFilters.TabIndex = 53;
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 29);
            this.label3.TabIndex = 52;
            this.label3.Text = "Filter By:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1004, 423);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 47);
            this.btnClose.TabIndex = 51;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblPatientsCount
            // 
            this.lblPatientsCount.AutoSize = true;
            this.lblPatientsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientsCount.Location = new System.Drawing.Point(141, 431);
            this.lblPatientsCount.Name = "lblPatientsCount";
            this.lblPatientsCount.Size = new System.Drawing.Size(23, 25);
            this.lblPatientsCount.TabIndex = 50;
            this.lblPatientsCount.Text = "#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "# Records: ";
            // 
            // btnAddNewPatient
            // 
            this.btnAddNewPatient.Location = new System.Drawing.Point(1037, 33);
            this.btnAddNewPatient.Name = "btnAddNewPatient";
            this.btnAddNewPatient.Size = new System.Drawing.Size(111, 73);
            this.btnAddNewPatient.TabIndex = 48;
            this.btnAddNewPatient.UseVisualStyleBackColor = true;
            this.btnAddNewPatient.Click += new System.EventHandler(this.btnAddNewPatient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(531, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 29);
            this.label1.TabIndex = 46;
            this.label1.Text = "Manage Patients";
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
            this.editToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // addNewPatientToolStripMenuItem
            // 
            this.addNewPatientToolStripMenuItem.Name = "addNewPatientToolStripMenuItem";
            this.addNewPatientToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.addNewPatientToolStripMenuItem.Text = "Add New Patient";
            this.addNewPatientToolStripMenuItem.Click += new System.EventHandler(this.addNewPatientToolStripMenuItem_Click);
            // 
            // showPatientDetailsToolStripMenuItem
            // 
            this.showPatientDetailsToolStripMenuItem.Name = "showPatientDetailsToolStripMenuItem";
            this.showPatientDetailsToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.showPatientDetailsToolStripMenuItem.Text = "Show Patient Details";
            this.showPatientDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPatientDetailsToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPatientDetailsToolStripMenuItem,
            this.addNewPatientToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(214, 128);
            // 
            // txtFilter1
            // 
            this.txtFilter1.Location = new System.Drawing.Point(328, 65);
            this.txtFilter1.Multiline = true;
            this.txtFilter1.Name = "txtFilter1";
            this.txtFilter1.Size = new System.Drawing.Size(161, 31);
            this.txtFilter1.TabIndex = 54;
            this.txtFilter1.TextChanged += new System.EventHandler(this.txtFilter1_TextChanged);
            this.txtFilter1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter1_KeyPress);
            // 
            // dgvPatients
            // 
            this.dgvPatients.AllowUserToAddRows = false;
            this.dgvPatients.AllowUserToDeleteRows = false;
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvPatients.Location = new System.Drawing.Point(12, 115);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.ReadOnly = true;
            this.dgvPatients.RowHeadersWidth = 51;
            this.dgvPatients.RowTemplate.Height = 24;
            this.dgvPatients.Size = new System.Drawing.Size(1146, 295);
            this.dgvPatients.TabIndex = 47;
            // 
            // frmListPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 495);
            this.Controls.Add(this.cbFilters);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblPatientsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddNewPatient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilter1);
            this.Controls.Add(this.dgvPatients);
            this.Name = "frmListPatients";
            this.Text = "frmListPatients";
            this.Load += new System.EventHandler(this.frmListPatients_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblPatientsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddNewPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPatientDetailsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtFilter1;
        private System.Windows.Forms.DataGridView dgvPatients;
    }
}