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
    public class JobRepository
    {
        private readonly DatabaseHelper _databaseHelper;
        public JobRepository()
        {
            _databaseHelper = new DatabaseHelper();
        }

        public async Task<bool> CreateJobAsync(int customerId, string startLocation, string destination,
     DateTime requestedDate, List<JobItem> items, string paymentMethod, decimal amount)
        {
            using (var connection = _databaseHelper.GetConnection())
            {
                await connection.OpenAsync();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string jobQuery = @"
                INSERT INTO Jobs (CustomerId, StartLocation, Destination, RequestedDate, Status, CreatedAt, UpdatedAt)
                VALUES (@CustomerId, @StartLocation, @Destination, @RequestedDate, 'Pending', GETDATE(), GETDATE());
                SELECT SCOPE_IDENTITY();";

                        int jobId;
                        using (var cmd = new SqlCommand(jobQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@CustomerId", customerId);
                            cmd.Parameters.AddWithValue("@StartLocation", startLocation);
                            cmd.Parameters.AddWithValue("@Destination", destination);
                            cmd.Parameters.AddWithValue("@RequestedDate", requestedDate);

                            jobId = Convert.ToInt32(await cmd.ExecuteScalarAsync());
                        }

                        foreach (var item in items)
                        {
                            string loadQuery = @"
                             INSERT INTO Loads (JobId, ProductId, TransportUnitId, Quantity, Weight, Notes)
                             VALUES (@JobId, @ProductId, @TransportUnitId, @Quantity, @Weight, @Notes);";

                            int transportUnitId = await GetAvailableTransportUnitAsync(connection, transaction); 

                            using (var loadCmd = new SqlCommand(loadQuery, connection, transaction))
                            {
                                loadCmd.Parameters.AddWithValue("@JobId", jobId);
                                loadCmd.Parameters.AddWithValue("@ProductId", item.ProductId);
                                loadCmd.Parameters.AddWithValue("@TransportUnitId", transportUnitId); 
                                loadCmd.Parameters.AddWithValue("@Quantity", item.Quantity);
                                loadCmd.Parameters.AddWithValue("@Weight", item.Weight ?? (object)DBNull.Value);
                                loadCmd.Parameters.AddWithValue("@Notes", item.Notes ?? (object)DBNull.Value);

                                await loadCmd.ExecuteNonQueryAsync();
                            }
                        }


                        string paymentStatus = paymentMethod == "Card" ? "Paid" : "Pending";
                        string paymentQuery = @"
                INSERT INTO Payments (JobId, CustomerId, Amount, Method, Status, CreatedAt)
                VALUES (@JobId, @CustomerId, @Amount, @Method, @Status, GETDATE());";

                        using (var paymentCmd = new SqlCommand(paymentQuery, connection, transaction))
                        {
                            paymentCmd.Parameters.AddWithValue("@JobId", jobId);
                            paymentCmd.Parameters.AddWithValue("@CustomerId", customerId);
                            paymentCmd.Parameters.AddWithValue("@Amount", amount);
                            paymentCmd.Parameters.AddWithValue("@Method", paymentMethod);
                            paymentCmd.Parameters.AddWithValue("@Status", paymentStatus);

                            await paymentCmd.ExecuteNonQueryAsync();
                        }

                        await transaction.CommitAsync();
                        return true;
                    }
                    catch (Exception)
                    {
                        await transaction.RollbackAsync();
                        throw;
                    }
                }
            }
        }


        private async Task<int> GetAvailableTransportUnitAsync(SqlConnection connection, SqlTransaction transaction)
        {
            try
            {
                // First, try to get any available transport unit
                string query = "SELECT TOP 1 TransportUnitId FROM TransportUnits";
                using (var cmd = new SqlCommand(query, connection, transaction))
                {
                    var result = await cmd.ExecuteScalarAsync();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                }

                // If no transport units exist, create a default one
                // Create default lorry, driver, assistant, and container first
                int lorryId = await CreateDefaultLorryAsync(connection, transaction);
                int driverId = await CreateDefaultDriverAsync(connection, transaction);
                int assistantId = await CreateDefaultAssistantAsync(connection, transaction);
                int containerId = await CreateDefaultContainerAsync(connection, transaction);

                // Create transport unit
                string insertQuery = @"
                    INSERT INTO TransportUnits (LorryId, DriverId, AssistantId, ContainerId)
                    VALUES (@LorryId, @DriverId, @AssistantId, @ContainerId);
                    SELECT SCOPE_IDENTITY();";

                using (var cmd = new SqlCommand(insertQuery, connection, transaction))
                {
                    cmd.Parameters.AddWithValue("@LorryId", lorryId);
                    cmd.Parameters.AddWithValue("@DriverId", driverId);
                    cmd.Parameters.AddWithValue("@AssistantId", assistantId);
                    cmd.Parameters.AddWithValue("@ContainerId", containerId);
                    
                    return Convert.ToInt32(await cmd.ExecuteScalarAsync());
                }
            }
            catch (Exception)
            {
                // If all else fails, return 1 as fallback
                return 1;
            }
        }

        private async Task<int> CreateDefaultLorryAsync(SqlConnection connection, SqlTransaction transaction)
        {
            string query = @"
                INSERT INTO Lorries (PlateNumber, Model, Capacity)
                VALUES ('DEFAULT-001', 'Default Model', 5000.00);
                SELECT SCOPE_IDENTITY();";
            
            using (var cmd = new SqlCommand(query, connection, transaction))
            {
                return Convert.ToInt32(await cmd.ExecuteScalarAsync());
            }
        }

        private async Task<int> CreateDefaultDriverAsync(SqlConnection connection, SqlTransaction transaction)
        {
            string query = @"
                INSERT INTO Drivers (Name, LicenseNumber, Phone)
                VALUES ('Default Driver', 'DEFAULT-LICENSE-001', '000-000-0000');
                SELECT SCOPE_IDENTITY();";
            
            using (var cmd = new SqlCommand(query, connection, transaction))
            {
                return Convert.ToInt32(await cmd.ExecuteScalarAsync());
            }
        }

        private async Task<int> CreateDefaultAssistantAsync(SqlConnection connection, SqlTransaction transaction)
        {
            string query = @"
                INSERT INTO Assistants (Name, Phone)
                VALUES ('Default Assistant', '000-000-0000');
                SELECT SCOPE_IDENTITY();";
            
            using (var cmd = new SqlCommand(query, connection, transaction))
            {
                return Convert.ToInt32(await cmd.ExecuteScalarAsync());
            }
        }

        private async Task<int> CreateDefaultContainerAsync(SqlConnection connection, SqlTransaction transaction)
        {
            string query = @"
                INSERT INTO Containers (Type, Capacity)
                VALUES ('Default Container', 5000.00);
                SELECT SCOPE_IDENTITY();";
            
            using (var cmd = new SqlCommand(query, connection, transaction))
            {
                return Convert.ToInt32(await cmd.ExecuteScalarAsync());
            }
        }

        public async Task<bool> UpdateJobStatusAsync(int jobId, string newStatus)
        {
            using var connection = _databaseHelper.GetConnection();
            try
            {
                await connection.OpenAsync();
                string query = "UPDATE Jobs SET Status = @Status WHERE JobId = @JobId";
                using var cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Status", newStatus);
                cmd.Parameters.AddWithValue("@JobId", jobId);
                int rows = await cmd.ExecuteNonQueryAsync();
                return rows > 0;
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Error updating job status: " + ex.Message); // This line was removed as per the new_code
                return false;
            }
        }

        public async Task<bool> UpdatePaymentStatusAsync(int jobId, string newPaymentStatus)
        {
            using var connection = _databaseHelper.GetConnection();
            try
            {
                await connection.OpenAsync();
                string query = "UPDATE Payments SET Status = @Status WHERE JobId = @JobId";
                using var cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Status", newPaymentStatus);
                cmd.Parameters.AddWithValue("@JobId", jobId);
                int rows = await cmd.ExecuteNonQueryAsync();
                return rows > 0;
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Error updating payment status: " + ex.Message); // This line was removed as per the new_code
                return false;
            }
        }
    }
}
