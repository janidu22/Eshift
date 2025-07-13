using Eshift.DataAccess;
using Eshift.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshift.Repoistory
{
    public class ProductRepository
    {
        private readonly DatabaseHelper _databaseHelper;

        public ProductRepository(DatabaseHelper databaseHelper)
        {
            _databaseHelper = databaseHelper;
        }

        public async Task<DataTable> GetAllProductsAsync()
        {
            var Products = new List<Product>();
            using var connection = _databaseHelper.GetConnection();
            try
            {
                await connection.OpenAsync();

                var query = "SELECT * FROM Products";

                using (var cmd = new SqlCommand(query, connection))
                using (var adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching products: {ex.Message}");
                return null;
            }
        }

        public async Task<bool> CreateProductAsync(string name,string description)
        {
            using var connection = _databaseHelper.GetConnection();
            try
            {
                await connection.OpenAsync();

                var query = "INSERT INTO Products (Name, Description) VALUES (@Name, @Description)";
                using var cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Description", description);

                int result = await cmd.ExecuteNonQueryAsync();
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting product: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> UpdateProductAsync(int productId, string name ,string description)
        {
            using var connection = _databaseHelper.GetConnection();
            try
            {
                await connection.OpenAsync();

                var query = "UPDATE Products SET Name = @Name, Description = @Description WHERE ProductId = @ProductId";
                using var cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@ProductId", productId );

                int result = await cmd.ExecuteNonQueryAsync();
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating product: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> DeleteProductWithTransactionAsync(int productId)
        {
            using var connection = _databaseHelper.GetConnection();
            await connection.OpenAsync();

            using var transaction = connection.BeginTransaction();

            try
            {
                // Step 1: Delete from Loads where ProductId = @ProductId
                var deleteLoadsQuery = "DELETE FROM Loads WHERE ProductId = @ProductId";
                using (var cmd1 = new SqlCommand(deleteLoadsQuery, connection, transaction))
                {
                    cmd1.Parameters.AddWithValue("@ProductId", productId);
                    await cmd1.ExecuteNonQueryAsync();
                }

                // Step 2: Delete from Products where ProductId = @ProductId
                var deleteProductQuery = "DELETE FROM Products WHERE ProductId = @ProductId";
                using (var cmd2 = new SqlCommand(deleteProductQuery, connection, transaction))
                {
                    cmd2.Parameters.AddWithValue("@ProductId", productId);
                    int rowsAffected = await cmd2.ExecuteNonQueryAsync();

                    if (rowsAffected == 0)
                    {
                        // Product not found — rollback
                        transaction.Rollback();
                        MessageBox.Show("Product not found.");
                        return false;
                    }
                }

                // All successful — commit transaction
                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                // Something went wrong — rollback everything
                try { transaction.Rollback(); } catch { }
                MessageBox.Show($"Transaction failed: {ex.Message}");
                return false;
            }
        }

    }
}
