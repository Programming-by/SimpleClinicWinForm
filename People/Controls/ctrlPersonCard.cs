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

namespace SimpleClinicWinForm.People.Controls
{
    public partial class ctrlPersonCard : UserControl
    {
        private clsPersons _Person;

        public clsPersons SelectedPersonInfo { get { return _Person; } }

        private int _PersonID = -1;

        public int PersonID { get { return _PersonID; } }
        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        public void LoadPersonInfo(int PersonID)
        {
            _Person = clsPersons.Find(PersonID);
            if (_Person == null)
            {
                MessageBox.Show("Person doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _PersonID = _Person.PersonID;

            lblPersonID.Text = _PersonID.ToString();    
            lblName.Text = _Person.Name;
            lblDateOfBirth.Text = _Person.DateOfBirth.ToString();
            lblGendor.Text = _Person.Gender.ToLower() == "m" ? "Male" : "Female";
            lblPhoneNumber.Text = _Person.PhoneNumber;
            lblEmail.Text = _Person.Email;
            lblAddress.Text = _Person.Address;


        }

        public void LoadPersonInfo(string Name)
        {
            _Person = clsPersons.Find(Name);
            if (_Person == null)
            {
                MessageBox.Show("Person doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _PersonID = _Person.PersonID;

            lblPersonID.Text = _PersonID.ToString();
            lblName.Text = _Person.Name;
            lblDateOfBirth.Text = _Person.DateOfBirth.ToString();
            lblGendor.Text = _Person.Gender.ToLower() == "m" ? "Male" : "Female";
            lblPhoneNumber.Text = _Person.PhoneNumber;
            lblEmail.Text = _Person.Email;
            lblAddress.Text = _Person.Address;


        }

    }
}
