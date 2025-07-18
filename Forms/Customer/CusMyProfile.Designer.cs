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
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.Navy;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1099, 36);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(486, 9);
            label1.Name = "label1";
            label1.Size = new Size(108, 19);
            label1.TabIndex = 1;
            label1.Text = "My Profiles";
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.White;
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
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 36);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(20);
            mainPanel.Size = new Size(1099, 693);
            mainPanel.TabIndex = 2;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Orange;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("JetBrains Mono", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(715, 515);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 40);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.MidnightBlue;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("JetBrains Mono", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(550, 515);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 40);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("JetBrains Mono", 14.25F);
            txtConfirmPassword.Location = new Point(535, 445);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '•';
            txtConfirmPassword.Size = new Size(300, 33);
            txtConfirmPassword.TabIndex = 13;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("JetBrains Mono", 14.25F);
            txtPassword.Location = new Point(535, 385);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(300, 33);
            txtPassword.TabIndex = 12;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("JetBrains Mono", 14.25F);
            txtPhone.Location = new Point(535, 325);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(300, 33);
            txtPhone.TabIndex = 11;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("JetBrains Mono", 14.25F);
            txtAddress.Location = new Point(535, 265);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(300, 40);
            txtAddress.TabIndex = 10;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("JetBrains Mono", 14.25F);
            txtUsername.Location = new Point(535, 205);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 33);
            txtUsername.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("JetBrains Mono", 14.25F);
            txtEmail.Location = new Point(535, 145);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 33);
            txtEmail.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Font = new Font("JetBrains Mono", 14.25F);
            txtName.Location = new Point(535, 85);
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 33);
            txtName.TabIndex = 7;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Bold);
            lblConfirmPassword.ForeColor = Color.MidnightBlue;
            lblConfirmPassword.Location = new Point(150, 453);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(320, 25);
            lblConfirmPassword.TabIndex = 6;
            lblConfirmPassword.Text = "Confirm Password (Optional):";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Bold);
            lblPassword.ForeColor = Color.MidnightBlue;
            lblPassword.Location = new Point(150, 393);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(232, 25);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password (Optional):";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Bold);
            lblPhone.ForeColor = Color.MidnightBlue;
            lblPhone.Location = new Point(150, 333);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(78, 25);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Phone:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Bold);
            lblAddress.ForeColor = Color.MidnightBlue;
            lblAddress.Location = new Point(150, 273);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(100, 25);
            lblAddress.TabIndex = 3;
            lblAddress.Text = "Address:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Bold);
            lblUsername.ForeColor = Color.MidnightBlue;
            lblUsername.Location = new Point(150, 213);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(111, 25);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Bold);
            lblEmail.ForeColor = Color.MidnightBlue;
            lblEmail.Location = new Point(150, 153);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(78, 25);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Bold);
            lblName.ForeColor = Color.MidnightBlue;
            lblName.Location = new Point(150, 93);
            lblName.Name = "lblName";
            lblName.Size = new Size(67, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // CusMyProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1099, 729);
            Controls.Add(mainPanel);
            Controls.Add(panel1);
            Name = "CusMyProfile";
            Text = "CusMyProfile";
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