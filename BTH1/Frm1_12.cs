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
    public partial class Frm1_12 : Form
    {
        public Frm1_12()
        {
            InitializeComponent();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtNhap.Text += 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtNhap.Text += 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtNhap.Text += 9;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtNhap.Text += 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtNhap.Text += 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtNhap.Text += 6;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtNhap.Text += 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtNhap.Text += 2;
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            txtNhap.Text += 3;
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            txtNhap.Text += 0;
        }
        double number1; string dau;

        private void btnCong_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtNhap.Text);
            dau = "+";
            txtNhap.Clear();
            txtNhap.Text += dau;
            txtNhap.Clear();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtNhap.Text);
            dau = "-";
            txtNhap.Clear();
            txtNhap.Text += dau;
            txtNhap.Clear();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtNhap.Text);
            dau = "*";
            txtNhap.Clear();
            txtNhap.Text += dau;
            txtNhap.Clear();
        }
        private void btnChia_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtNhap.Text);
            dau = "/";
            txtNhap.Clear();
            txtNhap.Text += dau;
            txtNhap.Clear();
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            double number2 = Convert.ToDouble(txtNhap.Text);
            double result = 0;
            switch (dau)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    if (number2 != 0)
                    {
                        result = number1 / number2;
                    }
                    else
                    {
                        MessageBox.Show("Khong the chia cho 0");
                        return;
                    }
                    break;
            }
            txtNhap.Text = result.ToString();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtNhap.Clear();
            number1 = 0;
            dau = string.Empty;
        }

        private void btnphay_Click(object sender, EventArgs e)
        {
            if (!txtNhap.Text.Contains("."))
            {
                txtNhap.Text += ".";
            }
        }

        private void btndau_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNhap.Text))
            {
                double value = double.Parse(txtNhap.Text);
                value = -value;
                txtNhap.Text = value.ToString();
            }
        }
    }
}
