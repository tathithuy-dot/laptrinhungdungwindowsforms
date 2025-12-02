using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTH2
{
    public partial class Frm2_1 : Form
    {
        public Frm2_1()
        {
            InitializeComponent();
        }

        int i = 10;

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = i.ToString();
            i--;
            if (i < 0)
            {
                this.timer1.Enabled = false;
                label1.Text = "Het gio";
            }
        }
    }
}
