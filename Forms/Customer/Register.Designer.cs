namespace Eshift.Forms.Customer
{
    partial class Register
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
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            btnRegister = new Button();
            tbPassword = new TextBox();
            tbName = new TextBox();
            label1 = new Label();
            tbAddress = new TextBox();
            tbUsername = new TextBox();
            tbEmail = new TextBox();
            tbPhone = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(323, 372);
            label3.Name = "label3";
            label3.Size = new Size(142, 15);
            label3.TabIndex = 12;
            label3.Text = "Already have an account?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(464, 372);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(37, 15);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(363, 303);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(91, 35);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "Register ";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 12F);
            tbPassword.Location = new Point(323, 185);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.PlaceholderText = "Password";
            tbPassword.Size = new Size(178, 29);
            tbPassword.TabIndex = 9;
            // 
            // tbName
            // 
            tbName.Font = new Font("Segoe UI", 12F);
            tbName.Location = new Point(323, 80);
            tbName.Name = "tbName";
            tbName.PlaceholderText = "Name";
            tbName.Size = new Size(178, 29);
            tbName.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(363, 18);
            label1.Name = "label1";
            label1.Size = new Size(112, 37);
            label1.TabIndex = 7;
            label1.Text = "Register";
            label1.Click += label1_Click;
            // 
            // tbAddress
            // 
            tbAddress.Font = new Font("Segoe UI", 12F);
            tbAddress.Location = new Point(323, 220);
            tbAddress.Name = "tbAddress";
            tbAddress.PlaceholderText = "Address";
            tbAddress.Size = new Size(178, 29);
            tbAddress.TabIndex = 13;
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Segoe UI", 12F);
            tbUsername.Location = new Point(323, 150);
            tbUsername.Name = "tbUsername";
            tbUsername.PlaceholderText = "Username";
            tbUsername.Size = new Size(178, 29);
            tbUsername.TabIndex = 14;
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 12F);
            tbEmail.Location = new Point(323, 115);
            tbEmail.Name = "tbEmail";
            tbEmail.PlaceholderText = "Email";
            tbEmail.Size = new Size(178, 29);
            tbEmail.TabIndex = 15;
            // 
            // tbPhone
            // 
            tbPhone.Font = new Font("Segoe UI", 12F);
            tbPhone.Location = new Point(323, 255);
            tbPhone.Name = "tbPhone";
            tbPhone.PlaceholderText = "Phone";
            tbPhone.Size = new Size(178, 29);
            tbPhone.TabIndex = 16;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbPhone);
            Controls.Add(tbEmail);
            Controls.Add(tbUsername);
            Controls.Add(tbAddress);
            Controls.Add(label3);
            Controls.Add(linkLabel1);
            Controls.Add(btnRegister);
            Controls.Add(tbPassword);
            Controls.Add(tbName);
            Controls.Add(label1);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fffff";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private LinkLabel linkLabel1;
        private Button btnRegister;
        private TextBox tbPassword;
        private TextBox tbName;
        private Label label1;
        private TextBox tbAddress;
        private TextBox tbUsername;
        private TextBox tbEmail;
        private TextBox tbPhone;
    }
}