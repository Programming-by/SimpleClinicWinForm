namespace SimpleClinicWinForm.Patients.Controls
{
    partial class ctrlPatientAppointments
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
            this.components = new System.ComponentModel.Container();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.lblPatientsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showAppointmentInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPatients
            // 
            this.dgvPatients.AllowUserToAddRows = false;
            this.dgvPatients.AllowUserToDeleteRows = false;
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvPatients.Location = new System.Drawing.Point(19, 58);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.ReadOnly = true;
            this.dgvPatients.RowHeadersWidth = 51;
            this.dgvPatients.RowTemplate.Height = 24;
            this.dgvPatients.Size = new System.Drawing.Size(836, 295);
            this.dgvPatients.TabIndex = 48;
            // 
            // lblPatientsCount
            // 
            this.lblPatientsCount.AutoSize = true;
            this.lblPatientsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientsCount.Location = new System.Drawing.Point(148, 379);
            this.lblPatientsCount.Name = "lblPatientsCount";
            this.lblPatientsCount.Size = new System.Drawing.Size(23, 25);
            this.lblPatientsCount.TabIndex = 52;
            this.lblPatientsCount.Text = "#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 51;
            this.label2.Text = "# Records: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 22);
            this.label1.TabIndex = 53;
            this.label1.Text = "Patient Appointments History";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAppointmentInfoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(237, 56);
            // 
            // showAppointmentInfoToolStripMenuItem
            // 
            this.showAppointmentInfoToolStripMenuItem.Name = "showAppointmentInfoToolStripMenuItem";
            this.showAppointmentInfoToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.showAppointmentInfoToolStripMenuItem.Text = "Show Appointment Info";
            this.showAppointmentInfoToolStripMenuItem.Click += new System.EventHandler(this.showAppointmentInfoToolStripMenuItem_Click);
            // 
            // ctrlPatientAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPatientsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPatients);
            this.Name = "ctrlPatientAppointments";
            this.Size = new System.Drawing.Size(882, 420);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.Label lblPatientsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showAppointmentInfoToolStripMenuItem;
    }
}
