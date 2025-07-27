using Eshift.Models;
using Eshift.Repoistory;
using System;
using System.Data;
using System.Windows.Forms;

namespace Eshift.Forms.Admin
{
    public partial class Containers : Form
    {
        private readonly TrasnportUnitRepository trasnportUnit = new TrasnportUnitRepository();
        private int? selectedContainerId = null;

        public Containers()
        {
            InitializeComponent();

            NudCapacity.Minimum = 0;
            NudCapacity.Maximum = 10000;
            NudCapacity.Increment = 10;
        }



        private void Containers_Load(object sender, EventArgs e)
        {
            LoadData();
            Add.Visible = true;
            Update.Visible = false;
            delete.Visible = false;
            Clear.Visible = false;
        }

        private async void LoadData()
        {
            DataTable dataTable = await trasnportUnit.GetAllContainersAsync();
            DtTable.DataSource = dataTable;
            DtTable.Columns["ContainerId"].Visible = false;
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
            var type = tbType.Text.Trim();
            var capacity = NudCapacity.Value;

            if (string.IsNullOrWhiteSpace(type))
            {
                MessageBox.Show("Please enter a container type.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var success = await trasnportUnit.AddContainerAsync(type, capacity);
            if (success)
            {
                MessageBox.Show("Container added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Failed to add container", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (selectedContainerId == null)
            {
                MessageBox.Show("Please select a container to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var type = tbType.Text.Trim();
            var capacity = NudCapacity.Value;
            if (string.IsNullOrWhiteSpace(type))
            {
                MessageBox.Show("Please enter a container type.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var success = await trasnportUnit.UpdateContainerAsync(selectedContainerId.Value, type, capacity);
            if (success)
            {
                MessageBox.Show("Container updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Failed to update container.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (selectedContainerId == null)
            {
                MessageBox.Show("Please select a container to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var confirm = MessageBox.Show("Are you sure you want to delete this container?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                var success = await trasnportUnit.DeleteContainerAsync(selectedContainerId.Value);
                if (success)
                {
                    MessageBox.Show("Container deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to delete container.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearForm()
        {
            tbType.Clear();
            NudCapacity.Value = NudCapacity.Minimum;
            Add.Visible = true;
            Update.Visible = false;
            delete.Visible = false;
            Clear.Visible = false;
            selectedContainerId = null;
        }

        private void DtTable_SelectionChanged(object sender, EventArgs e)
        {
            if (DtTable.SelectedRows.Count > 0)
            {
                var selectedRow = DtTable.SelectedRows[0];
                selectedContainerId = Convert.ToInt32(selectedRow.Cells["ContainerId"].Value);
                tbType.Text = selectedRow.Cells["Type"].Value.ToString();
                decimal capacity = Convert.ToDecimal(selectedRow.Cells["Capacity"].Value);
                if (capacity > NudCapacity.Maximum)
                    NudCapacity.Maximum = capacity;
                NudCapacity.Value = capacity;
                Add.Visible = false;
                Update.Visible = true;
                delete.Visible = true;
                Clear.Visible = true;
            }
        }

        private void Clear_Click_1(object sender, EventArgs e)
        {
            Add.Visible = true;
            Update.Visible = false;
            delete.Visible = false;
            Clear.Visible = false;
            selectedContainerId = null;
            ClearForm();
        }
    }
}
