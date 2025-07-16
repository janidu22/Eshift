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
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            cbJobs = new ComboBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            DataPanel = new Panel();
            dgvLoads = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cbProducts = new ComboBox();
            cbTransportUnits = new ComboBox();
            nudQuantity = new NumericUpDown();
            tbWeight = new TextBox();
            tbNotes = new TextBox();
            AddLoads = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            DataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoads).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(793, -20);
            label1.Name = "label1";
            label1.Size = new Size(126, 19);
            label1.TabIndex = 1;
            label1.Text = "Manage Admins";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.Navy;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(933, 31);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(412, 8);
            label2.Name = "label2";
            label2.Size = new Size(117, 19);
            label2.TabIndex = 2;
            label2.Text = "Manage Loads";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(286, 62);
            label3.Name = "label3";
            label3.Size = new Size(364, 25);
            label3.TabIndex = 3;
            label3.Text = "Assign loads to jobs uisng drops";
            // 
            // cbJobs
            // 
            cbJobs.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbJobs.Cursor = Cursors.Hand;
            cbJobs.DropDownStyle = ComboBoxStyle.DropDownList;
            cbJobs.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbJobs.FormattingEnabled = true;
            cbJobs.Location = new Point(26, 90);
            cbJobs.Name = "cbJobs";
            cbJobs.Size = new Size(881, 29);
            cbJobs.TabIndex = 4;
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
            // DataPanel
            // 
            DataPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DataPanel.BackColor = SystemColors.Control;
            DataPanel.Controls.Add(dgvLoads);
            DataPanel.Location = new Point(26, 127);
            DataPanel.Name = "DataPanel";
            DataPanel.Size = new Size(881, 189);
            DataPanel.TabIndex = 5;
            // 
            // dgvLoads
            // 
            dgvLoads.AllowUserToAddRows = false;
            dgvLoads.AllowUserToDeleteRows = false;
            dgvLoads.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoads.Dock = DockStyle.Fill;
            dgvLoads.Location = new Point(0, 0);
            dgvLoads.Name = "dgvLoads";
            dgvLoads.ReadOnly = true;
            dgvLoads.Size = new Size(881, 189);
            dgvLoads.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 343);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 6;
            label4.Text = "Product";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 465);
            label5.Name = "label5";
            label5.Size = new Size(140, 21);
            label5.TabIndex = 7;
            label5.Text = " Weight (kg):";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(26, 427);
            label6.Name = "label6";
            label6.Size = new Size(90, 21);
            label6.TabIndex = 8;
            label6.Text = "Quantity";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(26, 388);
            label7.Name = "label7";
            label7.Size = new Size(150, 21);
            label7.TabIndex = 9;
            label7.Text = "Transport Unit";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(26, 509);
            label8.Name = "label8";
            label8.Size = new Size(60, 21);
            label8.TabIndex = 10;
            label8.Text = "Notes";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbProducts
            // 
            cbProducts.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbProducts.FormattingEnabled = true;
            cbProducts.Location = new Point(175, 340);
            cbProducts.Name = "cbProducts";
            cbProducts.Size = new Size(712, 28);
            cbProducts.TabIndex = 11;
            // 
            // cbTransportUnits
            // 
            cbTransportUnits.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTransportUnits.FormattingEnabled = true;
            cbTransportUnits.Location = new Point(173, 385);
            cbTransportUnits.Name = "cbTransportUnits";
            cbTransportUnits.Size = new Size(714, 28);
            cbTransportUnits.TabIndex = 12;
            // 
            // nudQuantity
            // 
            nudQuantity.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudQuantity.Location = new Point(173, 425);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(714, 26);
            nudQuantity.TabIndex = 13;
            // 
            // tbWeight
            // 
            tbWeight.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbWeight.Location = new Point(173, 465);
            tbWeight.Name = "tbWeight";
            tbWeight.Size = new Size(714, 26);
            tbWeight.TabIndex = 14;
            // 
            // tbNotes
            // 
            tbNotes.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNotes.Location = new Point(173, 504);
            tbNotes.Name = "tbNotes";
            tbNotes.Size = new Size(714, 26);
            tbNotes.TabIndex = 15;
            // 
            // AddLoads
            // 
            AddLoads.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddLoads.ForeColor = Color.Green;
            AddLoads.Location = new Point(175, 557);
            AddLoads.Name = "AddLoads";
            AddLoads.Size = new Size(295, 32);
            AddLoads.TabIndex = 16;
            AddLoads.Text = "Add Loads";
            AddLoads.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Green;
            button1.Location = new Point(635, 559);
            button1.Name = "button1";
            button1.Size = new Size(114, 32);
            button1.TabIndex = 17;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(487, 559);
            button2.Name = "button2";
            button2.Size = new Size(130, 32);
            button2.TabIndex = 18;
            button2.Text = "Add New";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(192, 0, 0);
            button3.Location = new Point(773, 559);
            button3.Name = "button3";
            button3.Size = new Size(114, 32);
            button3.TabIndex = 19;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // ManageLoads
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 623);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(AddLoads);
            Controls.Add(tbNotes);
            Controls.Add(tbWeight);
            Controls.Add(nudQuantity);
            Controls.Add(cbTransportUnits);
            Controls.Add(cbProducts);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(DataPanel);
            Controls.Add(cbJobs);
            Controls.Add(label3);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            Name = "ManageLoads";
            StartPosition = FormStartPosition.CenterScreen;
            Load += ManageLoads_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            DataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLoads).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private ComboBox cbJobs;
        private ContextMenuStrip contextMenuStrip1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Panel DataPanel;
        private DataGridView dgvLoads;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cbProducts;
        private ComboBox cbTransportUnits;
        private NumericUpDown nudQuantity;
        private TextBox tbWeight;
        private TextBox tbNotes;
        private Button AddLoads;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}