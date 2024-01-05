using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClinicWinForm.MedicalRecords.Controls
{
    public partial class ctrlMedicalRecordCardWithFilter : UserControl
    {

        public int? MedicalRecordID
        {
            get { return ctrlMedicalRecordCard1.MedicalRecordID; }
        }
        public ctrlMedicalRecordCardWithFilter()
        {
            InitializeComponent();
        }

        private void txtMedicalRecord_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnFindMedicalRecord_Click(object sender, EventArgs e)
        {
            ctrlMedicalRecordCard1.LoadMedicalRecordInfo(int.Parse(txtMedicalRecord.Text));
        }

        private void DataBackEvent(object sender , int? MedicalRecordID)
        {
            txtMedicalRecord.Text = MedicalRecordID.ToString();
            ctrlMedicalRecordCard1.LoadMedicalRecordInfo(MedicalRecordID);

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditMedicalRecord frm = new frmAddEditMedicalRecord();

            frm.DataBack += DataBackEvent;
            frm.ShowDialog();
        }

        private void txtMedicalRecord_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMedicalRecord.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtMedicalRecord, "please enter medical record id");
            } else
                errorProvider1.SetError(txtMedicalRecord, "");


        }
    }
}
