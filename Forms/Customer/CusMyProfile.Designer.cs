namespace Eshift.Forms.Customer
{
    partial class CusMyProfile
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
            panel1 = new Panel();
            label1 = new Label();
            mainPanel = new Panel();
            btnClear = new Button();
            btnUpdate = new Button();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            lblConfirmPassword = new Label();
            lblPassword = new Label();
            lblPhone = new Label();
            lblAddress = new Label();
            lblUsername = new Label();
            lblEmail = new Label();
            lblName = new Label();
            panel1.SuspendLayout();
            mainPanel.SuspendLayout();
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
            panel1.Size = new Size(1268, 60);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(565, 16);
            label1.Name = "label1";
            label1.Size = new Size(133, 32);
            label1.TabIndex = 1;
            label1.Text = "My Profile";
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.None;
            mainPanel.BackColor = Color.FromArgb(236, 240, 241);
            mainPanel.Controls.Add(btnClear);
            mainPanel.Controls.Add(btnUpdate);
            mainPanel.Controls.Add(txtConfirmPassword);
            mainPanel.Controls.Add(txtPassword);
            mainPanel.Controls.Add(txtPhone);
            mainPanel.Controls.Add(txtAddress);
            mainPanel.Controls.Add(txtUsername);
            mainPanel.Controls.Add(txtEmail);
            mainPanel.Controls.Add(txtName);
            mainPanel.Controls.Add(lblConfirmPassword);
            mainPanel.Controls.Add(lblPassword);
            mainPanel.Controls.Add(lblPhone);
            mainPanel.Controls.Add(lblAddress);
            mainPanel.Controls.Add(lblUsername);
            mainPanel.Controls.Add(lblEmail);
            mainPanel.Controls.Add(lblName);
            mainPanel.Location = new Point(172, 117);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(40);
            mainPanel.Size = new Size(942, 600);
            mainPanel.TabIndex = 2;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(230, 126, 34);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(690, 520);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(140, 45);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear Fields";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(46, 204, 113);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(520, 520);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(140, 45);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update Profile";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.White;
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Font = new Font("Segoe UI", 12F);
            txtConfirmPassword.ForeColor = Color.FromArgb(44, 62, 80);
            txtConfirmPassword.Location = new Point(520, 445);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '•';
            txtConfirmPassword.Size = new Size(350, 29);
            txtConfirmPassword.TabIndex = 13;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.ForeColor = Color.FromArgb(44, 62, 80);
            txtPassword.Location = new Point(520, 385);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(350, 29);
            txtPassword.TabIndex = 12;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.White;
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 12F);
            txtPhone.ForeColor = Color.FromArgb(44, 62, 80);
            txtPhone.Location = new Point(520, 325);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(350, 29);
            txtPhone.TabIndex = 11;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.White;
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Segoe UI", 12F);
            txtAddress.ForeColor = Color.FromArgb(44, 62, 80);
            txtAddress.Location = new Point(520, 265);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(350, 45);
            txtAddress.TabIndex = 10;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.ForeColor = Color.FromArgb(44, 62, 80);
            txtUsername.Location = new Point(520, 205);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(350, 29);
            txtUsername.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.ForeColor = Color.FromArgb(44, 62, 80);
            txtEmail.Location = new Point(520, 145);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(350, 29);
            txtEmail.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.ForeColor = Color.FromArgb(44, 62, 80);
            txtName.Location = new Point(520, 85);
            txtName.Name = "txtName";
            txtName.Size = new Size(350, 29);
            txtName.TabIndex = 7;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblConfirmPassword.ForeColor = Color.FromArgb(44, 62, 80);
            lblConfirmPassword.Location = new Point(150, 450);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(231, 21);
            lblConfirmPassword.TabIndex = 6;
            lblConfirmPassword.Text = "Confirm Password (Optional)";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(44, 62, 80);
            lblPassword.Location = new Point(150, 390);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(165, 21);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password (Optional)";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPhone.ForeColor = Color.FromArgb(44, 62, 80);
            lblPhone.Location = new Point(150, 330);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(126, 21);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Phone Number";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAddress.ForeColor = Color.FromArgb(44, 62, 80);
            lblAddress.Location = new Point(150, 270);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(70, 21);
            lblAddress.TabIndex = 3;
            lblAddress.Text = "Address";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(44, 62, 80);
            lblUsername.Location = new Point(150, 210);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(87, 21);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(44, 62, 80);
            lblEmail.Location = new Point(150, 150);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(117, 21);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email Address";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(44, 62, 80);
            lblName.Location = new Point(150, 90);
            lblName.Name = "lblName";
            lblName.Size = new Size(88, 21);
            lblName.TabIndex = 0;
            lblName.Text = "Full Name";
            // 
            // CusMyProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(1268, 729);
            Controls.Add(mainPanel);
            Controls.Add(panel1);
            Name = "CusMyProfile";
            Text = "My Profile - eShift Customer Portal";
            Load += CusMyProfile_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel mainPanel;
        private Label lblName;
        private Label lblEmail;
        private Label lblUsername;
        private Label lblAddress;
        private Label lblPhone;
        private Label lblPassword;
        private Label lblConfirmPassword;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtUsername;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Button btnUpdate;
        private Button btnClear;
    }
}