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

namespace Eshift.Forms.Admin
{
    public partial class ProfileManage : Form
    {
        private readonly AdminRepository _adminRepository;
        private Eshift.Models.Admin? _currentAdmin;

        public ProfileManage(Eshift.Models.Admin admin)
        {
            InitializeComponent();
            _adminRepository = new AdminRepository();
            _currentAdmin = admin;
        }

        private void ProfileManage_Load(object sender, EventArgs e)
        {
            // Load admin details automatically since admin is passed as parameter
            LoadAdminDetails();
            this.Text = "Profile Management";
        }

        private void LoadAdminDetails()
        {
            if (_currentAdmin != null)
            {
                txtName.Text = _currentAdmin.Name;
                txtEmail.Text = _currentAdmin.Email;
                txtUsername.Text = _currentAdmin.Username;
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";
                
                // Disable username field since we already have the admin
                txtUsername.Enabled = false;
            }
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var name = txtName.Text.Trim();
                var email = txtEmail.Text.Trim();
                var username = txtUsername.Text.Trim();
                var password = txtPassword.Text;
                var confirmPassword = txtConfirmPassword.Text;

                // Validate inputs
                if (!ValidateProfileForm(name, email, username, password, confirmPassword))
                {
                    return;
                }

                bool success = _adminRepository.UpdateAdmin(_currentAdmin!.AdminId, name, email, username, password);

                if (success)
                {
                    // Update the current admin object with new details
                    _currentAdmin.Name = name;
                    _currentAdmin.Email = email;
                    _currentAdmin.Username = username;

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

        private bool ValidateProfileForm(string name, string email, string username, string password, string confirmPassword)
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
            LoadAdminDetails(); // Reload the admin details
        }

        private void ClearPasswordFields()
        {
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
        }
    }
}
