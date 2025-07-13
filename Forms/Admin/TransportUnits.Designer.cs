namespace Eshift.Forms.Admin
{
    partial class Transport_units
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
            panel2 = new Panel();
            DtTable = new DataGridView();
            Clear = new Button();
            Update = new Button();
            Delete = new Button();
            Add = new Button();
            cbLorry = new ComboBox();
            cbContainer = new ComboBox();
            cbAssistant = new ComboBox();
            cbDriver = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtTable).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 68);
            panel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(333, 19);
            label1.Name = "label1";
            label1.Size = new Size(254, 25);
            label1.TabIndex = 0;
            label1.Text = " Manage Transport Unit";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(DtTable);
            panel2.Location = new Point(32, 117);
            panel2.Name = "panel2";
            panel2.Size = new Size(867, 307);
            panel2.TabIndex = 11;
            // 
            // DtTable
            // 
            DtTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtTable.Dock = DockStyle.Fill;
            DtTable.Location = new Point(0, 0);
            DtTable.Name = "DtTable";
            DtTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtTable.Size = new Size(867, 307);
            DtTable.TabIndex = 0;
            DtTable.CellClick += DtTable_CellClick;
            DtTable.CellContentClick += DtTable_CellContentClick;
            DtTable.SelectionChanged += DtTable_SelectionChanged;
            // 
            // Clear
            // 
            Clear.BackColor = Color.PaleGreen;
            Clear.Font = new Font("JetBrains Mono", 14.25F);
            Clear.Location = new Point(528, 642);
            Clear.Name = "Clear";
            Clear.Size = new Size(149, 38);
            Clear.TabIndex = 18;
            Clear.Text = "Add New";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            // 
            // Update
            // 
            Update.BackColor = Color.LightCoral;
            Update.Font = new Font("JetBrains Mono", 14.25F);
            Update.Location = new Point(693, 642);
            Update.Name = "Update";
            Update.Size = new Size(96, 38);
            Update.TabIndex = 17;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = false;
            Update.Click += Update_Click;
            // 
            // Delete
            // 
            Delete.BackColor = Color.DarkRed;
            Delete.Font = new Font("JetBrains Mono", 14.25F);
            Delete.Location = new Point(810, 642);
            Delete.Name = "Delete";
            Delete.Size = new Size(89, 38);
            Delete.TabIndex = 16;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // Add
            // 
            Add.BackColor = Color.SeaGreen;
            Add.Font = new Font("JetBrains Mono", 14.25F);
            Add.Location = new Point(33, 642);
            Add.Name = "Add";
            Add.Size = new Size(233, 38);
            Add.TabIndex = 15;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // cbLorry
            // 
            cbLorry.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLorry.FormattingEnabled = true;
            cbLorry.Location = new Point(144, 478);
            cbLorry.Name = "cbLorry";
            cbLorry.Size = new Size(350, 23);
            cbLorry.TabIndex = 1;
            // 
            // cbContainer
            // 
            cbContainer.FormattingEnabled = true;
            cbContainer.Location = new Point(144, 565);
            cbContainer.Name = "cbContainer";
            cbContainer.Size = new Size(350, 23);
            cbContainer.TabIndex = 19;
            // 
            // cbAssistant
            // 
            cbAssistant.FormattingEnabled = true;
            cbAssistant.Location = new Point(144, 536);
            cbAssistant.Name = "cbAssistant";
            cbAssistant.Size = new Size(350, 23);
            cbAssistant.TabIndex = 20;
            // 
            // cbDriver
            // 
            cbDriver.FormattingEnabled = true;
            cbDriver.Location = new Point(144, 507);
            cbDriver.Name = "cbDriver";
            cbDriver.Size = new Size(350, 23);
            cbDriver.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 480);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 22;
            label2.Text = "Lorry ";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 567);
            label3.Name = "label3";
            label3.Size = new Size(110, 21);
            label3.TabIndex = 23;
            label3.Text = "Container ";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 538);
            label4.Name = "label4";
            label4.Size = new Size(110, 21);
            label4.TabIndex = 24;
            label4.Text = "Assistant ";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(33, 509);
            label5.Name = "label5";
            label5.Size = new Size(80, 21);
            label5.TabIndex = 25;
            label5.Text = "Driver ";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // Transport_units
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 701);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbDriver);
            Controls.Add(cbAssistant);
            Controls.Add(cbContainer);
            Controls.Add(cbLorry);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(Clear);
            Controls.Add(Update);
            Controls.Add(Delete);
            Controls.Add(Add);
            Name = "Transport_units";
            Text = "Transport_units";
            Load += this.Transport_units_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DtTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DataGridView DtTable;
        private Button Clear;
        private Button Update;
        private Button Delete;
        private Button Add;
        private ComboBox cbLorry;
        private ComboBox cbContainer;
        private ComboBox cbAssistant;
        private ComboBox cbDriver;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}