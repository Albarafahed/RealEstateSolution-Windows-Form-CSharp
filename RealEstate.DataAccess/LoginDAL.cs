using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace RealEstate.DataAccess
{
    public class LoginDAL
    {
            public bool CheckLogin(string username, string password)
            {
                bool isValid = false;

                string query = @"SELECT 1 FROM Users 
                             WHERE Username = @Username 
                             AND Password = @Password";

                using (SqlConnection con = new SqlConnection(Database.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        isValid = reader.HasRows;
                    }
                    catch
                    {
                        isValid = false;
                    }
                }

                return isValid;
            }
        
    }
}
