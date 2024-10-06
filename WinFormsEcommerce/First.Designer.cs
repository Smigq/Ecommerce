namespace WinFormsEcommerce
{
    partial class First
    {

        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnOrderDetails;

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
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnOrderDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(33, 22);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(96, 38);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Open Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.OrderButton_CLick);
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(33, 75);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(2);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(96, 38);
            this.btnPayment.TabIndex = 1;
            this.btnPayment.Text = "Open Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.PaymentButton_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(33, 128);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(96, 38);
            this.btnProduct.TabIndex = 2;
            this.btnProduct.Text = "Open Product";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.ProductButton_CLick);
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(33, 182);
            this.btnUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(96, 38);
            this.btnUser.TabIndex = 3;
            this.btnUser.Text = "Open User";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.UserButton_Click);
            // 
            // btnOrderDetails
            // 
            this.btnOrderDetails.Location = new System.Drawing.Point(33, 230);
            this.btnOrderDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrderDetails.Name = "btnOrderDetails";
            this.btnOrderDetails.Size = new System.Drawing.Size(96, 38);
            this.btnOrderDetails.TabIndex = 4;
            this.btnOrderDetails.Text = "Open OrderDetails";
            this.btnOrderDetails.UseVisualStyleBackColor = true;
            this.btnOrderDetails.Click += new System.EventHandler(this.OrderDetailsButton_Click);
            // 
            // First
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(165, 291);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnOrderDetails);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "First";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.First_Load);
            this.ResumeLayout(false);

        }


    }
}