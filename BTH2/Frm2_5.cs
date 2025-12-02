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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            for (int i = 65; i <= 90; i++)
            {
                string kt = Convert.ToChar(i).ToString();
                treeView1.Nodes.Add(kt, kt);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string key = textBox1.Text.Trim()[0].ToString();
            treeView1.Nodes[key].Nodes.Add(textBox1.Text + "," + textBox2.Text);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
