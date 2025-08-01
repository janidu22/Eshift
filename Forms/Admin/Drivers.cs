using Eshift.Models;
using Eshift.Repoistory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eshift.Forms.Admin
{
    public partial class Drivers : Form
    {

        private readonly TrasnportUnitRepository trasnportUnit = new TrasnportUnitRepository();
        private int? selectedDriverId = null;
        public Drivers()
        {
            InitializeComponent();
            
            // Apply responsive design
            this.ApplyResponsiveDesign();
            this.QuickLaptopFix();
        }



        private void Drivers_Load(object sender, EventArgs e)
        {
            LoadData();
            Add.Visible = true;
            Update.Visible = false;
            Delete.Visible = false;
            Clear.Visible = false;
        }


        private async void LoadData()
        {
            DataTable dataTable = await trasnportUnit.GetAllDriversAsync();
            DtTable.DataSource = dataTable;
            DtTable.Columns["DriverId"].Visible = false;
            DtTable.Dock = DockStyle.Fill;
            DtTable.RowHeadersVisible = false;
            DtTable.AllowUserToAddRows = false;
            DtTable.ReadOnly = true;
            DtTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DtTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DtTable.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DtTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private async void Add_Click(object sender, EventArgs e)
        {
            var Name = tbName.Text;
            var licenseNumber = tbLicenseNumber.Text;
            var phoneNumber = tbPhone.Text;

            try
            {
                if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(licenseNumber) || string.IsNullOrWhiteSpace(phoneNumber))
                {
                    MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var success = await trasnportUnit.AddDriverAsync(Name, licenseNumber, phoneNumber);
                if (!success)
                {
                    MessageBox.Show("Failed to add driver. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Driver added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the driver: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (selectedDriverId == null)
            {
                MessageBox.Show("Please select a driver to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var Name = tbName.Text;
            var licenseNumber = tbLicenseNumber.Text;
            var phoneNumber = tbPhone.Text;
            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(licenseNumber) || string.IsNullOrWhiteSpace(phoneNumber))
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var success = await trasnportUnit.UpdateDriverAsync(selectedDriverId.Value, Name, licenseNumber, phoneNumber);
            if (success)
            {
                MessageBox.Show("Driver updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Failed to update driver.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (selectedDriverId == null)
            {
                MessageBox.Show("Please select a driver to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var confirm = MessageBox.Show("Are you sure you want to delete this driver?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                var success = await trasnportUnit.DeleteDriverAsync(selectedDriverId.Value);
                if (success)
                {
                    MessageBox.Show("Driver deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to delete driver.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearFields()
        {
            tbPhone.Clear();
            tbName.Clear();
            tbLicenseNumber.Clear();
        }

        private void DtTable_SelectionChanged(object sender, EventArgs e)
        {
            if (DtTable.SelectedRows.Count > 0)
            {
                var row = DtTable.SelectedRows[0];
                selectedDriverId = Convert.ToInt32(row.Cells["DriverId"].Value);
                tbName.Text = row.Cells["Name"].Value.ToString();
                tbLicenseNumber.Text = row.Cells["License Number"].Value.ToString();
                tbPhone.Text = row.Cells["Phone"].Value.ToString();
                Add.Visible = false;
                Update.Visible = true;
                Delete.Visible = true;
                Clear.Visible = true;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Add.Visible = true;
            Update.Visible = false;
            Delete.Visible = false;
            Clear.Visible = false;
            selectedDriverId = null;
            ClearFields();
        }
    }
}
