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
using System.Windows.Forms;

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
                    INSERT INTO Payments (JobId, CustomerId, Amount, Method, Status, CreatedAt, PaidAt)
                    VALUES (@JobId, @CustomerId, @Amount, @Method, @Status, GETDATE(),
                        CASE WHEN @Status = 'Paid' THEN GETDATE() ELSE NULL END
                    );";

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

        // ==================== REPORT METHODS ====================

        public async Task<DataTable> GetJobsReportAsync(DateTime? fromDate = null, DateTime? toDate = null)
        {
            using var connection = _databaseHelper.GetConnection();
            await connection.OpenAsync();
            
            string query = @"
                SELECT 
                    j.JobId, c.Name AS CustomerName, j.StartLocation, j.Destination, 
                    j.RequestedDate, j.Status, a.Name AS AdminName, j.CreatedAt, j.UpdatedAt,
                    j.RequestedProducts, j.RequestedQuantity, j.RequestedWeight, j.RequestedNotes
                FROM Jobs j
                LEFT JOIN Customers c ON j.CustomerId = c.CustomerId
                LEFT JOIN Admins a ON j.AdminId = a.AdminId";

            // Build WHERE clause based on date parameters
            if (fromDate.HasValue && toDate.HasValue)
            {
                query += " WHERE j.RequestedDate >= @FromDate AND j.RequestedDate <= @ToDate";
            }
            else if (fromDate.HasValue)
            {
                query += " WHERE j.RequestedDate >= @FromDate";
            }
            else if (toDate.HasValue)
            {
                query += " WHERE j.RequestedDate <= @ToDate";
            }
            
            query += " ORDER BY j.RequestedDate DESC";

            using var cmd = new SqlCommand(query, connection);
            
            if (fromDate.HasValue)
                cmd.Parameters.AddWithValue("@FromDate", fromDate.Value);
                
            if (toDate.HasValue)
                cmd.Parameters.AddWithValue("@ToDate", toDate.Value);
            
            using var adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public async Task<DataTable> GetLoadsReportAsync(DateTime? fromDate = null, DateTime? toDate = null)
        {
            using var connection = _databaseHelper.GetConnection();
            await connection.OpenAsync();
            
            string query = @"
                SELECT 
                    l.LoadId, l.JobId, p.Name AS Product, l.Quantity, l.Weight, l.Notes,
                    tu.TransportUnitId, j.RequestedDate AS JobRequestedDate,
                    'Lorry: ' + lo.PlateNumber + ', Driver: ' + d.Name + ', Assistant: ' + a.Name + ', Container: ' + c.Type AS TransportUnit
                FROM Loads l
                LEFT JOIN Products p ON l.ProductId = p.ProductId
                LEFT JOIN TransportUnits tu ON l.TransportUnitId = tu.TransportUnitId
                LEFT JOIN Lorries lo ON tu.LorryId = lo.LorryId
                LEFT JOIN Drivers d ON tu.DriverId = d.DriverId
                LEFT JOIN Assistants a ON tu.AssistantId = a.AssistantId
                LEFT JOIN Containers c ON tu.ContainerId = c.ContainerId
                LEFT JOIN Jobs j ON l.JobId = j.JobId";

          
            if (fromDate.HasValue && toDate.HasValue)
            {
                query += " WHERE j.RequestedDate >= @FromDate AND j.RequestedDate <= @ToDate";
            }
            else if (fromDate.HasValue)
            {
                query += " WHERE j.RequestedDate >= @FromDate";
            }
            else if (toDate.HasValue)
            {
                query += " WHERE j.RequestedDate <= @ToDate";
            }
            
            query += " ORDER BY l.LoadId DESC";

            using var cmd = new SqlCommand(query, connection);
            
            if (fromDate.HasValue)
                cmd.Parameters.AddWithValue("@FromDate", fromDate.Value);
                
            if (toDate.HasValue)
                cmd.Parameters.AddWithValue("@ToDate", toDate.Value);
            
            using var adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public async Task<DataTable> GetPaymentsReportAsync(DateTime? fromDate = null, DateTime? toDate = null)
        {
            using var connection = _databaseHelper.GetConnection();
            await connection.OpenAsync();
            
            string query = @"
                SELECT 
                    p.PaymentId, p.JobId, c.Name AS CustomerName, p.Amount, p.Method, 
                    p.Status, p.PaidAt, p.CreatedAt
                FROM Payments p
                LEFT JOIN Customers c ON p.CustomerId = c.CustomerId";

            // Build WHERE clause based on date parameters
            if (fromDate.HasValue && toDate.HasValue)
            {
                query += " WHERE p.CreatedAt >= @FromDate AND p.CreatedAt <= @ToDate";
            }
            else if (fromDate.HasValue)
            {
                query += " WHERE p.CreatedAt >= @FromDate";
            }
            else if (toDate.HasValue)
            {
                query += " WHERE p.CreatedAt <= @ToDate";
            }
            
            query += " ORDER BY p.CreatedAt DESC";

            using var cmd = new SqlCommand(query, connection);
            
            if (fromDate.HasValue)
                cmd.Parameters.AddWithValue("@FromDate", fromDate.Value);
                
            if (toDate.HasValue)
                cmd.Parameters.AddWithValue("@ToDate", toDate.Value);
            
            using var adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public async Task<DataTable> GetCustomersReportAsync(DateTime? fromDate = null, DateTime? toDate = null)
        {
            using var connection = _databaseHelper.GetConnection();
            await connection.OpenAsync();
            
            string query = @"
                SELECT 
                    c.CustomerId, c.Name, c.Email, c.Phone, c.Address, u.CreatedAt, COUNT(j.JobId) AS TotalJobs
                FROM Customers c
                INNER JOIN Users u ON c.UserId = u.UserId
                LEFT JOIN Jobs j ON c.CustomerId = j.CustomerId
                WHERE (@FromDate IS NULL OR u.CreatedAt >= @FromDate)
                  AND (@ToDate IS NULL OR u.CreatedAt < @ToDate)
                GROUP BY c.CustomerId, c.Name, c.Email, c.Phone, c.Address, u.CreatedAt
                ORDER BY c.Name";

            using var cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@FromDate", fromDate ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@ToDate", toDate ?? (object)DBNull.Value);
            
            using var adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public async Task<DataTable> GetRevenueReportAsync(DateTime? fromDate = null, DateTime? toDate = null)
        {
            using var connection = _databaseHelper.GetConnection();
            await connection.OpenAsync();
            
            string query = @"
                SELECT 
                    YEAR(p.PaidAt) AS Year, MONTH(p.PaidAt) AS Month, 
                    SUM(p.Amount) AS TotalRevenue, COUNT(p.PaymentId) AS TotalPayments
                FROM Payments p
                WHERE p.Status = 'Paid'
                  AND p.PaidAt IS NOT NULL
                  AND (@FromDate IS NULL OR p.PaidAt >= @FromDate)
                  AND (@ToDate IS NULL OR p.PaidAt <= @ToDate)
                GROUP BY YEAR(p.PaidAt), MONTH(p.PaidAt)
                ORDER BY Year DESC, Month DESC";

            using var cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@FromDate", fromDate ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@ToDate", toDate ?? (object)DBNull.Value);
            
            using var adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public async Task<DataTable> GetJobStatusHistoryReportAsync(DateTime? fromDate = null, DateTime? toDate = null)
        {
            using var connection = _databaseHelper.GetConnection();
            await connection.OpenAsync();
            
            string query = @"
                SELECT 
                    h.HistoryId, h.JobId, h.Status, a.Name AS ChangedBy, h.ChangedAt, h.Notes
                FROM JobStatusHistory h
                LEFT JOIN Admins a ON h.ChangedByAdminId = a.AdminId
                INNER JOIN Jobs j ON h.JobId = j.JobId
                WHERE j.Status = 'Completed'
                  AND (@FromDate IS NULL OR h.ChangedAt >= @FromDate)
                  AND (@ToDate IS NULL OR h.ChangedAt < @ToDate)
                ORDER BY h.ChangedAt DESC";

            using var cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@FromDate", fromDate ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@ToDate", toDate ?? (object)DBNull.Value);
            
            using var adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public async Task<DataTable> GetProductsReportAsync(DateTime? fromDate = null, DateTime? toDate = null)
        {
            using var connection = _databaseHelper.GetConnection();
            await connection.OpenAsync();
            
            string query = @"
                SELECT 
                    p.ProductId, p.Name, p.Description, 
                    SUM(l.Quantity) AS TotalQuantity, SUM(l.Weight) AS TotalWeight,
                    COUNT(l.LoadId) AS TotalLoads
                FROM Products p
                LEFT JOIN Loads l ON p.ProductId = l.ProductId
                LEFT JOIN Jobs j ON l.JobId = j.JobId
                    AND (@FromDate IS NULL OR j.RequestedDate >= @FromDate)
                    AND (@ToDate IS NULL OR j.RequestedDate <= @ToDate)
                GROUP BY p.ProductId, p.Name, p.Description
                ORDER BY p.Name";

            using var cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@FromDate", fromDate ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@ToDate", toDate ?? (object)DBNull.Value);
            
            using var adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public async Task<DataTable> GetTransportUnitsReportAsync(DateTime? fromDate = null, DateTime? toDate = null)
        {
            using var connection = _databaseHelper.GetConnection();
            await connection.OpenAsync();
            
            string query = @"
                SELECT 
                    tu.TransportUnitId, 
                    lo.PlateNumber AS LorryPlate,
                    d.Name AS DriverName,
                    a.Name AS AssistantName,
                    c.Type AS ContainerType,
                    COUNT(lods.LoadId) AS TotalLoads
                FROM TransportUnits tu
                LEFT JOIN Lorries lo ON tu.LorryId = lo.LorryId
                LEFT JOIN Drivers d ON tu.DriverId = d.DriverId
                LEFT JOIN Assistants a ON tu.AssistantId = a.AssistantId
                LEFT JOIN Containers c ON tu.ContainerId = c.ContainerId
                LEFT JOIN Loads lods ON tu.TransportUnitId = lods.TransportUnitId
                LEFT JOIN Jobs j ON lods.JobId = j.JobId
                    AND (@FromDate IS NULL OR j.RequestedDate >= @FromDate)
                    AND (@ToDate IS NULL OR j.RequestedDate <= @ToDate)
                GROUP BY tu.TransportUnitId, lo.PlateNumber, d.Name, a.Name, c.Type
                ORDER BY TotalLoads DESC";

            using var cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@FromDate", fromDate ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@ToDate", toDate ?? (object)DBNull.Value);
            
            using var adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public async Task<DataTable> GetDriversReportAsync(DateTime? fromDate = null, DateTime? toDate = null)
        {
            using var connection = _databaseHelper.GetConnection();
            await connection.OpenAsync();
            
            string query = @"
                SELECT 
                    d.DriverId, d.Name, d.LicenseNumber, d.Phone, COUNT(l.LoadId) AS TotalLoads
                FROM Drivers d
                LEFT JOIN TransportUnits tu ON d.DriverId = tu.DriverId
                LEFT JOIN Loads l ON tu.TransportUnitId = l.TransportUnitId
                LEFT JOIN Jobs j ON l.JobId = j.JobId
                    AND (@FromDate IS NULL OR j.RequestedDate >= @FromDate)
                    AND (@ToDate IS NULL OR j.RequestedDate <= @ToDate)
                GROUP BY d.DriverId, d.Name, d.LicenseNumber, d.Phone
                ORDER BY d.Name";

            using var cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@FromDate", fromDate ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@ToDate", toDate ?? (object)DBNull.Value);
            
            using var adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public async Task<DataTable> GetAssistantsReportAsync(DateTime? fromDate = null, DateTime? toDate = null)
        {
            using var connection = _databaseHelper.GetConnection();
            await connection.OpenAsync();
            
            string query = @"
                SELECT 
                    a.AssistantId, a.Name, a.Phone, COUNT(l.LoadId) AS TotalLoads
                FROM Assistants a
                LEFT JOIN TransportUnits tu ON a.AssistantId = tu.AssistantId
                LEFT JOIN Loads l ON tu.TransportUnitId = l.TransportUnitId
                LEFT JOIN Jobs j ON l.JobId = j.JobId
                    AND (@FromDate IS NULL OR j.RequestedDate >= @FromDate)
                    AND (@ToDate IS NULL OR j.RequestedDate <= @ToDate)
                GROUP BY a.AssistantId, a.Name, a.Phone
                ORDER BY a.Name";

            using var cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@FromDate", fromDate ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@ToDate", toDate ?? (object)DBNull.Value);
            
            using var adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public async Task<DataTable> GetLorriesReportAsync(DateTime? fromDate = null, DateTime? toDate = null)
        {
            using var connection = _databaseHelper.GetConnection();
            await connection.OpenAsync();
            
            string query = @"
                SELECT 
                    l.LorryId, l.PlateNumber, l.Model, l.Capacity, COUNT(ld.LoadId) AS TotalLoads
                FROM Lorries l
                LEFT JOIN TransportUnits tu ON l.LorryId = tu.LorryId
                LEFT JOIN Loads ld ON tu.TransportUnitId = ld.TransportUnitId
                LEFT JOIN Jobs j ON ld.JobId = j.JobId
                    AND (@FromDate IS NULL OR j.RequestedDate >= @FromDate)
                    AND (@ToDate IS NULL OR j.RequestedDate <= @ToDate)
                GROUP BY l.LorryId, l.PlateNumber, l.Model, l.Capacity
                ORDER BY l.PlateNumber";

            using var cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@FromDate", fromDate ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@ToDate", toDate ?? (object)DBNull.Value);
            
            using var adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public async Task<DataTable> GetContainersReportAsync(DateTime? fromDate = null, DateTime? toDate = null)
        {
            using var connection = _databaseHelper.GetConnection();
            await connection.OpenAsync();
            
            string query = @"
                SELECT 
                    c.ContainerId, c.Type, c.Capacity, COUNT(l.LoadId) AS TotalLoads
                FROM Containers c
                LEFT JOIN TransportUnits tu ON c.ContainerId = tu.ContainerId
                LEFT JOIN Loads l ON tu.TransportUnitId = l.TransportUnitId
                LEFT JOIN Jobs j ON l.JobId = j.JobId
                    AND (@FromDate IS NULL OR j.RequestedDate >= @FromDate)
                    AND (@ToDate IS NULL OR j.RequestedDate <= @ToDate)
                GROUP BY c.ContainerId, c.Type, c.Capacity
                ORDER BY c.Type";

            using var cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@FromDate", fromDate ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@ToDate", toDate ?? (object)DBNull.Value);
            
            using var adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
