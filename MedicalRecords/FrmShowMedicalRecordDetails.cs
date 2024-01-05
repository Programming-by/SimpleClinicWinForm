using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClinicWinForm.MedicalRecords
{
    public partial class FrmShowMedicalRecordDetails : Form
    {
        int _MedicalRecordID;
        public FrmShowMedicalRecordDetails(int MedicalRecordID)
        {
            InitializeComponent();

            _MedicalRecordID = MedicalRecordID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmShowMedicalRecordDetails_Load(object sender, EventArgs e)
        {
            ctrlMedicalRecordCard1.LoadMedicalRecordInfo(_MedicalRecordID);
        }
    }
}
