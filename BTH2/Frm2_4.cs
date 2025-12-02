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
    public partial class Frm2_4 : Form
    {
        public Frm2_4()
        {
            InitializeComponent();
        }

        private void Frm2_4_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Columns.Add("MaSV", "Ma Sinh Vien");
            this.dataGridView1.Columns.Add("Hoten", "Ho Ten");
            this.dataGridView1.Columns.Add("Quequan", "Que Quan");
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            string[] mang = { txtNhapMa.Text, txtNhapTen.Text, txtNhapQue.Text };
            this.dataGridView1.Rows.Add(mang);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.CurrentRow.Cells[0].Value = txtNhapMa.Text;
                dataGridView1.CurrentRow.Cells[1].Value = txtNhapTen.Text;
                dataGridView1.CurrentRow.Cells[2].Value = txtNhapQue.Text;
            }
        }
        //Cach 2: Sua
        /*
         * private void btnSua_Click(object sender, EventArgs e)
        {
            foreach (DataGridView row in dataGridView1.Rows)
            {
                if (row.Cell[0].Value.ToString() = txtNhapMa.Text && row.Cell[0].Value.ToString() != null)
                {
                    row.Cells[1].Value = txtNhapTen.Text;
                    row.Cells[2].Value = txtNhapQue.Text;
                    break;
                }
            }
        }
         */

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string ma = txtNhapMa.Text.Trim();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["MaSV"].Value != null &&
                    row.Cells["MaSV"].Value.ToString() == ma)
                {
                    row.Selected = true;
                    dataGridView1.CurrentCell = row.Cells[0];
                    dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                    return;
                }
            }

            MessageBox.Show("Không tìm thấy sinh viên có mã: " + ma);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > 0)
            {
                txtNhapMa.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNhapTen.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNhapQue.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }
    }
}
