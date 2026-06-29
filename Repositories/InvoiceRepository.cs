using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using InventoryManagementSystem.Database;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Repositories
{
    internal class InvoiceRepository
    {
        public void SaveInvoice(Invoice invoice, List<CartItem> cartItems)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    int invoiceId = InsertInvoice(invoice, conn, transaction);
                    foreach (CartItem item in cartItems) {
                        InsertInvoiceItem(invoiceId, item, conn, transaction);
                        UpdateProductStock(item, conn, transaction);

                    }
                        transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
        private int InsertInvoice(Invoice invoice, SqlConnection connection, SqlTransaction transaction) {
            string query = "INSERT INTO Invoices(InvoiceNumber, CustomerId, InvoiceDate, DiscountPercent, DiscountAmount, TotalAmount, ReceivedAmount, ChangeAmount, UserId) OUTPUT INSERTED.Id VALUES (@InvoiceNumber, @CustomerId, @InvoiceDate, @DiscountPercent, @DiscountAmount, @TotalAmount, @ReceivedAmount, @ChangeAmount, @UserId)";
            SqlCommand command = new SqlCommand(query, connection, transaction);
            command.Parameters.AddWithValue("@InvoiceNumber", invoice.InvoiceNumber);
            command.Parameters.AddWithValue("@CustomerId", invoice.CustomerId);
            command.Parameters.AddWithValue("@InvoiceDate", invoice.InvoiceDate);
            command.Parameters.AddWithValue("@TotalAmount", invoice.TotalAmount);
            command.Parameters.AddWithValue("@DiscountPercent", invoice.DiscountPercent);
            command.Parameters.AddWithValue("@DiscountAmount", invoice.DiscountAmount);
            command.Parameters.AddWithValue("@ReceivedAmount", invoice.ReceivedAmount);
            command.Parameters.AddWithValue("@ChangeAmount", invoice.ChangeAmount);
            command.Parameters.AddWithValue("@UserId", (object)invoice.UserId ?? DBNull.Value);
            return Convert.ToInt32(command.ExecuteScalar());
        }
        private void InsertInvoiceItem(int invoiceId, CartItem item, SqlConnection connection, SqlTransaction transaction)
        {
            string query = "INSERT INTO InvoiceItems(InvoiceId, ProductId, Quantity, UnitPrice, Total) VALUES (@InvoiceId, @ProductId, @Quantity, @UnitPrice, @Total);";
            SqlCommand cmd = new SqlCommand(query, connection, transaction);
            cmd.Parameters.AddWithValue("@InvoiceId", invoiceId);
            cmd.Parameters.AddWithValue("@ProductId", item.ProductId);
            cmd.Parameters.AddWithValue("@Quantity", item.Quantity);
            cmd.Parameters.AddWithValue("@UnitPrice", item.Price);
            cmd.Parameters.AddWithValue("@Total", item.Total);
            cmd.ExecuteNonQuery();
        }
        private void UpdateProductStock(CartItem item, SqlConnection connection, SqlTransaction transaction)
        {
            string query = "UPDATE Products SET Quantity = Quantity - @Quantity WHERE Id = @ProductId;";
            SqlCommand cmd = new SqlCommand(query, connection, transaction);
            cmd.Parameters.AddWithValue("@Quantity", item.Quantity);
            cmd.Parameters.AddWithValue("@ProductId", item.ProductId);
            cmd.ExecuteNonQuery();
        }
        public string GetInvoiceNumber()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Invoices WHERE CAST(InvoiceDate AS DATE) = CAST(GETDATE() AS DATE)";
                SqlCommand cmd = new SqlCommand(query, conn);
                int todayCount = Convert.ToInt32(cmd.ExecuteScalar());
                return $"INV-{DateTime.Now:ddMMyyyy}-{(todayCount + 1):D4}";
            }
        }
    }
}