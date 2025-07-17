using Eshift.Repoistory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eshift.Forms.Admin
{
    public partial class AdminLogin : Form
    {

        private readonly AdminRepository _adminRepository;
        public AdminLogin()
        {
            InitializeComponent();
            _adminRepository = new AdminRepository();   
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = tbUsername.Text.Trim();
                string password = tbPassword.Text;

            
                if (!ValidateLoginForm(username, password))
                {
                    return;
                }

                var admin = _adminRepository.LoginAdmin(username, password);


                if (admin != null)
                {
                    MessageBox.Show($"Welcome, {admin.Name}!", "Login Successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (this.Owner is MainForm mainForm)
                    {
                        AdminMain adminMain = new AdminMain(username, mainForm);
                        adminMain.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Parent form is not set correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbPassword.Clear();
                    tbUsername.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during login: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPassword.Clear();
                tbUsername.Focus();
            }
        }

        private bool ValidateLoginForm(string username, string password)
        {
            // Validate Username
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter your username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbUsername.Focus();
                return false;
            }

            if (username.Length < 3)
            {
                MessageBox.Show("Username must be at least 3 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbUsername.Focus();
                return false;
            }

            // Validate Password
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPassword.Focus();
                return false;
            }

            if (password.Length < 1)
            {
                MessageBox.Show("Please enter your password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPassword.Focus();
                return false;
            }

            return true;
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
