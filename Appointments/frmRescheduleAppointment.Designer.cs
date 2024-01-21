namespace SimpleClinicWinForm.Appointments
{
    partial class frmRescheduleAppointment
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnScheduleNewAppointment = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAppointmentStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.lblAppointmentID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ctrlAppointmentInfoWithFilter1 = new SimpleClinicWinForm.Appointments.Controls.ctrlAppointmentInfoWithFilter();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(429, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 29);
            this.label1.TabIndex = 65;
            this.label1.Text = "Reschedule Appointment";
            // 
            // btnScheduleNewAppointment
            // 
            this.btnScheduleNewAppointment.Location = new System.Drawing.Point(656, 805);
            this.btnScheduleNewAppointment.Margin = new System.Windows.Forms.Padding(4);
            this.btnScheduleNewAppointment.Name = "btnScheduleNewAppointment";
            this.btnScheduleNewAppointment.Size = new System.Drawing.Size(233, 82);
            this.btnScheduleNewAppointment.TabIndex = 67;
            this.btnScheduleNewAppointment.Text = "Schedule New Appointment";
            this.btnScheduleNewAppointment.UseVisualStyleBackColor = true;
            this.btnScheduleNewAppointment.Click += new System.EventHandler(this.btnScheduleNewAppointment_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAppointmentStatus);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePickerAppointmentDate);
            this.groupBox1.Controls.Add(this.lblAppointmentID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(56, 555);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 226);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblAppointmentStatus
            // 
            this.lblAppointmentStatus.AutoSize = true;
            this.lblAppointmentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentStatus.Location = new System.Drawing.Point(321, 153);
            this.lblAppointmentStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppointmentStatus.Name = "lblAppointmentStatus";
            this.lblAppointmentStatus.Size = new System.Drawing.Size(48, 25);
            this.lblAppointmentStatus.TabIndex = 74;
            this.lblAppointmentStatus.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 69;
            this.label4.Text = "AppointmentID:";
            // 
            // dateTimePickerAppointmentDate
            // 
            this.dateTimePickerAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAppointmentDate.Location = new System.Drawing.Point(326, 98);
            this.dateTimePickerAppointmentDate.Name = "dateTimePickerAppointmentDate";
            this.dateTimePickerAppointmentDate.Size = new System.Drawing.Size(282, 22);
            this.dateTimePickerAppointmentDate.TabIndex = 73;
            // 
            // lblAppointmentID
            // 
            this.lblAppointmentID.AutoSize = true;
            this.lblAppointmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentID.Location = new System.Drawing.Point(321, 35);
            this.lblAppointmentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppointmentID.Name = "lblAppointmentID";
            this.lblAppointmentID.Size = new System.Drawing.Size(48, 25);
            this.lblAppointmentID.TabIndex = 70;
            this.lblAppointmentID.Text = "???";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 153);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 25);
            this.label6.TabIndex = 72;
            this.label6.Text = "Appointment Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 25);
            this.label5.TabIndex = 71;
            this.label5.Text = "Appointment Date Time:";
            // 
            // ctrlAppointmentInfoWithFilter1
            // 
            this.ctrlAppointmentInfoWithFilter1.Location = new System.Drawing.Point(15, 78);
            this.ctrlAppointmentInfoWithFilter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctrlAppointmentInfoWithFilter1.Name = "ctrlAppointmentInfoWithFilter1";
            this.ctrlAppointmentInfoWithFilter1.Size = new System.Drawing.Size(1000, 594);
            this.ctrlAppointmentInfoWithFilter1.TabIndex = 66;
            this.ctrlAppointmentInfoWithFilter1.OnAppointmentSelected += new System.Action<int>(this.ctrlAppointmentInfoWithFilter1_OnAppointmentSelected);
            // 
            // frmRescheduleAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 935);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnScheduleNewAppointment);
            this.Controls.Add(this.ctrlAppointmentInfoWithFilter1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRescheduleAppointment";
            this.Text = "frmRescheduleAppointment";
            this.Load += new System.EventHandler(this.frmRescheduleAppointment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Controls.ctrlAppointmentInfoWithFilter ctrlAppointmentInfoWithFilter1;
        private System.Windows.Forms.Button btnScheduleNewAppointment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAppointmentStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerAppointmentDate;
        private System.Windows.Forms.Label lblAppointmentID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}