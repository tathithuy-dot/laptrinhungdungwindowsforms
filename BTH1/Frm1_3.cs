namespace BTH1_3
{
    public partial class Frm1_3 : Form
    {
        public Frm1_3()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            cboSo.Items.Add(this.txtNhap.Text);
        }

        private void cboSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int so = int.Parse(txtNhap.Text);
            for (int i = 1; i <= so; i++)
            {
                if (so % i == 0)
                {
                    lstTinh.Items.Add(i);
                }
            }
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong = 0;
            for (int i = 0; i < lstTinh.Items.Count; i++)
            {
                tong = tong + int.Parse(lstTinh.Items[i].ToString());
            }
            MessageBox.Show("Tong cac uoc la: " + tong);
        }

        private void btnUocChan_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < lstTinh.Items.Count; i++)
            {
                int uoc = int.Parse(lstTinh.Items[i].ToString());
                if (uoc % 2 == 0)
                {
                    count++;
                }
            }
            MessageBox.Show("Co " + count + " uoc chan");
        }

        private void btnUocNT_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < lstTinh.Items.Count; i++)
            {
                int songto = int.Parse(lstTinh.Items[i].ToString());
                for (int j = 2; j <= Math.Sqrt(songto); j++)
                {
                    if (songto % j != 0)
                    {
                        count++;
                        break;
                    }
                }
            }
            MessageBox.Show("Co " + count + " nguyen to");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
