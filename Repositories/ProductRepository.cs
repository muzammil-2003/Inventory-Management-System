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
        public void UpdateProduct(Product product)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                string query = "UPDATE Products SET Name = @Name, Price = @Price, Quantity = @Quantity, CategoryId = @CategoryId, SupplierId = @SupplierId WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", product.Id);
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
                string query = @"SELECT p.Id, p.Name, p.Price, p.Quantity, p.CategoryId, p.SupplierId, 
                                c.Name AS Category, s.Name AS Supplier FROM Products 
                                p INNER JOIN Categories c ON p.CategoryId = c.Id INNER JOIN Suppliers s ON p.SupplierId = s.Id";
                
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
        public void DeleteProduct(int id)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                string query = "DELETE FROM Products WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable SearchProduct(string keyword)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                string query = "SELECT p.Id, p.Name, p.Price, p.Quantity, p.CategoryId, p.SupplierId, c.Name AS Category, s.Name AS Supplier FROM Products p INNER JOIN Categories c ON p.CategoryId = c.Id INNER JOIN Suppliers s ON p.SupplierId = s.Id  WHERE p.Name LIKE @Keyword";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
    }
}