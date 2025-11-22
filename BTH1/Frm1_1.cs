namespace BaiTH1_1
{
    public partial class Frm1_1 : Form
    {
        public Frm1_1()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tendangnhap = txtUser.Text;
            string matkhau = txtPass.Text;
            string message = $"{tendangnhap},{matkhau}";
            if (chkNho.Checked == true)
            {
                message += "\n Ban co ghi nho mat khau";
            }
            MessageBox.Show(message, "Thong bao");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtUser.Clear();
            this.txtPass.Clear();
            this.txtUser.Focus();
            this.chkNho.Checked = false;
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
    }
}
