using Eshift.Models;
using Eshift.Repoistory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eshift.Forms.Customer
{
    public partial class CusMyProfile : Form
    {
        private readonly CustomerRepository _customerRepository;
        private Eshift.Models.Customer? _currentCustomer;

        public CusMyProfile(Eshift.Models.Customer customer)
        {
            InitializeComponent();
            _customerRepository = new CustomerRepository();
            _currentCustomer = customer;
        }

        private void CusMyProfile_Load(object sender, EventArgs e)
        {
            // Load customer details automatically since customer is passed as parameter
            LoadCustomerDetails();
            this.Text = "Customer Profile Management";
        }

        private void LoadCustomerDetails()
        {
            if (_currentCustomer != null)
            {
                txtName.Text = _currentCustomer.Name ?? "";
                txtEmail.Text = _currentCustomer.Email ?? "";
                txtUsername.Text = _currentCustomer.Username ?? "";
                txtAddress.Text = _currentCustomer.Address ?? "";
                txtPhone.Text = _currentCustomer.Phone ?? "";
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";
                
                // Disable username field since we already have the customer
                txtUsername.Enabled = false;
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var name = txtName.Text.Trim();
                var email = txtEmail.Text.Trim();
                var username = txtUsername.Text.Trim();
                var address = txtAddress.Text.Trim();
                var phone = txtPhone.Text.Trim();
                var password = txtPassword.Text;
                var confirmPassword = txtConfirmPassword.Text;

                // Validate inputs
                if (!ValidateCustomerForm(name, email, username, address, phone, password, confirmPassword))
                {
                    return;
                }

                bool success = await _customerRepository.UpdateCustomerAsync(_currentCustomer!.UserId, name, email, username, password, address, phone);

                if (success)
                {
                    // Update the current customer object with new details
                    _currentCustomer.Name = name;
                    _currentCustomer.Email = email;
                    _currentCustomer.Username = username;
                    _currentCustomer.Address = address;
                    _currentCustomer.Phone = phone;

                    MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearPasswordFields();
                }
                else
                {
                    MessageBox.Show("Failed to update profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateCustomerForm(string name, string email, string username, string address, string phone, string password, string confirmPassword)
        {
            // Validate Name
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter your full name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            if (name.Length < 2)
            {
                MessageBox.Show("Name must be at least 2 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            if (!Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Name can only contain letters and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            // Validate Email
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter your email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            // Validate Username
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter a username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }

            if (username.Length < 3)
            {
                MessageBox.Show("Username must be at least 3 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }

            if (!Regex.IsMatch(username, @"^[a-zA-Z0-9_]+$"))
            {
                MessageBox.Show("Username can only contain letters, numbers, and underscores.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }

            // Validate Address
            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Please enter your address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return false;
            }

            if (address.Length < 5)
            {
                MessageBox.Show("Address must be at least 5 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return false;
            }

            // Validate Phone
            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Please enter your phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return false;
            }

            if (!Regex.IsMatch(phone, @"^[\d\s\-\+\(\)]+$"))
            {
                MessageBox.Show("Please enter a valid phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return false;
            }

            // Validate Password (only if provided)
            if (!string.IsNullOrWhiteSpace(password))
            {
                if (password.Length < 6)
                {
                    MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();
                    return false;
                }

                if (string.IsNullOrWhiteSpace(confirmPassword))
                {
                    MessageBox.Show("Please confirm your password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtConfirmPassword.Focus();
                    return false;
                }

                if (password != confirmPassword)
                {
                    MessageBox.Show("Password and confirm password do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtConfirmPassword.Focus();
                    return false;
                }
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            LoadCustomerDetails(); // Reload the customer details
        }

        private void ClearPasswordFields()
        {
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
        }
    }
}
