namespace WinFormsEcommerce
{
    partial class OrderDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewOrderDetails;
        private System.Windows.Forms.TextBox txtOrderDetailsId;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Button btnLoadOrderDetails;
        private System.Windows.Forms.Button btnAddOrderDetails;
        private System.Windows.Forms.Button btnUpdateOrderDetails;
        private System.Windows.Forms.Button btnDeleteOrderDetails;

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
        private void InitializeComponent()
        {
            this.dataGridViewOrderDetails = new System.Windows.Forms.DataGridView();
            this.txtOrderDetailsId = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnLoadOrderDetails = new System.Windows.Forms.Button();
            this.btnAddOrderDetails = new System.Windows.Forms.Button();
            this.btnUpdateOrderDetails = new System.Windows.Forms.Button();
            this.btnDeleteOrderDetails = new System.Windows.Forms.Button();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrderDetails
            // 
            this.dataGridViewOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderDetails.Location = new System.Drawing.Point(14, 15);
            this.dataGridViewOrderDetails.Name = "dataGridViewOrderDetails";
            this.dataGridViewOrderDetails.RowHeadersWidth = 62;
            this.dataGridViewOrderDetails.Size = new System.Drawing.Size(873, 312);
            this.dataGridViewOrderDetails.TabIndex = 0;
            // 
            // txtOrderDetailsId
            // 
            this.txtOrderDetailsId.Location = new System.Drawing.Point(14, 351);
            this.txtOrderDetailsId.Name = "txtOrderDetailsId";
            this.txtOrderDetailsId.Size = new System.Drawing.Size(148, 26);
            this.txtOrderDetailsId.TabIndex = 1;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(170, 351);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(148, 26);
            this.txtResult.TabIndex = 2;
            // 
            // btnLoadOrderDetails
            // 
            this.btnLoadOrderDetails.Location = new System.Drawing.Point(14, 400);
            this.btnLoadOrderDetails.Name = "btnLoadOrderDetails";
            this.btnLoadOrderDetails.Size = new System.Drawing.Size(150, 37);
            this.btnLoadOrderDetails.TabIndex = 6;
            this.btnLoadOrderDetails.Text = "Load OrderDetails";
            this.btnLoadOrderDetails.UseVisualStyleBackColor = true;
            this.btnLoadOrderDetails.Click += new System.EventHandler(this.btnLoadOrderDetails_Click);
            // 
            // btnAddOrderDetails
            // 
            this.btnAddOrderDetails.Location = new System.Drawing.Point(170, 400);
            this.btnAddOrderDetails.Name = "btnAddOrderDetails";
            this.btnAddOrderDetails.Size = new System.Drawing.Size(152, 37);
            this.btnAddOrderDetails.TabIndex = 7;
            this.btnAddOrderDetails.Text = "Add OrderDetails";
            this.btnAddOrderDetails.UseVisualStyleBackColor = true;
            this.btnAddOrderDetails.Click += new System.EventHandler(this.btnAddOrderDetails_Click);
            // 
            // btnUpdateOrderDetails
            // 
            this.btnUpdateOrderDetails.Location = new System.Drawing.Point(327, 400);
            this.btnUpdateOrderDetails.Name = "btnUpdateOrderDetails";
            this.btnUpdateOrderDetails.Size = new System.Drawing.Size(150, 37);
            this.btnUpdateOrderDetails.TabIndex = 8;
            this.btnUpdateOrderDetails.Text = "Update OrderDetails";
            this.btnUpdateOrderDetails.UseVisualStyleBackColor = true;
            this.btnUpdateOrderDetails.Click += new System.EventHandler(this.btnUpdateOrderDetails_Click);
            // 
            // btnDeleteOrderDetails
            // 
            this.btnDeleteOrderDetails.Location = new System.Drawing.Point(486, 400);
            this.btnDeleteOrderDetails.Name = "btnDeleteOrderDetails";
            this.btnDeleteOrderDetails.Size = new System.Drawing.Size(150, 37);
            this.btnDeleteOrderDetails.TabIndex = 9;
            this.btnDeleteOrderDetails.Text = "Delete OrderDetails";
            this.btnDeleteOrderDetails.UseVisualStyleBackColor = true;
            this.btnDeleteOrderDetails.Click += new System.EventHandler(this.btnDeleteOrderDetails_Click);
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(327, 351);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(154, 26);
            this.txtOrderId.TabIndex = 10;
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(487, 351);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(154, 26);
            this.txtProductId.TabIndex = 11;
            // 
            // OrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 563);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.dataGridViewOrderDetails);
            this.Controls.Add(this.txtOrderDetailsId);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnLoadOrderDetails);
            this.Controls.Add(this.btnAddOrderDetails);
            this.Controls.Add(this.btnUpdateOrderDetails);
            this.Controls.Add(this.btnDeleteOrderDetails);
            this.Name = "OrderDetails";
            this.Text = "Payment Management";
            this.Load += new System.EventHandler(this.OrderDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}