namespace Eshift.Forms.Admin
{
    partial class ViewReports
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
            panelFilter = new Panel();
            btnFilter = new Button();
            lblToDate = new Label();
            lblFromDate = new Label();
            label3 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            CbReports = new ComboBox();
            panel2 = new Panel();
            dgvReportData = new DataGridView();
            panel3 = new Panel();
            btnRefresh = new Button();
            btnPrint = new Button();
            btnExport = new Button();
            panel1.SuspendLayout();
            panelFilter.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportData).BeginInit();
            panel3.SuspendLayout();
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
            panel1.Size = new Size(1104, 36);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(493, 9);
            label1.Name = "label1";
            label1.Size = new Size(117, 19);
            label1.TabIndex = 1;
            label1.Text = "View Reports";
            // 
            // panelFilter
            // 
            panelFilter.BackColor = Color.LightGray;
            panelFilter.Controls.Add(btnFilter);
            panelFilter.Controls.Add(lblToDate);
            panelFilter.Controls.Add(lblFromDate);
            panelFilter.Controls.Add(label3);
            panelFilter.Controls.Add(dateTimePicker2);
            panelFilter.Controls.Add(dateTimePicker1);
            panelFilter.Controls.Add(label2);
            panelFilter.Controls.Add(CbReports);
            panelFilter.Dock = DockStyle.Top;
            panelFilter.Location = new Point(0, 36);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(1104, 120);
            panelFilter.TabIndex = 12;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.Orange;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("JetBrains Mono", 10F, FontStyle.Bold);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(760, 40);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(100, 29);
            btnFilter.TabIndex = 8;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            // 
            // lblToDate
            // 
            lblToDate.AutoSize = true;
            lblToDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblToDate.Location = new Point(540, 70);
            lblToDate.Name = "lblToDate";
            lblToDate.Size = new Size(23, 15);
            lblToDate.TabIndex = 10;
            lblToDate.Text = "To:";
            // 
            // lblFromDate
            // 
            lblFromDate.AutoSize = true;
            lblFromDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFromDate.Location = new Point(320, 70);
            lblFromDate.Name = "lblFromDate";
            lblFromDate.Size = new Size(38, 15);
            lblFromDate.TabIndex = 9;
            lblFromDate.Text = "From:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(320, 15);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 6;
            label3.Text = "Select Date Range";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarFont = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.Location = new Point(540, 40);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(320, 40);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 15);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 3;
            label2.Text = "Select report to view";
            // 
            // CbReports
            // 
            CbReports.DropDownStyle = ComboBoxStyle.DropDownList;
            CbReports.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CbReports.FormattingEnabled = true;
            CbReports.Items.AddRange(new object[] { "Jobs", "Loads", "Payments", "Customers", "Revenue", "Products", "Transport Units", "Drivers", "Assistants", "Lorries", "Containers" });
            CbReports.Location = new Point(20, 40);
            CbReports.Name = "CbReports";
            CbReports.Size = new Size(250, 29);
            CbReports.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvReportData);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 156);
            panel2.Name = "panel2";
            panel2.Size = new Size(1104, 542);
            panel2.TabIndex = 7;
            // 
            // dgvReportData
            // 
            dgvReportData.AllowUserToAddRows = false;
            dgvReportData.AllowUserToDeleteRows = false;
            dgvReportData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvReportData.BackgroundColor = Color.White;
            dgvReportData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportData.Dock = DockStyle.Fill;
            dgvReportData.Font = new Font("JetBrains Mono", 9F);
            dgvReportData.Location = new Point(0, 0);
            dgvReportData.Name = "dgvReportData";
            dgvReportData.ReadOnly = true;
            dgvReportData.RowHeadersVisible = false;
            dgvReportData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReportData.Size = new Size(1104, 542);
            dgvReportData.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnRefresh);
            panel3.Controls.Add(btnPrint);
            panel3.Controls.Add(btnExport);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 638);
            panel3.Name = "panel3";
            panel3.Size = new Size(1104, 60);
            panel3.TabIndex = 11;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Orange;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("JetBrains Mono", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(361, 15);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 35);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.Orange;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("JetBrains Mono", 10F, FontStyle.Bold);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(220, 15);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(120, 35);
            btnPrint.TabIndex = 1;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.Orange;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("JetBrains Mono", 10F, FontStyle.Bold);
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(79, 15);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(120, 35);
            btnExport.TabIndex = 0;
            btnExport.Text = "Export CSV";
            btnExport.UseVisualStyleBackColor = false;
            // 
            // ViewReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 698);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panelFilter);
            Controls.Add(panel1);
            MinimumSize = new Size(1120, 737);
            Name = "ViewReports";
            Text = "ViewReports";
            Load += ViewReports_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelFilter.ResumeLayout(false);
            panelFilter.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReportData).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panelFilter;
        private ComboBox CbReports;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private Button btnFilter;
        private Label lblFromDate;
        private Label lblToDate;
        private Panel panel2;
        private DataGridView dgvReportData;
        private Panel panel3;
        private Button btnExport;
        private Button btnPrint;
        private Button btnRefresh;
    }
}