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
    public partial class Payment : Form
    {
        private readonly System.Net.Http.HttpClient _httpClient;

        public Payment()
        {
            InitializeComponent();
            _httpClient = new System.Net.Http.HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5197/api/");
            this.dataGridViewPayment.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPayment_CellChanged);
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            LoadPaymentsAsync();
        }
        private void LoadPaymentsAsync()
        {
            IEnumerable<CPayment> paymentsList = null;
            try
            {
                var payments = _httpClient.GetAsync("Payment");
                var readData = payments.Result;
                if (readData.IsSuccessStatusCode)
                {
                    var displaydata = readData.Content.ReadFromJsonAsync<IList<CPayment>>();
                    displaydata.Wait();
                    paymentsList = displaydata.Result;

                    dataGridViewPayment.DataSource = paymentsList;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnLoadPayments_Click(object sender, EventArgs e)
        {
            LoadPaymentsAsync();
        }

        private async void btnAddPayment_Click(object sender, EventArgs e)
        {
            string ApiBaseUrl = "http://localhost:5197/api/Payment";
            var payment = new CPayment
            {
                //PaymentId = int.Parse(txtPaymentId.Text),
                PaymentMethod = txtPaymentMethod.Text,
                PaymentStatus = txtPaymentStatus.Text,
                OrderId = int.Parse(txtOrderId.Text)
            };

            try
            {
                var response = await _httpClient.PostAsJsonAsync(ApiBaseUrl, payment);
                response.EnsureSuccessStatusCode();
                LoadPaymentsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void btnUpdatePayment_Click(object sender, EventArgs e)
        {
            string ApiBaseUrl = "http://localhost:5197/api/Payment";
            var payment = new CPayment
            {
                PaymentId = int.Parse(txtPaymentId.Text),
                PaymentMethod = txtPaymentMethod.Text,
                PaymentStatus = txtPaymentStatus.Text,
                OrderId = int.Parse(txtOrderId.Text)
            };

            try
            {
                var response = await _httpClient.PutAsJsonAsync(ApiBaseUrl, payment);
                response.EnsureSuccessStatusCode();
                LoadPaymentsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void btnDeletePayment_Click(object sender, EventArgs e)
        {
            string ApiBaseUrl = "http://localhost:5197/api/Payment";
            int paymentId = int.Parse(txtPaymentId.Text);

            try
            {
                var response = await _httpClient.DeleteAsync($"{ApiBaseUrl}/{paymentId}");
                response.EnsureSuccessStatusCode();
                LoadPaymentsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void dataGridViewPayment_CellChanged(object sender, DataGridViewCellEventArgs e)
        {
            string ApiBaseUrl = "http://localhost:5197/api/Payment";
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewPayment.Rows[e.RowIndex];
                var updatePayment = new CPayment
                {
                    PaymentId = Convert.ToInt32(row.Cells["PaymentId"].Value.ToString()),
                    PaymentMethod = row.Cells["PaymentMethod"].Value.ToString(),
                    PaymentStatus = row.Cells["PaymentStatus"].Value.ToString(),
                    OrderId = Convert.ToInt32(row.Cells["OrderId"].Value.ToString())
                };

                try
                {
                    var response = await _httpClient.PutAsJsonAsync(ApiBaseUrl, updatePayment);
                    response.EnsureSuccessStatusCode();
                    LoadPaymentsAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }

        }
    }
}
