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
            panel1 = new Panel();
            label1 = new Label();
            tbName = new TextBox();
            tbEmail = new TextBox();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            label3 = new Label();
            btnAddAdmin = new Button();
            TableLayoutPanel = new Panel();
            viewAdminsDt = new DataGridView();
            btnDeleteAdmin = new Button();
            btnUpdateAdmin = new Button();
            label2 = new Label();
            add = new Button();
            panel1.SuspendLayout();
            TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewAdminsDt).BeginInit();
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
            panel1.Size = new Size(902, 36);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(388, 9);
            label1.Name = "label1";
            label1.Size = new Size(126, 19);
            label1.TabIndex = 1;
            label1.Text = "Manage Admins";
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.None;
            tbName.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbName.Location = new Point(52, 184);
            tbName.Name = "tbName";
            tbName.PlaceholderText = "Name";
            tbName.Size = new Size(198, 29);
            tbName.TabIndex = 3;
            // 
            // tbEmail
            // 
            tbEmail.Anchor = AnchorStyles.None;
            tbEmail.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(52, 219);
            tbEmail.Name = "tbEmail";
            tbEmail.PlaceholderText = "Email";
            tbEmail.Size = new Size(198, 29);
            tbEmail.TabIndex = 4;
            // 
            // tbUsername
            // 
            tbUsername.Anchor = AnchorStyles.None;
            tbUsername.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(52, 254);
            tbUsername.Name = "tbUsername";
            tbUsername.PlaceholderText = "Username";
            tbUsername.Size = new Size(198, 29);
            tbUsername.TabIndex = 5;
            // 
            // tbPassword
            // 
            tbPassword.Anchor = AnchorStyles.None;
            tbPassword.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(52, 289);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.PlaceholderText = "Password";
            tbPassword.Size = new Size(198, 29);
            tbPassword.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 138);
            label3.Name = "label3";
            label3.Size = new Size(198, 19);
            label3.TabIndex = 7;
            label3.Text = "Administrator Details";
            // 
            // btnAddAdmin
            // 
            btnAddAdmin.Anchor = AnchorStyles.None;
            btnAddAdmin.BackColor = Color.FromArgb(0, 64, 0);
            btnAddAdmin.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddAdmin.ForeColor = Color.White;
            btnAddAdmin.Location = new Point(52, 333);
            btnAddAdmin.Name = "btnAddAdmin";
            btnAddAdmin.Size = new Size(198, 36);
            btnAddAdmin.TabIndex = 8;
            btnAddAdmin.Text = "Create Account";
            btnAddAdmin.UseVisualStyleBackColor = false;
            btnAddAdmin.Click += btnAddAdmin_Click;
            // 
            // TableLayoutPanel
            // 
            TableLayoutPanel.Anchor = AnchorStyles.None;
            TableLayoutPanel.BackColor = SystemColors.Control;
            TableLayoutPanel.Controls.Add(viewAdminsDt);
            TableLayoutPanel.Location = new Point(277, 138);
            TableLayoutPanel.Name = "TableLayoutPanel";
            TableLayoutPanel.Size = new Size(574, 274);
            TableLayoutPanel.TabIndex = 9;
            // 
            // viewAdminsDt
            // 
            viewAdminsDt.AllowUserToAddRows = false;
            viewAdminsDt.AllowUserToDeleteRows = false;
            viewAdminsDt.Anchor = AnchorStyles.None;
            viewAdminsDt.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            viewAdminsDt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            viewAdminsDt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            viewAdminsDt.DefaultCellStyle = dataGridViewCellStyle2;
            viewAdminsDt.GridColor = Color.Black;
            viewAdminsDt.Location = new Point(30, 36);
            viewAdminsDt.Name = "viewAdminsDt";
            viewAdminsDt.ReadOnly = true;
            viewAdminsDt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            viewAdminsDt.Size = new Size(500, 207);
            viewAdminsDt.TabIndex = 15;
            viewAdminsDt.SelectionChanged += viewAdminsDt_SelectionChanged;
            // 
            // btnDeleteAdmin
            // 
            btnDeleteAdmin.Anchor = AnchorStyles.None;
            btnDeleteAdmin.BackColor = Color.Maroon;
            btnDeleteAdmin.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteAdmin.ForeColor = Color.White;
            btnDeleteAdmin.Location = new Point(708, 418);
            btnDeleteAdmin.Name = "btnDeleteAdmin";
            btnDeleteAdmin.Size = new Size(143, 36);
            btnDeleteAdmin.TabIndex = 14;
            btnDeleteAdmin.Text = "Delete Admin";
            btnDeleteAdmin.UseVisualStyleBackColor = false;
            btnDeleteAdmin.Click += btnDeleteAdmin_Click;
            // 
            // btnUpdateAdmin
            // 
            btnUpdateAdmin.Anchor = AnchorStyles.None;
            btnUpdateAdmin.BackColor = Color.MediumSeaGreen;
            btnUpdateAdmin.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateAdmin.ForeColor = Color.White;
            btnUpdateAdmin.Location = new Point(566, 418);
            btnUpdateAdmin.Name = "btnUpdateAdmin";
            btnUpdateAdmin.Size = new Size(136, 36);
            btnUpdateAdmin.TabIndex = 15;
            btnUpdateAdmin.Text = "Update Admin ";
            btnUpdateAdmin.TextAlign = ContentAlignment.BottomCenter;
            btnUpdateAdmin.UseVisualStyleBackColor = false;
            btnUpdateAdmin.Click += btnUpdateAdmin_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(463, 112);
            label2.Name = "label2";
            label2.Size = new Size(135, 19);
            label2.TabIndex = 12;
            label2.Text = "Current Admins";
            // 
            // add
            // 
            add.Anchor = AnchorStyles.None;
            add.BackColor = Color.Navy;
            add.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add.ForeColor = Color.White;
            add.Location = new Point(361, 418);
            add.Name = "add";
            add.Size = new Size(199, 36);
            add.TabIndex = 15;
            add.Text = "Add New Admin";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // ManageAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 605);
            Controls.Add(add);
            Controls.Add(TableLayoutPanel);
            Controls.Add(btnDeleteAdmin);
            Controls.Add(btnAddAdmin);
            Controls.Add(btnUpdateAdmin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(tbEmail);
            Controls.Add(tbName);
            Controls.Add(panel1);
            Name = "ManageAdmin";
            Text = "ManageAdmin";
            Load += ManageAdmin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            TableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)viewAdminsDt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox tbName;
        private TextBox tbEmail;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Label label3;
        private Button btnAddAdmin;
        private Panel TableLayoutPanel;
        private DataGridView viewAdminsDt;
        private Button btnDeleteAdmin;
        private Button btnUpdateAdmin;
        private Label label2;
        private Button add;
    }
}