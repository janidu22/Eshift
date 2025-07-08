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
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var Password = tbPassword.Text;
            var Username = tbUsername.Text.Trim();

            try
            {
                if(Username =="admin" && Password == "123")
                {
                    AdminMain adminMain = new AdminMain();
                    adminMain.Show();   
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("login error");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred during login: {ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
