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

namespace SimpleClinicWinForm.Prescriptions
{
    public partial class frmListPrescriptions : Form
    {
        private DataTable _dtPrescriptions;
        public frmListPrescriptions()
        {
            InitializeComponent();
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
                case "Diagnosis":
                    FilterColumn = "Diagnosis";
                    break;
                case "Medication Name":
                    FilterColumn = "MedicationName";
                    break;
                case "Dosage":
                    FilterColumn = "Dosage";
                    break;
                default:
                case "None":
                    break;
            }

            if (txtFilter1.Text.Trim() == "" || cbFilters.Text.Trim() == "None")
            {
                _dtPrescriptions.DefaultView.RowFilter = "";
                lblPrescriptionsCount.Text = dgvPrescriptions.Rows.Count.ToString();
                return;
            }

            if (cbFilters.Text == "PrescriptionID")
                _dtPrescriptions.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter1.Text);
            else
                _dtPrescriptions.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter1.Text);
            lblPrescriptionsCount.Text = dgvPrescriptions.Rows.Count.ToString();
        }

        private void frmListPrescriptions_Load(object sender, EventArgs e)
        {
            cbFilters.SelectedIndex = 0;
            _dtPrescriptions = clsPrescriptions.GetAllPrescriptions();
            dgvPrescriptions.DataSource = _dtPrescriptions;
            lblPrescriptionsCount.Text = dgvPrescriptions.Rows.Count.ToString();

            if (dgvPrescriptions.Rows.Count > 0)
            {
                dgvPrescriptions.Columns[0].HeaderText = "Prescription ID";
                dgvPrescriptions.Columns[0].Width = 110;

                dgvPrescriptions.Columns[1].HeaderText = "Diagnosis";
                dgvPrescriptions.Columns[1].Width = 140;

                dgvPrescriptions.Columns[2].HeaderText = "Medication Name";
                dgvPrescriptions.Columns[2].Width = 160;

                dgvPrescriptions.Columns[3].HeaderText = "Dosage";
                dgvPrescriptions.Columns[3].Width = 140;

                dgvPrescriptions.Columns[4].HeaderText = "Frequency";
                dgvPrescriptions.Columns[4].Width = 120;

                dgvPrescriptions.Columns[5].HeaderText = "Start Date";
                dgvPrescriptions.Columns[5].Width = 160;


                dgvPrescriptions.Columns[6].HeaderText = "End Date";
                dgvPrescriptions.Columns[6].Width = 160;


                dgvPrescriptions.Columns[7].HeaderText = "Special Instructions";
                dgvPrescriptions.Columns[7].Width = 160;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this prescription?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (clsPrescriptions.DeletePrescriptions((int)dgvPrescriptions.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Prescription Deleted Successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmListPrescriptions_Load(null, null);
            }
            else
                MessageBox.Show("Failed to Delete this Prescription", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtFilter1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilters.Text == "PrescriptionID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddNewPrescription_Click(object sender, EventArgs e)
        {
            frmAddEditPrescription frm = new frmAddEditPrescription();
            frm.ShowDialog();
            frmListPrescriptions_Load(null, null);
        }

        private void addNewPrescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditPrescription frm = new frmAddEditPrescription();
            frm.ShowDialog();
            frmListPrescriptions_Load(null, null);
        }

    }
}
