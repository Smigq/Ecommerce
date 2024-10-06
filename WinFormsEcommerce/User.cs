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
    public partial class User : Form
    {
        private readonly System.Net.Http.HttpClient _httpClient;

        public User()
        {
            InitializeComponent();
            _httpClient = new System.Net.Http.HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5197/api/");
            this.dataGridViewUsers.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellChanged);
            dataGridViewUsers.SelectionChanged += dataGridViewUsers_SelectionChanged;
            ClearTextFields();
        }

        private void User_Load(object sender, EventArgs e)
        {
            LoadUsersAsync();
        }

        private void LoadUsersAsync()
        {
            IEnumerable<CUser> usersList = null;
            try
            {
                var users = _httpClient.GetAsync("User");
                var readData = users.Result;
                if (readData.IsSuccessStatusCode)
                {
                    var displaydata = readData.Content.ReadFromJsonAsync<IList<CUser>>();
                    displaydata.Wait();
                    usersList = displaydata.Result;

                    dataGridViewUsers.DataSource = usersList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnLoadUsers_Click(object sender, EventArgs e)
        {
            LoadUsersAsync();
        }

        private async void btnAddUser_Click(object sender, EventArgs e)
        {
            string ApiBaseUrl = "http://localhost:5197/api/User";
            var user = new CUser
            {
                //UserId = int.Parse(txtUserId.Text),
                UserName = txtUserName.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
            };

            try
            {
                var response = await _httpClient.PostAsJsonAsync(ApiBaseUrl, user);
                response.EnsureSuccessStatusCode();
                LoadUsersAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void btnUpdateUser_Click(object sender, EventArgs e)
        {
            string ApiBaseUrl = "http://localhost:5197/api/User";
            var user = new CUser
            {
                UserId = int.Parse(txtUserId.Text),
                UserName = txtUserName.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
            };

            try
            {
                var response = await _httpClient.PutAsJsonAsync(ApiBaseUrl, user);
                response.EnsureSuccessStatusCode();
                LoadUsersAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void btnDeleteUser_Click(object sender, EventArgs e)
        {
            string ApiBaseUrl = "http://localhost:5197/api/User";
            int userId = int.Parse(txtUserId.Text);

            try
            {
                var response = await _httpClient.DeleteAsync($"{ApiBaseUrl}/{userId}");
                response.EnsureSuccessStatusCode();
                LoadUsersAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void dataGridViewUsers_CellChanged(object sender, DataGridViewCellEventArgs e)
        {
            string ApiBaseUrl = "http://localhost:5197/api/User";
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewUsers.Rows[e.RowIndex];
                var updateUser = new CUser
                {
                    UserId = Convert.ToInt32(row.Cells["UserId"].Value.ToString()),
                    UserName = row.Cells["UserName"].Value.ToString(),
                    Email = row.Cells["Email"].Value.ToString(),
                    Password = row.Cells["Password"].Value.ToString()
                };

                try
                {
                    var response = await _httpClient.PutAsJsonAsync(ApiBaseUrl, updateUser);
                    response.EnsureSuccessStatusCode();
                    LoadUsersAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }

        }
        private void ClearTextFields()
        {
            txtUserId.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void dataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            // Proveri da li je odabran red
            if (dataGridViewUsers.CurrentRow != null && dataGridViewUsers.SelectedRows.Count > 0)
            {
                // Pribavi vrednosti iz odabranog reda i postavi ih u tekstualne kutije
                txtUserId.Text = dataGridViewUsers.CurrentRow.Cells["UserId"].Value.ToString();
                txtUserName.Text = dataGridViewUsers.CurrentRow.Cells["UserName"].Value.ToString();
                txtEmail.Text = dataGridViewUsers.CurrentRow.Cells["Email"].Value.ToString();
                txtPassword.Text = dataGridViewUsers.CurrentRow.Cells["Password"].Value.ToString();
            }
            else
            {
                // Ako nije odabran red, obriši tekstualna polja
                ClearTextFields();
            }
        }
    }

}
