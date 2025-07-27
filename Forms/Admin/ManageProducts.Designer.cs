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
            mainContainer = new Panel();
            contentPanel = new Panel();
            productsViewPanel = new Panel();
            panel2 = new Panel();
            ViewProduct = new DataGridView();
            productManagementPanel = new Panel();
            actionButtonsPanel = new Panel();
            DelBtn = new Button();
            UpdateBtn = new Button();
            ClearBtn = new Button();
            AddBtn = new Button();
            productFormPanel = new Panel();
            TbDesc = new TextBox();
            lblDescription = new Label();
            TbName = new TextBox();
            lblName = new Label();
            panel3 = new Panel();
            label2 = new Label();
            
            panel1.SuspendLayout();
            mainContainer.SuspendLayout();
            contentPanel.SuspendLayout();
            productsViewPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ViewProduct).BeginInit();
            productManagementPanel.SuspendLayout();
            actionButtonsPanel.SuspendLayout();
            productFormPanel.SuspendLayout();
            panel3.SuspendLayout();
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
            label1.Location = new Point(530, 16);
            label1.Name = "label1";
            label1.Size = new Size(200, 32);
            label1.TabIndex = 1;
            label1.Text = "Manage Products";
            
            // 
            // mainContainer
            // 
            mainContainer.BackColor = Color.FromArgb(236, 240, 241);
            mainContainer.Controls.Add(contentPanel);
            mainContainer.Dock = DockStyle.Fill;
            mainContainer.Location = new Point(0, 60);
            mainContainer.Name = "mainContainer";
            mainContainer.Padding = new Padding(20);
            mainContainer.Size = new Size(1200, 640);
            mainContainer.TabIndex = 2;
            
            // 
            // contentPanel
            // 
            contentPanel.Controls.Add(productsViewPanel);
            contentPanel.Controls.Add(productManagementPanel);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(20, 20);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1160, 600);
            contentPanel.TabIndex = 0;
            
            // 
            // productsViewPanel
            // 
            productsViewPanel.BackColor = Color.White;
            productsViewPanel.Controls.Add(panel2);
            productsViewPanel.Dock = DockStyle.Fill;
            productsViewPanel.Location = new Point(0, 0);
            productsViewPanel.Name = "productsViewPanel";
            productsViewPanel.Padding = new Padding(10);
            productsViewPanel.Size = new Size(730, 600);
            productsViewPanel.TabIndex = 0;
            
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(ViewProduct);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(10, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(710, 580);
            panel2.TabIndex = 0;
            
            // 
            // ViewProduct
            // 
            ViewProduct.AllowUserToAddRows = false;
            ViewProduct.AllowUserToDeleteRows = false;
            ViewProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewProduct.BackgroundColor = Color.White;
            ViewProduct.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ViewProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ViewProduct.ColumnHeadersHeight = 40;
            ViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(46, 204, 113);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            ViewProduct.DefaultCellStyle = dataGridViewCellStyle2;
            ViewProduct.Dock = DockStyle.Fill;
            ViewProduct.EnableHeadersVisualStyles = false;
            ViewProduct.GridColor = Color.FromArgb(189, 195, 199);
            ViewProduct.Location = new Point(0, 0);
            ViewProduct.MultiSelect = false;
            ViewProduct.Name = "ViewProduct";
            ViewProduct.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(236, 240, 241);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(46, 204, 113);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            ViewProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            ViewProduct.RowHeadersVisible = false;
            ViewProduct.RowTemplate.Height = 35;
            ViewProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ViewProduct.Size = new Size(710, 580);
            ViewProduct.TabIndex = 0;
            ViewProduct.SelectionChanged += ViewProduct_SelectionChanged;
            
            // 
            // productManagementPanel
            // 
            productManagementPanel.BackColor = Color.White;
            productManagementPanel.Controls.Add(actionButtonsPanel);
            productManagementPanel.Controls.Add(productFormPanel);
            productManagementPanel.Controls.Add(panel3);
            productManagementPanel.Dock = DockStyle.Right;
            productManagementPanel.Location = new Point(730, 0);
            productManagementPanel.Name = "productManagementPanel";
            productManagementPanel.Padding = new Padding(15);
            productManagementPanel.Size = new Size(430, 600);
            productManagementPanel.TabIndex = 1;
            
            // 
            // actionButtonsPanel
            // 
            actionButtonsPanel.Controls.Add(DelBtn);
            actionButtonsPanel.Controls.Add(UpdateBtn);
            actionButtonsPanel.Controls.Add(ClearBtn);
            actionButtonsPanel.Controls.Add(AddBtn);
            actionButtonsPanel.Dock = DockStyle.Bottom;
            actionButtonsPanel.Location = new Point(15, 540);
            actionButtonsPanel.Name = "actionButtonsPanel";
            actionButtonsPanel.Size = new Size(400, 45);
            actionButtonsPanel.TabIndex = 2;
            
            // 
            // DelBtn
            // 
            DelBtn.BackColor = Color.FromArgb(231, 76, 60);
            DelBtn.FlatAppearance.BorderSize = 0;
            DelBtn.FlatStyle = FlatStyle.Flat;
            DelBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            DelBtn.ForeColor = Color.White;
            DelBtn.Location = new Point(300, 5);
            DelBtn.Name = "DelBtn";
            DelBtn.Size = new Size(90, 35);
            DelBtn.TabIndex = 3;
            DelBtn.Text = "🗑️ Delete";
            DelBtn.UseVisualStyleBackColor = false;
            DelBtn.Click += DelBtn_Click;
            
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.FromArgb(46, 204, 113);
            UpdateBtn.FlatAppearance.BorderSize = 0;
            UpdateBtn.FlatStyle = FlatStyle.Flat;
            UpdateBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            UpdateBtn.ForeColor = Color.White;
            UpdateBtn.Location = new Point(200, 5);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(90, 35);
            UpdateBtn.TabIndex = 2;
            UpdateBtn.Text = "✏️ Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            
            // 
            // ClearBtn
            // 
            ClearBtn.BackColor = Color.FromArgb(149, 165, 166);
            ClearBtn.FlatAppearance.BorderSize = 0;
            ClearBtn.FlatStyle = FlatStyle.Flat;
            ClearBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ClearBtn.ForeColor = Color.White;
            ClearBtn.Location = new Point(105, 5);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(90, 35);
            ClearBtn.TabIndex = 1;
            ClearBtn.Text = "🧹 Clear";
            ClearBtn.UseVisualStyleBackColor = false;
            ClearBtn.Click += ClearBtn_Click;
            
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.FromArgb(52, 152, 219);
            AddBtn.FlatAppearance.BorderSize = 0;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            AddBtn.ForeColor = Color.White;
            AddBtn.Location = new Point(10, 5);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(90, 35);
            AddBtn.TabIndex = 0;
            AddBtn.Text = "➕ Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            
            // 
            // productFormPanel
            // 
            productFormPanel.Controls.Add(TbDesc);
            productFormPanel.Controls.Add(lblDescription);
            productFormPanel.Controls.Add(TbName);
            productFormPanel.Controls.Add(lblName);
            productFormPanel.Dock = DockStyle.Top;
            productFormPanel.Location = new Point(15, 60);
            productFormPanel.Name = "productFormPanel";
            productFormPanel.Size = new Size(400, 480);
            productFormPanel.TabIndex = 1;
            
            // 
            // TbDesc
            // 
            TbDesc.BackColor = Color.White;
            TbDesc.BorderStyle = BorderStyle.FixedSingle;
            TbDesc.Font = new Font("Segoe UI", 11F);
            TbDesc.ForeColor = Color.FromArgb(44, 62, 80);
            TbDesc.Location = new Point(120, 130);
            TbDesc.Multiline = true;
            TbDesc.Name = "TbDesc";
            TbDesc.Size = new Size(270, 120);
            TbDesc.TabIndex = 3;
            
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDescription.ForeColor = Color.FromArgb(44, 62, 80);
            lblDescription.Location = new Point(10, 132);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(89, 20);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description";
            
            // 
            // TbName
            // 
            TbName.BackColor = Color.White;
            TbName.BorderStyle = BorderStyle.FixedSingle;
            TbName.Font = new Font("Segoe UI", 11F);
            TbName.ForeColor = Color.FromArgb(44, 62, 80);
            TbName.Location = new Point(120, 60);
            TbName.Name = "TbName";
            TbName.Size = new Size(270, 27);
            TbName.TabIndex = 1;
            
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(44, 62, 80);
            lblName.Location = new Point(10, 62);
            lblName.Name = "lblName";
            lblName.Size = new Size(104, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Product Name";
            
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(25, 42, 86);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(15, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(400, 45);
            panel3.TabIndex = 0;
            
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(125, 12);
            label2.Name = "label2";
            label2.Size = new Size(184, 25);
            label2.TabIndex = 0;
            label2.Text = "Product Management";
            
            // 
            // ManageProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(1200, 700);
            Controls.Add(mainContainer);
            Controls.Add(panel1);
            Name = "ManageProducts";
            Text = "Manage Products - eShift Admin Portal";
            Load += ManageProducts_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            mainContainer.ResumeLayout(false);
            contentPanel.ResumeLayout(false);
            productsViewPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ViewProduct).EndInit();
            productManagementPanel.ResumeLayout(false);
            actionButtonsPanel.ResumeLayout(false);
            productFormPanel.ResumeLayout(false);
            productFormPanel.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel mainContainer;
        private Panel contentPanel;
        private Panel productsViewPanel;
        private Panel panel2;
        private DataGridView ViewProduct;
        private Panel productManagementPanel;
        private Panel panel3;
        private Label label2;
        private Panel productFormPanel;
        private Label lblName;
        private TextBox TbName;
        private Label lblDescription;
        private TextBox TbDesc;
        private Panel actionButtonsPanel;
        private Button AddBtn;
        private Button ClearBtn;
        private Button UpdateBtn;
        private Button DelBtn;
    }
}