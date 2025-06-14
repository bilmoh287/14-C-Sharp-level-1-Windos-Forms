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
    public partial class frmMessageBox : Form
    {
        public frmMessageBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tis is my first Message");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tis is my first Message", "This a Title KOKO");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm", "Are you sure!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                {
                    MessageBox.Show("User Pressed Ok");
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm", "Are you sure!", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                {
                    MessageBox.Show("User Pressed Ok");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm", "Are you sure!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2 ) == DialogResult.OK)
            {
                {
                    MessageBox.Show("User Pressed Ok");
                }
            }
        }
    }
}
