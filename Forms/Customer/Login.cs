using Eshift.Forms.Admin;
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

namespace Eshift.Forms.Customer
{
    public partial class Login : Form
    {
        private readonly CustomerRepository customerRepository;
        public Login()
        {
            InitializeComponent();
            customerRepository = new CustomerRepository();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = tbUsername.Text.Trim();
                string password = tbPassword.Text;

                // Basic validation
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please enter both username and password.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Attempt login
                var customer = customerRepository.LoginCustomer(username, password);

                if (customer != null)
                {


                    MessageBox.Show($"Welcome, {customer.Name}!", "Login Successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Navigate to main dashboard or customer form
                    // Replace this with your actual main form
                    CustomerDashboard dashboard = new CustomerDashboard(username);
                    dashboard.Show();
                    this.Hide();
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
            }


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();  
            this.Hide();    

        }
    }
}
