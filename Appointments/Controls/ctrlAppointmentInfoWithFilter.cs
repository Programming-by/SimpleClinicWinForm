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
    public partial class ctrlAppointmentInfoWithFilter : UserControl
    {

        public event Action <int> OnAppointmentSelected;

        protected virtual void AppointmentSelected(int AppointmentID)
        {
            Action<int> handler =  OnAppointmentSelected;

            if (handler != null)
            {
                handler(AppointmentID);
            }
        }
        public clsAppointments Appointment
        {
            get { return ctrlAppointmentInfo1.SelectedAppointmentInfo; }
        }


        public int AppointmentID
        {
            get { return ctrlAppointmentInfo1.AppointmentID; }
        }

        public ctrlAppointmentInfoWithFilter()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            ctrlAppointmentInfo1.LoadAppointmentInfo(int.Parse(txtAppointmentID.Text));
            if (OnAppointmentSelected != null)
                AppointmentSelected(int.Parse(txtAppointmentID.Text));
        }

        private void txtAppointmentID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAppointmentID.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAppointmentID,"this field is required");

            } else
                errorProvider1.SetError(txtAppointmentID,"");
        }

        private void txtAppointmentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
