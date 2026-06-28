using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Repositories;
using InventoryManagementSystem.Services;

namespace InventoryManagementSystem.Forms
{
    public partial class BillingForm : Form
    {
        private readonly CustomerRepository _customerRepository = new CustomerRepository();
        private readonly ProductRepository _productRepository = new ProductRepository();
        private readonly InvoiceRepository _invoiceRepository = new InvoiceRepository();
        private readonly BillingService _billingService = new BillingService();
        public BillingForm()
        {
            InitializeComponent();
            LoadCustomers();
            LoadProducts();
        }
        public void LoadCustomers()
        {
            DataTable customers = _customerRepository.GetAllCustomers();
            cbxCustomer.DataSource = customers;
            cbxCustomer.DisplayMember = "Name";
            cbxCustomer.ValueMember = "Id";
            cbxCustomer.SelectedIndex = -1;
        }
        public void LoadProducts() {
            DataTable products = _productRepository.GetAllProducts();
            cbxProducts.DataSource = products;
            cbxProducts.DisplayMember = "Name";
            cbxProducts.ValueMember = "Id";
            cbxProducts.SelectedIndex = -1;
            tbxPrice.Clear();
            tbxStock.Clear();
        }
        private void cbxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxProducts.SelectedIndex == -1)
            {
                return;
            }
            DataRowView row = (DataRowView)cbxProducts.SelectedItem;
            tbxPrice.Text = row["Price"].ToString();
            tbxStock.Text = row["Quantity"].ToString();
        }
        private void tbxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private CartItem ValidateCartItem()
        {
            if (cbxProducts.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product.");
                cbxProducts.Focus();
                return null;
            }
            if (!int.TryParse(tbxQuantity.Text, out int quantity))
            {
                MessageBox.Show("Enter a valid quantity.");
                tbxQuantity.Focus();
                return null;
            }
            if (quantity <= 0)
            {
                MessageBox.Show("Quantity must be greater than zero.");
                tbxQuantity.Focus();
                return null;
            }
            int availableStock = Convert.ToInt32(tbxStock.Text);
            if (quantity > availableStock)
            {
                MessageBox.Show("Insufficient stock.");
                tbxQuantity.Focus();
                return null;
            }
            DataRowView row = (DataRowView)cbxProducts.SelectedItem;
            return new CartItem
            {
                ProductId = Convert.ToInt32(row["Id"]),
                ProductName = row["Name"].ToString(),
                Price = Convert.ToDecimal(row["Price"]),
                Quantity = quantity
            };
        }
        private void RefreshCart()
        {
            dgvCart.DataSource = null;
            dgvCart.DataSource = _billingService.GetCartItems();

        }
        private void LoadTotals()
        {
            decimal.TryParse(tbxDiscount.Text, out decimal discount);
            BillSummary summary = _billingService.CalculateTotals(discount);
            lblSubtotal.Text = summary.Subtotal.ToString("N2");
            lblGrandTotal.Text = summary.GrandTotal.ToString("N2");
        }
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            CartItem cartItem = ValidateCartItem();
            if (cartItem == null)
            {
                return;
            }
            int availableStock = Convert.ToInt32(tbxStock.Text);
            if (!_billingService.AddToCart(cartItem, availableStock, out string error)) {
                MessageBox.Show(error);
                return;
            }
            RefreshCart();
            LoadTotals();
            ClearProductSelection();
        }
        private void ClearProductSelection()
        {
            cbxProducts.SelectedIndex = -1;
            tbxPrice.Clear();
            tbxStock.Clear();
            tbxQuantity.Clear();
            cbxProducts.Focus();
        }
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a product.");
                return;
            }
            CartItem cartItem = (CartItem)dgvCart.SelectedRows[0].DataBoundItem;
            _billingService.RemoveItem(cartItem);
            RefreshCart();
            LoadTotals();
            CalculateChange();
        }
        private void btnClearCart_Click(object sender, EventArgs e)
        {
            if (_billingService.GetCartItems().Count == 0)
            {
                return;
            }
            DialogResult result = MessageBox.Show("Clear the entire cart?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            _billingService.ClearCart();
            tbxDiscount.Clear();
            tbxReceived.Clear();
            RefreshCart();
            LoadTotals();
            CalculateChange();
            ClearProductSelection();
        }
        private void tbxDiscount_TextChanged(object sender, EventArgs e)
        {
            LoadTotals();
            CalculateChange();
        }
        private void tbxReceived_TextChanged(object sender, EventArgs e)
        {
            CalculateChange();
        }
        private void CalculateChange()
        {
            if (!decimal.TryParse(tbxReceived.Text, out decimal received))
            {
                lblChange.Text = "0.00";
                return;
            }

            if (!decimal.TryParse(lblGrandTotal.Text, out decimal grandTotal))
            {
                lblChange.Text = "0.00";
                return;
            }

            if (received < grandTotal)
            {
                lblChange.Text = "Insufficient Payment";
                return;
            }

            decimal change = received - grandTotal;
            lblChange.Text = change.ToString("N2");
        }
    }
}
