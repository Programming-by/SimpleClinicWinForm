using SimpleClinicBusinessLayer;
using SimpleClinicWinForm.Appointments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClinicWinForm.Patients.Controls
{
    public partial class ctrlPatientAppointments : UserControl
    {

        int _PatientID;

        clsAppointments _Appointment;

        clsPatients _Patient;
        public ctrlPatientAppointments()
        {
            InitializeComponent();
        }

        private DataTable _dtPatientAppointments;
         private void _LoadPatientAppointment()
        {
            _dtPatientAppointments = clsPatients.GetAppointments(_PatientID);
            dgvPatients.DataSource = _dtPatientAppointments;
            lblPatientsCount.Text =  _dtPatientAppointments.Rows.Count.ToString();

            if (_dtPatientAppointments.Rows.Count > 0 )
            {
                dgvPatients.Columns[0].HeaderText = "Appointment ID";
                dgvPatients.Columns[0].Width = 110;

                dgvPatients.Columns[1].HeaderText = "Patient Name";
                dgvPatients.Columns[1].Width = 160;

                dgvPatients.Columns[2].HeaderText = "Doctor Name";
                dgvPatients.Columns[2].Width = 160;

                dgvPatients.Columns[3].HeaderText = "Specialization";
                dgvPatients.Columns[3].Width = 150;

                dgvPatients.Columns[4].HeaderText = "Appointment Date Time";
                dgvPatients.Columns[4].Width = 160;

                dgvPatients.Columns[5].HeaderText = "Appointment Status";
                dgvPatients.Columns[5].Width = 140;

                dgvPatients.Columns[6].HeaderText = "Diagnosis";
                dgvPatients.Columns[6].Width = 150;


                dgvPatients.Columns[7].HeaderText = "Additional Notes";
                dgvPatients.Columns[7].Width = 160;


                dgvPatients.Columns[8].HeaderText = "Payment Date";
                dgvPatients.Columns[8].Width = 140;
            }


        }
        public void LoadInfo(int PatientID) 
        {
            _PatientID = PatientID;
             _Patient = clsPatients.Find(_PatientID);

            if (_Patient == null)
            {
                MessageBox.Show("There is no Patient ID With id " + _Patient.PatientID);
                return;
            }

            _LoadPatientAppointment();
        }

        public void LoadInfoByPersonID(int PersonID)
        {
            _Patient = clsPatients.FindByPersonID(PersonID);

            if (_Patient == null)
            {
                MessageBox.Show("There is no Patient ID With id " + PersonID);
                return;
            }

            _PatientID = _Patient.PatientID;
            _LoadPatientAppointment();
        }

        private void showAppointmentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowAppointmentInfo frm = new frmShowAppointmentInfo((int)dgvPatients.CurrentRow.Cells[0].Value);

            frm.ShowDialog();
            
        }
    }
}
