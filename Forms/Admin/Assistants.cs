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
    public partial class Assistants : Form
    {
        private readonly TrasnportUnitRepository trasnportUnit = new TrasnportUnitRepository();
        public Assistants()
        {
            InitializeComponent();
        }

        private void Assistants_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void LoadData()
        {
            DataTable dataTable = await trasnportUnit.GetAllAssistantsAsync();
            DtTableAssistants.DataSource = dataTable;
            DtTableAssistants.Columns["AssistantId"].Visible = false;
            DtTableAssistants.Dock = DockStyle.Fill;
            DtTableAssistants.RowHeadersVisible = false;
            DtTableAssistants.AllowUserToAddRows = false;
            DtTableAssistants.ReadOnly = true;
            DtTableAssistants.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DtTableAssistants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DtTableAssistants.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DtTableAssistants.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void DtTableAssistants_SelectionChanged(object sender, EventArgs e)
        {
            if (DtTableAssistants.SelectedRows.Count > 0)
            {
                tbName.Text = DtTableAssistants.SelectedRows[0].Cells["Name"].Value.ToString();
                tbPhone.Text = DtTableAssistants.SelectedRows[0].Cells["Phone"].Value.ToString();
                Add.Visible = false;
                Clear.Visible = true;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Clear.Visible = false;
            Add.Visible = true;
            ClearForm();

        }

        private void ClearForm()
        {
            tbName.Clear();
            tbPhone.Clear();

        }
    }
}
