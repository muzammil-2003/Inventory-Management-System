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

namespace InventoryManagementSystem.Forms
{
    public partial class CategoryForm : Form
    {
        private readonly CategoryRepository _repo = new CategoryRepository();
        private int selectedCategoryId = 0;
        public CategoryForm()
        {
            InitializeComponent();
            LoadCategories();
        }

        private void LoadCategories()
        {
            dgvCategories.DataSource = _repo.GetAllCategories();
        }
        private void ClearFields()
        {
            tbxCategoryName.Clear();
            selectedCategoryId = 0;
            tbxCategoryName.Focus();
        }
        private Category ValidateCategory()
        {
            if (string.IsNullOrEmpty(tbxCategoryName.Text)) {
                MessageBox.Show("Category name is required.");
                return null;
            }
            return new Category
            {
                Name = tbxCategoryName.Text.Trim()
            };
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Category category = ValidateCategory();
            if (category == null) {
                return;
            }
            _repo.AddCategory(category);
            LoadCategories();
            ClearFields();
            MessageBox.Show("Category added successfully.");
        }
        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) {
                return;
            }
            DataGridViewRow row = dgvCategories.Rows[e.RowIndex];
            selectedCategoryId = Convert.ToInt32(row.Cells["Id"].Value);
            tbxCategoryName.Text = row.Cells["Name"].Value.ToString();
        }
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            dgvCategories.DataSource = _repo.SearchCategories(tbxSearch.Text.Trim());
        }
    }
}
