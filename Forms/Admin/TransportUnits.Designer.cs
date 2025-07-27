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
            headerPanel = new Panel();
            label1 = new Label();
            navbarPanel = new Panel();
            btnTransportUnit = new Button();
            btnContainer = new Button();
            btnAssistants = new Button();
            btnDrivers = new Button();
            btnLorries = new Button();
            mainContentContainer = new Panel();
            
            headerPanel.SuspendLayout();
            navbarPanel.SuspendLayout();
            SuspendLayout();
            
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(25, 42, 86);
            headerPanel.Controls.Add(label1);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1200, 60);
            headerPanel.TabIndex = 0;
            
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 16);
            label1.Name = "label1";
            label1.Size = new Size(331, 32);
            label1.TabIndex = 0;
            label1.Text = "🚢 Manage Transport Units";
            
            // 
            // navbarPanel
            // 
            navbarPanel.BackColor = Color.FromArgb(44, 62, 118);
            navbarPanel.Controls.Add(btnTransportUnit);
            navbarPanel.Controls.Add(btnContainer);
            navbarPanel.Controls.Add(btnAssistants);
            navbarPanel.Controls.Add(btnDrivers);
            navbarPanel.Controls.Add(btnLorries);
            navbarPanel.Dock = DockStyle.Top;
            navbarPanel.Location = new Point(0, 60);
            navbarPanel.Name = "navbarPanel";
            navbarPanel.Size = new Size(1200, 50);
            navbarPanel.TabIndex = 1;
            
            // 
            // btnLorries
            // 
            btnLorries.BackColor = Color.FromArgb(44, 62, 118);
            btnLorries.FlatAppearance.BorderSize = 0;
            btnLorries.FlatStyle = FlatStyle.Flat;
            btnLorries.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLorries.ForeColor = Color.White;
            btnLorries.Location = new Point(20, 5);
            btnLorries.Name = "btnLorries";
            btnLorries.Size = new Size(120, 40);
            btnLorries.TabIndex = 0;
            btnLorries.Text = "🚛 Lorries";
            btnLorries.UseVisualStyleBackColor = false;
            btnLorries.Click += BtnLorries_Click;
            
            // 
            // btnDrivers
            // 
            btnDrivers.BackColor = Color.FromArgb(44, 62, 118);
            btnDrivers.FlatAppearance.BorderSize = 0;
            btnDrivers.FlatStyle = FlatStyle.Flat;
            btnDrivers.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDrivers.ForeColor = Color.White;
            btnDrivers.Location = new Point(150, 5);
            btnDrivers.Name = "btnDrivers";
            btnDrivers.Size = new Size(120, 40);
            btnDrivers.TabIndex = 1;
            btnDrivers.Text = "👨‍💼 Drivers";
            btnDrivers.UseVisualStyleBackColor = false;
            btnDrivers.Click += BtnDrivers_Click;
            
            // 
            // btnAssistants
            // 
            btnAssistants.BackColor = Color.FromArgb(44, 62, 118);
            btnAssistants.FlatAppearance.BorderSize = 0;
            btnAssistants.FlatStyle = FlatStyle.Flat;
            btnAssistants.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAssistants.ForeColor = Color.White;
            btnAssistants.Location = new Point(280, 5);
            btnAssistants.Name = "btnAssistants";
            btnAssistants.Size = new Size(120, 40);
            btnAssistants.TabIndex = 2;
            btnAssistants.Text = "👥 Assistants";
            btnAssistants.UseVisualStyleBackColor = false;
            btnAssistants.Click += BtnAssistants_Click;
            
            // 
            // btnContainer
            // 
            btnContainer.BackColor = Color.FromArgb(44, 62, 118);
            btnContainer.FlatAppearance.BorderSize = 0;
            btnContainer.FlatStyle = FlatStyle.Flat;
            btnContainer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnContainer.ForeColor = Color.White;
            btnContainer.Location = new Point(410, 5);
            btnContainer.Name = "btnContainer";
            btnContainer.Size = new Size(120, 40);
            btnContainer.TabIndex = 3;
            btnContainer.Text = "📦 Container";
            btnContainer.UseVisualStyleBackColor = false;
            btnContainer.Click += BtnContainer_Click;
            
            // 
            // btnTransportUnit
            // 
            btnTransportUnit.BackColor = Color.FromArgb(25, 42, 86);
            btnTransportUnit.FlatAppearance.BorderSize = 0;
            btnTransportUnit.FlatStyle = FlatStyle.Flat;
            btnTransportUnit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTransportUnit.ForeColor = Color.White;
            btnTransportUnit.Location = new Point(540, 5);
            btnTransportUnit.Name = "btnTransportUnit";
            btnTransportUnit.Size = new Size(140, 40);
            btnTransportUnit.TabIndex = 4;
            btnTransportUnit.Text = "🚢 Transport Unit";
            btnTransportUnit.UseVisualStyleBackColor = false;
            btnTransportUnit.Click += BtnTransportUnit_Click;
            
            // 
            // mainContentContainer
            // 
            mainContentContainer.BackColor = Color.FromArgb(240, 244, 248);
            mainContentContainer.Dock = DockStyle.Fill;
            mainContentContainer.Location = new Point(0, 110);
            mainContentContainer.Name = "mainContentContainer";
            mainContentContainer.Size = new Size(1200, 590);
            mainContentContainer.TabIndex = 2;
            
            // 
            // Transport_units
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 42, 86);
            ClientSize = new Size(1200, 700);
            Controls.Add(mainContentContainer);
            Controls.Add(navbarPanel);
            Controls.Add(headerPanel);
            Name = "Transport_units";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transport Units Management";
            Load += Transport_units_Load;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            navbarPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel headerPanel;
        private Label label1;
        private Panel navbarPanel;
        private Button btnLorries;
        private Button btnDrivers;
        private Button btnAssistants;
        private Button btnContainer;
        private Button btnTransportUnit;
        private Panel mainContentContainer;
    }
}