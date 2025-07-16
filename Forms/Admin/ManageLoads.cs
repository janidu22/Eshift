using Eshift.Models;
using Eshift.Repoistory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace Eshift.Forms.Admin
{
    public partial class ManageLoads : Form
    {
        private readonly JobRepository jobRepository = new JobRepository();
        private int selectedJobId = -1;
        public ManageLoads()
        {
            InitializeComponent();
            cbJobs.SelectedIndexChanged += cbJobs_SelectedIndexChanged;
        }

        private void ManageLoads_Load(object sender, EventArgs e)
        {
            LoadPendingJobsAsync();
            DataPanel.Visible = false;
        }

    

        private string Truncate(string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return "";
            return value.Length <= maxLength ? value : value.Substring(0, maxLength - 3) + "...";
        }

        private async Task ShowLoadsForJobAsync()
        {

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
                    cbJobs.Items.Add(new ComboBoxItem { Text = display, Value = job.JobId });
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
                await ShowLoadsForJobAsync();
                dgvLoads.Visible = true;
                DataPanel.Visible=true;
            }
        }

        
    }
}
