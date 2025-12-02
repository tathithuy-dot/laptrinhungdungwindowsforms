using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
namespace Frm1_8
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            string tim = txtNhap.Text.Trim().ToLower();
            listView1.Items.Clear();

            TreeNode selectedNode = treeView1.SelectedNode;
            if (selectedNode == null) return;

            if (selectedNode.Level == 2) 
            {
                if (selectedNode.Text.ToLower().Contains(tim))
                {
                    ListViewItem item = new ListViewItem(selectedNode.Text);
                    item.SubItems.Add(selectedNode.Parent.Text); 
                    listView1.Items.Add(item);
                }
            }
            else if (selectedNode.Level == 1) 
            {
                foreach (TreeNode sv in selectedNode.Nodes)
                {
                    if (sv.Text.ToLower().Contains(tim))
                    {
                        ListViewItem item = new ListViewItem(sv.Text);
                        item.SubItems.Add(selectedNode.Text); 
                        listView1.Items.Add(item);
                    }
                }
            }
            else if (selectedNode.Level == 0) 
            {
                foreach (TreeNode lop in selectedNode.Nodes)
                {
                    foreach (TreeNode sv in lop.Nodes)
                    {
                        if (sv.Text.ToLower().Contains(tim))
                        {
                            ListViewItem item = new ListViewItem(sv.Text);
                            item.SubItems.Add(lop.Text); 
                            listView1.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            txtNhap.Focus();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listView1.Items.Clear();

            if (e.Node.Level == 0) 
            {
                foreach (TreeNode lop in e.Node.Nodes)
                {
                    foreach (TreeNode sv in lop.Nodes)
                    {
                        ListViewItem item = new ListViewItem(sv.Text); 
                        item.SubItems.Add(lop.Text); 
                        listView1.Items.Add(item);
                    }
                }
            }
            else if (e.Node.Level == 1) 
            {
                foreach (TreeNode sv in e.Node.Nodes)
                {
                    ListViewItem item = new ListViewItem(sv.Text);
                    item.SubItems.Add(e.Node.Text); 
                    listView1.Items.Add(item);
                }
            }
            else if (e.Node.Level == 2) 
            {
                ListViewItem item = new ListViewItem(e.Node.Text);
                item.SubItems.Add(e.Node.Parent.Text); 
                listView1.Items.Add(item);
            }
        }
    }
}
