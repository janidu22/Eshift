namespace Eshift.Forms.Admin
{
    partial class Containers
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
            delete = new Button();
            Add = new Button();
            NudCapacity = new NumericUpDown();
            tbType = new TextBox();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudCapacity).BeginInit();
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
            label1.Location = new Point(356, 19);
            label1.Name = "label1";
            label1.Size = new Size(199, 25);
            label1.TabIndex = 0;
            label1.Text = "Manage Containers";
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
            Clear.Click += Clear_Click_1;
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
            // 
            // delete
            // 
            delete.BackColor = Color.DarkRed;
            delete.Font = new Font("JetBrains Mono", 14.25F);
            delete.Location = new Point(810, 642);
            delete.Name = "delete";
            delete.Size = new Size(89, 38);
            delete.TabIndex = 16;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            // 
            // Add
            // 
            Add.BackColor = Color.SeaGreen;
            Add.Font = new Font("JetBrains Mono", 14.25F);
            Add.Location = new Point(241, 638);
            Add.Name = "Add";
            Add.Size = new Size(233, 38);
            Add.TabIndex = 15;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // NudCapacity
            // 
            NudCapacity.Location = new Point(241, 558);
            NudCapacity.Name = "NudCapacity";
            NudCapacity.Size = new Size(233, 23);
            NudCapacity.TabIndex = 14;
            // 
            // tbType
            // 
            tbType.Location = new Point(241, 513);
            tbType.Name = "tbType";
            tbType.Size = new Size(233, 23);
            tbType.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(145, 512);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 19;
            label2.Text = "Type";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(145, 558);
            label3.Name = "label3";
            label3.Size = new Size(90, 21);
            label3.TabIndex = 20;
            label3.Text = "Capacity";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // Containers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 701);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(Clear);
            Controls.Add(Update);
            Controls.Add(delete);
            Controls.Add(Add);
            Controls.Add(NudCapacity);
            Controls.Add(tbType);
            Name = "Containers";
            Text = "Containers";
            Load += Containers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DtTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudCapacity).EndInit();
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
        private Button delete;
        private Button Add;
        private NumericUpDown NudCapacity;
        private TextBox tbType;
        private Label label2;
        private Label label3;
    }
}