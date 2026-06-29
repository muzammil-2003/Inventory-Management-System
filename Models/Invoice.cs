using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    internal class Invoice
    {
        public int Id { get; set; }
        public string InvoiceNumber { get; set; } = "";
        public int CustomerId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal ReceivedAmount { get; set; }
        public decimal ChangeAmount { get; set; }
        public int UserId { get; set; }
    }
}
