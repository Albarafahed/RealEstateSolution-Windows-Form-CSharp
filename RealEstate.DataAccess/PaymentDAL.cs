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
    public class PaymentDAL
    {
        public static DataTable GetPaymentsByContract(int contractID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Database.ConnectionString))
            {
                string query = @"
                SELECT PaymentID AS [رقم الدفعة],
                       Amount AS [المبلغ],
                       PaymentDate AS [تاريخ الدفعة]
                FROM Payments
                WHERE ContractID = @ContractID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ContractID", contractID);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public static bool IsContractHasPayments(int contractId)
        {
            using SqlConnection con = new SqlConnection(Database.ConnectionString);

            string query = "SELECT COUNT(*) FROM Payments WHERE ContractID = @ContractID";

            using SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ContractID", contractId);

            con.Open();
            return (int)cmd.ExecuteScalar() > 0;
        }

        public bool AddNewPayment(Payment payment)
        {
            int rowsAffected = 0;

            using (SqlConnection con = new SqlConnection(Database.ConnectionString))
            {
                string query = @"INSERT INTO Payments (ContractID, Amount, PaymentDate)
                             VALUES (@ContractID, @Amount, @PaymentDate)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ContractID", payment.ContractID);
                cmd.Parameters.AddWithValue("@Amount", payment.Amount);
                cmd.Parameters.AddWithValue("@PaymentDate", payment.PaymentDate);

                try
                {
                    con.Open();
                    rowsAffected = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                   
                }
            }

            return rowsAffected > 0;
        }
        public DataTable GetPaymentsByContractId(int contractId)
        {
            using (SqlConnection con = new SqlConnection(Database.ConnectionString))
            {
                string query = @"
        SELECT 
            PaymentID,
            Amount,
            PaymentDate
        FROM Payments
        WHERE ContractID = @ContractID
        ORDER BY PaymentDate";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ContractID", contractId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        public static DataTable GetContractsForPayments()
        {
            using SqlConnection con = new SqlConnection(Database.ConnectionString);

            string query = @"
    SELECT
    c.ContractID,
    cl.FullName,
    p.PropertyType,
    p.Location,
    c.TotalAmount,

    ISNULL(SUM(pay.Amount), 0) AS PaidAmount,

    (c.TotalAmount - ISNULL(SUM(pay.Amount), 0)) AS RemainingAmount,
    c.Status
FROM Contracts c
INNER JOIN Clients cl ON c.ClientID = cl.ClientID
INNER JOIN Properties p ON c.PropertyID = p.PropertyID
LEFT JOIN Payments pay ON c.ContractID = pay.ContractID
GROUP BY
    c.ContractID,
    cl.FullName,
    p.PropertyType,
    p.Location,
    c.TotalAmount,
    c.Status;
";

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

      
        public static DataRow GetContractSummary(int contractId)
        {
            using SqlConnection con = new SqlConnection(Database.ConnectionString);

              string query = @"
                SELECT
                    c.ContractID,
                    cl.FullName,
                    p.PropertyType,
                    p.Location,
                    c.TotalAmount,
                    ISNULL(SUM(pay.Amount), 0) AS PaidAmount,
                    (c.TotalAmount - ISNULL(SUM(pay.Amount), 0)) AS RemainingAmount,
                    c.Status
                FROM Contracts c
                INNER JOIN Clients cl ON c.ClientID = cl.ClientID
                INNER JOIN Properties p ON c.PropertyID = p.PropertyID
                LEFT JOIN Payments pay ON c.ContractID = pay.ContractID
                WHERE c.ContractID = @ContractID
                GROUP BY
                    c.ContractID,
                    cl.FullName,
                    p.PropertyType,
                    p.Location,
                    c.TotalAmount,
                    c.Status";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ContractID", contractId);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        public void DeletePayment(int paymentId)
        {
            using SqlConnection con = new SqlConnection(Database.ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Payments WHERE PaymentID = @id", con);
            cmd.Parameters.AddWithValue("@id", paymentId);
            cmd.ExecuteNonQuery();
        }

        public static DataTable SearchContractsByClient(string clientName)
        {
            using SqlConnection con = new SqlConnection(Database.ConnectionString);

            SqlCommand cmd = new SqlCommand(@"
       SELECT
    c.ContractID,
    cl.FullName,
    p.PropertyType,
    p.Location,
    c.TotalAmount,
    ISNULL(SUM(pay.Amount), 0) AS PaidAmount,
    (c.TotalAmount - ISNULL(SUM(pay.Amount), 0)) AS RemainingAmount,
    c.Status
FROM Contracts c
INNER JOIN Clients cl ON c.ClientID = cl.ClientID
INNER JOIN Properties p ON c.PropertyID = p.PropertyID
LEFT JOIN Payments pay ON c.ContractID = pay.ContractID
WHERE cl.FullName LIKE @ClientName
GROUP BY
    c.ContractID,
    cl.FullName,
    p.PropertyType,
    p.Location,
    c.TotalAmount,
    c.Status
ORDER BY c.ContractID DESC;
", con);

            cmd.Parameters.AddWithValue("@ClientName", "%" + clientName + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }






    }
}
