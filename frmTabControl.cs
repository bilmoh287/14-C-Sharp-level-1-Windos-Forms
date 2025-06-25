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
    public partial class frmTabControl : Form
    {
        public frmTabControl()
        {
            InitializeComponent();
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void btnEmpInfo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtFullName.Text) || string.IsNullOrEmpty(txtDep.Text)
                || string.IsNullOrEmpty(txtJob.Text) || string.IsNullOrEmpty(txtSalary.Text) || string.IsNullOrEmpty(txtPhone.Text))
                return;

            string ID = txtID.Text.Trim();

            if(IsDuplicateID(ID))
            {
                MessageBox.Show("Employee with this ID already exists!", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem Item = new ListViewItem(ID);
            Item.SubItems.Add(txtFullName.Text.Trim());

            if (radioButton1.Checked)
                Item.SubItems.Add("Male");
            else
                Item.SubItems.Add("Femle");

            Item.SubItems.Add(txtJob.Text.Trim());
            Item.SubItems.Add(txtSalary.Text.Trim());
            Item.SubItems.Add(dateTimePicker1.Value.ToString());
            Item.SubItems.Add(txtPhone.Text.Trim());
            Item.SubItems.Add(txtDep.Text.Trim());
            Item.SubItems.Add(numericUpDown1.Value.ToString());

            listView1.Items.Add(Item);

            txtID.Clear();
            txtFullName.Clear();
            txtDep.Clear();
            txtJob.Clear();
            txtSalary.Clear();
            txtPhone.Clear();
            dateTimePicker1.Value = DateTime.Now;
            numericUpDown1.Value = 18;
            txtID.Focus();
        }


        private bool IsDuplicateID(string ID)
        {
            foreach(ListViewItem Item in listView1.Items)
            {
                if (Item.Text == ID) return true;
            }
            return false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string idToRemove = txtFindID.Text.Trim();

            ListViewItem item = listView1.FindItemWithText(idToRemove, false, 0, true);

            if (item != null)
            {
                listView1.Items.Remove(item);
                MessageBox.Show("Employee removed successfully.", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear labels if not found
                lblName.Text = lblGender.Text = lblDep.Text = lblJob.Text =
                lblSalary.Text = lblDate.Text = lblPhone.Text = lblAge.Text = "";

                txtFindID.Clear();
                txtFindID.Focus();
            }
            else
            {
                MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFindID_TextChanged(object sender, EventArgs e)
        {
            string ID = txtFindID.Text.Trim();

            if(listView1.Items.Count == 0)
            {
                return;
            }

            ListViewItem Item = listView1.FindItemWithText(ID, false, 0, true);

            if(Item != null)
            {
                lblName.Text = Item.SubItems[1].Text;
                lblGender.Text = Item.SubItems[2].Text;
                lblDep.Text = Item.SubItems[7].Text;
                lblJob.Text = Item.SubItems[3].Text;
                lblSalary.Text = Item.SubItems[4].Text;
                lblDate.Text = Item.SubItems[5].Text;
                lblPhone.Text = Item.SubItems[6].Text;
                lblAge.Text = Item.SubItems[8].Text;    
            }
            else
            {
                // Clear labels if not found
                lblName.Text = lblGender.Text = lblDep.Text = lblJob.Text =
                lblSalary.Text = lblDate.Text = lblPhone.Text = lblAge.Text = "";
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbDetail_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;

        }

        private void btnSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;

        }

        private void btnTile_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;

        }

        private void btnList_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;

        }

        private void btnLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;

        }

        private void btnFillRandom_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                ListViewItem Item = new ListViewItem(i.ToString());

                //if (i % 2 == 0)
                //    Item.ImageIndex = 1;
                //else
                //    Item.ImageIndex = 0;

                Item.SubItems.Add("Person" + i);

                if (i % 2 == 0)
                    Item.SubItems.Add("Male");
                else
                    Item.SubItems.Add("Femle");

                Item.SubItems.Add("Not Yet");
                Item.SubItems.Add("0000");
                Item.SubItems.Add(dateTimePicker1.Value.ToString());
                Item.SubItems.Add("09000000" + i);
                Item.SubItems.Add("Uknown");

                listView1.Items.Add(Item);
            }
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Select Employee Photo";
            openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picEmployeePhoto.Image = Image.FromFile(openFile.FileName);

                // Optional: store the path for saving or loading later
                //lblImagePath.Text = openFile.FileName; // (you can use a hidden label or a variable)
            }
        }
    }
}
