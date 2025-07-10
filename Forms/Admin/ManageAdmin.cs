using Eshift.Models;
using Eshift.Repoistory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Eshift.Forms.Admin
{
    public partial class ManageAdmin : Form
    {
        private readonly AdminRepository _adminRepository;

        public ManageAdmin()
        {
            InitializeComponent();
            _adminRepository = new AdminRepository();
            viewAdminsDt.SelectionChanged += viewAdminsDt_SelectionChanged;
        }

        private void ManageAdmin_Load(object sender, EventArgs e)
        {
            LoadAllAdmins();
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                var name = tbName.Text.Trim();
                var email = tbEmail.Text.Trim();
                var username = tbUsername.Text.Trim();
                var password = tbPassword.Text;

                // Validate inputs
                if (!ValidateAdminForm(name, email, username, password))
                {
                    return;
                }

                bool success = _adminRepository.RegisterAdmin(name, email, username, password);

                if (success)
                {
                    MessageBox.Show("Admin Created Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadAllAdmins();
                }
                else
                {
                    MessageBox.Show("Registration failed. Username or email might already exist.", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateAdminForm(string name, string email, string username, string password)
        {
            // Validate Name
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter the admin's full name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbName.Focus();
                return false;
            }

            if (name.Length < 2)
            {
                MessageBox.Show("Name must be at least 2 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbName.Focus();
                return false;
            }

            if (!Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Name can only contain letters and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbName.Focus();
                return false;
            }

            // Validate Email
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter the admin's email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbEmail.Focus();
                return false;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbEmail.Focus();
                return false;
            }

            // Validate Username
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter a username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbUsername.Focus();
                return false;
            }

            if (username.Length < 3)
            {
                MessageBox.Show("Username must be at least 3 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbUsername.Focus();
                return false;
            }

            if (!Regex.IsMatch(username, @"^[a-zA-Z0-9_]+$"))
            {
                MessageBox.Show("Username can only contain letters, numbers, and underscores.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbUsername.Focus();
                return false;
            }

            // Validate Password
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter a password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPassword.Focus();
                return false;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPassword.Focus();
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void LoadAllAdmins()
        {
            DataTable adminDataTable = _adminRepository.GetAllAdmins();
            viewAdminsDt.DataSource = adminDataTable;

            viewAdminsDt.Dock = DockStyle.Fill;
            viewAdminsDt.RowHeadersVisible = false;
            viewAdminsDt.AllowUserToAddRows = false;
            viewAdminsDt.ReadOnly = true;
            viewAdminsDt.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            viewAdminsDt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewAdminsDt.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            string[] hideColNames = { "AdminId", "UserId", "CreatedAt", "UserEmail" };
            foreach (string colName in hideColNames)
            {
                if (viewAdminsDt.Columns.Contains(colName))
                    viewAdminsDt.Columns[colName].Visible = false;
            }
        }

        private int? GetSelectedAdminId()
        {

            if (viewAdminsDt.SelectedRows.Count > 0)
            {
                var selectedRow = viewAdminsDt.SelectedRows[0];
                var cellValue = selectedRow.Cells["AdminId"].Value;

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int adminId))
                {

                    return adminId;

                }
            }

            return null;
        }

        private void btnUpdateAdmin_Click(object sender, EventArgs e)
        {
            int? adminId = GetSelectedAdminId();

            if (adminId == null)
            {
                MessageBox.Show("Please select an admin to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var name = tbName.Text.Trim();
            var email = tbEmail.Text.Trim();
            var username = tbUsername.Text.Trim();
            var password = tbPassword.Text;

            // Validate inputs
            if (!ValidateAdminForm(name, email, username, password))
            {
                return;
            }

            bool success = _adminRepository.UpdateAdmin(adminId.Value, name, email, username, password);

            if (success)
            {
                MessageBox.Show("Admin updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllAdmins();
            }
            else
            {
                MessageBox.Show("Failed to update admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void viewAdminsDt_SelectionChanged(object? sender, EventArgs e)
        {
            int? adminId = GetSelectedAdminId();
            if (adminId != null)
            {
                var admin = _adminRepository.GetAdminById(adminId.Value);
                if (admin != null)
                {
                    tbName.Text = admin.Name;
                    tbEmail.Text = admin.Email;
                    tbUsername.Text = admin.Username;
                    tbPassword.Text = "password";
                }
            }
        }

        private void ClearForm()
        {
            tbName.Clear();
            tbEmail.Clear();
            tbUsername.Clear();
            tbPassword.Clear();
        }

        private void add_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnDeleteAdmin_Click(object sender, EventArgs e)
        {
            int? adminId = GetSelectedAdminId();
            if (adminId == null)
            {
                MessageBox.Show("Please select an admin to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool success = _adminRepository.DeleteAdmin(adminId.Value);
            if (success)
            {
                MessageBox.Show("Admin deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllAdmins();
            }
            else
            {
                MessageBox.Show("Failed to delete admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
