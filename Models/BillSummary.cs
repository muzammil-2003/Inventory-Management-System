using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    internal class BillSummary
    {
        public decimal Subtotal { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal GrandTotal { get; set; }
        public decimal ReceivedAmount { get; set; }
        public decimal ChangeAmount { get; set; }
    }
}
