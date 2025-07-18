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

                            userId = (userCmd.ExecuteScalar() as int?) ?? 0;
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
                                    int adminIdOrdinal = reader.GetOrdinal("AdminId");
                                    int adminUserIdOrdinal = reader.GetOrdinal("AdminUserId");
                                    int nameOrdinal = reader.GetOrdinal("Name");
                                    int emailOrdinal = reader.GetOrdinal("AdminEmail");
                                    return new Admin
                                    {
                                        AdminId = !reader.IsDBNull(adminIdOrdinal) ? reader.GetInt32(adminIdOrdinal) : 0,
                                        UserId = !reader.IsDBNull(adminUserIdOrdinal) ? reader.GetInt32(adminUserIdOrdinal) : 0,
                                        Name = !reader.IsDBNull(nameOrdinal) ? reader.GetString(nameOrdinal) : string.Empty,
                                        Email = !reader.IsDBNull(emailOrdinal) ? reader.GetString(emailOrdinal) : string.Empty
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
                                    AdminId = Convert.ToInt32(reader["AdminId"]),
                                    UserId = Convert.ToInt32(reader["UserId"]),
                                    Name = reader["AdminName"]?.ToString() ?? string.Empty,
                                    Email = reader["AdminEmail"]?.ToString() ?? string.Empty,
                                    Username = reader["Username"]?.ToString() ?? string.Empty,
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

        public async Task<Admin?> GetAdminByUsernameAsync(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                return null;
            }

            using var connection = _databaseHelper.GetConnection();
            try
            {
                await connection.OpenAsync();

                string query = @"
            SELECT 
                a.AdminId, 
                a.Name AS AdminName, 
                u.Username, 
                a.Email AS AdminEmail
            FROM Admins a
            INNER JOIN Users u ON a.UserId = u.UserId
            WHERE u.Username = @Username";

                using var cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Username", username);

                using var reader = await cmd.ExecuteReaderAsync();
                if (await reader.ReadAsync())
                {
                    return new Admin
                    {
                        AdminId = Convert.ToInt32(reader["AdminId"]),
                        Name = reader["AdminName"]?.ToString() ?? "",
                        Username = reader["Username"]?.ToString() ?? "",
                        Email = reader["AdminEmail"]?.ToString() ?? ""
                    };
                }
            }
            catch (Exception ex)
            {
                // Don't show message box here, just log the error
                System.Diagnostics.Debug.WriteLine($"Error fetching admin by username: {ex.Message}");
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
                        // Check if username or email already exists (excluding current admin)
                        var currentAdmin = GetAdminById(adminId);
                        if (currentAdmin == null)
                        {
                            MessageBox.Show("Admin not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }

                        // Check if new username exists (excluding current admin)
                        if (username != currentAdmin.Username && IsUsernameExists(username, connection, transaction))
                        {
                            MessageBox.Show("Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }

                        // Check if new email exists (excluding current admin)
                        if (email != currentAdmin.Email && IsEmailExists(email, connection, transaction))
                        {
                            MessageBox.Show("Email already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }

                        // 1. Update Users table
                        string updateUserQuery;
                        if (!string.IsNullOrWhiteSpace(password))
                        {
                            // Update with new password
                            updateUserQuery = @"
                        UPDATE Users
                        SET Username = @Username,
                            Email = @Email,
                            PasswordHash = @PasswordHash
                        WHERE UserId = (SELECT UserId FROM Admins WHERE AdminId = @AdminId)";

                            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

                            using (var userCmd = new SqlCommand(updateUserQuery, connection, transaction))
                            {
                                userCmd.Parameters.AddWithValue("@Username", username);
                                userCmd.Parameters.AddWithValue("@Email", email);
                                userCmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);
                                userCmd.Parameters.AddWithValue("@AdminId", adminId);
                                userCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Update without changing password
                            updateUserQuery = @"
                        UPDATE Users
                        SET Username = @Username,
                            Email = @Email
                        WHERE UserId = (SELECT UserId FROM Admins WHERE AdminId = @AdminId)";

                            using (var userCmd = new SqlCommand(updateUserQuery, connection, transaction))
                            {
                                userCmd.Parameters.AddWithValue("@Username", username);
                                userCmd.Parameters.AddWithValue("@Email", email);
                                userCmd.Parameters.AddWithValue("@AdminId", adminId);
                                userCmd.ExecuteNonQuery();
                            }
                        }

                        // 2. Update Admins table
                        string updateAdminQuery = @"
                    UPDATE Admins
                    SET Name = @Name,
                        Email = @Email
                    WHERE AdminId = @AdminId";

                        using (var adminCmd = new SqlCommand(updateAdminQuery, connection, transaction))
                        {
                            adminCmd.Parameters.AddWithValue("@Name", name);
                            adminCmd.Parameters.AddWithValue("@Email", email);
                            adminCmd.Parameters.AddWithValue("@AdminId", adminId);
                            adminCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("An error occurred while updating the admin: " + ex.Message);
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
                        // 1. Delete from Admins table
                        string deleteAdminQuery = @"DELETE FROM Admins WHERE AdminId = @AdminId";
                        using (var adminCmd = new SqlCommand(deleteAdminQuery, connection, transaction))
                        {
                            adminCmd.Parameters.AddWithValue("@AdminId", adminId);
                            adminCmd.ExecuteNonQuery();
                        }

                        // 2. Delete from UserRoles and Users
                        string deleteUserRoleQuery = @"DELETE FROM UserRoles WHERE UserId = (SELECT UserId FROM Admins WHERE AdminId = @AdminId)";
                        using (var userRoleCmd = new SqlCommand(deleteUserRoleQuery, connection, transaction))
                        {
                            userRoleCmd.Parameters.AddWithValue("@AdminId", adminId);
                            userRoleCmd.ExecuteNonQuery();
                        }
                        string deleteUserQuery = @"DELETE FROM Users WHERE UserId = (SELECT UserId FROM Admins WHERE AdminId = @AdminId)";
                        using (var userCmd = new SqlCommand(deleteUserQuery, connection, transaction))
                        {
                            userCmd.Parameters.AddWithValue("@AdminId", adminId);
                            userCmd.ExecuteNonQuery();
                        }
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("An error occurred while deleting the admin: " + ex.Message);
                        return false;
                    }
                }
            }
        }
        #endregion
        #region Helper Methods
        public bool IsUsernameExists(string username)
        {
            using (var connection = _databaseHelper.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                    using (var cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        int count = (cmd.ExecuteScalar() as int?) ?? 0;
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error checking username existence: " + ex.Message);
                    return false;
                }
            }
        }

        public bool IsEmailExists(string email)
        {
            using (var connection = _databaseHelper.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
                    using (var cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        int count = (cmd.ExecuteScalar() as int?) ?? 0;
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error checking email existence: " + ex.Message);
                    return false;
                }
            }
        }

        private bool IsUsernameExists(string username, SqlConnection connection, SqlTransaction transaction)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
            using (var cmd = new SqlCommand(query, connection, transaction))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                int count = (cmd.ExecuteScalar() as int?) ?? 0;
                return count > 0;
            }
        }
        private bool IsEmailExists(string email, SqlConnection connection, SqlTransaction transaction)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
            using (var cmd = new SqlCommand(query, connection, transaction))
            {
                cmd.Parameters.AddWithValue("@Email", email);
                int count = (cmd.ExecuteScalar() as int?) ?? 0;
                return count > 0;
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
