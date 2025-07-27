namespace Eshift.Forms.Admin
{
    partial class ManageLoads
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            mainContainer = new Panel();
            jobSelectionPanel = new Panel();
            cbJobs = new ComboBox();
            label3 = new Label();
            contentPanel = new Panel();
            loadsViewPanel = new Panel();
            DataPanel = new Panel();
            dgvLoads = new DataGridView();
            loadManagementPanel = new Panel();
            actionButtonsPanel = new Panel();
            button3 = new Button();
            button1 = new Button();
            AddLoads = new Button();
            loadFormPanel = new Panel();
            tbNotes = new TextBox();
            label8 = new Label();
            tbWeight = new TextBox();
            label5 = new Label();
            nudQuantity = new NumericUpDown();
            label6 = new Label();
            cbTransportUnits = new ComboBox();
            label7 = new Label();
            cbProducts = new ComboBox();
            label4 = new Label();
            panel2 = new Panel();
            label9 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            
            panel1.SuspendLayout();
            mainContainer.SuspendLayout();
            jobSelectionPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            loadsViewPanel.SuspendLayout();
            DataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoads).BeginInit();
            loadManagementPanel.SuspendLayout();
            actionButtonsPanel.SuspendLayout();
            loadFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 42, 86);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 60);
            panel1.TabIndex = 1;
            
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(871, -20);
            label1.Name = "label1";
            label1.Size = new Size(181, 32);
            label1.TabIndex = 1;
            label1.Text = "Manage Admins";
            label1.Visible = false;
            
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(540, 16);
            label2.Name = "label2";
            label2.Size = new Size(172, 32);
            label2.TabIndex = 2;
            label2.Text = "Manage Loads";
            
            // 
            // mainContainer
            // 
            mainContainer.BackColor = Color.FromArgb(236, 240, 241);
            mainContainer.Controls.Add(jobSelectionPanel);
            mainContainer.Controls.Add(contentPanel);
            mainContainer.Dock = DockStyle.Fill;
            mainContainer.Location = new Point(0, 60);
            mainContainer.Name = "mainContainer";
            mainContainer.Padding = new Padding(20);
            mainContainer.Size = new Size(1200, 640);
            mainContainer.TabIndex = 2;
            
            // 
            // jobSelectionPanel
            // 
            jobSelectionPanel.BackColor = Color.White;
            jobSelectionPanel.Controls.Add(cbJobs);
            jobSelectionPanel.Controls.Add(label3);
            jobSelectionPanel.Dock = DockStyle.Top;
            jobSelectionPanel.Location = new Point(20, 20);
            jobSelectionPanel.Name = "jobSelectionPanel";
            jobSelectionPanel.Padding = new Padding(20, 15, 20, 15);
            jobSelectionPanel.Size = new Size(1160, 80);
            jobSelectionPanel.TabIndex = 0;
            
            // 
            // cbJobs
            // 
            cbJobs.BackColor = Color.White;
            cbJobs.Cursor = Cursors.Hand;
            cbJobs.DropDownStyle = ComboBoxStyle.DropDownList;
            cbJobs.FlatStyle = FlatStyle.Flat;
            cbJobs.Font = new Font("Segoe UI", 12F);
            cbJobs.ForeColor = Color.FromArgb(44, 62, 80);
            cbJobs.FormattingEnabled = true;
            cbJobs.Location = new Point(350, 25);
            cbJobs.Name = "cbJobs";
            cbJobs.Size = new Size(480, 29);
            cbJobs.TabIndex = 1;
            cbJobs.SelectedIndexChanged += cbJobs_SelectedIndexChanged;
            
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(44, 62, 80);
            label3.Location = new Point(20, 27);
            label3.Name = "label3";
            label3.Size = new Size(312, 25);
            label3.TabIndex = 0;
            label3.Text = "📦 Select Job to Manage Loads:";
            
            // 
            // contentPanel
            // 
            contentPanel.Controls.Add(loadsViewPanel);
            contentPanel.Controls.Add(loadManagementPanel);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(20, 100);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1160, 520);
            contentPanel.TabIndex = 1;
            
            // 
            // loadsViewPanel
            // 
            loadsViewPanel.BackColor = Color.White;
            loadsViewPanel.Controls.Add(DataPanel);
            loadsViewPanel.Dock = DockStyle.Fill;
            loadsViewPanel.Location = new Point(0, 0);
            loadsViewPanel.Name = "loadsViewPanel";
            loadsViewPanel.Padding = new Padding(10);
            loadsViewPanel.Size = new Size(730, 520);
            loadsViewPanel.TabIndex = 0;
            
            // 
            // DataPanel
            // 
            DataPanel.BackColor = Color.White;
            DataPanel.Controls.Add(dgvLoads);
            DataPanel.Dock = DockStyle.Fill;
            DataPanel.Location = new Point(10, 10);
            DataPanel.Name = "DataPanel";
            DataPanel.Size = new Size(710, 500);
            DataPanel.TabIndex = 0;
            
            // 
            // dgvLoads
            // 
            dgvLoads.AllowUserToAddRows = false;
            dgvLoads.AllowUserToDeleteRows = false;
            dgvLoads.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoads.BackgroundColor = Color.White;
            dgvLoads.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLoads.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLoads.ColumnHeadersHeight = 40;
            dgvLoads.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(46, 204, 113);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvLoads.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLoads.Dock = DockStyle.Fill;
            dgvLoads.EnableHeadersVisualStyles = false;
            dgvLoads.GridColor = Color.FromArgb(189, 195, 199);
            dgvLoads.Location = new Point(0, 0);
            dgvLoads.MultiSelect = false;
            dgvLoads.Name = "dgvLoads";
            dgvLoads.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(236, 240, 241);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(46, 204, 113);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvLoads.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvLoads.RowHeadersVisible = false;
            dgvLoads.RowTemplate.Height = 35;
            dgvLoads.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLoads.Size = new Size(710, 500);
            dgvLoads.TabIndex = 0;
            dgvLoads.SelectionChanged += dgvLoads_SelectionChanged;
            
            // 
            // loadManagementPanel
            // 
            loadManagementPanel.BackColor = Color.White;
            loadManagementPanel.Controls.Add(actionButtonsPanel);
            loadManagementPanel.Controls.Add(loadFormPanel);
            loadManagementPanel.Controls.Add(panel2);
            loadManagementPanel.Dock = DockStyle.Right;
            loadManagementPanel.Location = new Point(730, 0);
            loadManagementPanel.Name = "loadManagementPanel";
            loadManagementPanel.Padding = new Padding(15);
            loadManagementPanel.Size = new Size(430, 520);
            loadManagementPanel.TabIndex = 1;
            
            // 
            // actionButtonsPanel
            // 
            actionButtonsPanel.Controls.Add(button3);
            actionButtonsPanel.Controls.Add(button1);
            actionButtonsPanel.Controls.Add(AddLoads);
            actionButtonsPanel.Dock = DockStyle.Bottom;
            actionButtonsPanel.Location = new Point(15, 460);
            actionButtonsPanel.Name = "actionButtonsPanel";
            actionButtonsPanel.Size = new Size(400, 45);
            actionButtonsPanel.TabIndex = 2;
            
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(231, 76, 60);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(270, 5);
            button3.Name = "button3";
            button3.Size = new Size(120, 35);
            button3.TabIndex = 2;
            button3.Text = "🗑️ Delete Load";
            button3.UseVisualStyleBackColor = false;
            button3.Click += delete;
            
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(46, 204, 113);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(140, 5);
            button1.Name = "button1";
            button1.Size = new Size(120, 35);
            button1.TabIndex = 1;
            button1.Text = "✏️ Update Load";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            
            // 
            // AddLoads
            // 
            AddLoads.BackColor = Color.FromArgb(52, 152, 219);
            AddLoads.FlatAppearance.BorderSize = 0;
            AddLoads.FlatStyle = FlatStyle.Flat;
            AddLoads.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            AddLoads.ForeColor = Color.White;
            AddLoads.Location = new Point(10, 5);
            AddLoads.Name = "AddLoads";
            AddLoads.Size = new Size(120, 35);
            AddLoads.TabIndex = 0;
            AddLoads.Text = "➕ Add Load";
            AddLoads.UseVisualStyleBackColor = false;
            AddLoads.Click += AddLoads_Click;
            
            // 
            // loadFormPanel
            // 
            loadFormPanel.Controls.Add(tbNotes);
            loadFormPanel.Controls.Add(label8);
            loadFormPanel.Controls.Add(tbWeight);
            loadFormPanel.Controls.Add(label5);
            loadFormPanel.Controls.Add(nudQuantity);
            loadFormPanel.Controls.Add(label6);
            loadFormPanel.Controls.Add(cbTransportUnits);
            loadFormPanel.Controls.Add(label7);
            loadFormPanel.Controls.Add(cbProducts);
            loadFormPanel.Controls.Add(label4);
            loadFormPanel.Dock = DockStyle.Top;
            loadFormPanel.Location = new Point(15, 60);
            loadFormPanel.Name = "loadFormPanel";
            loadFormPanel.Size = new Size(400, 400);
            loadFormPanel.TabIndex = 1;
            
            // 
            // tbNotes
            // 
            tbNotes.BackColor = Color.White;
            tbNotes.BorderStyle = BorderStyle.FixedSingle;
            tbNotes.Font = new Font("Segoe UI", 11F);
            tbNotes.ForeColor = Color.FromArgb(44, 62, 80);
            tbNotes.Location = new Point(120, 310);
            tbNotes.Multiline = true;
            tbNotes.Name = "tbNotes";
            tbNotes.Size = new Size(270, 80);
            tbNotes.TabIndex = 9;
            
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(44, 62, 80);
            label8.Location = new Point(10, 312);
            label8.Name = "label8";
            label8.Size = new Size(48, 20);
            label8.TabIndex = 8;
            label8.Text = "Notes";
            
            // 
            // tbWeight
            // 
            tbWeight.BackColor = Color.White;
            tbWeight.BorderStyle = BorderStyle.FixedSingle;
            tbWeight.Font = new Font("Segoe UI", 11F);
            tbWeight.ForeColor = Color.FromArgb(44, 62, 80);
            tbWeight.Location = new Point(120, 250);
            tbWeight.Name = "tbWeight";
            tbWeight.Size = new Size(270, 27);
            tbWeight.TabIndex = 7;
            
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(44, 62, 80);
            label5.Location = new Point(10, 252);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 6;
            label5.Text = "Weight (kg)";
            
            // 
            // nudQuantity
            // 
            nudQuantity.BackColor = Color.White;
            nudQuantity.BorderStyle = BorderStyle.FixedSingle;
            nudQuantity.Font = new Font("Segoe UI", 11F);
            nudQuantity.ForeColor = Color.FromArgb(44, 62, 80);
            nudQuantity.Location = new Point(120, 190);
            nudQuantity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(270, 27);
            nudQuantity.TabIndex = 5;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(44, 62, 80);
            label6.Location = new Point(10, 192);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 4;
            label6.Text = "Quantity";
            
            // 
            // cbTransportUnits
            // 
            cbTransportUnits.BackColor = Color.White;
            cbTransportUnits.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTransportUnits.FlatStyle = FlatStyle.Flat;
            cbTransportUnits.Font = new Font("Segoe UI", 11F);
            cbTransportUnits.ForeColor = Color.FromArgb(44, 62, 80);
            cbTransportUnits.FormattingEnabled = true;
            cbTransportUnits.Location = new Point(120, 130);
            cbTransportUnits.Name = "cbTransportUnits";
            cbTransportUnits.Size = new Size(270, 28);
            cbTransportUnits.TabIndex = 3;
            
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(44, 62, 80);
            label7.Location = new Point(10, 132);
            label7.Name = "label7";
            label7.Size = new Size(106, 20);
            label7.TabIndex = 2;
            label7.Text = "Transport Unit";
            
            // 
            // cbProducts
            // 
            cbProducts.BackColor = Color.White;
            cbProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProducts.FlatStyle = FlatStyle.Flat;
            cbProducts.Font = new Font("Segoe UI", 11F);
            cbProducts.ForeColor = Color.FromArgb(44, 62, 80);
            cbProducts.FormattingEnabled = true;
            cbProducts.Location = new Point(120, 70);
            cbProducts.Name = "cbProducts";
            cbProducts.Size = new Size(270, 28);
            cbProducts.TabIndex = 1;
            
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(44, 62, 80);
            label4.Location = new Point(10, 72);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 0;
            label4.Text = "Product";
            
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(25, 42, 86);
            panel2.Controls.Add(label9);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(15, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 45);
            panel2.TabIndex = 0;
            
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(145, 12);
            label9.Name = "label9";
            label9.Size = new Size(151, 25);
            label9.TabIndex = 0;
            label9.Text = "Load Management";
            
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            
            // 
            // ManageLoads
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(1200, 700);
            Controls.Add(mainContainer);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            Name = "ManageLoads";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Loads - eShift Admin Portal";
            Load += ManageLoads_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            mainContainer.ResumeLayout(false);
            jobSelectionPanel.ResumeLayout(false);
            jobSelectionPanel.PerformLayout();
            contentPanel.ResumeLayout(false);
            loadsViewPanel.ResumeLayout(false);
            DataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLoads).EndInit();
            loadManagementPanel.ResumeLayout(false);
            actionButtonsPanel.ResumeLayout(false);
            loadFormPanel.ResumeLayout(false);
            loadFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel mainContainer;
        private Panel jobSelectionPanel;
        private ComboBox cbJobs;
        private Label label3;
        private Panel contentPanel;
        private Panel loadsViewPanel;
        private Panel DataPanel;
        private DataGridView dgvLoads;
        private Panel loadManagementPanel;
        private Panel panel2;
        private Label label9;
        private Panel loadFormPanel;
        private Label label4;
        private ComboBox cbProducts;
        private Label label7;
        private ComboBox cbTransportUnits;
        private Label label6;
        private NumericUpDown nudQuantity;
        private Label label5;
        private TextBox tbWeight;
        private Label label8;
        private TextBox tbNotes;
        private Panel actionButtonsPanel;
        private Button AddLoads;
        private Button button1;
        private Button button3;
        private ContextMenuStrip contextMenuStrip1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}