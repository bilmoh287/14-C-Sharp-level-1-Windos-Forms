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
    public partial class frmMaskedBox : Form
    {
        public frmMaskedBox()
        {
            InitializeComponent();
        }

        private void btnToMaskedBoxForm_Click(object sender, EventArgs e)
        {
            if(maskedTextBox1.MaskFull)
            {
                Form frm1 = new frmComboBox();
                frm1.ShowDialog();
            }
        }
    }
}
