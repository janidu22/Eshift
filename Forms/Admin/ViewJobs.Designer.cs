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
            panel1 = new Panel();
            label1 = new Label();
            tbSearch = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            viewJobsDt = new DataGridView();
            button1 = new Button();
            CbStatus = new ComboBox();
            CbPaymentStatus = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            btnCreateNewJob = new Button();
            RbCash = new RadioButton();
            RbCard = new RadioButton();
            CbProducts = new ComboBox();
            NuDQuentity = new NumericUpDown();
            DTRequestDate = new DateTimePicker();
            TbAmount = new TextBox();
            TbNotes = new TextBox();
            TbWeight = new TextBox();
            tbDestination = new TextBox();
            tbStartLocation = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            DeleteJob = new Button();
            UpdateJobBtn = new Button();
            rbPending = new RadioButton();
            rbCompleted = new RadioButton();
            rbApproved = new RadioButton();
            rbPaymentPending = new RadioButton();
            rbPaymentPaid = new RadioButton();
            label14 = new Label();
            label15 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewJobsDt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NuDQuentity).BeginInit();
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
            panel1.Size = new Size(1089, 36);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(481, 9);
            label1.Name = "label1";
            label1.Size = new Size(90, 19);
            label1.TabIndex = 1;
            label1.Text = "View Jobs";
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Segoe UI", 15F);
            tbSearch.Location = new Point(120, 57);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Search Customer Name";
            tbSearch.Size = new Size(793, 34);
            tbSearch.TabIndex = 2;
            tbSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(81, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(viewJobsDt);
            panel2.Location = new Point(444, 274);
            panel2.Name = "panel2";
            panel2.Size = new Size(615, 356);
            panel2.TabIndex = 4;
            // 
            // viewJobsDt
            // 
            viewJobsDt.AllowUserToAddRows = false;
            viewJobsDt.AllowUserToDeleteRows = false;
            viewJobsDt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewJobsDt.Dock = DockStyle.Fill;
            viewJobsDt.Location = new Point(0, 0);
            viewJobsDt.Name = "viewJobsDt";
            viewJobsDt.ReadOnly = true;
            viewJobsDt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            viewJobsDt.Size = new Size(615, 356);
            viewJobsDt.TabIndex = 0;
            viewJobsDt.CellContentClick += viewJobsDt_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(919, 57);
            button1.Name = "button1";
            button1.Size = new Size(80, 34);
            button1.TabIndex = 5;
            button1.Text = "CLEAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // CbStatus
            // 
            CbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            CbStatus.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CbStatus.FormattingEnabled = true;
            CbStatus.Items.AddRange(new object[] { "Pending", "Approved", "Complete", "All" });
            CbStatus.Location = new Point(444, 156);
            CbStatus.Name = "CbStatus";
            CbStatus.Size = new Size(328, 29);
            CbStatus.TabIndex = 6;
            // 
            // CbPaymentStatus
            // 
            CbPaymentStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            CbPaymentStatus.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CbPaymentStatus.FormattingEnabled = true;
            CbPaymentStatus.Items.AddRange(new object[] { "Pending", "Paid" });
            CbPaymentStatus.Location = new Point(444, 229);
            CbPaymentStatus.Name = "CbPaymentStatus";
            CbPaymentStatus.Size = new Size(328, 29);
            CbPaymentStatus.TabIndex = 7;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(443, 196);
            label2.Name = "label2";
            label2.Size = new Size(216, 19);
            label2.TabIndex = 8;
            label2.Text = "Filter by Pament Status";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(444, 122);
            label3.Name = "label3";
            label3.Size = new Size(153, 19);
            label3.TabIndex = 9;
            label3.Text = "Filter by Status";
            // 
            // btnCreateNewJob
            // 
            btnCreateNewJob.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateNewJob.Location = new Point(31, 453);
            btnCreateNewJob.Name = "btnCreateNewJob";
            btnCreateNewJob.Size = new Size(372, 41);
            btnCreateNewJob.TabIndex = 41;
            btnCreateNewJob.Text = "Create New Job";
            btnCreateNewJob.UseVisualStyleBackColor = true;
            btnCreateNewJob.Click += btnCreateNewJob_Click;
            // 
            // RbCash
            // 
            RbCash.AutoSize = true;
            RbCash.Font = new Font("Microsoft Sans Serif", 12F);
            RbCash.Location = new Point(281, 348);
            RbCash.Name = "RbCash";
            RbCash.Size = new Size(64, 24);
            RbCash.TabIndex = 40;
            RbCash.TabStop = true;
            RbCash.Text = "Cash";
            RbCash.UseVisualStyleBackColor = true;
            RbCash.CheckedChanged += RbCash_CheckedChanged;
            // 
            // RbCard
            // 
            RbCard.AutoSize = true;
            RbCard.Font = new Font("Microsoft Sans Serif", 12F);
            RbCard.Location = new Point(214, 348);
            RbCard.Name = "RbCard";
            RbCard.Size = new Size(61, 24);
            RbCard.TabIndex = 39;
            RbCard.TabStop = true;
            RbCard.Text = "Card";
            RbCard.UseVisualStyleBackColor = true;
            // 
            // CbProducts
            // 
            CbProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            CbProducts.Font = new Font("Microsoft Sans Serif", 12F);
            CbProducts.FormattingEnabled = true;
            CbProducts.Location = new Point(214, 240);
            CbProducts.Name = "CbProducts";
            CbProducts.Size = new Size(189, 28);
            CbProducts.TabIndex = 38;
            // 
            // NuDQuentity
            // 
            NuDQuentity.Font = new Font("Microsoft Sans Serif", 12F);
            NuDQuentity.Location = new Point(214, 284);
            NuDQuentity.Name = "NuDQuentity";
            NuDQuentity.Size = new Size(189, 26);
            NuDQuentity.TabIndex = 37;
            // 
            // DTRequestDate
            // 
            DTRequestDate.Font = new Font("Microsoft Sans Serif", 12F);
            DTRequestDate.Location = new Point(214, 207);
            DTRequestDate.Name = "DTRequestDate";
            DTRequestDate.Size = new Size(189, 26);
            DTRequestDate.TabIndex = 36;
            // 
            // TbAmount
            // 
            TbAmount.Font = new Font("Microsoft Sans Serif", 12F);
            TbAmount.Location = new Point(214, 381);
            TbAmount.Name = "TbAmount";
            TbAmount.Size = new Size(189, 26);
            TbAmount.TabIndex = 35;
            // 
            // TbNotes
            // 
            TbNotes.Font = new Font("Microsoft Sans Serif", 12F);
            TbNotes.Location = new Point(214, 419);
            TbNotes.Name = "TbNotes";
            TbNotes.Size = new Size(189, 26);
            TbNotes.TabIndex = 34;
            // 
            // TbWeight
            // 
            TbWeight.Font = new Font("Microsoft Sans Serif", 12F);
            TbWeight.Location = new Point(214, 316);
            TbWeight.Name = "TbWeight";
            TbWeight.Size = new Size(189, 26);
            TbWeight.TabIndex = 33;
            // 
            // tbDestination
            // 
            tbDestination.Font = new Font("Microsoft Sans Serif", 12F);
            tbDestination.Location = new Point(214, 176);
            tbDestination.Name = "tbDestination";
            tbDestination.Size = new Size(189, 26);
            tbDestination.TabIndex = 32;
            // 
            // tbStartLocation
            // 
            tbStartLocation.Font = new Font("Microsoft Sans Serif", 12F);
            tbStartLocation.Location = new Point(214, 144);
            tbStartLocation.Name = "tbStartLocation";
            tbStartLocation.Size = new Size(189, 26);
            tbStartLocation.TabIndex = 31;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("JetBrains Mono", 11.9999981F);
            label10.Location = new Point(28, 381);
            label10.Name = "label10";
            label10.Size = new Size(180, 21);
            label10.TabIndex = 30;
            label10.Text = "Amount          :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("JetBrains Mono", 11.9999981F);
            label9.Location = new Point(31, 179);
            label9.Name = "label9";
            label9.Size = new Size(180, 21);
            label9.TabIndex = 29;
            label9.Text = "Destination     :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("JetBrains Mono", 11.9999981F);
            label8.Location = new Point(31, 213);
            label8.Name = "label8";
            label8.Size = new Size(180, 21);
            label8.TabIndex = 28;
            label8.Text = "Requested Date  :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("JetBrains Mono", 11.9999981F);
            label7.Location = new Point(31, 247);
            label7.Name = "label7";
            label7.Size = new Size(180, 21);
            label7.TabIndex = 27;
            label7.Text = "Products/Items  :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("JetBrains Mono", 11.9999981F);
            label6.Location = new Point(31, 284);
            label6.Name = "label6";
            label6.Size = new Size(180, 21);
            label6.TabIndex = 26;
            label6.Text = "Quantity        :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("JetBrains Mono", 11.9999981F);
            label5.Location = new Point(28, 316);
            label5.Name = "label5";
            label5.Size = new Size(180, 21);
            label5.TabIndex = 25;
            label5.Text = "Weight          :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("JetBrains Mono", 11.9999981F);
            label4.Location = new Point(28, 419);
            label4.Name = "label4";
            label4.Size = new Size(180, 21);
            label4.TabIndex = 24;
            label4.Text = "Notes           :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("JetBrains Mono", 11.9999981F);
            label11.Location = new Point(28, 350);
            label11.Name = "label11";
            label11.Size = new Size(180, 21);
            label11.TabIndex = 23;
            label11.Text = "Payment Method  :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("JetBrains Mono", 11.9999981F);
            label12.Location = new Point(31, 147);
            label12.Name = "label12";
            label12.Size = new Size(180, 21);
            label12.TabIndex = 22;
            label12.Text = "Start Location  :";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.BackColor = SystemColors.ActiveCaptionText;
            label13.Font = new Font("JetBrains Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.ImageAlign = ContentAlignment.TopCenter;
            label13.Location = new Point(106, 95);
            label13.Name = "label13";
            label13.Size = new Size(155, 27);
            label13.TabIndex = 42;
            label13.Text = "Add New Job";
            // 
            // DeleteJob
            // 
            DeleteJob.BackColor = Color.IndianRed;
            DeleteJob.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteJob.Location = new Point(226, 630);
            DeleteJob.Name = "DeleteJob";
            DeleteJob.Size = new Size(147, 41);
            DeleteJob.TabIndex = 43;
            DeleteJob.Text = "Delete Job";
            DeleteJob.UseVisualStyleBackColor = false;
            DeleteJob.Click += DeleteJob_Click;
            // 
            // UpdateJobBtn
            // 
            UpdateJobBtn.BackColor = Color.SpringGreen;
            UpdateJobBtn.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateJobBtn.Location = new Point(28, 630);
            UpdateJobBtn.Name = "UpdateJobBtn";
            UpdateJobBtn.Size = new Size(161, 41);
            UpdateJobBtn.TabIndex = 44;
            UpdateJobBtn.Text = "Update Job";
            UpdateJobBtn.UseVisualStyleBackColor = false;
            UpdateJobBtn.Click += UpdateJobBtn_Click;
            // 
            // rbPending
            // 
            rbPending.AutoSize = true;
            rbPending.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rbPending.Location = new Point(31, 543);
            rbPending.Name = "rbPending";
            rbPending.Size = new Size(70, 19);
            rbPending.TabIndex = 45;
            rbPending.TabStop = true;
            rbPending.Text = "Pending";
            rbPending.UseVisualStyleBackColor = true;
            // 
            // rbCompleted
            // 
            rbCompleted.AutoSize = true;
            rbCompleted.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rbCompleted.Location = new Point(30, 593);
            rbCompleted.Name = "rbCompleted";
            rbCompleted.Size = new Size(86, 19);
            rbCompleted.TabIndex = 46;
            rbCompleted.TabStop = true;
            rbCompleted.Text = "Completed";
            rbCompleted.UseVisualStyleBackColor = true;
            // 
            // rbApproved
            // 
            rbApproved.AutoSize = true;
            rbApproved.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rbApproved.Location = new Point(31, 567);
            rbApproved.Name = "rbApproved";
            rbApproved.Size = new Size(80, 19);
            rbApproved.TabIndex = 48;
            rbApproved.TabStop = true;
            rbApproved.Text = "Approved";
            rbApproved.UseVisualStyleBackColor = true;
            // 
            // rbPaymentPending
            // 
            rbPaymentPending.AutoSize = true;
            rbPaymentPending.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rbPaymentPending.Location = new Point(226, 543);
            rbPaymentPending.Name = "rbPaymentPending";
            rbPaymentPending.Size = new Size(70, 19);
            rbPaymentPending.TabIndex = 49;
            rbPaymentPending.TabStop = true;
            rbPaymentPending.Text = "Pending";
            rbPaymentPending.UseVisualStyleBackColor = true;
            // 
            // rbPaymentPaid
            // 
            rbPaymentPaid.AutoSize = true;
            rbPaymentPaid.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rbPaymentPaid.Location = new Point(226, 567);
            rbPaymentPaid.Name = "rbPaymentPaid";
            rbPaymentPaid.Size = new Size(48, 19);
            rbPaymentPaid.TabIndex = 50;
            rbPaymentPaid.TabStop = true;
            rbPaymentPaid.Text = "Paid";
            rbPaymentPaid.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.BackColor = SystemColors.ActiveCaptionText;
            label14.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.ImageAlign = ContentAlignment.TopCenter;
            label14.Location = new Point(214, 496);
            label14.Name = "label14";
            label14.Size = new Size(150, 21);
            label14.TabIndex = 51;
            label14.Text = "Payment Status";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.AutoSize = true;
            label15.BackColor = SystemColors.ActiveCaptionText;
            label15.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.White;
            label15.ImageAlign = ContentAlignment.TopCenter;
            label15.Location = new Point(30, 496);
            label15.Name = "label15";
            label15.Size = new Size(110, 21);
            label15.TabIndex = 52;
            label15.Text = "Job Status";
            // 
            // ViewJobs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 719);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(rbPaymentPaid);
            Controls.Add(rbPaymentPending);
            Controls.Add(rbApproved);
            Controls.Add(UpdateJobBtn);
            Controls.Add(rbCompleted);
            Controls.Add(rbPending);
            Controls.Add(DeleteJob);
            Controls.Add(label13);
            Controls.Add(btnCreateNewJob);
            Controls.Add(RbCash);
            Controls.Add(RbCard);
            Controls.Add(CbProducts);
            Controls.Add(NuDQuentity);
            Controls.Add(DTRequestDate);
            Controls.Add(TbAmount);
            Controls.Add(TbNotes);
            Controls.Add(TbWeight);
            Controls.Add(tbDestination);
            Controls.Add(tbStartLocation);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(CbPaymentStatus);
            Controls.Add(CbStatus);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(tbSearch);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "ViewJobs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewJobs";
            Load += ViewJobs_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)viewJobsDt).EndInit();
            ((System.ComponentModel.ISupportInitialize)NuDQuentity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox tbSearch;
        private PictureBox pictureBox1;
        private Panel panel2;
        private DataGridView viewJobsDt;
        private Button button1;
        private ComboBox CbStatus;
        private ComboBox CbPaymentStatus;
        private Label label2;
        private Label label3;
        private Button btnCreateNewJob;
        private RadioButton RbCash;
        private RadioButton RbCard;
        private ComboBox CbProducts;
        private NumericUpDown NuDQuentity;
        private DateTimePicker DTRequestDate;
        private TextBox TbAmount;
        private TextBox TbNotes;
        private TextBox TbWeight;
        private TextBox tbDestination;
        private TextBox tbStartLocation;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button DeleteJob;
        private Button UpdateJobBtn;
        private RadioButton rbPending;
        private RadioButton rbCompleted;
        private RadioButton rbApproved;
        private RadioButton rbPaymentPending;
        private RadioButton rbPaymentPaid;
        private Label label14;
        private Label label15;
    }
}