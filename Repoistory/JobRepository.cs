using Eshift.DataAccess;
using Eshift.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json;
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

        // Customer creates a job: only insert into Jobs and Payments, store requested products as JSON
        // Change this:
        public async Task<bool> CreateJobAsync(int customerId, string startLocation, string destination,
            DateTime requestedDate, string requestedProducts, string paymentMethod, decimal amount, int quantity,int weight,string notes)
        {
            using (var connection = _databaseHelper.GetConnection())
            {
                await connection.OpenAsync();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // No need to serialize, just use the string
                        string jobQuery = @"
                    INSERT INTO Jobs (CustomerId, StartLocation, Destination, RequestedDate, Status, CreatedAt, UpdatedAt, RequestedProducts,RequestedQuantity,RequestedWeight,RequestedNotes)
                    VALUES (@CustomerId, @StartLocation, @Destination, @RequestedDate, 'Pending', GETDATE(), GETDATE(), @RequestedProducts,@RequestedQuantity,@RequestedWeight,@RequestedNotes);
                    SELECT SCOPE_IDENTITY();";

                        int jobId;
                        using (var cmd = new SqlCommand(jobQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@CustomerId", customerId);
                            cmd.Parameters.AddWithValue("@StartLocation", startLocation);
                            cmd.Parameters.AddWithValue("@Destination", destination);
                            cmd.Parameters.AddWithValue("@RequestedDate", requestedDate);
                            cmd.Parameters.AddWithValue("@RequestedProducts", requestedProducts ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("@RequestedQuantity",quantity);
                            cmd.Parameters.AddWithValue("@RequestedWeight", weight );
                            cmd.Parameters.AddWithValue("@RequestedNotes", notes);

                            jobId = Convert.ToInt32(await cmd.ExecuteScalarAsync());
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


        public async Task<List<JobSummary>> GetPendingJobsAsync()
        {
            var jobs = new List<JobSummary>();
            using (var connection = _databaseHelper.GetConnection())
            {
                await connection.OpenAsync();
                string query = @"SELECT JobId, StartLocation, Destination, RequestedDate, RequestedProducts ,RequestedQuantity, RequestedWeight, RequestedNotes
                         FROM Jobs
                         WHERE Status = 'Pending'
                         ORDER BY CreatedAt DESC";
                using (var cmd = new SqlCommand(query, connection))
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        jobs.Add(new JobSummary
                        {
                            JobId = reader.GetInt32(reader.GetOrdinal("JobId")),
                            StartLocation = reader.IsDBNull(reader.GetOrdinal("StartLocation")) ? "" : reader.GetString(reader.GetOrdinal("StartLocation")),
                            Destination = reader.IsDBNull(reader.GetOrdinal("Destination")) ? "" : reader.GetString(reader.GetOrdinal("Destination")),
                            RequestedDate = reader.IsDBNull(reader.GetOrdinal("RequestedDate")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("RequestedDate")),
                            RequestedProducts = reader.IsDBNull(reader.GetOrdinal("RequestedProducts")) ? "" : reader.GetString(reader.GetOrdinal("RequestedProducts")),
                            RequestedQuantity = reader.IsDBNull(reader.GetOrdinal("RequestedQuantity")) ? 0 : reader.GetInt32(reader.GetOrdinal("RequestedQuantity")),
                            RequestedWeight = reader.IsDBNull(reader.GetOrdinal("RequestedWeight")) ? 0 : reader.GetDecimal(reader.GetOrdinal("RequestedWeight")),
                            RequestedNotes = reader.IsDBNull(reader.GetOrdinal("RequestedNotes")) ? "" : reader.GetString(reader.GetOrdinal("RequestedNotes"))
                        });
                    }
                }
            }
            return jobs;
        }


        public async Task<DataTable> GetLoadsForJobAsync(int jobId)
        {
            using var connection = _databaseHelper.GetConnection();
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
            catch (Exception)
            {
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
            catch (Exception)
            {
                return false;
            }
        }


        public async Task<bool> AddLoadAsync(int jobId, int productId, int transportUnitId, int quantity, decimal? weight, string notes)
        {
            using var connection = _databaseHelper.GetConnection();
            await connection.OpenAsync();

            string query = @"
        INSERT INTO Loads (JobId, ProductId, TransportUnitId, Quantity, Weight, Notes)
        VALUES (@JobId, @ProductId, @TransportUnitId, @Quantity, @Weight, @Notes);";

            using var cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@JobId", jobId);
            cmd.Parameters.AddWithValue("@ProductId", productId);
            cmd.Parameters.AddWithValue("@TransportUnitId", transportUnitId);
            cmd.Parameters.AddWithValue("@Quantity", quantity);
            cmd.Parameters.AddWithValue("@Weight", weight ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Notes", notes ?? (object)DBNull.Value);

            return await cmd.ExecuteNonQueryAsync() > 0;
        }


        public async Task<bool> UpdateLoadAsync(int loadId, int productId, int transportUnitId, int quantity, decimal? weight, string notes)
        {
            using var connection = _databaseHelper.GetConnection();
            await connection.OpenAsync();

            string query = @"
        UPDATE Loads
        SET ProductId = @ProductId,
            TransportUnitId = @TransportUnitId,
            Quantity = @Quantity,
            Weight = @Weight,
            Notes = @Notes
        WHERE LoadId = @LoadId;";

            using var cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@LoadId", loadId);
            cmd.Parameters.AddWithValue("@ProductId", productId);
            cmd.Parameters.AddWithValue("@TransportUnitId", transportUnitId);
            cmd.Parameters.AddWithValue("@Quantity", quantity);
            cmd.Parameters.AddWithValue("@Weight", weight ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Notes", notes ?? (object)DBNull.Value);

            return await cmd.ExecuteNonQueryAsync() > 0;
        }


        public async Task<bool> DeleteLoadAsync(int loadId)
        {
            using var connection = _databaseHelper.GetConnection();
            await connection.OpenAsync();

            string query = "DELETE FROM Loads WHERE LoadId = @LoadId;";

            using var cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@LoadId", loadId);

            return await cmd.ExecuteNonQueryAsync() > 0;
        }


        public async Task<DataTable> GetAllProductsAsync()
        {
            using var connection = _databaseHelper.GetConnection();
            await connection.OpenAsync();
            string query = "SELECT ProductId, Name FROM Products ORDER BY Name";
            using var cmd = new SqlCommand(query, connection);
            using var adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public async Task<DataTable> GetAllTransportUnitsAsync()
        {
            using var connection = _databaseHelper.GetConnection();
            await connection.OpenAsync();
            string query = @"
        SELECT 
            t.TransportUnitId,
            'Lorry: ' + lo.PlateNumber + 
            ', Driver: ' + d.Name + 
            ', Assistant: ' + a.Name + 
            ', Container: ' + c.Type AS TransportUnitSummary
        FROM TransportUnits t
        INNER JOIN Lorries lo ON t.LorryId = lo.LorryId
        INNER JOIN Drivers d ON t.DriverId = d.DriverId
        INNER JOIN Assistants a ON t.AssistantId = a.AssistantId
        INNER JOIN Containers c ON t.ContainerId = c.ContainerId
        ORDER BY t.TransportUnitId";
            using var cmd = new SqlCommand(query, connection);
            using var adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
