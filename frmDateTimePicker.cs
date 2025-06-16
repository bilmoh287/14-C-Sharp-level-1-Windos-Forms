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
    public partial class frmDateTimePicker : Form
    {
        public frmDateTimePicker()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text += "Default Text: " + dateTimePicker1.Text + Environment.NewLine;
            label1.Text += "d-M-y: " + dateTimePicker1.Value.ToString("d-M-y") + Environment.NewLine;
            label1.Text += "dd-MMM-yyyy: " + dateTimePicker1.Value.ToString("dd-MMM-yyyy") + Environment.NewLine;
            label1.Text += "dddd-MMMM-yyyy: " + dateTimePicker1.Value.ToString("dddd-MMMM-yyyy") + Environment.NewLine;
            label1.Text += "dddd,dddd-MMM-yyyy: " + dateTimePicker1.Value.ToString("dddd,dddd-MMM-yyyy") + Environment.NewLine; // This format might look a bit odd, repeating dddd
            label1.Text += "dd/MMM/yyyy: " + dateTimePicker1.Value.ToString("dd/MMM/yyyy") + Environment.NewLine;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToShortDateString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToLongDateString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmDateTimePicker_Load(object sender, EventArgs e)
        {

        }
    }
}
