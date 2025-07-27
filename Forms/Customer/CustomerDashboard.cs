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
        private System.Windows.Forms.Timer timeTimer;

        public CustomerDashboard(string username, MainForm mainForm)
        {
            InitializeComponent();
            _username = username;
            _mainForm = mainForm;
            InitializeModernUI();
        }

        private void InitializeModernUI()
        {
            // Initialize time timer
            timeTimer = new System.Windows.Forms.Timer();
            timeTimer.Interval = 1000; // Update every second
            timeTimer.Tick += TimeTimer_Tick;
            timeTimer.Start();

            // Add window control button events
            btnClose.Click += BtnClose_Click;
            btnMaximize.Click += BtnMaximize_Click;
            btnMinimize.Click += BtnMinimize_Click;

            // Set profile picture placeholder
            SetProfilePicture();

            // Add hover effects to navigation buttons
            AddHoverEffects();

            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void SetProfilePicture()
        {
            // Create a circular profile picture placeholder
            picBoxProfile.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (var brush = new SolidBrush(Color.White))
                {
                    e.Graphics.FillEllipse(brush, 0, 0, picBoxProfile.Width, picBoxProfile.Height);
                }
                
                // Draw customer icon
                using (var font = new Font("Segoe UI", 20, FontStyle.Bold))
                using (var brush = new SolidBrush(Color.FromArgb(44, 62, 80)))
                {
                    var text = "👤";
                    var size = e.Graphics.MeasureString(text, font);
                    var x = (picBoxProfile.Width - size.Width) / 2;
                    var y = (picBoxProfile.Height - size.Height) / 2;
                    e.Graphics.DrawString(text, font, brush, x, y);
                }
            };
        }

        private void AddHoverEffects()
        {
            // Add hover effects to all navigation buttons except logout
            var navButtons = new[] { ViewJobs, NewJobRequest, TrackStatus, MyProfile };
            
            foreach (var button in navButtons)
            {
                button.MouseEnter += (s, e) =>
                {
                    button.BackColor = Color.FromArgb(46, 204, 113); // Green hover
                };
                
                button.MouseLeave += (s, e) =>
                {
                    button.BackColor = Color.Transparent;
                };
            }

            // Special hover effect for logout button
            Logout.MouseEnter += (s, e) =>
            {
                Logout.BackColor = Color.FromArgb(192, 57, 43); // Darker red hover
            };
            
            Logout.MouseLeave += (s, e) =>
            {
                Logout.BackColor = Color.FromArgb(231, 76, 60); // Original red
            };
        }

        private void TimeTimer_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss");
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                btnMaximize.Text = "□";
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                btnMaximize.Text = "❐";
            }
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
                    lbUsername.Text = $"@{customer.Username}";
                    lbEmail.Text = customer.Email;
                    lbPhone.Text = customer.Phone ?? "+1 (555) 123-4567";
                    lblWelcome.Text = $"Welcome back, {customer.Name}!";
                }
                else
                {
                    SetDefaultCustomerInfo();
                    MessageBox.Show("Customer details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                SetDefaultCustomerInfo();
                MessageBox.Show($"An error occurred while loading customer details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetDefaultCustomerInfo()
        {
            lbName.Text = "Customer";
            lbUsername.Text = "@customer";
            lbEmail.Text = "customer@eshift.com";
            lbPhone.Text = "+1 (555) 123-4567";
            lblWelcome.Text = "Welcome back!";
        }

        private void LoadFormInPanel(Form childForm)
        {
            // Dispose of existing form
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm.Dispose();
            }

            // Clear existing controls
            PanelMain.Controls.Clear();

            // Configure child form
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            
            // Add to panel and show
            PanelMain.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void ViewJobs_Click(object sender, EventArgs e)
        {
            cusViewJobs viewJobs = new cusViewJobs(_username);
            LoadFormInPanel(viewJobs);
        }

        private void NewJobRequest_Click(object sender, EventArgs e)
        {
            cusNewJob cusNewJob = new cusNewJob(_username);
            LoadFormInPanel(cusNewJob);
        }

        private void TrackStatus_Click(object sender, EventArgs e)
        {
            CusTrackStatus cusTrackStatus = new CusTrackStatus(_username);
            LoadFormInPanel(cusTrackStatus);
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
                LoadFormInPanel(cusMyProfile);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading profile management: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PanelMain_Paint(object sender, PaintEventArgs e)
        {
            // Only load default view on first paint
            if (PanelMain.Controls.Count == 0)
            {
                cusViewJobs viewJobs = new cusViewJobs(_username);
                LoadFormInPanel(viewJobs);
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                _mainForm.OpenFormInPanel(); // Go back to the main login or home form
                this.Hide(); // Hide the current form
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            timeTimer?.Stop();
            timeTimer?.Dispose();
            activeForm?.Dispose();
            base.OnFormClosed(e);
        }
    }
}
