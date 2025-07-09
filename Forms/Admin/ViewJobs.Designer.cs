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
            tbSearch = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            viewJobsDt = new DataGridView();
            button1 = new Button();
            CbStatus = new ComboBox();
            CbPaymentStatus = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewJobsDt).BeginInit();
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
            tbSearch.Location = new Point(120, 58);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Search Customer Name";
            tbSearch.Size = new Size(793, 34);
            tbSearch.TabIndex = 2;
            tbSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(81, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(viewJobsDt);
            panel2.Location = new Point(81, 235);
            panel2.Name = "panel2";
            panel2.Size = new Size(921, 383);
            panel2.TabIndex = 4;
            // 
            // viewJobsDt
            // 
            viewJobsDt.AllowUserToAddRows = false;
            viewJobsDt.AllowUserToDeleteRows = false;
            viewJobsDt.Anchor = AnchorStyles.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            viewJobsDt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            viewJobsDt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            viewJobsDt.DefaultCellStyle = dataGridViewCellStyle2;
            viewJobsDt.Location = new Point(0, 3);
            viewJobsDt.Name = "viewJobsDt";
            viewJobsDt.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            viewJobsDt.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            viewJobsDt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            viewJobsDt.Size = new Size(918, 380);
            viewJobsDt.TabIndex = 0;
            viewJobsDt.CellContentClick += viewJobsDt_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(919, 58);
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
            CbStatus.Location = new Point(120, 156);
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
            CbPaymentStatus.Location = new Point(585, 156);
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
            label2.Location = new Point(585, 120);
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
            label3.Location = new Point(120, 122);
            label3.Name = "label3";
            label3.Size = new Size(153, 19);
            label3.TabIndex = 9;
            label3.Text = "Filter by Status";
            // 
            // ViewJobs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 719);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(CbPaymentStatus);
            Controls.Add(CbStatus);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(tbSearch);
            Controls.Add(panel1);
            Name = "ViewJobs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewJobs";
            Load += ViewJobs_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)viewJobsDt).EndInit();
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
    }
}