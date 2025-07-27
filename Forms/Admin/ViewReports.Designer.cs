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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            
            panel1 = new Panel();
            label1 = new Label();
            mainContainer = new Panel();
            filterPanel = new Panel();
            filterHeaderPanel = new Panel();
            filterHeaderLabel = new Label();
            filterControlsPanel = new Panel();
            btnFilter = new Button();
            lblToDate = new Label();
            lblFromDate = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            CbReports = new ComboBox();
            reportDataPanel = new Panel();
            dgvReportData = new DataGridView();
            actionButtonsPanel = new Panel();
            btnRefresh = new Button();
            btnPrint = new Button();
            btnExport = new Button();
            
            panel1.SuspendLayout();
            mainContainer.SuspendLayout();
            filterPanel.SuspendLayout();
            filterHeaderPanel.SuspendLayout();
            filterControlsPanel.SuspendLayout();
            reportDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportData).BeginInit();
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
            label1.Size = new Size(200, 32);
            label1.TabIndex = 0;
            label1.Text = "📊 View Reports";
            
            // 
            // mainContainer
            // 
            mainContainer.BackColor = Color.FromArgb(240, 244, 248);
            mainContainer.Controls.Add(actionButtonsPanel);
            mainContainer.Controls.Add(reportDataPanel);
            mainContainer.Controls.Add(filterPanel);
            mainContainer.Dock = DockStyle.Fill;
            mainContainer.Location = new Point(0, 60);
            mainContainer.Name = "mainContainer";
            mainContainer.Padding = new Padding(10);
            mainContainer.Size = new Size(1200, 640);
            mainContainer.TabIndex = 1;
            
            // 
            // filterPanel
            // 
            filterPanel.BackColor = Color.White;
            filterPanel.Controls.Add(filterControlsPanel);
            filterPanel.Controls.Add(filterHeaderPanel);
            filterPanel.Dock = DockStyle.Top;
            filterPanel.Location = new Point(10, 10);
            filterPanel.Name = "filterPanel";
            filterPanel.Size = new Size(1180, 120);
            filterPanel.TabIndex = 0;
            
            // 
            // filterHeaderPanel
            // 
            filterHeaderPanel.BackColor = Color.FromArgb(46, 125, 50);
            filterHeaderPanel.Controls.Add(filterHeaderLabel);
            filterHeaderPanel.Dock = DockStyle.Top;
            filterHeaderPanel.Location = new Point(0, 0);
            filterHeaderPanel.Name = "filterHeaderPanel";
            filterHeaderPanel.Size = new Size(1180, 40);
            filterHeaderPanel.TabIndex = 0;
            
            // 
            // filterHeaderLabel
            // 
            filterHeaderLabel.AutoSize = true;
            filterHeaderLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            filterHeaderLabel.ForeColor = Color.White;
            filterHeaderLabel.Location = new Point(20, 10);
            filterHeaderLabel.Name = "filterHeaderLabel";
            filterHeaderLabel.Size = new Size(150, 21);
            filterHeaderLabel.TabIndex = 0;
            filterHeaderLabel.Text = "🔍 Report Filters";
            
            // 
            // filterControlsPanel
            // 
            filterControlsPanel.BackColor = Color.White;
            filterControlsPanel.Controls.Add(btnFilter);
            filterControlsPanel.Controls.Add(lblToDate);
            filterControlsPanel.Controls.Add(lblFromDate);
            filterControlsPanel.Controls.Add(dateTimePicker2);
            filterControlsPanel.Controls.Add(dateTimePicker1);
            filterControlsPanel.Controls.Add(label2);
            filterControlsPanel.Controls.Add(CbReports);
            filterControlsPanel.Dock = DockStyle.Fill;
            filterControlsPanel.Location = new Point(0, 40);
            filterControlsPanel.Name = "filterControlsPanel";
            filterControlsPanel.Padding = new Padding(20);
            filterControlsPanel.Size = new Size(1180, 80);
            filterControlsPanel.TabIndex = 1;
            
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(46, 125, 50);
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(1080, 20);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(80, 40);
            btnFilter.TabIndex = 8;
            btnFilter.Text = "🔍 Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += BtnFilter_Click;
            
            // 
            // lblToDate
            // 
            lblToDate.AutoSize = true;
            lblToDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblToDate.ForeColor = Color.FromArgb(25, 42, 86);
            lblToDate.Location = new Point(720, 30);
            lblToDate.Name = "lblToDate";
            lblToDate.Size = new Size(25, 19);
            lblToDate.TabIndex = 10;
            lblToDate.Text = "To:";
            
            // 
            // lblFromDate
            // 
            lblFromDate.AutoSize = true;
            lblFromDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFromDate.ForeColor = Color.FromArgb(25, 42, 86);
            lblFromDate.Location = new Point(500, 30);
            lblFromDate.Name = "lblFromDate";
            lblFromDate.Size = new Size(45, 19);
            lblFromDate.TabIndex = 9;
            lblFromDate.Text = "From:";
            
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Segoe UI", 10F);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(750, 28);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(150, 23);
            dateTimePicker2.TabIndex = 5;
            
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 10F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(550, 28);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(150, 23);
            dateTimePicker1.TabIndex = 4;
            
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(25, 42, 86);
            label2.Location = new Point(20, 30);
            label2.Name = "label2";
            label2.Size = new Size(120, 19);
            label2.TabIndex = 3;
            label2.Text = "Report Type:";
            
            // 
            // CbReports
            // 
            CbReports.BackColor = Color.White;
            CbReports.DropDownStyle = ComboBoxStyle.DropDownList;
            CbReports.Font = new Font("Segoe UI", 10F);
            CbReports.ForeColor = Color.FromArgb(64, 64, 64);
            CbReports.FormattingEnabled = true;
            CbReports.Items.AddRange(new object[] { "Jobs", "Loads", "Payments", "Customers", "Revenue", "Products", "Transport Units", "Drivers", "Assistants", "Lorries", "Containers" });
            CbReports.Location = new Point(150, 28);
            CbReports.Name = "CbReports";
            CbReports.Size = new Size(250, 23);
            CbReports.TabIndex = 2;
            CbReports.SelectedIndexChanged += CbReports_SelectedIndexChanged;
            
            // 
            // reportDataPanel
            // 
            reportDataPanel.BackColor = Color.White;
            reportDataPanel.Controls.Add(dgvReportData);
            reportDataPanel.Dock = DockStyle.Fill;
            reportDataPanel.Location = new Point(10, 130);
            reportDataPanel.Name = "reportDataPanel";
            reportDataPanel.Padding = new Padding(20);
            reportDataPanel.Size = new Size(1180, 460);
            reportDataPanel.TabIndex = 1;
            
            // 
            // dgvReportData
            // 
            dgvReportData.AllowUserToAddRows = false;
            dgvReportData.AllowUserToDeleteRows = false;
            dgvReportData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportData.BackgroundColor = Color.White;
            dgvReportData.BorderStyle = BorderStyle.None;
            dgvReportData.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReportData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(25, 42, 86);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(25, 42, 86);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReportData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReportData.ColumnHeadersHeight = 45;
            dgvReportData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(25, 42, 86);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvReportData.DefaultCellStyle = dataGridViewCellStyle2;
            dgvReportData.Dock = DockStyle.Fill;
            dgvReportData.EnableHeadersVisualStyles = false;
            dgvReportData.GridColor = Color.FromArgb(230, 230, 230);
            dgvReportData.Location = new Point(20, 20);
            dgvReportData.MultiSelect = false;
            dgvReportData.Name = "dgvReportData";
            dgvReportData.ReadOnly = true;
            dgvReportData.RowHeadersVisible = false;
            dgvReportData.RowTemplate.Height = 35;
            dgvReportData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReportData.Size = new Size(1140, 420);
            dgvReportData.TabIndex = 0;
            
            // 
            // actionButtonsPanel
            // 
            actionButtonsPanel.BackColor = Color.FromArgb(240, 244, 248);
            actionButtonsPanel.Controls.Add(btnRefresh);
            actionButtonsPanel.Controls.Add(btnPrint);
            actionButtonsPanel.Controls.Add(btnExport);
            actionButtonsPanel.Dock = DockStyle.Bottom;
            actionButtonsPanel.Location = new Point(10, 590);
            actionButtonsPanel.Name = "actionButtonsPanel";
            actionButtonsPanel.Padding = new Padding(20);
            actionButtonsPanel.Size = new Size(1180, 40);
            actionButtonsPanel.TabIndex = 2;
            
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(96, 125, 139);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(1080, 5);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(80, 30);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "🔄 Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += BtnRefresh_Click;
            
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(255, 152, 0);
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(990, 5);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(80, 30);
            btnPrint.TabIndex = 1;
            btnPrint.Text = "🖨️ Print";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += BtnPrint_Click;
            
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.FromArgb(46, 125, 50);
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(900, 5);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(80, 30);
            btnExport.TabIndex = 0;
            btnExport.Text = "📄 Export";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += BtnExport_Click;
            
            // 
            // ViewReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 42, 86);
            ClientSize = new Size(1200, 700);
            Controls.Add(mainContainer);
            Controls.Add(panel1);
            MinimumSize = new Size(1216, 739);
            Name = "ViewReports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reports Dashboard";
            Load += ViewReports_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            mainContainer.ResumeLayout(false);
            filterPanel.ResumeLayout(false);
            filterHeaderPanel.ResumeLayout(false);
            filterHeaderPanel.PerformLayout();
            filterControlsPanel.ResumeLayout(false);
            filterControlsPanel.PerformLayout();
            reportDataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReportData).EndInit();
            actionButtonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel mainContainer;
        private Panel filterPanel;
        private Panel filterHeaderPanel;
        private Label filterHeaderLabel;
        private Panel filterControlsPanel;
        private ComboBox CbReports;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label lblFromDate;
        private Label lblToDate;
        private Button btnFilter;
        private Panel reportDataPanel;
        private DataGridView dgvReportData;
        private Panel actionButtonsPanel;
        private Button btnExport;
        private Button btnPrint;
        private Button btnRefresh;
    }
}