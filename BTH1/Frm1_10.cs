using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTH1
{
    public partial class Frm1_10 : Form
    {
        public Frm1_10()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Frm1_10_Load(object sender, EventArgs e)
        {

        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            string ten = txtNhap.Text.Trim();
            if (!string.IsNullOrEmpty(ten))
            {
                lstA.Items.Add(ten);
                txtNhap.Clear();
                txtNhap.Focus();
            }
            else
            {
                MessageBox.Show("Vui long nhap ho ten sinh vien.");
            }
        }

        private void btnAddA_Click(object sender, EventArgs e)
        {
            ChuyenDuLieu(lstA, lstB);
        }

        private void btnAddAllA_Click(object sender, EventArgs e)
        {
            ChuyenToanBo(lstA, lstB);
        }

        private void btnAddB_Click(object sender, EventArgs e)
        {
            ChuyenDuLieu(lstB, lstA);
        }

        private void btnAddAllB_Click(object sender, EventArgs e)
        {
            ChuyenToanBo(lstB, lstA);
        }
        private void ChuyenDuLieu(ListBox from, ListBox to)
        {
            var selected = from.SelectedItems.Cast<object>().ToList();
            foreach (var item in selected)
            {
                to.Items.Add(item);
            }
            foreach (var item in selected)
            {
                from.Items.Remove(item);
            }
        }

        private void ChuyenToanBo(ListBox from, ListBox to)
        {
            var all = from.Items.Cast<object>().ToList();
            foreach (var item in all)
            {
                to.Items.Add(item);
            }
            from.Items.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtNhap.Clear();
            lstA.Items.Clear();
            lstB.Items.Clear();
            txtNhap.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
