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

namespace SimpleClinicWinForm.Patients.Controls
{
    public partial class ctrlPatientCard : UserControl
    {

        private int _PatientID = -1;

        public int PatientID
        {
            get { return _PatientID; }
        }

        private clsPatients _Patient;
        public clsPatients SelectedPatientInfo
        {
            get { return _Patient; }
        }
        public ctrlPatientCard()
        {
            InitializeComponent();
        }

        public void LoadPatientInfo(int PatientID)
        {
            _Patient = clsPatients.Find(PatientID);

            if (_Patient == null)
            {
                MessageBox.Show("Patient is not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _PatientID = _Patient.PatientID;
            ctrlPersonCard1.LoadPersonInfo(_Patient.PersonID);
            lblPatientID.Text = PatientID.ToString();
        }

    }
}
