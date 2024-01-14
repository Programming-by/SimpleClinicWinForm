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

namespace SimpleClinicWinForm.Payments.Controls
{
    public partial class ctrlPaymentCard : UserControl
    {
        private clsPayments _Payment;

        public clsPayments SelectedPaymentInfo
        {
            get { return _Payment; }
        }

        private int? _PaymentID;
        public int? PaymentID
        {
            get { return _PaymentID; }
        }
        public ctrlPaymentCard()
        {
            InitializeComponent();
        }

        public void LoadPaymentInfo(int? PaymentID)
        {
            _Payment = clsPayments.Find(PaymentID);

            if (_Payment == null)
            {
                MessageBox.Show("Payment is not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _PaymentID = PaymentID;
            lblPaymentID.Text = _Payment.PaymentID.ToString();
            lblPaymentDate.Text = _Payment.PaymentDate.ToString();
            lblPaymentMethod.Text = _Payment.PaymentMethod;
            lblAmountPaid.Text = _Payment.AmountPaid.ToString();
            lblAdditionalDetails.Text = _Payment.AdditionalNotes;
        }
    }
}
