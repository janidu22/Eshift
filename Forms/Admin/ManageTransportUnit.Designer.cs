namespace Eshift.Forms.Admin
{
    partial class ManageTransportUnit
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
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            PanelMain = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.Navy;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1400, 46);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(619, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(189, 19);
            label1.TabIndex = 1;
            label1.Text = "Manage Trasport unit";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(0, 44);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(132, 749);
            panel2.TabIndex = 2;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Bold);
            button5.Location = new Point(9, 452);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(114, 51);
            button5.TabIndex = 8;
            button5.Text = "Transport  Unit";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Bold);
            button4.Location = new Point(9, 399);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(114, 45);
            button4.TabIndex = 7;
            button4.Text = "Container";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Bold);
            button3.Location = new Point(9, 346);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(114, 45);
            button3.TabIndex = 6;
            button3.Text = "Assistants";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Bold);
            button2.Location = new Point(9, 293);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(114, 45);
            button2.TabIndex = 5;
            button2.Text = "Drivers";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Bold);
            button1.Location = new Point(9, 237);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(114, 48);
            button1.TabIndex = 4;
            button1.Text = "Lorries";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PanelMain
            // 
            PanelMain.Location = new Point(139, 53);
            PanelMain.Name = "PanelMain";
            PanelMain.Size = new Size(1249, 741);
            PanelMain.TabIndex = 3;
            PanelMain.Paint += panel3_Paint;
            // 
            // ManageTransportUnit
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 806);
            Controls.Add(PanelMain);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("JetBrains Mono", 11.25F);
            Margin = new Padding(4);
            Name = "ManageTransportUnit";
            Text = "ManageTransportUnit";
            Load += ManageTransportUnit_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button5;
        private Panel PanelMain;
    }
}