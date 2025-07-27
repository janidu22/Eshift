using Eshift.Repoistory;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing; // Added for Color, Point, Size, Font, Padding, BorderStyle, DataGridViewCellBorderStyle, FlatStyle

namespace Eshift.Forms.Admin
{
    public partial class Transport_units : Form
    {
        public Transport_units()
        {
            InitializeComponent();
            InitializeNavbarEvents();
            // Load Transport Units content by default
            LoadTransportUnitsContent();
        }

        private void InitializeNavbarEvents()
        {
            // Add click events for navbar buttons
            btnLorries.Click += BtnLorries_Click;
            btnDrivers.Click += BtnDrivers_Click;
            btnAssistants.Click += BtnAssistants_Click;
            btnContainer.Click += BtnContainer_Click;
            btnTransportUnit.Click += BtnTransportUnit_Click;
        }

        private void LoadFormInContainer(Form form)
        {
            // Clear existing content
            mainContentContainer.Controls.Clear();
            
            // Configure the form to be embedded
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            
            // Add to container and show
            mainContentContainer.Controls.Add(form);
            form.Show();
        }

        private void UpdateNavbarHighlight(Button activeButton)
        {
            // Reset all buttons to default color
            btnLorries.BackColor = Color.FromArgb(44, 62, 118);
            btnDrivers.BackColor = Color.FromArgb(44, 62, 118);
            btnAssistants.BackColor = Color.FromArgb(44, 62, 118);
            btnContainer.BackColor = Color.FromArgb(44, 62, 118);
            btnTransportUnit.BackColor = Color.FromArgb(44, 62, 118);
            
            // Highlight the active button
            activeButton.BackColor = Color.FromArgb(25, 42, 86);
        }

        private void BtnLorries_Click(object sender, EventArgs e)
        {
            UpdateNavbarHighlight(btnLorries);
            LoadFormInContainer(new Lorries());
        }

        private void BtnDrivers_Click(object sender, EventArgs e)
        {
            UpdateNavbarHighlight(btnDrivers);
            LoadFormInContainer(new Drivers());
        }

        private void BtnAssistants_Click(object sender, EventArgs e)
        {
            UpdateNavbarHighlight(btnAssistants);
            LoadFormInContainer(new Assistants());
        }

        private void BtnContainer_Click(object sender, EventArgs e)
        {
            UpdateNavbarHighlight(btnContainer);
            LoadFormInContainer(new Containers());
        }

        private void BtnTransportUnit_Click(object sender, EventArgs e)
        {
            UpdateNavbarHighlight(btnTransportUnit);
            LoadTransportUnitsContent();
        }

        private void LoadTransportUnitsContent()
        {
            // Create the original transport units form content
            var transportUnitsForm = CreateTransportUnitsForm();
            LoadFormInContainer(transportUnitsForm);
            UpdateNavbarHighlight(btnTransportUnit);
        }

        private Form CreateTransportUnitsForm()
        {
            // Create a form with the original transport units functionality
            var form = new Form()
            {
                Text = "Transport Units",
                BackColor = Color.FromArgb(240, 244, 248)
            };

            // Create the split-screen layout like the original design
            var contentAreaPanel = new Panel()
            {
                BackColor = Color.FromArgb(240, 244, 248),
                Dock = DockStyle.Fill
            };

            var dataGridPanel = new Panel()
            {
                BackColor = Color.White,
                Dock = DockStyle.Fill,
                Padding = new Padding(20)
            };

            var formPanel = new Panel()
            {
                BackColor = Color.FromArgb(25, 42, 86),
                Dock = DockStyle.Right,
                Size = new Size(400, 590)
            };

            // Add DataGridView
            var dtTable = new DataGridView()
            {
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal,
                Dock = DockStyle.Fill,
                EnableHeadersVisualStyles = false,
                GridColor = Color.FromArgb(230, 230, 230),
                MultiSelect = false,
                ReadOnly = true,
                RowHeadersVisible = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };

            // Style the DataGridView headers
            dtTable.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(25, 42, 86);
            dtTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtTable.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dtTable.ColumnHeadersHeight = 45;
            dtTable.RowTemplate.Height = 40;

            // Style the DataGridView cells
            dtTable.DefaultCellStyle.BackColor = Color.White;
            dtTable.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            dtTable.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dtTable.DefaultCellStyle.SelectionBackColor = Color.FromArgb(25, 42, 86);
            dtTable.DefaultCellStyle.SelectionForeColor = Color.White;

            // Create form header
            var formHeaderPanel = new Panel()
            {
                BackColor = Color.FromArgb(46, 125, 50),
                Dock = DockStyle.Top,
                Size = new Size(400, 60)
            };

            var headerLabel = new Label()
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(20, 18),
                Text = "🚢 Transport Unit Management"
            };

            // Create form fields panel
            var formFieldsPanel = new Panel()
            {
                BackColor = Color.White,
                Dock = DockStyle.Fill,
                Padding = new Padding(25)
            };

            // Create action buttons panel
            var actionButtonsPanel = new Panel()
            {
                BackColor = Color.FromArgb(240, 244, 248),
                Dock = DockStyle.Bottom,
                Size = new Size(400, 80),
                Padding = new Padding(25)
            };

            // Add ComboBoxes and Labels
            var cbLorry = CreateStyledComboBox(new Point(25, 50));
            var lblLorry = CreateStyledLabel("Lorry", new Point(25, 25));
            
            var cbDriver = CreateStyledComboBox(new Point(25, 130));
            var lblDriver = CreateStyledLabel("Driver", new Point(25, 105));
            
            var cbAssistant = CreateStyledComboBox(new Point(25, 210));
            var lblAssistant = CreateStyledLabel("Assistant", new Point(25, 185));
            
            var cbContainer = CreateStyledComboBox(new Point(25, 290));
            var lblContainer = CreateStyledLabel("Container", new Point(25, 265));

            // Add action buttons
            var btnAdd = CreateActionButton("➕ Add", new Point(115, 20), Color.FromArgb(46, 125, 50));
            var btnUpdate = CreateActionButton("✏️ Update", new Point(205, 20), Color.FromArgb(255, 152, 0));
            var btnDelete = CreateActionButton("🗑️ Delete", new Point(295, 20), Color.FromArgb(211, 47, 47));
            var btnClear = CreateActionButton("🆕 New", new Point(25, 20), Color.FromArgb(96, 125, 139));

            // Assemble the layout
            formHeaderPanel.Controls.Add(headerLabel);
            
            formFieldsPanel.Controls.AddRange(new Control[] {
                cbContainer, lblContainer, cbAssistant, lblAssistant,
                cbDriver, lblDriver, cbLorry, lblLorry
            });
            
            actionButtonsPanel.Controls.AddRange(new Control[] {
                btnDelete, btnUpdate, btnAdd, btnClear
            });
            
            formPanel.Controls.AddRange(new Control[] { 
                actionButtonsPanel, formFieldsPanel, formHeaderPanel 
            });
            
            dataGridPanel.Controls.Add(dtTable);
            contentAreaPanel.Controls.AddRange(new Control[] { dataGridPanel, formPanel });
            form.Controls.Add(contentAreaPanel);

            // Load data
            LoadTransportUnitsData(dtTable, cbLorry, cbDriver, cbAssistant, cbContainer);

            return form;
        }

        private ComboBox CreateStyledComboBox(Point location)
        {
            return new ComboBox()
            {
                BackColor = Color.White,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Segoe UI", 11F),
                ForeColor = Color.FromArgb(64, 64, 64),
                Location = location,
                Size = new Size(350, 28)
            };
        }

        private Label CreateStyledLabel(string text, Point location)
        {
            return new Label()
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = Color.FromArgb(25, 42, 86),
                Location = location,
                Text = text
            };
        }

        private Button CreateActionButton(string text, Point location, Color backgroundColor)
        {
            return new Button()
            {
                BackColor = backgroundColor,
                FlatAppearance = { BorderSize = 0 },
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.White,
                Location = location,
                Size = new Size(80, 40),
                Text = text,
                UseVisualStyleBackColor = false
            };
        }

        private async void LoadTransportUnitsData(DataGridView dtTable, ComboBox cbLorry, ComboBox cbDriver, ComboBox cbAssistant, ComboBox cbContainer)
        {
            try
            {
                var trasnportUnit = new TrasnportUnitRepository();
                
                // Load DataGridView
                DataTable dataTable = await trasnportUnit.GetAllTransportUnitsAsync();
                dtTable.DataSource = dataTable;
                dtTable.Columns["UnitID"].Visible = false;
                dtTable.Columns["LorryId"].Visible = false;
                dtTable.Columns["DriverId"].Visible = false;
                dtTable.Columns["AssistantId"].Visible = false;
                dtTable.Columns["ContainerId"].Visible = false;

                // Load ComboBoxes
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
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading transport units data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void Transport_units_Load(object sender, EventArgs e)
        {
            // The form is already loaded with transport units content by default
        }
    }
}
