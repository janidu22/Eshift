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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.Owner is MainForm main)
            {
                main.LoadCustomerForm();
            }
            else
            {
                MessageBox.Show("Parent form is not set correctly.");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (this.Owner is MainForm main)
            {
                main.LoadAdminForm();
            }
            else
            {
                MessageBox.Show("Parent form is not set correctly.");
            }
        }
    }
}
