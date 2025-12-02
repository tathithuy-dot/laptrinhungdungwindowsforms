using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm1_8
{
    public partial class Frm1_7 : Form
    {
        private class SinhVien
        {
            public string MaSV { get; set; }
            public string TenSV { get; set; }
            public string DiaChi { get; set; }
            public override string ToString()
            {
                return MaSV;
            }
        }
        public Frm1_7()
        {
            InitializeComponent();
            btnCapNhat.Click += btnCapNhat_Click;
            btnXoa.Click += btnXoa_Click;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text) ||
                string.IsNullOrWhiteSpace(txtTen.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui long nhap du thong tin", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TreeNode selectedNode = treeView1.SelectedNode;

            if (selectedNode == null || (selectedNode.Tag != null && selectedNode.Tag.ToString() != "Lop"))
            {
                MessageBox.Show("Vui long chon Lop", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (KiemTraTrungMaSV(txtMa.Text))
            {
                MessageBox.Show($"Ma sinh vien {txtMa.Text} da co", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SinhVien newSV = new SinhVien
            {
                MaSV = txtMa.Text,
                TenSV = txtTen.Text,
                DiaChi = txtDiaChi.Text
            };

            TreeNode svNode = new TreeNode($"{newSV.MaSV} - {newSV.TenSV}") { Tag = newSV };

            TreeNode addressNode = new TreeNode(newSV.DiaChi) { Tag = "DiaChi" };

            svNode.Nodes.Add(addressNode);

            selectedNode.Nodes.Add(svNode);
            selectedNode.Expand();

            txtMa.Clear();
            txtTen.Clear();
            txtDiaChi.Clear();
            txtMa.Focus();
            MessageBox.Show("Them sinh vien thanh cong!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool KiemTraTrungMaSV(string maSV)
        {
            foreach (TreeNode lopNode in treeView1.Nodes)
            {
                foreach (TreeNode svNode in lopNode.Nodes)
                {
                    if (svNode.Tag is SinhVien sv && sv.MaSV.Equals(maSV, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode?.Remove();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            SinhVien sv = null;

            if (selectedNode.Tag is SinhVien)
            {
                sv = (SinhVien)selectedNode.Tag;
            }
         
            else if (selectedNode.Tag?.ToString() == "DiaChi" && selectedNode.Parent?.Tag is SinhVien)
            {
                sv = (SinhVien)selectedNode.Parent.Tag;
            }

            if (sv != null)
            {
                txtMa.Text = sv.MaSV;
                txtTen.Text = sv.TenSV;
                txtDiaChi.Text = sv.DiaChi;
            }
            else
            {
                txtMa.Clear();
                txtTen.Clear();
                txtDiaChi.Clear();
            }
        }
    }
}
