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
    public partial class ManageCustomer : Form
    {

        private readonly CustomerRepository _customerRepository = new CustomerRepository(); 
        public ManageCustomer()
        {
            InitializeComponent();
        }

        private async void ManageCustomer_Load(object sender, EventArgs e)
        {

            DataTable customer = await _customerRepository.GetAllCustomersAsync();
            viewCustmerDt.DataSource = customer;
            viewCustmerDt.Dock = DockStyle.Fill;
            viewCustmerDt.RowHeadersVisible = false;
            viewCustmerDt.AllowUserToAddRows = false;
            viewCustmerDt.ReadOnly = true;
            viewCustmerDt.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            viewCustmerDt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewCustmerDt.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            viewCustmerDt.RowTemplate.Height = 28;


            string[] hideColNames = { "UserId",  "CustomerId" };
            foreach (string colName in hideColNames)
            {
                if (viewCustmerDt.Columns.Contains(colName))
                    viewCustmerDt.Columns[colName].Visible = false;
            }
        }
    }
}
