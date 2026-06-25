using Microsoft.Data.SqlClient;
using InventoryManagementSystem.Database;
using System;

namespace InventoryManagementSystem.Repositories
{
    public class UserRepository
    {
        public bool Login(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString)) {
            conn.Open();
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
            }
        }
    }
}
