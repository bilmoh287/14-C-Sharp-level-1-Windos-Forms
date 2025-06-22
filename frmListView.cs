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
    public partial class frmListView : Form
    {
        public frmListView()
        {
            InitializeComponent();
        }

        private void frmListView_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtName.Text))
            {
                return;
            }

            ListViewItem Item = new ListViewItem(txtID.Text.Trim());
            if(rbMale.Checked )
                Item.ImageIndex = 0;
            else
                Item.ImageIndex = 1;

            Item.SubItems.Add(txtName.Text.Trim());
            listView1.Items.Add(Item);

            txtID.Clear();
            txtName.Clear();
            txtID.Focus();
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            for(int i = 1; i <= 10; i++)
            {
                ListViewItem Item = new ListViewItem(i.ToString());

                if(i % 2 == 0)
                    Item.ImageIndex = 1;
                else
                    Item.ImageIndex = 0;

                Item.SubItems.Add("Person" + i);
                listView1.Items.Add(Item);
            }
        }


        private void rbDetail_CheckedChanged_1(object sender, EventArgs e)
        {
            listView1.View = View.Details;

        }

        private void btnSmallIcon_CheckedChanged_1(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;

        }

        private void btnTile_CheckedChanged_1(object sender, EventArgs e)
        {
            listView1.View = View.Tile;

        }

        private void btnLargeIcon_CheckedChanged_1(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;

        }

        private void btnList_CheckedChanged_1(object sender, EventArgs e)
        {
            listView1.View = View.List;

        }
    }
}
