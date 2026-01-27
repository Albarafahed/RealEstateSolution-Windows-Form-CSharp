using Microsoft.Data.SqlClient;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace RealEstate.DataAccess
{
    public static class Database
    {
        public static string ConnectionString = "Data Source=.;Initial Catalog=RealEstateDB;Integrated Security=True;Trust Server Certificate=True";

        //"Server=.;Database=RealEstateDB;User Id=sa;Password=123456;";
    }
}
