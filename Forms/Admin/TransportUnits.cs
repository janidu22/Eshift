using Eshift.Repoistory;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eshift.Forms.Admin
{
    public partial class Transport_units : Form
    {
        private readonly TrasnportUnitRepository trasnportUnit = new TrasnportUnitRepository();

        public Transport_units()
        {
            InitializeComponent();
            this.Load += async (s, e) => await Transport_units_Load(s, e);
        }

        private async Task Transport_units_Load(object sender, EventArgs e)
        {
            await LoadAllDropdowns();
            LoadData();
        }

        private async void LoadData()
        {
            DataTable dataTable = await trasnportUnit.GetAllTransportUnitsAsync();
            DtTable.DataSource = dataTable;
            DtTable.Columns["UnitID"].Visible = false;
            DtTable.Dock = DockStyle.Fill;
            DtTable.RowHeadersVisible = false;
            DtTable.AllowUserToAddRows = false;
            DtTable.ReadOnly = true;
            DtTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DtTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DtTable.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DtTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtTable.Columns["LorryId"].Visible = false;
            DtTable.Columns["DriverId"].Visible = false;
            DtTable.Columns["AssistantId"].Visible = false;
            DtTable.Columns["ContainerId"].Visible = false;

        }

        private async Task LoadAllDropdowns()
        {
            var lorries = await trasnportUnit.GetLorriesForDropdownAsync();
            cbLorry.DataSource = lorries;
            cbLorry.DisplayMember = "DisplayText";
            cbLorry.ValueMember = "LorryId";

            var drivers = await trasnportUnit.GetDriversForDropdownAsync();
            cbDriver.DataSource = drivers;
            cbDriver.DisplayMember = "DisplayText";
            cbDriver.ValueMember = "DriverId";

            var assistants = await trasnportUnit.GetAssistantsForDropdownAsync();
            cbAssistant.DataSource = assistants;
            cbAssistant.DisplayMember = "DisplayText";
            cbAssistant.ValueMember = "AssistantId";

            var containers = await trasnportUnit.GetContainersForDropdownAsync();
            cbContainer.DataSource = containers;
            cbContainer.DisplayMember = "DisplayText";
            cbContainer.ValueMember = "ContainerId";
        }

        private void DtTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void Add_Click(object sender, EventArgs e)
        {
            if (cbLorry.SelectedValue == null || cbDriver.SelectedValue == null ||
                cbAssistant.SelectedValue == null || cbContainer.SelectedValue == null)
            {
                MessageBox.Show("Please select all dropdown values.");
                return;
            }

            int lorryId = Convert.ToInt32(cbLorry.SelectedValue);
            int driverId = Convert.ToInt32(cbDriver.SelectedValue);
            int assistantId = Convert.ToInt32(cbAssistant.SelectedValue);
            int containerId = Convert.ToInt32(cbContainer.SelectedValue);
            var transportUnit = await trasnportUnit.AddTransportUnitAsync(lorryId, driverId, assistantId, containerId);
            MessageBox.Show(transportUnit ? "Transport unit added successfully." : "Failed to add transport unit.");
            LoadData();
            clearForm();
        }

        private void clearForm()
        {
            cbLorry.SelectedIndex = -1;
            cbDriver.SelectedIndex = -1;
            cbAssistant.SelectedIndex = -1;
            cbContainer.SelectedIndex = -1;
        }

        private void DtTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                Add.Visible = false;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Add.Visible = true;
            Clear.Visible = false;
        }

        private async void Update_Click(object sender, EventArgs e)
        {
            if (cbLorry.SelectedValue == null || cbDriver.SelectedValue == null ||
                            cbAssistant.SelectedValue == null || cbContainer.SelectedValue == null)
            {
                MessageBox.Show("Please select all dropdown values.");
                return;
            }

            int lorryId = Convert.ToInt32(cbLorry.SelectedValue);
            int driverId = Convert.ToInt32(cbDriver.SelectedValue);
            int assistantId = Convert.ToInt32(cbAssistant.SelectedValue);
            int containerId = Convert.ToInt32(cbContainer.SelectedValue);
            int transportUnitId = Convert.ToInt32(DtTable.SelectedRows[0].Cells["UnitID"].Value);
            var transportUnit = await trasnportUnit.UpdateTransportUnitAsync(transportUnitId, lorryId, driverId, assistantId, containerId);

            cbLorry.SelectedValue = lorryId;
            cbDriver.SelectedValue = driverId;
            cbAssistant.SelectedValue = assistantId;
            cbContainer.SelectedValue = containerId;

            MessageBox.Show(transportUnit ? "Transport unit added successfully." : "Failed to add transport unit.");
            LoadData();

        }

        private async void Delete_Click(object sender, EventArgs e)
        {
            int transportUnitId = Convert.ToInt32(DtTable.SelectedRows[0].Cells["UnitID"].Value);
            var delete = await trasnportUnit.DeleteTransportUnitAsync(transportUnitId);
            LoadData();
        }

        private void DtTable_SelectionChanged(object sender, EventArgs e)
        {
            if (DtTable.SelectedRows.Count == 0) return;
            Clear.Visible = true;
            var row = DtTable.SelectedRows[0];

            if (row.Cells["LorryId"].Value != DBNull.Value)
            {
                cbLorry.SelectedValue = Convert.ToInt32(row.Cells["LorryId"].Value);
                cbDriver.SelectedValue = Convert.ToInt32(row.Cells["DriverId"].Value);
                cbAssistant.SelectedValue = Convert.ToInt32(row.Cells["AssistantId"].Value);
                cbContainer.SelectedValue = Convert.ToInt32(row.Cells["ContainerId"].Value);

                Add.Visible = false;
            }
        }
    }
}
