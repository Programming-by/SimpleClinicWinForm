using SimpleClinicWinForm.Doctors.Controls;
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
    public partial class frmShowDoctorDetails : Form
    {
        int _DoctorID;
        public frmShowDoctorDetails(int DoctorID)
        {
            InitializeComponent();
            _DoctorID = DoctorID;
        }

        private void frmShowDoctorDetails_Load(object sender, EventArgs e)
        {
            ctrlDoctorCard1.LoadDoctorInfo(_DoctorID);
        }
    }
}
