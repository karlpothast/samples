using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SalesProcess
{
    public partial class CustomerForm : Form
    {
        private DataLayer clsDataLayer = new DataLayer();

        public CustomerForm()
        {
            InitializeComponent();
            LoadDefaultSettings();
        }

        #region Events

        private void CustomerForm_OnLoad(object sender, EventArgs e)
        {
            dgvCustomerList.ClearSelection();
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            CreateOrderForm createOrderForm = new CreateOrderForm(CustomerId);
            createOrderForm.ShowDialog();
        }

        private void btnAddCustomerView_Click(object sender, EventArgs e)
        {
            ClearCustomerForm();
            AddMode = true;

            btnCancelAddUser.Visible = true;
            btnAddUpdateCustomer.Text = "Add Customer";
            btnAddUpdateCustomer.Enabled = true;
            btnAddCustomerView.Enabled = false;
            btnCreateOrder.Enabled = false;
            groupBoxCustomer.Enabled = true;
            txtFirstName.Focus();

        }

        private void btnAddUpdateCustomer_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (ValidateCustomer())
            {
                //remove "-" from zip code mask if only 5 digits entered
                String zipCodeFormatted = mTxtZipCode.Text;
                if (zipCodeFormatted.Trim().Length < 10)
                {
                    zipCodeFormatted = zipCodeFormatted.Substring(0, 5);
                }

                if (AddMode)
                {
                    try
                    {
                        clsDataLayer.InsertCustomer(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtCity.Text,
                            ddlState.SelectedValue.ToString(), zipCodeFormatted);

                        String message = "Customer Added";
                        MessageBox.Show(message);
                        LoadDefaultSettings();

                    }
                    catch (Exception ex)
                    {
                        errorProvider1.SetError(btnAddUpdateCustomer, "Error - " + ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        clsDataLayer.UpdateCustomer(CustomerId, txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtCity.Text,
                            ddlState.SelectedValue.ToString(), zipCodeFormatted);

                        String message = "Customer Updated";
                        MessageBox.Show(message);
                        LoadDefaultSettings();

                    }
                    catch (Exception ex)
                    {
                        errorProvider1.SetError(btnAddUpdateCustomer, "Error - " + ex.Message);
                    }
                }
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this customer?",
                                     "Confirm Delete",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                clsDataLayer.DeleteCustomer(CustomerId);
                String message = "Customer Deleted";
                MessageBox.Show(message);
                LoadDefaultSettings();
            }
        }

        private void btnCancelAddUser_Click(object sender, EventArgs e)
        {
            ClearCustomerForm();
            errorProvider1.Clear();
            AddMode = false;

            btnAddCustomerView.Enabled = true;
            groupBoxCustomer.Enabled = false;
            btnCreateOrder.Enabled = false;
            btnCancelAddUser.Visible = false;
            btnAddUpdateCustomer.Text = "Update Customer";
        }

        private void mTxtZipCode_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                mTxtZipCode.Select(0, 0);
            });
        }

        private void dgvCustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgvSelected = (DataGridView)sender;
            if (dgvSelected.SelectedCells.Count > 0)
            {
                DataGridViewRow dataGridViewRow = dgvSelected.CurrentRow;
                Int32 selectedCustomerId = (Int32)dataGridViewRow.Cells[0].Value;
                CustomerId = selectedCustomerId;
                GetCustomer(selectedCustomerId);

                DataTable dtOpenOrders = new DataTable();
                dtOpenOrders = clsDataLayer.GetOpenCustomerOrders(CustomerId);
                if (dtOpenOrders.Rows.Count > 0)
                {
                    btnCreateOrder.Text = "Open Current Order";
                }
                else
                {
                    btnCreateOrder.Text = "New Order";
                }
            }
        }

        #endregion

        #region Methods

        private void LoadDefaultSettings()
        {
            groupBoxCustomer.Enabled = false;
            btnCreateOrder.Enabled = false;
            btnCancelAddUser.Visible = false;

            //bind state combo box
            ddlState.DataSource = new BindingSource(StateList.getStates(), null);
            ddlState.DisplayMember = "Value";
            ddlState.ValueMember = "Key";

            //bind customer grid
            DataTable dtCustomerList = clsDataLayer.GetCustomerList();
            dtCustomerList.Columns.Add("Name", typeof(string), "LastName + ', ' + FirstName");
            dtCustomerList.Columns.Add("Location", typeof(string), "City + ', ' + State + ' ' + ZipCode");

            dgvCustomerList.DataSource = null;
            dgvCustomerList.DataSource = dtCustomerList;
            dgvCustomerList.Columns["FirstName"].Visible = false;
            dgvCustomerList.Columns["LastName"].Visible = false;
            dgvCustomerList.Columns["Id"].Visible = false;
            dgvCustomerList.Columns["Address"].Visible = false;
            dgvCustomerList.Columns["City"].Visible = false;
            dgvCustomerList.Columns["State"].Visible = false;
            dgvCustomerList.Columns["ZipCode"].Visible = false;
            dgvCustomerList.Columns["Name"].Visible = false;

            DataGridViewLinkColumn editLink = new DataGridViewLinkColumn();
            dgvCustomerList.Columns.Add(editLink);
            editLink.DataPropertyName = "Name";
            editLink.HeaderText = "Name";
            editLink.DisplayIndex = 0;
            editLink.ActiveLinkColor = Color.White;

            AddMode = false;
            ClearCustomerForm();
            errorProvider1.ContainerControl = this;
        }

        private void ClearCustomerForm()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtCity.Text = string.Empty;
            ddlState.SelectedIndex = 0;
            mTxtZipCode.Text = string.Empty;
        }

        private void GetCustomer(Int32 CustomerId)
        {
            AddMode = false;
            SqlDataReader customer = clsDataLayer.GetCustomer(CustomerId);

            customer.Read();
            txtFirstName.Text = (String)customer["FirstName"];
            txtLastName.Text = (String)customer["LastName"];
            txtAddress.Text = (String)customer["Address"];
            txtCity.Text = (String)customer["City"];
            ddlState.SelectedValue = (String)customer["State"];
            mTxtZipCode.Text = (String)customer["ZipCode"];

            groupBoxCustomer.Enabled = true;
            btnCreateOrder.Enabled = true;

        }

        private Boolean ValidateCustomer()
        {
            Boolean customerValidated = false;
            Int16 errCnt = 0;
            errorProvider1.Clear();

            if (txtFirstName.Text == string.Empty) { errorProvider1.SetError(txtFirstName, "Please enter the first name."); errCnt += 1; }
            if (txtLastName.Text == string.Empty) { errorProvider1.SetError(txtLastName, "Please enter the last name."); errCnt += 1; }
            if (txtAddress.Text == string.Empty) { errorProvider1.SetError(txtAddress, "Please enter the address."); errCnt += 1; }
            if (txtCity.Text == string.Empty) { errorProvider1.SetError(txtCity, "Please enter the city."); errCnt += 1; }
            if (ddlState.SelectedValue.ToString() == "") { errorProvider1.SetError(ddlState, "Please select a state."); errCnt += 1; }

            Int32 ZipCodeLength = mTxtZipCode.Text.Trim().Replace("-", "").Length;
            if (ZipCodeLength == 5 || ZipCodeLength == 9) { } else { errorProvider1.SetError(mTxtZipCode, "Please enter a valid 5 or 9 digit zip code."); errCnt += 1; }

            if (errCnt == 0) { customerValidated = true; } else { customerValidated = false; }
            return customerValidated;
        }

        #endregion

        #region Properties

        private Boolean _AddMode;
        public Boolean AddMode
        {
            get
            {
                return _AddMode;
            }
            set
            {
                _AddMode = value;
            }
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

        #endregion

        static class StateList
        {
            static Dictionary<string, string> states = new Dictionary<string, string>();

            public static Dictionary<string, string> getStates()
            {
                states.Clear();
                states.Add("", "");
                states.Add("AL", "Alabama");
                states.Add("AK", "Alaska");
                states.Add("AZ", "Arizona");
                states.Add("AR", "Arkansas");
                states.Add("CA", "California");
                states.Add("CO", "Colorado");
                states.Add("CT", "Connecticut");
                states.Add("DE", "Delaware");
                states.Add("DC", "District of Columbia");
                states.Add("FL", "Florida");
                states.Add("GA", "Georgia");
                states.Add("HI", "Hawaii");
                states.Add("ID", "Idaho");
                states.Add("IL", "Illinois");
                states.Add("IN", "Indiana");
                states.Add("IA", "Iowa");
                states.Add("KS", "Kansas");
                states.Add("KY", "Kentucky");
                states.Add("LA", "Louisiana");
                states.Add("ME", "Maine");
                states.Add("MD", "Maryland");
                states.Add("MA", "Massachusetts");
                states.Add("MI", "Michigan");
                states.Add("MN", "Minnesota");
                states.Add("MS", "Mississippi");
                states.Add("MO", "Missouri");
                states.Add("MT", "Montana");
                states.Add("NE", "Nebraska");
                states.Add("NV", "Nevada");
                states.Add("NH", "New Hampshire");
                states.Add("NJ", "New Jersey");
                states.Add("NM", "New Mexico");
                states.Add("NY", "New York");
                states.Add("NC", "North Carolina");
                states.Add("ND", "North Dakota");
                states.Add("OH", "Ohio");
                states.Add("OK", "Oklahoma");
                states.Add("OR", "Oregon");
                states.Add("PA", "Pennsylvania");
                states.Add("RI", "Rhode Island");
                states.Add("SC", "South Carolina");
                states.Add("SD", "South Dakota");
                states.Add("TN", "Tennessee");
                states.Add("TX", "Texas");
                states.Add("UT", "Utah");
                states.Add("VT", "Vermont");
                states.Add("VA", "Virginia");
                states.Add("WA", "Washington");
                states.Add("WV", "West Virginia");
                states.Add("WI", "Wisconsin");
                states.Add("WY", "Wyoming");
                return states;
            }
        }

    
    }
}
