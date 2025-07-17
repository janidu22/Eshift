using Eshift.DataAccess;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshift.Repoistory
{
    public class TrasnportUnitRepository
    {

        private readonly DatabaseHelper _dbHelper = new DatabaseHelper();
        public TrasnportUnitRepository()
        {

        }


        #region CRUD Lorries
        public async Task<bool> AddLorryAsync(string plateNumber, string model, decimal capacity)
        {
            using var connection = _dbHelper.GetConnection();
            await connection.OpenAsync();

            string query = "INSERT INTO Lorries (PlateNumber, Model, Capacity) VALUES (@PlateNumber, @Model, @Capacity)";

            using var cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@PlateNumber", plateNumber);
            cmd.Parameters.AddWithValue("@Model", model ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Capacity", capacity);

            return await cmd.ExecuteNonQueryAsync() > 0;
        }

        public async Task<bool> UpdateLorryAsync(int lorryId, string plateNumber, string model, decimal capacity)
        {
            using var connection = _dbHelper.GetConnection();
            await connection.OpenAsync();

            string query = "UPDATE Lorries SET PlateNumber = @PlateNumber, Model = @Model, Capacity = @Capacity WHERE LorryId = @LorryId";

            using var cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@LorryId", lorryId);
            cmd.Parameters.AddWithValue("@PlateNumber", plateNumber);
            cmd.Parameters.AddWithValue("@Model", model ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Capacity", capacity);

            return await cmd.ExecuteNonQueryAsync() > 0;
        }

        public async Task<bool> DeleteLorryAsync(int lorryId)
        {
            using var connection = _dbHelper.GetConnection();
            await connection.OpenAsync();

            // First, delete the related records in TransportUnits
            string deleteTransportUnitsQuery = "DELETE FROM TransportUnits WHERE LorryId = @LorryId";

            using var cmd = new SqlCommand(deleteTransportUnitsQuery, connection);
            cmd.Parameters.AddWithValue("@LorryId", lorryId);

            try
            {
                // Delete related TransportUnits first
                await cmd.ExecuteNonQueryAsync();

                // Now delete the Lorry
                string deleteLorryQuery = "DELETE FROM Lorries WHERE LorryId = @LorryId";
                cmd.CommandText = deleteLorryQuery; // Reuse the command for the next delete operation
                return await cmd.ExecuteNonQueryAsync() > 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"An error occurred while deleting the lorry: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw; // Rethrow the exception
            }
        }


        #endregion

        #region CRUD Drivers
        public async Task<bool> AddDriverAsync(string name, string licenseNumber, string phone)
        {
            using var connection = _dbHelper.GetConnection();
            await connection.OpenAsync();

            string query = "INSERT INTO Drivers (Name, LicenseNumber, Phone) VALUES (@Name, @LicenseNumber, @Phone)";

            using var cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@LicenseNumber", licenseNumber);
            cmd.Parameters.AddWithValue("@Phone", phone ?? (object)DBNull.Value);

            return await cmd.ExecuteNonQueryAsync() > 0;
        }

        public async Task<bool> UpdateDriverAsync(int driverId, string name, string licenseNumber, string phone)
        {
            using var connection = _dbHelper.GetConnection();
            await connection.OpenAsync();

            string query = "UPDATE Drivers SET Name = @Name, LicenseNumber = @LicenseNumber, Phone = @Phone WHERE DriverId = @DriverId";

            using var cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@DriverId", driverId);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@LicenseNumber", licenseNumber);
            cmd.Parameters.AddWithValue("@Phone", phone ?? (object)DBNull.Value);

            return await cmd.ExecuteNonQueryAsync() > 0;
        }

        public async Task<bool> DeleteDriverAsync(int driverId)
        {
            using var connection = _dbHelper.GetConnection();
            await connection.OpenAsync();

            string query = "DELETE FROM Drivers WHERE DriverId = @DriverId";

            using var cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@DriverId", driverId);

            return await cmd.ExecuteNonQueryAsync() > 0;
        }
        #endregion

        #region CRUD Assistants
        public async Task<bool> AddAssistantAsync(string name, string phone)
        {
            using var connection = _dbHelper.GetConnection();
            await connection.OpenAsync();

            string query = "INSERT INTO Assistants (Name, Phone) VALUES (@Name, @Phone)";

            using var cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Phone", phone ?? (object)DBNull.Value);

            return await cmd.ExecuteNonQueryAsync() > 0;
        }

        public async Task<bool> UpdateAssistantAsync(int assistantId, string name, string phone)
        {
            using var connection = _dbHelper.GetConnection();
            await connection.OpenAsync();

            string query = "UPDATE Assistants SET Name = @Name, Phone = @Phone WHERE AssistantId = @AssistantId";

            using var cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@AssistantId", assistantId);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Phone", phone ?? (object)DBNull.Value);

            return await cmd.ExecuteNonQueryAsync() > 0;
        }

        public async Task<bool> DeleteAssistantAsync(int assistantId)
        {
            using var connection = _dbHelper.GetConnection();
            await connection.OpenAsync();

            string query = "DELETE FROM Assistants WHERE AssistantId = @AssistantId";

            using var cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@AssistantId", assistantId);

            return await cmd.ExecuteNonQueryAsync() > 0;
        }
        #endregion

        #region CRUD Containers
        public async Task<bool> AddContainerAsync(string type, decimal capacity)
        {
            using var connection = _dbHelper.GetConnection();
            await connection.OpenAsync();

            string query = "INSERT INTO Containers (Type, Capacity) VALUES (@Type, @Capacity)";

            using var cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Type", type);
            cmd.Parameters.AddWithValue("@Capacity", capacity);

            return await cmd.ExecuteNonQueryAsync() > 0;
        }

        public async Task<bool> UpdateContainerAsync(int containerId, string type, decimal capacity)
        {
            using var connection = _dbHelper.GetConnection();
            await connection.OpenAsync();

            string query = "UPDATE Containers SET Type = @Type, Capacity = @Capacity WHERE ContainerId = @ContainerId";

            using var cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ContainerId", containerId);
            cmd.Parameters.AddWithValue("@Type", type);
            cmd.Parameters.AddWithValue("@Capacity", capacity);

            return await cmd.ExecuteNonQueryAsync() > 0;
        }

        public async Task<bool> DeleteContainerAsync(int containerId)
        {
            using var connection = _dbHelper.GetConnection();
            await connection.OpenAsync();

            string query = "DELETE FROM Containers WHERE ContainerId = @ContainerId";

            using var cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ContainerId", containerId);

            return await cmd.ExecuteNonQueryAsync() > 0;
        }
        #endregion

        #region CRUD Transport Units
        public async Task<bool> AddTransportUnitAsync(int lorryId, int driverId, int assistantId, int containerId)
        {
            using var connection = _dbHelper.GetConnection();
            await connection.OpenAsync();

            string query = "INSERT INTO TransportUnits (LorryId, DriverId, AssistantId, ContainerId) VALUES (@LorryId, @DriverId, @AssistantId, @ContainerId)";

            using var cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@LorryId", lorryId);
            cmd.Parameters.AddWithValue("@DriverId", driverId);
            cmd.Parameters.AddWithValue("@AssistantId", assistantId);
            cmd.Parameters.AddWithValue("@ContainerId", containerId);

            return await cmd.ExecuteNonQueryAsync() > 0;
        }

        public async Task<bool> UpdateTransportUnitAsync(int transportUnitId, int lorryId, int driverId, int assistantId, int containerId)
        {
            using var connection = _dbHelper.GetConnection();
            await connection.OpenAsync();

            string query = "UPDATE TransportUnits SET LorryId = @LorryId, DriverId = @DriverId, AssistantId = @AssistantId, ContainerId = @ContainerId WHERE TransportUnitId = @TransportUnitId";

            using var cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@TransportUnitId", transportUnitId);
            cmd.Parameters.AddWithValue("@LorryId", lorryId);
            cmd.Parameters.AddWithValue("@DriverId", driverId);
            cmd.Parameters.AddWithValue("@AssistantId", assistantId);
            cmd.Parameters.AddWithValue("@ContainerId", containerId);

            return await cmd.ExecuteNonQueryAsync() > 0;
        }

        public async Task<bool> DeleteTransportUnitAsync(int transportUnitId)
        {
            using var connection = _dbHelper.GetConnection();
            await connection.OpenAsync();

       
            string deleteLoadsQuery = "DELETE FROM Loads WHERE TransportUnitId = @TransportUnitId";
            using var deleteLoadsCmd = new SqlCommand(deleteLoadsQuery, connection);
            deleteLoadsCmd.Parameters.AddWithValue("@TransportUnitId", transportUnitId);
            await deleteLoadsCmd.ExecuteNonQueryAsync();

           
            string deleteTransportUnitQuery = "DELETE FROM TransportUnits WHERE TransportUnitId = @TransportUnitId";
            using var deleteTransportUnitCmd = new SqlCommand(deleteTransportUnitQuery, connection);
            deleteTransportUnitCmd.Parameters.AddWithValue("@TransportUnitId", transportUnitId);

            return await deleteTransportUnitCmd.ExecuteNonQueryAsync() > 0;
        }


        public async Task<DataTable> GetLorriesForDropdownAsync()
        {
            using var connection = _dbHelper.GetConnection();
            await connection.OpenAsync();

            string query = "SELECT LorryId, PlateNumber + ' - ' + Model AS DisplayText FROM Lorries ORDER BY PlateNumber";

            using var cmd = new SqlCommand(query, connection);
            using var adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public async Task<DataTable> GetDriversForDropdownAsync()
        {
            using var connection = _dbHelper.GetConnection();
            await connection.OpenAsync();

            string query = "SELECT DriverId, Name + ' - ' + LicenseNumber AS DisplayText FROM Drivers ORDER BY Name";

            using var cmd = new SqlCommand(query, connection);
            using var adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public async Task<DataTable> GetAssistantsForDropdownAsync()
        {
            using var connection = _dbHelper.GetConnection();
            await connection.OpenAsync();

            string query = "SELECT AssistantId, Name AS DisplayText FROM Assistants ORDER BY Name";

            using var cmd = new SqlCommand(query, connection);
            using var adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public async Task<DataTable> GetContainersForDropdownAsync()
        {
            using var connection = _dbHelper.GetConnection();
            await connection.OpenAsync();

            string query = "SELECT ContainerId, Type + ' - ' + CAST(Capacity AS VARCHAR) + ' ton' AS DisplayText FROM Containers ORDER BY Type";

            using var cmd = new SqlCommand(query, connection);
            using var adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        #endregion

        #region get Quries
        public async Task<DataTable> GetAllTransportUnitsAsync()
        {
            using var connection = _dbHelper.GetConnection();
            await connection.OpenAsync();

            try
            {
                string query = @"
        SELECT 
            tu.TransportUnitId AS 'UnitID',
            tu.LorryId,
            l.PlateNumber AS 'Lorry',
            tu.DriverId,
            d.Name AS 'Driver',
            tu.AssistantId,
            a.Name AS 'Assistant',
            tu.ContainerId,
            c.Type AS 'Container'
        FROM TransportUnits tu
        JOIN Lorries l ON tu.LorryId = l.LorryId
        JOIN Drivers d ON tu.DriverId = d.DriverId
        JOIN Assistants a ON tu.AssistantId = a.AssistantId
        JOIN Containers c ON tu.ContainerId = c.ContainerId
        ORDER BY tu.TransportUnitId";

                using var cmd = new SqlCommand(query, connection);
                using var adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching transport units: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }


        public async Task<DataTable> GetAllLorriesAsync()
        {
            using var connection = _dbHelper.GetConnection();
            await connection.OpenAsync();

            string query = @"
        SELECT 
            LorryId,
            PlateNumber AS 'Plate Number',
            Model,
            Capacity
        FROM Lorries
        ORDER BY PlateNumber";

            using var cmd = new SqlCommand(query, connection);
            using var adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public async Task<DataTable> GetAllDriversAsync()
        {
            using var connection = _dbHelper.GetConnection();
            await connection.OpenAsync();

            string query = @"
        SELECT 
            DriverId,
            Name,
            LicenseNumber AS 'License Number',
            Phone
        FROM Drivers
        ORDER BY Name";

            using var cmd = new SqlCommand(query, connection);
            using var adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public async Task<DataTable> GetAllAssistantsAsync()
        {
            using var connection = _dbHelper.GetConnection();
            await connection.OpenAsync();

            string query = @"
        SELECT 
            AssistantId,
            Name,
            Phone
        FROM Assistants
        ORDER BY Name";

            using var cmd = new SqlCommand(query, connection);
            using var adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public async Task<DataTable> GetAllContainersAsync()
        {
            using var connection = _dbHelper.GetConnection();
            await connection.OpenAsync();

            string query = @"
        SELECT 
            ContainerId,
            Type,
            Capacity
        FROM Containers
        ORDER BY Type";

            using var cmd = new SqlCommand(query, connection);
            using var adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        #endregion

    }
}
