using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsEcommerce
{
    public partial class First : Form
    {
        public First()
        {
            InitializeComponent();
        }

        private void OrderButton_CLick(object sender, EventArgs e)
        {
            Form order = new Order();
            order.Show();
            this.Hide();

            order.FormClosed += (s, args) => this.Show();
        }

        private void ProductButton_CLick(object sender, EventArgs e)
        {
            Form product = new Product();
            product.Show();
            this.Hide();

            product.FormClosed += (s, args) => this.Show();
        }

        private void PaymentButton_Click(object sender, EventArgs e)
        { 
            Form payment = new Payment();
            payment.Show();
            this.Hide();

            payment.FormClosed += (s, args) => this.Show();
        }

        private void UserButton_Click(object sender, EventArgs e)
        { 
            Form user = new User();
            user.Show();
            this.Hide();

            user.FormClosed += (s, args) => this.Show();
        }
        private void OrderDetailsButton_Click(object sender, EventArgs e)
        {
            Form orderD = new OrderDetails();
            orderD.Show();
            this.Hide();

            orderD.FormClosed += (s, args) => this.Show();
        }

        private void First_Load(object sender, EventArgs e)
        {

        }
    }
}
