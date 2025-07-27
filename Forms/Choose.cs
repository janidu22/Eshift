using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eshift.Forms
{
    public partial class Choose : Form
    {
        public Choose()
        {
            InitializeComponent();
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            if (this.Owner is MainForm main)
            {
                main.LoadCustomerForm();
            }
            else
            {
                MessageBox.Show("Parent form is not set correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            if (this.Owner is MainForm main)
            {
                main.LoadAdminForm();
            }
            else
            {
                MessageBox.Show("Parent form is not set correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Choose_Load(object sender, EventArgs e)
        {
            // Set focus to the form for better user experience
            this.Focus();
        }

        private void headerLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
