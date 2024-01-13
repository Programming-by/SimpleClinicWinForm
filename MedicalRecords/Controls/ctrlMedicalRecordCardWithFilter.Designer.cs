namespace SimpleClinicWinForm.MedicalRecords.Controls
{
    partial class ctrlMedicalRecordCardWithFilter
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMedicalRecord = new System.Windows.Forms.TextBox();
            this.btnFindMedicalRecord = new System.Windows.Forms.Button();
            this.ctrlMedicalRecordCard1 = new SimpleClinicWinForm.MedicalRecords.Controls.ctrlMedicalRecordCard();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "MedicalRecordID:";
            // 
            // txtMedicalRecord
            // 
            this.txtMedicalRecord.Location = new System.Drawing.Point(179, 36);
            this.txtMedicalRecord.Multiline = true;
            this.txtMedicalRecord.Name = "txtMedicalRecord";
            this.txtMedicalRecord.Size = new System.Drawing.Size(276, 30);
            this.txtMedicalRecord.TabIndex = 2;
            this.txtMedicalRecord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMedicalRecord_KeyPress);
            // 
            // btnFindMedicalRecord
            // 
            this.btnFindMedicalRecord.Location = new System.Drawing.Point(474, 22);
            this.btnFindMedicalRecord.Name = "btnFindMedicalRecord";
            this.btnFindMedicalRecord.Size = new System.Drawing.Size(101, 51);
            this.btnFindMedicalRecord.TabIndex = 3;
            this.btnFindMedicalRecord.Text = "Find";
            this.btnFindMedicalRecord.UseVisualStyleBackColor = true;
            this.btnFindMedicalRecord.Click += new System.EventHandler(this.btnFindMedicalRecord_Click);
            // 
            // ctrlMedicalRecordCard1
            // 
            this.ctrlMedicalRecordCard1.Location = new System.Drawing.Point(22, 62);
            this.ctrlMedicalRecordCard1.Name = "ctrlMedicalRecordCard1";
            this.ctrlMedicalRecordCard1.Size = new System.Drawing.Size(612, 285);
            this.ctrlMedicalRecordCard1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(581, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 51);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Controls.Add(this.btnAdd);
            this.gbFilter.Controls.Add(this.txtMedicalRecord);
            this.gbFilter.Controls.Add(this.btnFindMedicalRecord);
            this.gbFilter.Location = new System.Drawing.Point(42, 3);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(693, 82);
            this.gbFilter.TabIndex = 5;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // ctrlMedicalRecordCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.ctrlMedicalRecordCard1);
            this.Name = "ctrlMedicalRecordCardWithFilter";
            this.Size = new System.Drawing.Size(735, 362);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlMedicalRecordCard ctrlMedicalRecordCard1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMedicalRecord;
        private System.Windows.Forms.Button btnFindMedicalRecord;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbFilter;
    }
}
