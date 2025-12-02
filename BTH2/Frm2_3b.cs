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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem item1 = new ListViewItem();
            item1.Text = txtNhapMa.Text;
            item1.SubItems.Add(txtNhapTen.Text);
            item1.SubItems.Add(txtDiaChi.Text);
            item1.SubItems.Add(dateTimePicker1.Value.ToShortDateString());
            item1.SubItems.Add(cboLop.Text);
            listView1.Items.Add(item1);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                item.SubItems[0].Text = txtNhapMa.Text;
                item.SubItems[1].Text = txtNhapTen.Text;
                item.SubItems[2].Text = txtDiaChi.Text;
                item.SubItems[3].Text = dateTimePicker1.Value.ToShortDateString();
                item.SubItems[4].Text = cboLop.Text;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                txtNhapMa.Text = item.SubItems[0].Text;
                txtNhapTen.Text = item.SubItems[1].Text;
                txtDiaChi.Text = item.SubItems[2].Text;
                dateTimePicker1.Value = DateTime.Parse(item.SubItems[3].Text);
                cboLop.Text = item.SubItems[4].Text;
            }
        }
    }
}
