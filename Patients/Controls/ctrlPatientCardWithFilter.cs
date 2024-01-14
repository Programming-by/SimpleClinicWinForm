using SimpleClinicBusinessLayer;
using SimpleClinicWinForm.Doctors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClinicWinForm.Patients.Controls
{
    public partial class ctrlPatientCardWithFilter : UserControl
    {

        private bool _FilterEnabled = true;

        public bool FilterEnabled
        {
            get { return _FilterEnabled; }
            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;
            }
        }

        public int PatientID
        {
            get { return ctrlPatientCard1.PatientID; }
        }

        public clsPatients SelectedPatientInfo
        {
             get { return ctrlPatientCard1.SelectedPatientInfo; }
        }
        public ctrlPatientCardWithFilter()
        {
            InitializeComponent();
        }

        public void LoadPatientInfo(int PatientID)
        {
            txtPatientID.Text = PatientID.ToString();
            ctrlPatientCard1.LoadPatientInfo(PatientID);
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("must fill all required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrlPatientCard1.LoadPatientInfo(int.Parse(txtPatientID.Text));
        }
       
        private void DataBackEvent(object sender , int PatientID)
        {
            txtPatientID.Text = PatientID.ToString();
            ctrlPatientCard1.LoadPatientInfo(PatientID);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditPatient frm = new frmAddEditPatient();

            frm.DataBack += DataBackEvent;

            frm.ShowDialog();
        }
        private void txtPatientID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPatientID.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPatientID, "this field is required");
            }
            else
                errorProvider1.SetError(txtPatientID, "");
        }
    
        private void txtPatientID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ctrlPatientCardWithFilter_Load(object sender, EventArgs e)
        {

        }
    }
}
