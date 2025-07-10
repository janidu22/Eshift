using Eshift.Repoistory;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eshift.Forms.Customer
{
    public partial class Register : Form
    {
        private readonly CustomerRepository customerRepository;

        public Register()
        {
            InitializeComponent();
            customerRepository = new CustomerRepository();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
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
                bool success = await customerRepository.RegisterCustomerAsync(name, email, username, password, address, phone);

                if (success)
                {
                    MessageBox.Show("Registration successful! You can now login.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    Login login = new Login();
                    login.Show();
                    this.Hide();
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
            if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
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

        private bool IsValidEmail(string email) =>
            System.Net.Mail.MailAddress.TryCreate(email, out _);

        private bool IsValidPhoneNumber(string phone) =>
            Regex.Replace(phone, "[^\\d]", "").Length is >= 10 and <= 15;

        private void ClearForm()
        {
            tbName.Clear(); tbEmail.Clear(); tbUsername.Clear();
            tbPassword.Clear(); tbAddress.Clear(); tbPhone.Clear();
        }

        private void Register_Load(object sender, EventArgs e) { }
    }
}
