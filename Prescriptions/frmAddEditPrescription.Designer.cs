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
            this.label1 = new System.Windows.Forms.Label();
            this.tbPatientInfo = new System.Windows.Forms.TabControl();
            this.tpPrescriptionInfo = new System.Windows.Forms.TabPage();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbPatientInfo.SuspendLayout();
            this.tpPrescriptionInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(322, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 29);
            this.label1.TabIndex = 74;
            this.label1.Text = "Add New Prescription";
            // 
            // tbPatientInfo
            // 
            this.tbPatientInfo.Controls.Add(this.tabPage1);
            this.tbPatientInfo.Controls.Add(this.tpPrescriptionInfo);
            this.tbPatientInfo.Location = new System.Drawing.Point(29, 66);
            this.tbPatientInfo.Name = "tbPatientInfo";
            this.tbPatientInfo.SelectedIndex = 0;
            this.tbPatientInfo.Size = new System.Drawing.Size(804, 537);
            this.tbPatientInfo.TabIndex = 75;
            // 
            // tpPrescriptionInfo
            // 
            this.tpPrescriptionInfo.Controls.Add(this.btnNext);
            this.tpPrescriptionInfo.Controls.Add(this.lblPatientID);
            this.tpPrescriptionInfo.Controls.Add(this.label4);
            this.tpPrescriptionInfo.Location = new System.Drawing.Point(4, 25);
            this.tpPrescriptionInfo.Name = "tpPrescriptionInfo";
            this.tpPrescriptionInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPrescriptionInfo.Size = new System.Drawing.Size(796, 508);
            this.tpPrescriptionInfo.TabIndex = 1;
            this.tpPrescriptionInfo.Text = "Prescription Info";
            this.tpPrescriptionInfo.UseVisualStyleBackColor = true;
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.Location = new System.Drawing.Point(353, 244);
            this.lblPatientID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(48, 25);
            this.lblPatientID.TabIndex = 41;
            this.lblPatientID.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(199, 244);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "PatientID:";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(643, 335);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(121, 78);
            this.btnNext.TabIndex = 76;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
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
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(653, 611);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 78);
            this.btnSave.TabIndex = 78;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(796, 508);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "MedicalRecord Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // frmAddEditPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 693);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbPatientInfo);
            this.Controls.Add(this.label1);
            this.Name = "frmAddEditPrescription";
            this.Text = "frmAddEditPrescription";
            this.tbPatientInfo.ResumeLayout(false);
            this.tpPrescriptionInfo.ResumeLayout(false);
            this.tpPrescriptionInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tbPatientInfo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tpPrescriptionInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}