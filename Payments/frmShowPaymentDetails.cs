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
    public partial class frmShowPaymentDetails : Form
    {
        public frmShowPaymentDetails(int PaymentID)
        {
            InitializeComponent();
            ctrlPaymentCard1.LoadPaymentInfo(PaymentID);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
