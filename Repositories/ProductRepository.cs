using InventoryManagementSystem.Database;
using InventoryManagementSystem.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace InventoryManagementSystem.Repositories
{
    public class ProductRepository
    {
        public void AddProduct(Product product)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                string query = "INSERT INTO Products(Name, Price, Quantity, CategoryId, SupplierId) VALUES ( @Name, @Price, @Quantity, @CategoryId, @SupplierId)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", product.Name);
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@Quantity", product.Quantity);
                cmd.Parameters.AddWithValue("@CategoryId", product.CategoryId);
                cmd.Parameters.AddWithValue("@SupplierId", product.SupplierId);

                cmd.ExecuteNonQuery();
            }
        }
        public DataTable GetAllProducts()
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                string query = @"SELECT p.Id, p.Name, p.Price, p.Quantity, c.Name AS Category,
                                s.Name AS Supplier FROM Products p INNER JOIN Categories 
                                c ON p.CategoryId = c.Id INNER JOIN Suppliers s ON p.SupplierId = s.Id";
                
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
    }
}