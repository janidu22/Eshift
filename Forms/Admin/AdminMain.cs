
using Eshift.Forms.Customer;
using Eshift.Models;
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

namespace Eshift.Forms.Admin
{
    public partial class AdminMain : Form
    {
        private readonly string _username;
        private readonly AdminRepository adminRepository = new AdminRepository();
        private MainForm _mainForm;
        private System.Windows.Forms.Timer timeTimer;

        public AdminMain(string username, MainForm mainForm)
        {
            InitializeComponent();
            _username = username;
            _mainForm = mainForm;
            InitializeModernUI();
        }

        public AdminMain()
        {
            InitializeComponent();
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

            // Make form responsive
            SetupResponsiveLayout();

            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void SetupResponsiveLayout()
        {
            // Set minimum size for usability
            this.MinimumSize = new Size(1000, 700);
            
            // Handle form resize
            this.Resize += AdminMain_Resize;
            this.Load += AdminMain_Load;
            
            // Make sure form starts maximized for better experience
            this.WindowState = FormWindowState.Maximized;
        }

        private void AdminMain_Load(object sender, EventArgs e)
        {
            // Auto-adjust for different screen sizes
            Screen currentScreen = Screen.FromControl(this);
            
            // Ensure form doesn't exceed screen bounds
            if (this.WindowState != FormWindowState.Maximized)
            {
                int maxWidth = currentScreen.WorkingArea.Width;
                int maxHeight = currentScreen.WorkingArea.Height;
                
                this.Size = new Size(
                    Math.Min(this.Width, maxWidth),
                    Math.Min(this.Height, maxHeight)
                );
                
                this.CenterToScreen();
            }
        }

        private void AdminMain_Resize(object sender, EventArgs e)
        {
            // Handle responsive adjustments when form is resized
            AdjustControlsForScreenSize();
        }

        private void AdjustControlsForScreenSize()
        {
            if (this.WindowState == FormWindowState.Minimized) return;

            // Adjust header label positions based on form width
            int formWidth = this.Width;
            
            // Position welcome label dynamically
            if (lblWelcome != null && panelHeader != null)
            {
                lblWelcome.Location = new Point(
                    Math.Max(300, formWidth - 600), // Keep it on the right but not too close to buttons
                    15
                );
            }
            
            if (lblCurrentTime != null && panelHeader != null)
            {
                lblCurrentTime.Location = new Point(
                    Math.Max(300, formWidth - 600),
                    38
                );
            }

            // Adjust window control buttons dynamically
            if (btnClose != null)
            {
                btnClose.Location = new Point(formWidth - 60, 15);
            }
            
            if (btnMaximize != null)
            {
                btnMaximize.Location = new Point(formWidth - 105, 15);
            }
            
            if (btnMinimize != null)
            {
                btnMinimize.Location = new Point(formWidth - 150, 15);
            }
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
                
                // Draw admin icon
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
            var navButtons = new[] { ViewJobs, AdminManagement, manageCustomers, ViewInvoice, button9, ManageLoads, button11, ManageProducts };
            
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
            button10.MouseEnter += (s, e) =>
            {
                button10.BackColor = Color.FromArgb(192, 57, 43); // Darker red hover
            };
            
            button10.MouseLeave += (s, e) =>
            {
                button10.BackColor = Color.FromArgb(231, 76, 60); // Original red
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

        private void ViewJobs_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new ViewJobs());
        }

        private void AdminManagement_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new ManageAdmin());
        }

        private void manageCustomers_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new ManageCustomer());
        }

        private void ViewInvoice_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new ManageProducts());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Transport_units());
        }

        private void ManageLoads_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new ManageLoads());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new ViewReports());
        }

        private async void ManageProducts_Click(object sender, EventArgs e)
        {
            try
            {
                var admin = await adminRepository.GetAdminByUsernameAsync(_username);
                if (admin == null)
                {
                    MessageBox.Show("Unable to load admin details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LoadFormInPanel(new ProfileManage(admin));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading profile management: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                _mainForm.OpenFormInPanel();
                this.Hide();
            }
        }

        private void LoadFormInPanel(Form childForm)
        {
            // Clear existing controls
            PanelMain.Controls.Clear();

            // Configure child form
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            
            // Add to panel and show
            PanelMain.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void PanelMain_Paint(object sender, PaintEventArgs e)
        {
            // Only load default view on first paint
            if (PanelMain.Controls.Count == 0)
            {
                LoadFormInPanel(new ViewJobs());
            }
        }

        private async void AdminMain_Load(object sender, EventArgs e)
        {
            await LoadAdminDetails();
        }

        private async Task LoadAdminDetails()
        {
            try
            {
                if (string.IsNullOrEmpty(_username))
                {
                    SetDefaultAdminInfo();
                    return;
                }

                var admin = await adminRepository.GetAdminByUsernameAsync(_username);
                if (admin != null)
                {
                    lblAdminName.Text = admin.Name;
                    lblAdminUsername.Text = $"@{admin.Username}";
                    lblAdminEmail.Text = admin.Email;
                    lblWelcome.Text = $"Welcome back, {admin.Name}!";
                }
                else
                {
                    SetDefaultAdminInfo();
                }
            }
            catch (Exception ex)
            {
                SetDefaultAdminInfo();
            }
        }

        private void SetDefaultAdminInfo()
        {
            lblAdminName.Text = "Admin";
            lblAdminUsername.Text = "@admin";
            lblAdminEmail.Text = "admin@eshift.com";
            lblWelcome.Text = "Welcome back, Admin!";
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            timeTimer?.Stop();
            timeTimer?.Dispose();
            base.OnFormClosed(e);
        }
    }
}

