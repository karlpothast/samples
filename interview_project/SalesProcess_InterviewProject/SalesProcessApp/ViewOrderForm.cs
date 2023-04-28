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
    public partial class ViewOrderForm : Form
    {
        DataLayer clsDataLayer = new DataLayer();

        public ViewOrderForm()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dt = clsDataLayer.GetAllCustomerOrders();
            dgvAllOrders.DataSource = dt;

        }
    }
}
