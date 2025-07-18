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
        private int? selectedAssistantId = null;
        public Assistants()
        {
            InitializeComponent();
        }

        private void Assistants_Load(object sender, EventArgs e)
        {
            LoadData();
            Add.Visible = true;
            Update.Visible = false;
            delete.Visible = false;
            Clear.Visible = false;
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

        private async void Add_Click(object sender, EventArgs e)
        {
            var Name = tbName.Text;
            var phoneNumber = tbPhone.Text;
            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(phoneNumber))
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var success = await trasnportUnit.AddAssistantAsync(Name, phoneNumber);
            if (success)
            {
                MessageBox.Show("Assistant added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Failed to add assistant.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (selectedAssistantId == null)
            {
                MessageBox.Show("Please select an assistant to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var Name = tbName.Text;
            var phoneNumber = tbPhone.Text;
            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(phoneNumber))
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var success = await trasnportUnit.UpdateAssistantAsync(selectedAssistantId.Value, Name, phoneNumber);
            if (success)
            {
                MessageBox.Show("Assistant updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Failed to update assistant.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (selectedAssistantId == null)
            {
                MessageBox.Show("Please select an assistant to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var confirm = MessageBox.Show("Are you sure you want to delete this assistant?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                var success = await trasnportUnit.DeleteAssistantAsync(selectedAssistantId.Value);
                if (success)
                {
                    MessageBox.Show("Assistant deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to delete assistant.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DtTableAssistants_SelectionChanged(object sender, EventArgs e)
        {
            if (DtTableAssistants.SelectedRows.Count > 0)
            {
                var row = DtTableAssistants.SelectedRows[0];
                selectedAssistantId = Convert.ToInt32(row.Cells["AssistantId"].Value);
                tbName.Text = row.Cells["Name"].Value.ToString();
                tbPhone.Text = row.Cells["Phone"].Value.ToString();
                Add.Visible = false;
                Update.Visible = true;
                delete.Visible = true;
                Clear.Visible = true;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Add.Visible = true;
            Update.Visible = false;
            Update.Visible = false;
            Clear.Visible = false;
            selectedAssistantId = null;
            ClearForm();
        }

        private void ClearForm()
        {
            tbName.Clear();
            tbPhone.Clear();

        }

     
    }
}
