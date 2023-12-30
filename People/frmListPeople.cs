using SimpleClinicBusinessLayer;
using SimpleClinicWinForm.People.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClinicWinForm.People
{
    public partial class frmListPeople : Form
    {
        public frmListPeople()
        {
            InitializeComponent();
        }

        private DataTable _dtPeople;

        private void frmListPeople_Load(object sender, EventArgs e)
        {
            cbFilters.SelectedIndex = 0;
            _dtPeople = clsPersons.GetAllPersons();
            dgvPeople.DataSource = _dtPeople;
            lblPeopleCount.Text = dgvPeople.Rows.Count.ToString();

            if (dgvPeople.Rows.Count > 0)
            {
                dgvPeople.Columns[0].HeaderText = "Person ID";
                dgvPeople.Columns[0].Width = 110;

                dgvPeople.Columns[1].HeaderText = "Name";
                dgvPeople.Columns[1].Width = 150;


                dgvPeople.Columns[2].HeaderText = "Date Of Birth";
                dgvPeople.Columns[2].Width = 140;


                dgvPeople.Columns[3].HeaderText = "Gender";
                dgvPeople.Columns[3].Width = 120;

                dgvPeople.Columns[4].HeaderText = "PhoneNumber";
                dgvPeople.Columns[4].Width = 120;

                dgvPeople.Columns[5].HeaderText = "Email";
                dgvPeople.Columns[5].Width = 140;

                dgvPeople.Columns[6].HeaderText = "Address";
                dgvPeople.Columns[6].Width = 140;

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
            switch(cbFilters.Text)
            {
                case "PersonID":
                    FilterColumn = "PersonID";
                    break;
                case "Name":
                    FilterColumn = "Name";
                    break;
                case "Gender":
                    FilterColumn = "Gender";
                    break;
                case "PhoneNumber":
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
                _dtPeople.DefaultView.RowFilter = "";
                lblPeopleCount.Text = dgvPeople.Rows.Count.ToString();
                return;
            }

            if (cbFilters.Text == "PersonID")
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}",FilterColumn, txtFilter1.Text) ;
            else
                _dtPeople.DefaultView.RowFilter = string.Format("{0} Like '{1}%'", FilterColumn, txtFilter1.Text);

            lblPeopleCount.Text = dgvPeople.Rows.Count.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddNewPerson frm = new frmAddNewPerson();

            frm.ShowDialog();

            frmListPeople_Load(null, null);

        }
        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewPerson frm = new frmAddNewPerson();

            frm.ShowDialog();

            frmListPeople_Load(null, null);
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewPerson frm = new frmAddNewPerson((int)dgvPeople.CurrentRow.Cells[0].Value);

            frm.ShowDialog();

            frmListPeople_Load(null, null);
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this person", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (clsPersons.DeletePersons((int)dgvPeople.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Person Deleted Successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmListPeople_Load(null, null); 
            } else
                MessageBox.Show("Failed to Delete this Person", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersonDetails frm = new frmShowPersonDetails((int)dgvPeople.CurrentRow.Cells[0].Value);

            frm.ShowDialog();
        }

        private void dgvPeople_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmShowPersonDetails frm = new frmShowPersonDetails((int)dgvPeople.CurrentRow.Cells[0].Value);

            frm.ShowDialog();
        }

        private void txtFilter1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilters.Text == "PersonID")
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
