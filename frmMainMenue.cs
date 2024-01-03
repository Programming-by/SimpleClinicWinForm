using SimpleClinicWinForm.Doctors;
using SimpleClinicWinForm.MedicalRecords;
using SimpleClinicWinForm.Patients;
using SimpleClinicWinForm.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClinicWinForm
{
    public partial class frmMainMenue : Form
    {
        public frmMainMenue()
        {
            InitializeComponent();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListPeople frm = new frmListPeople();

            frm.ShowDialog();
        }

        private void doctorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListDoctors frm = new frmListDoctors();

            frm.ShowDialog();
        }

        private void patientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListPatients frm = new frmListPatients();
            frm.ShowDialog();
        }

        private void medicalRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListMedicalRecords frm = new frmListMedicalRecords();
            frm.ShowDialog();
        }
    }
}
