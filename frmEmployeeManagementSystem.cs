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
    public partial class frmEmployeeManagementSystem : Form
    {
        string selectedImagePath = "";

        public frmEmployeeManagementSystem()
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



            // 👇 Call helper method to handle image + add to ListView
            AddEmployeeToListView(Item, ID, selectedImagePath);

            txtID.Clear();
            txtFullName.Clear();
            txtDep.Clear();
            txtJob.Clear();
            txtSalary.Clear();
            txtPhone.Clear();
            dateTimePicker1.Value = DateTime.Now;
            picEmployeePhoto.Image = Resources.question_mark_96;
            numericUpDown1.Value = 18;

            txtID.Focus();
        }

        private void AddEmployeeToListView(ListViewItem item, string id, string imagePath)
        {
            Image img;

            if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                img = Image.FromFile(imagePath);
            else
                img = Properties.Resources.question_mark_96;

            if (!imageList1.Images.ContainsKey(id))
                imageList1.Images.Add(id, img);
            if (!imageList2.Images.ContainsKey(id))
                imageList2.Images.Add(id, img);

            item.ImageKey = id;
            listView1.LargeImageList = imageList1;
            listView1.SmallImageList = imageList2;

            // ✅ Fix: Clone before adding
            listView1.Items.Add((ListViewItem)item.Clone());
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
                ClearLabels();

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

            if (listView1.Items.Count == 0 || string.IsNullOrEmpty(ID))
            {
                ClearLabels();
                pbRemove.Image = Properties.Resources.question_mark_96;
                return;
            }

            ListViewItem item = listView1.FindItemWithText(ID, false, 0, true);

            if (item != null)
            {
                lblName.Text = item.SubItems[1].Text;
                lblGender.Text = item.SubItems[2].Text;
                lblDep.Text = item.SubItems[7].Text;
                lblJob.Text = item.SubItems[3].Text;
                lblSalary.Text = item.SubItems[4].Text;
                lblDate.Text = item.SubItems[5].Text;
                lblPhone.Text = item.SubItems[6].Text;
                lblAge.Text = item.SubItems[8].Text;


                // Try to get image by ImageKey &(ID) first (for manually added employees)
                if (imageList1.Images.ContainsKey(ID))
                {
                    pbRemove.Image = imageList1.Images[ID];
                }
                // If not found by key, try to get image by ImageIndex (for randomly filled employees)
                else if (item.ImageIndex >= 0 && item.ImageIndex < imageList1.Images.Count)
                {
                    pbRemove.Image = imageList1.Images[item.ImageIndex];
                }
                else
                {
                    // Fallback to question mark if image not found by key or index
                    pbRemove.Image = Properties.Resources.question_mark_96;
                }

            }
            else
            {
                ClearLabels();
                pbRemove.Image = Properties.Resources.question_mark_96;
            }

        }

        private void ClearLabels()
        {
            lblName.Text = lblGender.Text = lblDep.Text = lblJob.Text =
            lblSalary.Text = lblDate.Text = lblPhone.Text = lblAge.Text = "";
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
            int age = 18;

            for (int i = 1; i <= 10; i++)
            {
                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add("Person" + i);

                string gender = i % 2 == 0 ? "Female" : "Male";
                item.SubItems.Add(gender);

                item.SubItems.Add("Not Yet"); // Job
                item.SubItems.Add("0000");    // Salary
                item.SubItems.Add(DateTime.Now.ToShortDateString()); // Hire Date
                item.SubItems.Add("09000000" + i); // Phone
                item.SubItems.Add("Unknown"); // Department
                item.SubItems.Add(age.ToString()); // Age

                // Assign image index
                if (gender == "Male")
                    item.ImageIndex = age <= 21 ? 0 : 2; // 0 = boy, 2 = man
                else
                    item.ImageIndex = age <= 21 ? 1 : 3; // 1 = girl, 3 = woman

                listView1.LargeImageList = imageList1;
                listView1.SmallImageList = imageList2;
                listView1.Items.Add(item);

                age++; // Increase age each loop
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

                // ✅ Store the path for later use when adding the employee
               selectedImagePath = openFile.FileName;
            }
        }

    }
}
