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
    public partial class Containers : Form
    {

        private readonly TrasnportUnitRepository trasnportUnit = new TrasnportUnitRepository();
        public Containers()
        {
            InitializeComponent();
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

        private async  void Add_Click(object sender, EventArgs e)
        {
            var Type = tbType.Text;
            var Capacity = NudCapacity.Value;
             
            var container =  await trasnportUnit.AddContainerAsync(Type, Capacity); 
            if (container != null)
            {

                MessageBox.Show("Container added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Failed to add container", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
