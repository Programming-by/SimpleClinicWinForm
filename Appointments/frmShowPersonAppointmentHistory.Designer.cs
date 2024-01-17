namespace SimpleClinicWinForm.Appointments
{
    partial class frmShowPersonAppointmentHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowPersonAppointmentHistory));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlPersonCardWithFilter1 = new SimpleClinicWinForm.People.Controls.ctrlPersonCardWithFilter();
            this.ctrlPatientAppintments1 = new SimpleClinicWinForm.Patients.Controls.ctrlPatientAppointments();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1045, 853);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 61);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(282, 24);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(736, 436);
            this.ctrlPersonCardWithFilter1.TabIndex = 1;
            // 
            // ctrlPatientAppintments1
            // 
            this.ctrlPatientAppintments1.Location = new System.Drawing.Point(306, 441);
            this.ctrlPatientAppintments1.Name = "ctrlPatientAppintments1";
            this.ctrlPatientAppintments1.Size = new System.Drawing.Size(882, 420);
            this.ctrlPatientAppintments1.TabIndex = 4;
            // 
            // frmShowPersonAppointmentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 926);
            this.Controls.Add(this.ctrlPatientAppintments1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmShowPersonAppointmentHistory";
            this.Text = "frmShowPersonAppointmentHistory";
            this.Load += new System.EventHandler(this.frmShowPersonAppointmentHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.Button btnClose;
        private Patients.Controls.ctrlPatientAppointments ctrlPatientAppintments1;
    }
}