using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH1_6
{
    public partial class Frm1_11 : Form
    {
        public Frm1_11()
        {
            InitializeComponent();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            string thongtin = "Ma SV: " + txtNhapMa.Text + "\n" +
                                "Ho ten: " + txtNhapName.Text + "\n" +
                                "Lop: " + cboLop.Text + "\n" +
                                "Nien khoa " + cboNienkhoa.Text + "\n" +
                                "Cac mon da dang ki: " +chklstMon.CheckedItems;
            string hk = "Da dang ki hoc ki: ";
            if (radI.Checked)
                hk += radI.Text;
            else if (radII.Checked)
                hk += radII.Text;
            else if (radIII.Checked)
                hk += radIII.Text;
            else
                hk += radIV.Text;
            MessageBox.Show("Sinh vien:" + thongtin + "\n" + hk);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtNhapMa.Clear();
            txtNhapName.Clear();
            cboLop.Items.Clear();
            cboNienkhoa.Items.Clear();
            radI.Checked = true;
            chklstMon.Items.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
