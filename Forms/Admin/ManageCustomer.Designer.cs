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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label4 = new Label();
            label1 = new Label();
            TableLayoutPanel = new Panel();
            viewCustmerDt = new DataGridView();
            btnAddAdmin = new Button();
            label3 = new Label();
            add = new Button();
            btnDeleteCustomer = new Button();
            btnUpdateCustomer = new Button();
            tbPhone = new TextBox();
            tbEmail = new TextBox();
            tbUsername = new TextBox();
            tbAddress = new TextBox();
            tbPassword = new TextBox();
            tbName = new TextBox();
            panel1.SuspendLayout();
            TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewCustmerDt).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.Navy;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1089, 36);
            panel1.TabIndex = 16;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(481, 9);
            label4.Name = "label4";
            label4.Size = new Size(153, 19);
            label4.TabIndex = 2;
            label4.Text = "Manage Customers";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(925, -23);
            label1.Name = "label1";
            label1.Size = new Size(126, 19);
            label1.TabIndex = 1;
            label1.Text = "Manage Admins";
            // 
            // TableLayoutPanel
            // 
            TableLayoutPanel.Anchor = AnchorStyles.None;
            TableLayoutPanel.BackColor = SystemColors.Control;
            TableLayoutPanel.Controls.Add(viewCustmerDt);
            TableLayoutPanel.Location = new Point(12, 42);
            TableLayoutPanel.Name = "TableLayoutPanel";
            TableLayoutPanel.Size = new Size(1065, 311);
            TableLayoutPanel.TabIndex = 23;
            // 
            // viewCustmerDt
            // 
            viewCustmerDt.AllowUserToAddRows = false;
            viewCustmerDt.AllowUserToDeleteRows = false;
            viewCustmerDt.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            viewCustmerDt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            viewCustmerDt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            viewCustmerDt.DefaultCellStyle = dataGridViewCellStyle4;
            viewCustmerDt.Dock = DockStyle.Fill;
            viewCustmerDt.GridColor = Color.Black;
            viewCustmerDt.Location = new Point(0, 0);
            viewCustmerDt.Name = "viewCustmerDt";
            viewCustmerDt.ReadOnly = true;
            viewCustmerDt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            viewCustmerDt.Size = new Size(1065, 311);
            viewCustmerDt.TabIndex = 15;
            // 
            // btnAddAdmin
            // 
            btnAddAdmin.Anchor = AnchorStyles.None;
            btnAddAdmin.BackColor = Color.FromArgb(0, 64, 0);
            btnAddAdmin.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddAdmin.ForeColor = Color.White;
            btnAddAdmin.Location = new Point(25, 654);
            btnAddAdmin.Name = "btnAddAdmin";
            btnAddAdmin.Size = new Size(273, 36);
            btnAddAdmin.TabIndex = 22;
            btnAddAdmin.Text = "Create Account";
            btnAddAdmin.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("JetBrains Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 376);
            label3.Name = "label3";
            label3.Size = new Size(220, 27);
            label3.TabIndex = 21;
            label3.Text = "Customer Details";
            // 
            // add
            // 
            add.Anchor = AnchorStyles.None;
            add.BackColor = Color.Navy;
            add.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add.ForeColor = Color.White;
            add.Location = new Point(814, 592);
            add.Name = "add";
            add.Size = new Size(173, 41);
            add.TabIndex = 26;
            add.Text = "Add New Customer";
            add.UseVisualStyleBackColor = false;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Anchor = AnchorStyles.None;
            btnDeleteCustomer.BackColor = Color.Maroon;
            btnDeleteCustomer.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteCustomer.ForeColor = Color.White;
            btnDeleteCustomer.Location = new Point(814, 535);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(173, 44);
            btnDeleteCustomer.TabIndex = 25;
            btnDeleteCustomer.Text = "Delete Customer";
            btnDeleteCustomer.UseVisualStyleBackColor = false;
            // 
            // btnUpdateCustomer
            // 
            btnUpdateCustomer.Anchor = AnchorStyles.None;
            btnUpdateCustomer.BackColor = Color.MediumSeaGreen;
            btnUpdateCustomer.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateCustomer.ForeColor = Color.White;
            btnUpdateCustomer.Location = new Point(814, 639);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(173, 41);
            btnUpdateCustomer.TabIndex = 27;
            btnUpdateCustomer.Text = "Update Customer";
            btnUpdateCustomer.UseVisualStyleBackColor = false;
            // 
            // tbPhone
            // 
            tbPhone.Font = new Font("Segoe UI", 14.25F);
            tbPhone.Location = new Point(25, 579);
            tbPhone.Name = "tbPhone";
            tbPhone.PlaceholderText = "Phone";
            tbPhone.Size = new Size(273, 33);
            tbPhone.TabIndex = 33;
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 14.25F);
            tbEmail.Location = new Point(25, 462);
            tbEmail.Name = "tbEmail";
            tbEmail.PlaceholderText = "Email";
            tbEmail.Size = new Size(273, 33);
            tbEmail.TabIndex = 32;
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Segoe UI", 14.25F);
            tbUsername.Location = new Point(25, 501);
            tbUsername.Name = "tbUsername";
            tbUsername.PlaceholderText = "Username";
            tbUsername.Size = new Size(273, 33);
            tbUsername.TabIndex = 31;
            // 
            // tbAddress
            // 
            tbAddress.Font = new Font("Segoe UI", 14.25F);
            tbAddress.Location = new Point(25, 615);
            tbAddress.Name = "tbAddress";
            tbAddress.PlaceholderText = "Address";
            tbAddress.Size = new Size(273, 33);
            tbAddress.TabIndex = 30;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 14.25F);
            tbPassword.Location = new Point(25, 540);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.PlaceholderText = "Password";
            tbPassword.Size = new Size(273, 33);
            tbPassword.TabIndex = 29;
            // 
            // tbName
            // 
            tbName.Font = new Font("Segoe UI", 14.25F);
            tbName.Location = new Point(25, 423);
            tbName.Name = "tbName";
            tbName.PlaceholderText = "Name";
            tbName.Size = new Size(273, 33);
            tbName.TabIndex = 28;
            // 
            // ManageCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 719);
            Controls.Add(tbPhone);
            Controls.Add(tbEmail);
            Controls.Add(tbUsername);
            Controls.Add(tbAddress);
            Controls.Add(tbPassword);
            Controls.Add(tbName);
            Controls.Add(panel1);
            Controls.Add(TableLayoutPanel);
            Controls.Add(btnAddAdmin);
            Controls.Add(label3);
            Controls.Add(add);
            Controls.Add(btnDeleteCustomer);
            Controls.Add(btnUpdateCustomer);
            Name = "ManageCustomer";
            Text = "ManageCustomer";
            Load += ManageCustomer_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            TableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)viewCustmerDt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel TableLayoutPanel;
        private DataGridView viewCustmerDt;
        private Button btnAddAdmin;
        private Label label3;
        private Button add;
        private Button btnDeleteCustomer;
        private Button btnUpdateCustomer;
        private Label label4;
        private TextBox tbPhone;
        private TextBox tbEmail;
        private TextBox tbUsername;
        private TextBox tbAddress;
        private TextBox tbPassword;
        private TextBox tbName;
    }
}