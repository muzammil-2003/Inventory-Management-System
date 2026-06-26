using InventoryManagementSystem.Database;
using Microsoft.Data.SqlClient;
using System;

namespace InventoryManagementSystem.Repositories
{
    public class DashboardRepository
    {
        public int GetTotalProducts()
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Products";
                SqlCommand cmd = new SqlCommand(query, conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        public int GetTotalCategories()
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Categories";
                SqlCommand cmd = new SqlCommand(query, conn);
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }
        public int GetTotalSuppliers()
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Suppliers";
                SqlCommand cmd = new SqlCommand(query, conn);
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }
        public int GetTotalStock()
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                string query = "SELECT ISNULL(SUM(Quantity), 0) FROM Products";
                SqlCommand cmd = new SqlCommand(query, conn);
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }
        public decimal GetInventoryValue()
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                string query = "SELECT ISNULL(SUM(Price * Quantity),0) FROM Products";
                SqlCommand cmd = new SqlCommand(query, conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
}