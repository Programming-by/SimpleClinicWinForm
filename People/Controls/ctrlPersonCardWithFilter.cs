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
        public event Action<int> OnPersonSelected;
        protected virtual void PersonSelected(int PersonID)
        {
            Action <int> handler = OnPersonSelected;

            if (handler != null)
                handler(PersonID);
        }

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get { return _FilterEnabled; }

           set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;
            }
        }
       
        public int PersonID
        {
            get { return ctrlPersonCard1.PersonID;  }
        }
        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }

        public void LoadPersonInfo(int PersonID)
        {
            cbFilters.SelectedIndex = 0;
            txtFilter1.Text = PersonID.ToString();
            ctrlPersonCard1.LoadPersonInfo(PersonID);
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

            if (OnPersonSelected != null && FilterEnabled)
                PersonSelected(ctrlPersonCard1.PersonID);
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("some fields are not valid","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            _FindNow();
        }

        private void DataBackEvent(object sender , int PersonID)
        {
            cbFilters.SelectedIndex = 0;
            txtFilter1.Text = PersonID.ToString();
            ctrlPersonCard1.LoadPersonInfo(PersonID);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddNewPerson frm = new frmAddNewPerson();

            frm.DataBack += DataBackEvent;
            frm.ShowDialog();
        }

        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFilters.SelectedIndex = 0;
            txtFilter1.Focus();
        }

        private void txtFilter1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilters.Text == "PersonID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter1.Text = "";
            txtFilter1.Focus();
        }

        public void FilterFocus()
        {
            txtFilter1.Focus();
        }
    }
}
