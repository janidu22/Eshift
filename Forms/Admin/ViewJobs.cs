using Eshift.Repoistory;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Eshift.Forms.Admin
{
    public partial class ViewJobs : Form
    {
        private readonly CustomerRepository _customerRepository = new CustomerRepository();
        private DataTable _allJobsTable;

        public ViewJobs()
        {
            InitializeComponent();

            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;

            viewJobsDt.Dock = DockStyle.Fill;

            viewJobsDt.DataBindingComplete += viewJobsDt_DataBindingComplete;

            tbSearch.TextChanged += FilterData;
            CbStatus.SelectedIndexChanged += FilterData;
            CbPaymentStatus.SelectedIndexChanged += FilterData;

   
        }

        private void ViewJobs_Load(object sender, EventArgs e)
        {
            _allJobsTable = _customerRepository.GetAllJobs();
            viewJobsDt.DataSource = _allJobsTable;

            viewJobsDt.AllowUserToAddRows = false;
            viewJobsDt.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            viewJobsDt.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            viewJobsDt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            viewJobsDt.ClearSelection();

            // Initialize combo boxes
            InitFilterComboBoxes();
        }

        private void InitFilterComboBoxes()
        {
            // Add default "All" option to show everything
            CbStatus.Items.Clear();
            CbStatus.Items.Add("All");
            CbStatus.Items.Add("Pending");
            CbStatus.Items.Add("Approved");
            CbStatus.SelectedIndex = 0;

            CbPaymentStatus.Items.Clear();
            CbPaymentStatus.Items.Add("All");
            CbPaymentStatus.Items.Add("Pending");
            CbPaymentStatus.Items.Add("Paid");
            CbPaymentStatus.Items.Add("Received");
            CbPaymentStatus.SelectedIndex = 0;
        }

        private void FilterData(object sender, EventArgs e)
        {
            if (_allJobsTable == null) return;

            string searchText = tbSearch.Text.Trim().Replace("'", "''");

            string statusFilter = CbStatus.SelectedItem?.ToString();
            string paymentFilter = CbPaymentStatus.SelectedItem?.ToString();

            
            string filter = "";

            
            if (!string.IsNullOrEmpty(searchText))
            {
                filter += $"CustomerName LIKE '%{searchText}%'";
            }

       
            if (!string.IsNullOrEmpty(statusFilter) && statusFilter != "All")
            {
                if (filter.Length > 0) filter += " AND ";
                filter += $"Status = '{statusFilter}'";
            }

         
            if (!string.IsNullOrEmpty(paymentFilter) && paymentFilter != "All")
            {
                if (filter.Length > 0) filter += " AND ";
                filter += $"PaymentStatus = '{paymentFilter}'";
            }

            _allJobsTable.DefaultView.RowFilter = filter;

            viewJobsDt.ClearSelection();
        }

        private void viewJobsDt_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            viewJobsDt.ClearSelection();

            foreach (DataGridViewRow row in viewJobsDt.Rows)
            {
                if (row.Cells["Status"].Value != null)
                {
                    string status = row.Cells["Status"].Value.ToString().Trim();

                    if (status.Equals("Pending", StringComparison.OrdinalIgnoreCase))
                    {
                        row.Cells["Status"].Style.ForeColor = Color.Red;
                        row.Cells["Status"].Style.Font = new Font(viewJobsDt.Font, FontStyle.Bold);
                    }
                    else if (status.Equals("Approved", StringComparison.OrdinalIgnoreCase))
                    {
                        row.Cells["Status"].Style.ForeColor = Color.Green;
                        row.Cells["Status"].Style.Font = new Font(viewJobsDt.Font, FontStyle.Bold);
                    }
                }

                if (row.Cells["PaymentStatus"].Value != null)
                {
                    string paymentStatus = row.Cells["PaymentStatus"].Value.ToString().Trim();

                    if (paymentStatus.Equals("Pending", StringComparison.OrdinalIgnoreCase))
                    {
                        row.Cells["PaymentStatus"].Style.ForeColor = Color.Red;
                        row.Cells["PaymentStatus"].Style.Font = new Font(viewJobsDt.Font, FontStyle.Bold);
                    }
                    else if (paymentStatus.Equals("Paid", StringComparison.OrdinalIgnoreCase) ||
                             paymentStatus.Equals("Received", StringComparison.OrdinalIgnoreCase))
                    {
                        row.Cells["PaymentStatus"].Style.ForeColor = Color.Green;
                        row.Cells["PaymentStatus"].Style.Font = new Font(viewJobsDt.Font, FontStyle.Bold);
                    }
                }
            }
        }

        private void ClearSearch()
        {
            tbSearch.Text = string.Empty;
            CbStatus.SelectedIndex = 0;
            CbPaymentStatus.SelectedIndex = 0;

            if (_allJobsTable != null)
            {
                _allJobsTable.DefaultView.RowFilter = "";
                viewJobsDt.DataSource = _allJobsTable;
                viewJobsDt.ClearSelection();
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            ClearSearch();
        }

        private void viewJobsDt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Implement if needed
        }
    }
}
