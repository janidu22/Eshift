namespace Eshift.Forms.Admin
{
    partial class ManageAdmin
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            
            panel1 = new Panel();
            label1 = new Label();
            mainContainer = new Panel();
            adminViewPanel = new Panel();
            viewAdminsDt = new DataGridView();
            adminManagementPanel = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            adminFormPanel = new Panel();
            tbPassword = new TextBox();
            label6 = new Label();
            tbUsername = new TextBox();
            label5 = new Label();
            tbEmail = new TextBox();
            label4 = new Label();
            tbName = new TextBox();
            label3 = new Label();
            actionButtonsPanel = new Panel();
            btnDeleteAdmin = new Button();
            btnUpdateAdmin = new Button();
            btnAddAdmin = new Button();
            add = new Button();
            
            panel1.SuspendLayout();
            mainContainer.SuspendLayout();
            adminViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewAdminsDt).BeginInit();
            adminManagementPanel.SuspendLayout();
            panel2.SuspendLayout();
            adminFormPanel.SuspendLayout();
            actionButtonsPanel.SuspendLayout();
            SuspendLayout();
            
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 42, 86);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 60);
            panel1.TabIndex = 0;
            
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 16);
            label1.Name = "label1";
            label1.Size = new Size(227, 32);
            label1.TabIndex = 0;
            label1.Text = "👥 Manage Admins";
            
            // 
            // mainContainer
            // 
            mainContainer.BackColor = Color.FromArgb(240, 244, 248);
            mainContainer.Controls.Add(adminViewPanel);
            mainContainer.Controls.Add(adminManagementPanel);
            mainContainer.Dock = DockStyle.Fill;
            mainContainer.Location = new Point(0, 60);
            mainContainer.Name = "mainContainer";
            mainContainer.Padding = new Padding(10);
            mainContainer.Size = new Size(1200, 640);
            mainContainer.TabIndex = 1;
            
            // 
            // adminViewPanel
            // 
            adminViewPanel.BackColor = Color.White;
            adminViewPanel.Controls.Add(viewAdminsDt);
            adminViewPanel.Dock = DockStyle.Fill;
            adminViewPanel.Location = new Point(10, 10);
            adminViewPanel.Name = "adminViewPanel";
            adminViewPanel.Padding = new Padding(20);
            adminViewPanel.Size = new Size(780, 620);
            adminViewPanel.TabIndex = 1;
            
            // 
            // viewAdminsDt
            // 
            viewAdminsDt.AllowUserToAddRows = false;
            viewAdminsDt.AllowUserToDeleteRows = false;
            viewAdminsDt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewAdminsDt.BackgroundColor = Color.White;
            viewAdminsDt.BorderStyle = BorderStyle.None;
            viewAdminsDt.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            viewAdminsDt.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(25, 42, 86);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(25, 42, 86);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            viewAdminsDt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            viewAdminsDt.ColumnHeadersHeight = 45;
            viewAdminsDt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(25, 42, 86);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            viewAdminsDt.DefaultCellStyle = dataGridViewCellStyle2;
            viewAdminsDt.Dock = DockStyle.Fill;
            viewAdminsDt.EnableHeadersVisualStyles = false;
            viewAdminsDt.GridColor = Color.FromArgb(230, 230, 230);
            viewAdminsDt.Location = new Point(20, 20);
            viewAdminsDt.MultiSelect = false;
            viewAdminsDt.Name = "viewAdminsDt";
            viewAdminsDt.ReadOnly = true;
            viewAdminsDt.RowHeadersVisible = false;
            viewAdminsDt.RowTemplate.Height = 35;
            viewAdminsDt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            viewAdminsDt.Size = new Size(740, 580);
            viewAdminsDt.TabIndex = 0;
            viewAdminsDt.SelectionChanged += viewAdminsDt_SelectionChanged;
            
            // 
            // adminManagementPanel
            // 
            adminManagementPanel.BackColor = Color.FromArgb(25, 42, 86);
            adminManagementPanel.Controls.Add(actionButtonsPanel);
            adminManagementPanel.Controls.Add(adminFormPanel);
            adminManagementPanel.Controls.Add(panel2);
            adminManagementPanel.Dock = DockStyle.Right;
            adminManagementPanel.Location = new Point(790, 10);
            adminManagementPanel.Name = "adminManagementPanel";
            adminManagementPanel.Size = new Size(400, 620);
            adminManagementPanel.TabIndex = 0;
            
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(46, 125, 50);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 60);
            panel2.TabIndex = 0;
            
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 18);
            label2.Name = "label2";
            label2.Size = new Size(207, 25);
            label2.TabIndex = 0;
            label2.Text = "👤 Admin Management";
            
            // 
            // adminFormPanel
            // 
            adminFormPanel.BackColor = Color.White;
            adminFormPanel.Controls.Add(tbPassword);
            adminFormPanel.Controls.Add(label6);
            adminFormPanel.Controls.Add(tbUsername);
            adminFormPanel.Controls.Add(label5);
            adminFormPanel.Controls.Add(tbEmail);
            adminFormPanel.Controls.Add(label4);
            adminFormPanel.Controls.Add(tbName);
            adminFormPanel.Controls.Add(label3);
            adminFormPanel.Dock = DockStyle.Fill;
            adminFormPanel.Location = new Point(0, 60);
            adminFormPanel.Name = "adminFormPanel";
            adminFormPanel.Padding = new Padding(25);
            adminFormPanel.Size = new Size(400, 480);
            adminFormPanel.TabIndex = 1;
            
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.White;
            tbPassword.Font = new Font("Segoe UI", 11F);
            tbPassword.ForeColor = Color.FromArgb(64, 64, 64);
            tbPassword.Location = new Point(25, 370);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.PlaceholderText = "Enter password";
            tbPassword.Size = new Size(350, 27);
            tbPassword.TabIndex = 7;
            
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(25, 42, 86);
            label6.Location = new Point(25, 345);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 6;
            label6.Text = "Password";
            
            // 
            // tbUsername
            // 
            tbUsername.BackColor = Color.White;
            tbUsername.Font = new Font("Segoe UI", 11F);
            tbUsername.ForeColor = Color.FromArgb(64, 64, 64);
            tbUsername.Location = new Point(25, 290);
            tbUsername.Name = "tbUsername";
            tbUsername.PlaceholderText = "Enter username";
            tbUsername.Size = new Size(350, 27);
            tbUsername.TabIndex = 5;
            
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(25, 42, 86);
            label5.Location = new Point(25, 265);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 4;
            label5.Text = "Username";
            
            // 
            // tbEmail
            // 
            tbEmail.BackColor = Color.White;
            tbEmail.Font = new Font("Segoe UI", 11F);
            tbEmail.ForeColor = Color.FromArgb(64, 64, 64);
            tbEmail.Location = new Point(25, 210);
            tbEmail.Name = "tbEmail";
            tbEmail.PlaceholderText = "Enter email address";
            tbEmail.Size = new Size(350, 27);
            tbEmail.TabIndex = 3;
            
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(25, 42, 86);
            label4.Location = new Point(25, 185);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 2;
            label4.Text = "Email";
            
            // 
            // tbName
            // 
            tbName.BackColor = Color.White;
            tbName.Font = new Font("Segoe UI", 11F);
            tbName.ForeColor = Color.FromArgb(64, 64, 64);
            tbName.Location = new Point(25, 130);
            tbName.Name = "tbName";
            tbName.PlaceholderText = "Enter full name";
            tbName.Size = new Size(350, 27);
            tbName.TabIndex = 1;
            
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(25, 42, 86);
            label3.Location = new Point(25, 105);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 0;
            label3.Text = "Name";
            
            // 
            // actionButtonsPanel
            // 
            actionButtonsPanel.BackColor = Color.FromArgb(240, 244, 248);
            actionButtonsPanel.Controls.Add(btnDeleteAdmin);
            actionButtonsPanel.Controls.Add(btnUpdateAdmin);
            actionButtonsPanel.Controls.Add(btnAddAdmin);
            actionButtonsPanel.Controls.Add(add);
            actionButtonsPanel.Dock = DockStyle.Bottom;
            actionButtonsPanel.Location = new Point(0, 540);
            actionButtonsPanel.Name = "actionButtonsPanel";
            actionButtonsPanel.Padding = new Padding(25);
            actionButtonsPanel.Size = new Size(400, 80);
            actionButtonsPanel.TabIndex = 2;
            
            // 
            // btnDeleteAdmin
            // 
            btnDeleteAdmin.BackColor = Color.FromArgb(211, 47, 47);
            btnDeleteAdmin.FlatAppearance.BorderSize = 0;
            btnDeleteAdmin.FlatStyle = FlatStyle.Flat;
            btnDeleteAdmin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteAdmin.ForeColor = Color.White;
            btnDeleteAdmin.Location = new Point(295, 20);
            btnDeleteAdmin.Name = "btnDeleteAdmin";
            btnDeleteAdmin.Size = new Size(80, 40);
            btnDeleteAdmin.TabIndex = 3;
            btnDeleteAdmin.Text = "🗑️ Delete";
            btnDeleteAdmin.UseVisualStyleBackColor = false;
            btnDeleteAdmin.Click += btnDeleteAdmin_Click;
            
            // 
            // btnUpdateAdmin
            // 
            btnUpdateAdmin.BackColor = Color.FromArgb(255, 152, 0);
            btnUpdateAdmin.FlatAppearance.BorderSize = 0;
            btnUpdateAdmin.FlatStyle = FlatStyle.Flat;
            btnUpdateAdmin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdateAdmin.ForeColor = Color.White;
            btnUpdateAdmin.Location = new Point(205, 20);
            btnUpdateAdmin.Name = "btnUpdateAdmin";
            btnUpdateAdmin.Size = new Size(80, 40);
            btnUpdateAdmin.TabIndex = 2;
            btnUpdateAdmin.Text = "✏️ Update";
            btnUpdateAdmin.UseVisualStyleBackColor = false;
            btnUpdateAdmin.Click += btnUpdateAdmin_Click;
            
            // 
            // btnAddAdmin
            // 
            btnAddAdmin.BackColor = Color.FromArgb(46, 125, 50);
            btnAddAdmin.FlatAppearance.BorderSize = 0;
            btnAddAdmin.FlatStyle = FlatStyle.Flat;
            btnAddAdmin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddAdmin.ForeColor = Color.White;
            btnAddAdmin.Location = new Point(115, 20);
            btnAddAdmin.Name = "btnAddAdmin";
            btnAddAdmin.Size = new Size(80, 40);
            btnAddAdmin.TabIndex = 1;
            btnAddAdmin.Text = "➕ Add";
            btnAddAdmin.UseVisualStyleBackColor = false;
            btnAddAdmin.Click += btnAddAdmin_Click;
            
            // 
            // add
            // 
            add.BackColor = Color.FromArgb(96, 125, 139);
            add.FlatAppearance.BorderSize = 0;
            add.FlatStyle = FlatStyle.Flat;
            add.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            add.ForeColor = Color.White;
            add.Location = new Point(25, 20);
            add.Name = "add";
            add.Size = new Size(80, 40);
            add.TabIndex = 0;
            add.Text = "🆕 New";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            
            // 
            // ManageAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 42, 86);
            ClientSize = new Size(1200, 700);
            Controls.Add(mainContainer);
            Controls.Add(panel1);
            Name = "ManageAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Management";
            Load += ManageAdmin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            mainContainer.ResumeLayout(false);
            adminViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)viewAdminsDt).EndInit();
            adminManagementPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            adminFormPanel.ResumeLayout(false);
            adminFormPanel.PerformLayout();
            actionButtonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel mainContainer;
        private Panel adminViewPanel;
        private DataGridView viewAdminsDt;
        private Panel adminManagementPanel;
        private Panel panel2;
        private Label label2;
        private Panel adminFormPanel;
        private TextBox tbPassword;
        private Label label6;
        private TextBox tbUsername;
        private Label label5;
        private TextBox tbEmail;
        private Label label4;
        private TextBox tbName;
        private Label label3;
        private Panel actionButtonsPanel;
        private Button btnDeleteAdmin;
        private Button btnUpdateAdmin;
        private Button btnAddAdmin;
        private Button add;
    }
}