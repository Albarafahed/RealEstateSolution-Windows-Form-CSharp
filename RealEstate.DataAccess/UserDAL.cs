using Microsoft.Data.SqlClient;
using RealEstate.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.DataAccess
{
    public class UserDAL
    {
        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Database.ConnectionString))
            {
                string query = "SELECT UserID, Username,Password, Photo , Role FROM Users";
                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }
        public static void UpdateUserPhoto(int userId, string photoPath)
        {
            using SqlConnection con = new SqlConnection(Database.ConnectionString);
            string query = "UPDATE Users SET Photo = @Photo WHERE UserID = @UserID";

            using SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Photo", photoPath);
            cmd.Parameters.AddWithValue("@UserID", userId);

            con.Open();
            cmd.ExecuteNonQuery();
        }

    }
}
