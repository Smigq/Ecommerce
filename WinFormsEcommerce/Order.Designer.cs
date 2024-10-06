namespace WinFormsEcommerce
{
    partial class Order
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtOrderStatus;
        private System.Windows.Forms.TextBox txtPaymentId;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Button btnLoadOrders;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.Button btnDeleteOrder;
         protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

    
        private void InitializeComponent()
        {
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtOrderStatus = new System.Windows.Forms.TextBox();
            this.txtPaymentId = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.btnLoadOrders = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(14, 15);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.RowHeadersWidth = 62;
            this.dataGridViewOrders.Size = new System.Drawing.Size(873, 312);
            this.dataGridViewOrders.TabIndex = 0;
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(14, 351);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(148, 26);
            this.txtOrderId.TabIndex = 1;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(170, 351);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(148, 26);
            this.txtTotalPrice.TabIndex = 2;
            // 
            // txtOrderStatus
            // 
            this.txtOrderStatus.Location = new System.Drawing.Point(327, 351);
            this.txtOrderStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOrderStatus.Name = "txtOrderStatus";
            this.txtOrderStatus.Size = new System.Drawing.Size(148, 26);
            this.txtOrderStatus.TabIndex = 3;
            // 
            // txtPaymentId
            // 
            this.txtPaymentId.Location = new System.Drawing.Point(486, 351);
            this.txtPaymentId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPaymentId.Name = "txtPaymentId";
            this.txtPaymentId.Size = new System.Drawing.Size(148, 26);
            this.txtPaymentId.TabIndex = 4;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(645, 351);
            this.txtUserId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(148, 26);
            this.txtUserId.TabIndex = 5;
            // 
            // btnLoadOrders
            // 
            this.btnLoadOrders.Location = new System.Drawing.Point(14, 400);
            this.btnLoadOrders.Name = "btnLoadOrders";
            this.btnLoadOrders.Size = new System.Drawing.Size(150, 37);
            this.btnLoadOrders.TabIndex = 6;
            this.btnLoadOrders.Text = "Load Orders";
            this.btnLoadOrders.UseVisualStyleBackColor = true;
            this.btnLoadOrders.Click += new System.EventHandler(this.btnLoadOrders_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(170, 400);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(152, 37);
            this.btnAddOrder.TabIndex = 7;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Location = new System.Drawing.Point(327, 400);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(150, 37);
            this.btnUpdateOrder.TabIndex = 8;
            this.btnUpdateOrder.Text = "Update Order";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Location = new System.Drawing.Point(486, 400);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(150, 37);
            this.btnDeleteOrder.TabIndex = 9;
            this.btnDeleteOrder.Text = "Delete Order";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 563);
            this.Controls.Add(this.dataGridViewOrders);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.txtOrderStatus);
            this.Controls.Add(this.txtPaymentId);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.btnLoadOrders);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.btnUpdateOrder);
            this.Controls.Add(this.btnDeleteOrder);
            this.Name = "Order";
            this.Text = "Order Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }

}

