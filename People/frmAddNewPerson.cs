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

namespace SimpleClinicWinForm.People
{
    public partial class frmAddNewPerson : Form
    {
        public enum enMode { AddNew = 0 , Update = 1}

        enMode Mode = enMode.AddNew;

        int _PersonID = -1;

        private clsPersons _Person;

        public delegate void DataBackHandler(object sender, int PersonID);

        public event DataBackHandler DataBack;
        public frmAddNewPerson()
        {
            InitializeComponent();
        }
        public frmAddNewPerson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            Mode = enMode.Update;
        }

        private void _ResetDefaultValues()
        {
            if (Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Person";
                this.Text = "Add New Person";
                _Person = new clsPersons();

            } else
            {
                lblTitle.Text = "Update Person";
                this.Text = "Update Person";
            }
            rbMale.Checked = true;
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-5);
        }
        private void _LoadData()
        {
            _Person = clsPersons.Find(_PersonID);
            if ( _Person == null )
            {
                MessageBox.Show("Person doesn't exist","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            txtName.Text = _Person.Name;
            dtpDateOfBirth.Value = (DateTime)_Person.DateOfBirth;
            if (_Person.Gender == "M")
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;
            txtPhoneNumber.Text = _Person.PhoneNumber;
            txtEmail.Text = _Person.Email;
            txtAddress.Text = _Person.Address;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
        private void ValidateEmptyTextBox(object sender , CancelEventArgs e)
        {
            TextBox Temp = (TextBox) sender;
            if (string.IsNullOrEmpty(Temp.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
                errorProvider1.SetError(Temp, "");
        }
        private void frmAddNewPerson_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (Mode == enMode.Update)
                _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Person.Name = txtName.Text;
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            _Person.Gender = rbMale.Checked ? "M" : "F";
            _Person.PhoneNumber = txtPhoneNumber.Text;
            _Person.Email = txtEmail.Text;
            _Person.Address = txtAddress.Text;
            if (_Person.Save())
            {
                MessageBox.Show("Data Saved Successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Mode = enMode.Update;
                lblTitle.Text = "Update Person";
                _PersonID = _Person.PersonID;
                DataBack?.Invoke(this, _PersonID);
            } else
                MessageBox.Show("Failed to save this person","Error" ,MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text.Trim() == "")
                return;

            if (!clsValidation.ValidateEmail(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Invalid Email Address Format!");
            }
            else
                errorProvider1.SetError(txtEmail, "");

        }
    }
}
