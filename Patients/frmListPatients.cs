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

namespace SimpleClinicWinForm.Patients
{
    public partial class frmListPatients : Form
    {
        public frmListPatients()
        {
            InitializeComponent();
        }
        private DataTable _dtPatients;
        private void frmListPatients_Load(object sender, EventArgs e)
        {
            cbFilters.SelectedIndex = 0;
            _dtPatients = clsPatients.GetAllPatients();
            dgvPatients.DataSource = _dtPatients;
            lblPatientsCount.Text = dgvPatients.Rows.Count.ToString();

            if (dgvPatients.Rows.Count > 0)
            {
                dgvPatients.Columns[0].HeaderText = "Patient ID";
                dgvPatients.Columns[0].Width = 110;

                dgvPatients.Columns[1].HeaderText = "Patient Name";
                dgvPatients.Columns[1].Width = 150;

                dgvPatients.Columns[2].HeaderText = "Date Of Birth";
                dgvPatients.Columns[2].Width = 140;

                dgvPatients.Columns[3].HeaderText = "Gender";
                dgvPatients.Columns[3].Width = 120;

                dgvPatients.Columns[4].HeaderText = "PhoneNumber";
                dgvPatients.Columns[4].Width = 120;

                dgvPatients.Columns[5].HeaderText = "Email";
                dgvPatients.Columns[5].Width = 140;
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
                case "PatientID":
                    FilterColumn = "PatientID";
                    break;
                case "Patient Name":
                    FilterColumn = "Name";
                    break;
                case "Gender":
                    FilterColumn = "Gender";
                    break;
                case "Phone Number":
                    FilterColumn = "PhoneNumber";
                    break;
                case "Email":
                    FilterColumn = "Email";
                    break;
                default:
                case "None":
                    break;
            }

            if (txtFilter1.Text.Trim() == "" || cbFilters.Text.Trim() == "None")
            {
                _dtPatients.DefaultView.RowFilter = "";
                lblPatientsCount.Text = dgvPatients.Rows.Count.ToString();
                return;
            }

            if (cbFilters.Text == "PatientID")
                _dtPatients.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter1.Text);
            else
                _dtPatients.DefaultView.RowFilter = string.Format("{0} Like '{1}%'", FilterColumn, txtFilter1.Text);

            lblPatientsCount.Text = dgvPatients.Rows.Count.ToString();
    }

        private void txtFilter1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilters.Text == "PatientID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this patient?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (clsPatients.DeletePatients((int)dgvPatients.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Patients Deleted Successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmListPatients_Load(null, null);
            }
            else
                MessageBox.Show("Failed to Delete this Patient", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
