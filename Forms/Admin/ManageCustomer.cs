using Eshift.Forms.Customer;
using Eshift.Models;
using Eshift.Repoistory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eshift.Forms.Admin
{
    public partial class ManageCustomer : Form
    {

        private readonly CustomerRepository _customerRepository = new CustomerRepository();
        private int userId = 0;
        private int customerId = 0;

        public ManageCustomer()
        {
            InitializeComponent();
        }

        private async void ManageCustomer_Load(object sender, EventArgs e)
        {

            LoadCustomers();
        }

        private async void LoadCustomers()
        {
            try
            {
                DataTable customer = await _customerRepository.GetAllCustomersAsync();
                viewCustmerDt.DataSource = customer;
                viewCustmerDt.Dock = DockStyle.Fill;
                viewCustmerDt.RowHeadersVisible = false;
                viewCustmerDt.AllowUserToAddRows = false;
                viewCustmerDt.ReadOnly = true;
                viewCustmerDt.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                viewCustmerDt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                viewCustmerDt.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                viewCustmerDt.RowTemplate.Height = 28;


                string[] hideColNames = { "UserId", "CustomerId" };
                foreach (string colName in hideColNames)
                {
                    if (viewCustmerDt.Columns.Contains(colName))
                        viewCustmerDt.Columns[colName].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading customers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAddAdmin_Click(object sender, EventArgs e)
        {

            var name = tbName.Text.Trim();
            var email = tbEmail.Text.Trim();
            var username = tbUsername.Text.Trim();
            var password = tbPassword.Text;
            var address = tbAddress.Text.Trim();
            var phone = tbPhone.Text.Trim();

            if (!ValidateRegistrationForm(name, email, username, password, address, phone)) return;

            try
            {
                bool success = await _customerRepository.RegisterCustomerAsync(name, email, username, password, address, phone);

                if (success)
                {
                    MessageBox.Show("Registration successful! You can now login.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadCustomers();
                }
                else
                {
                    MessageBox.Show("Registration failed. Username or email might already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateRegistrationForm(string name, string email, string username, string password, string address, string phone)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length < 2 || !Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Invalid name."); tbName.Focus(); return false;
            }
            if (string.IsNullOrWhiteSpace(email) || !IsValidEmail(email))
            {
                MessageBox.Show("Invalid email."); tbEmail.Focus(); return false;
            }
            if (string.IsNullOrWhiteSpace(username) || username.Length < 3 || !Regex.IsMatch(username, @"^[a-zA-Z0-9_]+$"))
            {
                MessageBox.Show("Invalid username."); tbUsername.Focus(); return false;
            }
            // Only validate password if it's not empty (for updates)
            if (!string.IsNullOrWhiteSpace(password) && password != "Password" && password.Length < 6)
            {
                MessageBox.Show("Password too short."); tbPassword.Focus(); return false;
            }
            if (string.IsNullOrWhiteSpace(address) || address.Length < 10)
            {
                MessageBox.Show("Invalid address."); tbAddress.Focus(); return false;
            }
            if (string.IsNullOrWhiteSpace(phone) || !IsValidPhoneNumber(phone))
            {
                MessageBox.Show("Invalid phone."); tbPhone.Focus(); return false;
            }
            return true;
        }


        private int getUserId()
        {
            if (viewCustmerDt.SelectedRows.Count > 0)
            {
                var selectedRow = viewCustmerDt.SelectedRows[0];
                userId = Convert.ToInt32(selectedRow.Cells["UserId"].Value);
            }
            return userId;
        }

        private void ClearForm()
        {
            tbName.Clear(); 
            tbEmail.Clear();
            tbUsername.Clear();
            tbPassword.Clear(); 
            tbAddress.Clear();
            tbPhone.Clear();
            userId = 0; // Reset userId when clearing form
        }

        private bool IsValidEmail(string email) =>
                System.Net.Mail.MailAddress.TryCreate(email, out _);

        private bool IsValidPhoneNumber(string phone) =>
            Regex.Replace(phone, "[^\\d]", "").Length is >= 10 and <= 15;

        private async void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the userId from the selected row
                userId = getUserId();
                
                if (userId == 0)
                {
                    MessageBox.Show("Please select a customer to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var name = tbName.Text.Trim();
                var email = tbEmail.Text.Trim();
                var username = tbUsername.Text.Trim();
                var password = tbPassword.Text;
                var address = tbAddress.Text.Trim();
                var phone = tbPhone.Text.Trim();

                // Check if password field contains the placeholder text
                if (password == "Password" || string.IsNullOrWhiteSpace(password))
                {
                    // Don't update password if it's the placeholder or empty
                    password = "";
                }

                if (!ValidateRegistrationForm(name, email, username, password, address, phone)) return;

                try
                {
                    bool success = await _customerRepository.UpdateCustomerAsync(userId, name, email, username, password, address, phone);

                    if (success)
                    {
                        MessageBox.Show("Customer Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                        LoadCustomers();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update the customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void viewCustmerDt_SelectionChanged(object sender, EventArgs e)
        {
            if (viewCustmerDt.SelectedRows.Count > 0)
            {
                var selectedRow = viewCustmerDt.SelectedRows[0];
                
                // Set the userId from the selected row
                userId = Convert.ToInt32(selectedRow.Cells["UserId"].Value);
                
                var username = selectedRow.Cells["Username"].Value.ToString();

                var customer = await _customerRepository.GetCustomerByUsernameAsync(username);

                if (customer != null)
                {
                    tbName.Text = customer.Name;
                    tbUsername.Text = username;
                    tbEmail.Text = customer.Email;
                    tbAddress.Text = customer.Address;
                    tbPhone.Text = customer.Phone;
                    tbPassword.Text = "Password"; // Placeholder text
                }
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private async void DeleteCustomer(object sender, EventArgs e)
        {
            try
            {
                userId = getUserId();
                
                if (userId == 0)
                {
                    MessageBox.Show("Please select a customer to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get customer details for confirmation
                var selectedRow = viewCustmerDt.SelectedRows[0];
                var customerName = selectedRow.Cells["Name"].Value?.ToString() ?? "Unknown Customer";
                var customerUsername = selectedRow.Cells["Username"].Value?.ToString() ?? "Unknown";

                var result = MessageBox.Show(
                    $"Are you sure you want to delete customer '{customerName}' ({customerUsername})?\n\nThis will also delete all associated jobs and data.",
                    "Confirm Delete", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question);
                
                if (result == DialogResult.Yes)
                {
                    // Show progress or disable UI during deletion
                    this.Enabled = false;
                    
                    try
                    {
                        bool success = await _customerRepository.DeleteUserAndCustomerAsync(userId);
                        
                        if (success)
                        {
                            MessageBox.Show($"Customer '{customerName}' deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadCustomers();
                            ClearForm();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete customer. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    finally
                    {
                        // Re-enable UI
                        this.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Enabled = true; // Ensure UI is re-enabled
            }
        }
    }
}

