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
    public partial class frmTreeView : Form
    {
        public frmTreeView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                TreeNode newNode = new TreeNode(textBox1.Text);
                newNode.Name = textBox1.Text;
                treeView1.Nodes.Add(newNode);

                comboBox1.Items.Add(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Please Enter what you want to add first!", 
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                TreeNode[] FoundNodes =  treeView1.Nodes.Find(textBox1.Text, true);
                if(FoundNodes.Length > 0)
                {
                    TreeNode NodeToRemove = FoundNodes[0];
                    NodeToRemove.Remove();


                    MessageBox.Show($"Node '{textBox1.Text}' removed successfully.");

                }

                else
                {
                    MessageBox.Show($"Node '{textBox1.Text}' not found.");
                }
            }

            else
            {
                MessageBox.Show("Please Enter what you want Remove first!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            treeView1 .Nodes.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmTreeView_Load(object sender, EventArgs e)
        {
            string treeViewSizeString = treeView1.Nodes.Count.ToString();
            comboBox1.Items.Clear();
            comboBox1.Items.Add(treeViewSizeString);

            foreach (TreeNode node in treeView1.Nodes)
            {
                comboBox1.Items.Add(node.Text);
            }
            comboBox1.SelectedIndex = 0;

        }
    }
}
