using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm1_8
{
    public partial class Frm2_8 : Form
    {
        public Frm2_8()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            txtNhapKH.Clear();
            txtNhapKH.Focus();
            txtSoCu.Clear();
            txtSoMoi.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }
        double tongtien;
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNhapKH.Text) ||
                string.IsNullOrWhiteSpace(txtSoCu.Text) ||
                string.IsNullOrWhiteSpace(txtSoMoi.Text))
            {
                MessageBox.Show("Vui long nhap day du thong tin!");
                return;
            }

            if (!double.TryParse(txtSoCu.Text, out double soCu) ||
                !double.TryParse(txtSoMoi.Text, out double soMoi))
            {
                MessageBox.Show("So cu va so moi phai la so hop le!");
                return;
            }

            double tieuthu = soMoi - soCu;
            if (tieuthu < 0)
            {
                MessageBox.Show("So moi phai lon hon hoac bang so cu!");
                return;
            }
            lblTieuThu.Text = tieuthu.ToString();
            double dinhmuc;
            if (cboKhuVuc.SelectedIndex == -1)
            {
                MessageBox.Show("Vui long chon khu vuc!");
                return;
            }
            else if (cboKhuVuc.SelectedIndex == 0)
            {
                lblDinhMuc.Text = "50";
                dinhmuc = 50;
            }
            else if (cboKhuVuc.SelectedIndex == 1)
            {
                lblDinhMuc.Text = "100";
                dinhmuc = 100;
            }
            else
            {
                lblDinhMuc.Text = "200";
                dinhmuc = 200;
            }
            lblDinhMuc.Text = dinhmuc.ToString();
            tongtien = tieuthu * dinhmuc;
            lblTongTien.Text = tongtien.ToString(); 
            lblThanhTien.Text = tongtien.ToString(); 

            ListViewItem item = new ListViewItem(txtNhapKH.Text);
            item.SubItems.Add(cboKhuVuc.Text);
            item.SubItems.Add(lblDinhMuc.Text);
            item.SubItems.Add(lblTieuThu.Text);
            item.SubItems.Add(lblTongTien.Text);
            listView1.Items.Add(item);
        }
    }
}
