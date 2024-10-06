using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsEcommerce
{
    public partial class OrderDetails : Form
    {
        private readonly System.Net.Http.HttpClient _httpClient;
        public OrderDetails()
        {
            InitializeComponent();
            _httpClient = new System.Net.Http.HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5197/api/");
            this.dataGridViewOrderDetails.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrderDetails_CellChanged);
        }
        
        private void OrderDetails_Load(object sender, EventArgs e)
        {
            LoadOrderDetailsAsync();
        }

        private void LoadOrderDetailsAsync()
        {
            IEnumerable<COrderDetails> orderDetailsList = null;
            try
            {
                var orderDetails = _httpClient.GetAsync("OrderDetails");
                var readData = orderDetails.Result;
                if (readData.IsSuccessStatusCode)
                {
                    var displaydata = readData.Content.ReadFromJsonAsync<IList<COrderDetails>>();
                    displaydata.Wait();
                    orderDetailsList = displaydata.Result;

                    dataGridViewOrderDetails.DataSource = orderDetailsList;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void btnLoadOrderDetails_Click(object sender, EventArgs e)
        {
            LoadOrderDetailsAsync();
        }

        private async void btnAddOrderDetails_Click(object sender, EventArgs e)
        {
            string ApiBaseUrl = "http://localhost:5197/api/OrderDetails";
            var orderD = new COrderDetails
            {
                //PaymentId = int.Parse(txtPaymentId.Text),
                Result = txtResult.Text,
                OrderId = int.Parse(txtOrderId.Text),
                ProductId = int.Parse(txtProductId.Text),
            };

            try
            {
                var response = await _httpClient.PostAsJsonAsync(ApiBaseUrl, orderD);
                response.EnsureSuccessStatusCode();
                LoadOrderDetailsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void btnUpdateOrderDetails_Click(object sender, EventArgs e)
        {
            string ApiBaseUrl = "http://localhost:5197/api/OrderDetails";
            var orderD = new COrderDetails
            {
                OrderDetailsId = int.Parse(txtOrderDetailsId.Text),
                Result = txtResult.Text,
                OrderId = int.Parse(txtOrderId.Text),
                ProductId = int.Parse(txtProductId.Text),
            };

            try
            {
                var response = await _httpClient.PutAsJsonAsync(ApiBaseUrl, orderD);
                response.EnsureSuccessStatusCode();
                LoadOrderDetailsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void btnDeleteOrderDetails_Click(object sender, EventArgs e)
        {
            string ApiBaseUrl = "http://localhost:5197/api/OrderDetails";
            int OrderDetailsId = int.Parse(txtOrderDetailsId.Text);

            try
            {
                var response = await _httpClient.DeleteAsync($"{ApiBaseUrl}/{OrderDetailsId}");
                response.EnsureSuccessStatusCode();
                LoadOrderDetailsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void dataGridViewOrdersDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private async void dataGridViewOrderDetails_CellChanged(object sender, DataGridViewCellEventArgs e)
        {
            string ApiBaseUrl = "http://localhost:5197/api/OrderDetails";
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewOrderDetails.Rows[e.RowIndex];
                var updateOrder = new COrderDetails
                {
                    OrderDetailsId = Convert.ToInt32(row.Cells["OrderDetailsId"].Value.ToString()),
                    Result = row.Cells["Result"].Value.ToString(),
                    OrderId = Convert.ToInt32(row.Cells["OrderId"].Value.ToString()),
                    ProductId = Convert.ToInt32(row.Cells["ProductId"].Value.ToString())

                };

                try
                {
                    var response = await _httpClient.PutAsJsonAsync(ApiBaseUrl, updateOrder);
                    response.EnsureSuccessStatusCode();
                    LoadOrderDetailsAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }

        }
    }
}
