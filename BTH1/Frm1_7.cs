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
    public partial class Frm1_7 : Form
    {
        public Frm1_7()
        {
            InitializeComponent();
        }

        private void txtYourName_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtYourName_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtYourName, "You must enter Your Name");
                ctr.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int age = DateTime.Now.Year - int.Parse(txtYear.Text);
            string s = "My Name is: " + txtYourName.Text + "\n" + age.ToString();
            MessageBox.Show(s, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length > 0 && !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
            {
                errorProvider1.SetError(txtYear, "This is not invalid number");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtYourName.Clear();
            txtYear.Clear();
            txtYourName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm1_7_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Do you want to close?", "Exit", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
