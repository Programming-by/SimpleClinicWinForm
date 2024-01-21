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

namespace SimpleClinicWinForm.Appointments.Controls
{
    public partial class ctrlAppointmentInfo : UserControl
    {

        clsAppointments _Appointment;

        public clsAppointments SelectedAppointmentInfo
        {
            get { return _Appointment; }
        }

        private int _AppointmentID = -1;

        public int AppointmentID
        {
            get { return _AppointmentID; } 
        }
        public ctrlAppointmentInfo()
        {
            InitializeComponent();
        }


        public void LoadAppointmentInfo(int AppointmentID)
        {
            _Appointment = clsAppointments.Find(AppointmentID);

            if (_Appointment == null)
            {
                MessageBox.Show("Appointment is not found");
                return;
            }
            _AppointmentID = AppointmentID;

       
            lblAppointmentID.Text = _Appointment.AppointmentID.ToString();
            lblPatientName.Text = _Appointment.PatientInfo.PersonInfo.Name;
            lblDoctorName.Text = _Appointment.DoctorInfo.PersonInfo.Name;
            lblSpecialization.Text = _Appointment.DoctorInfo.Specialization;
            lblAppointmentDateTime.Text = _Appointment.AppointmentDateTime.ToString();
            lblAppointmentStatus.Text = _Appointment.AppointmentStatus.ToString();
            if (_Appointment.MedicalRecordID.HasValue)
                lblDiagnosis.Text = _Appointment.MedicalRecordInfo.Diagnosis;
            if (_Appointment.MedicalRecordID.HasValue)
                lblAdditionalNotes.Text = _Appointment.MedicalRecordInfo.AdditionalNotes;

        }
    }
}
