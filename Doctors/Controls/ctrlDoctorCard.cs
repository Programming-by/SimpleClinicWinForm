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

namespace SimpleClinicWinForm.Doctors.Controls
{
    public partial class ctrlDoctorCard : UserControl
    {
        clsDoctors _Doctor;
        public ctrlDoctorCard()
        {
            InitializeComponent();
        }
        public void LoadDoctorInfo(int DoctorID)
        {
            _Doctor = clsDoctors.Find(DoctorID); 

            if (_Doctor == null)
            {
                MessageBox.Show("Doctor is not found","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            lblDoctorID.Text = _Doctor.DoctorID.ToString();
            lblSpecialization.Text = _Doctor.Specialization.ToString();
            ctrlPersonCard1.LoadPersonInfo(_Doctor.PersonID);
        }
    }
}
