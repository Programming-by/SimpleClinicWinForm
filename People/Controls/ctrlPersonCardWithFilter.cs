using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClinicWinForm.People.Controls
{
    public partial class ctrlPersonCardWithFilter : UserControl
    {
        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            _FindNow();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddNewPerson frm = new frmAddNewPerson();

            frm.ShowDialog();
        }

        private void _FindNow()
        {
            switch (cbFilters.Text)
            {
                case "PersonID":
                    ctrlPersonCard1.LoadPersonInfo(int.Parse(txtFilter1.Text));
                    break;
                case "Name":
                    ctrlPersonCard1.LoadPersonInfo(txtFilter1.Text);
                    break;
            }
          
        }
    }
}
