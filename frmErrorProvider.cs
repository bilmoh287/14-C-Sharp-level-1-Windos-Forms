using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmErrorProvider : Form
    {
        public frmErrorProvider()
        {
            InitializeComponent();
        }

        private void txtFname_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtFname.Text))
            {
                e.Cancel = true;
                txtFname.Focus();
                errorProvider1.SetError(txtFname, "First Name must have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFname, "");
            }
        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLName.Text))
            {
                e.Cancel = true;
                txtLName.Focus();
                errorProvider1.SetError(txtLName, "Last Name must have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLName, "");
            }
        }
    }
}
