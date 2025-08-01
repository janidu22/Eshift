using System;
using System.Drawing;
using System.Windows.Forms;
using Eshift.Helper;

namespace Eshift.Forms.Admin
{
    /// <summary>
    /// Extension methods to quickly make any admin form responsive
    /// </summary>
    public static class ResponsiveFormExtensions
    {
        /// <summary>
        /// Applies responsive design to any admin form with minimal code changes
        /// </summary>
        /// <param name="form">The form to make responsive</param>
        /// <param name="minWidth">Minimum width for the form</param>
        /// <param name="minHeight">Minimum height for the form</param>
        public static void ApplyResponsiveDesign(this Form form, int minWidth = 800, int minHeight = 600)
        {
            // Basic responsive setup
            ResponsiveLayoutHelper.MakeFormResponsive(form, minWidth, minHeight);
            
            // Apply to all DataGridViews in the form
            ApplyToAllDataGridViews(form);
            
            // Apply to all buttons
            ApplyToAllButtons(form);
            
            // Apply to panels
            ApplyToAllPanels(form);
        }

        /// <summary>
        /// Makes all DataGridViews in a form responsive
        /// </summary>
        /// <param name="form">Form containing DataGridViews</param>
        private static void ApplyToAllDataGridViews(Form form)
        {
            foreach (Control control in GetAllControls(form))
            {
                if (control is DataGridView dgv)
                {
                    ResponsiveLayoutHelper.MakeDataGridViewResponsive(dgv);
                    
                    // Add resize event for dynamic column adjustment
                    dgv.Resize += (sender, e) =>
                    {
                        ResponsiveLayoutHelper.AdjustDataGridViewColumns(dgv);
                    };
                }
            }
        }

        /// <summary>
        /// Applies responsive styling to all buttons
        /// </summary>
        /// <param name="form">Form containing buttons</param>
        private static void ApplyToAllButtons(Form form)
        {
            foreach (Control control in GetAllControls(form))
            {
                if (control is Button btn)
                {
                    // Ensure buttons have minimum size and proper anchoring
                    btn.MinimumSize = new Size(100, 35);
                    btn.AutoSize = false;
                    
                    // Apply consistent styling
                    if (btn.FlatStyle != FlatStyle.Flat)
                    {
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderSize = 0;
                    }
                    
                    // Set proper font if not already set
                    if (btn.Font.Size < 9)
                    {
                        btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    }
                }
            }
        }

        /// <summary>
        /// Applies responsive layout to panels
        /// </summary>
        /// <param name="form">Form containing panels</param>
        private static void ApplyToAllPanels(Form form)
        {
            foreach (Control control in GetAllControls(form))
            {
                if (control is FlowLayoutPanel flowPanel)
                {
                    ResponsiveLayoutHelper.MakePanelResponsive(flowPanel, true);
                }
                else if (control is TableLayoutPanel tablePanel)
                {
                    ResponsiveLayoutHelper.MakePanelResponsive(tablePanel, true);
                }
                else if (control is Panel panel && !panel.Dock.HasFlag(DockStyle.Fill))
                {
                    // Ensure panels have proper padding
                    if (panel.Padding == Padding.Empty)
                    {
                        panel.Padding = new Padding(5);
                    }
                }
            }
        }

        /// <summary>
        /// Gets all controls recursively
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
        /// Quick fix for forms that are too wide for laptop screens
        /// Call this in the form's Load event
        /// </summary>
        /// <param name="form">Form to adjust</param>
        public static void QuickLaptopFix(this Form form)
        {
            form.Load += (sender, e) =>
            {
                Screen currentScreen = Screen.FromControl(form);
                
                // If screen width is less than 1366 (typical laptop), adjust form
                if (currentScreen.WorkingArea.Width < 1366)
                {
                    // Ensure form fits on screen
                    if (form.Width > currentScreen.WorkingArea.Width)
                    {
                        form.Width = currentScreen.WorkingArea.Width - 50;
                    }
                    
                    if (form.Height > currentScreen.WorkingArea.Height)
                    {
                        form.Height = currentScreen.WorkingArea.Height - 50;
                    }
                    
                    // Center the form
                    ResponsiveLayoutHelper.CenterFormOnScreen(form);
                    
                    // Adjust font sizes for better readability on smaller screens
                    AdjustFontSizesForLaptop(form);
                }
            };
        }

        /// <summary>
        /// Adjusts font sizes specifically for laptop screens
        /// </summary>
        /// <param name="form">Form to adjust</param>
        private static void AdjustFontSizesForLaptop(Form form)
        {
            foreach (Control control in GetAllControls(form))
            {
                switch (control)
                {
                    case Label label when label.Font.Size > 12:
                        label.Font = new Font(label.Font.FontFamily, 11F, label.Font.Style);
                        break;
                    case Button button when button.Font.Size > 10:
                        button.Font = new Font(button.Font.FontFamily, 9F, button.Font.Style);
                        break;
                    case ComboBox comboBox when comboBox.Font.Size > 12:
                        comboBox.Font = new Font(comboBox.Font.FontFamily, 10F, comboBox.Font.Style);
                        break;
                    case TextBox textBox when textBox.Font.Size > 11:
                        textBox.Font = new Font(textBox.Font.FontFamily, 10F, textBox.Font.Style);
                        break;
                }
            }
        }
    }
}