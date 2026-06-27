using InventoryManagementSystem.Database;
using InventoryManagementSystem.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace InventoryManagementSystem.Repositories
{
    public class CustomerRepository
    {
        public void AddCustomer(Customer customer)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "INSERT INTO Customers (Name, Phone, Address) VALUES (@Name, @Phone, @Address)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", customer.Name);
                cmd.Parameters.AddWithValue("@Phone", customer.Phone);
                cmd.Parameters.AddWithValue("@Address", customer.Address);
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable GetAllCustomers()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT Id, Name, Phone, Address FROM Customers ORDER BY Name";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
        public void UpdateCustomer(Customer customer)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "UPDATE Customers SET Name=@Name, Phone=@Phone, Address=@Address WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", customer.Id);
                cmd.Parameters.AddWithValue("@Name", customer.Name);
                cmd.Parameters.AddWithValue("@Phone", customer.Phone);
                cmd.Parameters.AddWithValue("@Address", customer.Address);
                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteCustomer(int id)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "DELETE FROM Customers WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable SearchCustomer(string keyword)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT Id, Name, Phone, Address FROM Customers WHERE Name LIKE @Keyword or Phone LIKE @Keyword ORDER BY Name";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
    }
}