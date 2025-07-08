using Eshift.DataAccess;
using Eshift.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
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
