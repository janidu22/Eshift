namespace Eshift.Forms.Admin
{
    partial class Lorries
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
            lorriesViewPanel = new Panel();
            DtTable = new DataGridView();
            lorryManagementPanel = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            lorryFormPanel = new Panel();
            tbPlateNumber = new TextBox();
            label2 = new Label();
            tbModel = new TextBox();
            label4 = new Label();
            NudCapacity = new NumericUpDown();
            label3 = new Label();
            actionButtonsPanel = new Panel();
            Clear = new Button();
            Add = new Button();
            Update = new Button();
            Delete = new Button();
            
            panel1.SuspendLayout();
            mainContainer.SuspendLayout();
            lorriesViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtTable).BeginInit();
            lorryManagementPanel.SuspendLayout();
            panel2.SuspendLayout();
            lorryFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudCapacity).BeginInit();
            actionButtonsPanel.SuspendLayout();
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
            panel1.Size = new Size(1200, 60);
            panel1.TabIndex = 0;
            
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
            label1.Text = "🚛 Manage Lorries";
            

            
            // 
            // mainContainer
            // 
            mainContainer.BackColor = Color.FromArgb(240, 244, 248);
            mainContainer.Controls.Add(lorriesViewPanel);
            mainContainer.Controls.Add(lorryManagementPanel);
            mainContainer.Dock = DockStyle.Fill;
            mainContainer.Location = new Point(0, 60);
            mainContainer.Name = "mainContainer";
            mainContainer.Padding = new Padding(10);
            mainContainer.Size = new Size(1200, 640);
            mainContainer.TabIndex = 1;
            
            // 
            // lorriesViewPanel
            // 
            lorriesViewPanel.BackColor = Color.White;
            lorriesViewPanel.Controls.Add(DtTable);
            lorriesViewPanel.Dock = DockStyle.Left;
            lorriesViewPanel.Location = new Point(10, 10);
            lorriesViewPanel.Name = "lorriesViewPanel";
            lorriesViewPanel.Padding = new Padding(15);
            lorriesViewPanel.Size = new Size(756, 620);
            lorriesViewPanel.TabIndex = 0;
            
            // 
            // DtTable
            // 
            DtTable.AllowUserToAddRows = false;
            DtTable.AllowUserToDeleteRows = false;
            DtTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DtTable.BackgroundColor = Color.White;
            DtTable.BorderStyle = BorderStyle.None;
            DtTable.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(25, 42, 86);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(25, 42, 86);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DtTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DtTable.ColumnHeadersHeight = 40;
            DtTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(46, 125, 50);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DtTable.DefaultCellStyle = dataGridViewCellStyle2;
            DtTable.Dock = DockStyle.Fill;
            DtTable.EnableHeadersVisualStyles = false;
            DtTable.GridColor = Color.FromArgb(230, 230, 230);
            DtTable.Location = new Point(15, 15);
            DtTable.MultiSelect = false;
            DtTable.Name = "DtTable";
            DtTable.ReadOnly = true;
            DtTable.RowHeadersVisible = false;
            
            DtTable.RowTemplate.Height = 35;
            DtTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            DtTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtTable.Size = new Size(726, 590);
            DtTable.TabIndex = 0;
            DtTable.SelectionChanged += DtTable_SelectionChanged;
            
            // 
            // lorryManagementPanel
            // 
            lorryManagementPanel.BackColor = Color.White;
            lorryManagementPanel.Controls.Add(actionButtonsPanel);
            lorryManagementPanel.Controls.Add(lorryFormPanel);
            lorryManagementPanel.Controls.Add(panel2);
            lorryManagementPanel.Dock = DockStyle.Right;
            lorryManagementPanel.Location = new Point(776, 10);
            lorryManagementPanel.Name = "lorryManagementPanel";
            lorryManagementPanel.Size = new Size(414, 620);
            lorryManagementPanel.TabIndex = 1;
            
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(46, 125, 50);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(414, 50);
            panel2.TabIndex = 0;
            
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(20, 12);
            label5.Name = "label5";
            label5.Size = new Size(201, 25);
            label5.TabIndex = 0;
            label5.Text = "🚛 Lorry Management";
            
            // 
            // lorryFormPanel
            // 
            lorryFormPanel.BackColor = Color.White;
            lorryFormPanel.Controls.Add(NudCapacity);
            lorryFormPanel.Controls.Add(label3);
            lorryFormPanel.Controls.Add(tbModel);
            lorryFormPanel.Controls.Add(label4);
            lorryFormPanel.Controls.Add(tbPlateNumber);
            lorryFormPanel.Controls.Add(label2);
            lorryFormPanel.Dock = DockStyle.Fill;
            lorryFormPanel.Location = new Point(0, 50);
            lorryFormPanel.Name = "lorryFormPanel";
            lorryFormPanel.Padding = new Padding(20);
            lorryFormPanel.Size = new Size(414, 490);
            lorryFormPanel.TabIndex = 1;
            
            // 
            // tbPlateNumber
            // 
            tbPlateNumber.BorderStyle = BorderStyle.FixedSingle;
            tbPlateNumber.Font = new Font("Segoe UI", 11F);
            tbPlateNumber.Location = new Point(20, 70);
            tbPlateNumber.Name = "tbPlateNumber";
            tbPlateNumber.Size = new Size(374, 27);
            tbPlateNumber.TabIndex = 1;
            
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(20, 47);
            label2.Name = "label2";
            label2.Size = new Size(94, 19);
            label2.TabIndex = 0;
            label2.Text = "Plate Number";
            
            // 
            // tbModel
            // 
            tbModel.BorderStyle = BorderStyle.FixedSingle;
            tbModel.Font = new Font("Segoe UI", 11F);
            tbModel.Location = new Point(20, 140);
            tbModel.Name = "tbModel";
            tbModel.Size = new Size(374, 27);
            tbModel.TabIndex = 3;
            
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(20, 117);
            label4.Name = "label4";
            label4.Size = new Size(49, 19);
            label4.TabIndex = 2;
            label4.Text = "Model";
            
            // 
            // NudCapacity
            // 
            NudCapacity.BorderStyle = BorderStyle.FixedSingle;
            NudCapacity.Font = new Font("Segoe UI", 11F);
            NudCapacity.Location = new Point(20, 210);
            NudCapacity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NudCapacity.Name = "NudCapacity";
            NudCapacity.Size = new Size(374, 27);
            NudCapacity.TabIndex = 5;
            
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(20, 187);
            label3.Name = "label3";
            label3.Size = new Size(106, 19);
            label3.TabIndex = 4;
            label3.Text = "Capacity (Tons)";
            
            // 
            // actionButtonsPanel
            // 
            actionButtonsPanel.BackColor = Color.FromArgb(250, 250, 250);
            actionButtonsPanel.Controls.Add(Delete);
            actionButtonsPanel.Controls.Add(Update);
            actionButtonsPanel.Controls.Add(Add);
            actionButtonsPanel.Controls.Add(Clear);
            actionButtonsPanel.Dock = DockStyle.Bottom;
            actionButtonsPanel.Location = new Point(0, 540);
            actionButtonsPanel.Name = "actionButtonsPanel";
            actionButtonsPanel.Padding = new Padding(20);
            actionButtonsPanel.Size = new Size(414, 80);
            actionButtonsPanel.TabIndex = 2;
            
            // 
            // Clear
            // 
            Clear.BackColor = Color.FromArgb(96, 125, 139);
            Clear.FlatAppearance.BorderSize = 0;
            Clear.FlatStyle = FlatStyle.Flat;
            Clear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Clear.ForeColor = Color.White;
            Clear.Location = new Point(20, 20);
            Clear.Name = "Clear";
            Clear.Size = new Size(90, 40);
            Clear.TabIndex = 0;
            Clear.Text = "🆕 New";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            
            // 
            // Add
            // 
            Add.BackColor = Color.FromArgb(46, 125, 50);
            Add.FlatAppearance.BorderSize = 0;
            Add.FlatStyle = FlatStyle.Flat;
            Add.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Add.ForeColor = Color.White;
            Add.Location = new Point(120, 20);
            Add.Name = "Add";
            Add.Size = new Size(90, 40);
            Add.TabIndex = 1;
            Add.Text = "➕ Add";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            
            // 
            // Update
            // 
            Update.BackColor = Color.FromArgb(255, 152, 0);
            Update.FlatAppearance.BorderSize = 0;
            Update.FlatStyle = FlatStyle.Flat;
            Update.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Update.ForeColor = Color.White;
            Update.Location = new Point(220, 20);
            Update.Name = "Update";
            Update.Size = new Size(90, 40);
            Update.TabIndex = 2;
            Update.Text = "✏️ Update";
            Update.UseVisualStyleBackColor = false;
            Update.Click += Update_Click;
            
            // 
            // Delete
            // 
            Delete.BackColor = Color.FromArgb(211, 47, 47);
            Delete.FlatAppearance.BorderSize = 0;
            Delete.FlatStyle = FlatStyle.Flat;
            Delete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Delete.ForeColor = Color.White;
            Delete.Location = new Point(320, 20);
            Delete.Name = "Delete";
            Delete.Size = new Size(74, 40);
            Delete.TabIndex = 3;
            Delete.Text = "🗑️ Delete";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            
            // 
            // Lorries
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 248);
            ClientSize = new Size(1200, 700);
            Controls.Add(mainContainer);
            Controls.Add(panel1);
            Name = "Lorries";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lorries Management";
            Load += Lorries_Load;
            
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            mainContainer.ResumeLayout(false);
            lorriesViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DtTable).EndInit();
            lorryManagementPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            lorryFormPanel.ResumeLayout(false);
            lorryFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NudCapacity).EndInit();
            actionButtonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel mainContainer;
        private Panel lorriesViewPanel;
        private DataGridView DtTable;
        private Panel lorryManagementPanel;
        private Panel panel2;
        private Label label5;
        private Panel lorryFormPanel;
        private TextBox tbPlateNumber;
        private Label label2;
        private TextBox tbModel;
        private Label label4;
        private NumericUpDown NudCapacity;
        private Label label3;
        private Panel actionButtonsPanel;
        private Button Clear;
        private Button Add;
        private Button Update;
        private Button Delete;
    }
}