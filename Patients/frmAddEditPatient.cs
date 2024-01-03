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

namespace SimpleClinicWinForm.Patients
{
    public partial class frmAddEditPatient : Form
    {
        public enum enMode { AddNew = 0 , Update  = 1 }

        enMode Mode = enMode.AddNew;

        int _PatientID = -1;
        clsPatients _Patient;
        public frmAddEditPatient()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }

        public frmAddEditPatient(int PatientID)
        {
            InitializeComponent();
            _PatientID = PatientID;
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
                lblTitle.Text = "Add New Patient";
                this.Text = lblTitle.Text;
                _Patient = new clsPatients();
            } else
            {
                lblTitle.Text = "Update Patient";
                this.Text = lblTitle.Text;
            }
            tpPatientInfo.Enabled = false;
        }

        private void _LoadData()
        {
            _Patient = clsPatients.Find(_PatientID);

            if (_Patient == null)
            {
                MessageBox.Show("Doctor Doesn't Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrlPersonCardWithFilter1.LoadPersonInfo(_Patient.PersonID);
            ctrlPersonCardWithFilter1.FilterEnabled = false;
            lblPatientID.Text = _Patient.PatientID.ToString();
        }
        private void frmAddEditPatient_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (Mode == enMode.Update)
                _LoadData();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Mode == enMode.Update)
            {
                tpPatientInfo.Enabled = true;
                tbPatientInfo.SelectedTab = tbPatientInfo.TabPages["tpPatientInfo"];
                btnSave.Enabled = true;
                return;
            }
            if (ctrlPersonCardWithFilter1.PersonID != -1)
            {
                bool IsDoctor = clsDoctors.IsDoctorsExistByPersonID(ctrlPersonCardWithFilter1.PersonID);
                bool IsPatient = clsPatients.IsPatientsExistByPersonID(ctrlPersonCardWithFilter1.PersonID);

                if (IsDoctor || IsPatient)
                {
                    MessageBox.Show("this person is linked to a doctor or patient,Please choose another one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonCardWithFilter1.FilterFocus();

                }
                else
                {

                    tpPatientInfo.Enabled = true;
                    tbPatientInfo.SelectedTab = tbPatientInfo.TabPages["tpPatientInfo"];
                    btnSave.Enabled = true;

                }


            }
            else
            {
                MessageBox.Show("Please enter a Person first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithFilter1.FilterFocus();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Patient.PersonID = ctrlPersonCardWithFilter1.PersonID;

            if (_Patient.Save())
            {
                lblPatientID.Text = _Patient.PatientID.ToString();
                Mode = enMode.Update;
                lblTitle.Text = "Update Patient";
                this.Text = "Update Patient";
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }

    }
}
