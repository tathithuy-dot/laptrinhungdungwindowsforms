namespace BaiTH2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem it = new ListViewItem(txtLastName.Text);
            it.SubItems.Add(txtFirstName.Text);
            it.SubItems.Add(txtPhone.Text);
            this.listView1.Items.Add(it);
        }
    }
}
