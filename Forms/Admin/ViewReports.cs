using Eshift.Models;
using Eshift.Repoistory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eshift.Forms.Admin
{
    public partial class ViewReports : Form
    {
        private readonly JobRepository jobRepository = new JobRepository();
        private DataTable currentReportData;

        public ViewReports()
        {
            InitializeComponent();
            InitializeForm();
            this.Load += ViewReports_Load;
        }

        private void ViewReports_Load(object sender, EventArgs e)
        {
            // Ensure all controls are visible
            panel1.Visible = true;
            panelFilter.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            dgvReportData.Visible = true;
            btnFilter.Visible = true;
            btnExport.Visible = true;
            btnPrint.Visible = true;
            btnRefresh.Visible = true;
            CbReports.Visible = true;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
            
            // Set form title
            this.Text = "View Reports - Eshift";
            
            // Load initial data if a report type is selected
            if (CbReports.SelectedItem != null)
            {
                _ = LoadReportAsync();
            }
        }

        private void InitializeForm()
        {
            // Set default date range (last 30 days)
            dateTimePicker1.Value = DateTime.Now.AddDays(-30);
            dateTimePicker2.Value = DateTime.Now;

            // Set up event handlers
            btnFilter.Click += BtnFilter_Click;
            btnExport.Click += BtnExport_Click;
            btnPrint.Click += BtnPrint_Click;
            btnRefresh.Click += BtnRefresh_Click;
            CbReports.SelectedIndexChanged += CbReports_SelectedIndexChanged;

            // Set default report type
            if (CbReports.Items.Count > 0)
                CbReports.SelectedIndex = 0;

            // Configure DataGridView
            ConfigureDataGridView();
            
            // Ensure all panels and controls are visible
            panel1.Visible = true;
            panelFilter.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            dgvReportData.Visible = true;
            btnFilter.Visible = true;
            btnExport.Visible = true;
            btnPrint.Visible = true;
            btnRefresh.Visible = true;
            CbReports.Visible = true;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
        }

        private void ConfigureDataGridView()
        {
            dgvReportData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvReportData.AllowUserToAddRows = false;
            dgvReportData.AllowUserToDeleteRows = false;
            dgvReportData.ReadOnly = true;
            dgvReportData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReportData.RowHeadersVisible = false;
            dgvReportData.BackgroundColor = Color.White;
            dgvReportData.Font = new Font("JetBrains Mono", 9F);
            
            // Set header style
            dgvReportData.ColumnHeadersDefaultCellStyle.BackColor = Color.MidnightBlue;
            dgvReportData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvReportData.ColumnHeadersDefaultCellStyle.Font = new Font("JetBrains Mono", 9F, FontStyle.Bold);
        }

        private async void CbReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbReports.SelectedItem != null)
            {
                await LoadReportAsync();
            }
        }

        private async void BtnFilter_Click(object sender, EventArgs e)
        {
            await LoadReportAsync();
        }

        private async void BtnRefresh_Click(object sender, EventArgs e)
        {
            await LoadReportAsync();
        }

        private async Task LoadReportAsync()
        {
            try
            {
                if (CbReports.SelectedItem == null)
                {
                    MessageBox.Show("Please select a report type.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string selectedReport = CbReports.SelectedItem.ToString();
                DateTime? fromDate = dateTimePicker1.Value;
                DateTime? toDate = dateTimePicker2.Value;

                // Debug: Show the dates being used
                Console.WriteLine($"Filtering {selectedReport} from {fromDate:yyyy-MM-dd} to {toDate:yyyy-MM-dd}");

                // Validate date range
                if (fromDate > toDate)
                {
                    MessageBox.Show("From date cannot be later than To date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                currentReportData = await GetReportDataAsync(selectedReport, fromDate, toDate);
                dgvReportData.DataSource = currentReportData;

                // Update form title with report info
                string dateRange = $" ({fromDate:yyyy-MM-dd} to {toDate:yyyy-MM-dd})";
                this.Text = $"View Reports - {selectedReport}{dateRange}";

                // Show row count in status bar or title instead of message box
                int rowCount = currentReportData?.Rows.Count ?? 0;
                this.Text = $"View Reports - {selectedReport}{dateRange} ({rowCount} records)";
                
                // Debug: Show the result count
                Console.WriteLine($"Found {rowCount} records for {selectedReport}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<DataTable> GetReportDataAsync(string reportType, DateTime? fromDate, DateTime? toDate)
        {
            return reportType switch
            {
                "Jobs" => await jobRepository.GetJobsReportAsync(fromDate, toDate),
                "Loads" => await jobRepository.GetLoadsReportAsync(fromDate, toDate),
                "Payments" => await jobRepository.GetPaymentsReportAsync(fromDate, toDate),
                "Customers" => await jobRepository.GetCustomersReportAsync(fromDate, toDate),
                "Revenue" => await jobRepository.GetRevenueReportAsync(fromDate, toDate),
                "Job Status History" => await jobRepository.GetJobStatusHistoryReportAsync(fromDate, toDate),
                "Products" => await jobRepository.GetProductsReportAsync(fromDate, toDate),
                "Transport Units" => await jobRepository.GetTransportUnitsReportAsync(fromDate, toDate),
                "Drivers" => await jobRepository.GetDriversReportAsync(fromDate, toDate),
                "Assistants" => await jobRepository.GetAssistantsReportAsync(fromDate, toDate),
                "Lorries" => await jobRepository.GetLorriesReportAsync(fromDate, toDate),
                "Containers" => await jobRepository.GetContainersReportAsync(fromDate, toDate),
                _ => throw new ArgumentException($"Unknown report type: {reportType}")
            };
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            if (currentReportData == null || currentReportData.Rows.Count == 0)
            {
                MessageBox.Show("No data to export. Please load a report first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                    saveFileDialog.FilterIndex = 1;
                    saveFileDialog.RestoreDirectory = true;
                    saveFileDialog.FileName = $"Report_{CbReports.SelectedItem}_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        ExportToCSV(currentReportData, saveFileDialog.FileName);
                        MessageBox.Show($"Report exported successfully to: {saveFileDialog.FileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportToCSV(DataTable dataTable, string filePath)
        {
            StringBuilder csv = new StringBuilder();

            // Add headers
            var headers = dataTable.Columns.Cast<DataColumn>().Select(column => column.ColumnName);
            csv.AppendLine(string.Join(",", headers));

            // Add data rows
            foreach (DataRow row in dataTable.Rows)
            {
                var fields = row.ItemArray.Select(field => 
                {
                    string value = field?.ToString() ?? "";
                    // Escape commas and quotes
                    if (value.Contains(",") || value.Contains("\"") || value.Contains("\n"))
                    {
                        value = value.Replace("\"", "\"\"");
                        value = $"\"{value}\"";
                    }
                    return value;
                });
                csv.AppendLine(string.Join(",", fields));
            }

            File.WriteAllText(filePath, csv.ToString());
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (currentReportData == null || currentReportData.Rows.Count == 0)
            {
                MessageBox.Show("No data to print. Please load a report first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Create a print preview
                PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                
                printDocument.PrintPage += (s, e) => PrintPage(s, e, currentReportData, CbReports.SelectedItem?.ToString());
                
                printPreviewDialog.Document = printDocument;
                printPreviewDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error printing report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintPage(object sender, PrintPageEventArgs e, DataTable dataTable, string reportTitle)
        {
            Graphics graphics = e.Graphics;
            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font headerFont = new Font("Arial", 10, FontStyle.Bold);
            Font dataFont = new Font("Arial", 9);
            Brush brush = Brushes.Black;

            float yPos = 10;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;

            // Print title
            string title = $"Report: {reportTitle} - Generated on {DateTime.Now:yyyy-MM-dd HH:mm:ss}";
            graphics.DrawString(title, titleFont, brush, leftMargin, yPos);
            yPos += 30;

            // Print headers
            float xPos = leftMargin;
            foreach (DataColumn column in dataTable.Columns)
            {
                graphics.DrawString(column.ColumnName, headerFont, brush, xPos, yPos);
                xPos += 100; // Adjust column width as needed
            }
            yPos += 20;

            // Print data rows
            foreach (DataRow row in dataTable.Rows)
            {
                if (yPos > e.MarginBounds.Bottom - 50)
                {
                    e.HasMorePages = true;
                    return;
                }

                xPos = leftMargin;
                foreach (DataColumn column in dataTable.Columns)
                {
                    string value = row[column]?.ToString() ?? "";
                    graphics.DrawString(value, dataFont, brush, xPos, yPos);
                    xPos += 100; // Adjust column width as needed
                }
                yPos += 15;
            }
        }
    }
}
