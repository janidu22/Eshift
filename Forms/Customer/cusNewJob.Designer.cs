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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            tbStartLocation = new TextBox();
            tbDestination = new TextBox();
            TbWeight = new TextBox();
            TbNotes = new TextBox();
            TbAmount = new TextBox();
            DTRequestDate = new DateTimePicker();
            NuDQuentity = new NumericUpDown();
            CbProducts = new ComboBox();
            RbCard = new RadioButton();
            RbCash = new RadioButton();
            btnCreateNewJob = new Button();
            panel1.SuspendLayout();
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
            panel1.Size = new Size(1099, 36);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(486, 9);
            label1.Name = "label1";
            label1.Size = new Size(81, 19);
            label1.TabIndex = 1;
            label1.Text = "New Jobs";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono", 15.75F);
            label2.Location = new Point(263, 166);
            label2.Name = "label2";
            label2.Size = new Size(233, 27);
            label2.TabIndex = 2;
            label2.Text = "Start Location  :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("JetBrains Mono", 15.75F);
            label3.Location = new Point(263, 439);
            label3.Name = "label3";
            label3.Size = new Size(233, 27);
            label3.TabIndex = 3;
            label3.Text = "Payment Method  :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("JetBrains Mono", 15.75F);
            label4.Location = new Point(263, 516);
            label4.Name = "label4";
            label4.Size = new Size(233, 27);
            label4.TabIndex = 4;
            label4.Text = "Notes           :";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("JetBrains Mono", 15.75F);
            label5.Location = new Point(263, 394);
            label5.Name = "label5";
            label5.Size = new Size(233, 27);
            label5.TabIndex = 5;
            label5.Text = "Weight          :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("JetBrains Mono", 15.75F);
            label6.Location = new Point(263, 347);
            label6.Name = "label6";
            label6.Size = new Size(233, 27);
            label6.TabIndex = 6;
            label6.Text = "Quantity        :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("JetBrains Mono", 15.75F);
            label7.Location = new Point(263, 303);
            label7.Name = "label7";
            label7.Size = new Size(233, 27);
            label7.TabIndex = 7;
            label7.Text = "Products/Items  :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("JetBrains Mono", 15.75F);
            label8.Location = new Point(263, 260);
            label8.Name = "label8";
            label8.Size = new Size(233, 27);
            label8.TabIndex = 8;
            label8.Text = "Requested Date  :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("JetBrains Mono", 15.75F);
            label9.Location = new Point(263, 212);
            label9.Name = "label9";
            label9.Size = new Size(233, 27);
            label9.TabIndex = 9;
            label9.Text = "Destination     :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("JetBrains Mono", 15.75F);
            label10.Location = new Point(263, 476);
            label10.Name = "label10";
            label10.Size = new Size(233, 27);
            label10.TabIndex = 10;
            label10.Text = "Amount          :";
            // 
            // tbStartLocation
            // 
            tbStartLocation.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbStartLocation.Location = new Point(511, 160);
            tbStartLocation.Name = "tbStartLocation";
            tbStartLocation.Size = new Size(344, 33);
            tbStartLocation.TabIndex = 11;
            // 
            // tbDestination
            // 
            tbDestination.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbDestination.Location = new Point(511, 206);
            tbDestination.Name = "tbDestination";
            tbDestination.Size = new Size(344, 33);
            tbDestination.TabIndex = 12;
            // 
            // TbWeight
            // 
            TbWeight.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbWeight.Location = new Point(511, 388);
            TbWeight.Name = "TbWeight";
            TbWeight.Size = new Size(344, 33);
            TbWeight.TabIndex = 13;
            // 
            // TbNotes
            // 
            TbNotes.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbNotes.Location = new Point(511, 532);
            TbNotes.Name = "TbNotes";
            TbNotes.Size = new Size(344, 33);
            TbNotes.TabIndex = 14;
            // 
            // TbAmount
            // 
            TbAmount.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbAmount.Location = new Point(514, 476);
            TbAmount.Name = "TbAmount";
            TbAmount.Size = new Size(344, 33);
            TbAmount.TabIndex = 15;
            // 
            // DTRequestDate
            // 
            DTRequestDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DTRequestDate.Location = new Point(511, 254);
            DTRequestDate.Name = "DTRequestDate";
            DTRequestDate.Size = new Size(344, 33);
            DTRequestDate.TabIndex = 16;
            // 
            // NuDQuentity
            // 
            NuDQuentity.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NuDQuentity.Location = new Point(511, 341);
            NuDQuentity.Name = "NuDQuentity";
            NuDQuentity.Size = new Size(344, 33);
            NuDQuentity.TabIndex = 17;
            // 
            // CbProducts
            // 
            CbProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            CbProducts.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CbProducts.FormattingEnabled = true;
            CbProducts.Location = new Point(511, 301);
            CbProducts.Name = "CbProducts";
            CbProducts.Size = new Size(347, 33);
            CbProducts.TabIndex = 18;
            // 
            // RbCard
            // 
            RbCard.AutoSize = true;
            RbCard.Location = new Point(514, 447);
            RbCard.Name = "RbCard";
            RbCard.Size = new Size(50, 19);
            RbCard.TabIndex = 19;
            RbCard.TabStop = true;
            RbCard.Text = "Card";
            RbCard.UseVisualStyleBackColor = true;
            // 
            // RbCash
            // 
            RbCash.AutoSize = true;
            RbCash.Location = new Point(570, 447);
            RbCash.Name = "RbCash";
            RbCash.Size = new Size(51, 19);
            RbCash.TabIndex = 20;
            RbCash.TabStop = true;
            RbCash.Text = "Cash";
            RbCash.UseVisualStyleBackColor = true;
            // 
            // btnCreateNewJob
            // 
            btnCreateNewJob.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateNewJob.Location = new Point(263, 585);
            btnCreateNewJob.Name = "btnCreateNewJob";
            btnCreateNewJob.Size = new Size(592, 41);
            btnCreateNewJob.TabIndex = 21;
            btnCreateNewJob.Text = "Create New Job";
            btnCreateNewJob.UseVisualStyleBackColor = true;
            btnCreateNewJob.Click += button1_Click;
            // 
            // cusNewJob
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1099, 729);
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
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "cusNewJob";
            Text = "cusNewJob";
            Load += cusNewJob_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NuDQuentity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
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