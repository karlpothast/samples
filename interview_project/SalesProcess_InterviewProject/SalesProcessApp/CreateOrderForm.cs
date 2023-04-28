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
    public partial class CreateOrderForm : Form
    {
        DataLayer clsDataLayer = new DataLayer();

        public CreateOrderForm(Int32 customerId)
        {
            InitializeComponent();
            CustomerId = customerId;
            SetDefaults();
        }

        private Int32 _CustomerId;
        public Int32 CustomerId
        {
            get
            {
                return _CustomerId;
            }
            set
            {
                _CustomerId = value;
            }
        }

        private Boolean _OpenOrderMode;
        public Boolean OpenOrderMode
        {
            get
            {
                return _OpenOrderMode;
            }
            set
            {
                _OpenOrderMode = value;
            }
        }

        private Int32 _OpenOrderId;
        public Int32 OpenOrderId
        {
            get
            {
                return _OpenOrderId;
            }
            set
            {
                _OpenOrderId = value;
            }
        }

        private void SetDefaults()
        {
            DataTable dt = new DataTable();
            dt = clsDataLayer.GetItemList();

            ddlItems.DataSource = dt;
            ddlItems.ValueMember = "Id";
            ddlItems.DisplayMember = "ItemDescription";

            mtxtShippingDate.Text = DateTime.Now.ToString("MM-dd-yyyy"); 

            nupQty.Value = 1;
            BindGrid();

        }

        private void BindGrid() 
        {
            //bind grid
            DataTable dtOpenOrder = clsDataLayer.GetOpenCustomerOrders(CustomerId);
            if (dtOpenOrder.Rows.Count > 0)
            {
                dgvOrder.DataSource = null;
                dgvOrder.DataSource = dtOpenOrder;
                dgvOrder.Visible = true;
                OpenOrderMode = true;
                OpenOrderId = Int32.Parse(dtOpenOrder.Rows[0]["OrderId"].ToString());

                lblOrderTotal.Text = clsDataLayer.GetCustomerOrderTotal(CustomerId).ToString();
            }
            else
            {
                OpenOrderMode = false;
            }
        }

        private void ddlItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            Decimal price = clsDataLayer.GetItemPrice(ddlItems.SelectedIndex);
            txtPrice.Text = price.ToString();

            Int32 qty = (Int32)nupQty.Value;
            Decimal total = price * qty;

            txtTotal.Text = total.ToString();

        }

        private void nupQty_ValueChanged(object sender, EventArgs e)
        {
            Decimal price = clsDataLayer.GetItemPrice(ddlItems.SelectedIndex);
            txtPrice.Text = price.ToString();

            Int32 qty = (Int32)nupQty.Value;
            Decimal total = price * qty;

            txtTotal.Text = total.ToString();
        }

        private void btnAddItemToOrder_Click(object sender, EventArgs e)
        {
            if (ValidateOrder())
            {
                DateTime shipDttm = DateTime.Parse(mtxtShippingDate.Text);
                Decimal price = Decimal.Parse(txtPrice.Text);
                

                String message;
                if (OpenOrderMode)
                {
                    clsDataLayer.AddOrderItem(OpenOrderId, (Int32)ddlItems.SelectedValue, (Int32)nupQty.Value, price);
                    message = "Item Added to Order";
                }
                else
                {
                    clsDataLayer.CreateOrder(CustomerId, shipDttm, (Int32)ddlItems.SelectedValue, (Int32)nupQty.Value, price);
                    message = "Order Created";
                }
               
                MessageBox.Show(message);
                SetDefaults();

            }
        }

        private Boolean ValidateOrder()
        {
            Boolean orderValidated = false;

            Int16 errCnt = 0;
            errorProvider1.Clear();

            if (ddlItems.SelectedValue.ToString() == "0") { errorProvider1.SetError(ddlItems, "Please select an item."); errCnt += 1; }
            if (mtxtShippingDate.Text == string.Empty) { errorProvider1.SetError(mtxtShippingDate, "Please enter a shipping date."); errCnt += 1; }
 
            if (errCnt == 0) { orderValidated = true; } else { orderValidated = false; }

            return orderValidated;
        }
    }
}
