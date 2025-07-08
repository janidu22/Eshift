using Eshift.DataAccess;
using Eshift.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Eshift.Repoistory
{
    public class AdminRepository
    {
        private readonly DatabaseHelper _databaseHelper;

        public AdminRepository()
        {
            _databaseHelper = new DatabaseHelper();
        }

        public bool RegisterAdmin(string name, string email, string username, string password)
        {
            using (var connection = _databaseHelper.GetConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Check if email or username already exists
                        if (IsEmailExists(email, connection, transaction) || IsUsernameExists(username, connection, transaction))
                            return false;

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

                            userId = (int)userCmd.ExecuteScalar();
                        }

                        // Get Admin Role ID
                        int adminRoleId = GetRoleId("Admin", connection, transaction);

                        // Insert into UserRoles
                        string insertUserRoleQuery = @"
                            INSERT INTO UserRoles (UserId, RoleId) 
                            VALUES (@UserId, @RoleId);";

                        using (var userRoleCmd = new SqlCommand(insertUserRoleQuery, connection, transaction))
                        {
                            userRoleCmd.Parameters.AddWithValue("@UserId", userId);
                            userRoleCmd.Parameters.AddWithValue("@RoleId", adminRoleId);
                            userRoleCmd.ExecuteNonQuery();
                        }

                        // Insert into Admins
                        string insertAdminQuery = @"
                            INSERT INTO Admins (UserId, Name, Email) 
                            VALUES (@UserId, @Name, @Email);";

                        using (var adminCmd = new SqlCommand(insertAdminQuery, connection, transaction))
                        {
                            adminCmd.Parameters.AddWithValue("@UserId", userId);
                            adminCmd.Parameters.AddWithValue("@Name", name);
                            adminCmd.Parameters.AddWithValue("@Email", email);
                            adminCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("An error occurred while registering the admin: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public Admin? LoginAdmin(string username, string password)
        {
            using (var connection = _databaseHelper.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = @"
                        SELECT u.UserId, u.Username, u.PasswordHash, u.Email AS UserEmail, u.IsActive, u.CreatedAt,
                               a.AdminId, a.UserId AS AdminUserId, a.Name, a.Email AS AdminEmail
                        FROM Users u
                        INNER JOIN Admins a ON u.UserId = a.UserId
                        INNER JOIN UserRoles ur ON u.UserId = ur.UserId
                        INNER JOIN Roles r ON ur.RoleId = r.RoleId
                        WHERE u.Username = @Username AND r.RoleName = 'Admin' AND u.IsActive = 1;";

                    using (var cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedHash = reader["PasswordHash"].ToString();

                                if (BCrypt.Net.BCrypt.Verify(password, storedHash))
                                {
                                    return new Admin
                                    {
                                        AdminId = (int)reader["AdminId"],
                                        UserId = (int)reader["AdminUserId"],
                                        Name = reader["Name"].ToString(),
                                        Email = reader["AdminEmail"].ToString()
                                    };
                                }
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while logging in as Admin: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message);
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
