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

namespace SimpleClinicWinForm.Prescriptions
{
    public partial class frmAddEditPrescription : Form
    {
        public enum enMode { AddNew = 0 , Update = 1 };

        enMode Mode = enMode.AddNew;

        clsPrescriptions _Prescription;

        int _PrescriptionID;
        public frmAddEditPrescription()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }

        public frmAddEditPrescription(int PrescriptionID)
        {

            InitializeComponent();
            _PrescriptionID = PrescriptionID;
            Mode = enMode.Update;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _ResetDefaultValues()
        {
            if (Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Prescription";
                this.Text = lblTitle.Text;
                _Prescription = new clsPrescriptions();
            }
            else
            {
                lblTitle.Text = "Update Prescription";
                this.Text = lblTitle.Text;
            }
            tpPrescriptionInfo.Enabled = false;
           // dateTimePickerStartDate.MinDate = DateTime.Now.AddYears(-5);
            //dateTimePickerEndDate.MinDate = DateTime.Now.AddYears(dateTimePickerStartDate.Value.Date.Year +  5);

        }

        private void _LoadData()
        {
            _Prescription = clsPrescriptions.Find(_PrescriptionID);

            if (_Prescription == null)
            {
                MessageBox.Show("Prescription is not found","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            ctrlMedicalRecordCardWithFilter1.FilterEnabled = false;
            ctrlMedicalRecordCardWithFilter1.LoadMedicalRecordInfo(_PrescriptionID);
            lblPrescriptionID.Text = _Prescription.PrescriptionID.ToString();
            txtMedicationName.Text = _Prescription.MedicationName;
            txtDosage.Text = _Prescription.Dosage;
            txtFrequency.Text = _Prescription.Frequency;
            dateTimePickerStartDate.Value = _Prescription.StartDate;
            dateTimePickerEndDate.Value = _Prescription.EndDate;
            txtSpecialInstructions.Text = _Prescription.SpecialInstructions;


        }
        private void frmAddEditPrescription_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (Mode == enMode.Update)
                _LoadData();
        }
        private void ValidateTextBox(object sender , CancelEventArgs e)
        {
            TextBox Temp = (TextBox) sender;
            if (string.IsNullOrEmpty(Temp.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "this field is required");
                
            } else
            {
                errorProvider1.SetError(Temp, "");

            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {

            if (Mode == enMode.Update)
            {
                tpPrescriptionInfo.Enabled = true;
                tbMedicalRecordInfo.SelectedTab = tbMedicalRecordInfo.TabPages["tpPrescriptionInfo"];
                btnSave.Enabled = true;
                return;
            }

            if (ctrlMedicalRecordCardWithFilter1.MedicalRecordID != -1)
            {
                if (clsPrescriptions.IsPrescriptionsExistByMedicalRecordID(ctrlMedicalRecordCardWithFilter1.MedicalRecordID))
                {
                    MessageBox.Show("this Medical Record is linked with Prescription","Not Allowed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                } else
                {
                tpPrescriptionInfo.Enabled = true;
                tbMedicalRecordInfo.SelectedTab = tbMedicalRecordInfo.TabPages["tpPrescriptionInfo"];
                btnSave.Enabled = true;
                }
                 
            } else
            {
                MessageBox.Show("Please Select Medical Record ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Prescription.MedicalRecordID = ctrlMedicalRecordCardWithFilter1.MedicalRecordID;
            _Prescription.MedicationName = txtMedicationName.Text;
            _Prescription.Dosage = txtDosage.Text;
            _Prescription.Frequency = txtFrequency.Text;
            _Prescription.StartDate = dateTimePickerStartDate.Value;
            _Prescription.EndDate = dateTimePickerEndDate.Value;
            _Prescription.SpecialInstructions = txtSpecialInstructions.Text;

            if (_Prescription.Save())
            {
                lblPrescriptionID.Text = _Prescription.PrescriptionID.ToString();
                lblTitle.Text = "Update Prescription";
                this.Text = lblTitle.Text;
                Mode = enMode.Update;
                MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Couldn't save Prescription", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
