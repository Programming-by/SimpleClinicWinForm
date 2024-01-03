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
        clsPatients _Patient;
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

            ctrlPersonCard1.LoadPersonInfo(_Patient.PersonID);
            lblPatientID.Text = PatientID.ToString();
        }

    }
}
