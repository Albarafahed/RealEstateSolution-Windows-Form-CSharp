using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.DataAccess
{
    public class ReportsDAL
    {
        public static DataTable GetContractsReport(DateTime from, DateTime to)
        {
            using SqlConnection con = new SqlConnection(Database.ConnectionString);

            string query = @"
SELECT
    c.ContractID,
    cl.FullName,
    p.PropertyType,
    p.Location,
    c.ContractType,
    c.StartDate,
    c.EndDate,
    c.TotalAmount,
    ISNULL(payments.PaidAmount, 0) AS PaidAmount,
    c.TotalAmount - ISNULL(payments.PaidAmount, 0) AS RemainingAmount,
    c.Status
FROM Contracts c
INNER JOIN Clients cl ON c.ClientID = cl.ClientID
INNER JOIN Properties p ON c.PropertyID = p.PropertyID
LEFT JOIN (
    SELECT ContractID, SUM(Amount) AS PaidAmount
    FROM Payments
    GROUP BY ContractID
) payments ON c.ContractID = payments.ContractID
ORDER BY c.ContractID DESC;

";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@From", from);
            cmd.Parameters.AddWithValue("@To", to);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable GetAllContracts()
        {
            using SqlConnection con = new SqlConnection(Database.ConnectionString);
            con.Open();

            string query = @"
SELECT
    c.ContractID,
    cl.FullName,
    p.PropertyType,
    p.Location,
    c.ContractType,
    c.StartDate,
    c.EndDate,
    c.TotalAmount,
    ISNULL(payments.PaidAmount,0) AS PaidAmount,
    c.TotalAmount - ISNULL(payments.PaidAmount,0) AS RemainingAmount,
    c.Status
FROM Contracts c
INNER JOIN Clients cl ON c.ClientID = cl.ClientID
INNER JOIN Properties p ON c.PropertyID = p.PropertyID
LEFT JOIN (
    SELECT ContractID, SUM(Amount) AS PaidAmount
    FROM Payments
    GROUP BY ContractID
) payments ON c.ContractID = payments.ContractID
ORDER BY c.ContractID DESC";

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}
