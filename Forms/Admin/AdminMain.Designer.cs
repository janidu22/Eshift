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
            ViewJobs = new Button();
            lblEmail = new Label();
            lblPhone = new Label();
            AdminManagement = new Button();
            ManageLoads = new Button();
            lblAddress = new Label();
            lblName = new Label();
            panel2 = new Panel();
            lblAdminEmail = new Label();
            lblAdminUsername = new Label();
            lblAdminName = new Label();
            label1 = new Label();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            ManageProducts = new Button();
            ViewInvoice = new Button();
            manageCustomers = new Button();
            panel1 = new Panel();
            PanelMain = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ViewJobs
            // 
            ViewJobs.BackColor = Color.FromArgb(64, 64, 64);
            ViewJobs.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            ViewJobs.ForeColor = Color.White;
            ViewJobs.Location = new Point(1, 163);
            ViewJobs.Name = "ViewJobs";
            ViewJobs.Size = new Size(256, 60);
            ViewJobs.TabIndex = 0;
            ViewJobs.Text = "Manage & View Jobs";
            ViewJobs.TextAlign = ContentAlignment.MiddleLeft;
            ViewJobs.UseVisualStyleBackColor = false;
            ViewJobs.Click += ViewJobs_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(19, 89);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(0, 25);
            lblEmail.TabIndex = 4;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.ForeColor = Color.Black;
            lblPhone.Location = new Point(19, 114);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(0, 25);
            lblPhone.TabIndex = 3;
            // 
            // AdminManagement
            // 
            AdminManagement.BackColor = Color.FromArgb(64, 64, 64);
            AdminManagement.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            AdminManagement.ForeColor = Color.White;
            AdminManagement.Location = new Point(1, 229);
            AdminManagement.Name = "AdminManagement";
            AdminManagement.Size = new Size(255, 60);
            AdminManagement.TabIndex = 5;
            AdminManagement.Text = "Manage Admins";
            AdminManagement.TextAlign = ContentAlignment.MiddleLeft;
            AdminManagement.UseVisualStyleBackColor = false;
            AdminManagement.Click += AdminManagement_Click;
            // 
            // ManageLoads
            // 
            ManageLoads.BackColor = Color.FromArgb(64, 64, 64);
            ManageLoads.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            ManageLoads.ForeColor = Color.White;
            ManageLoads.Location = new Point(0, 490);
            ManageLoads.Name = "ManageLoads";
            ManageLoads.Size = new Size(255, 60);
            ManageLoads.TabIndex = 2;
            ManageLoads.Text = "Manage Loads";
            ManageLoads.TextAlign = ContentAlignment.MiddleLeft;
            ManageLoads.UseVisualStyleBackColor = false;
            ManageLoads.Click += ManageLoads_Click;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddress.ForeColor = Color.Black;
            lblAddress.Location = new Point(19, 139);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(0, 25);
            lblAddress.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(19, 64);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 25);
            lblName.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(ManageLoads);
            panel2.Controls.Add(lblAdminEmail);
            panel2.Controls.Add(lblAdminUsername);
            panel2.Controls.Add(lblAdminName);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button11);
            panel2.Controls.Add(button10);
            panel2.Controls.Add(button9);
            panel2.Controls.Add(ManageProducts);
            panel2.Controls.Add(ViewInvoice);
            panel2.Controls.Add(AdminManagement);
            panel2.Controls.Add(manageCustomers);
            panel2.Controls.Add(ViewJobs);
            panel2.Location = new Point(3, 11);
            panel2.Name = "panel2";
            panel2.Size = new Size(261, 760);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // lblAdminEmail
            // 
            lblAdminEmail.AutoSize = true;
            lblAdminEmail.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Bold);
            lblAdminEmail.ForeColor = Color.Black;
            lblAdminEmail.Location = new Point(22, 128);
            lblAdminEmail.Name = "lblAdminEmail";
            lblAdminEmail.Size = new Size(210, 25);
            lblAdminEmail.TabIndex = 14;
            lblAdminEmail.Text = "Welcome Back Admin";
            // 
            // lblAdminUsername
            // 
            lblAdminUsername.AutoSize = true;
            lblAdminUsername.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Bold);
            lblAdminUsername.ForeColor = Color.Black;
            lblAdminUsername.Location = new Point(22, 103);
            lblAdminUsername.Name = "lblAdminUsername";
            lblAdminUsername.Size = new Size(210, 25);
            lblAdminUsername.TabIndex = 13;
            lblAdminUsername.Text = "Welcome Back Admin";
            // 
            // lblAdminName
            // 
            lblAdminName.AutoSize = true;
            lblAdminName.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Bold);
            lblAdminName.ForeColor = Color.Navy;
            lblAdminName.Location = new Point(22, 53);
            lblAdminName.Name = "lblAdminName";
            lblAdminName.Size = new Size(210, 25);
            lblAdminName.TabIndex = 12;
            lblAdminName.Text = "Welcome Back Admin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(22, 28);
            label1.Name = "label1";
            label1.Size = new Size(210, 25);
            label1.TabIndex = 11;
            label1.Text = "Welcome Back Admin";
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(64, 64, 64);
            button11.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            button11.ForeColor = Color.White;
            button11.Location = new Point(1, 556);
            button11.Name = "button11";
            button11.Size = new Size(255, 60);
            button11.TabIndex = 10;
            button11.Text = "View Reports";
            button11.TextAlign = ContentAlignment.MiddleLeft;
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(64, 64, 64);
            button10.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            button10.ForeColor = Color.White;
            button10.Location = new Point(0, 688);
            button10.Name = "button10";
            button10.Size = new Size(255, 60);
            button10.TabIndex = 9;
            button10.Text = "Logout";
            button10.TextAlign = ContentAlignment.MiddleLeft;
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(64, 64, 64);
            button9.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            button9.ForeColor = Color.White;
            button9.Location = new Point(1, 424);
            button9.Name = "button9";
            button9.Size = new Size(255, 60);
            button9.TabIndex = 8;
            button9.Text = "Manage Transport Unit";
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // ManageProducts
            // 
            ManageProducts.BackColor = Color.FromArgb(64, 64, 64);
            ManageProducts.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            ManageProducts.ForeColor = Color.White;
            ManageProducts.Location = new Point(0, 622);
            ManageProducts.Name = "ManageProducts";
            ManageProducts.Size = new Size(255, 60);
            ManageProducts.TabIndex = 7;
            ManageProducts.Text = "Profile Management";
            ManageProducts.TextAlign = ContentAlignment.MiddleLeft;
            ManageProducts.UseVisualStyleBackColor = false;
            // 
            // ViewInvoice
            // 
            ViewInvoice.BackColor = Color.FromArgb(64, 64, 64);
            ViewInvoice.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            ViewInvoice.ForeColor = Color.White;
            ViewInvoice.Location = new Point(0, 358);
            ViewInvoice.Name = "ViewInvoice";
            ViewInvoice.Size = new Size(256, 60);
            ViewInvoice.TabIndex = 6;
            ViewInvoice.Text = "Manage Products";
            ViewInvoice.TextAlign = ContentAlignment.MiddleLeft;
            ViewInvoice.UseVisualStyleBackColor = false;
            ViewInvoice.Click += ViewInvoice_Click;
            // 
            // manageCustomers
            // 
            manageCustomers.BackColor = Color.FromArgb(64, 64, 64);
            manageCustomers.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            manageCustomers.ForeColor = Color.White;
            manageCustomers.Location = new Point(1, 292);
            manageCustomers.Name = "manageCustomers";
            manageCustomers.Size = new Size(256, 60);
            manageCustomers.TabIndex = 1;
            manageCustomers.Text = "Manage Customers";
            manageCustomers.TextAlign = ContentAlignment.MiddleLeft;
            manageCustomers.UseVisualStyleBackColor = false;
            manageCustomers.Click += manageCustomers_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(lblPhone);
            panel1.Controls.Add(lblAddress);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(panel2);
            panel1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, -9);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 785);
            panel1.TabIndex = 1;
            // 
            // PanelMain
            // 
            PanelMain.Location = new Point(266, 2);
            PanelMain.Name = "PanelMain";
            PanelMain.Size = new Size(1111, 760);
            PanelMain.TabIndex = 2;
            PanelMain.Paint += PanelMain_Paint;
            // 
            // AdminMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1381, 767);
            Controls.Add(PanelMain);
            Controls.Add(panel1);
            Name = "AdminMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminMain";
            Load += AdminMain_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button ViewJobs;
        private Label lblEmail;
        private Label lblPhone;
        private Button AdminManagement;
        private Button ManageLoads;
        private Label lblAddress;
        private Label lblName;
        private Panel panel2;
        private Button button10;
        private Button button9;
        private Button ManageProducts;
        private Button ViewInvoice;
        private Button manageCustomers;
        private Panel panel1;
        private Button button11;
        private Panel PanelMain;
        private Label label1;
        private Label lblAdminName;
        private Label lblAdminEmail;
        private Label lblAdminUsername;
    }
}