namespace Eshift.Forms.Admin
{
    partial class Assistants
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
            DtTable = new Label();
            panel2 = new Panel();
            DtTableAssistants = new DataGridView();
            Clear = new Button();
            Update = new Button();
            delete = new Button();
            Add = new Button();
            tbPhone = new TextBox();
            tbName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtTableAssistants).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(DtTable);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 68);
            panel1.TabIndex = 10;
            // 
            // DtTable
            // 
            DtTable.AutoSize = true;
            DtTable.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DtTable.Location = new Point(356, 19);
            DtTable.Name = "DtTable";
            DtTable.Size = new Size(199, 25);
            DtTable.TabIndex = 0;
            DtTable.Text = "Manage Assistants";
            DtTable.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(DtTableAssistants);
            panel2.Location = new Point(32, 117);
            panel2.Name = "panel2";
            panel2.Size = new Size(867, 307);
            panel2.TabIndex = 11;
            // 
            // DtTableAssistants
            // 
            DtTableAssistants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtTableAssistants.Dock = DockStyle.Fill;
            DtTableAssistants.Location = new Point(0, 0);
            DtTableAssistants.Name = "DtTableAssistants";
            DtTableAssistants.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtTableAssistants.Size = new Size(867, 307);
            DtTableAssistants.TabIndex = 0;
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
            Add.Location = new Point(223, 642);
            Add.Name = "Add";
            Add.Size = new Size(233, 38);
            Add.TabIndex = 15;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = false;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(223, 573);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(233, 23);
            tbPhone.TabIndex = 13;
            // 
            // tbName
            // 
            tbName.Location = new Point(223, 534);
            tbName.Name = "tbName";
            tbName.Size = new Size(233, 23);
            tbName.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 11.9999981F);
            label1.Location = new Point(158, 572);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 19;
            label1.Text = "Phone";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono", 11.9999981F);
            label2.Location = new Point(158, 536);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 20;
            label2.Text = "Name";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // Assistants
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 701);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(Clear);
            Controls.Add(Update);
            Controls.Add(delete);
            Controls.Add(Add);
            Controls.Add(tbPhone);
            Controls.Add(tbName);
            Name = "Assistants";
            Text = "Assistants";
            Load += Assistants_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DtTableAssistants).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label DtTable;
        private Panel panel2;
        private DataGridView DtTableAssistants;
        private Button Clear;
        private Button Update;
        private Button delete;
        private Button Add;
        private TextBox tbPhone;
        private TextBox tbName;
        private Label label1;
        private Label label2;
    }
}