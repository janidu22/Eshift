using Eshift.DataAccess;
using Eshift.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eshift.Repoistory
{
    public class CustomerRepository
    {
        private readonly DatabaseHelper _dbHelper;

        public CustomerRepository()
        {
            _dbHelper = new DatabaseHelper();
        }

        public async Task<bool> RegisterCustomerAsync(string name, string email, string username, string password, string address, string phone)
        {
            using var connection = _dbHelper.GetConnection();
            await connection.OpenAsync();

            using var transaction = connection.BeginTransaction();

            try
            {
                if (await IsUsernameExistsAsync(username, connection, transaction) ||
                    await IsEmailExistsAsync(email, connection, transaction))
                {
                    return false;
                }

                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

                // Insert into Users
                string insertUserQuery = @"
                    INSERT INTO Users (Username, PasswordHash, Email, IsActive, CreatedAt) 
                    VALUES (@Username, @PasswordHash, @Email, @IsActive, @CreatedAt);
                    SELECT CAST(SCOPE_IDENTITY() AS INT);";

                int userId;
                using (var userCmd = new SqlCommand(insertUserQuery, connection, transaction))
                {
                    userCmd.Parameters.AddWithValue("@Username", username);
                    userCmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);
                    userCmd.Parameters.AddWithValue("@Email", email);
                    userCmd.Parameters.AddWithValue("@IsActive", true);
                    userCmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now);

                    userId = (int)(await userCmd.ExecuteScalarAsync() ?? 0);
                }

                int customerRoleId = await GetRoleIdAsync("Customer", connection, transaction);

                string insertUserRoleQuery = @"
                    INSERT INTO UserRoles (UserId, RoleId) 
                    VALUES (@UserId, @RoleId)";

                using (var userRoleCmd = new SqlCommand(insertUserRoleQuery, connection, transaction))
                {
                    userRoleCmd.Parameters.AddWithValue("@UserId", userId);
                    userRoleCmd.Parameters.AddWithValue("@RoleId", customerRoleId);
                    await userRoleCmd.ExecuteNonQueryAsync();
                }

                string insertCustomerQuery = @"
                    INSERT INTO Customers (UserId, Name, Address, Phone, Email) 
                    VALUES (@UserId, @Name, @Address, @Phone, @Email)";

                using (var customerCmd = new SqlCommand(insertCustomerQuery, connection, transaction))
                {
                    customerCmd.Parameters.AddWithValue("@UserId", userId);
                    customerCmd.Parameters.AddWithValue("@Name", name);
                    customerCmd.Parameters.AddWithValue("@Address", address ?? "");
                    customerCmd.Parameters.AddWithValue("@Phone", phone ?? "");
                    customerCmd.Parameters.AddWithValue("@Email", email);
                    await customerCmd.ExecuteNonQueryAsync();
                }

                await transaction.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                MessageBox.Show("An error occurred: " + ex.Message);
                return false;
            }
        }

        public async Task<Customer?> LoginCustomerAsync(string username, string password)
        {
            using var connection = _dbHelper.GetConnection();
            try
            {
                await connection.OpenAsync();

                string query = @"
                    SELECT u.UserId, u.Username, u.PasswordHash, u.Email, u.IsActive,
                           c.CustomerId, c.Name, c.Address, c.Phone, c.Email as CustomerEmail
                    FROM Users u
                    INNER JOIN Customers c ON u.UserId = c.UserId
                    INNER JOIN UserRoles ur ON u.UserId = ur.UserId
                    INNER JOIN Roles r ON ur.RoleId = r.RoleId
                    WHERE u.Username = @Username AND r.RoleName = 'Customer' AND u.IsActive = 1";

                using var cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Username", username);

                using var reader = await cmd.ExecuteReaderAsync();
                if (await reader.ReadAsync())
                {
                    string storedHash = reader["PasswordHash"].ToString()!;
                    if (BCrypt.Net.BCrypt.Verify(password, storedHash))
                    {
                        return new Customer
                        {
                            CustomerId = Convert.ToInt32(reader["CustomerId"]),
                            UserId = Convert.ToInt32(reader["UserId"]),
                            Name = reader["Name"].ToString() ?? "",
                            Address = reader["Address"].ToString() ?? "",
                            Phone = reader["Phone"].ToString() ?? "",
                            Email = reader["CustomerEmail"].ToString() ?? ""
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error: " + ex.Message);
            }
            return null;
        }

        public async Task<bool> UpdateCustomerAsync(int userId, string newName, string newEmail, string newUsername,string password, string newAddress, string newPhone)
        {
            using var connection = _dbHelper.GetConnection();
            await connection.OpenAsync();

            using var transaction = connection.BeginTransaction();
            try
            {
                string updateUserQuery = @"
                    UPDATE Users
                    SET Username = @Username, PasswordHash = @PasswordHash, Email = @Email
                    WHERE UserId = @UserId";

                using (var userCmd = new SqlCommand(updateUserQuery, connection, transaction))
                {
                    userCmd.Parameters.AddWithValue("@Username", newUsername);
                    userCmd.Parameters.AddWithValue("@PasswordHash", BCrypt.Net.BCrypt.HashPassword(password)); 
                    userCmd.Parameters.AddWithValue("@Email", newEmail);
                    userCmd.Parameters.AddWithValue("@UserId", userId);
                    await userCmd.ExecuteNonQueryAsync();
                }

                string updateCustomerQuery = @"
                    UPDATE Customers
                    SET Name = @Name, Address = @Address, Phone = @Phone, Email = @Email
                    WHERE UserId = @UserId";

                using (var customerCmd = new SqlCommand(updateCustomerQuery, connection, transaction))
                {
                    customerCmd.Parameters.AddWithValue("@Name", newName);
                    customerCmd.Parameters.AddWithValue("@Address", newAddress ?? "");
                    customerCmd.Parameters.AddWithValue("@Phone", newPhone ?? "");
                    customerCmd.Parameters.AddWithValue("@Email", newEmail);
                    customerCmd.Parameters.AddWithValue("@UserId", userId);
                    await customerCmd.ExecuteNonQueryAsync();
                }

                await transaction.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                MessageBox.Show("Update error: " + ex.Message);
                return false;
            }
        }

        public async Task<DataTable> GetAllCustomersAsync()
        {
            var customers = new List<Customer>(); 
            using var connection = _dbHelper.GetConnection();
            try
            {
                await connection.OpenAsync();

                string query = @"
                SELECT u.UserId, u.Username, u.IsActive,
                c.CustomerId, c.Name, c.Address, c.Phone, c.Email AS CustomerEmail
                FROM Users u
                JOIN Customers c ON u.UserId = c.UserId
                JOIN UserRoles ur ON u.UserId = ur.UserId
                JOIN Roles r ON ur.RoleId = r.RoleId
                 WHERE r.RoleName = 'Customer'";

                using (var cmd = new SqlCommand(query, connection))
                using (var adapter = new SqlDataAdapter(cmd))
                {
                    DataTable customerTable = new DataTable();
                    adapter.Fill(customerTable);
                    return customerTable;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching admin list: " + ex.Message);
                return new DataTable(); 
            }
          
        }

        public async Task<Customer?> GetCustomerByUsernameAsync(string username)
        {
            using var connection = _dbHelper.GetConnection();
            try
            {
                await connection.OpenAsync();

                string query = @"
                    SELECT u.UserId, u.Username, u.Email AS UserEmail, u.IsActive, u.CreatedAt,
                           c.CustomerId, c.Name, c.Address, c.Phone, c.Email AS CustomerEmail
                    FROM Users u
                    JOIN Customers c ON u.UserId = c.UserId
                    JOIN UserRoles ur ON u.UserId = ur.UserId
                    JOIN Roles r ON ur.RoleId = r.RoleId
                    WHERE u.Username = @Username AND r.RoleName = 'Customer'";

                using var cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Username", username);

                using var reader = await cmd.ExecuteReaderAsync();
                if (await reader.ReadAsync())
                {
                    return new Customer
                    {
                        CustomerId = Convert.ToInt32(reader["CustomerId"]),
                        UserId = Convert.ToInt32(reader["UserId"]),
                        Name = reader["Name"].ToString() ?? "",
                        Address = reader["Address"].ToString() ?? "",
                        Phone = reader["Phone"].ToString() ?? "",
                        Email = reader["CustomerEmail"].ToString() ?? ""
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fetch error: " + ex.Message);
            }
            return null;
        }

        public async Task<DataTable> GetJobsByCustomerIdAsync(int customerId)
        {
            using var connection = _dbHelper.GetConnection();
            var jobsTable = new DataTable();

            try
            {
                await connection.OpenAsync();
                string query = @"SELECT * FROM Jobs WHERE CustomerId = @CustomerId";

                using var cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@CustomerId", customerId);

                using var reader = await cmd.ExecuteReaderAsync();
                jobsTable.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching jobs: " + ex.Message);
            }

            return jobsTable;
        }

        public async Task<DataTable> GetAllJobsAsync()
        {
            using var connection = _dbHelper.GetConnection();
            var jobsTable = new DataTable();

            try
            {
                await connection.OpenAsync();
                string query = "SELECT * FROM Jobs";

                using var cmd = new SqlCommand(query, connection);
                using var reader = await cmd.ExecuteReaderAsync();
                jobsTable.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching all jobs: " + ex.Message);
            }

            return jobsTable;
        }

        public async Task<DataTable> GetAllJobsWithPaymentStatusAsync()
        {
            using var connection = _dbHelper.GetConnection();
            var jobsTable = new DataTable();

            try
            {
                await connection.OpenAsync();
                string query = @"
            SELECT
                j.JobId,
                c.Name AS CustomerName,
                c.CustomerId,
                j.StartLocation,
                j.Destination,
                j.RequestedDate,
                j.Status AS JobStatus,
                l.PlateNumber AS Lorry,
                d.Name AS Driver,
                a.Name AS Assistant,
                p.Status AS PaymentStatus,
                p.Method AS PaymentMethod,
                p.Amount,
                j.CreatedAt,
                j.UpdatedAt
            FROM Jobs j
            INNER JOIN Customers c ON j.CustomerId = c.CustomerId
            LEFT JOIN Admins adm ON j.AdminId = adm.AdminId
            LEFT JOIN Loads ld ON ld.JobId = j.JobId
            LEFT JOIN TransportUnits tu ON ld.TransportUnitId = tu.TransportUnitId
            LEFT JOIN Lorries l ON tu.LorryId = l.LorryId
            LEFT JOIN Drivers d ON tu.DriverId = d.DriverId
            LEFT JOIN Assistants a ON tu.AssistantId = a.AssistantId
            LEFT JOIN Payments p ON j.JobId = p.JobId
            ORDER BY j.RequestedDate DESC, j.JobId;
        ";

                using var cmd = new SqlCommand(query, connection);
                using var reader = await cmd.ExecuteReaderAsync();
                jobsTable.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching jobs with payment status: " + ex.Message);
            }

            return jobsTable;
        }

        public async Task<DataTable> GetLoadsForJobAsync(int jobId)
        {
            using var connection = _dbHelper.GetConnection();
            try
            {
                await connection.OpenAsync();
                string query = @"
            SELECT 
                l.LoadId, 
                p.Name AS Product, 
                'Lorry: ' + lo.PlateNumber + 
                ', Driver: ' + d.Name + 
                ', Assistant: ' + a.Name + 
                ', Container: ' + c.Type AS TransportUnit,
                l.Quantity, 
                l.Weight, 
                l.Notes
            FROM Loads l
            INNER JOIN Products p ON l.ProductId = p.ProductId
            INNER JOIN TransportUnits t ON l.TransportUnitId = t.TransportUnitId
            INNER JOIN Lorries lo ON t.LorryId = lo.LorryId
            INNER JOIN Drivers d ON t.DriverId = d.DriverId
            INNER JOIN Assistants a ON t.AssistantId = a.AssistantId
            INNER JOIN Containers c ON t.ContainerId = c.ContainerId
            WHERE l.JobId = @JobId
            ORDER BY l.LoadId DESC";
                using (var cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@JobId", jobId);
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable loadsTable = new DataTable();
                        adapter.Fill(loadsTable);
                        return loadsTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading loads: " + ex.Message);
                return new DataTable();
            }
        }

        private async Task<bool> IsUsernameExistsAsync(string username, SqlConnection connection, SqlTransaction transaction)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
            using var cmd = new SqlCommand(query, connection, transaction);
            cmd.Parameters.AddWithValue("@Username", username);
            int count = (int)(await cmd.ExecuteScalarAsync() ?? 0);
            return count > 0;
        }

        private async Task<bool> IsEmailExistsAsync(string email, SqlConnection connection, SqlTransaction transaction)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
            using var cmd = new SqlCommand(query, connection, transaction);
            cmd.Parameters.AddWithValue("@Email", email);
            int count = (int)(await cmd.ExecuteScalarAsync() ?? 0);
            return count > 0;
        }

        private async Task<int> GetRoleIdAsync(string roleName, SqlConnection connection, SqlTransaction transaction)
        {
            string query = "SELECT RoleId FROM Roles WHERE RoleName = @RoleName";
            using var cmd = new SqlCommand(query, connection, transaction);
            cmd.Parameters.AddWithValue("@RoleName", roleName);
            var result = await cmd.ExecuteScalarAsync();
            return result != null ? (int)result : 0;
        }

        public async Task<bool> DeleteUserAndCustomerAsync(int userId)
        {
            using var connection = _dbHelper.GetConnection();
            await connection.OpenAsync();
            using var transaction = connection.BeginTransaction();

            try
            {
                // Step 1: Delete Customer(s) linked to this UserId
                var deleteCustomerQuery = "DELETE FROM Customers WHERE UserId = @UserId";
                using (var deleteCustomerCmd = new SqlCommand(deleteCustomerQuery, connection, transaction))
                {
                    deleteCustomerCmd.Parameters.AddWithValue("@UserId", userId);
                    await deleteCustomerCmd.ExecuteNonQueryAsync();
                }

                // Step 2: Delete the User
                var deleteUserQuery = "DELETE FROM Users WHERE UserId = @UserId";
                using (var deleteUserCmd = new SqlCommand(deleteUserQuery, connection, transaction))
                {
                    deleteUserCmd.Parameters.AddWithValue("@UserId", userId);
                    await deleteUserCmd.ExecuteNonQueryAsync();
                }

                // Step 3: Commit all changes
                await transaction.CommitAsync();
                return true;
            }
            catch (Exception)
            {
                // Rollback in case of error
                await transaction.RollbackAsync();
                return false;
            }
        }


    }
}
