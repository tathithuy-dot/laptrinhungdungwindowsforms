namespace BTH1_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radTimesNewRoman_CheckedChanged(object sender, EventArgs e)
        {
            txtNhap.Font = new Font("Times New Roman", txtNhap.Font.Size, txtNhap.Font.Style);
        }

        private void radArial_CheckedChanged(object sender, EventArgs e)
        {
            txtNhap.Font = new Font("Arial", txtNhap.Font.Size, txtNhap.Font.Style);
        }

        private void radTahoma_CheckedChanged(object sender, EventArgs e)
        {
            txtNhap.Font = new Font("Tahoma", txtNhap.Font.Size, txtNhap.Font.Style);
        }

        private void radCourierNew_CheckedChanged(object sender, EventArgs e)
        {
            txtNhap.Font = new Font("Courier New", txtNhap.Font.Size, txtNhap.Font.Style);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
