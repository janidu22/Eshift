namespace Eshift.Forms.Customer
{
    partial class cusNewJob
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
            centerPanel = new Panel();
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
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            centerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NuDQuentity).BeginInit();
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
            panel1.Size = new Size(1099, 60);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(480, 16);
            label1.Name = "label1";
            label1.Size = new Size(211, 32);
            label1.TabIndex = 1;
            label1.Text = "New Job Request";
            // 
            // centerPanel
            // 
            centerPanel.Anchor = AnchorStyles.None;
            centerPanel.BackColor = Color.FromArgb(236, 240, 241);
            centerPanel.Controls.Add(btnCreateNewJob);
            centerPanel.Controls.Add(RbCash);
            centerPanel.Controls.Add(RbCard);
            centerPanel.Controls.Add(CbProducts);
            centerPanel.Controls.Add(NuDQuentity);
            centerPanel.Controls.Add(DTRequestDate);
            centerPanel.Controls.Add(TbAmount);
            centerPanel.Controls.Add(TbNotes);
            centerPanel.Controls.Add(TbWeight);
            centerPanel.Controls.Add(tbDestination);
            centerPanel.Controls.Add(tbStartLocation);
            centerPanel.Controls.Add(label10);
            centerPanel.Controls.Add(label9);
            centerPanel.Controls.Add(label8);
            centerPanel.Controls.Add(label7);
            centerPanel.Controls.Add(label6);
            centerPanel.Controls.Add(label5);
            centerPanel.Controls.Add(label4);
            centerPanel.Controls.Add(label3);
            centerPanel.Controls.Add(label2);
            centerPanel.Location = new Point(150, 80);
            centerPanel.Name = "centerPanel";
            centerPanel.Size = new Size(800, 600);
            centerPanel.TabIndex = 0;
            // 
            // btnCreateNewJob
            // 
            btnCreateNewJob.BackColor = Color.FromArgb(46, 204, 113);
            btnCreateNewJob.FlatAppearance.BorderSize = 0;
            btnCreateNewJob.FlatStyle = FlatStyle.Flat;
            btnCreateNewJob.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnCreateNewJob.ForeColor = Color.White;
            btnCreateNewJob.Location = new Point(113, 494);
            btnCreateNewJob.Name = "btnCreateNewJob";
            btnCreateNewJob.Size = new Size(507, 50);
            btnCreateNewJob.TabIndex = 21;
            btnCreateNewJob.Text = "Create New Job Request";
            btnCreateNewJob.UseVisualStyleBackColor = false;
            btnCreateNewJob.Click += button1_Click;
            // 
            // RbCash
            // 
            RbCash.AutoSize = true;
            RbCash.Font = new Font("Segoe UI", 11F);
            RbCash.ForeColor = Color.FromArgb(44, 62, 80);
            RbCash.Location = new Point(350, 350);
            RbCash.Name = "RbCash";
            RbCash.Size = new Size(58, 24);
            RbCash.TabIndex = 20;
            RbCash.TabStop = true;
            RbCash.Text = "Cash";
            RbCash.UseVisualStyleBackColor = true;
            // 
            // RbCard
            // 
            RbCard.AutoSize = true;
            RbCard.Font = new Font("Segoe UI", 11F);
            RbCard.ForeColor = Color.FromArgb(44, 62, 80);
            RbCard.Location = new Point(270, 350);
            RbCard.Name = "RbCard";
            RbCard.Size = new Size(58, 24);
            RbCard.TabIndex = 19;
            RbCard.TabStop = true;
            RbCard.Text = "Card";
            RbCard.UseVisualStyleBackColor = true;
            // 
            // CbProducts
            // 
            CbProducts.BackColor = Color.White;
            CbProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            CbProducts.FlatStyle = FlatStyle.Flat;
            CbProducts.Font = new Font("Segoe UI", 12F);
            CbProducts.ForeColor = Color.FromArgb(44, 62, 80);
            CbProducts.FormattingEnabled = true;
            CbProducts.Location = new Point(270, 198);
            CbProducts.Name = "CbProducts";
            CbProducts.Size = new Size(350, 29);
            CbProducts.TabIndex = 18;
            // 
            // NuDQuentity
            // 
            NuDQuentity.BackColor = Color.White;
            NuDQuentity.BorderStyle = BorderStyle.FixedSingle;
            NuDQuentity.Font = new Font("Segoe UI", 12F);
            NuDQuentity.ForeColor = Color.FromArgb(44, 62, 80);
            NuDQuentity.Location = new Point(270, 248);
            NuDQuentity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            NuDQuentity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NuDQuentity.Name = "NuDQuentity";
            NuDQuentity.Size = new Size(350, 29);
            NuDQuentity.TabIndex = 17;
            NuDQuentity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // DTRequestDate
            // 
            DTRequestDate.CalendarForeColor = Color.FromArgb(44, 62, 80);
            DTRequestDate.CalendarMonthBackground = Color.White;
            DTRequestDate.Font = new Font("Segoe UI", 12F);
            DTRequestDate.Location = new Point(270, 158);
            DTRequestDate.Name = "DTRequestDate";
            DTRequestDate.Size = new Size(350, 29);
            DTRequestDate.TabIndex = 16;
            // 
            // TbAmount
            // 
            TbAmount.BackColor = Color.FromArgb(248, 249, 250);
            TbAmount.BorderStyle = BorderStyle.FixedSingle;
            TbAmount.Font = new Font("Segoe UI", 12F);
            TbAmount.ForeColor = Color.FromArgb(127, 140, 141);
            TbAmount.Location = new Point(270, 378);
            TbAmount.Name = "TbAmount";
            TbAmount.ReadOnly = true;
            TbAmount.Size = new Size(350, 29);
            TbAmount.TabIndex = 15;
            // 
            // TbNotes
            // 
            TbNotes.BackColor = Color.White;
            TbNotes.BorderStyle = BorderStyle.FixedSingle;
            TbNotes.Font = new Font("Segoe UI", 12F);
            TbNotes.ForeColor = Color.FromArgb(44, 62, 80);
            TbNotes.Location = new Point(270, 418);
            TbNotes.Multiline = true;
            TbNotes.Name = "TbNotes";
            TbNotes.Size = new Size(350, 60);
            TbNotes.TabIndex = 14;
            // 
            // TbWeight
            // 
            TbWeight.BackColor = Color.White;
            TbWeight.BorderStyle = BorderStyle.FixedSingle;
            TbWeight.Font = new Font("Segoe UI", 12F);
            TbWeight.ForeColor = Color.FromArgb(44, 62, 80);
            TbWeight.Location = new Point(270, 298);
            TbWeight.Name = "TbWeight";
            TbWeight.Size = new Size(350, 29);
            TbWeight.TabIndex = 13;
            // 
            // tbDestination
            // 
            tbDestination.BackColor = Color.White;
            tbDestination.BorderStyle = BorderStyle.FixedSingle;
            tbDestination.Font = new Font("Segoe UI", 12F);
            tbDestination.ForeColor = Color.FromArgb(44, 62, 80);
            tbDestination.Location = new Point(270, 108);
            tbDestination.Name = "tbDestination";
            tbDestination.Size = new Size(350, 29);
            tbDestination.TabIndex = 12;
            // 
            // tbStartLocation
            // 
            tbStartLocation.BackColor = Color.White;
            tbStartLocation.BorderStyle = BorderStyle.FixedSingle;
            tbStartLocation.Font = new Font("Segoe UI", 12F);
            tbStartLocation.ForeColor = Color.FromArgb(44, 62, 80);
            tbStartLocation.Location = new Point(270, 58);
            tbStartLocation.Name = "tbStartLocation";
            tbStartLocation.Size = new Size(350, 29);
            tbStartLocation.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(44, 62, 80);
            label10.Location = new Point(113, 380);
            label10.Name = "label10";
            label10.Size = new Size(97, 21);
            label10.TabIndex = 10;
            label10.Text = "Amount ($)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(44, 62, 80);
            label9.Location = new Point(113, 110);
            label9.Name = "label9";
            label9.Size = new Size(99, 21);
            label9.TabIndex = 9;
            label9.Text = "Destination";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(44, 62, 80);
            label8.Location = new Point(113, 160);
            label8.Name = "label8";
            label8.Size = new Size(130, 21);
            label8.TabIndex = 8;
            label8.Text = "Requested Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(44, 62, 80);
            label7.Location = new Point(113, 200);
            label7.Name = "label7";
            label7.Size = new Size(112, 21);
            label7.TabIndex = 7;
            label7.Text = "Product/Item";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(44, 62, 80);
            label6.Location = new Point(113, 250);
            label6.Name = "label6";
            label6.Size = new Size(77, 21);
            label6.TabIndex = 6;
            label6.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(44, 62, 80);
            label5.Location = new Point(113, 300);
            label5.Name = "label5";
            label5.Size = new Size(115, 21);
            label5.TabIndex = 5;
            label5.Text = "Weight (tons)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(44, 62, 80);
            label4.Location = new Point(113, 420);
            label4.Name = "label4";
            label4.Size = new Size(55, 21);
            label4.TabIndex = 4;
            label4.Text = "Notes";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(44, 62, 80);
            label3.Location = new Point(113, 350);
            label3.Name = "label3";
            label3.Size = new Size(142, 21);
            label3.TabIndex = 3;
            label3.Text = "Payment Method";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(44, 62, 80);
            label2.Location = new Point(113, 60);
            label2.Name = "label2";
            label2.Size = new Size(116, 21);
            label2.TabIndex = 2;
            label2.Text = "Start Location";
            // 
            // cusNewJob
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(1099, 680);
            Controls.Add(centerPanel);
            Controls.Add(panel1);
            Name = "cusNewJob";
            Text = "New Job Request - eShift Customer Portal";
            Load += cusNewJob_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            centerPanel.ResumeLayout(false);
            centerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NuDQuentity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel centerPanel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox tbStartLocation;
        private TextBox tbDestination;
        private TextBox TbWeight;
        private TextBox TbNotes;
        private TextBox TbAmount;
        private DateTimePicker DTRequestDate;
        private NumericUpDown NuDQuentity;
        private ComboBox CbProducts;
        private RadioButton RbCard;
        private RadioButton RbCash;
        private Button btnCreateNewJob;
    }
}