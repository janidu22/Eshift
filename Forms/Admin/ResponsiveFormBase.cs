using System;
using System.Drawing;
using System.Windows.Forms;

namespace Eshift.Forms.Admin
{
    /// <summary>
    /// Base form class that provides responsive design capabilities for all admin forms
    /// </summary>
    public partial class ResponsiveFormBase : Form
    {
        protected Panel headerPanel;
        protected Panel contentPanel;
        protected Label titleLabel;
        
        public ResponsiveFormBase()
        {
            InitializeResponsiveComponents();
            SetupResponsiveLayout();
        }

        private void InitializeResponsiveComponents()
        {
            // Form setup
            this.MinimumSize = new Size(800, 600); // Minimum size for usability
            this.WindowState = FormWindowState.Maximized; // Start maximized for better experience
            this.FormBorderStyle = FormBorderStyle.Sizable;
            
            // Header panel
            headerPanel = new Panel
            {
                BackColor = Color.FromArgb(25, 42, 86),
                Dock = DockStyle.Top,
                Height = 60
            };

            // Content panel
            contentPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Padding = new Padding(10)
            };

            // Title label
            titleLabel = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(20, 15),
                Text = "Admin Panel"
            };

            // Add controls to form
            headerPanel.Controls.Add(titleLabel);
            this.Controls.Add(contentPanel);
            this.Controls.Add(headerPanel);
        }

        private void SetupResponsiveLayout()
        {
            // Handle form resize events
            this.Resize += ResponsiveFormBase_Resize;
            this.Load += ResponsiveFormBase_Load;
        }

        private void ResponsiveFormBase_Load(object sender, EventArgs e)
        {
            // Auto-adjust form size based on screen
            Screen currentScreen = Screen.FromControl(this);
            
            // Set form to 90% of screen size with minimum constraints
            int newWidth = Math.Max(800, (int)(currentScreen.WorkingArea.Width * 0.9));
            int newHeight = Math.Max(600, (int)(currentScreen.WorkingArea.Height * 0.9));
            
            this.Size = new Size(newWidth, newHeight);
            this.CenterToScreen();
        }

        private void ResponsiveFormBase_Resize(object sender, EventArgs e)
        {
            // Override in derived classes for custom resize logic
            OnFormResize();
        }

        protected virtual void OnFormResize()
        {
            // Base implementation - can be overridden by derived classes
        }

        /// <summary>
        /// Sets the title of the form
        /// </summary>
        /// <param name="title">Title to display</param>
        protected void SetFormTitle(string title)
        {
            if (titleLabel != null)
            {
                titleLabel.Text = title;
                this.Text = title;
            }
        }

        /// <summary>
        /// Creates a responsive DataGridView with proper sizing
        /// </summary>
        /// <returns>Configured DataGridView</returns>
        protected DataGridView CreateResponsiveDataGridView()
        {
            var dgv = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                RowHeadersVisible = false,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = Color.White,
                    ForeColor = Color.Black,
                    SelectionBackColor = Color.FromArgb(46, 204, 113),
                    SelectionForeColor = Color.White,
                    Font = new Font("Segoe UI", 10F),
                    WrapMode = DataGridViewTriState.True
                },
                ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = Color.FromArgb(44, 62, 80),
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                    Alignment = DataGridViewContentAlignment.MiddleLeft
                },
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing,
                ColumnHeadersHeight = 40
            };

            return dgv;
        }

        /// <summary>
        /// Creates a responsive button with consistent styling
        /// </summary>
        /// <param name="text">Button text</param>
        /// <param name="color">Button color</param>
        /// <returns>Configured button</returns>
        protected Button CreateResponsiveButton(string text, Color color)
        {
            return new Button
            {
                Text = text,
                BackColor = color,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Height = 35,
                MinimumSize = new Size(100, 35),
                FlatAppearance = { BorderSize = 0 },
                Cursor = Cursors.Hand,
                UseVisualStyleBackColor = false
            };
        }

        /// <summary>
        /// Creates a responsive TableLayoutPanel for form layouts
        /// </summary>
        /// <param name="rows">Number of rows</param>
        /// <param name="columns">Number of columns</param>
        /// <returns>Configured TableLayoutPanel</returns>
        protected TableLayoutPanel CreateResponsiveTableLayout(int rows, int columns)
        {
            var table = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = rows,
                ColumnCount = columns,
                Padding = new Padding(10),
                AutoSize = true
            };

            // Set equal column widths
            for (int i = 0; i < columns; i++)
            {
                table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / columns));
            }

            // Set row heights
            for (int i = 0; i < rows; i++)
            {
                table.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }

            return table;
        }
    }
}