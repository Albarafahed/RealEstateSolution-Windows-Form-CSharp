using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.DataAccess
{
    public class ClientDAL
    {
        public static DataTable GetAllClients()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Database.ConnectionString))
            {
                string query = "SELECT ClientID AS [رقم العميل], FullName AS [الاسم الكامل], Phone AS [الهاتف], Notes AS [ملاحظات] FROM Clients";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }
        public static DataTable GetAllClientsSwhow()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Database.ConnectionString))
            {
                string query = "SELECT ClientID, FullName, Phone, Notes FROM Clients";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public static DataTable SearchClients(string keyword)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Database.ConnectionString))
            {
                string query = @"
                SELECT ClientID AS [رقم العميل], FullName AS [الاسم الكامل], Phone AS [الهاتف], Notes AS [ملاحظات]
                FROM Clients
                WHERE FullName LIKE @kw OR Phone LIKE @kw";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@kw", $"%{keyword}%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public static bool AddClient(string fullName, string phone, string notes)
        {
            using (SqlConnection con = new SqlConnection(Database.ConnectionString))
            {
                string query = @"INSERT INTO Clients (FullName, Phone, Notes)
                         VALUES (@FullName, @Phone, @Notes)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Notes", notes);

                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool UpdateClient(int clientID, string fullName, string phone, string notes)
        {
            using (SqlConnection con = new SqlConnection(Database.ConnectionString))
            {
                string query = @"UPDATE Clients 
                         SET FullName=@FullName, Phone=@Phone, Notes=@Notes
                         WHERE ClientID=@ClientID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ClientID", clientID);
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Notes", notes);

                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public static bool DeleteClient(int clientID)
        {
            using (SqlConnection con = new SqlConnection(Database.ConnectionString))
            {
                string query = @"DELETE FROM Clients WHERE ClientID=@ClientID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ClientID", clientID);

                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool HasContracts(int clientID)
        {
            using (SqlConnection con = new SqlConnection(Database.ConnectionString))
            {
                string query = "SELECT COUNT(*) FROM Contracts WHERE ClientID=@ClientID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ClientID", clientID);
                    con.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0; // true إذا العميل له عقود
                }
            }
        }




    }
}
