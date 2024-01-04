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
    public partial class frmAddEditPayment : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };

        enMode Mode = enMode.AddNew;

        int _PaymentID;

        clsPayments _Payment;
        public frmAddEditPayment()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }

        public frmAddEditPayment(int PaymentID)
        {
            InitializeComponent();
            _PaymentID = PaymentID;
            Mode = enMode.Update;
        }

        private void _ResetDefaultValues()
        {
            if (Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Payment";
                this.Text = lblTitle.Text;
                _Payment = new clsPayments();
            }
            else
            {
                lblTitle.Text = "Update Payment";
                this.Text = lblTitle.Text;
            }

            dateTimePicker1.MinDate = DateTime.Now.Date;
            cbPaymentMethods.SelectedIndex = 0;
        }

        private void _LoadData()
        {
            _Payment = clsPayments.Find(_PaymentID);

            if (_Payment == null)
            {
                MessageBox.Show("Payment doesn't Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_Payment.PaymentDate >= DateTime.Now.Date)
            {
            dateTimePicker1.Value = _Payment.PaymentDate;
            } else
            {
                dateTimePicker1.Value = DateTime.Now.Date;
            }

            cbPaymentMethods.Text = _Payment.PaymentMethod;
            txtAmountPaid.Text = _Payment.AmountPaid.ToString();
            txtAdditionalNotes.Text = _Payment.AdditionalNotes;

        }
        private void frmAddEditPayment_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (Mode == enMode.Update)
                _LoadData();
        }


        private void txtAmountPaid_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAmountPaid.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAmountPaid, "this field is required");
            } else
                errorProvider1.SetError(txtAmountPaid, "");

        }

        private void txtAmountPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Payment.PaymentDate = dateTimePicker1.Value.Date;
            _Payment.PaymentMethod = cbPaymentMethods.Text;
            _Payment.AmountPaid = decimal.Parse(txtAmountPaid.Text);
            _Payment.AdditionalNotes = txtAdditionalNotes.Text;

            if (_Payment.Save())
            {
                lblPaymentID.Text = _Payment.PaymentID.ToString();
                Mode = enMode.Update;
                lblTitle.Text = "Update Payment";
                this.Text = "Update Payment";
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
