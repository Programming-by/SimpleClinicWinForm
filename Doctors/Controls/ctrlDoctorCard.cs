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
       private clsDoctors _Doctor;

       public clsDoctors SelectedDoctorInfo
        {
            get { return _Doctor; }
        }

        private int _DoctorID = -1;

        public int DoctorID
        {
            get { return _DoctorID; }
        }
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
            _DoctorID = _Doctor.DoctorID;   
            lblDoctorID.Text = _Doctor.DoctorID.ToString();
            lblSpecialization.Text = _Doctor.Specialization.ToString();
            ctrlPersonCard1.LoadPersonInfo(_Doctor.PersonID);
        }
    }
}
