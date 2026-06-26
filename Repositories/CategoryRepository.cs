using InventoryManagementSystem.Database;
using InventoryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Repositories
{
    internal class CategoryRepository
    {
        public void AddCategory(Category category)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString)) {
                conn.Open();
                string query = "INSERT INTO Categories(Name) VALUES (@Name)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", category.Name);
                cmd.ExecuteNonQuery();
            }
            
        }
        public DataTable GetAllCategories() {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                string query = "SELECT Id, Name FROM Categories";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
        public void UpdateCategory(Category category) {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                string query = "UPDATE Categories SET Name = @Name WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", category.Id);
                cmd.Parameters.AddWithValue("@Name", category.Name);
                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteCategory(int id)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                string query = "DELETE FROM Categories WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable SearchCategories(string keyword)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                string query = "SELECT Id, Name FROM Categories WHERE Name LIKE @Keyword";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
        public DataTable GetCategories()
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                string query = "SELECT Id, Name FROM Categories";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
    }
}
