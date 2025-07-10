// cusViewJobs.cs (Async version)
using Eshift.Repoistory;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eshift.Forms.Customer
{
    public partial class cusViewJobs : Form
    {
        private string _username;
        private readonly CustomerRepository _customerRepository = new CustomerRepository();

        public cusViewJobs(string username)
        {
            InitializeComponent();
            _username = username;
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        private async void cusViewJobs_Load(object sender, EventArgs e)
        {
            var customer = await _customerRepository.GetCustomerByUsernameAsync(_username);
            if (customer != null)
            {
                await LoadCustomerJobsAsync(customer.CustomerId);
            }
            else
            {
                MessageBox.Show("Customer not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadCustomerJobsAsync(int customerId)
        {
            DataTable jobsTable = await _customerRepository.GetJobsByCustomerIdAsync(customerId);
            viewJobsDt.DataSource = jobsTable;
            viewJobsDt.AllowUserToAddRows = false;
            viewJobsDt.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            viewJobsDt.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            viewJobsDt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void viewJobsDt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click if needed
        }
    }
}
