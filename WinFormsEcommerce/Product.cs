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

namespace WinFormsEcommerce
{
    public partial class Product : Form
    {
        private readonly System.Net.Http.HttpClient _httpClient;
        // Replace with your API base URL


        public Product()
        {
            InitializeComponent();
            _httpClient = new System.Net.Http.HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5197/api/");
            this.dataGridViewProducts.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellChanged);
        }

        private void Product_Load(object sender, EventArgs e)
        {
          LoadProductsAsync();
        }

        private async Task LoadProductsAsync()
        {
            IEnumerable<CProducts> productsList = null;
            try
            {
                var response = await _httpClient.GetAsync("Product");
                if (response.IsSuccessStatusCode)
                {
                    var displaydata = await response.Content.ReadFromJsonAsync<IList<CProducts>>();
                    productsList = displaydata;
                    dataGridViewProducts.DataSource = productsList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public async void Load_Product(object sender, EventArgs e)
        {
            await LoadProductsAsync();
        }

        private async void btnLoadProducts_Click(object sender, EventArgs e)
        {
            await LoadProductsAsync();
        }

        private async void btnAddProduct_Click(object sender, EventArgs e)
        {
            string ApiBaseUrl = "http://localhost:5197/api/Product";
            var product = new CProducts
            {
                //ProductId = int.Parse(txtProductId.Text),
                Name = txtName.Text,
                Description = txtDescription.Text,
                Price = int.Parse(txtPrice.Text),
                StockQuantity = int.Parse(txtStockQuantity.Text),
                OrderDetailsId = int.Parse(txtOrderDetailsId.Text)
            };

            try
            {
                var response = await _httpClient.PostAsJsonAsync(ApiBaseUrl, product);
                response.EnsureSuccessStatusCode();
                await LoadProductsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private async void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            string ApiBaseUrl = "http://localhost:5197/api/Product";
            var product = new CProducts
            {
                ProductId = int.Parse(txtProductId.Text),
                Name = txtName.Text,
                Description = txtDescription.Text,
                Price = int.Parse(txtPrice.Text),
                StockQuantity = int.Parse(txtStockQuantity.Text),
                OrderDetailsId = int.Parse(txtOrderDetailsId.Text)
            };

            try
            {
                var response = await _httpClient.PutAsJsonAsync(ApiBaseUrl, product);
                response.EnsureSuccessStatusCode();
                await LoadProductsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            string ApiBaseUrl = "http://localhost:5197/api/Product";
            int productId = int.Parse(txtProductId.Text);

            try
            {
                var response = await _httpClient.DeleteAsync($"{ApiBaseUrl}/{productId}");
                response.EnsureSuccessStatusCode();
                await LoadProductsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void dataGridViewProducts_CellChanged(object sender, DataGridViewCellEventArgs e)
        {
            string ApiBaseUrl = "http://localhost:5197/api/Product";
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewProducts.Rows[e.RowIndex];
                var updateProduct = new CProducts
                {
                    ProductId = Convert.ToInt32(row.Cells["ProductId"].Value.ToString()),
                    Name = row.Cells["Name"].Value.ToString(),
                    Price = Convert.ToInt32(row.Cells["Price"].Value.ToString()),
                    Description = row.Cells["Description"].Value.ToString(),
                    StockQuantity = Convert.ToInt32(row.Cells["StockQuantity"].Value.ToString()),
                    OrderDetailsId = Convert.ToInt32(row.Cells["OrderDetailsId"].Value.ToString())
                };

                try
                {
                    var response = await _httpClient.PutAsJsonAsync(ApiBaseUrl, updateProduct);
                    response.EnsureSuccessStatusCode();
                    await LoadProductsAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
    }
}
