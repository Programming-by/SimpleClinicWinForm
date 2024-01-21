using SimpleClinicBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClinicWinForm.Appointments
{
    public partial class frmListAppointments : Form
    {
        public frmListAppointments()
        {
            InitializeComponent();
        }

        private DataTable _dtAppointments;
        private void frmListAppointments_Load(object sender, EventArgs e)
        {
            cbFilters.SelectedIndex = 0;
            _dtAppointments = clsAppointments.GetAllAppointments();
            dgvAppointments.DataSource = _dtAppointments;
            lblAppointmentCount.Text = dgvAppointments.Rows.Count.ToString();

            if (dgvAppointments.Rows.Count > 0)
            {
                dgvAppointments.Columns[0].HeaderText = "Appointment ID";
                dgvAppointments.Columns[0].Width = 110;

                dgvAppointments.Columns[1].HeaderText = "Patient Name";
                dgvAppointments.Columns[1].Width = 140;

                dgvAppointments.Columns[2].HeaderText = "Doctor Name";
                dgvAppointments.Columns[2].Width = 140;

                dgvAppointments.Columns[3].HeaderText = "Specialization";
                dgvAppointments.Columns[3].Width = 140;

                dgvAppointments.Columns[4].HeaderText = "Appointment Date Time";
                dgvAppointments.Columns[4].Width = 140;

                dgvAppointments.Columns[5].HeaderText = "Appointment Status";
                dgvAppointments.Columns[5].Width = 160;

                dgvAppointments.Columns[6].HeaderText = "Diagnosis";
                dgvAppointments.Columns[6].Width = 160;

                dgvAppointments.Columns[7].HeaderText = "Payment Date";
                dgvAppointments.Columns[7].Width = 160;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter1.Visible = (cbFilters.Text != "None");

            txtFilter1.Text = "";
            txtFilter1.Focus();
        }

        private void txtFilter1_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbFilters.Text)
            {

                case "PrescriptionID":
                    FilterColumn = "PrescriptionID";
                    break;
                 case "Patient Name":
                    FilterColumn = "PatientName";
              break;
                case "Doctor Name":
                    FilterColumn = "DoctorName";
                    break;
                  case "Appointment Status":
                    FilterColumn = "AppointmentStatus";
            break;
                  case "Diagnosis":
                    FilterColumn = "Diagnosis";
            break;
            default:
                case "None":
                    break;
            }

            if (txtFilter1.Text.Trim() == "" || cbFilters.Text.Trim() == "None")
            {
                _dtAppointments.DefaultView.RowFilter = "";
                lblAppointmentCount.Text = dgvAppointments.Rows.Count.ToString();
                return;
            }

            if (cbFilters.Text == "AppointmentID")
                _dtAppointments.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter1.Text);
            else
                _dtAppointments.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter1.Text);
            lblAppointmentCount.Text = dgvAppointments.Rows.Count.ToString();
        }

        private void txtFilter1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilters.Text == "AppointmentID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this appointment?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (clsAppointments.DeleteAppointments((int)dgvAppointments.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Appointment Deleted Successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmListAppointments_Load(null, null);
            }
            else
                MessageBox.Show("Failed to Delete this Appointment", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAddNewPayment_Click(object sender, EventArgs e)
        {
            frmAddEditAppointment frm = new frmAddEditAppointment();

            frm.ShowDialog();

            frmListAppointments_Load(null, null);

        }
        private void addNewAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditAppointment frm = new frmAddEditAppointment();

            frm.ShowDialog();

            frmListAppointments_Load(null, null);
        }


        private void btnAddNewAppointment_Click(object sender, EventArgs e)
        {
            frmAddEditAppointment frm = new frmAddEditAppointment();

            frm.ShowDialog();

            frmListAppointments_Load(null, null);
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditAppointment frm = new frmAddEditAppointment((int)dgvAppointments.CurrentRow.Cells[0].Value);

            frm.ShowDialog();

            frmListAppointments_Load(null, null);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            string AppointmentStatus = (string) dgvAppointments.CurrentRow.Cells[5].Value;
            cancelAppointmentToolStripMenuItem.Enabled = (AppointmentStatus == "Pending");
            confirmAppointmentToolStripMenuItem.Enabled = (AppointmentStatus == "Pending");
            completeAppointmentToolStripMenuItem.Enabled = (AppointmentStatus == "Pending");

        }

        private void cancelAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to cancel this appointment?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int AppointmentID = (int)dgvAppointments.CurrentRow.Cells[0].Value;
            clsAppointments _Appointment = clsAppointments.Find(AppointmentID);

            if (_Appointment != null)
            {
            if (_Appointment.Cancel())
            {
                MessageBox.Show("Appointment has been canceled","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                frmListAppointments_Load(null, null);
            } else
            {
                MessageBox.Show("Appointment failed to be canceled", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }

        }

        private void confirmAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to confirm this appointment?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int AppointmentID = (int)dgvAppointments.CurrentRow.Cells[0].Value;
            clsAppointments _Appointment = clsAppointments.Find(AppointmentID);

            if (_Appointment != null)
            {
                if (_Appointment.Confirm())
                {
                    MessageBox.Show("Appointment has been confirmed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmListAppointments_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Appointment failed to be confirmed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void completeAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to complete this appointment?", "Complete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int AppointmentID = (int)dgvAppointments.CurrentRow.Cells[0].Value;
            clsAppointments _Appointment = clsAppointments.Find(AppointmentID);

            if (_Appointment != null)
            {
                if (_Appointment.SetComplete())
                {
                    MessageBox.Show("Appointment has been completed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmListAppointments_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Appointment failed to be complete", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
