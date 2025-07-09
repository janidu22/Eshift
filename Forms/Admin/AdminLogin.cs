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

        private readonly AdminRepository _adminRepository ;
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

                // Basic validation
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please enter both username and password.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var admin = _adminRepository.LoginAdmin(username, password);
                

                if(admin != null)
                {
                    AdminMain adminMain = new AdminMain();
                    adminMain.Show();
                    this.Hide();
                     
                }
                else
                {

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Invalid username or password.", "Login Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPassword.Clear();
                tbUsername.Focus();
            }
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
