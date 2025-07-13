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
            Clear = new Button();
            Update = new Button();
            Delete = new Button();
            Add = new Button();
            tbLicenseNumber = new TextBox();
            tbName = new TextBox();
            panel2 = new Panel();
            DtTable = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            tbPhone = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtTable).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Clear
            // 
            Clear.BackColor = Color.PaleGreen;
            Clear.Font = new Font("JetBrains Mono", 14.25F);
            Clear.Location = new Point(528, 642);
            Clear.Name = "Clear";
            Clear.Size = new Size(149, 38);
            Clear.TabIndex = 18;
            Clear.Text = "Add New";
            Clear.UseVisualStyleBackColor = false;
            // 
            // Update
            // 
            Update.BackColor = Color.LightCoral;
            Update.Font = new Font("JetBrains Mono", 14.25F);
            Update.Location = new Point(693, 642);
            Update.Name = "Update";
            Update.Size = new Size(96, 38);
            Update.TabIndex = 17;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = false;
            // 
            // Delete
            // 
            Delete.BackColor = Color.DarkRed;
            Delete.Font = new Font("JetBrains Mono", 14.25F);
            Delete.Location = new Point(810, 642);
            Delete.Name = "Delete";
            Delete.Size = new Size(89, 38);
            Delete.TabIndex = 16;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            // 
            // Add
            // 
            Add.BackColor = Color.SeaGreen;
            Add.Font = new Font("JetBrains Mono", 14.25F);
            Add.Location = new Point(218, 637);
            Add.Name = "Add";
            Add.Size = new Size(233, 38);
            Add.TabIndex = 15;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // tbLicenseNumber
            // 
            tbLicenseNumber.Location = new Point(218, 543);
            tbLicenseNumber.Name = "tbLicenseNumber";
            tbLicenseNumber.Size = new Size(233, 23);
            tbLicenseNumber.TabIndex = 13;
            // 
            // tbName
            // 
            tbName.Location = new Point(218, 505);
            tbName.Name = "tbName";
            tbName.Size = new Size(233, 23);
            tbName.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.Controls.Add(DtTable);
            panel2.Location = new Point(32, 117);
            panel2.Name = "panel2";
            panel2.Size = new Size(867, 307);
            panel2.TabIndex = 11;
            // 
            // DtTable
            // 
            DtTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtTable.Dock = DockStyle.Fill;
            DtTable.Location = new Point(0, 0);
            DtTable.Name = "DtTable";
            DtTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtTable.Size = new Size(867, 307);
            DtTable.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 68);
            panel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(356, 19);
            label1.Name = "label1";
            label1.Size = new Size(166, 25);
            label1.TabIndex = 0;
            label1.Text = "Manage Drivers";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(218, 578);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(233, 23);
            tbPhone.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(72, 507);
            label2.Name = "label2";
            label2.Size = new Size(130, 21);
            label2.TabIndex = 20;
            label2.Text = "Drivers Name";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(72, 580);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 21;
            label3.Text = "Phone";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(72, 545);
            label4.Name = "label4";
            label4.Size = new Size(140, 21);
            label4.TabIndex = 22;
            label4.Text = "LicenseNumber";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // Drivers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 701);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbPhone);
            Controls.Add(Clear);
            Controls.Add(Update);
            Controls.Add(Delete);
            Controls.Add(Add);
            Controls.Add(tbLicenseNumber);
            Controls.Add(tbName);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Drivers";
            Text = "Drivers";
            Load += Drivers_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DtTable).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Clear;
        private Button Update;
        private Button Delete;
        private Button Add;
        private TextBox tbLicenseNumber;
        private TextBox tbName;
        private Panel panel2;
        private DataGridView DtTable;
        private Panel panel1;
        private Label label1;
        private TextBox tbPhone;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}