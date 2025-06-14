using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class frmImageBoxExer : Form
    {
        public frmImageBoxExer()
        {
            InitializeComponent();
        }

        void UpdatePicture()
        {
            if(rbGirl.Checked)
            {
                pictureBox1.Image = Resources.girl2;
            }
            else if(rbBook.Checked)
            {
                pictureBox1.Image = Resources.books;
            }
            else if(rbPen.Checked)
            {
                pictureBox1.Image = Resources.Pen2;
            }
            else
            {
                pictureBox1.Image = Resources.Boy3;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rbBoy_CheckedChanged(object sender, EventArgs e)
        {
            //UpdatePicture();
            pictureBox1.Image = Resources.Boy3;
            lblTitle.Text = ((RadioButton)sender).Tag.ToString();
        }

        //private void frmImageBoxExer_Load(object sender, EventArgs e)
        //{
        //    UpdatePicture();

        //}

        private void rbGirl_CheckedChanged(object sender, EventArgs e)
        {
            //UpdatePicture();
            pictureBox1.Image = Resources.girl2;
            lblTitle.Text = ((RadioButton)sender).Tag.ToString();

        }

        private void rbBook_CheckedChanged(object sender, EventArgs e)
        {
            //UpdatePicture();
            pictureBox1.Image = Resources.books;
            lblTitle.Text = ((RadioButton)sender).Tag.ToString();

        }

        private void rbPen_CheckedChanged(object sender, EventArgs e)
        {
            //UpdatePicture();
            pictureBox1.Image = Resources.Pen2;
            lblTitle.Text = ((RadioButton)sender).Tag.ToString();

        }
    }
}
