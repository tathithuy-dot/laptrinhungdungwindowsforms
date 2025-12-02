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
    public partial class Frm2_9 : Form
    {
        public Frm2_9()
        {
            InitializeComponent();
        }

        private void btnNop_Click(object sender, EventArgs e)
        {
            string thongbao;
            thongbao = "Nhan vien: " + txtTen.Text + "\n";
            thongbao += "Ngay sinh: " + mskBirth.Text + "\n";
            thongbao += "Dia chi: " + txtDiaChi.Text + "\n";
            thongbao += "Dat nuoc: " + cboCountry.Text + "\n";
            thongbao += "Thanh pho: " + cboTp.Text + "\n";
            thongbao += "Bang cap: " + txtBangCap.Text + "\n";
            thongbao += "So dien thoai: " + mskPhone.Text + "\n";
            thongbao += "Email: " + txtEmail.Text + "\n";
            thongbao += "Ngay gia nhap: " + dateTimePicker1.Text + "\n";
            MessageBox.Show(thongbao, "Thong tin ca nhan");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
