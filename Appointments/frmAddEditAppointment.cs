using SimpleClinicBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClinicWinForm.Appointments
{
    public partial class frmAddEditAppointment : Form
    {
        clsAppointments _Appointment;
        public enum enMode { AddNew = 0 , Update = 1 }

        enMode _Mode;
        public frmAddEditAppointment()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _ResetDefaultValues()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Appointment";
                this.Text = lblTitle.Text;
                _Appointment = new clsAppointments();
            } else
            {
                lblTitle.Text = "Update Appointment";
                this.Text = lblTitle.Text;
            }

            dateTimePickerAppointmentDate.MinDate = DateTime.Now;
            lblAppointmentStatus.Text = clsAppointments.enAppointmentStatus.Pending.ToString();
            tpDoctorInfo.Enabled = false;
            tpMedicalRecordInfo.Enabled = false;
            tpPaymentInfo.Enabled = false;
            tpAppointmentInfo.Enabled = false;
        }
        private void _LoadData()
        {

        }
        private void frmAddEditAppointment_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (_Mode == enMode.Update)
                _LoadData();
        }
        private void btnNextToDoctor_Click(object sender, EventArgs e)
        {
            if (ctrlPatientCardWithFilter1.PatientID != -1)
            {
                tpDoctorInfo.Enabled = true;
                tbAppointmentInfo.SelectedTab = tbAppointmentInfo.TabPages["tpDoctorInfo"];
            }
            else
                MessageBox.Show("Please Select Patient","Not allowed",MessageBoxButtons.OK,MessageBoxIcon.Error);
            
        }

        private void btnNextToMedicalRecord_Click(object sender, EventArgs e)
        {
            if (ctrlDoctorCardWithFilter1.DoctorID != -1)
            {
                tpMedicalRecordInfo.Enabled = true;
                tbAppointmentInfo.SelectedTab = tbAppointmentInfo.TabPages["tpMedicalRecordInfo"];
            }
            else
                MessageBox.Show("Please Select a Doctor", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnNextToPayment_Click(object sender, EventArgs e)
        {
                tpPaymentInfo.Enabled = true;
                tbAppointmentInfo.SelectedTab = tbAppointmentInfo.TabPages["tpPaymentInfo"];
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            tpAppointmentInfo.Enabled = true;
            tbAppointmentInfo.SelectedTab = tbAppointmentInfo.TabPages["tpAppointmentInfo"];

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Appointment.PatientID = ctrlPatientCardWithFilter1.PatientID;
            _Appointment.DoctorID = ctrlDoctorCardWithFilter1.DoctorID;
            _Appointment.AppointmentDateTime = dateTimePickerAppointmentDate.Value;
            _Appointment.AppointmentStatus = clsAppointments.enAppointmentStatus.Pending;
            if (ctrlMedicalRecordCardWithFilter1.MedicalRecordID == -1)
                _Appointment.MedicalRecordID = null;
            else
            _Appointment.MedicalRecordID = ctrlMedicalRecordCardWithFilter1.MedicalRecordID;
            if (ctrlPaymentCardWithFilter1.PaymentID == -1)
                _Appointment.PaymentID = null;
            else
                _Appointment.PaymentID = ctrlPaymentCardWithFilter1.PaymentID;

            if (_Appointment.Save())
            {
                lblAppointmentID.Text = _Appointment.AppointmentID.ToString();
                this.Text = "Update Appointment";
                _Mode = enMode.Update;
                MessageBox.Show("Data Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
                MessageBox.Show("Failed to save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
