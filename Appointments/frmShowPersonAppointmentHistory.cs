using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClinicWinForm.Appointments
{
    public partial class frmShowPersonAppointmentHistory : Form
    {
        int _PersonID = -1;
        public frmShowPersonAppointmentHistory(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowPersonAppointmentHistory_Load(object sender, EventArgs e)
        {
            if (_PersonID != -1)
            {
            ctrlPersonCardWithFilter1.FilterEnabled = false;
            ctrlPersonCardWithFilter1.LoadPersonInfo(_PersonID);
            ctrlPatientAppintments1.LoadInfoByPersonID(_PersonID);
            } else
            {
                ctrlPersonCardWithFilter1.FilterEnabled = true;
                ctrlPersonCardWithFilter1.FilterFocus();
            }
        }
    }
}
