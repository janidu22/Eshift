namespace Eshift.Forms.Admin
{
    partial class Assistants
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
            DtTable = new Label();

            mainContainer = new Panel();
            assistantsViewPanel = new Panel();
            DtTableAssistants = new DataGridView();
            assistantManagementPanel = new Panel();
            panel2 = new Panel();
            label3 = new Label();
            assistantFormPanel = new Panel();
            tbName = new TextBox();
            label2 = new Label();
            tbPhone = new TextBox();
            label1 = new Label();
            actionButtonsPanel = new Panel();
            Clear = new Button();
            Add = new Button();
            Update = new Button();
            delete = new Button();
            
            panel1.SuspendLayout();

            mainContainer.SuspendLayout();
            assistantsViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtTableAssistants).BeginInit();
            assistantManagementPanel.SuspendLayout();
            panel2.SuspendLayout();
            assistantFormPanel.SuspendLayout();
            actionButtonsPanel.SuspendLayout();
            SuspendLayout();
            
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 42, 86);
            panel1.Controls.Add(DtTable);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 60);
            panel1.TabIndex = 10;
            
            // 
            // DtTable
            // 
            DtTable.AutoSize = true;
            DtTable.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            DtTable.ForeColor = Color.White;
            DtTable.Location = new Point(20, 16);
            DtTable.Name = "DtTable";
            DtTable.Size = new Size(226, 32);
            DtTable.TabIndex = 0;
            DtTable.Text = "👥 Manage Assistants";
            


            
            // 
            // mainContainer
            // 
            mainContainer.BackColor = Color.FromArgb(240, 244, 248);
            mainContainer.Controls.Add(assistantsViewPanel);
            mainContainer.Controls.Add(assistantManagementPanel);
            mainContainer.Dock = DockStyle.Fill;
            mainContainer.Location = new Point(0, 60);
            mainContainer.Name = "mainContainer";
            mainContainer.Padding = new Padding(10);
            mainContainer.Size = new Size(1200, 640);
            mainContainer.TabIndex = 11;
            
            // 
            // assistantsViewPanel
            // 
            assistantsViewPanel.BackColor = Color.White;
            assistantsViewPanel.Controls.Add(DtTableAssistants);
            assistantsViewPanel.Dock = DockStyle.Left;
            assistantsViewPanel.Location = new Point(10, 10);
            assistantsViewPanel.Name = "assistantsViewPanel";
            assistantsViewPanel.Padding = new Padding(15);
            assistantsViewPanel.Size = new Size(756, 620);
            assistantsViewPanel.TabIndex = 0;
            
            // 
            // DtTableAssistants
            // 
            DtTableAssistants.AllowUserToAddRows = false;
            DtTableAssistants.AllowUserToDeleteRows = false;
            DtTableAssistants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DtTableAssistants.BackgroundColor = Color.White;
            DtTableAssistants.BorderStyle = BorderStyle.None;
            DtTableAssistants.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(25, 42, 86);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(25, 42, 86);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DtTableAssistants.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DtTableAssistants.ColumnHeadersHeight = 40;
            DtTableAssistants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(46, 125, 50);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DtTableAssistants.DefaultCellStyle = dataGridViewCellStyle2;
            DtTableAssistants.Dock = DockStyle.Fill;
            DtTableAssistants.EnableHeadersVisualStyles = false;
            DtTableAssistants.GridColor = Color.FromArgb(230, 230, 230);
            DtTableAssistants.Location = new Point(15, 15);
            DtTableAssistants.MultiSelect = false;
            DtTableAssistants.Name = "DtTableAssistants";
            DtTableAssistants.ReadOnly = true;
            DtTableAssistants.RowHeadersVisible = false;
            DtTableAssistants.RowsDefaultCellStyle = dataGridViewCellStyle3;
            DtTableAssistants.RowTemplate.Height = 35;
            DtTableAssistants.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtTableAssistants.Size = new Size(726, 590);
            DtTableAssistants.TabIndex = 0;
            DtTableAssistants.SelectionChanged += DtTableAssistants_SelectionChanged;
            
            // 
            // assistantManagementPanel
            // 
            assistantManagementPanel.BackColor = Color.White;
            assistantManagementPanel.Controls.Add(actionButtonsPanel);
            assistantManagementPanel.Controls.Add(assistantFormPanel);
            assistantManagementPanel.Controls.Add(panel2);
            assistantManagementPanel.Dock = DockStyle.Right;
            assistantManagementPanel.Location = new Point(776, 10);
            assistantManagementPanel.Name = "assistantManagementPanel";
            assistantManagementPanel.Size = new Size(414, 620);
            assistantManagementPanel.TabIndex = 1;
            
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(46, 125, 50);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(414, 50);
            panel2.TabIndex = 0;
            
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(20, 12);
            label3.Name = "label3";
            label3.Size = new Size(226, 25);
            label3.TabIndex = 0;
            label3.Text = "👥 Assistant Management";
            
            // 
            // assistantFormPanel
            // 
            assistantFormPanel.BackColor = Color.White;
            assistantFormPanel.Controls.Add(tbPhone);
            assistantFormPanel.Controls.Add(label1);
            assistantFormPanel.Controls.Add(tbName);
            assistantFormPanel.Controls.Add(label2);
            assistantFormPanel.Dock = DockStyle.Fill;
            assistantFormPanel.Location = new Point(0, 50);
            assistantFormPanel.Name = "assistantFormPanel";
            assistantFormPanel.Padding = new Padding(20);
            assistantFormPanel.Size = new Size(414, 490);
            assistantFormPanel.TabIndex = 1;
            
            // 
            // tbName
            // 
            tbName.BorderStyle = BorderStyle.FixedSingle;
            tbName.Font = new Font("Segoe UI", 11F);
            tbName.Location = new Point(20, 70);
            tbName.Name = "tbName";
            tbName.Size = new Size(374, 27);
            tbName.TabIndex = 1;
            
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(20, 47);
            label2.Name = "label2";
            label2.Size = new Size(45, 19);
            label2.TabIndex = 0;
            label2.Text = "Name";
            
            // 
            // tbPhone
            // 
            tbPhone.BorderStyle = BorderStyle.FixedSingle;
            tbPhone.Font = new Font("Segoe UI", 11F);
            tbPhone.Location = new Point(20, 140);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(374, 27);
            tbPhone.TabIndex = 3;
            
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(20, 117);
            label1.Name = "label1";
            label1.Size = new Size(49, 19);
            label1.TabIndex = 2;
            label1.Text = "Phone";
            
            // 
            // actionButtonsPanel
            // 
            actionButtonsPanel.BackColor = Color.FromArgb(250, 250, 250);
            actionButtonsPanel.Controls.Add(delete);
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
            Update.Click += UpdateBtn_Click;
            
            // 
            // delete
            // 
            delete.BackColor = Color.FromArgb(211, 47, 47);
            delete.FlatAppearance.BorderSize = 0;
            delete.FlatStyle = FlatStyle.Flat;
            delete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            delete.ForeColor = Color.White;
            delete.Location = new Point(320, 20);
            delete.Name = "delete";
            delete.Size = new Size(74, 40);
            delete.TabIndex = 3;
            delete.Text = "🗑️ Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += DeleteBtn_Click;
            
            // 
            // Assistants
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 248);
            ClientSize = new Size(1200, 700);
            Controls.Add(mainContainer);

            Controls.Add(panel1);
            Name = "Assistants";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Assistants Management";
            Load += Assistants_Load;
            
            panel1.ResumeLayout(false);
            panel1.PerformLayout();


            mainContainer.ResumeLayout(false);
            assistantsViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DtTableAssistants).EndInit();
            assistantManagementPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            assistantFormPanel.ResumeLayout(false);
            assistantFormPanel.PerformLayout();
            actionButtonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label DtTable;

        private Panel mainContainer;
        private Panel assistantsViewPanel;
        private DataGridView DtTableAssistants;
        private Panel assistantManagementPanel;
        private Panel panel2;
        private Label label3;
        private Panel assistantFormPanel;
        private TextBox tbName;
        private Label label2;
        private TextBox tbPhone;
        private Label label1;
        private Panel actionButtonsPanel;
        private Button Clear;
        private Button Add;
        private Button Update;
        private Button delete;
    }
}