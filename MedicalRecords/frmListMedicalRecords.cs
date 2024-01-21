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

namespace SimpleClinicWinForm.MedicalRecords
{
    public partial class frmListMedicalRecords : Form
    {
        private DataTable _dtRecords;
        public frmListMedicalRecords()
        {
            InitializeComponent();
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
                case "MedicalRecordID":
                    FilterColumn = "MedicalRecordID";
                    break;
                    
                default:
                case "None":
                    break;
            }

            if (txtFilter1.Text.Trim() == "" || cbFilters.Text.Trim() == "None")
            {
                _dtRecords.DefaultView.RowFilter = "";
                lblMedicalRecordCount.Text = dgvMedicalRecords.Rows.Count.ToString();
                return;
            }

            if (cbFilters.Text == "MedicalRecordID")
                _dtRecords.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter1.Text);

            lblMedicalRecordCount.Text = dgvMedicalRecords.Rows.Count.ToString();
        }

        private void btnAddNewMedicalRecord_Click(object sender, EventArgs e)
        {
            frmAddEditMedicalRecord frm = new frmAddEditMedicalRecord();
            frm.ShowDialog();
            frmListMedicalRecords_Load(null,null);
        }

        private void txtFilter1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilters.Text == "MedicalRecordID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void frmListMedicalRecords_Load(object sender, EventArgs e)
        {

            cbFilters.SelectedIndex = 0;
            _dtRecords = clsMedicalRecords.GetAllMedicalRecords();
            dgvMedicalRecords.DataSource = _dtRecords;
            lblMedicalRecordCount.Text = dgvMedicalRecords.Rows.Count.ToString();

            if (dgvMedicalRecords.Rows.Count > 0)
            {
                dgvMedicalRecords.Columns[0].HeaderText = "Medical Record ID";
                dgvMedicalRecords.Columns[0].Width = 110;

                dgvMedicalRecords.Columns[1].HeaderText = "Visit Description";
                dgvMedicalRecords.Columns[1].Width = 160;

                dgvMedicalRecords.Columns[2].HeaderText = "Diagnosis";
                dgvMedicalRecords.Columns[2].Width = 160;

                dgvMedicalRecords.Columns[3].HeaderText = "Additional Notes";
                dgvMedicalRecords.Columns[3].Width = 160;

            }
        }

        private void addNewRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditMedicalRecord frm = new frmAddEditMedicalRecord();

            frm.ShowDialog();

            frmListMedicalRecords_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditMedicalRecord frm = new frmAddEditMedicalRecord((int)dgvMedicalRecords.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListMedicalRecords_Load(null, null);
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (clsMedicalRecords.DeleteMedicalRecords((int)dgvMedicalRecords.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Record Deleted Successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmListMedicalRecords_Load(null, null);
            }
            else
                MessageBox.Show("Failed to Delete this Record", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void showMedicalRecordDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowMedicalRecordDetails frm = new FrmShowMedicalRecordDetails((int)dgvMedicalRecords.CurrentRow.Cells[0].Value);

            frm.ShowDialog();
        }

        private void dgvMedicalRecords_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmShowMedicalRecordDetails frm = new FrmShowMedicalRecordDetails((int)dgvMedicalRecords.CurrentRow.Cells[0].Value);

            frm.ShowDialog();
        }
    }
}
