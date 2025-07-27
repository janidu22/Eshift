namespace Eshift.Forms.Admin
{
    partial class ManageCustomer
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
            label4 = new Label();
            mainContainer = new Panel();
            contentPanel = new Panel();
            customersViewPanel = new Panel();
            TableLayoutPanel = new Panel();
            viewCustmerDt = new DataGridView();
            customerManagementPanel = new Panel();
            actionButtonsPanel = new Panel();
            btnDeleteCustomer = new Button();
            btnUpdateCustomer = new Button();
            btnAddAdmin = new Button();
            add = new Button();
            customerFormPanel = new Panel();
            tbPhone = new TextBox();
            lblPhone = new Label();
            tbEmail = new TextBox();
            lblEmail = new Label();
            tbUsername = new TextBox();
            lblUsername = new Label();
            tbAddress = new TextBox();
            lblAddress = new Label();
            tbPassword = new TextBox();
            lblPassword = new Label();
            tbName = new TextBox();
            lblName = new Label();
            panel2 = new Panel();
            label3 = new Label();
            
            panel1.SuspendLayout();
            mainContainer.SuspendLayout();
            contentPanel.SuspendLayout();
            customersViewPanel.SuspendLayout();
            TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewCustmerDt).BeginInit();
            customerManagementPanel.SuspendLayout();
            actionButtonsPanel.SuspendLayout();
            customerFormPanel.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 42, 86);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 60);
            panel1.TabIndex = 1;
            
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(520, 16);
            label4.Name = "label4";
            label4.Size = new Size(218, 32);
            label4.TabIndex = 2;
            label4.Text = "Manage Customers";
            
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(925, -23);
            label1.Name = "label1";
            label1.Size = new Size(181, 32);
            label1.TabIndex = 1;
            label1.Text = "Manage Admins";
            label1.Visible = false;
            
            // 
            // mainContainer
            // 
            mainContainer.BackColor = Color.FromArgb(236, 240, 241);
            mainContainer.Controls.Add(contentPanel);
            mainContainer.Dock = DockStyle.Fill;
            mainContainer.Location = new Point(0, 60);
            mainContainer.Name = "mainContainer";
            mainContainer.Padding = new Padding(20);
            mainContainer.Size = new Size(1200, 640);
            mainContainer.TabIndex = 2;
            
            // 
            // contentPanel
            // 
            contentPanel.Controls.Add(customersViewPanel);
            contentPanel.Controls.Add(customerManagementPanel);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(20, 20);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1160, 600);
            contentPanel.TabIndex = 0;
            
            // 
            // customersViewPanel
            // 
            customersViewPanel.BackColor = Color.White;
            customersViewPanel.Controls.Add(TableLayoutPanel);
            customersViewPanel.Dock = DockStyle.Fill;
            customersViewPanel.Location = new Point(0, 0);
            customersViewPanel.Name = "customersViewPanel";
            customersViewPanel.Padding = new Padding(10);
            customersViewPanel.Size = new Size(730, 600);
            customersViewPanel.TabIndex = 0;
            
            // 
            // TableLayoutPanel
            // 
            TableLayoutPanel.BackColor = Color.White;
            TableLayoutPanel.Controls.Add(viewCustmerDt);
            TableLayoutPanel.Dock = DockStyle.Fill;
            TableLayoutPanel.Location = new Point(10, 10);
            TableLayoutPanel.Name = "TableLayoutPanel";
            TableLayoutPanel.Size = new Size(710, 580);
            TableLayoutPanel.TabIndex = 0;
            
            // 
            // viewCustmerDt
            // 
            viewCustmerDt.AllowUserToAddRows = false;
            viewCustmerDt.AllowUserToDeleteRows = false;
            viewCustmerDt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewCustmerDt.BackgroundColor = Color.White;
            viewCustmerDt.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            viewCustmerDt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            viewCustmerDt.ColumnHeadersHeight = 40;
            viewCustmerDt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(46, 204, 113);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            viewCustmerDt.DefaultCellStyle = dataGridViewCellStyle2;
            viewCustmerDt.Dock = DockStyle.Fill;
            viewCustmerDt.EnableHeadersVisualStyles = false;
            viewCustmerDt.GridColor = Color.FromArgb(189, 195, 199);
            viewCustmerDt.Location = new Point(0, 0);
            viewCustmerDt.MultiSelect = false;
            viewCustmerDt.Name = "viewCustmerDt";
            viewCustmerDt.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(236, 240, 241);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(46, 204, 113);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            viewCustmerDt.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            viewCustmerDt.RowHeadersVisible = false;
            viewCustmerDt.RowTemplate.Height = 35;
            viewCustmerDt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            viewCustmerDt.Size = new Size(710, 580);
            viewCustmerDt.TabIndex = 0;
            viewCustmerDt.SelectionChanged += viewCustmerDt_SelectionChanged;
            
            // 
            // customerManagementPanel
            // 
            customerManagementPanel.BackColor = Color.White;
            customerManagementPanel.Controls.Add(actionButtonsPanel);
            customerManagementPanel.Controls.Add(customerFormPanel);
            customerManagementPanel.Controls.Add(panel2);
            customerManagementPanel.Dock = DockStyle.Right;
            customerManagementPanel.Location = new Point(730, 0);
            customerManagementPanel.Name = "customerManagementPanel";
            customerManagementPanel.Padding = new Padding(15);
            customerManagementPanel.Size = new Size(430, 600);
            customerManagementPanel.TabIndex = 1;
            
            // 
            // actionButtonsPanel
            // 
            actionButtonsPanel.Controls.Add(btnDeleteCustomer);
            actionButtonsPanel.Controls.Add(btnUpdateCustomer);
            actionButtonsPanel.Controls.Add(btnAddAdmin);
            actionButtonsPanel.Controls.Add(add);
            actionButtonsPanel.Dock = DockStyle.Bottom;
            actionButtonsPanel.Location = new Point(15, 540);
            actionButtonsPanel.Name = "actionButtonsPanel";
            actionButtonsPanel.Size = new Size(400, 45);
            actionButtonsPanel.TabIndex = 2;
            
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.BackColor = Color.FromArgb(231, 76, 60);
            btnDeleteCustomer.FlatAppearance.BorderSize = 0;
            btnDeleteCustomer.FlatStyle = FlatStyle.Flat;
            btnDeleteCustomer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteCustomer.ForeColor = Color.White;
            btnDeleteCustomer.Location = new Point(270, 5);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(120, 35);
            btnDeleteCustomer.TabIndex = 3;
            btnDeleteCustomer.Text = "🗑️ Delete";
            btnDeleteCustomer.UseVisualStyleBackColor = false;
            btnDeleteCustomer.Click += DeleteCustomer;
            
            // 
            // btnUpdateCustomer
            // 
            btnUpdateCustomer.BackColor = Color.FromArgb(46, 204, 113);
            btnUpdateCustomer.FlatAppearance.BorderSize = 0;
            btnUpdateCustomer.FlatStyle = FlatStyle.Flat;
            btnUpdateCustomer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdateCustomer.ForeColor = Color.White;
            btnUpdateCustomer.Location = new Point(140, 5);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(120, 35);
            btnUpdateCustomer.TabIndex = 2;
            btnUpdateCustomer.Text = "✏️ Update";
            btnUpdateCustomer.UseVisualStyleBackColor = false;
            btnUpdateCustomer.Click += btnUpdateCustomer_Click;
            
            // 
            // btnAddAdmin
            // 
            btnAddAdmin.BackColor = Color.FromArgb(52, 152, 219);
            btnAddAdmin.FlatAppearance.BorderSize = 0;
            btnAddAdmin.FlatStyle = FlatStyle.Flat;
            btnAddAdmin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddAdmin.ForeColor = Color.White;
            btnAddAdmin.Location = new Point(10, 5);
            btnAddAdmin.Name = "btnAddAdmin";
            btnAddAdmin.Size = new Size(120, 35);
            btnAddAdmin.TabIndex = 1;
            btnAddAdmin.Text = "➕ Add New";
            btnAddAdmin.UseVisualStyleBackColor = false;
            btnAddAdmin.Click += btnAddAdmin_Click;
            
            // 
            // add
            // 
            add.BackColor = Color.FromArgb(52, 152, 219);
            add.FlatAppearance.BorderSize = 0;
            add.FlatStyle = FlatStyle.Flat;
            add.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            add.ForeColor = Color.White;
            add.Location = new Point(1200, 5);
            add.Name = "add";
            add.Size = new Size(120, 35);
            add.TabIndex = 0;
            add.Text = "Create Account";
            add.UseVisualStyleBackColor = false;
            add.Visible = false;
            
            // 
            // customerFormPanel
            // 
            customerFormPanel.Controls.Add(tbPhone);
            customerFormPanel.Controls.Add(lblPhone);
            customerFormPanel.Controls.Add(tbEmail);
            customerFormPanel.Controls.Add(lblEmail);
            customerFormPanel.Controls.Add(tbUsername);
            customerFormPanel.Controls.Add(lblUsername);
            customerFormPanel.Controls.Add(tbAddress);
            customerFormPanel.Controls.Add(lblAddress);
            customerFormPanel.Controls.Add(tbPassword);
            customerFormPanel.Controls.Add(lblPassword);
            customerFormPanel.Controls.Add(tbName);
            customerFormPanel.Controls.Add(lblName);
            customerFormPanel.Dock = DockStyle.Top;
            customerFormPanel.Location = new Point(15, 60);
            customerFormPanel.Name = "customerFormPanel";
            customerFormPanel.Size = new Size(400, 480);
            customerFormPanel.TabIndex = 1;
            
            // 
            // tbPhone
            // 
            tbPhone.BackColor = Color.White;
            tbPhone.BorderStyle = BorderStyle.FixedSingle;
            tbPhone.Font = new Font("Segoe UI", 11F);
            tbPhone.ForeColor = Color.FromArgb(44, 62, 80);
            tbPhone.Location = new Point(120, 415);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(270, 27);
            tbPhone.TabIndex = 11;
            
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPhone.ForeColor = Color.FromArgb(44, 62, 80);
            lblPhone.Location = new Point(10, 417);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(53, 20);
            lblPhone.TabIndex = 10;
            lblPhone.Text = "Phone";
            
            // 
            // tbEmail
            // 
            tbEmail.BackColor = Color.White;
            tbEmail.BorderStyle = BorderStyle.FixedSingle;
            tbEmail.Font = new Font("Segoe UI", 11F);
            tbEmail.ForeColor = Color.FromArgb(44, 62, 80);
            tbEmail.Location = new Point(120, 345);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(270, 27);
            tbEmail.TabIndex = 9;
            
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(44, 62, 80);
            lblEmail.Location = new Point(10, 347);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email";
            
            // 
            // tbUsername
            // 
            tbUsername.BackColor = Color.White;
            tbUsername.BorderStyle = BorderStyle.FixedSingle;
            tbUsername.Font = new Font("Segoe UI", 11F);
            tbUsername.ForeColor = Color.FromArgb(44, 62, 80);
            tbUsername.Location = new Point(120, 275);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(270, 27);
            tbUsername.TabIndex = 7;
            
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(44, 62, 80);
            lblUsername.Location = new Point(10, 277);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(80, 20);
            lblUsername.TabIndex = 6;
            lblUsername.Text = "Username";
            
            // 
            // tbAddress
            // 
            tbAddress.BackColor = Color.White;
            tbAddress.BorderStyle = BorderStyle.FixedSingle;
            tbAddress.Font = new Font("Segoe UI", 11F);
            tbAddress.ForeColor = Color.FromArgb(44, 62, 80);
            tbAddress.Location = new Point(120, 185);
            tbAddress.Multiline = true;
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(270, 70);
            tbAddress.TabIndex = 5;
            
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAddress.ForeColor = Color.FromArgb(44, 62, 80);
            lblAddress.Location = new Point(10, 187);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(66, 20);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address";
            
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.White;
            tbPassword.BorderStyle = BorderStyle.FixedSingle;
            tbPassword.Font = new Font("Segoe UI", 11F);
            tbPassword.ForeColor = Color.FromArgb(44, 62, 80);
            tbPassword.Location = new Point(120, 115);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(270, 27);
            tbPassword.TabIndex = 3;
            
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(44, 62, 80);
            lblPassword.Location = new Point(10, 117);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(76, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            
            // 
            // tbName
            // 
            tbName.BackColor = Color.White;
            tbName.BorderStyle = BorderStyle.FixedSingle;
            tbName.Font = new Font("Segoe UI", 11F);
            tbName.ForeColor = Color.FromArgb(44, 62, 80);
            tbName.Location = new Point(120, 45);
            tbName.Name = "tbName";
            tbName.Size = new Size(270, 27);
            tbName.TabIndex = 1;
            
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(44, 62, 80);
            lblName.Location = new Point(10, 47);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(25, 42, 86);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(15, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 45);
            panel2.TabIndex = 0;
            
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(120, 12);
            label3.Name = "label3";
            label3.Size = new Size(194, 25);
            label3.TabIndex = 0;
            label3.Text = "Customer Management";
            
            // 
            // ManageCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(1200, 700);
            Controls.Add(mainContainer);
            Controls.Add(panel1);
            Name = "ManageCustomer";
            Text = "Manage Customers - eShift Admin Portal";
            Load += ManageCustomer_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            mainContainer.ResumeLayout(false);
            contentPanel.ResumeLayout(false);
            customersViewPanel.ResumeLayout(false);
            TableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)viewCustmerDt).EndInit();
            customerManagementPanel.ResumeLayout(false);
            actionButtonsPanel.ResumeLayout(false);
            customerFormPanel.ResumeLayout(false);
            customerFormPanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label4;
        private Panel mainContainer;
        private Panel contentPanel;
        private Panel customersViewPanel;
        private Panel TableLayoutPanel;
        private DataGridView viewCustmerDt;
        private Panel customerManagementPanel;
        private Panel panel2;
        private Label label3;
        private Panel customerFormPanel;
        private Label lblName;
        private TextBox tbName;
        private Label lblPassword;
        private TextBox tbPassword;
        private Label lblAddress;
        private TextBox tbAddress;
        private Label lblUsername;
        private TextBox tbUsername;
        private Label lblEmail;
        private TextBox tbEmail;
        private Label lblPhone;
        private TextBox tbPhone;
        private Panel actionButtonsPanel;
        private Button add;
        private Button btnAddAdmin;
        private Button btnUpdateCustomer;
        private Button btnDeleteCustomer;
    }
}