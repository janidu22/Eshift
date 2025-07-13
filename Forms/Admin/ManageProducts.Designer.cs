namespace Eshift.Forms.Admin
{
    partial class ManageProducts
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
            panel2 = new Panel();
            ViewProduct = new DataGridView();
            TbName = new TextBox();
            TbDesc = new TextBox();
            AddBtn = new Button();
            ClearBtn = new Button();
            UpdateBtn = new Button();
            DelBtn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ViewProduct).BeginInit();
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
            label1.Size = new Size(144, 19);
            label1.TabIndex = 1;
            label1.Text = "Manage Products";
            // 
            // panel2
            // 
            panel2.Controls.Add(ViewProduct);
            panel2.Location = new Point(106, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(882, 318);
            panel2.TabIndex = 2;
            // 
            // ViewProduct
            // 
            dataGridViewCellStyle1.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ViewProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ViewProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ViewProduct.DefaultCellStyle = dataGridViewCellStyle3;
            ViewProduct.Dock = DockStyle.Fill;
            ViewProduct.Location = new Point(0, 0);
            ViewProduct.Name = "ViewProduct";
            ViewProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ViewProduct.Size = new Size(882, 318);
            ViewProduct.TabIndex = 0;
            ViewProduct.SelectionChanged += ViewProduct_SelectionChanged;
            // 
            // TbName
            // 
            TbName.Font = new Font("JetBrains Mono", 14.25F);
            TbName.Location = new Point(106, 501);
            TbName.Name = "TbName";
            TbName.PlaceholderText = "Product Name";
            TbName.Size = new Size(322, 33);
            TbName.TabIndex = 3;
            // 
            // TbDesc
            // 
            TbDesc.Font = new Font("JetBrains Mono", 14.25F);
            TbDesc.Location = new Point(106, 540);
            TbDesc.Multiline = true;
            TbDesc.Name = "TbDesc";
            TbDesc.PlaceholderText = "Description";
            TbDesc.Size = new Size(322, 67);
            TbDesc.TabIndex = 4;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.DarkGreen;
            AddBtn.Font = new Font("JetBrains Mono", 14.25F);
            AddBtn.ForeColor = Color.White;
            AddBtn.Location = new Point(106, 613);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(322, 45);
            AddBtn.TabIndex = 5;
            AddBtn.Text = "Add Product";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.BackColor = SystemColors.ActiveCaptionText;
            ClearBtn.Font = new Font("JetBrains Mono", 14.25F);
            ClearBtn.ForeColor = Color.White;
            ClearBtn.Location = new Point(780, 520);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(208, 45);
            ClearBtn.TabIndex = 6;
            ClearBtn.Text = "Add New Product";
            ClearBtn.UseVisualStyleBackColor = false;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.LightGreen;
            UpdateBtn.Font = new Font("JetBrains Mono", 14.25F);
            UpdateBtn.Location = new Point(780, 571);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(208, 45);
            UpdateBtn.TabIndex = 7;
            UpdateBtn.Text = "Update Product";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // DelBtn
            // 
            DelBtn.BackColor = Color.DarkRed;
            DelBtn.Font = new Font("JetBrains Mono", 14.25F);
            DelBtn.ForeColor = SystemColors.ControlLightLight;
            DelBtn.Location = new Point(780, 622);
            DelBtn.Name = "DelBtn";
            DelBtn.Size = new Size(208, 45);
            DelBtn.TabIndex = 8;
            DelBtn.Text = "Delete Product";
            DelBtn.UseVisualStyleBackColor = false;
            DelBtn.Click += DelBtn_Click;
            // 
            // ManageProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 719);
            Controls.Add(DelBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(ClearBtn);
            Controls.Add(AddBtn);
            Controls.Add(TbDesc);
            Controls.Add(TbName);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ManageProducts";
            Text = "ManageProducts";
            Load += ManageProducts_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ViewProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DataGridView ViewProduct;
        private TextBox TbName;
        private TextBox TbDesc;
        private Button AddBtn;
        private Button ClearBtn;
        private Button UpdateBtn;
        private Button DelBtn;
    }
}