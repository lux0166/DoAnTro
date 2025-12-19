using System.Data.SqlClient;
using System.Configuration;

namespace QuanLyNhaTro.Data
{
    public static class DatabaseConnection
    {
        public static string GetConnectionString()
        {
            // Read connection string from App.config
            return ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(GetConnectionString());
        }
    }
}
