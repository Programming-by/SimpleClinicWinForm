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

namespace SimpleClinicWinForm.MedicalRecords.Controls
{
    public partial class ctrlMedicalRecordCardWithFilter : UserControl
    {
        private bool _FilterEnabled = true;

        public bool FilterEnabled
        {
            get { return _FilterEnabled; }
            set {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;
               }
        }
        public int? MedicalRecordID
        {
            get { return ctrlMedicalRecordCard1.MedicalRecordID; }
        }

        public clsMedicalRecords SelectedMedicalRecordInfo
        {
            get { return ctrlMedicalRecordCard1.SelectedMedicalRecord; }
        }
        public ctrlMedicalRecordCardWithFilter()
        {
            InitializeComponent();
        }

        public void LoadMedicalRecordInfo(int PrescriptionID)
        {
            ctrlMedicalRecordCard1.LoadMedicalRecordInfo(PrescriptionID);
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

        }
    }
}
