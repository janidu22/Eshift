using Eshift.Models;
using Eshift.Repoistory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eshift.Forms.Admin
{
    public partial class Lorries : Form
    {
        private readonly TrasnportUnitRepository trasnportUnit = new TrasnportUnitRepository();
        private int lorryId = 0;
        public Lorries()
        {
            InitializeComponent();

            NudCapacity.Minimum = 0;
            NudCapacity.Maximum = 10000;
            NudCapacity.Increment = 10;
        }

        private void Lorries_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void LoadData()
        {
            DataTable dataTable = await trasnportUnit.GetAllLorriesAsync();
            DtTable.DataSource = dataTable;
            DtTable.Columns["LorryId"].Visible = false;
            DtTable.Dock = DockStyle.Fill;
            DtTable.RowHeadersVisible = false;
            DtTable.AllowUserToAddRows = false;
            DtTable.ReadOnly = true;
            DtTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DtTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DtTable.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DtTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void Add_Click(object sender, EventArgs e)
        {
            var PlateNumber = tbPlateNumber.Text;
            var Model = tbModel.Text;
            var Capacity = NudCapacity.Value;

            try
            {
                if (string.IsNullOrWhiteSpace(PlateNumber) || string.IsNullOrWhiteSpace(PlateNumber))
                {
                    MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Capacity == null)
                {
                    MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                var result = trasnportUnit.AddLorryAsync(PlateNumber, Model, Capacity);
                MessageBox.Show("lorry added successfully");
                clear();
                LoadData();

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void clear()
        {
            tbModel.Clear();
            tbPlateNumber.Clear();
            NudCapacity.Value = 0;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Add.Visible = true;
            Clear.Visible = false;
            clear();
        }

        private void DtTable_SelectionChanged(object sender, EventArgs e)
        {
            if (DtTable.SelectedRows.Count > 0)
            {
                tbModel.Text = DtTable.SelectedRows[0].Cells["Model"].Value.ToString();
                tbPlateNumber.Text = DtTable.SelectedRows[0].Cells["Plate Number"].Value.ToString();
                lorryId = Convert.ToInt32(DtTable.SelectedRows[0].Cells["LorryId"].Value);

                decimal capacity = Convert.ToDecimal(DtTable.SelectedRows[0].Cells["Capacity"].Value);


                if (capacity > NudCapacity.Maximum)
                    NudCapacity.Maximum = capacity;

                NudCapacity.Value = capacity;

                Add.Visible = false;
            }
        }

        private async void Update_Click(object sender, EventArgs e)
        {
            var PlateNumber = tbPlateNumber.Text;
            var Model = tbModel.Text;
            var Capacity = NudCapacity.Value;

            try
            {
                if (string.IsNullOrWhiteSpace(PlateNumber) || string.IsNullOrWhiteSpace(PlateNumber))
                {
                    MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Capacity == null)
                {
                    MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                var result = await trasnportUnit.UpdateLorryAsync(lorryId, PlateNumber, Model, Capacity);
                MessageBox.Show("lorry updated successfully");
                clear();
                LoadData();

            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while updating the lorry. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private async void Delete_Click(object sender, EventArgs e)
        {
            if (lorryId <= 0)
            {
                MessageBox.Show("Please select a valid lorry.");
                return;
            }

            bool deleted = await trasnportUnit.DeleteLorryAsync(lorryId);

            if (deleted)
            {
                MessageBox.Show("Lorry deleted successfully");
                LoadData(); 
            }
            else
            {
                MessageBox.Show("Lorry is in use and cannot be deleted.");
            }
        }
    }
}

