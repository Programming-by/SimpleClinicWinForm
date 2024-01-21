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
    public partial class frmRescheduleAppointment : Form
    {
        clsAppointments _Appointment;

        public frmRescheduleAppointment()
        {
            InitializeComponent();
        }

        private void btnScheduleNewAppointment_Click(object sender, EventArgs e)
        {
            _Appointment = clsAppointments.Find(ctrlAppointmentInfoWithFilter1.AppointmentID);

            if (_Appointment == null )
            {
                MessageBox.Show("Appointment is not found");
                return;
            }



          if ( _Appointment.Reschedule(dateTimePickerAppointmentDate.Value))
            {
                MessageBox.Show("Appointment rescheduled","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                lblAppointmentID.Text = _Appointment.AppointmentID.ToString();
                btnScheduleNewAppointment.Enabled = false;
            }

        }

        private void frmRescheduleAppointment_Load(object sender, EventArgs e)
        {
            lblAppointmentStatus.Text = clsAppointments.enAppointmentStatus.Pending.ToString();
        }

        private void ctrlAppointmentInfoWithFilter1_OnAppointmentSelected(int obj)
        {
            _Appointment = clsAppointments.Find(obj);

            if (_Appointment != null)
            {
                if (_Appointment.AppointmentStatus == clsAppointments.enAppointmentStatus.Canceled ||
                 _Appointment.AppointmentStatus == clsAppointments.enAppointmentStatus.Completed
                 )
                {
                    MessageBox.Show("Appointment is Canceled Or Completed", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
