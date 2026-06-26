using InventoryManagementSystem.Models;
using InventoryManagementSystem.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace InventoryManagementSystem.Forms
{
    public partial class ProductForm : Form
    {
        private readonly ProductRepository _productRepository = new ProductRepository();
        private readonly CategoryRepository _categoryRepository = new CategoryRepository();
        private readonly SupplierRepository _supplierRepository = new SupplierRepository();

        private int selectedProductId = 0;
        public ProductForm()
        {
            InitializeComponent();
            LoadCategories();
            LoadSuppliers();
            LoadProducts();
        }
        public void LoadCategories()
        {
            DataTable categories = _categoryRepository.GetCategories();
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
            cmbCategory.SelectedIndex = -1;
        }
        public void LoadSuppliers()
        {
            DataTable suppliers = _supplierRepository.GetAllSuppliers();
            cmbSupplier.DataSource = suppliers;
            cmbSupplier.DisplayMember = "Name";
            cmbSupplier.ValueMember = "Id";
            cmbSupplier.SelectedIndex = -1;
        }
        private void LoadProducts() { 
            dgvProducts.DataSource = _productRepository.GetAllProducts();
        }
        private Product ValidateProduct() {
            if (string.IsNullOrWhiteSpace(txtProductName.Text)) {
                MessageBox.Show("Product name is required.");
                txtProductName.Focus();
                return null;
            }
            if (cmbCategory.SelectedIndex == -1) {
                MessageBox.Show("Please select a category.");
                cmbCategory.Focus();
                return null;
            }
            if (cmbSupplier.SelectedIndex == -1) {
                MessageBox.Show("Please select a supplier.");
                cmbSupplier.Focus();
                return null;
            }
            if (!int.TryParse(txtQuantity.Text, out int quantity)) {
                MessageBox.Show("Please enter a valid quantity.");
                txtQuantity.Focus();
                return null;
            }
            if (!decimal.TryParse(txtPrice.Text, out decimal price)) {
                MessageBox.Show("Please enter a valid price.");
                txtPrice.Focus();
                return null;
            }
            if (price <= 0) {
                MessageBox.Show("Price must be greater than zero.");
                txtPrice.Focus();
                return null;
            }
            if (quantity <= 0) {
                MessageBox.Show("Quantity must be greater than zero.");
                txtQuantity.Focus();
                return null;
            }

            return new Product
            {
                Name = txtProductName.Text.Trim(),
                Price = price,
                Quantity = quantity,
                CategoryId = Convert.ToInt32(cmbCategory.SelectedValue),
                SupplierId = Convert.ToInt32(cmbSupplier.SelectedValue)
            };
        }
        private void ClearFields()
        {
            txtProductName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            cmbCategory.SelectedIndex = -1;
            cmbSupplier.SelectedIndex = -1;
            selectedProductId = 0;
            txtProductName.Focus();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Product product = ValidateProduct();
            if (product == null) {
                return;
            }
            _productRepository.AddProduct(product);
            MessageBox.Show("Product added successfully.");
            LoadProducts();
            ClearFields();
        }
    }
}
