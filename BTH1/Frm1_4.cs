namespace BTH1_4
{
    public partial class Frm1_4 : Form
    {
        public Frm1_4()
        {
            InitializeComponent();
        }
        int so1, so2;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            so2 = int.Parse(textBox2.Text);
        }


        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int kq = so2 * so1;
            textBox3.Text = kq.ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            so1 = int.Parse(textBox1.Text);
        }

        private void rad1_CheckedChanged(object sender, EventArgs e)
        {
            int kq = so1 + so2;
            textBox3.Text = kq.ToString();
        }

        private void rad2_CheckedChanged(object sender, EventArgs e)
        {
            int kq = so1 - so2;
            textBox3.Text = kq.ToString();
        }

        private void rad4_CheckedChanged(object sender, EventArgs e)
        {
            int kq = so1 / so2;
            textBox3.Text = kq.ToString();
        }
    }
}
