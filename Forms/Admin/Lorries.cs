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
        public Lorries()
        {
            InitializeComponent();
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
                if(string.IsNullOrWhiteSpace(PlateNumber) || string.IsNullOrWhiteSpace(PlateNumber) )
                {
                 MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
                }

                if(Capacity == null)
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
    }
}
