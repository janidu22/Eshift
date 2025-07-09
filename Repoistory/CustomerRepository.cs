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
    public class CustomerRepository
    {
        private readonly DatabaseHelper _dbHelper;

        public CustomerRepository()
        {
            _dbHelper = new DatabaseHelper();
        }

        public bool RegisterCustomer(string name, string email, string username, string password, string address, string phone)
        {
            using (var connection = _dbHelper.GetConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                       
                        // Check if username or email already exists
                        if (IsUsernameExists(username, connection, transaction) || IsEmailExists(email, connection, transaction))
                        {
                            return false;
                        }

                        // Hash the password
                        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

                        // Insert into Users table
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

                            userId = (int)userCmd.ExecuteScalar();
                        }

                        // Get Customer Role ID (assuming role "Customer" exists)
                        int customerRoleId = GetRoleId("Customer", connection, transaction);

                        // Insert into UserRoles table
                        string insertUserRoleQuery = @"
                            INSERT INTO UserRoles (UserId, RoleId) 
                            VALUES (@UserId, @RoleId)";

                        using (var userRoleCmd = new SqlCommand(insertUserRoleQuery, connection, transaction))
                        {
                            userRoleCmd.Parameters.AddWithValue("@UserId", userId);
                            userRoleCmd.Parameters.AddWithValue("@RoleId", customerRoleId);
                            userRoleCmd.ExecuteNonQuery();
                        }

                        // Insert into Customers table
                        string insertCustomerQuery = @"
                            INSERT INTO Customers (UserId, Name, Address, Phone, Email) 
                            VALUES (@UserId, @Name, @Address, @Phone, @Email)";

                        using (var customerCmd = new SqlCommand(insertCustomerQuery, connection, transaction))
                        {
                            customerCmd.Parameters.AddWithValue("@UserId", userId);
                            customerCmd.Parameters.AddWithValue("@Name", name);
                            customerCmd.Parameters.AddWithValue("@Address", address ?? string.Empty);
                            customerCmd.Parameters.AddWithValue("@Phone", phone ?? string.Empty);
                            customerCmd.Parameters.AddWithValue("@Email", email);
                            customerCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;

                 
                    }
                    catch (SqlException ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("An error occurred while registering the customer: " + ex.Message);
                        return false;

                    }
                    catch(Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("An error occurred while registering the customer: " + ex.Message);
                        return false;

                    }
                }
            }
        }

        public Customer? LoginCustomer(string username, string password)
        {
            using (var connection = _dbHelper.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = @"
                        SELECT u.UserId, u.Username, u.PasswordHash, u.Email, u.IsActive,
                               c.CustomerId, c.Name, c.Address, c.Phone, c.Email as CustomerEmail
                        FROM Users u
                        INNER JOIN Customers c ON u.UserId = c.UserId
                        INNER JOIN UserRoles ur ON u.UserId = ur.UserId
                        INNER JOIN Roles r ON ur.RoleId = r.RoleId
                        WHERE u.Username = @Username AND r.RoleName = 'Customer' AND u.IsActive = 1";

                    using (var cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedHash = reader["PasswordHash"].ToString();

                                // Verify password
                                if (BCrypt.Net.BCrypt.Verify(password, storedHash))
                                {
                                    return new Customer
                                    {
                                        CustomerId = (int)reader["CustomerId"],
                                        UserId = (int)reader["UserId"],
                                        Name = reader["Name"].ToString(),
                                        Address = reader["Address"].ToString(),
                                        Phone = reader["Phone"].ToString(),
                                        Email = reader["CustomerEmail"].ToString()
                                    };
                                }
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while logging in: " + ex.Message);
                }
                catch (Exception ex)
                {
                  
                    MessageBox.Show("An error occurred while logging in: " + ex.Message);
                }
            }
            return null;
        }

        public bool UpdateCustomer(int userId, string newName, string newEmail, string newUsername, string newAddress, string newPhone)
        {
            using (var connection = _dbHelper.GetConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // 1. Update Users table
                        string updateUserQuery = @"
                    UPDATE Users
                    SET Username = @Username,
                        Email = @Email
                    WHERE UserId = @UserId";

                        using (var userCmd = new SqlCommand(updateUserQuery, connection, transaction))
                        {
                            userCmd.Parameters.AddWithValue("@Username", newUsername);
                            userCmd.Parameters.AddWithValue("@Email", newEmail);
                            userCmd.Parameters.AddWithValue("@UserId", userId);
                            userCmd.ExecuteNonQuery();
                        }

                        // 2. Update Customers table
                        string updateCustomerQuery = @"
                    UPDATE Customers
                    SET Name = @Name,
                        Address = @Address,
                        Phone = @Phone,
                        Email = @Email
                    WHERE UserId = @UserId";

                        using (var customerCmd = new SqlCommand(updateCustomerQuery, connection, transaction))
                        {
                            customerCmd.Parameters.AddWithValue("@Name", newName);
                            customerCmd.Parameters.AddWithValue("@Address", newAddress ?? string.Empty);
                            customerCmd.Parameters.AddWithValue("@Phone", newPhone ?? string.Empty);
                            customerCmd.Parameters.AddWithValue("@Email", newEmail);
                            customerCmd.Parameters.AddWithValue("@UserId", userId);
                            customerCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (SqlException ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("An error occurred while updating the customer: " + ex.Message);
                        return false;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("An error occurred while updating the customer: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public Customer? GetCustomerByUsername(string username)
        {
            using (var connection = _dbHelper.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = @"
                SELECT u.UserId, u.Username, u.Email AS UserEmail, u.IsActive, u.CreatedAt,
                       c.CustomerId, c.Name, c.Address, c.Phone, c.Email AS CustomerEmail
                FROM Users u
                JOIN Customers c ON u.UserId = c.UserId
                JOIN UserRoles ur ON u.UserId = ur.UserId
                JOIN Roles r ON ur.RoleId = r.RoleId
                WHERE u.Username = @Username AND r.RoleName = 'Customer'";

                    using (var cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Customer
                                {
                                    CustomerId = (int)reader["CustomerId"],
                                    UserId = (int)reader["UserId"],
                                    Username = reader["Username"].ToString(),
                                    Name = reader["Name"].ToString(),
                                    Address = reader["Address"].ToString(),
                                    Phone = reader["Phone"].ToString(),
                                    Email = reader["CustomerEmail"].ToString(),
                                    CreatedAt = (DateTime)reader["CreatedAt"],
                                    IsActive = (bool)reader["IsActive"]
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving customer: " + ex.Message);
                }
            }

            return null;
        }

        public DataTable GetJobsByCustomerId(int customerId)
        {
            DataTable dt = new DataTable();

            string query = @"
        SELECT
            j.JobId,
            j.StartLocation,
            j.Destination,
            j.RequestedDate,
            j.Status,
            l.PlateNumber AS Lorry,
            d.Name AS Driver,
            a.Name AS Assistant,
            ISNULL(p.Status, 'No Payment') AS PaymentStatus,
            p.Method AS PaymentMethod,
            p.Amount,
            p.PaidAt,
            j.CreatedAt,
            j.UpdatedAt
        FROM Jobs j
        LEFT JOIN Loads ld ON j.JobId = ld.JobId
        LEFT JOIN TransportUnits tu ON ld.TransportUnitId = tu.TransportUnitId
        LEFT JOIN Lorries l ON tu.LorryId = l.LorryId
        LEFT JOIN Drivers d ON tu.DriverId = d.DriverId
        LEFT JOIN Assistants a ON tu.AssistantId = a.AssistantId
        LEFT JOIN Payments p ON j.JobId = p.JobId
        WHERE j.CustomerId = @CustomerId
        GROUP BY
            j.JobId, j.StartLocation, j.Destination, j.RequestedDate, j.Status,
            l.PlateNumber, d.Name, a.Name, p.Status, p.Method, p.Amount, p.PaidAt,
            j.CreatedAt, j.UpdatedAt
        ORDER BY j.JobId DESC;
    ";

            using (var connection = _dbHelper.GetConnection())
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CustomerId", customerId);

                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
            }

            return dt;
        }



        private bool IsUsernameExists(string username, SqlConnection connection, SqlTransaction transaction)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
            using (var cmd = new SqlCommand(query, connection, transaction))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        private bool IsEmailExists(string email, SqlConnection connection, SqlTransaction transaction)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
            using (var cmd = new SqlCommand(query, connection, transaction))
            {
                cmd.Parameters.AddWithValue("@Email", email);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        private int GetRoleId(string roleName, SqlConnection connection, SqlTransaction transaction)
        {
            string query = "SELECT RoleId FROM Roles WHERE RoleName = @RoleName";
            using (var cmd = new SqlCommand(query, connection, transaction))
            {
                cmd.Parameters.AddWithValue("@RoleName", roleName);
                var result = cmd.ExecuteScalar();
                return result != null ? (int)result : 0;
            }
        }
    }
}
