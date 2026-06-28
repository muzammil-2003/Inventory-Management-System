using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Services
{
    internal class BillingService
    {
        private readonly List<CartItem> _cart = new List<CartItem>();
        public List<CartItem> GetCartItems()
        {
            return _cart;
        }
        public bool AddToCart(CartItem cartItem, int availableStock, out string errorMessage)
        {
            errorMessage = "";
            CartItem existingItem = _cart.FirstOrDefault(item => item.ProductId == cartItem.ProductId);
            if (existingItem != null)
            {
                if (existingItem.Quantity + cartItem.Quantity > availableStock)
                {
                    errorMessage = "Insufficient Stock";
                    return false;
                }
                existingItem.Quantity += cartItem.Quantity;
            }
            else
            {
                _cart.Add(cartItem);
            }
            return true;
        }
        public void RemoveItem(CartItem cartItem)
        {
            _cart.Remove(cartItem);
        }
        public void ClearCart()
        {
            _cart.Clear();
        }
        public BillSummary CalculateTotals(decimal discountPercent)
        {
            decimal subtotal = _cart.Sum(item => item.Total);
            decimal discountAmount = subtotal * discountPercent / 100;
            return new BillSummary
            {
                Subtotal = subtotal,
                DiscountPercent = discountPercent,
                DiscountAmount = discountAmount,
                GrandTotal = subtotal - discountAmount
            };
        }
    }
}
