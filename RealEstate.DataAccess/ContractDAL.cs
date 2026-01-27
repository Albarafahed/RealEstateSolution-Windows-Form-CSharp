using Microsoft.Data.SqlClient;
using RealEstate.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.DataAccess
{
    public class ContractDAL
    {
        public static DataTable GetContractsByClient(int clientID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Database.ConnectionString))
            {
                string query = @"
               SELECT 
                 c.ContractID       AS [رقم العقد],
                 p.PropertyType     AS [اسم العقار],
                 p.Location         AS [الموقع],
                 c.ContractType     AS [نوع العقد],
                 c.StartDate        AS [تاريخ البداية],
                 c.EndDate          AS [تاريخ النهاية],
                 c.TotalAmount      AS [المبلغ الكلي],
                 c.Status           AS[ الحالة],
                 c.PropertyID       -- مخفي
                 FROM Contracts c
                 INNER JOIN Properties p ON c.PropertyID = p.PropertyID
                 WHERE c.ClientID = @ClientID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ClientID", clientID);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public static DataTable GetAllContracts()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(Database.ConnectionString))
            {
                string query = @"
        SELECT 
            C.ContractID,
            CL.FullName,
            P.PropertyType,
            C.StartDate,
            C.EndDate,
            C.TotalAmount,
            C.ContractType,
            C.Status
        FROM Contracts C
        INNER JOIN Clients CL ON C.ClientID = CL.ClientID
        INNER JOIN Properties P ON C.PropertyID = P.PropertyID
        ";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    dt.Load(cmd.ExecuteReader());
                }
            }

            return dt;
        }

        public static bool AddNewContract(Contract contract)
        {
            using SqlConnection con = new SqlConnection(Database.ConnectionString);

            string query = @"
        INSERT INTO Contracts
        (ClientID, PropertyID, ContractType, StartDate, EndDate, TotalAmount, Status)
        VALUES
        (@ClientID, @PropertyID, @ContractType, @StartDate, @EndDate, @TotalAmount, @Status)";

            using SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@ClientID", contract.ClientID);
            cmd.Parameters.AddWithValue("@PropertyID", contract.PropertyID);
            cmd.Parameters.AddWithValue("@ContractType", contract.ContractType);
            cmd.Parameters.AddWithValue("@StartDate", contract.StartDate);
            cmd.Parameters.AddWithValue("@EndDate", contract.EndDate);
            cmd.Parameters.AddWithValue("@TotalAmount", contract.TotalAmount);
            cmd.Parameters.AddWithValue("@Status", contract.Status);

            con.Open();
            return cmd.ExecuteNonQuery() > 0;
        }

        public static DataTable GetAllForSelection()
        {
            using SqlConnection con = new SqlConnection(Database.ConnectionString);

            string query = @"
        SELECT 
            PropertyID,
            PropertyType + ' - ' + Location + ' - '
            AS DisplayText
        FROM Properties
        WHERE Status = 'متاح'";

            using SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }

        public static bool Delete(int contractId)
        {
            using SqlConnection con = new SqlConnection(Database.ConnectionString);

            string query = "DELETE FROM Contracts WHERE ContractID = @ContractID";

            using SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ContractID", contractId);

            con.Open();
            return cmd.ExecuteNonQuery() > 0;
        }
        public static bool Update(Contract contract)
        {
            using SqlConnection con = new SqlConnection(Database.ConnectionString);

            string query = @"UPDATE Contracts
                     SET ClientID = @ClientID,
                         PropertyID = @PropertyID,
                         ContractType = @ContractType,
                         StartDate = @StartDate,
                         EndDate = @EndDate,
                         TotalAmount = @TotalAmount,
                         Status = @Status
                     WHERE ContractID = @ContractID";

            using SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ClientID", contract.ClientID);
            cmd.Parameters.AddWithValue("@PropertyID", contract.PropertyID);
            cmd.Parameters.AddWithValue("@ContractType", contract.ContractType);
            cmd.Parameters.AddWithValue("@StartDate", contract.StartDate);
            cmd.Parameters.AddWithValue("@EndDate", contract.EndDate);
            cmd.Parameters.AddWithValue("@TotalAmount", contract.TotalAmount);
            cmd.Parameters.AddWithValue("@Status", contract.Status);
            cmd.Parameters.AddWithValue("@ContractID", contract.ContractID);

            con.Open();
            return cmd.ExecuteNonQuery() > 0;
        }

        public DataTable SearchContractsByClientName(string clientName)
        {
            using SqlConnection con = new SqlConnection(Database.ConnectionString);

            string query = @"
    SELECT 
        c.ContractID,
        cl.FullName,
        p.PropertyType,
        c.ContractType,
        c.StartDate,
        c.EndDate,
        c.TotalAmount,
        c.Status
    FROM Contracts c
    INNER JOIN Clients cl ON c.ClientID = cl.ClientID
    INNER JOIN Properties p ON c.PropertyID = p.PropertyID
    WHERE cl.FullName LIKE @ClientName";

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@ClientName", "%" + clientName + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        

      

    }
}
