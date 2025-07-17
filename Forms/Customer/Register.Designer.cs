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
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 604);
            label3.Name = "label3";
            label3.Size = new Size(142, 15);
            label3.TabIndex = 12;
            label3.Text = "Already have an account?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(267, 604);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(37, 15);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Peru;
            btnRegister.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(78, 534);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(307, 35);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "Register ";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(78, 318);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(307, 33);
            tbPassword.TabIndex = 9;
            tbPassword.TextChanged += tbPassword_TextChanged;
            // 
            // tbName
            // 
            tbName.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbName.Location = new Point(78, 121);
            tbName.Name = "tbName";
            tbName.Size = new Size(307, 33);
            tbName.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(174, 9);
            label1.Name = "label1";
            label1.Size = new Size(112, 37);
            label1.TabIndex = 7;
            label1.Text = "Register";
            // 
            // tbAddress
            // 
            tbAddress.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbAddress.Location = new Point(78, 382);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(307, 33);
            tbAddress.TabIndex = 13;
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(78, 254);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(307, 33);
            tbUsername.TabIndex = 14;
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(78, 190);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(307, 33);
            tbEmail.TabIndex = 15;
            // 
            // tbPhone
            // 
            tbPhone.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPhone.Location = new Point(78, 446);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(307, 33);
            tbPhone.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(78, 93);
            label2.Name = "label2";
            label2.Size = new Size(111, 25);
            label2.TabIndex = 17;
            label2.Text = "Full Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(78, 354);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 18;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(78, 290);
            label5.Name = "label5";
            label5.Size = new Size(100, 25);
            label5.TabIndex = 19;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(78, 226);
            label6.Name = "label6";
            label6.Size = new Size(100, 25);
            label6.TabIndex = 20;
            label6.Text = "Username";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(78, 162);
            label7.Name = "label7";
            label7.Size = new Size(67, 25);
            label7.TabIndex = 21;
            label7.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(78, 418);
            label8.Name = "label8";
            label8.Size = new Size(67, 25);
            label8.TabIndex = 22;
            label8.Text = "Phone";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 674);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
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
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}