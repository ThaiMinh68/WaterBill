namespace WaterBill
{
    public partial class WaterBill : Form
    {
        public ManageInvoices FormListInvoices = new ManageInvoices();
        public WaterBill()
        {
            InitializeComponent();
            addInvoiceUserControl.Hide();
            manageinvoicesUserControl.Hide();

            addInvoiceUserControl.ListInvoices = FormListInvoices;
            manageinvoicesUserControl.ListInvoices = FormListInvoices;
        }

        private void AddInvoiceMenuButton_Click(object sender, EventArgs e)
        {
            addInvoiceUserControl.Show();
            manageinvoicesUserControl.Hide();

            AddInvoiceMenuButton.BackColor = Color.DarkGray;
            AddInvoiceMenuButton.ForeColor = Color.White;

            ManageInvoicesMenuButton.BackColor = Color.White;
            ManageInvoicesMenuButton.ForeColor = Color.Black;
        }

        private void ExitMenuButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void manageinvoicesUserControl_Load(object sender, EventArgs e)
        {

        }

        private void ManageInvoicesMenuButton_Click(object sender, EventArgs e)
        {
            addInvoiceUserControl.Hide();
            manageinvoicesUserControl.RefreshInvoiceList();
            manageinvoicesUserControl.Show();

            AddInvoiceMenuButton.BackColor = Color.White;
            AddInvoiceMenuButton.ForeColor = Color.Black;

            ManageInvoicesMenuButton.BackColor = Color.DarkGray;
            ManageInvoicesMenuButton.ForeColor = Color.White;
        }
    }
}
