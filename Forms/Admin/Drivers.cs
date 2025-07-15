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
        public Drivers()
        {
            InitializeComponent();
         
           
        }

        private void Drivers_Load(object sender, EventArgs e)
        {
            LoadData();
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

                var driver = await trasnportUnit.AddDriverAsync(Name, licenseNumber, phoneNumber);
                if (driver == null)
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
                tbName.Text = DtTable.SelectedRows[0].Cells["Name"].Value.ToString();
                tbLicenseNumber.Text = DtTable.SelectedRows[0].Cells["License Number"].Value.ToString();
                tbPhone.Text = DtTable.SelectedRows[0].Cells["Phone"].Value.ToString();
                Add.Visible = false;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Add.Visible = true;
            Clear.Visible = false;  
            ClearFields();
        }
    }
}
