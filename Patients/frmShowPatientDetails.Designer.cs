﻿namespace SimpleClinicWinForm.Patients
{
    partial class frmShowPatientDetails
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
            this.ctrlPatientCard1 = new SimpleClinicWinForm.Patients.Controls.ctrlPatientCard();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(296, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 29);
            this.label1.TabIndex = 39;
            this.label1.Text = "Patient Details";
            // 
            // ctrlPatientCard1
            // 
            this.ctrlPatientCard1.Location = new System.Drawing.Point(12, 86);
            this.ctrlPatientCard1.Name = "ctrlPatientCard1";
            this.ctrlPatientCard1.Size = new System.Drawing.Size(733, 352);
            this.ctrlPatientCard1.TabIndex = 40;
            // 
            // frmShowPatientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 440);
            this.Controls.Add(this.ctrlPatientCard1);
            this.Controls.Add(this.label1);
            this.Name = "frmShowPatientDetails";
            this.Text = "frmShowPatientDetails";
            this.Load += new System.EventHandler(this.frmShowPatientDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Controls.ctrlPatientCard ctrlPatientCard1;
    }
}