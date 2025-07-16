using Eshift.DataAccess;
using Eshift.Models;
using Eshift.Repoistory;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eshift.Forms.Customer
{
    public partial class cusNewJob : Form
    {
        private readonly string customerUsername;
        private int customerId;
        private readonly JobRepository jobRepository;
        private readonly DatabaseHelper databaseHelper = new DatabaseHelper();

        public cusNewJob(string username)
        {
            InitializeComponent();
            customerUsername = username;
            jobRepository = new JobRepository();
            // Call async loaders in Load event
            this.Load += cusNewJob_Load;
            SetupPaymentMethod();
        }

        private void cusNewJob_Load(object? sender, EventArgs e)
        {
            LoadCustomerId();
            LoadProducts();
            // Set default date to tomorrow
            DTRequestDate.Value = DateTime.Now.AddDays(1);
            DTRequestDate.MinDate = DateTime.Now;
            TbAmount.ReadOnly = true; // Make amount read-only
            TbWeight.TextChanged += TbWeight_TextChanged;
        }

        private void LoadCustomerId()
        {
            try
            {
                using (var connection = databaseHelper.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT c.CustomerId FROM Customers c INNER JOIN Users u ON c.UserId = u.UserId WHERE u.Username = @Username";
                    using (var cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", customerUsername);
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            customerId = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Customer not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void LoadProducts()
        {
            try
            {
                using (var connection = databaseHelper.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT ProductId, Name FROM Products ORDER BY Name";
                    using (var cmd = new SqlCommand(query, connection))
                    using (var reader = cmd.ExecuteReader())
                    {
                        CbProducts.Items.Clear();
                        while (reader.Read())
                        {
                            var item = new ProductItem
                            {
                                ProductId = reader.GetInt32("ProductId"),
                                Name = reader.GetString("Name")
                            };
                            CbProducts.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupPaymentMethod()
        {
            RbCash.Text = "Cash";
            RbCard.Text = "Card";
            RbCash.Checked = true;
        }

        private void TbWeight_TextChanged(object? sender, EventArgs e)
        {
            if (decimal.TryParse(TbWeight.Text, out decimal weight) && weight > 0)
            {
                decimal ratePerKg = 20.0m;
                decimal amount = weight * ratePerKg;
                TbAmount.Text = amount.ToString("N2");
            }
            else
            {
                TbAmount.Text = "0.00";
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                await CreateJob();
            }
        }

        private bool ValidateForm()
        {
            // Validate Start Location
            if (string.IsNullOrWhiteSpace(tbStartLocation.Text))
            {
                MessageBox.Show("Please enter start location.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbStartLocation.Focus();
                return false;
            }

            if (tbStartLocation.Text.Trim().Length < 5)
            {
                MessageBox.Show("Start location must be at least 5 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbStartLocation.Focus();
                return false;
            }

            // Validate Destination
            if (string.IsNullOrWhiteSpace(tbDestination.Text))
            {
                MessageBox.Show("Please enter destination.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbDestination.Focus();
                return false;
            }

            if (tbDestination.Text.Trim().Length < 5)
            {
                MessageBox.Show("Destination must be at least 5 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbDestination.Focus();
                return false;
            }

            // Validate Requested Date
            if (DTRequestDate.Value <= DateTime.Now)
            {
                MessageBox.Show("Requested date must be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DTRequestDate.Focus();
                return false;
            }

            // Validate Product Selection
            if (CbProducts.SelectedItem == null)
            {
                MessageBox.Show("Please select a product/item.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CbProducts.Focus();
                return false;
            }

            // Validate Quantity
            if (NuDQuentity.Value <= 0)
            {
                MessageBox.Show("Quantity must be greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NuDQuentity.Focus();
                return false;
            }

            if (NuDQuentity.Value > 1000)
            {
                MessageBox.Show("Quantity cannot exceed 1000.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NuDQuentity.Focus();
                return false;
            }

            // Validate Weight (if provided)
            if (!string.IsNullOrWhiteSpace(TbWeight.Text))
            {
                if (!decimal.TryParse(TbWeight.Text, out decimal weight) || weight <= 0)
                {
                    MessageBox.Show("Please enter a valid weight (must be greater than 0).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TbWeight.Focus();
                    return false;
                }

                if (weight > 10000) // 10 tons max
                {
                    MessageBox.Show("Weight cannot exceed 10,000 kg.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TbWeight.Focus();
                    return false;
                }
            }

            // Validate Amount
            if (string.IsNullOrWhiteSpace(TbAmount.Text))
            {
                MessageBox.Show("Please enter the amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbAmount.Focus();
                return false;
            }

            if (!decimal.TryParse(TbAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid amount (must be greater than 0).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbAmount.Focus();
                return false;
            }

            if (amount > 100000) // $100,000 max
            {
                MessageBox.Show("Amount cannot exceed $100,000.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbAmount.Focus();
                return false;
            }

            // Validate Notes (optional but if provided, check length)
            if (!string.IsNullOrWhiteSpace(TbNotes.Text) && TbNotes.Text.Length > 500)
            {
                MessageBox.Show("Notes cannot exceed 500 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbNotes.Focus();
                return false;
            }

            return true;
        }

        private async Task CreateJob()
        {
            try
            {
                // Extract data from form controls using correct names
                var startLocation = tbStartLocation.Text.Trim();
                var destination = tbDestination.Text.Trim();
                var requestedDate = DTRequestDate.Value;
                var quantity = (int)NuDQuentity.Value;
                var weight = Convert.ToInt32(TbWeight.Text);
                var notes = TbNotes.Text;
                var card = RbCard.Checked;
                var amount = TbAmount.Text;

                // Validate amount
                if (!decimal.TryParse(amount, out decimal amountValue) || amountValue <= 0)
                {
                    MessageBox.Show("Please enter a valid amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TbAmount.Focus();
                    return;
                }

                // Determine payment method
                string paymentMethod = card ? "Card" : "Cash";

                // Get selected product name from combo box
                if (CbProducts.SelectedItem == null)
                {
                    MessageBox.Show("Please select a product.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CbProducts.Focus();
                    return;
                }

                var selectedProduct = (ProductItem)CbProducts.SelectedItem;
                string requestedProducts = selectedProduct.Name; // Or use a category property if you have one

                bool success = await jobRepository.CreateJobAsync(customerId, startLocation, destination,
                    requestedDate, requestedProducts, paymentMethod, amountValue, quantity, weight);

                if (success)
                {
                    string paymentStatus = paymentMethod == "Card" ? "Paid" : "Pending";
                    MessageBox.Show($"Job created successfully!\nPayment Status: {paymentStatus}",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to create job. Please try again.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            tbStartLocation.Clear();
            tbDestination.Clear();
            TbWeight.Clear();
            TbAmount.Clear();
            NuDQuentity.Value = 0;  
            TbNotes.Clear();
            CbProducts.SelectedIndex = -1;
            NuDQuentity.Value = 1;
            DTRequestDate.Value = DateTime.Now.AddDays(1);
            RbCash.Checked = true;
        }

        private void cusNewJob_Load_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
