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
    public partial class Frm1_9 : Form
    {
        public Frm1_9()
        {
            InitializeComponent();
        }

        private void Frm1_9_Load(object sender, EventArgs e)
        {
            txtNhap.Clear();
            lstSo.Items.Clear();
            txtNhap.Focus();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNhap.Text, out double so))
            {
                lstSo.Items.Add(so);
                txtNhap.Clear();
                txtNhap.Focus();
            }
            else
            {
                MessageBox.Show("Vui long nhap du lieu hop le!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhap.SelectAll();
            }

        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            double tong = 0;
            foreach (var item in lstSo.Items)
                tong += Convert.ToDouble(item);
            MessageBox.Show($"Tổng các số là: {tong}", "Kết quả");
        }

        private void btnXoaDauCuoi_Click(object sender, EventArgs e)
        {
            if (lstSo.Items.Count >= 2)
            {
                lstSo.Items.RemoveAt(0);
                lstSo.Items.RemoveAt(lstSo.Items.Count - 1);
            }
            else
            {
                lstSo.Items.Clear();
            }
        }

        private void btnXoaDangChon_Click(object sender, EventArgs e)
        {
            while (lstSo.SelectedItems.Count > 0)
                lstSo.Items.Remove(lstSo.SelectedItems[0]);
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                double so = Convert.ToDouble(lstSo.Items[i]);
                lstSo.Items[i] = so + 2;
            }
        }

        private void btnBinhPhuong_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                double so = Convert.ToDouble(lstSo.Items[i]);
                lstSo.Items[i] = so * so;
            }
        }

        private void btnChan_Click(object sender, EventArgs e)
        {
            List<double> chan = new List<double>();
            foreach (var item in lstSo.Items)
            {
                double so = Convert.ToDouble(item);
                if (so % 2 == 0)
                    chan.Add(so);
            }
            MessageBox.Show("Cac so chan: " + string.Join(", ", chan), "Ket qua");
        }

        private void btnLe_Click(object sender, EventArgs e)
        {
            List<double> le = new List<double>();
            foreach (var item in lstSo.Items)
            {
                double so = Convert.ToDouble(item);
                if (so % 2 != 0)
                    le.Add(so);
            }
            MessageBox.Show("Cac so le: " + string.Join(", ", le), "Ket qua");
        }
    }
}
