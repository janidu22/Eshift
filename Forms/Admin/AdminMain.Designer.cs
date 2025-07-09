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
            NewJobs = new Button();
            ProfileMange = new Button();
            ManageAdmins = new Button();
            lblAddress = new Label();
            lblName = new Label();
            panel2 = new Panel();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            ManageProducts = new Button();
            ViewInvoice = new Button();
            TrackStatus = new Button();
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
            ViewJobs.Location = new Point(1, 20);
            ViewJobs.Name = "ViewJobs";
            ViewJobs.Size = new Size(256, 60);
            ViewJobs.TabIndex = 0;
            ViewJobs.Text = "View Jobs";
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
            AdminManagement.Location = new Point(2, 215);
            AdminManagement.Name = "AdminManagement";
            AdminManagement.Size = new Size(255, 60);
            AdminManagement.TabIndex = 5;
            AdminManagement.Text = "Manage Admins";
            AdminManagement.TextAlign = ContentAlignment.MiddleLeft;
            AdminManagement.UseVisualStyleBackColor = false;
            AdminManagement.Click += AdminManagement_Click;
            // 
            // NewJobs
            // 
            NewJobs.BackColor = Color.FromArgb(64, 64, 64);
            NewJobs.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            NewJobs.ForeColor = Color.White;
            NewJobs.Location = new Point(1, 83);
            NewJobs.Name = "NewJobs";
            NewJobs.Size = new Size(256, 60);
            NewJobs.TabIndex = 4;
            NewJobs.Text = "Manage Jobs";
            NewJobs.TextAlign = ContentAlignment.MiddleLeft;
            NewJobs.UseVisualStyleBackColor = false;
            NewJobs.Click += NewJobs_Click;
            // 
            // ProfileMange
            // 
            ProfileMange.BackColor = Color.FromArgb(64, 64, 64);
            ProfileMange.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            ProfileMange.ForeColor = Color.White;
            ProfileMange.Location = new Point(2, 413);
            ProfileMange.Name = "ProfileMange";
            ProfileMange.Size = new Size(257, 60);
            ProfileMange.TabIndex = 3;
            ProfileMange.Text = "View and Manage Payments";
            ProfileMange.TextAlign = ContentAlignment.MiddleLeft;
            ProfileMange.UseVisualStyleBackColor = false;
            // 
            // ManageAdmins
            // 
            ManageAdmins.BackColor = Color.FromArgb(64, 64, 64);
            ManageAdmins.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            ManageAdmins.ForeColor = Color.White;
            ManageAdmins.Location = new Point(2, 545);
            ManageAdmins.Name = "ManageAdmins";
            ManageAdmins.Size = new Size(255, 60);
            ManageAdmins.TabIndex = 2;
            ManageAdmins.Text = "View and Manage Invoices";
            ManageAdmins.TextAlign = ContentAlignment.MiddleLeft;
            ManageAdmins.UseVisualStyleBackColor = false;
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
            panel2.Controls.Add(button11);
            panel2.Controls.Add(button10);
            panel2.Controls.Add(button9);
            panel2.Controls.Add(ManageProducts);
            panel2.Controls.Add(ViewInvoice);
            panel2.Controls.Add(AdminManagement);
            panel2.Controls.Add(NewJobs);
            panel2.Controls.Add(ProfileMange);
            panel2.Controls.Add(ManageAdmins);
            panel2.Controls.Add(TrackStatus);
            panel2.Controls.Add(ViewJobs);
            panel2.Location = new Point(3, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(261, 750);
            panel2.TabIndex = 0;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(64, 64, 64);
            button11.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            button11.ForeColor = Color.White;
            button11.Location = new Point(2, 479);
            button11.Name = "button11";
            button11.Size = new Size(255, 60);
            button11.TabIndex = 10;
            button11.Text = "View Reports";
            button11.TextAlign = ContentAlignment.MiddleLeft;
            button11.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(64, 64, 64);
            button10.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            button10.ForeColor = Color.White;
            button10.Location = new Point(2, 677);
            button10.Name = "button10";
            button10.Size = new Size(255, 60);
            button10.TabIndex = 9;
            button10.Text = "Logout";
            button10.TextAlign = ContentAlignment.MiddleLeft;
            button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(64, 64, 64);
            button9.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            button9.ForeColor = Color.White;
            button9.Location = new Point(2, 347);
            button9.Name = "button9";
            button9.Size = new Size(255, 60);
            button9.TabIndex = 8;
            button9.Text = "Manage Transport Unit";
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button9.UseVisualStyleBackColor = false;
            // 
            // ManageProducts
            // 
            ManageProducts.BackColor = Color.FromArgb(64, 64, 64);
            ManageProducts.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            ManageProducts.ForeColor = Color.White;
            ManageProducts.Location = new Point(2, 611);
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
            ViewInvoice.Location = new Point(1, 281);
            ViewInvoice.Name = "ViewInvoice";
            ViewInvoice.Size = new Size(256, 60);
            ViewInvoice.TabIndex = 6;
            ViewInvoice.Text = "Manage Products";
            ViewInvoice.TextAlign = ContentAlignment.MiddleLeft;
            ViewInvoice.UseVisualStyleBackColor = false;
            // 
            // TrackStatus
            // 
            TrackStatus.BackColor = Color.FromArgb(64, 64, 64);
            TrackStatus.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            TrackStatus.ForeColor = Color.White;
            TrackStatus.Location = new Point(1, 149);
            TrackStatus.Name = "TrackStatus";
            TrackStatus.Size = new Size(256, 60);
            TrackStatus.TabIndex = 1;
            TrackStatus.Text = "Manage Customers";
            TrackStatus.TextAlign = ContentAlignment.MiddleLeft;
            TrackStatus.UseVisualStyleBackColor = false;
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
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button ViewJobs;
        private Label lblEmail;
        private Label lblPhone;
        private Button AdminManagement;
        private Button NewJobs;
        private Button ProfileMange;
        private Button ManageAdmins;
        private Label lblAddress;
        private Label lblName;
        private Panel panel2;
        private Button button10;
        private Button button9;
        private Button ManageProducts;
        private Button ViewInvoice;
        private Button TrackStatus;
        private Panel panel1;
        private Button button11;
        private Panel PanelMain;
    }
}