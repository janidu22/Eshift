using Eshift.Repoistory;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eshift.Forms.Customer
{
    public partial class CustomerDashboard : Form
    {
        private string _username;
        private Form? activeForm = null;
        private CustomerRepository _customerRepository = new CustomerRepository();
        private MainForm _mainForm; 

        
        public CustomerDashboard(string username, MainForm mainForm)
        {
            InitializeComponent();
            _username = username;
            _mainForm = mainForm; 
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            LoadCustomerDetails();
        }

        private async void LoadCustomerDetails()
        {
            try
            {
                var customer = await _customerRepository.GetCustomerByUsernameAsync(_username);
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
            cusNewJob cusNewJob = new cusNewJob(_username);
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

        private async void MyProfile_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the current customer details
                var customer = await _customerRepository.GetCustomerByUsernameAsync(_username);
                if (customer == null)
                {
                    MessageBox.Show("Unable to load customer details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                CusMyProfile cusMyProfile = new CusMyProfile(customer);
                cusMyProfile.TopLevel = false;
                cusMyProfile.FormBorderStyle = FormBorderStyle.None;
                cusMyProfile.Dock = DockStyle.Fill;
                PanelMain.Controls.Clear();
                PanelMain.Controls.Add(cusMyProfile);
                cusMyProfile.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading profile management: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            _mainForm.OpenFormInPanel(); // Go back to the main login or home form
            this.Hide(); // Hide the current form
        }
    }
}
