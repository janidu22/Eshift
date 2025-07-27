namespace Eshift.Forms
{
    partial class Choose
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
            mainContainer = new Panel();
            cardsContainer = new Panel();
            adminCard = new Panel();
            adminButton = new Button();
            adminDescription = new Label();
            adminCardHeader = new Panel();
            adminIcon = new Label();
            adminTitle = new Label();
            customerCard = new Panel();
            customerButton = new Button();
            customerDescription = new Label();
            customerCardHeader = new Panel();
            customerIcon = new Label();
            customerTitle = new Label();
            headerPanel = new Panel();
            subtitleLabel = new Label();
            headerLabel = new Label();
            logoPanel = new Panel();
            logoSubtitle = new Label();
            logoLabel = new Label();
            customerCardShadow = new Panel();
            adminCardShadow = new Panel();
            mainContainer.SuspendLayout();
            cardsContainer.SuspendLayout();
            adminCard.SuspendLayout();
            adminCardHeader.SuspendLayout();
            customerCard.SuspendLayout();
            customerCardHeader.SuspendLayout();
            headerPanel.SuspendLayout();
            logoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainContainer
            // 
            mainContainer.BackColor = Color.FromArgb(240, 244, 248);
            mainContainer.Controls.Add(cardsContainer);
            mainContainer.Controls.Add(headerPanel);
            mainContainer.Controls.Add(logoPanel);
            mainContainer.Dock = DockStyle.Fill;
            mainContainer.Location = new Point(0, 0);
            mainContainer.Name = "mainContainer";
            mainContainer.Size = new Size(496, 689);
            mainContainer.TabIndex = 0;
            // 
            // cardsContainer
            // 
            cardsContainer.BackColor = Color.Transparent;
            cardsContainer.Controls.Add(adminCard);
            cardsContainer.Controls.Add(customerCard);
            cardsContainer.Location = new Point(20, 150);
            cardsContainer.Name = "cardsContainer";
            cardsContainer.Size = new Size(456, 500);
            cardsContainer.TabIndex = 1;
            // 
            // adminCard
            // 
            adminCard.BackColor = Color.White;
            adminCard.Controls.Add(adminButton);
            adminCard.Controls.Add(adminDescription);
            adminCard.Controls.Add(adminCardHeader);
            adminCard.Location = new Point(236, 50);
            adminCard.Name = "adminCard";
            adminCard.Size = new Size(200, 400);
            adminCard.TabIndex = 1;

            // 
            // adminButton
            // 
            adminButton.BackColor = Color.FromArgb(46, 125, 50);
            adminButton.FlatAppearance.BorderSize = 0;
            adminButton.FlatStyle = FlatStyle.Flat;
            adminButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            adminButton.ForeColor = Color.White;
            adminButton.Location = new Point(15, 320);
            adminButton.Name = "adminButton";
            adminButton.Size = new Size(170, 45);
            adminButton.TabIndex = 2;
            adminButton.Text = "🔧 Enter Admin Portal";
            adminButton.UseVisualStyleBackColor = false;
            adminButton.Click += AdminButton_Click;
            // 
            // adminDescription
            // 
            adminDescription.Font = new Font("Segoe UI", 11F);
            adminDescription.ForeColor = Color.FromArgb(64, 64, 64);
            adminDescription.Location = new Point(15, 100);
            adminDescription.Name = "adminDescription";
            adminDescription.Size = new Size(170, 200);
            adminDescription.TabIndex = 1;
            adminDescription.Text = "Access your admin portal to:\r\n\r\n• Manage all shipments\r\n• View customer data\r\n• Generate reports\r\n• System administration\r\n• Monitor operations";
            // 
            // adminCardHeader
            // 
            adminCardHeader.BackColor = Color.FromArgb(46, 125, 50);
            adminCardHeader.Controls.Add(adminIcon);
            adminCardHeader.Controls.Add(adminTitle);
            adminCardHeader.Location = new Point(0, 0);
            adminCardHeader.Name = "adminCardHeader";
            adminCardHeader.Size = new Size(200, 80);
            adminCardHeader.TabIndex = 0;
            // 
            // adminIcon
            // 
            adminIcon.AutoSize = true;
            adminIcon.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            adminIcon.ForeColor = Color.White;
            adminIcon.Location = new Point(20, 20);
            adminIcon.Name = "adminIcon";
            adminIcon.Size = new Size(65, 45);
            adminIcon.TabIndex = 0;
            adminIcon.Text = "⚙️";
            // 
            // adminTitle
            // 
            adminTitle.AutoSize = true;
            adminTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            adminTitle.ForeColor = Color.White;
            adminTitle.Location = new Point(80, 25);
            adminTitle.Name = "adminTitle";
            adminTitle.Size = new Size(81, 30);
            adminTitle.TabIndex = 1;
            adminTitle.Text = "Admin";
            // 
            // customerCard
            // 
            customerCard.BackColor = Color.White;
            customerCard.Controls.Add(customerButton);
            customerCard.Controls.Add(customerDescription);
            customerCard.Controls.Add(customerCardHeader);
            customerCard.Location = new Point(20, 50);
            customerCard.Name = "customerCard";
            customerCard.Size = new Size(200, 400);
            customerCard.TabIndex = 0;

            // 
            // customerButton
            // 
            customerButton.BackColor = Color.FromArgb(46, 204, 113);
            customerButton.FlatAppearance.BorderSize = 0;
            customerButton.FlatStyle = FlatStyle.Flat;
            customerButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            customerButton.ForeColor = Color.White;
            customerButton.Location = new Point(15, 320);
            customerButton.Name = "customerButton";
            customerButton.Size = new Size(170, 45);
            customerButton.TabIndex = 2;
            customerButton.Text = "🚀 Enter Customer Portal";
            customerButton.UseVisualStyleBackColor = false;
            customerButton.Click += CustomerButton_Click;
            // 
            // customerDescription
            // 
            customerDescription.Font = new Font("Segoe UI", 11F);
            customerDescription.ForeColor = Color.FromArgb(64, 64, 64);
            customerDescription.Location = new Point(15, 100);
            customerDescription.Name = "customerDescription";
            customerDescription.Size = new Size(170, 200);
            customerDescription.TabIndex = 1;
            customerDescription.Text = "Access your customer portal to:\r\n\r\n• Create new shipping requests\r\n• Track your shipments\r\n• View job history\r\n• Manage your profile\r\n• Get real-time updates";
            // 
            // customerCardHeader
            // 
            customerCardHeader.BackColor = Color.FromArgb(46, 204, 113);
            customerCardHeader.Controls.Add(customerIcon);
            customerCardHeader.Controls.Add(customerTitle);
            customerCardHeader.Location = new Point(0, 0);
            customerCardHeader.Name = "customerCardHeader";
            customerCardHeader.Size = new Size(200, 80);
            customerCardHeader.TabIndex = 0;
            // 
            // customerIcon
            // 
            customerIcon.AutoSize = true;
            customerIcon.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            customerIcon.ForeColor = Color.White;
            customerIcon.Location = new Point(20, 20);
            customerIcon.Name = "customerIcon";
            customerIcon.Size = new Size(65, 45);
            customerIcon.TabIndex = 0;
            customerIcon.Text = "👤";
            // 
            // customerTitle
            // 
            customerTitle.AutoSize = true;
            customerTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            customerTitle.ForeColor = Color.White;
            customerTitle.Location = new Point(80, 25);
            customerTitle.Name = "customerTitle";
            customerTitle.Size = new Size(113, 30);
            customerTitle.TabIndex = 1;
            customerTitle.Text = "Customer";
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(25, 42, 86);
            headerPanel.Controls.Add(subtitleLabel);
            headerPanel.Controls.Add(headerLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(496, 120);
            headerPanel.TabIndex = 0;
            // 
            // subtitleLabel
            // 
            subtitleLabel.AutoSize = true;
            subtitleLabel.Font = new Font("Segoe UI", 14F);
            subtitleLabel.ForeColor = Color.FromArgb(200, 200, 200);
            subtitleLabel.Location = new Point(100, 85);
            subtitleLabel.Name = "subtitleLabel";
            subtitleLabel.Size = new Size(290, 25);
            subtitleLabel.TabIndex = 1;
            subtitleLabel.Text = "Choose your portal to get started";
            subtitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            headerLabel.ForeColor = Color.White;
            headerLabel.Location = new Point(45, 23);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(411, 51);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "🚀 Welcome to Eshift";
            headerLabel.TextAlign = ContentAlignment.MiddleCenter;
            headerLabel.Click += headerLabel_Click;
            // 
            // logoPanel
            // 
            logoPanel.BackColor = Color.FromArgb(25, 42, 86);
            logoPanel.Controls.Add(logoSubtitle);
            logoPanel.Controls.Add(logoLabel);
            logoPanel.Dock = DockStyle.Bottom;
            logoPanel.Location = new Point(0, 669);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(496, 20);
            logoPanel.TabIndex = 2;
            // 
            // logoSubtitle
            // 
            logoSubtitle.AutoSize = true;
            logoSubtitle.Font = new Font("Segoe UI", 6F);
            logoSubtitle.ForeColor = Color.FromArgb(150, 150, 150);
            logoSubtitle.Location = new Point(200, 15);
            logoSubtitle.Name = "logoSubtitle";
            logoSubtitle.Size = new Size(77, 11);
            logoSubtitle.TabIndex = 1;
            logoSubtitle.Text = "Your Trusted Partner";
            logoSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logoLabel
            // 
            logoLabel.AutoSize = true;
            logoLabel.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            logoLabel.ForeColor = Color.White;
            logoLabel.Location = new Point(200, 2);
            logoLabel.Name = "logoLabel";
            logoLabel.Size = new Size(84, 13);
            logoLabel.TabIndex = 0;
            logoLabel.Text = "Eshift Logistics";
            logoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customerCardShadow
            // 
            customerCardShadow.Location = new Point(0, 0);
            customerCardShadow.Name = "customerCardShadow";
            customerCardShadow.Size = new Size(200, 100);
            customerCardShadow.TabIndex = 0;
            // 
            // adminCardShadow
            // 
            adminCardShadow.Location = new Point(0, 0);
            adminCardShadow.Name = "adminCardShadow";
            adminCardShadow.Size = new Size(200, 100);
            adminCardShadow.TabIndex = 0;
            // 
            // Choose
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 42, 86);
            ClientSize = new Size(496, 689);
            Controls.Add(mainContainer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Choose";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eshift - Choose Your Portal";
            Load += Choose_Load;
            mainContainer.ResumeLayout(false);
            cardsContainer.ResumeLayout(false);
            adminCard.ResumeLayout(false);
            adminCardHeader.ResumeLayout(false);
            adminCardHeader.PerformLayout();
            customerCard.ResumeLayout(false);
            customerCardHeader.ResumeLayout(false);
            customerCardHeader.PerformLayout();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            logoPanel.ResumeLayout(false);
            logoPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainContainer;
        private Panel headerPanel;
        private Label headerLabel;
        private Label subtitleLabel;
        private Panel cardsContainer;
        private Panel customerCard;
        private Panel customerCardHeader;
        private Label customerIcon;
        private Label customerTitle;
        private Label customerDescription;
        private Button customerButton;
        private Panel customerCardShadow;
        private Panel adminCard;
        private Panel adminCardHeader;
        private Label adminIcon;
        private Label adminTitle;
        private Label adminDescription;
        private Button adminButton;
        private Panel adminCardShadow;
        private Panel logoPanel;
        private Label logoLabel;
        private Label logoSubtitle;
    }
}