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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                // Get input values
                var name = tbName.Text.Trim();
                var email = tbEmail.Text.Trim();
                var username = tbUsername.Text.Trim();
                var password = tbPassword.Text;
                var address = tbAddress.Text.Trim();
                var phone = tbPhone.Text.Trim();



                // Attempt registration
                bool success = customerRepository.RegisterCustomer(name, email, username, password, address, phone);

                if (success)
                {
                    MessageBox.Show("Registration successful! You can now login.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear form
                    ClearForm();

                    // Navigate to login
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Registration failed. Username or email might already exist.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void ClearForm()
        {
            tbName.Clear();
            tbEmail.Clear();
            tbUsername.Clear();
            tbPassword.Clear();
            tbAddress.Clear();
            tbPhone.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
