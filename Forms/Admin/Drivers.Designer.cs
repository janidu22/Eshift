namespace Eshift.Forms.Admin
{
    partial class Drivers
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
            contentPanel = new Panel();
            driversViewPanel = new Panel();
            panel2 = new Panel();
            DtTable = new DataGridView();
            driverManagementPanel = new Panel();
            actionButtonsPanel = new Panel();
            Delete = new Button();
            Update = new Button();
            Clear = new Button();
            Add = new Button();
            driverFormPanel = new Panel();
            tbPhone = new TextBox();
            label4 = new Label();
            tbLicenseNumber = new TextBox();
            label3 = new Label();
            tbName = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            label5 = new Label();
            
            panel1.SuspendLayout();

            mainContainer.SuspendLayout();
            contentPanel.SuspendLayout();
            driversViewPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtTable).BeginInit();
            driverManagementPanel.SuspendLayout();
            actionButtonsPanel.SuspendLayout();
            driverFormPanel.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 42, 86);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 60);
            panel1.TabIndex = 1;
            
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 16);
            label1.Name = "label1";
            label1.Size = new Size(195, 32);
            label1.TabIndex = 0;
            label1.Text = "👨‍💼 Manage Drivers";
            


            
            // 
            // mainContainer
            // 
            mainContainer.BackColor = Color.FromArgb(240, 244, 248);
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
            contentPanel.Controls.Add(driversViewPanel);
            contentPanel.Controls.Add(driverManagementPanel);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(20, 20);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1160, 600);
            contentPanel.TabIndex = 0;
            
            // 
            // driversViewPanel
            // 
            driversViewPanel.BackColor = Color.White;
            driversViewPanel.Controls.Add(panel2);
            driversViewPanel.Dock = DockStyle.Fill;
            driversViewPanel.Location = new Point(0, 0);
            driversViewPanel.Name = "driversViewPanel";
            driversViewPanel.Padding = new Padding(10);
            driversViewPanel.Size = new Size(730, 600);
            driversViewPanel.TabIndex = 0;
            
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(DtTable);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(10, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(710, 580);
            panel2.TabIndex = 0;
            
            // 
            // DtTable
            // 
            DtTable.AllowUserToAddRows = false;
            DtTable.AllowUserToDeleteRows = false;
            DtTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DtTable.BackgroundColor = Color.White;
            DtTable.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DtTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DtTable.ColumnHeadersHeight = 40;
            DtTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(46, 204, 113);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DtTable.DefaultCellStyle = dataGridViewCellStyle2;
            DtTable.Dock = DockStyle.Fill;
            DtTable.EnableHeadersVisualStyles = false;
            DtTable.GridColor = Color.FromArgb(189, 195, 199);
            DtTable.Location = new Point(0, 0);
            DtTable.MultiSelect = false;
            DtTable.Name = "DtTable";
            DtTable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(236, 240, 241);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(46, 204, 113);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DtTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DtTable.RowHeadersVisible = false;
            DtTable.RowTemplate.Height = 35;
            DtTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtTable.Size = new Size(710, 580);
            DtTable.TabIndex = 0;
            DtTable.SelectionChanged += DtTable_SelectionChanged;
            
            // 
            // driverManagementPanel
            // 
            driverManagementPanel.BackColor = Color.White;
            driverManagementPanel.Controls.Add(actionButtonsPanel);
            driverManagementPanel.Controls.Add(driverFormPanel);
            driverManagementPanel.Controls.Add(panel3);
            driverManagementPanel.Dock = DockStyle.Right;
            driverManagementPanel.Location = new Point(730, 0);
            driverManagementPanel.Name = "driverManagementPanel";
            driverManagementPanel.Padding = new Padding(15);
            driverManagementPanel.Size = new Size(430, 600);
            driverManagementPanel.TabIndex = 1;
            
            // 
            // actionButtonsPanel
            // 
            actionButtonsPanel.Controls.Add(Delete);
            actionButtonsPanel.Controls.Add(Update);
            actionButtonsPanel.Controls.Add(Clear);
            actionButtonsPanel.Controls.Add(Add);
            actionButtonsPanel.Dock = DockStyle.Bottom;
            actionButtonsPanel.Location = new Point(15, 540);
            actionButtonsPanel.Name = "actionButtonsPanel";
            actionButtonsPanel.Size = new Size(400, 45);
            actionButtonsPanel.TabIndex = 2;
            
            // 
            // Delete
            // 
            Delete.BackColor = Color.FromArgb(231, 76, 60);
            Delete.FlatAppearance.BorderSize = 0;
            Delete.FlatStyle = FlatStyle.Flat;
            Delete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Delete.ForeColor = Color.White;
            Delete.Location = new Point(300, 5);
            Delete.Name = "Delete";
            Delete.Size = new Size(90, 35);
            Delete.TabIndex = 3;
            Delete.Text = "🗑️ Delete";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += DeleteBtn_Click;
            
            // 
            // Update
            // 
            Update.BackColor = Color.FromArgb(46, 204, 113);
            Update.FlatAppearance.BorderSize = 0;
            Update.FlatStyle = FlatStyle.Flat;
            Update.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Update.ForeColor = Color.White;
            Update.Location = new Point(200, 5);
            Update.Name = "Update";
            Update.Size = new Size(90, 35);
            Update.TabIndex = 2;
            Update.Text = "✏️ Update";
            Update.UseVisualStyleBackColor = false;
            Update.Click += UpdateBtn_Click;
            
            // 
            // Clear
            // 
            Clear.BackColor = Color.FromArgb(149, 165, 166);
            Clear.FlatAppearance.BorderSize = 0;
            Clear.FlatStyle = FlatStyle.Flat;
            Clear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Clear.ForeColor = Color.White;
            Clear.Location = new Point(105, 5);
            Clear.Name = "Clear";
            Clear.Size = new Size(90, 35);
            Clear.TabIndex = 1;
            Clear.Text = "🧹 Clear";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            
            // 
            // Add
            // 
            Add.BackColor = Color.FromArgb(52, 152, 219);
            Add.FlatAppearance.BorderSize = 0;
            Add.FlatStyle = FlatStyle.Flat;
            Add.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Add.ForeColor = Color.White;
            Add.Location = new Point(10, 5);
            Add.Name = "Add";
            Add.Size = new Size(90, 35);
            Add.TabIndex = 0;
            Add.Text = "➕ Add";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            
            // 
            // driverFormPanel
            // 
            driverFormPanel.Controls.Add(tbPhone);
            driverFormPanel.Controls.Add(label4);
            driverFormPanel.Controls.Add(tbLicenseNumber);
            driverFormPanel.Controls.Add(label3);
            driverFormPanel.Controls.Add(tbName);
            driverFormPanel.Controls.Add(label2);
            driverFormPanel.Dock = DockStyle.Top;
            driverFormPanel.Location = new Point(15, 60);
            driverFormPanel.Name = "driverFormPanel";
            driverFormPanel.Size = new Size(400, 480);
            driverFormPanel.TabIndex = 1;
            
            // 
            // tbPhone
            // 
            tbPhone.BackColor = Color.White;
            tbPhone.BorderStyle = BorderStyle.FixedSingle;
            tbPhone.Font = new Font("Segoe UI", 11F);
            tbPhone.ForeColor = Color.FromArgb(44, 62, 80);
            tbPhone.Location = new Point(120, 200);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(270, 27);
            tbPhone.TabIndex = 5;
            
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(44, 62, 80);
            label4.Location = new Point(10, 202);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 4;
            label4.Text = "Phone";
            
            // 
            // tbLicenseNumber
            // 
            tbLicenseNumber.BackColor = Color.White;
            tbLicenseNumber.BorderStyle = BorderStyle.FixedSingle;
            tbLicenseNumber.Font = new Font("Segoe UI", 11F);
            tbLicenseNumber.ForeColor = Color.FromArgb(44, 62, 80);
            tbLicenseNumber.Location = new Point(120, 130);
            tbLicenseNumber.Name = "tbLicenseNumber";
            tbLicenseNumber.Size = new Size(270, 27);
            tbLicenseNumber.TabIndex = 3;
            
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(44, 62, 80);
            label3.Location = new Point(10, 132);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 2;
            label3.Text = "License Number";
            
            // 
            // tbName
            // 
            tbName.BackColor = Color.White;
            tbName.BorderStyle = BorderStyle.FixedSingle;
            tbName.Font = new Font("Segoe UI", 11F);
            tbName.ForeColor = Color.FromArgb(44, 62, 80);
            tbName.Location = new Point(120, 60);
            tbName.Name = "tbName";
            tbName.Size = new Size(270, 27);
            tbName.TabIndex = 1;
            
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(44, 62, 80);
            label2.Location = new Point(10, 62);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 0;
            label2.Text = "Driver Name";
            
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(25, 42, 86);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(15, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(400, 45);
            panel3.TabIndex = 0;
            
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(140, 12);
            label5.Name = "label5";
            label5.Size = new Size(160, 25);
            label5.TabIndex = 0;
            label5.Text = "Driver Management";
            
            // 
            // Drivers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(1200, 700);
            Controls.Add(mainContainer);

            Controls.Add(panel1);
            Name = "Drivers";
            Text = "Manage Drivers - eShift Admin Portal";
            Load += Drivers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();


            mainContainer.ResumeLayout(false);
            contentPanel.ResumeLayout(false);
            driversViewPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DtTable).EndInit();
            driverManagementPanel.ResumeLayout(false);
            actionButtonsPanel.ResumeLayout(false);
            driverFormPanel.ResumeLayout(false);
            driverFormPanel.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;

        private Panel mainContainer;
        private Panel contentPanel;
        private Panel driversViewPanel;
        private Panel panel2;
        private DataGridView DtTable;
        private Panel driverManagementPanel;
        private Panel panel3;
        private Label label5;
        private Panel driverFormPanel;
        private Label label2;
        private TextBox tbName;
        private Label label3;
        private TextBox tbLicenseNumber;
        private Label label4;
        private TextBox tbPhone;
        private Panel actionButtonsPanel;
        private Button Add;
        private Button Clear;
        private Button Update;
        private Button Delete;
    }
}