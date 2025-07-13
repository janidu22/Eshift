namespace Eshift.Forms.Admin
{
    partial class Lorries
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
            tbPlateNumber = new TextBox();
            tbModel = new TextBox();
            NudCapacity = new NumericUpDown();
            Add = new Button();
            Delete = new Button();
            Update = new Button();
            Clear = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
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
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(356, 19);
            label1.Name = "label1";
            label1.Size = new Size(166, 25);
            label1.TabIndex = 0;
            label1.Text = "Manage Lorries";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(DtTable);
            panel2.Location = new Point(32, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(867, 307);
            panel2.TabIndex = 1;
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
            // 
            // tbPlateNumber
            // 
            tbPlateNumber.Location = new Point(168, 476);
            tbPlateNumber.Name = "tbPlateNumber";
            tbPlateNumber.Size = new Size(233, 23);
            tbPlateNumber.TabIndex = 2;
            // 
            // tbModel
            // 
            tbModel.Location = new Point(168, 517);
            tbModel.Name = "tbModel";
            tbModel.Size = new Size(233, 23);
            tbModel.TabIndex = 4;
            // 
            // NudCapacity
            // 
            NudCapacity.Location = new Point(168, 558);
            NudCapacity.Margin = new Padding(4);
            NudCapacity.Name = "NudCapacity";
            NudCapacity.Size = new Size(233, 23);
            NudCapacity.TabIndex = 5;
            // 
            // Add
            // 
            Add.BackColor = Color.SeaGreen;
            Add.Font = new Font("JetBrains Mono", 14.25F);
            Add.Location = new Point(168, 626);
            Add.Name = "Add";
            Add.Size = new Size(233, 38);
            Add.TabIndex = 6;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // Delete
            // 
            Delete.BackColor = Color.DarkRed;
            Delete.Font = new Font("JetBrains Mono", 14.25F);
            Delete.Location = new Point(810, 622);
            Delete.Name = "Delete";
            Delete.Size = new Size(89, 38);
            Delete.TabIndex = 7;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            // 
            // Update
            // 
            Update.BackColor = Color.LightCoral;
            Update.Font = new Font("JetBrains Mono", 14.25F);
            Update.Location = new Point(693, 622);
            Update.Name = "Update";
            Update.Size = new Size(96, 38);
            Update.TabIndex = 8;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = false;
            // 
            // Clear
            // 
            Clear.BackColor = Color.PaleGreen;
            Clear.Font = new Font("JetBrains Mono", 14.25F);
            Clear.Location = new Point(528, 622);
            Clear.Name = "Clear";
            Clear.Size = new Size(149, 38);
            Clear.TabIndex = 9;
            Clear.Text = "Add New";
            Clear.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 478);
            label2.Name = "label2";
            label2.Size = new Size(130, 21);
            label2.TabIndex = 10;
            label2.Text = "Plate Number";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 558);
            label3.Name = "label3";
            label3.Size = new Size(90, 21);
            label3.TabIndex = 11;
            label3.Text = "Capacity";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 519);
            label4.Name = "label4";
            label4.Size = new Size(60, 21);
            label4.TabIndex = 12;
            label4.Text = "Model";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(138, 427);
            label5.Name = "label5";
            label5.Size = new Size(177, 25);
            label5.TabIndex = 13;
            label5.Text = "Add new Lorries";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // Lorries
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 701);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Clear);
            Controls.Add(Update);
            Controls.Add(Delete);
            Controls.Add(Add);
            Controls.Add(NudCapacity);
            Controls.Add(tbModel);
            Controls.Add(tbPlateNumber);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Lorries";
            Text = "Lorries";
            Load += Lorries_Load;
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
        private TextBox tbPlateNumber;
        private TextBox tbModel;
        private NumericUpDown NudCapacity;
        private DataGridView DtTable;
        private Button Add;
        private Button Delete;
        private Button Update;
        private Button Clear;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}