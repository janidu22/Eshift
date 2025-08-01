namespace Eshift.Forms.Admin
{
    partial class AdminMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // Header Panel
            panelHeader = new Panel();
            lblWelcome = new Label();
            lblCurrentTime = new Label();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            lblAppTitle = new Label();
            
            // Sidebar Panel
            panelSidebar = new Panel();
            panelProfile = new Panel();
            picBoxProfile = new PictureBox();
            lblAdminName = new Label();
            lblAdminUsername = new Label();
            lblAdminEmail = new Label();
            
            // Navigation Buttons
            ViewJobs = new Button();
            AdminManagement = new Button();
            manageCustomers = new Button();
            ViewInvoice = new Button();
            button9 = new Button();
            ManageLoads = new Button();
            button11 = new Button();
            ManageProducts = new Button();
            button10 = new Button();
            
            // Main Content Panel
            PanelMain = new Panel();
            
            // Separator lines
            separatorLine1 = new Panel();
            separatorLine2 = new Panel();

            panelHeader.SuspendLayout();
            panelSidebar.SuspendLayout();
            panelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxProfile).BeginInit();
            SuspendLayout();

            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(25, 42, 86); // Midnight Blue
            panelHeader.Controls.Add(lblWelcome);
            panelHeader.Controls.Add(lblCurrentTime);
            panelHeader.Controls.Add(btnMinimize);
            panelHeader.Controls.Add(btnMaximize);
            panelHeader.Controls.Add(btnClose);
            panelHeader.Controls.Add(lblAppTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Height = 70;
            panelHeader.Name = "panelHeader";

            // 
            // lblAppTitle
            // 
            lblAppTitle.AutoSize = true;
            lblAppTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblAppTitle.ForeColor = Color.White;
            lblAppTitle.Location = new Point(20, 20);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Text = "eShift Admin Dashboard";

            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12F);
            lblWelcome.ForeColor = Color.FromArgb(46, 204, 113); // Green
            lblWelcome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblWelcome.Location = new Point(400, 15); // Will be adjusted dynamically
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Text = "Welcome back, Admin!";

            // 
            // lblCurrentTime
            // 
            lblCurrentTime.AutoSize = true;
            lblCurrentTime.Font = new Font("Segoe UI", 10F);
            lblCurrentTime.ForeColor = Color.White;
            lblCurrentTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCurrentTime.Location = new Point(400, 38); // Will be adjusted dynamically
            lblCurrentTime.Name = "lblCurrentTime";
            lblCurrentTime.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");

            // Window Control Buttons
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(231, 76, 60);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(this.Width - 60, 15); // Dynamic positioning
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 30);
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = false;

            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = Color.FromArgb(52, 152, 219);
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMaximize.ForeColor = Color.White;
            btnMaximize.Location = new Point(this.Width - 105, 15); // Dynamic positioning
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(40, 30);
            btnMaximize.Text = "□";
            btnMaximize.UseVisualStyleBackColor = false;

            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.FromArgb(241, 196, 15);
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(this.Width - 150, 15); // Dynamic positioning
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(40, 30);
            btnMinimize.Text = "−";
            btnMinimize.UseVisualStyleBackColor = false;

            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(44, 62, 80); // Dark Blue-Gray
            panelSidebar.Controls.Add(panelProfile);
            panelSidebar.Controls.Add(separatorLine1);
            panelSidebar.Controls.Add(ViewJobs);
            panelSidebar.Controls.Add(AdminManagement);
            panelSidebar.Controls.Add(manageCustomers);
            panelSidebar.Controls.Add(ViewInvoice);
            panelSidebar.Controls.Add(button9);
            panelSidebar.Controls.Add(ManageLoads);
            panelSidebar.Controls.Add(button11);
            panelSidebar.Controls.Add(separatorLine2);
            panelSidebar.Controls.Add(ManageProducts);
            panelSidebar.Controls.Add(button10);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Width = 280;
            panelSidebar.Name = "panelSidebar";

            // 
            // panelProfile
            // 
            panelProfile.BackColor = Color.FromArgb(52, 73, 94);
            panelProfile.Controls.Add(picBoxProfile);
            panelProfile.Controls.Add(lblAdminName);
            panelProfile.Controls.Add(lblAdminUsername);
            panelProfile.Controls.Add(lblAdminEmail);
            panelProfile.Dock = DockStyle.Top;
            panelProfile.Height = 120;
            panelProfile.Name = "panelProfile";
            panelProfile.Padding = new Padding(20, 10, 20, 10);

            // 
            // picBoxProfile
            // 
            picBoxProfile.BackColor = Color.FromArgb(46, 204, 113);
            picBoxProfile.Location = new Point(20, 15);
            picBoxProfile.Name = "picBoxProfile";
            picBoxProfile.Size = new Size(60, 60);
            picBoxProfile.SizeMode = PictureBoxSizeMode.CenterImage;

            // 
            // lblAdminName
            // 
            lblAdminName.AutoSize = true;
            lblAdminName.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblAdminName.ForeColor = Color.White;
            lblAdminName.Location = new Point(90, 15);
            lblAdminName.Name = "lblAdminName";
            lblAdminName.Text = "Admin Name";

            // 
            // lblAdminUsername
            // 
            lblAdminUsername.AutoSize = true;
            lblAdminUsername.Font = new Font("Segoe UI", 10F);
            lblAdminUsername.ForeColor = Color.FromArgb(189, 195, 199);
            lblAdminUsername.Location = new Point(90, 40);
            lblAdminUsername.Name = "lblAdminUsername";
            lblAdminUsername.Text = "@username";

            // 
            // lblAdminEmail
            // 
            lblAdminEmail.AutoSize = true;
            lblAdminEmail.Font = new Font("Segoe UI", 9F);
            lblAdminEmail.ForeColor = Color.FromArgb(189, 195, 199);
            lblAdminEmail.Location = new Point(90, 58);
            lblAdminEmail.Name = "lblAdminEmail";
            lblAdminEmail.Text = "admin@eshift.com";

            // 
            // separatorLine1
            // 
            separatorLine1.BackColor = Color.FromArgb(127, 140, 141);
            separatorLine1.Dock = DockStyle.Top;
            separatorLine1.Height = 1;
            separatorLine1.Name = "separatorLine1";

            // Modern Navigation Buttons
            // 
            // ViewJobs
            // 
            ViewJobs.BackColor = Color.Transparent;
            ViewJobs.Dock = DockStyle.Top;
            ViewJobs.FlatStyle = FlatStyle.Flat;
            ViewJobs.FlatAppearance.BorderSize = 0;
            ViewJobs.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 204, 113);
            ViewJobs.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            ViewJobs.ForeColor = Color.White;
            ViewJobs.Height = 55;
            ViewJobs.ImageAlign = ContentAlignment.MiddleLeft;
            ViewJobs.Name = "ViewJobs";
            ViewJobs.Padding = new Padding(25, 0, 0, 0);
            ViewJobs.Text = "📋  Manage & View Jobs";
            ViewJobs.TextAlign = ContentAlignment.MiddleLeft;
            ViewJobs.UseVisualStyleBackColor = false;
            ViewJobs.Click += ViewJobs_Click;

            // 
            // AdminManagement
            // 
            AdminManagement.BackColor = Color.Transparent;
            AdminManagement.Dock = DockStyle.Top;
            AdminManagement.FlatStyle = FlatStyle.Flat;
            AdminManagement.FlatAppearance.BorderSize = 0;
            AdminManagement.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 204, 113);
            AdminManagement.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            AdminManagement.ForeColor = Color.White;
            AdminManagement.Height = 55;
            AdminManagement.Name = "AdminManagement";
            AdminManagement.Padding = new Padding(25, 0, 0, 0);
            AdminManagement.Text = "👥  Manage Admins";
            AdminManagement.TextAlign = ContentAlignment.MiddleLeft;
            AdminManagement.UseVisualStyleBackColor = false;
            AdminManagement.Click += AdminManagement_Click;

            // 
            // manageCustomers
            // 
            manageCustomers.BackColor = Color.Transparent;
            manageCustomers.Dock = DockStyle.Top;
            manageCustomers.FlatStyle = FlatStyle.Flat;
            manageCustomers.FlatAppearance.BorderSize = 0;
            manageCustomers.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 204, 113);
            manageCustomers.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            manageCustomers.ForeColor = Color.White;
            manageCustomers.Height = 55;
            manageCustomers.Name = "manageCustomers";
            manageCustomers.Padding = new Padding(25, 0, 0, 0);
            manageCustomers.Text = "👤  Manage Customers";
            manageCustomers.TextAlign = ContentAlignment.MiddleLeft;
            manageCustomers.UseVisualStyleBackColor = false;
            manageCustomers.Click += manageCustomers_Click;

            // 
            // ViewInvoice
            // 
            ViewInvoice.BackColor = Color.Transparent;
            ViewInvoice.Dock = DockStyle.Top;
            ViewInvoice.FlatStyle = FlatStyle.Flat;
            ViewInvoice.FlatAppearance.BorderSize = 0;
            ViewInvoice.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 204, 113);
            ViewInvoice.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            ViewInvoice.ForeColor = Color.White;
            ViewInvoice.Height = 55;
            ViewInvoice.Name = "ViewInvoice";
            ViewInvoice.Padding = new Padding(25, 0, 0, 0);
            ViewInvoice.Text = "📦  Manage Products";
            ViewInvoice.TextAlign = ContentAlignment.MiddleLeft;
            ViewInvoice.UseVisualStyleBackColor = false;
            ViewInvoice.Click += ViewInvoice_Click;

            // 
            // button9
            // 
            button9.BackColor = Color.Transparent;
            button9.Dock = DockStyle.Top;
            button9.FlatStyle = FlatStyle.Flat;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 204, 113);
            button9.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            button9.ForeColor = Color.White;
            button9.Height = 55;
            button9.Name = "button9";
            button9.Padding = new Padding(25, 0, 0, 0);
            button9.Text = "🚛  Manage Transport Unit";
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;

            // 
            // ManageLoads
            // 
            ManageLoads.BackColor = Color.Transparent;
            ManageLoads.Dock = DockStyle.Top;
            ManageLoads.FlatStyle = FlatStyle.Flat;
            ManageLoads.FlatAppearance.BorderSize = 0;
            ManageLoads.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 204, 113);
            ManageLoads.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            ManageLoads.ForeColor = Color.White;
            ManageLoads.Height = 55;
            ManageLoads.Name = "ManageLoads";
            ManageLoads.Padding = new Padding(25, 0, 0, 0);
            ManageLoads.Text = "📊  Manage Loads";
            ManageLoads.TextAlign = ContentAlignment.MiddleLeft;
            ManageLoads.UseVisualStyleBackColor = false;
            ManageLoads.Click += ManageLoads_Click;

            // 
            // button11
            // 
            button11.BackColor = Color.Transparent;
            button11.Dock = DockStyle.Top;
            button11.FlatStyle = FlatStyle.Flat;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 204, 113);
            button11.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            button11.ForeColor = Color.White;
            button11.Height = 55;
            button11.Name = "button11";
            button11.Padding = new Padding(25, 0, 0, 0);
            button11.Text = "📈  View Reports";
            button11.TextAlign = ContentAlignment.MiddleLeft;
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;

            // 
            // separatorLine2
            // 
            separatorLine2.BackColor = Color.FromArgb(127, 140, 141);
            separatorLine2.Dock = DockStyle.Top;
            separatorLine2.Height = 1;
            separatorLine2.Name = "separatorLine2";

            // 
            // ManageProducts
            // 
            ManageProducts.BackColor = Color.Transparent;
            ManageProducts.Dock = DockStyle.Top;
            ManageProducts.FlatStyle = FlatStyle.Flat;
            ManageProducts.FlatAppearance.BorderSize = 0;
            ManageProducts.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 204, 113);
            ManageProducts.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            ManageProducts.ForeColor = Color.White;
            ManageProducts.Height = 55;
            ManageProducts.Name = "ManageProducts";
            ManageProducts.Padding = new Padding(25, 0, 0, 0);
            ManageProducts.Text = "⚙️  Profile Management";
            ManageProducts.TextAlign = ContentAlignment.MiddleLeft;
            ManageProducts.UseVisualStyleBackColor = false;
            ManageProducts.Click += ManageProducts_Click;

            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(231, 76, 60);
            button10.Dock = DockStyle.Bottom;
            button10.FlatStyle = FlatStyle.Flat;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 57, 43);
            button10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button10.ForeColor = Color.White;
            button10.Height = 60;
            button10.Name = "button10";
            button10.Padding = new Padding(25, 0, 0, 0);
            button10.Text = "🚪  Logout";
            button10.TextAlign = ContentAlignment.MiddleLeft;
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;

            // 
            // PanelMain
            // 
            PanelMain.BackColor = Color.FromArgb(236, 240, 241);
            PanelMain.Dock = DockStyle.Fill;
            PanelMain.Name = "PanelMain";
            PanelMain.Padding = new Padding(20);
            PanelMain.Paint += PanelMain_Paint;

            // 
            // AdminMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(1200, 700); // Reduced default size for better laptop compatibility
            MinimumSize = new Size(1000, 600); // Set minimum size for usability
            Controls.Add(PanelMain);
            Controls.Add(panelSidebar);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "eShift Admin Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += AdminMain_Load;

            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelSidebar.ResumeLayout(false);
            panelProfile.ResumeLayout(false);
            panelProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxProfile).EndInit();
            ResumeLayout(false);
        }

        #endregion

        // Header Components
        private Panel panelHeader;
        private Label lblAppTitle;
        private Label lblWelcome;
        private Label lblCurrentTime;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnClose;

        // Sidebar Components
        private Panel panelSidebar;
        private Panel panelProfile;
        private PictureBox picBoxProfile;
        private Label lblAdminName;
        private Label lblAdminUsername;
        private Label lblAdminEmail;

        // Navigation Buttons
        private Button ViewJobs;
        private Button AdminManagement;
        private Button manageCustomers;
        private Button ViewInvoice;
        private Button button9;
        private Button ManageLoads;
        private Button button11;
        private Button ManageProducts;
        private Button button10;

        // Main Content
        private Panel PanelMain;

        // Separators
        private Panel separatorLine1;
        private Panel separatorLine2;
    }
}