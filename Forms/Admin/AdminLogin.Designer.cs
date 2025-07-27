namespace Eshift.Forms.Admin
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            
            mainContainer = new Panel();
            loginPanel = new Panel();
            loginHeaderPanel = new Panel();
            loginHeaderLabel = new Label();
            loginFormPanel = new Panel();
            btnBack = new Button();
            btnLogin = new Button();
            tbPassword = new TextBox();
            label2 = new Label();
            tbUsername = new TextBox();
            label1 = new Label();
            logoPanel = new Panel();
            pictureBox1 = new PictureBox();
            logoLabel = new Label();
            
            mainContainer.SuspendLayout();
            loginPanel.SuspendLayout();
            loginHeaderPanel.SuspendLayout();
            loginFormPanel.SuspendLayout();
            logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            
            // 
            // mainContainer
            // 
            mainContainer.BackColor = Color.FromArgb(240, 244, 248);
            mainContainer.Controls.Add(loginPanel);
            mainContainer.Controls.Add(logoPanel);
            mainContainer.Dock = DockStyle.Fill;
            mainContainer.Location = new Point(0, 0);
            mainContainer.Name = "mainContainer";
            mainContainer.Size = new Size(500, 600);
            mainContainer.TabIndex = 0;
            
            // 
            // loginPanel
            // 
            loginPanel.BackColor = Color.White;
            loginPanel.Controls.Add(loginFormPanel);
            loginPanel.Controls.Add(loginHeaderPanel);
            loginPanel.Dock = DockStyle.Right;
            loginPanel.Location = new Point(250, 0);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(250, 600);
            loginPanel.TabIndex = 1;
            
            // 
            // loginHeaderPanel
            // 
            loginHeaderPanel.BackColor = Color.FromArgb(46, 125, 50);
            loginHeaderPanel.Controls.Add(loginHeaderLabel);
            loginHeaderPanel.Dock = DockStyle.Top;
            loginHeaderPanel.Location = new Point(0, 0);
            loginHeaderPanel.Name = "loginHeaderPanel";
            loginHeaderPanel.Size = new Size(250, 60);
            loginHeaderPanel.TabIndex = 0;
            
            // 
            // loginHeaderLabel
            // 
            loginHeaderLabel.AutoSize = true;
            loginHeaderLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            loginHeaderLabel.ForeColor = Color.White;
            loginHeaderLabel.Location = new Point(20, 18);
            loginHeaderLabel.Name = "loginHeaderLabel";
            loginHeaderLabel.Size = new Size(120, 25);
            loginHeaderLabel.TabIndex = 0;
            loginHeaderLabel.Text = "🔐 Admin Login";
            
            // 
            // loginFormPanel
            // 
            loginFormPanel.BackColor = Color.White;
            loginFormPanel.Controls.Add(btnBack);
            loginFormPanel.Controls.Add(btnLogin);
            loginFormPanel.Controls.Add(tbPassword);
            loginFormPanel.Controls.Add(label2);
            loginFormPanel.Controls.Add(tbUsername);
            loginFormPanel.Controls.Add(label1);
            loginFormPanel.Dock = DockStyle.Fill;
            loginFormPanel.Location = new Point(0, 60);
            loginFormPanel.Name = "loginFormPanel";
            loginFormPanel.Padding = new Padding(30);
            loginFormPanel.Size = new Size(250, 540);
            loginFormPanel.TabIndex = 1;
            
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(96, 125, 139);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(30, 480);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(190, 40);
            btnBack.TabIndex = 5;
            btnBack.Text = "⬅️ Back to Main";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(46, 125, 50);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(30, 420);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(190, 45);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "🚀 Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.White;
            tbPassword.Font = new Font("Segoe UI", 11F);
            tbPassword.ForeColor = Color.FromArgb(64, 64, 64);
            tbPassword.Location = new Point(30, 320);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.PlaceholderText = "Enter your password";
            tbPassword.Size = new Size(190, 27);
            tbPassword.TabIndex = 3;
            
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(25, 42, 86);
            label2.Location = new Point(30, 295);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            
            // 
            // tbUsername
            // 
            tbUsername.BackColor = Color.White;
            tbUsername.Font = new Font("Segoe UI", 11F);
            tbUsername.ForeColor = Color.FromArgb(64, 64, 64);
            tbUsername.Location = new Point(30, 240);
            tbUsername.Name = "tbUsername";
            tbUsername.PlaceholderText = "Enter your username";
            tbUsername.Size = new Size(190, 27);
            tbUsername.TabIndex = 1;
            
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(25, 42, 86);
            label1.Location = new Point(30, 215);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            
            // 
            // logoPanel
            // 
            logoPanel.BackColor = Color.FromArgb(25, 42, 86);
            logoPanel.Controls.Add(logoLabel);
            logoPanel.Controls.Add(pictureBox1);
            logoPanel.Dock = DockStyle.Left;
            logoPanel.Location = new Point(0, 0);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(250, 600);
            logoPanel.TabIndex = 0;
            
            // 
            // logoLabel
            // 
            logoLabel.AutoSize = true;
            logoLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            logoLabel.ForeColor = Color.White;
            logoLabel.Location = new Point(50, 400);
            logoLabel.Name = "logoLabel";
            logoLabel.Size = new Size(150, 32);
            logoLabel.TabIndex = 1;
            logoLabel.Text = "Eshift Admin";
            logoLabel.TextAlign = ContentAlignment.MiddleCenter;
            
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(75, 150);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 42, 86);
            ClientSize = new Size(500, 600);
            Controls.Add(mainContainer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Login - Eshift";
            Load += AdminLogin_Load;
            mainContainer.ResumeLayout(false);
            loginPanel.ResumeLayout(false);
            loginHeaderPanel.ResumeLayout(false);
            loginHeaderPanel.PerformLayout();
            loginFormPanel.ResumeLayout(false);
            loginFormPanel.PerformLayout();
            logoPanel.ResumeLayout(false);
            logoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainContainer;
        private Panel loginPanel;
        private Panel loginHeaderPanel;
        private Label loginHeaderLabel;
        private Panel loginFormPanel;
        private Button btnBack;
        private Button btnLogin;
        private TextBox tbPassword;
        private Label label2;
        private TextBox tbUsername;
        private Label label1;
        private Panel logoPanel;
        private PictureBox pictureBox1;
        private Label logoLabel;
    }
}