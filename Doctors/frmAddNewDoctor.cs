using SimpleClinicBusinessLayer;
using SimpleClinicWinForm.Global_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClinicWinForm.Doctors
{
    public partial class frmAddNewDoctor : Form
    {
        public enum enMode { AddNew = 0 , Update = 1 }

        enMode Mode = enMode.AddNew;

        int _DoctorID = -1;

        clsDoctors _Doctor;

        public delegate void DataBackEvent(object sender, int DoctorID);

        public event DataBackEvent DataBack;
        public frmAddNewDoctor()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }

        public frmAddNewDoctor(int DoctorID)
        {
            InitializeComponent();
            _DoctorID = DoctorID;
            Mode = enMode.Update;
        }
        private void _ResetDefaultValues()
        {
            if (Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Doctor";
                this.Text = lblTitle.Text;
                _Doctor = new clsDoctors();
            } else
            {
                lblTitle.Text = "Update Doctor";
                this.Text = lblTitle.Text;
            }
            tpDoctorInfo.Enabled = false;
        }
        
        private void _LoadData()
        {
            _Doctor = clsDoctors.Find(_DoctorID);

            if (_Doctor == null)
            {
                MessageBox.Show("Doctor Doesn't Exist","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            ctrlPersonCardWithFilter1.LoadPersonInfo(_Doctor.PersonID);
            ctrlPersonCardWithFilter1.FilterEnabled = false;
            lblDoctorID.Text = _Doctor.DoctorID.ToString();
            txtSpecialization.Text = _Doctor.Specialization;

        }
        private void frmAddNewDoctor_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (Mode == enMode.Update)
                _LoadData();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Mode == enMode.Update)
            {
                tpDoctorInfo.Enabled = true;
                tbDoctorInfo.SelectedTab = tbDoctorInfo.TabPages["tpDoctorInfo"];
                btnSave.Enabled = true;
                return;
            }
            if (ctrlPersonCardWithFilter1.PersonID != -1)
            {
                if (clsDoctors.IsDoctorsExistByPersonID(ctrlPersonCardWithFilter1.PersonID))
                {
                    MessageBox.Show("this person is linked to a doctor,Please choose another one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonCardWithFilter1.FilterFocus();

                }
                else
                {

                    tpDoctorInfo.Enabled = true;
                    tbDoctorInfo.SelectedTab = tbDoctorInfo.TabPages["tpDoctorInfo"];
                    btnSave.Enabled = true;

                }


            }
            else
            {
                MessageBox.Show("Please enter a Person first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithFilter1.FilterFocus();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Doctor.PersonID = ctrlPersonCardWithFilter1.PersonID;
            _Doctor.Specialization = txtSpecialization.Text;

            if (_Doctor.Save())
            {
                lblDoctorID.Text = _Doctor.DoctorID.ToString();
                Mode = enMode.Update;
                lblTitle.Text = "Update Doctor";
                this.Text = "Update Doctor";
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBack?.Invoke(this, _Doctor.DoctorID);
            } else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
