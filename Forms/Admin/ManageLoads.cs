using Eshift.Models;
using Eshift.Repoistory;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eshift.Forms.Admin
{
    public partial class ManageLoads : Form
    {
        private readonly JobRepository jobRepository = new JobRepository();
        private int selectedJobId = -1;
        private bool isLoading = true;
        private int loadID = -1;

        public ManageLoads()
        {
            InitializeComponent();
            // Apply responsive design
            this.ApplyResponsiveDesign();
            this.QuickLaptopFix();
            cbJobs.SelectedIndexChanged += cbJobs_SelectedIndexChanged;
        }

        private void SetupResponsiveLayout()
        {
            // Set minimum size for usability
            this.MinimumSize = new Size(800, 600);
            
            // Setup responsive behavior
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            
            // Handle resize events
            this.Resize += ManageLoads_Resize;
        }

        private void ManageLoads_Resize(object sender, EventArgs e)
        {
            // Adjust controls when form is resized
            AdjustControlsForScreenSize();
        }

        private void AdjustControlsForScreenSize()
        {
            if (this.WindowState == FormWindowState.Minimized) return;

            // Adjust DataGridView columns
            if (dgvLoads != null && dgvLoads.Columns.Count > 0)
            {
                int availableWidth = dgvLoads.Width - SystemInformation.VerticalScrollBarWidth - 10;
                
                foreach (DataGridViewColumn column in dgvLoads.Columns)
                {
                    switch (column.HeaderText)
                    {
                        case "Product":
                            column.Width = Math.Max(120, (int)(availableWidth * 0.20));
                            break;
                        case "TransportUnit":
                            column.Width = Math.Max(200, (int)(availableWidth * 0.35));
                            break;
                        case "Quantity":
                            column.Width = Math.Max(80, (int)(availableWidth * 0.15));
                            break;
                        case "Weight":
                            column.Width = Math.Max(80, (int)(availableWidth * 0.15));
                            break;
                        case "Notes":
                            column.Width = Math.Max(100, (int)(availableWidth * 0.15));
                            break;
                        default:
                            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            break;
                    }
                }
            }

            // Adjust ComboBox size based on form width
            if (cbJobs != null)
            {
                int formWidth = this.Width;
                if (formWidth < 1000)
                {
                    cbJobs.Font = new Font("Consolas", 12); // Smaller font for smaller screens
                }
                else
                {
                    cbJobs.Font = new Font("Consolas", 15); // Original font for larger screens
                }
            }

            // Adjust panel layout for smaller screens
            if (DataPanel != null && loadManagementPanel != null)
            {
                if (this.Width < 1200)
                {
                    // Stack panels vertically on smaller screens
                    DataPanel.Dock = DockStyle.Top;
                    DataPanel.Height = this.Height / 2;
                    loadManagementPanel.Dock = DockStyle.Bottom;
                    loadManagementPanel.Height = this.Height / 2;
                }
                else
                {
                    // Side by side layout for larger screens
                    DataPanel.Dock = DockStyle.Left;
                    DataPanel.Width = (int)(this.Width * 0.6);
                    loadManagementPanel.Dock = DockStyle.Right;
                    loadManagementPanel.Width = (int)(this.Width * 0.4);
                }
            }
        }

        private void ManageLoads_Load(object sender, EventArgs e)
        {
            LoadPendingJobsAsync();
            LoadProductsAsync();
            LoadTransportUnitsAsync();
            DataPanel.Visible = false;
            dgvLoads.ClearSelection(); // Ensure no row is selected initially
            dgvLoads.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private string Truncate(string value, int maxLength)
        {
            return string.IsNullOrEmpty(value) ? "" : value.Length <= maxLength ? value : value.Substring(0, maxLength - 3) + "...";
        }
        private async Task ShowLoadsForJobAsync()
        {
            isLoading = true;
            var loadsTable = await jobRepository.GetLoadsForJobAsync(selectedJobId);
            dgvLoads.DataSource = loadsTable;
            dgvLoads.Dock = DockStyle.Fill;
            dgvLoads.RowHeadersVisible = false;
            dgvLoads.AllowUserToAddRows = false;
            dgvLoads.ReadOnly = true;
            dgvLoads.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLoads.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoads.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvLoads.Font = new Font("JetBrains Mono", 15);
            if (dgvLoads.Columns.Contains("LoadId"))
                dgvLoads.Columns["LoadId"].Visible = false;
            dgvLoads.Visible = false;

            // Add this line to clear selection after data is loaded
            dgvLoads.ClearSelection();

            isLoading = false;
        }

        private async Task LoadPendingJobsAsync()
        {
            try
            {
                cbJobs.Items.Clear();
                cbJobs.Font = new Font("Consolas", 15);
                var jobs = await jobRepository.GetPendingJobsAsync();
                foreach (var job in jobs)
                {
                    string productName = string.IsNullOrEmpty(job.RequestedProducts) ? "" : job.RequestedProducts;
                    int quantity = job.RequestedQuantity;
                    string weightDisplay = (job.RequestedWeight > 0) ? job.RequestedWeight.ToString("0.##") : "-";
                    string start = string.IsNullOrEmpty(job.StartLocation) ? "" : job.StartLocation;
                    string dest = string.IsNullOrEmpty(job.Destination) ? "" : job.Destination;
                    string display = string.Format(
                        "Job #{0,-6}| {1,-15}| Qty: {2,-5} | Weight: {3,-7} | {4,-15} → {5,-15}| {6:yyyy-MM-dd}",
                        job.JobId,
                        Truncate(productName, 15),
                        quantity > 0 ? quantity.ToString() : "-",
                        weightDisplay,
                        Truncate(start, 15),
                        Truncate(dest, 15),
                        job.RequestedDate
                    );
                    cbJobs.Items.Add(new ComboBoxItem { Text = display, Value = job.JobId, Tag = job });
                }

                if (cbJobs.Items.Count > 0)
                    cbJobs.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading jobs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void cbJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbJobs.SelectedItem is ComboBoxItem selected)
            {
                selectedJobId = selected.Value;
                var job = selected.Tag as Eshift.Models.JobSummary;
                tbNotes.Text = job?.RequestedNotes ?? string.Empty;
                await ShowLoadsForJobAsync();
                dgvLoads.Visible = true;
                DataPanel.Visible = true;
            }
        }

        private async Task LoadProductsAsync()
        {
            var dt = await jobRepository.GetAllProductsAsync();
            cbProducts.DataSource = dt;
            cbProducts.DisplayMember = "Name";
            cbProducts.ValueMember = "ProductId";
        }

        private async Task LoadTransportUnitsAsync()
        {
            var dt = await jobRepository.GetAllTransportUnitsAsync();
            cbTransportUnits.DataSource = dt;
            cbTransportUnits.DisplayMember = "TransportUnitSummary";
            cbTransportUnits.ValueMember = "TransportUnitId";
        }

        private async void AddLoads_Click(object sender, EventArgs e)
        {
            if (!(cbJobs.SelectedItem is ComboBoxItem selectedJob))
            {
                MessageBox.Show("Please select a job before adding a load.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int jobId = selectedJob.Value;

            if (cbProducts.SelectedValue == null)
            {
                MessageBox.Show("Please select a product.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbTransportUnits.SelectedValue == null)
            {
                MessageBox.Show("Please select a transport unit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int productId = (int)cbProducts.SelectedValue;
            int transportUnitId = (int)cbTransportUnits.SelectedValue;
            int quantity = (int)nudQuantity.Value;
            
            decimal? weight = null;
            if (!string.IsNullOrWhiteSpace(tbWeight.Text))
            {
                if (decimal.TryParse(tbWeight.Text, out decimal parsedWeight))
                {
                    weight = parsedWeight;
                }
                else
                {
                    MessageBox.Show("Please enter a valid weight value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            
            string notes = string.IsNullOrWhiteSpace(tbNotes.Text) ? null : tbNotes.Text.Trim();
            bool success = await jobRepository.AddLoadAsync(jobId, productId, transportUnitId, quantity, weight, notes);
            MessageBox.Show(success ? "Load added successfully!" : "Failed to add load.");
            dgvLoads.ClearSelection();
            ShowLoadsForJobAsync();
            DataPanel.Visible = true;
            dgvLoads.Visible = true;
        }

        private void dgvLoads_SelectionChanged(object sender, EventArgs e)
        {
            if (isLoading) return;

            
            if (dgvLoads.SelectedRows.Count > 0 && dgvLoads.SelectedRows[0] != null && dgvLoads.SelectedRows[0].Index != -1)
            {
                var selectedRow = dgvLoads.SelectedRows[0];
                string product = selectedRow.Cells["Product"].Value?.ToString() ?? string.Empty;
                string transportUnit = selectedRow.Cells["TransportUnit"].Value?.ToString() ?? string.Empty;
                
                // Safe conversion handling DBNull values
                int quantity = 0;
                if (selectedRow.Cells["Quantity"].Value != null && selectedRow.Cells["Quantity"].Value != DBNull.Value)
                {
                    int.TryParse(selectedRow.Cells["Quantity"].Value.ToString(), out quantity);
                }

                decimal weight = 0;
                if (selectedRow.Cells["Weight"].Value != null && selectedRow.Cells["Weight"].Value != DBNull.Value)
                {
                    decimal.TryParse(selectedRow.Cells["Weight"].Value.ToString(), out weight);
                }

                tbNotes.Text = selectedRow.Cells["Notes"].Value?.ToString() ?? string.Empty;

                // Safe ComboBox selection
                try
                {
                    cbProducts.SelectedItem = cbProducts.Items.Cast<DataRowView>()
                        .FirstOrDefault(item => item["Name"].ToString() == product);

                    cbTransportUnits.SelectedItem = cbTransportUnits.Items.Cast<DataRowView>()
                        .FirstOrDefault(item => item["TransportUnitSummary"].ToString() == transportUnit);
                }
                catch (Exception ex)
                {
                    // Handle ComboBox selection errors gracefully
                    Console.WriteLine($"ComboBox selection error: {ex.Message}");
                }

                nudQuantity.Value = quantity;
                tbWeight.Text = weight > 0 ? weight.ToString("0.##") : "";
                
                // Safe LoadId conversion
                int loadId = 0;
                if (selectedRow.Cells["LoadId"].Value != null && selectedRow.Cells["LoadId"].Value != DBNull.Value)
                {
                    int.TryParse(selectedRow.Cells["LoadId"].Value.ToString(), out loadId);
                }
                loadID = loadId;
            }
        }

        //update load button click event    
        private async void button1_Click(object sender, EventArgs e)
        {

            if (cbProducts.SelectedValue == null)
            {
                MessageBox.Show("Please select a product.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbTransportUnits.SelectedValue == null)
            {
                MessageBox.Show("Please select a transport unit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int productId = (int)cbProducts.SelectedValue;
            int transportUnitId = (int)cbTransportUnits.SelectedValue;
            int quantity = (int)nudQuantity.Value;
            
            decimal? weight = null;
            if (!string.IsNullOrWhiteSpace(tbWeight.Text))
            {
                if (decimal.TryParse(tbWeight.Text, out decimal parsedWeight))
                {
                    weight = parsedWeight;
                }
                else
                {
                    MessageBox.Show("Please enter a valid weight value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            
            string notes = string.IsNullOrWhiteSpace(tbNotes.Text) ? null : tbNotes.Text.Trim();
            if (loadID <= 0)
            {
                MessageBox.Show("Please select a valid load to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool success = await jobRepository.UpdateLoadAsync(loadID, productId, transportUnitId, quantity, weight, notes);
            if (success)
            {
                MessageBox.Show("Load updated successfully!");
                await ShowLoadsForJobAsync();
                dgvLoads.ClearSelection();
                ShowLoadsForJobAsync();
                DataPanel.Visible = true;
                dgvLoads.Visible = true;
                loadID = -1;
            }
            else
            {
                MessageBox.Show("Failed to update load.");
            }
        }

        private  async void delete(object sender, EventArgs e)
        {
            if (await jobRepository.DeleteLoadAsync(loadID))
            {
                MessageBox.Show("Load deleted successfully!");
                ShowLoadsForJobAsync();
                DataPanel.Visible = true;
                dgvLoads.Visible = true;
            }
        }
    }
}
