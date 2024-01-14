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

namespace SimpleClinicWinForm.MedicalRecords.Controls
{
    public partial class ctrlMedicalRecordCard : UserControl
    {
        private clsMedicalRecords _MedicalRecord;
        public clsMedicalRecords SelectedMedicalRecord
        {
            get { return _MedicalRecord; }
        }

        private int? _MedicalRecordID;

        public int? MedicalRecordID
        {
            get { return _MedicalRecordID; }
        }
        public ctrlMedicalRecordCard()
        {
            InitializeComponent();
        }

        public void LoadMedicalRecordInfo(int? MedicalRecordID)
        {
            _MedicalRecord = clsMedicalRecords.Find(MedicalRecordID);

            if (_MedicalRecord == null)
            {
                MessageBox.Show("Medical Record is not Found","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            _MedicalRecordID = MedicalRecordID;
         lblMedicalRecordID.Text = MedicalRecordID.ToString();
         lblVisitDescription.Text =   _MedicalRecord.VisitDescription;
         lblDiagnosis.Text = _MedicalRecord.Diagnosis;
         lblAdditionalNotes.Text = _MedicalRecord.AdditionalNotes;
        }
    }
}
