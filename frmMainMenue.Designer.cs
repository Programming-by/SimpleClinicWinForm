﻿namespace SimpleClinicWinForm
{
    partial class frmMainMenue
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageAppointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicalRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prescriptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rescheduleNewAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageAppointmentsToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.doctorsToolStripMenuItem,
            this.patientsToolStripMenuItem,
            this.medicalRecordsToolStripMenuItem,
            this.paymentsToolStripMenuItem,
            this.prescriptionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(890, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageAppointmentsToolStripMenuItem
            // 
            this.manageAppointmentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appointmentsToolStripMenuItem1});
            this.manageAppointmentsToolStripMenuItem.Name = "manageAppointmentsToolStripMenuItem";
            this.manageAppointmentsToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.manageAppointmentsToolStripMenuItem.Text = "Manage Appointments";
            // 
            // appointmentsToolStripMenuItem1
            // 
            this.appointmentsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appointmentsToolStripMenuItem,
            this.rescheduleNewAppointmentToolStripMenuItem});
            this.appointmentsToolStripMenuItem1.Name = "appointmentsToolStripMenuItem1";
            this.appointmentsToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.appointmentsToolStripMenuItem1.Text = "Appointments";
            // 
            // appointmentsToolStripMenuItem
            // 
            this.appointmentsToolStripMenuItem.Name = "appointmentsToolStripMenuItem";
            this.appointmentsToolStripMenuItem.Size = new System.Drawing.Size(293, 26);
            this.appointmentsToolStripMenuItem.Text = "Appointments Details";
            this.appointmentsToolStripMenuItem.Click += new System.EventHandler(this.appointmentsToolStripMenuItem_Click);
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.peopleToolStripMenuItem.Text = "People";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // doctorsToolStripMenuItem
            // 
            this.doctorsToolStripMenuItem.Name = "doctorsToolStripMenuItem";
            this.doctorsToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.doctorsToolStripMenuItem.Text = "Doctors";
            this.doctorsToolStripMenuItem.Click += new System.EventHandler(this.doctorsToolStripMenuItem_Click);
            // 
            // patientsToolStripMenuItem
            // 
            this.patientsToolStripMenuItem.Name = "patientsToolStripMenuItem";
            this.patientsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.patientsToolStripMenuItem.Text = "Patients";
            this.patientsToolStripMenuItem.Click += new System.EventHandler(this.patientsToolStripMenuItem_Click);
            // 
            // medicalRecordsToolStripMenuItem
            // 
            this.medicalRecordsToolStripMenuItem.Name = "medicalRecordsToolStripMenuItem";
            this.medicalRecordsToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.medicalRecordsToolStripMenuItem.Text = "Medical Records";
            this.medicalRecordsToolStripMenuItem.Click += new System.EventHandler(this.medicalRecordsToolStripMenuItem_Click);
            // 
            // paymentsToolStripMenuItem
            // 
            this.paymentsToolStripMenuItem.Name = "paymentsToolStripMenuItem";
            this.paymentsToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.paymentsToolStripMenuItem.Text = "Payments";
            this.paymentsToolStripMenuItem.Click += new System.EventHandler(this.paymentsToolStripMenuItem_Click);
            // 
            // prescriptionsToolStripMenuItem
            // 
            this.prescriptionsToolStripMenuItem.Name = "prescriptionsToolStripMenuItem";
            this.prescriptionsToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.prescriptionsToolStripMenuItem.Text = "Prescriptions";
            this.prescriptionsToolStripMenuItem.Click += new System.EventHandler(this.prescriptionsToolStripMenuItem_Click);
            // 
            // rescheduleNewAppointmentToolStripMenuItem
            // 
            this.rescheduleNewAppointmentToolStripMenuItem.Name = "rescheduleNewAppointmentToolStripMenuItem";
            this.rescheduleNewAppointmentToolStripMenuItem.Size = new System.Drawing.Size(293, 26);
            this.rescheduleNewAppointmentToolStripMenuItem.Text = "Reschedule New Appointment";
            this.rescheduleNewAppointmentToolStripMenuItem.Click += new System.EventHandler(this.rescheduleNewAppointmentToolStripMenuItem_Click);
            // 
            // frmMainMenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(890, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainMenue";
            this.Text = "Main Menue";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicalRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prescriptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageAppointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem appointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rescheduleNewAppointmentToolStripMenuItem;
    }
}

