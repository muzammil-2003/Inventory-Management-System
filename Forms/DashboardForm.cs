using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagementSystem.Repositories;

namespace InventoryManagementSystem.Forms
{
    public partial class DashboardForm : Form
    {
        private readonly DashboardRepository _dashboardRepository = new DashboardRepository();
        public DashboardForm()
        {
            InitializeComponent();
            LoadDashboard();
        }
        private void LoadDashboard()
        {
            lblTotalProducts.Text = _dashboardRepository.GetTotalProducts().ToString();
            lblTotalCategories.Text = _dashboardRepository.GetTotalCategories().ToString();
            lblTotalSuppliers.Text = _dashboardRepository.GetTotalSuppliers().ToString();
            lblTotalStock.Text = _dashboardRepository.GetTotalStock().ToString();
            lblTotalInventoryValue.Text = "Rs. " + _dashboardRepository.GetInventoryValue().ToString("N2");
            dgvLowStock.DataSource = _dashboardRepository.GetLowStockProducts();
        }
    }
}
