using Eshift.Forms.Admin;
using Eshift.Repoistory;
using System;
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

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text;

            if (!ValidateLoginForm(username, password)) return;

            try
            {
                var customer = await customerRepository.LoginCustomerAsync(username, password);

                if (customer != null)
                {
                    MessageBox.Show($"Welcome, {customer.Name}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (this.Owner is MainForm mainForm)
                    {
                        CustomerDashboard dashboard = new CustomerDashboard(username, mainForm);
                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Parent form is not set correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbPassword.Clear(); tbUsername.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during login: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPassword.Clear(); tbUsername.Focus();
            }
        }

        private bool ValidateLoginForm(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || username.Length < 3)
            {
                MessageBox.Show("Invalid username."); tbUsername.Focus(); return false;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your password."); tbPassword.Focus(); return false;
            }
            return true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.Owner is MainForm main)
            {
                this.Hide();
                main.LoadRegisterForm();
            }
            else
            {
                MessageBox.Show("Parent form is not set correctly.");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Owner is MainForm main)
                {
                    main.OpenFormInPanel(); ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Set focus to username field when form loads
            tbUsername.Focus();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(this.Owner is MainForm mainform)
            {
                mainform.LoadRegisterForm();    

            }
        }
    }
}
