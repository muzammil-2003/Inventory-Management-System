using Microsoft.Data.SqlClient;

namespace InventoryManagementSystem.Database
{
    public static class DatabaseHelper
    {
        public static readonly string ConnectionString =
    "Server=.\\SQLEXPRESS;Database=InventoryDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            return conn;
        }
    }
}