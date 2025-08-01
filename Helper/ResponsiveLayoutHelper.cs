using System;
using System.Drawing;
using System.Windows.Forms;

namespace Eshift.Helper
{
    /// <summary>
    /// Helper class to make Windows Forms responsive and adapt to different screen sizes
    /// </summary>
    public static class ResponsiveLayoutHelper
    {
        /// <summary>
        /// Configures a form to be responsive
        /// </summary>
        /// <param name="form">The form to configure</param>
        /// <param name="minWidth">Minimum width</param>
        /// <param name="minHeight">Minimum height</param>
        public static void MakeFormResponsive(Form form, int minWidth = 800, int minHeight = 600)
        {
            // Set minimum size
            form.MinimumSize = new Size(minWidth, minHeight);
            
            // Enable auto-scaling
            form.AutoScaleMode = AutoScaleMode.Dpi;
            form.AutoScaleDimensions = new SizeF(96F, 96F);
            
            // Start maximized for better experience on laptops
            if (form.TopLevel)
            {
                form.WindowState = FormWindowState.Maximized;
            }
            
            // Handle resize events
            form.Resize += (sender, e) => AdjustFormControls(form);
            form.Load += (sender, e) => AdjustFormControls(form);
        }

        /// <summary>
        /// Makes a DataGridView responsive
        /// </summary>
        /// <param name="dgv">DataGridView to configure</param>
        public static void MakeDataGridViewResponsive(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.RowHeadersVisible = false;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            
            // Set default cell style
            dgv.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = Color.Black,
                SelectionBackColor = Color.FromArgb(46, 204, 113),
                SelectionForeColor = Color.White,
                Font = new Font("Segoe UI", 10F),
                WrapMode = DataGridViewTriState.True,
                Padding = new Padding(5)
            };
            
            // Set header style
            dgv.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(44, 62, 80),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                Padding = new Padding(5)
            };
            
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersHeight = 40;
            dgv.RowTemplate.Height = 35;
        }

        /// <summary>
        /// Adjusts column widths for a DataGridView based on available space
        /// </summary>
        /// <param name="dgv">DataGridView to adjust</param>
        /// <param name="columnConfig">Dictionary with column names and their percentage widths</param>
        public static void AdjustDataGridViewColumns(DataGridView dgv, System.Collections.Generic.Dictionary<string, float> columnConfig = null)
        {
            if (dgv == null || dgv.Columns.Count == 0) return;

            int availableWidth = dgv.Width - SystemInformation.VerticalScrollBarWidth - 20;
            
            if (columnConfig != null)
            {
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    if (columnConfig.ContainsKey(column.Name))
                    {
                        column.Width = Math.Max(50, (int)(availableWidth * columnConfig[column.Name]));
                    }
                }
            }
            else
            {
                // Default equal distribution
                int columnWidth = availableWidth / dgv.Columns.Count;
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    column.Width = Math.Max(80, columnWidth);
                }
            }
        }

        /// <summary>
        /// Creates a responsive button with consistent styling
        /// </summary>
        /// <param name="text">Button text</param>
        /// <param name="color">Background color</param>
        /// <param name="textColor">Text color</param>
        /// <param name="height">Button height</param>
        /// <returns>Configured button</returns>
        public static Button CreateResponsiveButton(string text, Color color, Color? textColor = null, int height = 35)
        {
            return new Button
            {
                Text = text,
                BackColor = color,
                ForeColor = textColor ?? Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Height = height,
                MinimumSize = new Size(100, height),
                FlatAppearance = { BorderSize = 0 },
                Cursor = Cursors.Hand,
                UseVisualStyleBackColor = false,
                AutoSize = false
            };
        }

        /// <summary>
        /// Makes a panel responsive by adjusting its layout based on screen size
        /// </summary>
        /// <param name="panel">Panel to configure</param>
        /// <param name="isHorizontal">Whether to use horizontal layout by default</param>
        public static void MakePanelResponsive(Panel panel, bool isHorizontal = true)
        {
            if (panel is TableLayoutPanel tablePanel)
            {
                tablePanel.AutoSize = true;
                tablePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            }
            else if (panel is FlowLayoutPanel flowPanel)
            {
                flowPanel.FlowDirection = isHorizontal ? FlowDirection.LeftToRight : FlowDirection.TopDown;
                flowPanel.AutoSize = true;
                flowPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                flowPanel.WrapContents = true;
            }
        }

        /// <summary>
        /// Adjusts all controls in a form for current screen size
        /// </summary>
        /// <param name="form">Form to adjust</param>
        private static void AdjustFormControls(Form form)
        {
            if (form.WindowState == FormWindowState.Minimized) return;

            // Get current screen info
            Screen currentScreen = Screen.FromControl(form);
            
            // Adjust for small screens (laptops)
            if (currentScreen.WorkingArea.Width < 1366)
            {
                AdjustForSmallScreen(form);
            }
            else
            {
                AdjustForLargeScreen(form);
            }
            
            // Find and adjust all DataGridViews
            foreach (Control control in GetAllControls(form))
            {
                if (control is DataGridView dgv)
                {
                    AdjustDataGridViewColumns(dgv);
                }
                else if (control is Panel panel && panel.Name.Contains("action"))
                {
                    // Adjust action panels for smaller screens
                    if (form.Width < 1200 && panel is FlowLayoutPanel flowPanel)
                    {
                        flowPanel.FlowDirection = FlowDirection.TopDown;
                    }
                    else if (panel is FlowLayoutPanel flowPanel2)
                    {
                        flowPanel2.FlowDirection = FlowDirection.LeftToRight;
                    }
                }
            }
        }

        /// <summary>
        /// Gets all controls recursively from a parent control
        /// </summary>
        /// <param name="parent">Parent control</param>
        /// <returns>All child controls</returns>
        private static System.Collections.Generic.IEnumerable<Control> GetAllControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                yield return control;
                foreach (Control child in GetAllControls(control))
                {
                    yield return child;
                }
            }
        }

        /// <summary>
        /// Adjusts form layout for small screens (laptops)
        /// </summary>
        /// <param name="form">Form to adjust</param>
        private static void AdjustForSmallScreen(Form form)
        {
            // Reduce padding and margins
            form.Padding = new Padding(5);
            
            // Adjust font sizes if needed
            foreach (Control control in GetAllControls(form))
            {
                if (control is Label label && label.Font.Size > 12)
                {
                    label.Font = new Font(label.Font.FontFamily, 11F, label.Font.Style);
                }
                else if (control is Button button && button.Font.Size > 10)
                {
                    button.Font = new Font(button.Font.FontFamily, 9F, button.Font.Style);
                }
            }
        }

        /// <summary>
        /// Adjusts form layout for large screens
        /// </summary>
        /// <param name="form">Form to adjust</param>
        private static void AdjustForLargeScreen(Form form)
        {
            // Restore normal padding
            form.Padding = new Padding(10);
        }

        /// <summary>
        /// Centers a form on the current screen
        /// </summary>
        /// <param name="form">Form to center</param>
        public static void CenterFormOnScreen(Form form)
        {
            Screen currentScreen = Screen.FromControl(form);
            Rectangle workingArea = currentScreen.WorkingArea;
            
            form.Location = new Point(
                workingArea.X + (workingArea.Width - form.Width) / 2,
                workingArea.Y + (workingArea.Height - form.Height) / 2
            );
        }
    }
}