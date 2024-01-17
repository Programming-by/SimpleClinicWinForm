namespace SimpleClinicWinForm.Appointments
{
    partial class frmShowAppointmentInfo
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
            this.ctrlAppointmentInfo1 = new SimpleClinicWinForm.Appointments.Controls.ctrlAppointmentInfo();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(310, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 29);
            this.label1.TabIndex = 65;
            this.label1.Text = "Appointment Details";
            // 
            // ctrlAppointmentInfo1
            // 
            this.ctrlAppointmentInfo1.Location = new System.Drawing.Point(12, 85);
            this.ctrlAppointmentInfo1.Name = "ctrlAppointmentInfo1";
            this.ctrlAppointmentInfo1.Size = new System.Drawing.Size(862, 353);
            this.ctrlAppointmentInfo1.TabIndex = 66;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(652, 445);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(202, 62);
            this.btnClose.TabIndex = 67;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmShowAppointmentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 519);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlAppointmentInfo1);
            this.Controls.Add(this.label1);
            this.Name = "frmShowAppointmentInfo";
            this.Text = "frmShowAppointmentInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Controls.ctrlAppointmentInfo ctrlAppointmentInfo1;
        private System.Windows.Forms.Button btnClose;
    }
}