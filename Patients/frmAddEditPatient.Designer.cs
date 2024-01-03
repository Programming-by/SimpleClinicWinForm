namespace SimpleClinicWinForm.Patients
{
    partial class frmAddEditPatient
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
            this.tbPatientInfo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ctrlPersonCardWithFilter1 = new SimpleClinicWinForm.People.Controls.ctrlPersonCardWithFilter();
            this.btnNext = new System.Windows.Forms.Button();
            this.tpPatientInfo = new System.Windows.Forms.TabPage();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbPatientInfo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tpPatientInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTitle.Location = new System.Drawing.Point(350, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(192, 29);
            this.lblTitle.TabIndex = 40;
            this.lblTitle.Text = "Add New Patient";
            // 
            // tbPatientInfo
            // 
            this.tbPatientInfo.Controls.Add(this.tabPage1);
            this.tbPatientInfo.Controls.Add(this.tpPatientInfo);
            this.tbPatientInfo.Location = new System.Drawing.Point(12, 66);
            this.tbPatientInfo.Name = "tbPatientInfo";
            this.tbPatientInfo.SelectedIndex = 0;
            this.tbPatientInfo.Size = new System.Drawing.Size(804, 537);
            this.tbPatientInfo.TabIndex = 41;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(796, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Person Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(6, 2);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(736, 384);
            this.ctrlPersonCardWithFilter1.TabIndex = 52;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(510, 394);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(121, 78);
            this.btnNext.TabIndex = 51;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tpPatientInfo
            // 
            this.tpPatientInfo.Controls.Add(this.lblPatientID);
            this.tpPatientInfo.Controls.Add(this.label4);
            this.tpPatientInfo.Location = new System.Drawing.Point(4, 25);
            this.tpPatientInfo.Name = "tpPatientInfo";
            this.tpPatientInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPatientInfo.Size = new System.Drawing.Size(796, 508);
            this.tpPatientInfo.TabIndex = 1;
            this.tpPatientInfo.Text = "Patient Info";
            this.tpPatientInfo.UseVisualStyleBackColor = true;
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
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(406, 611);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 78);
            this.btnClose.TabIndex = 51;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(635, 611);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 78);
            this.btnSave.TabIndex = 52;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddEditPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 743);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbPatientInfo);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmAddEditPatient";
            this.Text = "frmAddEditPatient";
            this.Load += new System.EventHandler(this.frmAddEditPatient_Load);
            this.tbPatientInfo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tpPatientInfo.ResumeLayout(false);
            this.tpPatientInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tbPatientInfo;
        private System.Windows.Forms.TabPage tabPage1;
        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TabPage tpPatientInfo;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}