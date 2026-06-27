using System;
using System.Data;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Repositories;
using System.Windows.Forms;

namespace InventoryManagementSystem.Forms
{
    public partial class CustomerForm : Form
    {
        private readonly CustomerRepository _customerRepository = new CustomerRepository();
        private int selectedCustomerId = 0;
        public CustomerForm()
        {
            InitializeComponent();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void LoadCustomers()
        {
            dgvCustomers.DataSource = _customerRepository.GetAllCustomers();
            dgvCustomers.ClearSelection();
        }
        private Customer ValidateCustomer()
        {
            if (string.IsNullOrEmpty(tbxName.Text))
            {
                MessageBox.Show("Customer name is required.");
                tbxName.Focus();
                return null;
            }
            return new Customer
            {
                Name = tbxName.Text.Trim(),
                Phone = tbxPhone.Text.Trim(),
                Address = tbxAddress.Text.Trim()
            };
        }
        private void ClearFields()
        {
            tbxName.Clear();
            tbxPhone.Clear();
            tbxAddress.Clear();

            selectedCustomerId = 0;

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            tbxName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer customer = ValidateCustomer();
            if (customer == null)
            {
                return;
            }
            _customerRepository.AddCustomer(customer);
            MessageBox.Show("Customer added successfully");
            LoadCustomers();
            ClearFields();
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];
            selectedCustomerId = Convert.ToInt32(row.Cells["Id"].Value);
            tbxName.Text = row.Cells["Name"].Value.ToString();
            tbxPhone.Text = row.Cells["Phone"].Value.ToString();
            tbxAddress.Text = row.Cells["Address"].Value.ToString();
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCustomerId == 0)
            {
                MessageBox.Show("Please select a customer first.");
                return;
            }
            Customer customer = ValidateCustomer();
            if (customer == null)
            {
                return;
            }
            customer.Id = selectedCustomerId;
            _customerRepository.UpdateCustomer(customer);
            MessageBox.Show("Customer updated successfully.");
            LoadCustomers();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCustomerId == 0)
            {
                MessageBox.Show("Please select a customer first");
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            _customerRepository.DeleteCustomer(selectedCustomerId);
            MessageBox.Show("Customer deleted successfully.");
            LoadCustomers();
            ClearFields();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvCustomers.DataSource = _customerRepository.SearchCustomer(tbxSearch.Text.Trim());
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }
    }
}
