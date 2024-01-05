namespace SimpleClinicWinForm.Prescriptions
{
    partial class frmAddEditPrescription
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbMedicalRecordInfo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlMedicalRecordCardWithFilter1 = new SimpleClinicWinForm.MedicalRecords.Controls.ctrlMedicalRecordCardWithFilter();
            this.tpPrescriptionInfo = new System.Windows.Forms.TabPage();
            this.txtSpecialInstructions = new System.Windows.Forms.TextBox();
            this.txtMedicationName = new System.Windows.Forms.TextBox();
            this.txtDosage = new System.Windows.Forms.TextBox();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtFrequency = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrescriptionID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbMedicalRecordInfo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tpPrescriptionInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTitle.Location = new System.Drawing.Point(322, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(247, 29);
            this.lblTitle.TabIndex = 74;
            this.lblTitle.Text = "Add New Prescription";
            // 
            // tbMedicalRecordInfo
            // 
            this.tbMedicalRecordInfo.Controls.Add(this.tabPage1);
            this.tbMedicalRecordInfo.Controls.Add(this.tpPrescriptionInfo);
            this.tbMedicalRecordInfo.Location = new System.Drawing.Point(29, 66);
            this.tbMedicalRecordInfo.Name = "tbMedicalRecordInfo";
            this.tbMedicalRecordInfo.SelectedIndex = 0;
            this.tbMedicalRecordInfo.Size = new System.Drawing.Size(804, 537);
            this.tbMedicalRecordInfo.TabIndex = 75;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Controls.Add(this.ctrlMedicalRecordCardWithFilter1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(796, 508);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "MedicalRecord Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(583, 373);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(121, 78);
            this.btnNext.TabIndex = 76;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlMedicalRecordCardWithFilter1
            // 
            this.ctrlMedicalRecordCardWithFilter1.Location = new System.Drawing.Point(0, 3);
            this.ctrlMedicalRecordCardWithFilter1.Name = "ctrlMedicalRecordCardWithFilter1";
            this.ctrlMedicalRecordCardWithFilter1.Size = new System.Drawing.Size(704, 362);
            this.ctrlMedicalRecordCardWithFilter1.TabIndex = 0;
            // 
            // tpPrescriptionInfo
            // 
            this.tpPrescriptionInfo.Controls.Add(this.txtSpecialInstructions);
            this.tpPrescriptionInfo.Controls.Add(this.txtMedicationName);
            this.tpPrescriptionInfo.Controls.Add(this.txtDosage);
            this.tpPrescriptionInfo.Controls.Add(this.dateTimePickerEndDate);
            this.tpPrescriptionInfo.Controls.Add(this.dateTimePickerStartDate);
            this.tpPrescriptionInfo.Controls.Add(this.txtFrequency);
            this.tpPrescriptionInfo.Controls.Add(this.label8);
            this.tpPrescriptionInfo.Controls.Add(this.label7);
            this.tpPrescriptionInfo.Controls.Add(this.label6);
            this.tpPrescriptionInfo.Controls.Add(this.label5);
            this.tpPrescriptionInfo.Controls.Add(this.label3);
            this.tpPrescriptionInfo.Controls.Add(this.label2);
            this.tpPrescriptionInfo.Controls.Add(this.lblPrescriptionID);
            this.tpPrescriptionInfo.Controls.Add(this.label4);
            this.tpPrescriptionInfo.Location = new System.Drawing.Point(4, 25);
            this.tpPrescriptionInfo.Name = "tpPrescriptionInfo";
            this.tpPrescriptionInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPrescriptionInfo.Size = new System.Drawing.Size(796, 508);
            this.tpPrescriptionInfo.TabIndex = 1;
            this.tpPrescriptionInfo.Text = "Prescription Info";
            this.tpPrescriptionInfo.UseVisualStyleBackColor = true;
            // 
            // txtSpecialInstructions
            // 
            this.txtSpecialInstructions.Location = new System.Drawing.Point(271, 386);
            this.txtSpecialInstructions.Multiline = true;
            this.txtSpecialInstructions.Name = "txtSpecialInstructions";
            this.txtSpecialInstructions.Size = new System.Drawing.Size(282, 101);
            this.txtSpecialInstructions.TabIndex = 53;
            // 
            // txtMedicationName
            // 
            this.txtMedicationName.Location = new System.Drawing.Point(271, 135);
            this.txtMedicationName.Name = "txtMedicationName";
            this.txtMedicationName.Size = new System.Drawing.Size(282, 22);
            this.txtMedicationName.TabIndex = 52;
            this.txtMedicationName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateTextBox);
            // 
            // txtDosage
            // 
            this.txtDosage.Location = new System.Drawing.Point(271, 187);
            this.txtDosage.Name = "txtDosage";
            this.txtDosage.Size = new System.Drawing.Size(282, 22);
            this.txtDosage.TabIndex = 51;
            this.txtDosage.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateTextBox);
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(271, 330);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(282, 22);
            this.dateTimePickerEndDate.TabIndex = 50;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(271, 286);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(282, 22);
            this.dateTimePickerStartDate.TabIndex = 49;
            // 
            // txtFrequency
            // 
            this.txtFrequency.Location = new System.Drawing.Point(271, 237);
            this.txtFrequency.Name = "txtFrequency";
            this.txtFrequency.Size = new System.Drawing.Size(282, 22);
            this.txtFrequency.TabIndex = 48;
            this.txtFrequency.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateTextBox);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(47, 383);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 25);
            this.label8.TabIndex = 47;
            this.label8.Text = "Special Instructions:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 330);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 25);
            this.label7.TabIndex = 46;
            this.label7.Text = "End Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 283);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 25);
            this.label6.TabIndex = 45;
            this.label6.Text = "Start Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 234);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 44;
            this.label5.Text = "Frequency:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 43;
            this.label3.Text = "Dosage:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "Medication Name:";
            // 
            // lblPrescriptionID
            // 
            this.lblPrescriptionID.AutoSize = true;
            this.lblPrescriptionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrescriptionID.Location = new System.Drawing.Point(266, 78);
            this.lblPrescriptionID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrescriptionID.Name = "lblPrescriptionID";
            this.lblPrescriptionID.Size = new System.Drawing.Size(48, 25);
            this.lblPrescriptionID.TabIndex = 41;
            this.lblPrescriptionID.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "PrescriptionID:";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(466, 607);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 78);
            this.btnClose.TabIndex = 77;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(653, 611);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 78);
            this.btnSave.TabIndex = 78;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddEditPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 693);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbMedicalRecordInfo);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmAddEditPrescription";
            this.Text = "frmAddEditPrescription";
            this.Load += new System.EventHandler(this.frmAddEditPrescription_Load);
            this.tbMedicalRecordInfo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tpPrescriptionInfo.ResumeLayout(false);
            this.tpPrescriptionInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tbMedicalRecordInfo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tpPrescriptionInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private MedicalRecords.Controls.ctrlMedicalRecordCardWithFilter ctrlMedicalRecordCardWithFilter1;
        private System.Windows.Forms.Label lblPrescriptionID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSpecialInstructions;
        private System.Windows.Forms.TextBox txtMedicationName;
        private System.Windows.Forms.TextBox txtDosage;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.TextBox txtFrequency;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}