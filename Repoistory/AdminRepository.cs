using Eshift.DataAccess;
using Eshift.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
        
        #region Admin Registration and Login
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
        #endregion
        #region Get Admin Details
        public DataTable GetAllAdmins()
        {
            using (var connection = _databaseHelper.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = @"
                SELECT 
                    a.AdminId,
                    u.UserId,
                    u.Username,
                    u.Email AS UserEmail,
                    a.Name AS AdminName,
                    a.Email AS AdminEmail,
                    u.IsActive,
                    u.CreatedAt
                FROM Admins a
                INNER JOIN Users u ON a.UserId = u.UserId
                INNER JOIN UserRoles ur ON u.UserId = ur.UserId
                INNER JOIN Roles r ON ur.RoleId = r.RoleId
                WHERE r.RoleName = 'Admin';";

                    using (var cmd = new SqlCommand(query, connection))
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable adminTable = new DataTable();
                        adapter.Fill(adminTable);
                        return adminTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching admin list: " + ex.Message);
                    return new DataTable(); // return empty table on error
                }
            }
        }
        public Admin? GetAdminById(int? adminId)
        {
            using (var connection = _databaseHelper.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = @"
        SELECT 
            a.AdminId,
            u.UserId,
            u.Username,
            u.Email AS UserEmail,
            a.Name AS AdminName,
            a.Email AS AdminEmail,
            u.IsActive,
            u.CreatedAt
        FROM Admins a
        INNER JOIN Users u ON a.UserId = u.UserId
        INNER JOIN UserRoles ur ON u.UserId = ur.UserId
        INNER JOIN Roles r ON ur.RoleId = r.RoleId
        WHERE r.RoleName = 'Admin' AND a.AdminId = @AdminId;";

                    using (var cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@AdminId", adminId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Admin
                                {
                                    AdminId = (int)reader["AdminId"],
                                    UserId = (int)reader["UserId"],
                                    Name = reader["AdminName"].ToString(),
                                    Email = reader["AdminEmail"].ToString(),
                                    Username = reader["Username"].ToString(),   
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving admin: " + ex.Message);
                }
            }

            return null;
        }
        #endregion 
        #region Update and Delete Admin
        public bool UpdateAdmin(int adminId, string name, string email, string username, string password)
        {
            using (var connection = _databaseHelper.GetConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
           
                        string? passwordHash = null;
                        if (!string.IsNullOrEmpty(password))
                        {
                            passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
                        }

                        // Update Admin table
                        string updateAdminQuery = @"
                    UPDATE Admins
                    SET Name = @Name,
                        Email = @Email
                    WHERE AdminId = @AdminId;";

                        using (var cmd = new SqlCommand(updateAdminQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@Name", name);
                            cmd.Parameters.AddWithValue("@Email", email);
                            cmd.Parameters.AddWithValue("@AdminId", adminId);
                            cmd.ExecuteNonQuery();
                        }

                        // Update Users table
                        string updateUserQuery = @"
                    UPDATE Users
                    SET Email = @Email,
                        Username = @Username,
                        PasswordHash = CASE 
                            WHEN @PasswordHash IS NOT NULL AND @PasswordHash <> '' THEN @PasswordHash
                            ELSE PasswordHash
                        END
                    WHERE UserId = (SELECT UserId FROM Admins WHERE AdminId = @AdminId);";

                        using (var cmd = new SqlCommand(updateUserQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@Email", email);
                            cmd.Parameters.AddWithValue("@Username", username);
                            cmd.Parameters.AddWithValue("@PasswordHash", (object?)passwordHash ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@AdminId", adminId);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error updating admin: " + ex.Message);
                        return false;
                    }
                }
            }
        }
        public bool DeleteAdmin(int adminId)
        {
            using (var connection = _databaseHelper.GetConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // First get the UserId for this admin
                        int userId;
                        string getUserIdQuery = "SELECT UserId FROM Admins WHERE AdminId = @AdminId;";
                        using (var cmd = new SqlCommand(getUserIdQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@AdminId", adminId);
                            var result = cmd.ExecuteScalar();
                            if (result == null)
                                return false; // Admin not found
                            userId = (int)result;
                        }

                        // Delete from UserRoles
                        string deleteUserRolesQuery = "DELETE FROM UserRoles WHERE UserId = @UserId;";
                        using (var cmd = new SqlCommand(deleteUserRolesQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@UserId", userId);
                            cmd.ExecuteNonQuery();
                        }

                        // Delete from Admins
                        string deleteAdminQuery = "DELETE FROM Admins WHERE AdminId = @AdminId;";
                        using (var cmd = new SqlCommand(deleteAdminQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@AdminId", adminId);
                            cmd.ExecuteNonQuery();
                        }

                        // Delete from Users
                        string deleteUserQuery = "DELETE FROM Users WHERE UserId = @UserId;";
                        using (var cmd = new SqlCommand(deleteUserQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@UserId", userId);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error deleting admin: " + ex.Message);
                        return false;
                    }
                }
            }
        }
        #endregion
        #region Helper Methods
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
        #endregion

    }
}
