namespace SalesProcess

{
    partial class CreateOrderForm
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
            this.lblItemNumber = new System.Windows.Forms.Label();
            this.lblShippingDate = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAddItemToOrder = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.ddlItems = new System.Windows.Forms.ComboBox();
            this.nupQty = new System.Windows.Forms.NumericUpDown();
            this.mtxtShippingDate = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.lblOrderItems = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItemNumber
            // 
            this.lblItemNumber.AutoSize = true;
            this.lblItemNumber.Location = new System.Drawing.Point(48, 37);
            this.lblItemNumber.Name = "lblItemNumber";
            this.lblItemNumber.Size = new System.Drawing.Size(67, 13);
            this.lblItemNumber.TabIndex = 0;
            this.lblItemNumber.Text = "Item Number";
            // 
            // lblShippingDate
            // 
            this.lblShippingDate.AutoSize = true;
            this.lblShippingDate.Location = new System.Drawing.Point(47, 68);
            this.lblShippingDate.Name = "lblShippingDate";
            this.lblShippingDate.Size = new System.Drawing.Size(74, 13);
            this.lblShippingDate.TabIndex = 1;
            this.lblShippingDate.Text = "Shipping Date";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(48, 102);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(48, 132);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(48, 161);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total";
            // 
            // btnAddItemToOrder
            // 
            this.btnAddItemToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItemToOrder.Location = new System.Drawing.Point(51, 195);
            this.btnAddItemToOrder.Name = "btnAddItemToOrder";
            this.btnAddItemToOrder.Size = new System.Drawing.Size(133, 40);
            this.btnAddItemToOrder.TabIndex = 5;
            this.btnAddItemToOrder.Text = "Add To Order";
            this.btnAddItemToOrder.UseVisualStyleBackColor = true;
            this.btnAddItemToOrder.Click += new System.EventHandler(this.btnAddItemToOrder_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(127, 132);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 9;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(127, 161);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 10;
            // 
            // ddlItems
            // 
            this.ddlItems.FormattingEnabled = true;
            this.ddlItems.Location = new System.Drawing.Point(127, 34);
            this.ddlItems.Name = "ddlItems";
            this.ddlItems.Size = new System.Drawing.Size(199, 21);
            this.ddlItems.TabIndex = 11;
            this.ddlItems.SelectedIndexChanged += new System.EventHandler(this.ddlItems_SelectedIndexChanged);
            // 
            // nupQty
            // 
            this.nupQty.Location = new System.Drawing.Point(126, 100);
            this.nupQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupQty.Name = "nupQty";
            this.nupQty.Size = new System.Drawing.Size(120, 20);
            this.nupQty.TabIndex = 12;
            this.nupQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupQty.ValueChanged += new System.EventHandler(this.nupQty_ValueChanged);
            // 
            // mtxtShippingDate
            // 
            this.mtxtShippingDate.Location = new System.Drawing.Point(127, 65);
            this.mtxtShippingDate.Mask = "00/00/0000";
            this.mtxtShippingDate.Name = "mtxtShippingDate";
            this.mtxtShippingDate.Size = new System.Drawing.Size(100, 20);
            this.mtxtShippingDate.TabIndex = 13;
            this.mtxtShippingDate.ValidatingType = typeof(System.DateTime);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(51, 282);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersVisible = false;
            this.dgvOrder.Size = new System.Drawing.Size(485, 188);
            this.dgvOrder.TabIndex = 14;
            // 
            // lblOrderItems
            // 
            this.lblOrderItems.AutoSize = true;
            this.lblOrderItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderItems.Location = new System.Drawing.Point(51, 262);
            this.lblOrderItems.Name = "lblOrderItems";
            this.lblOrderItems.Size = new System.Drawing.Size(121, 17);
            this.lblOrderItems.TabIndex = 15;
            this.lblOrderItems.Text = "Order Summary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Order Total :";
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.AutoSize = true;
            this.lblOrderTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTotal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblOrderTotal.Location = new System.Drawing.Point(347, 263);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(0, 15);
            this.lblOrderTotal.TabIndex = 17;
            // 
            // CreateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 517);
            this.Controls.Add(this.lblOrderTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOrderItems);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.mtxtShippingDate);
            this.Controls.Add(this.nupQty);
            this.Controls.Add(this.ddlItems);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnAddItemToOrder);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblShippingDate);
            this.Controls.Add(this.lblItemNumber);
            this.Name = "CreateOrderForm";
            this.Text = "Customer Order Form";
            ((System.ComponentModel.ISupportInitialize)(this.nupQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItemNumber;
        private System.Windows.Forms.Label lblShippingDate;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAddItemToOrder;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ComboBox ddlItems;
        private System.Windows.Forms.NumericUpDown nupQty;
        private System.Windows.Forms.MaskedTextBox mtxtShippingDate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOrderItems;
        private System.Windows.Forms.DataGridView dgvOrder;
    }
}