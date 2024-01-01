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

namespace SimpleClinicWinForm.Doctors
{
    public partial class frmListDoctors : Form
    {
        public frmListDoctors()
        {
            InitializeComponent();
        }

        private DataTable _dtDoctors;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListDoctors_Load(object sender, EventArgs e)
        {
            cbFilters.SelectedIndex = 0;
            _dtDoctors = clsDoctors.GetAllDoctors();
            dgvDoctors.DataSource = _dtDoctors;
            lblDoctorsCount.Text = dgvDoctors.Rows.Count.ToString();

            if (dgvDoctors.Rows.Count > 0)
            {
                dgvDoctors.Columns[0].HeaderText = "Doctor ID";
                dgvDoctors.Columns[0].Width = 110;

                dgvDoctors.Columns[1].HeaderText = "Doctor Name";
                dgvDoctors.Columns[1].Width = 150;

                dgvDoctors.Columns[2].HeaderText = "Date Of Birth";
                dgvDoctors.Columns[2].Width = 140;

                dgvDoctors.Columns[3].HeaderText = "Gender";
                dgvDoctors.Columns[3].Width = 120;

                dgvDoctors.Columns[4].HeaderText = "PhoneNumber";
                dgvDoctors.Columns[4].Width = 120;

                dgvDoctors.Columns[5].HeaderText = "Email";
                dgvDoctors.Columns[5].Width = 140;
         
            }
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
                case "DoctorID":
                    FilterColumn = "DoctorID";
                    break;
                case "Doctor Name":
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
                _dtDoctors.DefaultView.RowFilter = "";
                lblDoctorsCount.Text = dgvDoctors.Rows.Count.ToString();
                return;
            }

            if (cbFilters.Text == "DoctorID")
                _dtDoctors.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter1.Text);
            else
                _dtDoctors.DefaultView.RowFilter = string.Format("{0} Like '{1}%'", FilterColumn, txtFilter1.Text);

            lblDoctorsCount.Text = dgvDoctors.Rows.Count.ToString();
        }

        private void txtFilter1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilters.Text == "DoctorID")
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this doctor?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (clsDoctors.DeleteDoctors((int)dgvDoctors.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Doctor Deleted Successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmListDoctors_Load(null, null);
            }
            else
                MessageBox.Show("Failed to Delete this Doctor", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddNewDoctor frm = new frmAddNewDoctor();

            frm.ShowDialog();
        }

        private void btnAddNewDoctor_Click(object sender, EventArgs e)
        {
            frmAddNewDoctor frm = new frmAddNewDoctor();

            frm.ShowDialog();
            frmListDoctors_Load(null, null);

        }

        private void addNewDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewDoctor frm = new frmAddNewDoctor();

            frm.ShowDialog();
            frmListDoctors_Load(null, null);


        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewDoctor frm = new frmAddNewDoctor((int)dgvDoctors.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListDoctors_Load(null, null);
        }

        private void showDoctorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowDoctorDetails frm = new frmShowDoctorDetails((int)dgvDoctors.CurrentRow.Cells[0].Value);

            frm.ShowDialog();
        }

        private void dgvDoctors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmShowDoctorDetails frm = new frmShowDoctorDetails((int)dgvDoctors.CurrentRow.Cells[0].Value);

            frm.ShowDialog();
        }
    }
}
