
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
        private MainForm _mainForm;

        public AdminMain(string username, MainForm mainForm )
        {
            InitializeComponent();
            _username = username;
            _mainForm = mainForm;
        }

        public AdminMain()
        {
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
            _mainForm.OpenFormInPanel();
            this.Hide();
        }

        private async void panel2_Paint(object sender, PaintEventArgs e)
        {
            var admin = await adminRepository.GetAdminByUsernameAsync(_username);
            lblAdminName.Text =  admin.Name;
            lblAdminUsername.Text = admin.Username;
            lblAdminEmail.Text = admin.Email;
        }

        private void manageCustomers_Click(object sender, EventArgs e)
        {
            ManageCustomer manageCustomer = new ManageCustomer();
            manageCustomer.TopLevel = false;
            manageCustomer.FormBorderStyle = FormBorderStyle.None;
            manageCustomer.Dock = DockStyle.Fill;
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(manageCustomer);
            manageCustomer.Show();
        }

        private void ViewInvoice_Click(object sender, EventArgs e)
        {
            ManageProducts manageProducts = new ManageProducts();
            manageProducts.TopLevel = false;
            manageProducts.FormBorderStyle = FormBorderStyle.None;
            manageProducts.Dock = DockStyle.Fill;
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(manageProducts);
            manageProducts.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            ManageTransportUnit manageTransportUnit = new ManageTransportUnit();
            manageTransportUnit.TopLevel = false;
            manageTransportUnit.FormBorderStyle = FormBorderStyle.None;
            manageTransportUnit.Dock = DockStyle.Fill;
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(manageTransportUnit);
            manageTransportUnit.Show();
        }

        private void ManageLoads_Click(object sender, EventArgs e)
        {
            ManageLoads manageLoads = new ManageLoads();
            manageLoads.TopLevel = false;
            manageLoads.FormBorderStyle = FormBorderStyle.None;
            manageLoads.Dock = DockStyle.Fill;
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(manageLoads);
            manageLoads.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ViewReports viewReports = new ViewReports();
            viewReports.TopLevel = false;
            viewReports.FormBorderStyle = FormBorderStyle.None;
            viewReports.Dock = DockStyle.Fill;
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(viewReports);
            viewReports.Show();
        }

        private void AdminMain_Load(object sender, EventArgs e)
        {

        }
    }
}

