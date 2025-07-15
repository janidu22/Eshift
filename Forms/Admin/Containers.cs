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

            var container = await trasnportUnit.AddContainerAsync(type, capacity);
            if (container != null)
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

   
        private void ClearForm()
        {
            tbType.Clear();
            NudCapacity.Value = NudCapacity.Minimum;
            Add.Visible = true;
            Clear.Visible = false;
        }

        private void DtTable_SelectionChanged(object sender, EventArgs e)
        {
            if (DtTable.SelectedRows.Count > 0)
            {
                var selectedRow = DtTable.SelectedRows[0];
                tbType.Text = selectedRow.Cells["Type"].Value.ToString();

                decimal capacity = Convert.ToDecimal(selectedRow.Cells["Capacity"].Value);
                if (capacity > NudCapacity.Maximum)
                    NudCapacity.Maximum = capacity;

                NudCapacity.Value = capacity;

                Add.Visible = false;
                Clear.Visible = true;
            }
        }

        private void Clear_Click_1(object sender, EventArgs e)
        {
            Add.Visible = true;
            Clear.Visible = false;
            ClearForm();
        }
    }
}
