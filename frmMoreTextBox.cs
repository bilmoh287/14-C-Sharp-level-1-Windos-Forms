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
    public partial class frmMoreTextBox : Form
    {
        public frmMoreTextBox()
        {
            InitializeComponent();
        }

        private void frmMoreTextBox_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTextBoxFocus_Click(object sender, EventArgs e)
        {
            textBox4.Focus();
        }
    }
}
