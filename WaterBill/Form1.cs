namespace WaterBill
{
    public partial class WaterBill : Form
    {
        public WaterBill()
        {
            InitializeComponent();
            addInvoiceUserControl.Hide();
        }

        private void AddInvoiceMenuButton_Click(object sender, EventArgs e)
        {
            addInvoiceUserControl.Show();
            AddInvoiceMenuButton.BackColor = Color.DarkGray;
            AddInvoiceMenuButton.ForeColor = Color.White;
        }

        private void ExitMenuButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
