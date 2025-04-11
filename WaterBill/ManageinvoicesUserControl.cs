using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterBill
{
    public partial class ManageinvoicesUserControl : UserControl
    {
        public ManageInvoices ListInvoices;
        public ManageinvoicesUserControl()
        {
            InitializeComponent();
        }
        public void RefreshInvoiceList()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("No");
            dataTable.Columns.Add("Customer ID");
            dataTable.Columns.Add("Customer Name");
            dataTable.Columns.Add("Customer Type");
            dataTable.Columns.Add("Last Month");
            dataTable.Columns.Add("This Month");
            dataTable.Columns.Add("Total");

            if (ListInvoices != null)
            {
                List<Invoice> invoices = ListInvoices.GetInvoices();
                int i = 1;
                foreach (Invoice invoice in invoices)
                {
                    dataTable.Rows.Add(
                    i++,
                    invoice.customerId,
                    invoice.customerName,
                    invoice.typeOfCustomer,
                    invoice.lastMonthNumber,
                    invoice.thisMonthNumber,
                    invoice.total
                    );
                }
                invoicesDataGridView.DataSource = dataTable;
            }
        }
    }
}
