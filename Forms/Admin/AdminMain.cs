
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

namespace Eshift.Forms.Admin
{
    public partial class AdminMain : Form
    {
      

    public AdminMain()
    {
        InitializeComponent();
       

        // Optional: lblName.Text = _admin.Name;
    }

        private void NewJobs_Click(object sender, EventArgs e)
        {
            NewJob newJob = new NewJob();
            newJob.TopLevel = false;
            newJob.FormBorderStyle = FormBorderStyle.None;
            newJob.Dock = DockStyle.Fill;
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(newJob);
            newJob.Show();


        }

        private void ViewJobs_Click(object sender, EventArgs e)
        {
            ViewJobs viewJobs = new ViewJobs();
            viewJobs.TopLevel = false;
            viewJobs.FormBorderStyle = FormBorderStyle.None;
            viewJobs.Dock = DockStyle.Fill;
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(viewJobs);
            viewJobs.Show();

        }

        private void AdminManagement_Click(object sender, EventArgs e)
        {
            
            ManageAdmin manageAdmin = new ManageAdmin();
            manageAdmin.TopLevel = false;
            manageAdmin.FormBorderStyle = FormBorderStyle.None;
            manageAdmin.Dock = DockStyle.Fill;
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(manageAdmin);
            manageAdmin.Show();
        }

        private void PanelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
