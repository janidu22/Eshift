using Eshift.DataAccess;
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
    public partial class ManageProducts : Form
    {
        private readonly ProductRepository _productRepository = new ProductRepository(new DatabaseHelper());
        private int productId = 0;


        public ManageProducts()
        {
            InitializeComponent();
        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private async void LoadProducts()
        {
            var productsTable = await _productRepository.GetAllProductsAsync();
            ViewProduct.DataSource = productsTable;
            ViewProduct.Dock = DockStyle.Fill;
            ViewProduct.RowHeadersVisible = false;
            ViewProduct.AllowUserToAddRows = false;
            ViewProduct.ReadOnly = true;
            ViewProduct.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ViewProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewProduct.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            ViewProduct.RowTemplate.Height = 28;
            ViewProduct.Columns["ProductId"].Visible = false;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var name = TbName.Text.Trim();
            var description = TbDesc.Text.Trim();

            try
            {
                var productCreated = _productRepository.CreateProductAsync(name, description);
                MessageBox.Show("Product created Successfully");
                LoadProducts();
                ClearForm();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product", ex.Message);
                throw;
            }
        }

        private void ClearForm()
        {
            TbName.Clear();
            TbDesc.Clear();
            TbName.Focus();
        }

        private async void UpdateBtn_Click(object sender, EventArgs e)
        {
            var name = TbName.Text.Trim();
            var description = TbDesc.Text.Trim();

            try
            {
                var product = await _productRepository.UpdateProductAsync(productId, name, description);
                MessageBox.Show("product updated successfully");
                LoadProducts();
                ClearForm();

                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product", ex.Message);
                throw;
            }
        }

        private void ViewProduct_SelectionChanged(object sender, EventArgs e)
        {
            if (ViewProduct.SelectedRows.Count > 0)
            {
                var selectedRow = ViewProduct.SelectedRows[0];
                productId = Convert.ToInt32(selectedRow.Cells["ProductId"].Value);
                TbName.Text = selectedRow.Cells["Name"].Value.ToString();
                TbDesc.Text = selectedRow.Cells["Description"].Value.ToString();

            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private async void DelBtn_Click(object sender, EventArgs e)
        {
            if (productId <= 0)
            {
                MessageBox.Show("Please select a valid product to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this product?",
                                          "Confirm Delete",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                var success = await _productRepository.DeleteProductWithTransactionAsync(productId);

                if (success)
                {
                    MessageBox.Show("Product deleted successfully.");
                   
                    LoadProducts(); 
                }
                else
                {
                    MessageBox.Show("Failed to delete the product.");
                }
            }
        }
    }
}
