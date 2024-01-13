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
    public partial class ctrlDoctorCardWithFilter : UserControl
    {
        public int DoctorID
        {
            get { return ctrlDoctorCard1.DoctorID; }
        }
        public clsDoctors SelectedDoctorInfo
        {
            get { return ctrlDoctorCard1.SelectedDoctorInfo; }
        }
        public ctrlDoctorCardWithFilter()
        {
            InitializeComponent();
        }

        private void txtDoctorID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDoctorID.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDoctorID,"this field is required");
            } else 
                errorProvider1.SetError(txtDoctorID,"");

        }

        private void txtDoctorID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("must fill all required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ctrlDoctorCard1.LoadDoctorInfo(int.Parse(txtDoctorID.Text));
        }

        private void DataBackEvent(object sender , int DoctorID)
        {
            txtDoctorID.Text = DoctorID.ToString();
            ctrlDoctorCard1.LoadDoctorInfo(DoctorID);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddNewDoctor frm = new frmAddNewDoctor();

            frm.DataBack += DataBackEvent;
            frm.ShowDialog();
        }
    }
}
