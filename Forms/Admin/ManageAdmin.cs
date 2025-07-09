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

                bool success = _adminRepository.RegisterAdmin(name, email, username, password);

                if (success)
                {
                    MessageBox.Show("Admin Created Successfully");
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

        private void LoadAdminDetails(int adminId)
        {
            var admin = _adminRepository.GetAdminById(adminId);
            if (admin != null)
            {
                tbName.Text = admin.Name;
                tbEmail.Text = admin.Email;
                tbUsername.Text = admin.Username;
                tbPassword.Text = "password";
            }
        }

        private void ClearForm()
        {
            tbName.Clear();
            tbEmail.Clear();
            tbUsername.Clear();
            tbPassword.Clear();
        }

        private void btnUpdateAdmin_Click(object sender, EventArgs e)
        {
            int? adminId = GetSelectedAdminId();

            if (adminId == null)
            {
                MessageBox.Show("Please select an admin to update.");
                return;
            }

            var name = tbName.Text.Trim();
            var email = tbEmail.Text.Trim();
            var username = tbUsername.Text.Trim();
            var password = tbPassword.Text;

            bool success = _adminRepository.UpdateAdmin(adminId.Value, name, email, username, password);

            if (success)
            {
                MessageBox.Show("Admin updated successfully.");
                ClearForm();
                LoadAllAdmins();
            }
            else
            {
                MessageBox.Show("Failed to update admin. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void viewAdminsDt_SelectionChanged(object sender, EventArgs e)
        {
            int? selectedAdminId = GetSelectedAdminId();
            if (selectedAdminId.HasValue)
            {
                LoadAdminDetails(selectedAdminId.Value);
            }
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

            var confirmResult = MessageBox.Show("Are you sure to delete this admin?",
                                                "Confirm Delete",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                bool isDeleted = _adminRepository.DeleteAdmin(adminId.Value);
                if (isDeleted)
                {
                    MessageBox.Show("Admin deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllAdmins(); // Refresh the grid
                    ClearForm();     // Clear input fields if needed
                }
                else
                {
                    MessageBox.Show("Failed to delete the admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
