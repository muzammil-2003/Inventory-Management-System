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
            timerClock.Start();
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
            dgvRecentlyAddedProducts.DataSource = _dashboardRepository.GetRecentProducts();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy  hh:mm:ss tt");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDashboard();
            MessageBox.Show("Dashboard refreshed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
