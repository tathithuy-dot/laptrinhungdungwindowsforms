namespace BTH1_2
{
    public partial class Frm1_2 : Form
    {
        public Frm1_2()
        {
            InitializeComponent();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string hoten = txtHoTen.Text;
            if (rad1.Checked == true)
            {
                txtKQ.Text = hoten.ToLower();
            }
            if (rad2.Checked == true)
            {
                txtKQ.Text = hoten.ToUpper();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtHoTen.Clear();
            this.txtKQ.Clear();
            this.txtHoTen.Focus();
            this.rad1.Checked = true;
        }
    }
}
