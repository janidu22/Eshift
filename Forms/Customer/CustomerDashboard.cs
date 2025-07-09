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
    public partial class CustomerDashboard : Form
    {
        private string _username;
        private Form activeForm = null;
        private CustomerRepository _customerRepository = new CustomerRepository();

        public CustomerDashboard(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            LoadCustomerDetails();
        }


        private void LoadCustomerDetails()
        {
            try
            {
                var customer = _customerRepository.GetCustomerByUsername(_username);
                if (customer != null)
                {
                    lbName.Text = customer.Name;
                    lbUsername.Text = customer.Username;
                    lbEmail.Text = customer.Email;
                    lbPhone.Text = customer.Phone;



                }
                else
                {
                    MessageBox.Show("Customer details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading customer details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;



            childForm.BringToFront();
            childForm.Show();
        }

        private void ViewJobs_Click(object sender, EventArgs e)
        {
            cusViewJobs viewJobs = new cusViewJobs(_username);
            viewJobs.TopLevel = false;
            viewJobs.FormBorderStyle = FormBorderStyle.None;
            viewJobs.Dock = DockStyle.Fill;

            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(viewJobs);
            viewJobs.Show();

        }

        private void NewJobRequest_Click(object sender, EventArgs e)
        {
            cusNewJob cusNewJob = new cusNewJob();
            cusNewJob.TopLevel = false;
            cusNewJob.FormBorderStyle = FormBorderStyle.None;
            cusNewJob.Dock = DockStyle.Fill;
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(cusNewJob);
            cusNewJob.Show();
        }

        private void TrackStatus_Click(object sender, EventArgs e)
        {
            CusTrackStatus cusTrackStatus = new CusTrackStatus();
            cusTrackStatus.TopLevel = false;
            cusTrackStatus.FormBorderStyle = FormBorderStyle.None;
            cusTrackStatus.Dock = DockStyle.Fill;
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(cusTrackStatus);
            cusTrackStatus.Show();
        }

        private void UpdateJobs_Click(object sender, EventArgs e)
        {
            CusUpdateJobs cusUpdateJobs = new CusUpdateJobs();
            cusUpdateJobs.TopLevel = false;
            cusUpdateJobs.FormBorderStyle = FormBorderStyle.None;
            cusUpdateJobs.Dock = DockStyle.Fill;
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(cusUpdateJobs);
            cusUpdateJobs.Show();

        }

        private void ViewInvoice_Click(object sender, EventArgs e)
        {
            CusViewInvoice cusViewInvoice = new CusViewInvoice();
            cusViewInvoice.TopLevel = false;
            cusViewInvoice.FormBorderStyle = FormBorderStyle.None;
            cusViewInvoice.Dock = DockStyle.Fill;
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(cusViewInvoice);
            cusViewInvoice.Show();

        }

        private void MyProfile_Click(object sender, EventArgs e)
        {
            CusMyProfile cusMyProfile = new CusMyProfile();
            cusMyProfile.TopLevel = false;
            cusMyProfile.FormBorderStyle = FormBorderStyle.None;
            cusMyProfile.Dock = DockStyle.Fill;
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(cusMyProfile);
            cusMyProfile.Show();
        }

        private void PanelMain_Paint(object sender, PaintEventArgs e)
        {
            cusViewJobs viewJobs = new cusViewJobs(_username);
            viewJobs.TopLevel = false;
            viewJobs.FormBorderStyle = FormBorderStyle.None;
            viewJobs.Dock = DockStyle.Fill;
            PanelMain.Controls.Add(viewJobs);
            viewJobs.Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();  
            login.Show();   
            this.Hide();
        }
    }
}
