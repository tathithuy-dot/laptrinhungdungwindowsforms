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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            radVN.Checked = true;
        }

        private void radVN_CheckedChanged(object sender, EventArgs e)
        {
            if (radVN.Checked)
            {
                pictureBox1.Image = Image.FromFile(@"D:\WF_baitap\Co\VietNam.png");
            }
        }

        private void radUSA_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radUSA.Checked)
            {
                pictureBox1.Image = Image.FromFile(@"D:\WF_baitap\Co\My.png");
            }
        }

        private void radY_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radY.Checked)
            {
                pictureBox1.Image = Image.FromFile(@"D:\WF_baitap\Co\Y.png");
            }
        }

        private void radPhilip_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radPhilip.Checked)
            {
                pictureBox1.Image = Image.FromFile(@"D:\WF_baitap\Co\Philip.png");
            }
        }
    }
}
