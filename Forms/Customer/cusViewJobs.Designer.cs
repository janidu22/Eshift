namespace Eshift.Forms.Customer
{
    partial class cusViewJobs
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
            label1 = new Label();
            viewJobsDt = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewJobsDt).BeginInit();
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
            label1.Size = new Size(207, 32);
            label1.TabIndex = 1;
            label1.Text = "My Job Requests";
            // 
            // viewJobsDt
            // 
            viewJobsDt.AllowUserToAddRows = false;
            viewJobsDt.AllowUserToDeleteRows = false;
            viewJobsDt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            viewJobsDt.Location = new Point(0, 60);
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
            viewJobsDt.Size = new Size(1099, 669);
            viewJobsDt.TabIndex = 2;
            viewJobsDt.CellContentClick += viewJobsDt_CellContentClick;
            // 
            // cusViewJobs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(1099, 729);
            Controls.Add(viewJobsDt);
            Controls.Add(panel1);
            Name = "cusViewJobs";
            Text = "My Jobs - eShift Customer Portal";
            Load += cusViewJobs_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)viewJobsDt).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView viewJobsDt;
    }
}