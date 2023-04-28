using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesProcess
{
    public partial class DefaultForm : Form
    {
        public DefaultForm()
        {
            InitializeComponent();
            try
            {
                DataLayer clsDataLayer = new DataLayer();
                clsDataLayer.TestSQLConnection();
            }
            catch (Exception ex)
            {
                String message = "Data Source Error : " + ex.Message;
                MessageBox.Show(message);
            }
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            ViewOrderForm viewOrderForm = new ViewOrderForm();
            viewOrderForm.ShowDialog();
        }


    }
}
