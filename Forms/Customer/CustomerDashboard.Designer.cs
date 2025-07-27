namespace Eshift.Forms.Customer
{
    partial class CustomerDashboard
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
            lbName = new Label();
            lbUsername = new Label();
            lbEmail = new Label();
            lbPhone = new Label();
            
            // Navigation Buttons
            ViewJobs = new Button();
            NewJobRequest = new Button();
            TrackStatus = new Button();
            MyProfile = new Button();
            Logout = new Button();
            
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
            lblAppTitle.Text = "eShift Customer Portal";

            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12F);
            lblWelcome.ForeColor = Color.FromArgb(46, 204, 113); // Green
            lblWelcome.Location = new Point(600, 15);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Text = "Welcome back!";

            // 
            // lblCurrentTime
            // 
            lblCurrentTime.AutoSize = true;
            lblCurrentTime.Font = new Font("Segoe UI", 10F);
            lblCurrentTime.ForeColor = Color.White;
            lblCurrentTime.Location = new Point(600, 38);
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
            btnClose.Location = new Point(1320, 15);
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
            btnMaximize.Location = new Point(1275, 15);
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
            btnMinimize.Location = new Point(1230, 15);
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
            panelSidebar.Controls.Add(NewJobRequest);
            panelSidebar.Controls.Add(TrackStatus);
            panelSidebar.Controls.Add(separatorLine2);
            panelSidebar.Controls.Add(MyProfile);
            panelSidebar.Controls.Add(Logout);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Width = 280;
            panelSidebar.Name = "panelSidebar";

            // 
            // panelProfile
            // 
            panelProfile.BackColor = Color.FromArgb(52, 73, 94);
            panelProfile.Controls.Add(picBoxProfile);
            panelProfile.Controls.Add(lbName);
            panelProfile.Controls.Add(lbUsername);
            panelProfile.Controls.Add(lbEmail);
            panelProfile.Controls.Add(lbPhone);
            panelProfile.Dock = DockStyle.Top;
            panelProfile.Height = 140;
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
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbName.ForeColor = Color.White;
            lbName.Location = new Point(90, 15);
            lbName.Name = "lbName";
            lbName.Text = "Customer Name";

            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI", 10F);
            lbUsername.ForeColor = Color.FromArgb(189, 195, 199);
            lbUsername.Location = new Point(90, 40);
            lbUsername.Name = "lbUsername";
            lbUsername.Text = "@username";

            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Segoe UI", 9F);
            lbEmail.ForeColor = Color.FromArgb(189, 195, 199);
            lbEmail.Location = new Point(90, 58);
            lbEmail.Name = "lbEmail";
            lbEmail.Text = "customer@eshift.com";

            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Font = new Font("Segoe UI", 9F);
            lbPhone.ForeColor = Color.FromArgb(189, 195, 199);
            lbPhone.Location = new Point(90, 76);
            lbPhone.Name = "lbPhone";
            lbPhone.Text = "+1 (555) 123-4567";

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
            ViewJobs.Text = "📋  View My Jobs";
            ViewJobs.TextAlign = ContentAlignment.MiddleLeft;
            ViewJobs.UseVisualStyleBackColor = false;
            ViewJobs.Click += ViewJobs_Click;

            // 
            // NewJobRequest
            // 
            NewJobRequest.BackColor = Color.Transparent;
            NewJobRequest.Dock = DockStyle.Top;
            NewJobRequest.FlatStyle = FlatStyle.Flat;
            NewJobRequest.FlatAppearance.BorderSize = 0;
            NewJobRequest.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 204, 113);
            NewJobRequest.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            NewJobRequest.ForeColor = Color.White;
            NewJobRequest.Height = 55;
            NewJobRequest.Name = "NewJobRequest";
            NewJobRequest.Padding = new Padding(25, 0, 0, 0);
            NewJobRequest.Text = "➕  New Job Request";
            NewJobRequest.TextAlign = ContentAlignment.MiddleLeft;
            NewJobRequest.UseVisualStyleBackColor = false;
            NewJobRequest.Click += NewJobRequest_Click;

            // 
            // TrackStatus
            // 
            TrackStatus.BackColor = Color.Transparent;
            TrackStatus.Dock = DockStyle.Top;
            TrackStatus.FlatStyle = FlatStyle.Flat;
            TrackStatus.FlatAppearance.BorderSize = 0;
            TrackStatus.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 204, 113);
            TrackStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            TrackStatus.ForeColor = Color.White;
            TrackStatus.Height = 55;
            TrackStatus.Name = "TrackStatus";
            TrackStatus.Padding = new Padding(25, 0, 0, 0);
            TrackStatus.Text = "📍  Track Job Status";
            TrackStatus.TextAlign = ContentAlignment.MiddleLeft;
            TrackStatus.UseVisualStyleBackColor = false;
            TrackStatus.Click += TrackStatus_Click;

            // 
            // separatorLine2
            // 
            separatorLine2.BackColor = Color.FromArgb(127, 140, 141);
            separatorLine2.Dock = DockStyle.Top;
            separatorLine2.Height = 1;
            separatorLine2.Name = "separatorLine2";

            // 
            // MyProfile
            // 
            MyProfile.BackColor = Color.Transparent;
            MyProfile.Dock = DockStyle.Top;
            MyProfile.FlatStyle = FlatStyle.Flat;
            MyProfile.FlatAppearance.BorderSize = 0;
            MyProfile.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 204, 113);
            MyProfile.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            MyProfile.ForeColor = Color.White;
            MyProfile.Height = 55;
            MyProfile.Name = "MyProfile";
            MyProfile.Padding = new Padding(25, 0, 0, 0);
            MyProfile.Text = "👤  My Profile";
            MyProfile.TextAlign = ContentAlignment.MiddleLeft;
            MyProfile.UseVisualStyleBackColor = false;
            MyProfile.Click += MyProfile_Click;

            // 
            // Logout
            // 
            Logout.BackColor = Color.FromArgb(231, 76, 60);
            Logout.Dock = DockStyle.Bottom;
            Logout.FlatStyle = FlatStyle.Flat;
            Logout.FlatAppearance.BorderSize = 0;
            Logout.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 57, 43);
            Logout.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Logout.ForeColor = Color.White;
            Logout.Height = 60;
            Logout.Name = "Logout";
            Logout.Padding = new Padding(25, 0, 0, 0);
            Logout.Text = "🚪  Logout";
            Logout.TextAlign = ContentAlignment.MiddleLeft;
            Logout.UseVisualStyleBackColor = false;
            Logout.Click += Logout_Click;

            // 
            // PanelMain
            // 
            PanelMain.BackColor = Color.FromArgb(236, 240, 241);
            PanelMain.Dock = DockStyle.Fill;
            PanelMain.Name = "PanelMain";
            PanelMain.Padding = new Padding(20);
            PanelMain.Paint += PanelMain_Paint;

            // 
            // CustomerDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(1400, 800);
            Controls.Add(PanelMain);
            Controls.Add(panelSidebar);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "eShift Customer Portal";
            WindowState = FormWindowState.Maximized;
            Load += CustomerDashboard_Load;

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
        private Label lbName;
        private Label lbUsername;
        private Label lbEmail;
        private Label lbPhone;

        // Navigation Buttons
        private Button ViewJobs;
        private Button NewJobRequest;
        private Button TrackStatus;
        private Button MyProfile;
        private Button Logout;

        // Main Content
        private Panel PanelMain;

        // Separators
        private Panel separatorLine1;
        private Panel separatorLine2;
    }
}