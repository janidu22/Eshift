namespace Eshift.Forms.Admin
{
    partial class ViewJobs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewJobs));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            mainContainer = new Panel();
            searchPanel = new Panel();
            button1 = new Button();
            CbPaymentStatus = new ComboBox();
            CbStatus = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            tbSearch = new TextBox();
            contentPanel = new Panel();
            jobsViewPanel = new Panel();
            viewJobsDt = new DataGridView();
            jobManagementPanel = new Panel();
            statusPanel = new Panel();
            label15 = new Label();
            label14 = new Label();
            rbPaymentPaid = new RadioButton();
            rbPaymentPending = new RadioButton();
            rbCompleted = new RadioButton();
            rbApproved = new RadioButton();
            rbPending = new RadioButton();
            actionButtonsPanel = new Panel();
            DeleteJob = new Button();
            UpdateJobBtn = new Button();
            btnCreateNewJob = new Button();
            jobFormPanel = new Panel();
            TbAmount = new TextBox();
            label10 = new Label();
            TbNotes = new TextBox();
            label4 = new Label();
            RbCash = new RadioButton();
            RbCard = new RadioButton();
            label11 = new Label();
            TbWeight = new TextBox();
            label5 = new Label();
            NuDQuentity = new NumericUpDown();
            label6 = new Label();
            CbProducts = new ComboBox();
            label7 = new Label();
            DTRequestDate = new DateTimePicker();
            label8 = new Label();
            tbDestination = new TextBox();
            label9 = new Label();
            tbStartLocation = new TextBox();
            label12 = new Label();
            panel2 = new Panel();
            label13 = new Label();
            panel1.SuspendLayout();
            mainContainer.SuspendLayout();
            searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contentPanel.SuspendLayout();
            jobsViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewJobsDt).BeginInit();
            jobManagementPanel.SuspendLayout();
            statusPanel.SuspendLayout();
            actionButtonsPanel.SuspendLayout();
            jobFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NuDQuentity).BeginInit();
            panel2.SuspendLayout();
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
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(550, 16);
            label1.Name = "label1";
            label1.Size = new Size(128, 32);
            label1.TabIndex = 1;
            label1.Text = "View Jobs";
            // 
            // mainContainer
            // 
            mainContainer.BackColor = Color.FromArgb(236, 240, 241);
            mainContainer.Controls.Add(searchPanel);
            mainContainer.Controls.Add(contentPanel);
            mainContainer.Dock = DockStyle.Fill;
            mainContainer.Location = new Point(0, 60);
            mainContainer.Name = "mainContainer";
            mainContainer.Padding = new Padding(20);
            mainContainer.Size = new Size(1200, 641);
            mainContainer.TabIndex = 2;
            // 
            // searchPanel
            // 
            searchPanel.BackColor = Color.White;
            searchPanel.Controls.Add(button1);
            searchPanel.Controls.Add(CbPaymentStatus);
            searchPanel.Controls.Add(CbStatus);
            searchPanel.Controls.Add(label3);
            searchPanel.Controls.Add(label2);
            searchPanel.Controls.Add(pictureBox1);
            searchPanel.Controls.Add(tbSearch);
            searchPanel.Dock = DockStyle.Top;
            searchPanel.Location = new Point(20, 20);
            searchPanel.Name = "searchPanel";
            searchPanel.Padding = new Padding(20, 15, 20, 15);
            searchPanel.Size = new Size(1160, 80);
            searchPanel.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(231, 76, 60);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1050, 20);
            button1.Name = "button1";
            button1.Size = new Size(80, 35);
            button1.TabIndex = 6;
            button1.Text = "CLEAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += ButtonClear_Click;
            // 
            // CbPaymentStatus
            // 
            CbPaymentStatus.BackColor = Color.White;
            CbPaymentStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            CbPaymentStatus.FlatStyle = FlatStyle.Flat;
            CbPaymentStatus.Font = new Font("Segoe UI", 10F);
            CbPaymentStatus.ForeColor = Color.FromArgb(44, 62, 80);
            CbPaymentStatus.FormattingEnabled = true;
            CbPaymentStatus.Location = new Point(820, 45);
            CbPaymentStatus.Name = "CbPaymentStatus";
            CbPaymentStatus.Size = new Size(200, 25);
            CbPaymentStatus.TabIndex = 5;
            // 
            // CbStatus
            // 
            CbStatus.BackColor = Color.White;
            CbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            CbStatus.FlatStyle = FlatStyle.Flat;
            CbStatus.Font = new Font("Segoe UI", 10F);
            CbStatus.ForeColor = Color.FromArgb(44, 62, 80);
            CbStatus.FormattingEnabled = true;
            CbStatus.Location = new Point(550, 45);
            CbStatus.Name = "CbStatus";
            CbStatus.Size = new Size(200, 25);
            CbStatus.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(44, 62, 80);
            label3.Location = new Point(820, 25);
            label3.Name = "label3";
            label3.Size = new Size(171, 19);
            label3.TabIndex = 3;
            label3.Text = "Filter by Payment Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(44, 62, 80);
            label2.Location = new Point(550, 25);
            label2.Name = "label2";
            label2.Size = new Size(108, 19);
            label2.TabIndex = 2;
            label2.Text = "Filter by Status";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tbSearch
            // 
            tbSearch.BackColor = Color.FromArgb(248, 249, 250);
            tbSearch.BorderStyle = BorderStyle.FixedSingle;
            tbSearch.Font = new Font("Segoe UI", 12F);
            tbSearch.ForeColor = Color.FromArgb(44, 62, 80);
            tbSearch.Location = new Point(70, 25);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Search Customer Name";
            tbSearch.Size = new Size(400, 29);
            tbSearch.TabIndex = 0;
            // 
            // contentPanel
            // 
            contentPanel.Controls.Add(jobsViewPanel);
            contentPanel.Controls.Add(jobManagementPanel);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(20, 20);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1160, 601);
            contentPanel.TabIndex = 1;
            // 
            // jobsViewPanel
            // 
            jobsViewPanel.BackColor = Color.White;
            jobsViewPanel.Controls.Add(viewJobsDt);
            jobsViewPanel.Dock = DockStyle.Fill;
            jobsViewPanel.Location = new Point(0, 0);
            jobsViewPanel.Name = "jobsViewPanel";
            jobsViewPanel.Padding = new Padding(10);
            jobsViewPanel.Size = new Size(730, 601);
            jobsViewPanel.TabIndex = 0;
            // 
            // viewJobsDt
            // 
            viewJobsDt.AllowUserToAddRows = false;
            viewJobsDt.AllowUserToDeleteRows = false;
            viewJobsDt.AllowUserToResizeColumns = true;
            viewJobsDt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            viewJobsDt.ScrollBars = ScrollBars.Both;
            viewJobsDt.BackgroundColor = Color.White;
            viewJobsDt.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            viewJobsDt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            viewJobsDt.ColumnHeadersHeight = 40;
            viewJobsDt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            viewJobsDt.ColumnHeadersVisible = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(46, 204, 113);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            viewJobsDt.DefaultCellStyle = dataGridViewCellStyle2;
            viewJobsDt.Dock = DockStyle.Fill;
            viewJobsDt.EnableHeadersVisualStyles = false;
            viewJobsDt.GridColor = Color.FromArgb(189, 195, 199);
            viewJobsDt.Location = new Point(10, 10);
            viewJobsDt.MultiSelect = false;
            viewJobsDt.Name = "viewJobsDt";
            viewJobsDt.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(236, 240, 241);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(46, 204, 113);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            viewJobsDt.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            viewJobsDt.RowHeadersVisible = false;
            viewJobsDt.RowTemplate.Height = 35;
            viewJobsDt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            viewJobsDt.Size = new Size(710, 581);
            viewJobsDt.TabIndex = 0;
            viewJobsDt.CellContentClick += viewJobsDt_CellContentClick;
            // 
            // jobManagementPanel
            // 
            jobManagementPanel.BackColor = Color.White;
            jobManagementPanel.Controls.Add(statusPanel);
            jobManagementPanel.Controls.Add(actionButtonsPanel);
            jobManagementPanel.Controls.Add(jobFormPanel);
            jobManagementPanel.Controls.Add(panel2);
            jobManagementPanel.Dock = DockStyle.Right;
            jobManagementPanel.Location = new Point(730, 0);
            jobManagementPanel.Name = "jobManagementPanel";
            jobManagementPanel.Padding = new Padding(15);
            jobManagementPanel.Size = new Size(430, 601);
            jobManagementPanel.TabIndex = 1;
            // 
            // statusPanel
            // 
            statusPanel.Controls.Add(label15);
            statusPanel.Controls.Add(label14);
            statusPanel.Controls.Add(rbPaymentPaid);
            statusPanel.Controls.Add(rbPaymentPending);
            statusPanel.Controls.Add(rbCompleted);
            statusPanel.Controls.Add(rbApproved);
            statusPanel.Controls.Add(rbPending);
            statusPanel.Dock = DockStyle.Top;
            statusPanel.Location = new Point(15, 420);
            statusPanel.Name = "statusPanel";
            statusPanel.Size = new Size(400, 114);
            statusPanel.TabIndex = 3;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label15.ForeColor = Color.FromArgb(44, 62, 80);
            label15.Location = new Point(200, 10);
            label15.Name = "label15";
            label15.Size = new Size(129, 21);
            label15.TabIndex = 6;
            label15.Text = "Payment Status";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label14.ForeColor = Color.FromArgb(44, 62, 80);
            label14.Location = new Point(10, 10);
            label14.Name = "label14";
            label14.Size = new Size(88, 21);
            label14.TabIndex = 5;
            label14.Text = "Job Status";
            // 
            // rbPaymentPaid
            // 
            rbPaymentPaid.AutoSize = true;
            rbPaymentPaid.Font = new Font("Segoe UI", 10F);
            rbPaymentPaid.ForeColor = Color.FromArgb(44, 62, 80);
            rbPaymentPaid.Location = new Point(200, 65);
            rbPaymentPaid.Name = "rbPaymentPaid";
            rbPaymentPaid.Size = new Size(53, 23);
            rbPaymentPaid.TabIndex = 4;
            rbPaymentPaid.TabStop = true;
            rbPaymentPaid.Text = "Paid";
            rbPaymentPaid.UseVisualStyleBackColor = true;
            // 
            // rbPaymentPending
            // 
            rbPaymentPending.AutoSize = true;
            rbPaymentPending.Font = new Font("Segoe UI", 10F);
            rbPaymentPending.ForeColor = Color.FromArgb(44, 62, 80);
            rbPaymentPending.Location = new Point(200, 40);
            rbPaymentPending.Name = "rbPaymentPending";
            rbPaymentPending.Size = new Size(76, 23);
            rbPaymentPending.TabIndex = 3;
            rbPaymentPending.TabStop = true;
            rbPaymentPending.Text = "Pending";
            rbPaymentPending.UseVisualStyleBackColor = true;
            // 
            // rbCompleted
            // 
            rbCompleted.AutoSize = true;
            rbCompleted.Font = new Font("Segoe UI", 10F);
            rbCompleted.ForeColor = Color.FromArgb(44, 62, 80);
            rbCompleted.Location = new Point(10, 90);
            rbCompleted.Name = "rbCompleted";
            rbCompleted.Size = new Size(94, 23);
            rbCompleted.TabIndex = 2;
            rbCompleted.TabStop = true;
            rbCompleted.Text = "Completed";
            rbCompleted.UseVisualStyleBackColor = true;
            // 
            // rbApproved
            // 
            rbApproved.AutoSize = true;
            rbApproved.Font = new Font("Segoe UI", 10F);
            rbApproved.ForeColor = Color.FromArgb(44, 62, 80);
            rbApproved.Location = new Point(10, 65);
            rbApproved.Name = "rbApproved";
            rbApproved.Size = new Size(87, 23);
            rbApproved.TabIndex = 1;
            rbApproved.TabStop = true;
            rbApproved.Text = "Approved";
            rbApproved.UseVisualStyleBackColor = true;
            // 
            // rbPending
            // 
            rbPending.AutoSize = true;
            rbPending.Checked = true;
            rbPending.Font = new Font("Segoe UI", 10F);
            rbPending.ForeColor = Color.FromArgb(44, 62, 80);
            rbPending.Location = new Point(10, 40);
            rbPending.Name = "rbPending";
            rbPending.Size = new Size(76, 23);
            rbPending.TabIndex = 0;
            rbPending.TabStop = true;
            rbPending.Text = "Pending";
            rbPending.UseVisualStyleBackColor = true;
            // 
            // actionButtonsPanel
            // 
            actionButtonsPanel.Controls.Add(DeleteJob);
            actionButtonsPanel.Controls.Add(UpdateJobBtn);
            actionButtonsPanel.Controls.Add(btnCreateNewJob);
            actionButtonsPanel.Dock = DockStyle.Bottom;
            actionButtonsPanel.Location = new Point(15, 541);
            actionButtonsPanel.Name = "actionButtonsPanel";
            actionButtonsPanel.Size = new Size(400, 45);
            actionButtonsPanel.TabIndex = 2;
            // 
            // DeleteJob
            // 
            DeleteJob.BackColor = Color.FromArgb(231, 76, 60);
            DeleteJob.FlatAppearance.BorderSize = 0;
            DeleteJob.FlatStyle = FlatStyle.Flat;
            DeleteJob.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            DeleteJob.ForeColor = Color.White;
            DeleteJob.Location = new Point(270, 5);
            DeleteJob.Name = "DeleteJob";
            DeleteJob.Size = new Size(120, 35);
            DeleteJob.TabIndex = 2;
            DeleteJob.Text = "🗑️ Delete Job";
            DeleteJob.UseVisualStyleBackColor = false;
            DeleteJob.Click += DeleteJob_Click;
            // 
            // UpdateJobBtn
            // 
            UpdateJobBtn.BackColor = Color.FromArgb(46, 204, 113);
            UpdateJobBtn.FlatAppearance.BorderSize = 0;
            UpdateJobBtn.FlatStyle = FlatStyle.Flat;
            UpdateJobBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            UpdateJobBtn.ForeColor = Color.White;
            UpdateJobBtn.Location = new Point(140, 5);
            UpdateJobBtn.Name = "UpdateJobBtn";
            UpdateJobBtn.Size = new Size(120, 35);
            UpdateJobBtn.TabIndex = 1;
            UpdateJobBtn.Text = "✏️ Update Job";
            UpdateJobBtn.UseVisualStyleBackColor = false;
            UpdateJobBtn.Click += UpdateJobBtn_Click;
            // 
            // btnCreateNewJob
            // 
            btnCreateNewJob.BackColor = Color.FromArgb(52, 152, 219);
            btnCreateNewJob.FlatAppearance.BorderSize = 0;
            btnCreateNewJob.FlatStyle = FlatStyle.Flat;
            btnCreateNewJob.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCreateNewJob.ForeColor = Color.White;
            btnCreateNewJob.Location = new Point(10, 5);
            btnCreateNewJob.Name = "btnCreateNewJob";
            btnCreateNewJob.Size = new Size(120, 35);
            btnCreateNewJob.TabIndex = 0;
            btnCreateNewJob.Text = "➕ Add New Job";
            btnCreateNewJob.UseVisualStyleBackColor = false;
            btnCreateNewJob.Click += btnCreateNewJob_Click;
            // 
            // jobFormPanel
            // 
            jobFormPanel.Controls.Add(TbAmount);
            jobFormPanel.Controls.Add(label10);
            jobFormPanel.Controls.Add(TbNotes);
            jobFormPanel.Controls.Add(label4);
            jobFormPanel.Controls.Add(RbCash);
            jobFormPanel.Controls.Add(RbCard);
            jobFormPanel.Controls.Add(label11);
            jobFormPanel.Controls.Add(TbWeight);
            jobFormPanel.Controls.Add(label5);
            jobFormPanel.Controls.Add(NuDQuentity);
            jobFormPanel.Controls.Add(label6);
            jobFormPanel.Controls.Add(CbProducts);
            jobFormPanel.Controls.Add(label7);
            jobFormPanel.Controls.Add(DTRequestDate);
            jobFormPanel.Controls.Add(label8);
            jobFormPanel.Controls.Add(tbDestination);
            jobFormPanel.Controls.Add(label9);
            jobFormPanel.Controls.Add(tbStartLocation);
            jobFormPanel.Controls.Add(label12);
            jobFormPanel.Dock = DockStyle.Top;
            jobFormPanel.Location = new Point(15, 60);
            jobFormPanel.Name = "jobFormPanel";
            jobFormPanel.Size = new Size(400, 360);
            jobFormPanel.TabIndex = 1;
            // 
            // TbAmount
            // 
            TbAmount.BackColor = Color.FromArgb(248, 249, 250);
            TbAmount.BorderStyle = BorderStyle.FixedSingle;
            TbAmount.Font = new Font("Segoe UI", 10F);
            TbAmount.ForeColor = Color.FromArgb(127, 140, 141);
            TbAmount.Location = new Point(120, 285);
            TbAmount.Name = "TbAmount";
            TbAmount.ReadOnly = true;
            TbAmount.Size = new Size(270, 25);
            TbAmount.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(44, 62, 80);
            label10.Location = new Point(10, 287);
            label10.Name = "label10";
            label10.Size = new Size(84, 19);
            label10.TabIndex = 17;
            label10.Text = "Amount ($)";
            // 
            // TbNotes
            // 
            TbNotes.BackColor = Color.White;
            TbNotes.BorderStyle = BorderStyle.FixedSingle;
            TbNotes.Font = new Font("Segoe UI", 10F);
            TbNotes.ForeColor = Color.FromArgb(44, 62, 80);
            TbNotes.Location = new Point(120, 320);
            TbNotes.Multiline = true;
            TbNotes.Name = "TbNotes";
            TbNotes.Size = new Size(270, 30);
            TbNotes.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(44, 62, 80);
            label4.Location = new Point(10, 322);
            label4.Name = "label4";
            label4.Size = new Size(48, 19);
            label4.TabIndex = 15;
            label4.Text = "Notes";
            // 
            // RbCash
            // 
            RbCash.AutoSize = true;
            RbCash.Font = new Font("Segoe UI", 9F);
            RbCash.ForeColor = Color.FromArgb(44, 62, 80);
            RbCash.Location = new Point(200, 250);
            RbCash.Name = "RbCash";
            RbCash.Size = new Size(51, 19);
            RbCash.TabIndex = 14;
            RbCash.TabStop = true;
            RbCash.Text = "Cash";
            RbCash.UseVisualStyleBackColor = true;
            // 
            // RbCard
            // 
            RbCard.AutoSize = true;
            RbCard.Font = new Font("Segoe UI", 9F);
            RbCard.ForeColor = Color.FromArgb(44, 62, 80);
            RbCard.Location = new Point(120, 250);
            RbCard.Name = "RbCard";
            RbCard.Size = new Size(50, 19);
            RbCard.TabIndex = 13;
            RbCard.TabStop = true;
            RbCard.Text = "Card";
            RbCard.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(44, 62, 80);
            label11.Location = new Point(10, 252);
            label11.Name = "label11";
            label11.Size = new Size(68, 19);
            label11.TabIndex = 12;
            label11.Text = "Payment";
            // 
            // TbWeight
            // 
            TbWeight.BackColor = Color.White;
            TbWeight.BorderStyle = BorderStyle.FixedSingle;
            TbWeight.Font = new Font("Segoe UI", 10F);
            TbWeight.ForeColor = Color.FromArgb(44, 62, 80);
            TbWeight.Location = new Point(120, 215);
            TbWeight.Name = "TbWeight";
            TbWeight.Size = new Size(270, 25);
            TbWeight.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(44, 62, 80);
            label5.Location = new Point(10, 217);
            label5.Name = "label5";
            label5.Size = new Size(99, 19);
            label5.TabIndex = 10;
            label5.Text = "Weight (tons)";
            // 
            // NuDQuentity
            // 
            NuDQuentity.BackColor = Color.White;
            NuDQuentity.BorderStyle = BorderStyle.FixedSingle;
            NuDQuentity.Font = new Font("Segoe UI", 10F);
            NuDQuentity.ForeColor = Color.FromArgb(44, 62, 80);
            NuDQuentity.Location = new Point(120, 180);
            NuDQuentity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            NuDQuentity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NuDQuentity.Name = "NuDQuentity";
            NuDQuentity.Size = new Size(270, 25);
            NuDQuentity.TabIndex = 9;
            NuDQuentity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(44, 62, 80);
            label6.Location = new Point(10, 182);
            label6.Name = "label6";
            label6.Size = new Size(66, 19);
            label6.TabIndex = 8;
            label6.Text = "Quantity";
            // 
            // CbProducts
            // 
            CbProducts.BackColor = Color.White;
            CbProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            CbProducts.FlatStyle = FlatStyle.Flat;
            CbProducts.Font = new Font("Segoe UI", 10F);
            CbProducts.ForeColor = Color.FromArgb(44, 62, 80);
            CbProducts.FormattingEnabled = true;
            CbProducts.Location = new Point(120, 145);
            CbProducts.Name = "CbProducts";
            CbProducts.Size = new Size(270, 25);
            CbProducts.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(44, 62, 80);
            label7.Location = new Point(10, 147);
            label7.Name = "label7";
            label7.Size = new Size(62, 19);
            label7.TabIndex = 6;
            label7.Text = "Product";
            // 
            // DTRequestDate
            // 
            DTRequestDate.CalendarForeColor = Color.FromArgb(44, 62, 80);
            DTRequestDate.CalendarMonthBackground = Color.White;
            DTRequestDate.Font = new Font("Segoe UI", 10F);
            DTRequestDate.Location = new Point(120, 110);
            DTRequestDate.Name = "DTRequestDate";
            DTRequestDate.Size = new Size(270, 25);
            DTRequestDate.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(44, 62, 80);
            label8.Location = new Point(10, 112);
            label8.Name = "label8";
            label8.Size = new Size(97, 19);
            label8.TabIndex = 4;
            label8.Text = "Request Date";
            // 
            // tbDestination
            // 
            tbDestination.BackColor = Color.White;
            tbDestination.BorderStyle = BorderStyle.FixedSingle;
            tbDestination.Font = new Font("Segoe UI", 10F);
            tbDestination.ForeColor = Color.FromArgb(44, 62, 80);
            tbDestination.Location = new Point(120, 75);
            tbDestination.Name = "tbDestination";
            tbDestination.Size = new Size(270, 25);
            tbDestination.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(44, 62, 80);
            label9.Location = new Point(10, 77);
            label9.Name = "label9";
            label9.Size = new Size(84, 19);
            label9.TabIndex = 2;
            label9.Text = "Destination";
            // 
            // tbStartLocation
            // 
            tbStartLocation.BackColor = Color.White;
            tbStartLocation.BorderStyle = BorderStyle.FixedSingle;
            tbStartLocation.Font = new Font("Segoe UI", 10F);
            tbStartLocation.ForeColor = Color.FromArgb(44, 62, 80);
            tbStartLocation.Location = new Point(120, 40);
            tbStartLocation.Name = "tbStartLocation";
            tbStartLocation.Size = new Size(270, 25);
            tbStartLocation.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label12.ForeColor = Color.FromArgb(44, 62, 80);
            label12.Location = new Point(10, 42);
            label12.Name = "label12";
            label12.Size = new Size(102, 19);
            label12.TabIndex = 0;
            label12.Text = "Start Location";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(25, 42, 86);
            panel2.Controls.Add(label13);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(15, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 45);
            panel2.TabIndex = 0;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label13.ForeColor = Color.White;
            label13.Location = new Point(140, 12);
            label13.Name = "label13";
            label13.Size = new Size(167, 25);
            label13.TabIndex = 0;
            label13.Text = "Job Management";
            // 
            // ViewJobs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(1200, 701);
            Controls.Add(mainContainer);
            Controls.Add(panel1);
            Name = "ViewJobs";
            Text = "View Jobs - eShift Admin Portal";
            Load += ViewJobs_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            mainContainer.ResumeLayout(false);
            searchPanel.ResumeLayout(false);
            searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contentPanel.ResumeLayout(false);
            jobsViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)viewJobsDt).EndInit();
            jobManagementPanel.ResumeLayout(false);
            statusPanel.ResumeLayout(false);
            statusPanel.PerformLayout();
            actionButtonsPanel.ResumeLayout(false);
            jobFormPanel.ResumeLayout(false);
            jobFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NuDQuentity).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel mainContainer;
        private Panel searchPanel;
        private TextBox tbSearch;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private ComboBox CbStatus;
        private ComboBox CbPaymentStatus;
        private Button button1;
        private Panel contentPanel;
        private Panel jobsViewPanel;
        private DataGridView viewJobsDt;
        private Panel jobManagementPanel;
        private Panel panel2;
        private Label label13;
        private Panel jobFormPanel;
        private Label label12;
        private TextBox tbStartLocation;
        private TextBox tbDestination;
        private Label label9;
        private DateTimePicker DTRequestDate;
        private Label label8;
        private ComboBox CbProducts;
        private Label label7;
        private NumericUpDown NuDQuentity;
        private Label label6;
        private TextBox TbWeight;
        private Label label5;
        private RadioButton RbCash;
        private RadioButton RbCard;
        private Label label11;
        private TextBox TbNotes;
        private Label label4;
        private TextBox TbAmount;
        private Label label10;
        private Panel actionButtonsPanel;
        private Button btnCreateNewJob;
        private Button UpdateJobBtn;
        private Button DeleteJob;
        private Panel statusPanel;
        private RadioButton rbPending;
        private RadioButton rbApproved;
        private RadioButton rbCompleted;
        private RadioButton rbPaymentPending;
        private RadioButton rbPaymentPaid;
        private Label label14;
        private Label label15;
    }
}