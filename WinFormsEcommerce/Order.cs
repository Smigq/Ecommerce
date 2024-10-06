using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsEcommerce
{
    public partial class Order : Form { 

        private readonly System.Net.Http.HttpClient _httpClient;
    
        public Order()
        {
            InitializeComponent();
            _httpClient = new System.Net.Http.HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5197/api/");
            this.dataGridViewOrders.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrders_CellChanged);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadOrdersAsync();
        }
        private void LoadOrdersAsync()
        {
            IEnumerable<COrder> ordersList = null;
            try
            {
                var orders = _httpClient.GetAsync("Order");
                var readData = orders.Result;
                if (readData.IsSuccessStatusCode)
                {
                    var displaydata = readData.Content.ReadFromJsonAsync<IList<COrder>>();
                    displaydata.Wait();
                    ordersList = displaydata.Result;

                    dataGridViewOrders.DataSource = ordersList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnLoadOrders_Click(object sender, EventArgs e)
        {
            LoadOrdersAsync();
        }

        private async void btnAddOrder_Click(object sender, EventArgs e)
        {
            string ApiBaseUrl = "http://localhost:5197/api/Order";
            var order = new COrder
            {
                //OrderId = int.Parse(txtOrderId.Text),
                TotalPrice = int.Parse(txtTotalPrice.Text),
                OrderStatus = txtOrderStatus.Text,
                PaymentId = int.Parse(txtPaymentId.Text),
                UserId = int.Parse(txtUserId.Text),
            };

            try
            {
                var response = await _httpClient.PostAsJsonAsync(ApiBaseUrl, order);
                response.EnsureSuccessStatusCode();
                LoadOrdersAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private async void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            string ApiBaseUrl = "http://localhost:5197/api/Order";
            var order = new COrder
            {
                OrderId = int.Parse(txtOrderId.Text),
                TotalPrice = int.Parse(txtTotalPrice.Text),
                OrderStatus = txtOrderStatus.Text,
                PaymentId = int.Parse(txtPaymentId.Text),
                UserId = int.Parse(txtUserId.Text),

            };

            try
            {
                var response = await _httpClient.PutAsJsonAsync(ApiBaseUrl, order);
                response.EnsureSuccessStatusCode();
                LoadOrdersAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            string ApiBaseUrl = "http://localhost:5197/api/Order";
            int orderId = int.Parse(txtOrderId.Text);

            try
            {
                var response = await _httpClient.DeleteAsync($"{ApiBaseUrl}/{orderId}");
                response.EnsureSuccessStatusCode();
                LoadOrdersAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void dataGridViewOrders_CellChanged(object sender, DataGridViewCellEventArgs e)
        {
            string ApiBaseUrl = "http://localhost:5197/api/Order";
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewOrders.Rows[e.RowIndex];
                var updateOrder = new COrder
                {
                    OrderId = Convert.ToInt32(row.Cells["OrderId"].Value.ToString()),
                    TotalPrice = Convert.ToInt32(row.Cells["TotalPrice"].Value.ToString()),
                    OrderStatus = row.Cells["OrderStatus"].Value.ToString(),
                    PaymentId = Convert.ToInt32(row.Cells["PaymentId"].Value.ToString()),
                    UserId = Convert.ToInt32(row.Cells["UserId"].Value.ToString()),
                    
                };

                try
                {
                    var response = await _httpClient.PutAsJsonAsync(ApiBaseUrl, updateOrder);
                    response.EnsureSuccessStatusCode();
                    LoadOrdersAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }

        }
    }
}
