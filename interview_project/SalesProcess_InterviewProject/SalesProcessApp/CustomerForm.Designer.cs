namespace SalesProcess
{
    partial class CustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.dgvCustomerList = new System.Windows.Forms.DataGridView();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.btnAddUpdateCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.lblCustomerList = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.groupBoxCustomer = new System.Windows.Forms.GroupBox();
            this.mTxtZipCode = new System.Windows.Forms.MaskedTextBox();
            this.ddlState = new System.Windows.Forms.ComboBox();
            this.btnAddCustomerView = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancelAddUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).BeginInit();
            this.groupBoxCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(32, 46);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(63, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name :";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(32, 76);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(64, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name :";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(102, 41);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(181, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(102, 73);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(181, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(103, 103);
            this.txtAddress.MaxLength = 100;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(277, 20);
            this.txtAddress.TabIndex = 5;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(33, 108);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(51, 13);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address :";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(103, 129);
            this.txtCity.MaxLength = 100;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(181, 20);
            this.txtCity.TabIndex = 7;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(33, 135);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(30, 13);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "City :";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(33, 161);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(38, 13);
            this.lblState.TabIndex = 8;
            this.lblState.Text = "State :";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(33, 188);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(56, 13);
            this.lblZipCode.TabIndex = 10;
            this.lblZipCode.Text = "Zip Code :";
            // 
            // dgvCustomerList
            // 
            this.dgvCustomerList.AllowUserToAddRows = false;
            this.dgvCustomerList.AllowUserToDeleteRows = false;
            this.dgvCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerList.Location = new System.Drawing.Point(22, 54);
            this.dgvCustomerList.Name = "dgvCustomerList";
            this.dgvCustomerList.ReadOnly = true;
            this.dgvCustomerList.RowHeadersVisible = false;
            this.dgvCustomerList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCustomerList.Size = new System.Drawing.Size(291, 383);
            this.dgvCustomerList.TabIndex = 12;
            this.dgvCustomerList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerList_CellContentClick);
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateOrder.Location = new System.Drawing.Point(383, 403);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(199, 34);
            this.btnCreateOrder.TabIndex = 13;
            this.btnCreateOrder.Text = "New Order";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // btnAddUpdateCustomer
            // 
            this.btnAddUpdateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUpdateCustomer.Location = new System.Drawing.Point(35, 251);
            this.btnAddUpdateCustomer.Name = "btnAddUpdateCustomer";
            this.btnAddUpdateCustomer.Size = new System.Drawing.Size(142, 34);
            this.btnAddUpdateCustomer.TabIndex = 14;
            this.btnAddUpdateCustomer.Text = "Update Customer";
            this.btnAddUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnAddUpdateCustomer.Click += new System.EventHandler(this.btnAddUpdateCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCustomer.Location = new System.Drawing.Point(209, 251);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(142, 34);
            this.btnDeleteCustomer.TabIndex = 15;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // lblCustomerList
            // 
            this.lblCustomerList.AutoSize = true;
            this.lblCustomerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerList.Location = new System.Drawing.Point(19, 22);
            this.lblCustomerList.Name = "lblCustomerList";
            this.lblCustomerList.Size = new System.Drawing.Size(107, 17);
            this.lblCustomerList.TabIndex = 16;
            this.lblCustomerList.Text = "Customer List";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMsg.Location = new System.Drawing.Point(354, 253);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 13);
            this.lblMsg.TabIndex = 17;
            // 
            // groupBoxCustomer
            // 
            this.groupBoxCustomer.Controls.Add(this.mTxtZipCode);
            this.groupBoxCustomer.Controls.Add(this.ddlState);
            this.groupBoxCustomer.Controls.Add(this.lblFirstName);
            this.groupBoxCustomer.Controls.Add(this.lblLastName);
            this.groupBoxCustomer.Controls.Add(this.txtFirstName);
            this.groupBoxCustomer.Controls.Add(this.txtLastName);
            this.groupBoxCustomer.Controls.Add(this.btnDeleteCustomer);
            this.groupBoxCustomer.Controls.Add(this.lblAddress);
            this.groupBoxCustomer.Controls.Add(this.btnAddUpdateCustomer);
            this.groupBoxCustomer.Controls.Add(this.txtAddress);
            this.groupBoxCustomer.Controls.Add(this.lblCity);
            this.groupBoxCustomer.Controls.Add(this.txtCity);
            this.groupBoxCustomer.Controls.Add(this.lblState);
            this.groupBoxCustomer.Controls.Add(this.lblZipCode);
            this.groupBoxCustomer.Location = new System.Drawing.Point(348, 57);
            this.groupBoxCustomer.Name = "groupBoxCustomer";
            this.groupBoxCustomer.Size = new System.Drawing.Size(408, 316);
            this.groupBoxCustomer.TabIndex = 19;
            this.groupBoxCustomer.TabStop = false;
            this.groupBoxCustomer.Text = "Customer Detail";
            // 
            // mTxtZipCode
            // 
            this.mTxtZipCode.Location = new System.Drawing.Point(103, 188);
            this.mTxtZipCode.Mask = "00000-9999";
            this.mTxtZipCode.Name = "mTxtZipCode";
            this.mTxtZipCode.Size = new System.Drawing.Size(100, 20);
            this.mTxtZipCode.TabIndex = 17;
            this.mTxtZipCode.Enter += new System.EventHandler(this.mTxtZipCode_Enter);
            // 
            // ddlState
            // 
            this.ddlState.FormattingEnabled = true;
            this.ddlState.Location = new System.Drawing.Point(103, 158);
            this.ddlState.Name = "ddlState";
            this.ddlState.Size = new System.Drawing.Size(121, 21);
            this.ddlState.TabIndex = 16;
            // 
            // btnAddCustomerView
            // 
            this.btnAddCustomerView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomerView.Location = new System.Drawing.Point(174, 15);
            this.btnAddCustomerView.Name = "btnAddCustomerView";
            this.btnAddCustomerView.Size = new System.Drawing.Size(140, 31);
            this.btnAddCustomerView.TabIndex = 20;
            this.btnAddCustomerView.Text = "Add Customer 🡆";
            this.btnAddCustomerView.UseVisualStyleBackColor = true;
            this.btnAddCustomerView.Click += new System.EventHandler(this.btnAddCustomerView_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // btnCancelAddUser
            // 
            this.btnCancelAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAddUser.Location = new System.Drawing.Point(346, 15);
            this.btnCancelAddUser.Name = "btnCancelAddUser";
            this.btnCancelAddUser.Size = new System.Drawing.Size(84, 31);
            this.btnCancelAddUser.TabIndex = 21;
            this.btnCancelAddUser.Text = "Cancel";
            this.btnCancelAddUser.UseVisualStyleBackColor = true;
            this.btnCancelAddUser.Click += new System.EventHandler(this.btnCancelAddUser_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.btnCancelAddUser);
            this.Controls.Add(this.btnAddCustomerView);
            this.Controls.Add(this.groupBoxCustomer);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.lblCustomerList);
            this.Controls.Add(this.dgvCustomerList);
            this.Controls.Add(this.btnCreateOrder);
            this.Name = "CustomerForm";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.CustomerForm_OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).EndInit();
            this.groupBoxCustomer.ResumeLayout(false);
            this.groupBoxCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.DataGridView dgvCustomerList;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Button btnAddUpdateCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Label lblCustomerList;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.GroupBox groupBoxCustomer;
        private System.Windows.Forms.Button btnAddCustomerView;
        private System.Windows.Forms.ComboBox ddlState;
        private System.Windows.Forms.MaskedTextBox mTxtZipCode;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnCancelAddUser;
    }
}