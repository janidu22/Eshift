
using Eshift.Forms.Customer;
using Eshift.Models;
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
    public partial class AdminMain : Form
    {
        private readonly string _username;
        private readonly AdminRepository adminRepository = new AdminRepository();

        public AdminMain(string username)
        {
            InitializeComponent();
            _username = username;
        }



        private void ViewJobs_Click(object sender, EventArgs e)
        {
            ViewJobs viewJobs = new ViewJobs();
            viewJobs.TopLevel = false;
            viewJobs.FormBorderStyle = FormBorderStyle.None;
            viewJobs.Dock = DockStyle.Fill;
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(viewJobs);
            viewJobs.Show();

        }

        private void AdminManagement_Click(object sender, EventArgs e)
        {

            ManageAdmin manageAdmin = new ManageAdmin();
            manageAdmin.TopLevel = false;
            manageAdmin.FormBorderStyle = FormBorderStyle.None;
            manageAdmin.Dock = DockStyle.Fill;
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(manageAdmin);
            manageAdmin.Show();
        }

        private void PanelMain_Paint(object sender, PaintEventArgs e)
        {
            ViewJobs viewJobs = new ViewJobs();
            viewJobs.TopLevel = false;
            viewJobs.FormBorderStyle = FormBorderStyle.None;
            viewJobs.Dock = DockStyle.Fill;
            PanelMain.Controls.Add(viewJobs);
            viewJobs.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private async void panel2_Paint(object sender, PaintEventArgs e)
        {
            var admin = await adminRepository.GetAdminByUsernameAsync(_username);
            lblAdminName.Text = admin.Name;
            lblAdminUsername.Text = admin.Username;
            lblAdminEmail.Text = admin.Email;
        }

        private void manageCustomers_Click(object sender, EventArgs e)
        {
            ManageCustomer  manageCustomer = new ManageCustomer();  
            manageCustomer.TopLevel = false;
            manageCustomer.FormBorderStyle = FormBorderStyle.None;
            manageCustomer.Dock = DockStyle.Fill;
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(manageCustomer);
            manageCustomer.Show();
        }
    }
}

