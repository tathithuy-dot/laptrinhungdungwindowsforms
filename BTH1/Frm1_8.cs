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
    public partial class Frm1_8 : Form
    {
        public Frm1_8()
        {
            InitializeComponent();
            btnGiai.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtNhapA.Text);
            double b = double.Parse(txtNhapB.Text);
            string ketQua;

            if (a == 0)
            {
                ketQua = b == 0 ? "Phuong trinh co vo so nghiem" : "Phuong trinh vo nghiem";
            }
            else
            {
                double x = -b / a;
                ketQua = $"Phuong trinh co nghiem x = {x}";
            }

            txtNghiem.Text = ketQua;
            btnXoa.Enabled = true;
            btnGiai.Enabled = false;
        }

        private void txtNhapB_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co chac chan muon thoat khong?", "Xac nhan", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtNhapA.Clear();
            txtNhapB.Clear();
            this.txtNghiem.Clear();
            txtNhapA.Focus();
            btnXoa.Enabled = false;
        }

        private void txtNhapA_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }
        private void ValidateInput()
        {
            bool isValidA = double.TryParse(txtNhapA.Text, out _);
            bool isValidB = double.TryParse(txtNhapB.Text, out _);

            errorProvider1.SetError(txtNhapA, isValidA ? "" : "Gia tri A khong hop le");
            errorProvider1.SetError(txtNhapB, isValidB ? "" : "Gia tri B khong hop le");

            btnGiai.Enabled = isValidA && isValidB;
        }
    }
}
