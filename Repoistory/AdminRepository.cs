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
                        // Check if email already exists
                        if (IsEmailExists(email, connection, transaction))
                        {
                            return false;
                        }

                        if (IsUsernameExists(username, connection, transaction))
                        {
                            return false;
                        }

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
                        int adminRoleId = GetRoleId("Admin", connection, transaction);

                        // Insert into UserRoles table
                        string insertUserRoleQuery = @"
                            INSERT INTO UserRoles (UserId, RoleId) 
                            VALUES (@UserId, @RoleId)";

                        using (var userRoleCmd = new SqlCommand(insertUserRoleQuery, connection, transaction))
                        {
                            userRoleCmd.Parameters.AddWithValue("@UserId", userId);
                            userRoleCmd.Parameters.AddWithValue("@RoleId", adminRoleId);
                            userRoleCmd.ExecuteNonQuery();
                        }

                        // Insert into Admins table
                        string insertAdminQuery = @"
                            INSERT INTO Admins (Name, Email, CreatedAt) 
                            VALUES (@Name, @Email, @CreatedAt);";
                        using (var cmd = new SqlCommand(insertAdminQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@Name", name);
                            cmd.Parameters.AddWithValue("@Email", email);
                            cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                            cmd.ExecuteNonQuery();
                        }
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {

                        transaction.Rollback();
                        MessageBox.Show("An error occurred while registering the customer: " + ex.Message);
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
                SELECT u.UserId,u.Username,u.passwordhash, u.Email, u.IsActive, u.CreatedAt ,
		        a.AdminID, a.UserId, a.Name, a.Email
		        FROM Users u
		        INNER JOIN Admins a ON u.UserId = a.AdminId
		        INNER JOIN UserRoles ur ON u.UserId = ur.UserId
		        INNER JOIN Roles r ON ur.RoleId = r.RoleId
		        WHERE u.Username = Username AND r.RoleName = 'Admin' AND u.IsActive = 1;";

                    using (var cmd = new SqlCommand(query,connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        using (var reader = cmd.ExecuteReader())
                        {
                           if(reader.Read())
                            {
                                string storedHash = reader["PasswordHash"].ToString();

                                if(BCrypt.Net.BCrypt.Verify(password,storedHash))
                                {
                                    return new Admin
                                    {
                                        AdminId = (int)reader["AdminId"],
                                        UserId = (int)reader["UserId"],
                                        Name = reader["Name"].ToString(),
                                        Email = reader["Email"].ToString(), 
                                    };
                                }
                            }

                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while Login as an Admin: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while Login as an Admin: " + ex.Message);
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
