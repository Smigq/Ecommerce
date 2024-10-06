namespace WinFormsEcommerce
{
    partial class Payment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewPayment;

        private System.Windows.Forms.TextBox txtPaymentId;
        private System.Windows.Forms.TextBox txtPaymentMethod;
        private System.Windows.Forms.TextBox txtPaymentStatus;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Button btnLoadPayments;
        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.Button btnUpdatePayment;
        private System.Windows.Forms.Button btnDeletePayment;

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
            this.dataGridViewPayment = new System.Windows.Forms.DataGridView();
            this.txtPaymentId = new System.Windows.Forms.TextBox();
            this.txtPaymentMethod = new System.Windows.Forms.TextBox();
            this.txtPaymentStatus = new System.Windows.Forms.TextBox();
            this.btnLoadPayments = new System.Windows.Forms.Button();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.btnUpdatePayment = new System.Windows.Forms.Button();
            this.btnDeletePayment = new System.Windows.Forms.Button();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPayment
            // 
            this.dataGridViewPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPayment.Location = new System.Drawing.Point(14, 15);
            this.dataGridViewPayment.Name = "dataGridViewPayment";
            this.dataGridViewPayment.RowHeadersWidth = 62;
            this.dataGridViewPayment.Size = new System.Drawing.Size(873, 312);
            this.dataGridViewPayment.TabIndex = 0;
            // 
            // txtPaymentId
            // 
            this.txtPaymentId.Location = new System.Drawing.Point(14, 351);
            this.txtPaymentId.Name = "txtPaymentId";
            this.txtPaymentId.Size = new System.Drawing.Size(148, 26);
            this.txtPaymentId.TabIndex = 1;
            // 
            // txtPaymentMethod
            // 
            this.txtPaymentMethod.Location = new System.Drawing.Point(170, 351);
            this.txtPaymentMethod.Name = "txtPaymentMethod";
            this.txtPaymentMethod.Size = new System.Drawing.Size(148, 26);
            this.txtPaymentMethod.TabIndex = 2;
            // 
            // txtPaymentStatus
            // 
            this.txtPaymentStatus.Location = new System.Drawing.Point(327, 351);
            this.txtPaymentStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPaymentStatus.Name = "txtPaymentStatus";
            this.txtPaymentStatus.Size = new System.Drawing.Size(148, 26);
            this.txtPaymentStatus.TabIndex = 3;
            // 
            // btnLoadPayments
            // 
            this.btnLoadPayments.Location = new System.Drawing.Point(14, 400);
            this.btnLoadPayments.Name = "btnLoadPayments";
            this.btnLoadPayments.Size = new System.Drawing.Size(150, 37);
            this.btnLoadPayments.TabIndex = 6;
            this.btnLoadPayments.Text = "Load Payments";
            this.btnLoadPayments.UseVisualStyleBackColor = true;
            this.btnLoadPayments.Click += new System.EventHandler(this.btnLoadPayments_Click);
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Location = new System.Drawing.Point(170, 400);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(152, 37);
            this.btnAddPayment.TabIndex = 7;
            this.btnAddPayment.Text = "Add Payment";
            this.btnAddPayment.UseVisualStyleBackColor = true;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // btnUpdatePayment
            // 
            this.btnUpdatePayment.Location = new System.Drawing.Point(327, 400);
            this.btnUpdatePayment.Name = "btnUpdatePayment";
            this.btnUpdatePayment.Size = new System.Drawing.Size(150, 37);
            this.btnUpdatePayment.TabIndex = 8;
            this.btnUpdatePayment.Text = "Update Payment";
            this.btnUpdatePayment.UseVisualStyleBackColor = true;
            this.btnUpdatePayment.Click += new System.EventHandler(this.btnUpdatePayment_Click);
            // 
            // btnDeletePayment
            // 
            this.btnDeletePayment.Location = new System.Drawing.Point(486, 400);
            this.btnDeletePayment.Name = "btnDeletePayment";
            this.btnDeletePayment.Size = new System.Drawing.Size(150, 37);
            this.btnDeletePayment.TabIndex = 9;
            this.btnDeletePayment.Text = "Delete Payment";
            this.btnDeletePayment.UseVisualStyleBackColor = true;
            this.btnDeletePayment.Click += new System.EventHandler(this.btnDeletePayment_Click);
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(482, 351);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(154, 26);
            this.txtOrderId.TabIndex = 10;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 563);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.dataGridViewPayment);
            this.Controls.Add(this.txtPaymentId);
            this.Controls.Add(this.txtPaymentMethod);
            this.Controls.Add(this.txtPaymentStatus);
            this.Controls.Add(this.btnLoadPayments);
            this.Controls.Add(this.btnAddPayment);
            this.Controls.Add(this.btnUpdatePayment);
            this.Controls.Add(this.btnDeletePayment);
            this.Name = "Payment";
            this.Text = "Payment Management";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}