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
    public partial class ctrlPaymentCardWithFilter : UserControl
    {
        public clsPayments SelectedPaymentInfo
        {
            get { return ctrlPaymentCard1.SelectedPaymentInfo; }
        }

        public int? PaymentID
        {
            get { return ctrlPaymentCard1.PaymentID; }
        }
        public ctrlPaymentCardWithFilter()
        {
            InitializeComponent();
        }

        private void txtPaymentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("you must fill all required fields","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ctrlPaymentCard1.LoadPaymentInfo(int.Parse(txtPaymentID.Text));
        }

        public void DataBackEvent(object sender , int? PaymentID)
        {
            txtPaymentID.Text = PaymentID.ToString();
            ctrlPaymentCard1.LoadPaymentInfo(PaymentID);

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditPayment frm = new frmAddEditPayment();

            frm.DataBack += DataBackEvent;

            frm.ShowDialog();
        }
    }
}
