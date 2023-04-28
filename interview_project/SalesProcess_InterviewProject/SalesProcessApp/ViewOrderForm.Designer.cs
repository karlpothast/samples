namespace SalesProcess
{
    partial class ViewOrderForm
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
            this.dgvAllOrders = new System.Windows.Forms.DataGridView();
            this.lblOrders = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllOrders
            // 
            this.dgvAllOrders.AllowUserToAddRows = false;
            this.dgvAllOrders.AllowUserToDeleteRows = false;
            this.dgvAllOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllOrders.Location = new System.Drawing.Point(32, 57);
            this.dgvAllOrders.Name = "dgvAllOrders";
            this.dgvAllOrders.ReadOnly = true;
            this.dgvAllOrders.RowHeadersVisible = false;
            this.dgvAllOrders.Size = new System.Drawing.Size(687, 444);
            this.dgvAllOrders.TabIndex = 3;
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrders.Location = new System.Drawing.Point(29, 22);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(81, 17);
            this.lblOrders.TabIndex = 0;
            this.lblOrders.Text = "All Orders";
            // 
            // ViewOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 549);
            this.Controls.Add(this.dgvAllOrders);
            this.Controls.Add(this.lblOrders);
            this.Name = "ViewOrderForm";
            this.Text = "ViewOrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAllOrders;
        private System.Windows.Forms.Label lblOrders;
    }
}