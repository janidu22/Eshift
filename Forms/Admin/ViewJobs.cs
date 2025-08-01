using Eshift.DataAccess;
using Eshift.Models;
using Eshift.Repoistory;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eshift.Forms.Admin
{
    public partial class ViewJobs : Form
    {

        private readonly CustomerRepository _customerRepository = new CustomerRepository();
        private readonly JobRepository _jobRepository = new JobRepository();
        private readonly DatabaseHelper databaseHelper = new DatabaseHelper();
        private DataTable? _allJobsTable;
        private string _currentJobStatus = "";
        private string _currentPaymentStatus = "";

        public ViewJobs()
        {
            InitializeComponent();

            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;

            // Apply responsive design
            this.ApplyResponsiveDesign();
            this.QuickLaptopFix();

            viewJobsDt.Dock = DockStyle.Fill;

            viewJobsDt.DataBindingComplete += viewJobsDt_DataBindingComplete;
            viewJobsDt.SelectionChanged += viewJobsDt_SelectionChanged;

            tbSearch.TextChanged += FilterData;
            CbStatus.SelectedIndexChanged += FilterData;
            CbPaymentStatus.SelectedIndexChanged += FilterData;
            this.Load += ViewJobs_Load;
        }

        private void SetupResponsiveLayout()
        {
            // Set minimum size for the form
            this.MinimumSize = new Size(800, 600);
            
            // Handle resize events
            this.Resize += ViewJobs_Resize;
            
            // Auto-scale controls
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoScaleDimensions = new SizeF(96F, 96F);
        }

        private void ViewJobs_Resize(object sender, EventArgs e)
        {
            // Adjust layout when form is resized
            AdjustControlsForScreenSize();
        }

        private void AdjustControlsForScreenSize()
        {
            if (this.WindowState == FormWindowState.Minimized) return;

            // Adjust DataGridView column widths based on form size
            if (viewJobsDt != null && viewJobsDt.Columns.Count > 0)
            {
                // Calculate available width
                int availableWidth = viewJobsDt.Width - SystemInformation.VerticalScrollBarWidth - 10;
                
                // Adjust column widths proportionally
                foreach (DataGridViewColumn column in viewJobsDt.Columns)
                {
                    switch (column.Name)
                    {
                        case "JobId":
                            column.Width = Math.Max(60, (int)(availableWidth * 0.08));
                            break;
                        case "CustomerName":
                            column.Width = Math.Max(120, (int)(availableWidth * 0.15));
                            break;
                        case "StartLocation":
                        case "Destination":
                            column.Width = Math.Max(100, (int)(availableWidth * 0.18));
                            break;
                        case "RequestedDate":
                            column.Width = Math.Max(100, (int)(availableWidth * 0.12));
                            break;
                        case "JobStatus":
                        case "PaymentStatus":
                            column.Width = Math.Max(80, (int)(availableWidth * 0.10));
                            break;
                        default:
                            column.Width = Math.Max(80, (int)(availableWidth * 0.08));
                            break;
                    }
                }
            }

            // Adjust button panel layout based on form width
            if (actionButtonsPanel != null)
            {
                int formWidth = this.Width;
                if (formWidth < 1200)
                {
                    // Stack buttons vertically on smaller screens
                    actionButtonsPanel.FlowDirection = FlowDirection.TopDown;
                }
                else
                {
                    // Arrange buttons horizontally on larger screens
                    actionButtonsPanel.FlowDirection = FlowDirection.LeftToRight;
                }
            }
        }


        private async void ViewJobs_Load(object sender, EventArgs e)
        {
            LoadProducts();
            await LoadJobsAsync();
            InitFilterComboBoxes();
            // Set default date to tomorrow
            DTRequestDate.Value = DateTime.Now.AddDays(1);
            DTRequestDate.MinDate = DateTime.Now;
            TbAmount.ReadOnly = true; // Make amount read-only
            TbWeight.TextChanged += TbWeight_TextChanged;
        }

        private void SetupPaymentMethod()
        {
            RbCash.Text = "Cash";
            RbCard.Text = "Card";
            RbCash.Checked = true;
        }

        private void TbWeight_TextChanged(object? sender, EventArgs e)
        {
            if (decimal.TryParse(TbWeight.Text, out decimal weight) && weight > 0)
            {
                decimal ratePerKg = 20.0m;
                decimal amount = weight * ratePerKg;
                TbAmount.Text = amount.ToString("N2");
            }
            else
            {
                TbAmount.Text = "0.00";
            }
        }



        private void InitFilterComboBoxes()
        {
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

        private void FilterData(object? sender, EventArgs e)
        {
            if (_allJobsTable == null) return;

            string searchText = tbSearch.Text.Trim().Replace("'", "''");
            string statusFilter = CbStatus.SelectedItem?.ToString() ?? string.Empty;
            string paymentFilter = CbPaymentStatus.SelectedItem?.ToString() ?? string.Empty;

            string filter = "";

            if (!string.IsNullOrEmpty(searchText))
                filter += $"CustomerName LIKE '%{searchText}%'";

            if (!string.IsNullOrEmpty(statusFilter) && statusFilter != "All")
            {
                if (filter.Length > 0) filter += " AND ";
                filter += $"JobStatus = '{statusFilter}'";
            }

            if (!string.IsNullOrEmpty(paymentFilter) && paymentFilter != "All")
            {
                if (filter.Length > 0) filter += " AND ";
                filter += $"PaymentStatus = '{paymentFilter}'";
            }

            _allJobsTable.DefaultView.RowFilter = filter;
            viewJobsDt.ClearSelection();
        }

        private void viewJobsDt_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            viewJobsDt.ClearSelection();

            foreach (DataGridViewRow row in viewJobsDt.Rows)
            {
                var statusObj = row.Cells["JobStatus"].Value;
                string status = statusObj == null || statusObj == DBNull.Value ? string.Empty : statusObj.ToString()!.Trim();
                if (!string.IsNullOrEmpty(status))
                {
                    var cell = row.Cells["JobStatus"];
                    cell.Style.Font = new Font(viewJobsDt.Font, FontStyle.Bold);
                    cell.Style.ForeColor = status.Equals("Pending", StringComparison.OrdinalIgnoreCase) ? Color.Red :
                                           status.Equals("Approved", StringComparison.OrdinalIgnoreCase) ? Color.Green : cell.Style.ForeColor;
                }

                var paymentObj = row.Cells["PaymentStatus"].Value;
                string paymentStatus = paymentObj == null || paymentObj == DBNull.Value ? string.Empty : paymentObj.ToString()!.Trim();
                if (!string.IsNullOrEmpty(paymentStatus))
                {
                    var cell = row.Cells["PaymentStatus"];
                    cell.Style.Font = new Font(viewJobsDt.Font, FontStyle.Bold);
                    cell.Style.ForeColor = paymentStatus.Equals("Pending", StringComparison.OrdinalIgnoreCase) ? Color.Red :
                                           (paymentStatus.Equals("Paid", StringComparison.OrdinalIgnoreCase) || paymentStatus.Equals("Received", StringComparison.OrdinalIgnoreCase)) ? Color.Green : cell.Style.ForeColor;
                }
            }
        }

        private void viewJobsDt_SelectionChanged(object? sender, EventArgs e)
        {
            if (viewJobsDt.SelectedRows.Count == 0) return;

            var row = viewJobsDt.SelectedRows[0];
            _currentJobStatus = row.Cells["JobStatus"].Value?.ToString()?.Trim() ?? "";
            _currentPaymentStatus = row.Cells["PaymentStatus"].Value?.ToString()?.Trim() ?? "";

            // Reflect current values in radio buttons
            rbPending.Checked = _currentJobStatus == "Pending";
            rbApproved.Checked = _currentJobStatus == "Approved";
            rbCompleted.Checked = _currentJobStatus == "Completed";

            rbPaymentPending.Checked = _currentPaymentStatus == "Pending";
            rbPaymentPaid.Checked = _currentPaymentStatus == "Paid";
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
            // Optional
        }

        private void RbCash_CheckedChanged(object sender, EventArgs e)
        {
            // Optional
        }

        private async Task LoadJobsAsync()
        {
            _allJobsTable = await _customerRepository.GetAllJobsWithPaymentStatusAsync();
            viewJobsDt.DataSource = _allJobsTable;
            ConfigureDataGridColumns();
            viewJobsDt.ClearSelection();
        }

        private void ConfigureDataGridColumns()
        {
            if (viewJobsDt.Columns.Count == 0) return;

            // Ensure headers are visible and properly styled
            viewJobsDt.ColumnHeadersVisible = true;
            viewJobsDt.ColumnHeadersHeight = 40;
            viewJobsDt.EnableHeadersVisualStyles = false;
            
            // Apply header styling
            viewJobsDt.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80);
            viewJobsDt.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            viewJobsDt.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            viewJobsDt.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Set specific column widths and visibility
            viewJobsDt.Columns["JobId"].Width = 60;
            viewJobsDt.Columns["JobId"].HeaderText = "Job ID";

            viewJobsDt.Columns["CustomerName"].Width = 120;
            viewJobsDt.Columns["CustomerName"].HeaderText = "Customer";

            viewJobsDt.Columns["CustomerId"].Visible = false;

            viewJobsDt.Columns["StartLocation"].Width = 100;
            viewJobsDt.Columns["StartLocation"].HeaderText = "Start Location";

            viewJobsDt.Columns["Destination"].Width = 100;
            viewJobsDt.Columns["Destination"].HeaderText = "Destination";

            viewJobsDt.Columns["RequestedDate"].Width = 90;
            viewJobsDt.Columns["RequestedDate"].HeaderText = "Request Date";
            viewJobsDt.Columns["RequestedDate"].DefaultCellStyle.Format = "MM/dd/yyyy";

            viewJobsDt.Columns["JobStatus"].Width = 80;
            viewJobsDt.Columns["JobStatus"].HeaderText = "Status";

            viewJobsDt.Columns["Lorry"].Width = 80;
            viewJobsDt.Columns["Lorry"].HeaderText = "Lorry";

            viewJobsDt.Columns["Driver"].Width = 100;
            viewJobsDt.Columns["Driver"].HeaderText = "Driver";

            viewJobsDt.Columns["Assistant"].Width = 100;
            viewJobsDt.Columns["Assistant"].HeaderText = "Assistant";

            viewJobsDt.Columns["PaymentStatus"].Width = 90;
            viewJobsDt.Columns["PaymentStatus"].HeaderText = "Payment";

            viewJobsDt.Columns["PaymentMethod"].Width = 70;
            viewJobsDt.Columns["PaymentMethod"].HeaderText = "Method";

            viewJobsDt.Columns["Amount"].Width = 80;
            viewJobsDt.Columns["Amount"].HeaderText = "Amount";
            viewJobsDt.Columns["Amount"].DefaultCellStyle.Format = "C2";

            // Hide less important columns to save space
            viewJobsDt.Columns["CreatedAt"].Visible = false;
            viewJobsDt.Columns["UpdatedAt"].Visible = false;
        }

        private async void UpdateJobBtn_Click(object sender, EventArgs e)
        {
            if (viewJobsDt.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a job to update.");
                return;
            }

            int jobId = Convert.ToInt32(viewJobsDt.SelectedRows[0].Cells["JobId"].Value);

            string? newJobStatus = rbPending.Checked ? "Pending" :
                                   rbApproved.Checked ? "Approved" :
                                   rbCompleted.Checked ? "Completed" : null;

            string? newPaymentStatus = rbPaymentPending.Checked ? "Pending" :
                                       rbPaymentPaid.Checked ? "Paid" : null;

            bool jobUpdated = true;
            bool paymentUpdated = true;
            bool anyChange = false;

            if (newJobStatus != null && newJobStatus != _currentJobStatus)
            {
                jobUpdated = await _jobRepository.UpdateJobStatusAsync(jobId, newJobStatus);
                anyChange = true;
            }

            if (newPaymentStatus != null && newPaymentStatus != _currentPaymentStatus)
            {
                paymentUpdated = await _jobRepository.UpdatePaymentStatusAsync(jobId, newPaymentStatus);
                anyChange = true;
            }

            if (!anyChange)
            {
                MessageBox.Show("No changes to update.");
                return;
            }

            if (jobUpdated && paymentUpdated)
                MessageBox.Show("Update successful!");
            else if (!jobUpdated && !paymentUpdated)
                MessageBox.Show("Both updates failed!");
            else if (!jobUpdated)
                MessageBox.Show("Job status update failed!");
            else if (!paymentUpdated)
                MessageBox.Show("Payment status update failed!");

            await LoadJobsAsync();
        }

        private async void btnCreateNewJob_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                CreateJob();
            }
            await LoadJobsAsync();

        }

        private bool ValidateForm()
        {
            // Validate Start Location
            if (string.IsNullOrWhiteSpace(tbStartLocation.Text))
            {
                MessageBox.Show("Please enter start location.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbStartLocation.Focus();
                return false;
            }

            if (tbStartLocation.Text.Trim().Length < 5)
            {
                MessageBox.Show("Start location must be at least 5 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbStartLocation.Focus();
                return false;
            }

            // Validate Destination
            if (string.IsNullOrWhiteSpace(tbDestination.Text))
            {
                MessageBox.Show("Please enter destination.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbDestination.Focus();
                return false;
            }

            if (tbDestination.Text.Trim().Length < 5)
            {
                MessageBox.Show("Destination must be at least 5 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbDestination.Focus();
                return false;
            }

            // Validate Requested Date
            if (DTRequestDate.Value <= DateTime.Now)
            {
                MessageBox.Show("Requested date must be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DTRequestDate.Focus();
                return false;
            }

            // Validate Product Selection
            if (CbProducts.SelectedItem == null)
            {
                MessageBox.Show("Please select a product/item.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CbProducts.Focus();
                return false;
            }

            // Validate Quantity
            if (NuDQuentity.Value <= 0)
            {
                MessageBox.Show("Quantity must be greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NuDQuentity.Focus();
                return false;
            }

            if (NuDQuentity.Value > 1000)
            {
                MessageBox.Show("Quantity cannot exceed 1000.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NuDQuentity.Focus();
                return false;
            }

            // Validate Weight (if provided)
            if (!string.IsNullOrWhiteSpace(TbWeight.Text))
            {
                if (!decimal.TryParse(TbWeight.Text, out decimal weight) || weight <= 0)
                {
                    MessageBox.Show("Please enter a valid weight (must be greater than 0).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TbWeight.Focus();
                    return false;
                }

                if (weight > 10000) // 10 tons max
                {
                    MessageBox.Show("Weight cannot exceed 10,000 kg.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TbWeight.Focus();
                    return false;
                }
            }

            // Validate Amount
            if (string.IsNullOrWhiteSpace(TbAmount.Text))
            {
                MessageBox.Show("Please enter the amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbAmount.Focus();
                return false;
            }

            if (!decimal.TryParse(TbAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid amount (must be greater than 0).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbAmount.Focus();
                return false;
            }

            if (amount > 100000) // $100,000 max
            {
                MessageBox.Show("Amount cannot exceed $100,000.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbAmount.Focus();
                return false;
            }

            // Validate Notes (optional but if provided, check length)
            if (!string.IsNullOrWhiteSpace(TbNotes.Text) && TbNotes.Text.Length > 500)
            {
                MessageBox.Show("Notes cannot exceed 500 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbNotes.Focus();
                return false;
            }

            return true;
        }


        private void LoadProducts()
        {
            try
            {
                using (var connection = databaseHelper.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT ProductId, Name FROM Products ORDER BY Name";
                    using (var cmd = new SqlCommand(query, connection))
                    using (var reader = cmd.ExecuteReader())
                    {
                        CbProducts.Items.Clear();
                        while (reader.Read())
                        {
                            var item = new ProductItem
                            {
                                ProductId = reader.GetInt32("ProductId"),
                                Name = reader.GetString("Name")
                            };
                            CbProducts.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CreateJob()
        {
            int customerId = 0;

            if (viewJobsDt.SelectedRows.Count > 0)
            {
                var selectedRow = viewJobsDt.SelectedRows[0];
                customerId = Convert.ToInt32(selectedRow.Cells["CustomerId"].Value);
            }

            if (customerId == 0)
            {
                MessageBox.Show("Please select a valid customer before creating a job.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Extract data from form controls using correct names
                var startLocation = tbStartLocation.Text.Trim();
                var destination = tbDestination.Text.Trim();
                var requestedDate = DTRequestDate.Value;
                var quantity = (int)NuDQuentity.Value;
                var weight = Convert.ToInt32(TbWeight.Text);
                var notes = TbNotes.Text;
                var card = RbCard.Checked;
                var amount = TbAmount.Text;

                // Validate amount
                if (!decimal.TryParse(amount, out decimal amountValue) || amountValue <= 0)
                {
                    MessageBox.Show("Please enter a valid amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TbAmount.Focus();
                    return;
                }

                // Determine payment method
                string paymentMethod = card ? "Card" : "Cash";

                // Get selected product name from combo box
                if (CbProducts.SelectedItem == null)
                {
                    MessageBox.Show("Please select a product.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CbProducts.Focus();
                    return;
                }

                var selectedProduct = (ProductItem)CbProducts.SelectedItem;
                string requestedProducts = selectedProduct.Name; // Or use a category property if you have one

                bool success = await _jobRepository.CreateJobAsync(customerId, startLocation, destination,
                    requestedDate, requestedProducts, paymentMethod, amountValue,quantity,weight,notes);

                if (success)
                {
                    string paymentStatus = paymentMethod == "Card" ? "Paid" : "Pending";
                    MessageBox.Show($"Job created successfully!\nPayment Status: {paymentStatus}",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to create job. Please try again.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            tbStartLocation.Clear();
            tbDestination.Clear();
            TbWeight.Clear();
            TbAmount.Clear();
            TbNotes.Clear();
            CbProducts.SelectedIndex = -1;
            NuDQuentity.Value = 1;
            DTRequestDate.Value = DateTime.Now.AddDays(1);
            RbCash.Checked = true;
        }

        private async void DeleteJob_Click(object sender, EventArgs e)
        {
            if (viewJobsDt.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a job to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int jobId = Convert.ToInt32(viewJobsDt.SelectedRows[0].Cells["JobId"].Value);

            var confirm = MessageBox.Show("Are you sure you want to delete this job?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            using (SqlConnection conn = databaseHelper.GetConnection())
            {
                await conn.OpenAsync();
                using (SqlTransaction tran = conn.BeginTransaction())
                {
                    try
                    {
                        // Delete dependent data first
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM Loads WHERE JobId = @JobId", conn, tran))
                        {
                            cmd.Parameters.AddWithValue("@JobId", jobId);
                            await cmd.ExecuteNonQueryAsync();
                        }

                        using (SqlCommand cmd = new SqlCommand("DELETE FROM Payments WHERE JobId = @JobId", conn, tran))
                        {
                            cmd.Parameters.AddWithValue("@JobId", jobId);
                            await cmd.ExecuteNonQueryAsync();
                        }

                        using (SqlCommand cmd = new SqlCommand("DELETE FROM JobStatusHistory WHERE JobId = @JobId", conn, tran))
                        {
                            cmd.Parameters.AddWithValue("@JobId", jobId);
                            await cmd.ExecuteNonQueryAsync();
                        }

                        using (SqlCommand cmd = new SqlCommand("DELETE FROM Jobs WHERE JobId = @JobId", conn, tran))
                        {
                            cmd.Parameters.AddWithValue("@JobId", jobId);
                            int affected = await cmd.ExecuteNonQueryAsync();

                            tran.Commit();

                            if (affected > 0)
                                MessageBox.Show("Job deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("Job deletion failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        await LoadJobsAsync(); // Refresh the table
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show($"Error deleting job: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
