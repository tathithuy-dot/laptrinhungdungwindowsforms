namespace BTH1_5
{
    public partial class Frm1_5 : Form
    {
        public Frm1_5()
        {
            InitializeComponent();
            lblKQ.ForeColor = Color.Red;
            textBox1.ForeColor = Color.Red;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblKQ.Text = textBox1.Text;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            lblKQ.ForeColor = Color.Red;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            lblKQ.ForeColor = Color.Green;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            lblKQ.ForeColor = Color.Blue;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            lblKQ.ForeColor = Color.Black;
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            lblKQ.Font = new Font(lblKQ.Font, lblKQ.Font.Style ^ FontStyle.Bold);
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            lblKQ.Font = new Font(lblKQ.Font, lblKQ.Font.Style ^ FontStyle.Italic);
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            lblKQ.Font = new Font(lblKQ.Font, lblKQ.Font.Style ^ FontStyle.Underline);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm1_5_Load(object sender, EventArgs e)
        {
            radRed.Checked = true;
        }
    }
}
