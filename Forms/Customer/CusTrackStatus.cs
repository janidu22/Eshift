using Eshift.Repoistory;
using Eshift.Models;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eshift.Forms.Customer
{
    public partial class CusTrackStatus : Form
    {
        private readonly string customerUsername;
        private readonly CustomerRepository customerRepository;
        private readonly JobRepository jobRepository;
        private int customerId;

        public CusTrackStatus()
        {
            InitializeComponent();
            customerRepository = new CustomerRepository();
            jobRepository = new JobRepository();
        }

        public CusTrackStatus(string username) : this()
        {
            customerUsername = username;
        }

        private async void CusTrackStatus_Load(object sender, EventArgs e)
        {
            await LoadCustomerIdAsync();
            await LoadActiveJobsAsync();
        }

        private async Task LoadCustomerIdAsync()
        {
            try
            {
                if (!string.IsNullOrEmpty(customerUsername))
                {
                    var customer = await customerRepository.GetCustomerByUsernameAsync(customerUsername);
                    if (customer != null)
                    {
                        customerId = customer.CustomerId;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customer information: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadActiveJobsAsync()
        {
            try
            {
                cbJobs.Items.Clear();
                
                if (customerId > 0)
                {
                    var jobsTable = await customerRepository.GetJobsByCustomerIdAsync(customerId);
                    
                    // Show all jobs for tracking (Pending, Approved, Completed)
                    var activeJobs = jobsTable.AsEnumerable()
                        .Where(row => 
                        {
                            var status = row["Status"]?.ToString() ?? "";
                            return status == "Pending" || status == "Approved" || status == "Completed";
                        })
                        .OrderByDescending(row => row["RequestedDate"])
                        .ToList();

                    if (activeJobs.Any())
                    {
                        foreach (var jobRow in activeJobs)
                        {
                            var jobDisplay = $"Job #{jobRow["JobId"]} - {jobRow["StartLocation"]} → {jobRow["Destination"]} ({jobRow["Status"]})";
                            cbJobs.Items.Add(new JobItem
                            {
                                JobId = Convert.ToInt32(jobRow["JobId"]),
                                DisplayText = jobDisplay,
                                StartLocation = jobRow["StartLocation"]?.ToString() ?? "",
                                Destination = jobRow["Destination"]?.ToString() ?? "",
                                Status = jobRow["Status"]?.ToString() ?? "",
                                RequestedDate = Convert.ToDateTime(jobRow["RequestedDate"])
                            });
                        }
                        cbJobs.DisplayMember = "DisplayText";
                        
                        // Select the first active job by default
                        if (cbJobs.Items.Count > 0)
                        {
                            cbJobs.SelectedIndex = 0;
                        }
                    }
                    else
                    {
                        // Show message when no active jobs
                        selectJobPromptLabel.Text = "You have no jobs to track. Please create a new job request first.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading jobs: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbJobs.SelectedItem is JobItem selectedJob)
            {
                ShowTrackingInfo(selectedJob);
                trackingCard.Visible = true;
                noJobSelectedPanel.Visible = false;
            }
            else
            {
                trackingCard.Visible = false;
                noJobSelectedPanel.Visible = true;
            }
        }

        private void ShowTrackingInfo(JobItem job)
        {
            // Update job details
            trackingNumberValueLabel.Text = $"#JOB{job.JobId:D3}";
            startLocationValueLabel.Text = job.StartLocation;
            destinationValueLabel.Text = job.Destination;
            
            // Calculate estimated arrival (example logic)
            var estimatedArrival = job.RequestedDate.AddDays(1);
            expectedArrivalValueLabel.Text = estimatedArrival.ToString("MMM dd, h:mm tt");
            estimatedArrivalLabel.Text = estimatedArrival.ToString("MMM dd, h:mm tt");

            // Update progress based on status
            UpdateProgressStatus(job.Status);
        }

        private void UpdateProgressStatus(string status)
        {
            // Reset all steps
            ResetAllSteps();

            switch (status.ToLower())
            {
                case "pending":
                    // Show only first step as pending
                    SetStepPending(step1Panel, step1Circle, step1Check, step1Label, step1Icon);
                    SetStepInactive(step2Panel, step2Circle, step2Check, step2Label, step2Icon);
                    SetStepInactive(step3Panel, step3Circle, step3Check, step3Label, step3Icon);
                    SetStepInactive(step4Panel, step4Circle, step4Check, step4Label, step4Icon);
                    UpdateProgressFill(0);
                    UpdateStatusMessage("Your job request is being processed", "We're reviewing your shipment request");
                    break;

                case "approved":
                case "accepted":
                    // Steps 1-2 completed, step 3 pending
                    SetStepCompleted(step1Panel, step1Circle, step1Check, step1Label, step1Icon);
                    SetStepCompleted(step2Panel, step2Circle, step2Check, step2Label, step2Icon);
                    SetStepPending(step3Panel, step3Circle, step3Check, step3Label, step3Icon);
                    SetStepInactive(step4Panel, step4Circle, step4Check, step4Label, step4Icon);
                    UpdateProgressFill(50);
                    UpdateStatusMessage("Job approved and in progress", "Your shipment is being prepared and dispatched");
                    break;

                case "completed":
                case "delivered":
                    // All steps completed
                    SetStepCompleted(step1Panel, step1Circle, step1Check, step1Label, step1Icon);
                    SetStepCompleted(step2Panel, step2Circle, step2Check, step2Label, step2Icon);
                    SetStepCompleted(step3Panel, step3Circle, step3Check, step3Label, step3Icon);
                    SetStepCompleted(step4Panel, step4Circle, step4Check, step4Label, step4Icon);
                    UpdateProgressFill(100);
                    UpdateStatusMessage("Package delivered successfully!", "Your shipment has been completed");
                    break;

                default:
                    // Default to pending for unknown status
                    SetStepPending(step1Panel, step1Circle, step1Check, step1Label, step1Icon);
                    SetStepInactive(step2Panel, step2Circle, step2Check, step2Label, step2Icon);
                    SetStepInactive(step3Panel, step3Circle, step3Check, step3Label, step3Icon);
                    SetStepInactive(step4Panel, step4Circle, step4Check, step4Label, step4Icon);
                    UpdateProgressFill(0);
                    UpdateStatusMessage($"Status: {status}", "Please contact support for more information");
                    break;
            }
        }

        private void ResetAllSteps()
        {
            SetStepInactive(step1Panel, step1Circle, step1Check, step1Label, step1Icon);
            SetStepInactive(step2Panel, step2Circle, step2Check, step2Label, step2Icon);
            SetStepInactive(step3Panel, step3Circle, step3Check, step3Label, step3Icon);
            SetStepInactive(step4Panel, step4Circle, step4Check, step4Label, step4Icon);
        }

        private void SetStepCompleted(Panel stepPanel, Panel circle, Label check, Label label, Label icon)
        {
            circle.BackColor = Color.FromArgb(46, 125, 50); // Green
            MakeCircleRounded(circle);
            check.Visible = true;
            label.ForeColor = Color.FromArgb(46, 125, 50);
            icon.ForeColor = Color.FromArgb(46, 125, 50);
        }

        private void SetStepPending(Panel stepPanel, Panel circle, Label check, Label label, Label icon)
        {
            circle.BackColor = Color.FromArgb(255, 152, 0); // Orange
            MakeCircleRounded(circle);
            check.Visible = false;
            label.ForeColor = Color.FromArgb(255, 152, 0);
            icon.ForeColor = Color.FromArgb(255, 152, 0);
        }

        private void SetStepInactive(Panel stepPanel, Panel circle, Label check, Label label, Label icon)
        {
            circle.BackColor = Color.FromArgb(230, 230, 230); // Gray
            MakeCircleRounded(circle);
            check.Visible = false;
            label.ForeColor = Color.FromArgb(150, 150, 150);
            icon.ForeColor = Color.FromArgb(150, 150, 150);
        }

        private void UpdateProgressFill(int percentage)
        {
            int totalWidth = progressLine.Width;
            int fillWidth = (totalWidth * percentage) / 100;
            progressFill.Width = fillWidth;
        }

        private void UpdateStatusMessage(string mainMessage, string subMessage)
        {
            currentLocationLabel.Text = mainMessage;
            estimatedArrivalLabel.Text = subMessage;
        }

        private async void refreshButton_Click(object sender, EventArgs e)
        {
            refreshButton.Enabled = false;
            refreshButton.Text = "🔄 Loading...";
            
            try
            {
                await LoadActiveJobsAsync();
            }
            finally
            {
                refreshButton.Enabled = true;
                refreshButton.Text = "🔄 Refresh";
            }
        }

        private void MakeCircleRounded(Panel panel)
        {
            // Create rounded corners for the tick mark circles
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, panel.Width, panel.Height);
            panel.Region = new Region(path);
        }
    }

    // Helper class for job items in ComboBox
    public class JobItem
    {
        public int JobId { get; set; }
        public string DisplayText { get; set; } = "";
        public string StartLocation { get; set; } = "";
        public string Destination { get; set; } = "";
        public string Status { get; set; } = "";
        public DateTime RequestedDate { get; set; }
    }
}
