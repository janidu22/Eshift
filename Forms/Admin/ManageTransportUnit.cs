using Eshift.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Eshift.Forms.Admin
{
    public partial class ManageTransportUnit : Form
    {
        public ManageTransportUnit()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lorries lorries = new Lorries();
            lorries.TopLevel = false;
            lorries.FormBorderStyle = FormBorderStyle.None;
            lorries.Dock = DockStyle.Fill;
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(lorries);
            lorries.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Drivers drivers = new Drivers();
            drivers.TopLevel = false;
            drivers.FormBorderStyle = FormBorderStyle.None;
            drivers.Dock = DockStyle.Fill;
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(drivers);
            drivers.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Assistants assistants = new Assistants();
            assistants.TopLevel = false;
            assistants.FormBorderStyle = FormBorderStyle.None;
            assistants.Dock = DockStyle.Fill;
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(assistants);
            assistants.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Containers containers = new Containers();
            containers.TopLevel = false;
            containers.FormBorderStyle = FormBorderStyle.None;
            containers.Dock = DockStyle.Fill;
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(containers);
            containers.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Transport_units transport_Units = new Transport_units();
            transport_Units.TopLevel = false;
            transport_Units.FormBorderStyle = FormBorderStyle.None;
            transport_Units.Dock = DockStyle.Fill;
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(transport_Units);
            transport_Units.Show();

        }

        private void ManageTransportUnit_Load(object sender, EventArgs e)
        {
            Lorries lorries = new Lorries();
            lorries.TopLevel = false;
            lorries.FormBorderStyle = FormBorderStyle.None;
            lorries.Dock = DockStyle.Fill;
            PanelMain.Controls.Add(lorries);
            lorries.Show();
        }
    }
}
