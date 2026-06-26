namespace InventoryManagementSystem.Forms
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlProducts = new System.Windows.Forms.Panel();
            this.lblProductsTitle = new System.Windows.Forms.Label();
            this.lblTotalProducts = new System.Windows.Forms.Label();
            this.pnlCategories = new System.Windows.Forms.Panel();
            this.lblTotalCategories = new System.Windows.Forms.Label();
            this.lblCategories = new System.Windows.Forms.Label();
            this.pnlSuppliers = new System.Windows.Forms.Panel();
            this.lblTotalSuppliers = new System.Windows.Forms.Label();
            this.lblSuppliers = new System.Windows.Forms.Label();
            this.pnlStocks = new System.Windows.Forms.Panel();
            this.lblTotalStock = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.pnlInventoryValue = new System.Windows.Forms.Panel();
            this.lblTotalInventoryValue = new System.Windows.Forms.Label();
            this.lblInventoryValue = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLowStock = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlProducts.SuspendLayout();
            this.pnlCategories.SuspendLayout();
            this.pnlSuppliers.SuspendLayout();
            this.pnlStocks.SuspendLayout();
            this.pnlInventoryValue.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(870, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "INVENTORY DASHBOARD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0033F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0033F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.9934F));
            this.tableLayoutPanel1.Controls.Add(this.pnlInventoryValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlStocks, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlCategories, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlProducts, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlSuppliers, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 80);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(870, 240);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pnlProducts
            // 
            this.pnlProducts.BackColor = System.Drawing.Color.LightCyan;
            this.pnlProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProducts.Controls.Add(this.lblTotalProducts);
            this.pnlProducts.Controls.Add(this.lblProductsTitle);
            this.pnlProducts.Location = new System.Drawing.Point(18, 18);
            this.pnlProducts.Margin = new System.Windows.Forms.Padding(15);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Size = new System.Drawing.Size(250, 87);
            this.pnlProducts.TabIndex = 0;
            // 
            // lblProductsTitle
            // 
            this.lblProductsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProductsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductsTitle.Location = new System.Drawing.Point(0, 0);
            this.lblProductsTitle.Name = "lblProductsTitle";
            this.lblProductsTitle.Size = new System.Drawing.Size(248, 35);
            this.lblProductsTitle.TabIndex = 0;
            this.lblProductsTitle.Text = "Total Products";
            this.lblProductsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalProducts
            // 
            this.lblTotalProducts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotalProducts.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProducts.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTotalProducts.Location = new System.Drawing.Point(0, 32);
            this.lblTotalProducts.Name = "lblTotalProducts";
            this.lblTotalProducts.Size = new System.Drawing.Size(248, 53);
            this.lblTotalProducts.TabIndex = 1;
            this.lblTotalProducts.Text = "0";
            this.lblTotalProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCategories
            // 
            this.pnlCategories.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnlCategories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCategories.Controls.Add(this.lblTotalCategories);
            this.pnlCategories.Controls.Add(this.lblCategories);
            this.pnlCategories.Location = new System.Drawing.Point(303, 18);
            this.pnlCategories.Margin = new System.Windows.Forms.Padding(15);
            this.pnlCategories.Name = "pnlCategories";
            this.pnlCategories.Size = new System.Drawing.Size(250, 87);
            this.pnlCategories.TabIndex = 2;
            // 
            // lblTotalCategories
            // 
            this.lblTotalCategories.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotalCategories.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCategories.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTotalCategories.Location = new System.Drawing.Point(0, 32);
            this.lblTotalCategories.Name = "lblTotalCategories";
            this.lblTotalCategories.Size = new System.Drawing.Size(248, 53);
            this.lblTotalCategories.TabIndex = 1;
            this.lblTotalCategories.Text = "0";
            this.lblTotalCategories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCategories
            // 
            this.lblCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCategories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategories.Location = new System.Drawing.Point(0, 0);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(248, 35);
            this.lblCategories.TabIndex = 0;
            this.lblCategories.Text = "Total Categories";
            this.lblCategories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSuppliers
            // 
            this.pnlSuppliers.BackColor = System.Drawing.Color.Orange;
            this.pnlSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSuppliers.Controls.Add(this.lblTotalSuppliers);
            this.pnlSuppliers.Controls.Add(this.lblSuppliers);
            this.pnlSuppliers.Location = new System.Drawing.Point(588, 18);
            this.pnlSuppliers.Margin = new System.Windows.Forms.Padding(15);
            this.pnlSuppliers.Name = "pnlSuppliers";
            this.pnlSuppliers.Size = new System.Drawing.Size(250, 87);
            this.pnlSuppliers.TabIndex = 2;
            // 
            // lblTotalSuppliers
            // 
            this.lblTotalSuppliers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotalSuppliers.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSuppliers.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTotalSuppliers.Location = new System.Drawing.Point(0, 32);
            this.lblTotalSuppliers.Name = "lblTotalSuppliers";
            this.lblTotalSuppliers.Size = new System.Drawing.Size(248, 53);
            this.lblTotalSuppliers.TabIndex = 1;
            this.lblTotalSuppliers.Text = "0";
            this.lblTotalSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSuppliers
            // 
            this.lblSuppliers.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSuppliers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppliers.Location = new System.Drawing.Point(0, 0);
            this.lblSuppliers.Name = "lblSuppliers";
            this.lblSuppliers.Size = new System.Drawing.Size(248, 35);
            this.lblSuppliers.TabIndex = 0;
            this.lblSuppliers.Text = "Total Suppliers";
            this.lblSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlStocks
            // 
            this.pnlStocks.BackColor = System.Drawing.Color.Violet;
            this.pnlStocks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStocks.Controls.Add(this.lblTotalStock);
            this.pnlStocks.Controls.Add(this.lblStock);
            this.pnlStocks.Location = new System.Drawing.Point(18, 135);
            this.pnlStocks.Margin = new System.Windows.Forms.Padding(15);
            this.pnlStocks.Name = "pnlStocks";
            this.pnlStocks.Size = new System.Drawing.Size(250, 87);
            this.pnlStocks.TabIndex = 2;
            // 
            // lblTotalStock
            // 
            this.lblTotalStock.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotalStock.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalStock.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTotalStock.Location = new System.Drawing.Point(0, 32);
            this.lblTotalStock.Name = "lblTotalStock";
            this.lblTotalStock.Size = new System.Drawing.Size(248, 53);
            this.lblTotalStock.TabIndex = 1;
            this.lblTotalStock.Text = "0";
            this.lblTotalStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStock
            // 
            this.lblStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(0, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(248, 35);
            this.lblStock.TabIndex = 0;
            this.lblStock.Text = "Total Stock";
            this.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlInventoryValue
            // 
            this.pnlInventoryValue.BackColor = System.Drawing.Color.PeachPuff;
            this.pnlInventoryValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInventoryValue.Controls.Add(this.lblTotalInventoryValue);
            this.pnlInventoryValue.Controls.Add(this.lblInventoryValue);
            this.pnlInventoryValue.Location = new System.Drawing.Point(303, 135);
            this.pnlInventoryValue.Margin = new System.Windows.Forms.Padding(15);
            this.pnlInventoryValue.Name = "pnlInventoryValue";
            this.pnlInventoryValue.Size = new System.Drawing.Size(250, 87);
            this.pnlInventoryValue.TabIndex = 2;
            // 
            // lblTotalInventoryValue
            // 
            this.lblTotalInventoryValue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotalInventoryValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInventoryValue.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTotalInventoryValue.Location = new System.Drawing.Point(0, 32);
            this.lblTotalInventoryValue.Name = "lblTotalInventoryValue";
            this.lblTotalInventoryValue.Size = new System.Drawing.Size(248, 53);
            this.lblTotalInventoryValue.TabIndex = 1;
            this.lblTotalInventoryValue.Text = "0";
            this.lblTotalInventoryValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInventoryValue
            // 
            this.lblInventoryValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInventoryValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryValue.Location = new System.Drawing.Point(0, 0);
            this.lblInventoryValue.Name = "lblInventoryValue";
            this.lblInventoryValue.Size = new System.Drawing.Size(248, 35);
            this.lblInventoryValue.TabIndex = 0;
            this.lblInventoryValue.Text = "Inventory Value";
            this.lblInventoryValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLowStock);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 320);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(870, 312);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Low Stock Products";
            // 
            // dgvLowStock
            // 
            this.dgvLowStock.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvLowStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLowStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLowStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLowStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLowStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLowStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLowStock.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLowStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLowStock.EnableHeadersVisualStyles = false;
            this.dgvLowStock.GridColor = System.Drawing.Color.LightGray;
            this.dgvLowStock.Location = new System.Drawing.Point(3, 30);
            this.dgvLowStock.MultiSelect = false;
            this.dgvLowStock.Name = "dgvLowStock";
            this.dgvLowStock.ReadOnly = true;
            this.dgvLowStock.RowHeadersWidth = 51;
            this.dgvLowStock.RowTemplate.Height = 35;
            this.dgvLowStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLowStock.Size = new System.Drawing.Size(864, 279);
            this.dgvLowStock.TabIndex = 0;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(900, 647);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DashboardForm";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlProducts.ResumeLayout(false);
            this.pnlCategories.ResumeLayout(false);
            this.pnlSuppliers.ResumeLayout(false);
            this.pnlStocks.ResumeLayout(false);
            this.pnlInventoryValue.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlProducts;
        private System.Windows.Forms.Label lblTotalProducts;
        private System.Windows.Forms.Label lblProductsTitle;
        private System.Windows.Forms.Panel pnlSuppliers;
        private System.Windows.Forms.Label lblTotalSuppliers;
        private System.Windows.Forms.Label lblSuppliers;
        private System.Windows.Forms.Panel pnlCategories;
        private System.Windows.Forms.Label lblTotalCategories;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Panel pnlInventoryValue;
        private System.Windows.Forms.Label lblTotalInventoryValue;
        private System.Windows.Forms.Label lblInventoryValue;
        private System.Windows.Forms.Panel pnlStocks;
        private System.Windows.Forms.Label lblTotalStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLowStock;
    }
}