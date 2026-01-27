using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using RealEstate.Entities;



namespace RealEstate.DataAccess
{
    using System.Data;
    using System.Data.SqlClient;
    public class PropertyDAL
    {
        public static bool AddNewProperty(Property property)
        {
            // Defensive Validation
            if (property == null)
                return false;

            if (string.IsNullOrWhiteSpace(property.PropertyType) ||
                string.IsNullOrWhiteSpace(property.Location) ||
                string.IsNullOrWhiteSpace(property.Status) ||
                property.Price <= 0)
                return false;

            const string query = @"
        INSERT INTO Properties (PropertyType, Location, Price, Status)
        VALUES (@PropertyType, @Location, @Price, @Status)";

            try
            {
                using (SqlConnection con = new SqlConnection(Database.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@PropertyType", property.PropertyType);
                    cmd.Parameters.AddWithValue("@Location", property.Location);
                    cmd.Parameters.AddWithValue("@Price", property.Price);
                    cmd.Parameters.AddWithValue("@Status", property.Status);

                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch
            {
                // لاحقًا Logging
                return false;
            }
            
        }

        public static DataTable GetAllProperties()
        {
            DataTable dataTable = new DataTable();
            string query = @"SELECT 
    PropertyID   AS [رقم العقار],
    PropertyType AS [نوع العقار],
    Location     AS [الموقع],
    Price        AS [السعر],
    Status       AS [الحالة]
FROM Properties";
            using (SqlConnection con = new SqlConnection(Database.ConnectionString))
            using (SqlCommand cmd = new SqlCommand( query, con))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                }
                catch (Exception)
                {

                    throw;
                }
            }



                return dataTable;
        }

        public static bool UpdateProperty(Property property)
        {
            int rows = 0;

            using (SqlConnection con = new SqlConnection(Database.ConnectionString))
            {
                string query = @"
        UPDATE Properties
        SET PropertyType = @PropertyType,
            Location     = @Location,
            Price        = @Price,
            Status       = @Status
        WHERE PropertyID = @PropertyID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@PropertyID", property.PropertyID);
                    cmd.Parameters.AddWithValue("@PropertyType", property.PropertyType);
                    cmd.Parameters.AddWithValue("@Location", property.Location);
                    cmd.Parameters.AddWithValue("@Price", property.Price);
                    cmd.Parameters.AddWithValue("@Status", property.Status);

                    con.Open();
                    rows = cmd.ExecuteNonQuery();
                }
            }

            return rows > 0;
        }

        public static bool DeleteProperty(int propertyID)
        {
            int rows = 0;

            using (SqlConnection con = new SqlConnection(Database.ConnectionString))
            {
                string query = "DELETE FROM Properties WHERE PropertyID = @PropertyID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@PropertyID", propertyID);

                    con.Open();
                    rows = cmd.ExecuteNonQuery();
                }
            }

            return rows > 0;
        }
        public static DataTable GetAllForSelection()
        {
            using SqlConnection con = new SqlConnection(Database.ConnectionString);

            string query = @"
        SELECT 
            PropertyID,
            PropertyType + ' - ' + Location + ' - رقم ' + CAST(PropertyID AS NVARCHAR)
            AS DisplayText
        FROM Properties
        WHERE Status = 'متاح'";

            using SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }

        public static bool UpdateStatus(int propertyId, string status)
        {
            using SqlConnection con = new SqlConnection(Database.ConnectionString);

            string query = @"UPDATE Properties
                     SET Status = @Status
                     WHERE PropertyID = @PropertyID";

            using SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Status", status);
            cmd.Parameters.AddWithValue("@PropertyID", propertyId);

            con.Open();
            return cmd.ExecuteNonQuery() > 0;
        }



    }
}
