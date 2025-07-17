using Eshift.Forms.Admin;
using Eshift.Forms.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eshift.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            OpenFormInPanel();
        }

        public void OpenFormInPanel()
        {
            Choose choose = new Choose();
            choose.Owner = this;
            choose.TopLevel = false;
            choose.FormBorderStyle = FormBorderStyle.None;
            choose.Dock = DockStyle.Fill;
            LoginPanel.Controls.Clear();
            LoginPanel.Controls.Add(choose);
            choose.Show();
        }

        public void LoadAdminForm()
        {
            AdminLogin adminForm = new AdminLogin();
            adminForm.Owner = this;
            adminForm.TopLevel = false;
            adminForm.FormBorderStyle = FormBorderStyle.None;
            adminForm.Dock = DockStyle.Fill;
            LoginPanel.Controls.Clear();
            LoginPanel.Controls.Add(adminForm);
            adminForm.Show();
        }

        public void LoadCustomerForm()
        {
            Login customerForm = new Login();
            customerForm.Owner = this;
            customerForm.TopLevel = false;
            customerForm.FormBorderStyle = FormBorderStyle.None;
            customerForm.Dock = DockStyle.Fill;
            LoginPanel.Controls.Clear();
            LoginPanel.Controls.Add(customerForm);
            customerForm.Show();
        }

        public void LoadRegisterForm()
        {
            Register customerRegisterForm = new Register();
            customerRegisterForm.Owner = this;
            customerRegisterForm.TopLevel = false;
            customerRegisterForm.FormBorderStyle = FormBorderStyle.None;
            customerRegisterForm.Dock = DockStyle.Fill;
            LoginPanel.Controls.Clear();
            LoginPanel.Controls.Add(customerRegisterForm);
            customerRegisterForm.Show();
        }

        public void LoadCustomerDashboard(string username)
        {
            CustomerDashboard customerDashboard = new CustomerDashboard(username, this);
            customerDashboard.Owner = this;
            customerDashboard.TopLevel = false;
            customerDashboard.FormBorderStyle = FormBorderStyle.None;
            customerDashboard.Dock = DockStyle.Fill;
            LoginPanel.Controls.Clear();
            LoginPanel.Controls.Add(customerDashboard);
            customerDashboard.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OpenFormInPanel();
        }
    }
}
