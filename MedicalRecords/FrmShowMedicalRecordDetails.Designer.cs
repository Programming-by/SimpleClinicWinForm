namespace SimpleClinicWinForm.MedicalRecords
{
    partial class FrmShowMedicalRecordDetails
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
            this.ctrlMedicalRecordCard1 = new SimpleClinicWinForm.MedicalRecords.Controls.ctrlMedicalRecordCard();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(180, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 29);
            this.label1.TabIndex = 47;
            this.label1.Text = "Medical Record Details";
            // 
            // ctrlMedicalRecordCard1
            // 
            this.ctrlMedicalRecordCard1.Location = new System.Drawing.Point(41, 89);
            this.ctrlMedicalRecordCard1.Name = "ctrlMedicalRecordCard1";
            this.ctrlMedicalRecordCard1.Size = new System.Drawing.Size(565, 285);
            this.ctrlMedicalRecordCard1.TabIndex = 48;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(463, 365);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 47);
            this.btnClose.TabIndex = 52;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmShowMedicalRecordDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlMedicalRecordCard1);
            this.Controls.Add(this.label1);
            this.Name = "FrmShowMedicalRecordDetails";
            this.Text = "FrmShowMedicalRecordDetails";
            this.Load += new System.EventHandler(this.FrmShowMedicalRecordDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Controls.ctrlMedicalRecordCard ctrlMedicalRecordCard1;
        private System.Windows.Forms.Button btnClose;
    }
}