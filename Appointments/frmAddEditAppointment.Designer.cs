namespace SimpleClinicWinForm.Appointments
{
    partial class frmAddEditAppointment
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbAppointmentInfo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNextToDoctor = new System.Windows.Forms.Button();
            this.tpDoctorInfo = new System.Windows.Forms.TabPage();
            this.btnNextToMedicalRecord = new System.Windows.Forms.Button();
            this.tpMedicalRecordInfo = new System.Windows.Forms.TabPage();
            this.btnNextToPayment = new System.Windows.Forms.Button();
            this.tpPaymentInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.tpAppointmentInfo = new System.Windows.Forms.TabPage();
            this.lblAppointmentStatus = new System.Windows.Forms.Label();
            this.dateTimePickerAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAppointmentID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ctrlPatientCardWithFilter1 = new SimpleClinicWinForm.Patients.Controls.ctrlPatientCardWithFilter();
            this.ctrlDoctorCardWithFilter1 = new SimpleClinicWinForm.Doctors.Controls.ctrlDoctorCardWithFilter();
            this.ctrlMedicalRecordCardWithFilter1 = new SimpleClinicWinForm.MedicalRecords.Controls.ctrlMedicalRecordCardWithFilter();
            this.ctrlPaymentCardWithFilter1 = new SimpleClinicWinForm.Payments.Controls.ctrlPaymentCardWithFilter();
            this.tbAppointmentInfo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tpDoctorInfo.SuspendLayout();
            this.tpMedicalRecordInfo.SuspendLayout();
            this.tpPaymentInfo.SuspendLayout();
            this.tpAppointmentInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTitle.Location = new System.Drawing.Point(379, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(253, 29);
            this.lblTitle.TabIndex = 75;
            this.lblTitle.Text = "Add New Appointment";
            // 
            // tbAppointmentInfo
            // 
            this.tbAppointmentInfo.Controls.Add(this.tabPage1);
            this.tbAppointmentInfo.Controls.Add(this.tpDoctorInfo);
            this.tbAppointmentInfo.Controls.Add(this.tpMedicalRecordInfo);
            this.tbAppointmentInfo.Controls.Add(this.tpPaymentInfo);
            this.tbAppointmentInfo.Controls.Add(this.tpAppointmentInfo);
            this.tbAppointmentInfo.Location = new System.Drawing.Point(12, 106);
            this.tbAppointmentInfo.Name = "tbAppointmentInfo";
            this.tbAppointmentInfo.SelectedIndex = 0;
            this.tbAppointmentInfo.Size = new System.Drawing.Size(916, 669);
            this.tbAppointmentInfo.TabIndex = 76;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnNextToDoctor);
            this.tabPage1.Controls.Add(this.ctrlPatientCardWithFilter1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(908, 640);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Patient Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnNextToDoctor
            // 
            this.btnNextToDoctor.Location = new System.Drawing.Point(738, 527);
            this.btnNextToDoctor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNextToDoctor.Name = "btnNextToDoctor";
            this.btnNextToDoctor.Size = new System.Drawing.Size(121, 78);
            this.btnNextToDoctor.TabIndex = 76;
            this.btnNextToDoctor.Text = "Next";
            this.btnNextToDoctor.UseVisualStyleBackColor = true;
            this.btnNextToDoctor.Click += new System.EventHandler(this.btnNextToDoctor_Click);
            // 
            // tpDoctorInfo
            // 
            this.tpDoctorInfo.Controls.Add(this.ctrlDoctorCardWithFilter1);
            this.tpDoctorInfo.Controls.Add(this.btnNextToMedicalRecord);
            this.tpDoctorInfo.Location = new System.Drawing.Point(4, 25);
            this.tpDoctorInfo.Name = "tpDoctorInfo";
            this.tpDoctorInfo.Size = new System.Drawing.Size(908, 640);
            this.tpDoctorInfo.TabIndex = 3;
            this.tpDoctorInfo.Text = "Doctor Info";
            this.tpDoctorInfo.UseVisualStyleBackColor = true;
            // 
            // btnNextToMedicalRecord
            // 
            this.btnNextToMedicalRecord.Location = new System.Drawing.Point(743, 527);
            this.btnNextToMedicalRecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNextToMedicalRecord.Name = "btnNextToMedicalRecord";
            this.btnNextToMedicalRecord.Size = new System.Drawing.Size(121, 78);
            this.btnNextToMedicalRecord.TabIndex = 81;
            this.btnNextToMedicalRecord.Text = "Next";
            this.btnNextToMedicalRecord.UseVisualStyleBackColor = true;
            this.btnNextToMedicalRecord.Click += new System.EventHandler(this.btnNextToMedicalRecord_Click);
            // 
            // tpMedicalRecordInfo
            // 
            this.tpMedicalRecordInfo.Controls.Add(this.ctrlMedicalRecordCardWithFilter1);
            this.tpMedicalRecordInfo.Controls.Add(this.btnNextToPayment);
            this.tpMedicalRecordInfo.Location = new System.Drawing.Point(4, 25);
            this.tpMedicalRecordInfo.Name = "tpMedicalRecordInfo";
            this.tpMedicalRecordInfo.Size = new System.Drawing.Size(908, 640);
            this.tpMedicalRecordInfo.TabIndex = 4;
            this.tpMedicalRecordInfo.Text = "Medical Record Info";
            this.tpMedicalRecordInfo.UseVisualStyleBackColor = true;
            // 
            // btnNextToPayment
            // 
            this.btnNextToPayment.Location = new System.Drawing.Point(710, 418);
            this.btnNextToPayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNextToPayment.Name = "btnNextToPayment";
            this.btnNextToPayment.Size = new System.Drawing.Size(121, 78);
            this.btnNextToPayment.TabIndex = 82;
            this.btnNextToPayment.Text = "Next";
            this.btnNextToPayment.UseVisualStyleBackColor = true;
            this.btnNextToPayment.Click += new System.EventHandler(this.btnNextToPayment_Click);
            // 
            // tpPaymentInfo
            // 
            this.tpPaymentInfo.Controls.Add(this.ctrlPaymentCardWithFilter1);
            this.tpPaymentInfo.Controls.Add(this.btnNext);
            this.tpPaymentInfo.Location = new System.Drawing.Point(4, 25);
            this.tpPaymentInfo.Name = "tpPaymentInfo";
            this.tpPaymentInfo.Size = new System.Drawing.Size(908, 640);
            this.tpPaymentInfo.TabIndex = 5;
            this.tpPaymentInfo.Text = "Payment Info";
            this.tpPaymentInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(734, 459);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(152, 78);
            this.btnNext.TabIndex = 83;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tpAppointmentInfo
            // 
            this.tpAppointmentInfo.Controls.Add(this.lblAppointmentStatus);
            this.tpAppointmentInfo.Controls.Add(this.dateTimePickerAppointmentDate);
            this.tpAppointmentInfo.Controls.Add(this.label6);
            this.tpAppointmentInfo.Controls.Add(this.label5);
            this.tpAppointmentInfo.Controls.Add(this.lblAppointmentID);
            this.tpAppointmentInfo.Controls.Add(this.label4);
            this.tpAppointmentInfo.Location = new System.Drawing.Point(4, 25);
            this.tpAppointmentInfo.Name = "tpAppointmentInfo";
            this.tpAppointmentInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpAppointmentInfo.Size = new System.Drawing.Size(908, 640);
            this.tpAppointmentInfo.TabIndex = 1;
            this.tpAppointmentInfo.Text = "Appointment Info";
            this.tpAppointmentInfo.UseVisualStyleBackColor = true;
            // 
            // lblAppointmentStatus
            // 
            this.lblAppointmentStatus.AutoSize = true;
            this.lblAppointmentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentStatus.Location = new System.Drawing.Point(353, 283);
            this.lblAppointmentStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppointmentStatus.Name = "lblAppointmentStatus";
            this.lblAppointmentStatus.Size = new System.Drawing.Size(48, 25);
            this.lblAppointmentStatus.TabIndex = 54;
            this.lblAppointmentStatus.Text = "???";
            // 
            // dateTimePickerAppointmentDate
            // 
            this.dateTimePickerAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAppointmentDate.Location = new System.Drawing.Point(358, 228);
            this.dateTimePickerAppointmentDate.Name = "dateTimePickerAppointmentDate";
            this.dateTimePickerAppointmentDate.Size = new System.Drawing.Size(282, 22);
            this.dateTimePickerAppointmentDate.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 283);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 25);
            this.label6.TabIndex = 45;
            this.label6.Text = "Appointment Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 226);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 25);
            this.label5.TabIndex = 44;
            this.label5.Text = "Appointment Date Time:";
            // 
            // lblAppointmentID
            // 
            this.lblAppointmentID.AutoSize = true;
            this.lblAppointmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentID.Location = new System.Drawing.Point(353, 165);
            this.lblAppointmentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppointmentID.Name = "lblAppointmentID";
            this.lblAppointmentID.Size = new System.Drawing.Size(48, 25);
            this.lblAppointmentID.TabIndex = 41;
            this.lblAppointmentID.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "AppointmentID:";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(518, 785);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 78);
            this.btnClose.TabIndex = 79;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(744, 783);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 78);
            this.btnSave.TabIndex = 80;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ctrlPatientCardWithFilter1
            // 
            this.ctrlPatientCardWithFilter1.FilterEnabled = true;
            this.ctrlPatientCardWithFilter1.Location = new System.Drawing.Point(3, 6);
            this.ctrlPatientCardWithFilter1.Name = "ctrlPatientCardWithFilter1";
            this.ctrlPatientCardWithFilter1.Size = new System.Drawing.Size(748, 504);
            this.ctrlPatientCardWithFilter1.TabIndex = 77;
            // 
            // ctrlDoctorCardWithFilter1
            // 
            this.ctrlDoctorCardWithFilter1.Location = new System.Drawing.Point(0, 3);
            this.ctrlDoctorCardWithFilter1.Name = "ctrlDoctorCardWithFilter1";
            this.ctrlDoctorCardWithFilter1.Size = new System.Drawing.Size(736, 602);
            this.ctrlDoctorCardWithFilter1.TabIndex = 82;
            // 
            // ctrlMedicalRecordCardWithFilter1
            // 
            this.ctrlMedicalRecordCardWithFilter1.FilterEnabled = true;
            this.ctrlMedicalRecordCardWithFilter1.Location = new System.Drawing.Point(3, 0);
            this.ctrlMedicalRecordCardWithFilter1.Name = "ctrlMedicalRecordCardWithFilter1";
            this.ctrlMedicalRecordCardWithFilter1.Size = new System.Drawing.Size(774, 373);
            this.ctrlMedicalRecordCardWithFilter1.TabIndex = 83;
            // 
            // ctrlPaymentCardWithFilter1
            // 
            this.ctrlPaymentCardWithFilter1.Location = new System.Drawing.Point(3, 3);
            this.ctrlPaymentCardWithFilter1.Name = "ctrlPaymentCardWithFilter1";
            this.ctrlPaymentCardWithFilter1.Size = new System.Drawing.Size(724, 534);
            this.ctrlPaymentCardWithFilter1.TabIndex = 84;
            // 
            // frmAddEditAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 877);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbAppointmentInfo);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmAddEditAppointment";
            this.Text = "frmAddEditPrescription";
            this.Load += new System.EventHandler(this.frmAddEditAppointment_Load);
            this.tbAppointmentInfo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tpDoctorInfo.ResumeLayout(false);
            this.tpMedicalRecordInfo.ResumeLayout(false);
            this.tpPaymentInfo.ResumeLayout(false);
            this.tpAppointmentInfo.ResumeLayout(false);
            this.tpAppointmentInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tbAppointmentInfo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnNextToDoctor;
        private System.Windows.Forms.TabPage tpAppointmentInfo;
        private System.Windows.Forms.DateTimePicker dateTimePickerAppointmentDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAppointmentID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblAppointmentStatus;
        private System.Windows.Forms.TabPage tpDoctorInfo;
        private System.Windows.Forms.Button btnNextToMedicalRecord;
        private System.Windows.Forms.TabPage tpMedicalRecordInfo;
        private System.Windows.Forms.Button btnNextToPayment;
        private System.Windows.Forms.TabPage tpPaymentInfo;
        private System.Windows.Forms.Button btnNext;
        private Patients.Controls.ctrlPatientCardWithFilter ctrlPatientCardWithFilter1;
        private Doctors.Controls.ctrlDoctorCardWithFilter ctrlDoctorCardWithFilter1;
        private MedicalRecords.Controls.ctrlMedicalRecordCardWithFilter ctrlMedicalRecordCardWithFilter1;
        private Payments.Controls.ctrlPaymentCardWithFilter ctrlPaymentCardWithFilter1;
    }
}