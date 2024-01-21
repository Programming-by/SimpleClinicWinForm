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

namespace SimpleClinicWinForm.MedicalRecords
{
    public partial class frmAddEditMedicalRecord : Form
    {
        public enum enMode { AddNew = 0 , Update = 1 };

        enMode Mode = enMode.AddNew;

        int _MedicalRecordID;

        clsMedicalRecords _Record;

        public delegate void DataBackHandler(object sender, int? MedicalRecordID);

        public event DataBackHandler DataBack;
        public frmAddEditMedicalRecord()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }

        public frmAddEditMedicalRecord(int MedicalRecordID)
        {
            InitializeComponent();
            Mode = enMode.Update;
            _MedicalRecordID = MedicalRecordID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _ResetDefaultValues()
        {
            if (Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Medical Record";
                this.Text = lblTitle.Text;
                _Record = new clsMedicalRecords();
            } else
            {
                lblTitle.Text = "Update Medical Record";
                this.Text += lblTitle.Text;
            }
        }

        private void _LoadData()
        {
            _Record = clsMedicalRecords.Find(_MedicalRecordID);

            if (_Record == null)
            {
                MessageBox.Show("Medical Record doesn't Exist","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            txtVisitDescription.Text =  _Record.VisitDescription;
            txtDiagnosis.Text = _Record.Diagnosis;
            txtAdditionalNotes.Text = _Record.AdditionalNotes;

        }
        private void frmAddEditMedicalRecord_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (Mode == enMode.Update)
                _LoadData();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Record.VisitDescription = txtVisitDescription.Text;
            _Record.Diagnosis = txtDiagnosis.Text;
            _Record.AdditionalNotes = txtAdditionalNotes.Text;

            if (_Record.Save())
            {
                lblMedicalRecordID.Text = _Record.MedicalRecordID.ToString();
               DataBack?.Invoke(this,_Record.MedicalRecordID);
                Mode = enMode.Update;
                lblTitle.Text = "Update MedicalRecord";
                this.Text = "Update MedicalRecord";
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
