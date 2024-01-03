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

namespace SimpleClinicWinForm.Payments
{
    public partial class frmListPayments : Form
    {
        private DataTable _dtPayments;

        public frmListPayments()
        {
            InitializeComponent();
        }

        private void frmListPayments_Load(object sender, EventArgs e)
        {
            cbFilters.SelectedIndex = 0;
            _dtPayments = clsPayments.GetAllPayments();
            dgvPayments.DataSource = _dtPayments;
            lblPaymentCount.Text = dgvPayments.Rows.Count.ToString();

            if (dgvPayments.Rows.Count > 0)
            {
                dgvPayments.Columns[0].HeaderText = "Payment ID";
                dgvPayments.Columns[0].Width = 110;

                dgvPayments.Columns[1].HeaderText = "Payment Date";
                dgvPayments.Columns[1].Width = 140;

                dgvPayments.Columns[2].HeaderText = "Payment Method";
                dgvPayments.Columns[2].Width = 140;

                dgvPayments.Columns[3].HeaderText = "Amount Paid";
                dgvPayments.Columns[3].Width = 140;

                dgvPayments.Columns[4].HeaderText = "Additional Notes";
                dgvPayments.Columns[4].Width = 160;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewPayment_Click(object sender, EventArgs e)
        {

        }

        private void addNewPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
                case "PaymentID":
                    FilterColumn = "PaymentID";
                    break;
                case "Payment Method":
                    FilterColumn = "PaymentMethod";
                    break;
                default:
                case "None":
                    break;
            }

            if (txtFilter1.Text.Trim() == "" || cbFilters.Text.Trim() == "None")
            {
                _dtPayments.DefaultView.RowFilter = "";
                lblPaymentCount.Text = dgvPayments.Rows.Count.ToString();
                return;
            }

            if (cbFilters.Text == "PaymentID")
                _dtPayments.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter1.Text);
            else 
                _dtPayments.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter1.Text);
            lblPaymentCount.Text = dgvPayments.Rows.Count.ToString();
        }

        private void txtFilter1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilters.Text == "PaymentID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this payment?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (clsPayments.DeletePayments((int)dgvPayments.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Payment Deleted Successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmListPayments_Load(null, null);
            }
            else
                MessageBox.Show("Failed to Delete this Payment", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
