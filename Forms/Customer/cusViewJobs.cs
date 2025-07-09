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
    public partial class cusViewJobs : Form
    {
        private string _username;
        private CustomerRepository _CustomerRepository = new CustomerRepository();

        public cusViewJobs(string username)
        {
            InitializeComponent();
            _username = username;

           
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;

            viewJobsDt.Dock = DockStyle.Fill;
        }

        private void cusViewJobs_Load(object sender, EventArgs e)
        {
            var customer = _CustomerRepository.GetCustomerByUsername(_username); 
            if (customer != null)
            {
                LoadCustomerJobs(customer.CustomerId);
            }
            else
            {
                MessageBox.Show("Customer not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCustomerJobs(int customerId)
        {
            var customerRepo = new CustomerRepository();
            DataTable jobsTable = customerRepo.GetJobsByCustomerId(customerId);
            viewJobsDt.DataSource = jobsTable;
            viewJobsDt.AllowUserToAddRows = false;
            viewJobsDt.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            viewJobsDt.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            viewJobsDt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void viewJobsDt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
