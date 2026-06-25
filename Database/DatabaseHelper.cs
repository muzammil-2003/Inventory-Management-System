using Microsoft.Data.SqlClient;

namespace InventoryManagementSystem.Database
{
    public static class DatabaseHelper
    {
        public static string ConnectionString =
    "Server=.\\SQLEXPRESS;Database=InventoryDB;Trusted_Connection=True;TrustServerCertificate=True;";
    }
}