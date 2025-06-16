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
    public partial class frmComboBox : Form
    {
        public frmComboBox()
        {
            InitializeComponent();
        }


        public void ChangeImageAndLabel(ComboBox comboBox)
        {
            switch (comboBox.SelectedIndex)
            {
                case 1:
                    pictureBox1.Image = Resources.girl2;
                    label1.Text = "Girl";
                    break;
                case 2:
                    pictureBox1.Image = Resources.books;
                    label1.Text = "Books";
                    break;
                case 3:
                    pictureBox1.Image = Resources.Pen2;
                    label1.Text = "Pen";
                    break;
                default:
                    pictureBox1.Image = Resources.Boy3;
                    label1.Text = "Boy";
                    break;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeImageAndLabel((ComboBox)sender);
        }

        private void frmComboBox_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}
