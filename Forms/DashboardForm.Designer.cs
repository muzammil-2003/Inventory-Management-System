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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLowStock = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvRecentlyAddedProducts = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlInventoryValue = new System.Windows.Forms.Panel();
            this.lblTotalInventoryValue = new System.Windows.Forms.Label();
            this.lblInventoryValue = new System.Windows.Forms.Label();
            this.pnlStocks = new System.Windows.Forms.Panel();
            this.lblTotalStock = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.pnlCategories = new System.Windows.Forms.Panel();
            this.lblTotalCategories = new System.Windows.Forms.Label();
            this.lblCategories = new System.Windows.Forms.Label();
            this.pnlProducts = new System.Windows.Forms.Panel();
            this.lblTotalProducts = new System.Windows.Forms.Label();
            this.lblProductsTitle = new System.Windows.Forms.Label();
            this.pnlSuppliers = new System.Windows.Forms.Panel();
            this.lblTotalSuppliers = new System.Windows.Forms.Label();
            this.lblSuppliers = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentlyAddedProducts)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlInventoryValue.SuspendLayout();
            this.pnlStocks.SuspendLayout();
            this.pnlCategories.SuspendLayout();
            this.pnlProducts.SuspendLayout();
            this.pnlSuppliers.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerClock
            // 
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(15, 355);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Size = new System.Drawing.Size(870, 277);
            this.splitContainer1.SplitterDistance = 430;
            this.splitContainer1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLowStock);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 269);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Low Stock Products";
            // 
            // dgvLowStock
            // 
            this.dgvLowStock.AllowUserToAddRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvLowStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvLowStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLowStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLowStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLowStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvLowStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.dgvLowStock.Size = new System.Drawing.Size(416, 236);
            this.dgvLowStock.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvRecentlyAddedProducts);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(4, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 269);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recently Added Products";
            // 
            // dgvRecentlyAddedProducts
            // 
            this.dgvRecentlyAddedProducts.AllowUserToAddRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvRecentlyAddedProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvRecentlyAddedProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentlyAddedProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecentlyAddedProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecentlyAddedProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvRecentlyAddedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentlyAddedProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecentlyAddedProducts.EnableHeadersVisualStyles = false;
            this.dgvRecentlyAddedProducts.GridColor = System.Drawing.Color.LightGray;
            this.dgvRecentlyAddedProducts.Location = new System.Drawing.Point(3, 30);
            this.dgvRecentlyAddedProducts.MultiSelect = false;
            this.dgvRecentlyAddedProducts.Name = "dgvRecentlyAddedProducts";
            this.dgvRecentlyAddedProducts.ReadOnly = true;
            this.dgvRecentlyAddedProducts.RowHeadersWidth = 51;
            this.dgvRecentlyAddedProducts.RowTemplate.Height = 35;
            this.dgvRecentlyAddedProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecentlyAddedProducts.Size = new System.Drawing.Size(422, 236);
            this.dgvRecentlyAddedProducts.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.lblDateTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15);
            this.panel1.Size = new System.Drawing.Size(870, 100);
            this.panel1.TabIndex = 7;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 115);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(870, 244);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // pnlInventoryValue
            // 
            this.pnlInventoryValue.BackColor = System.Drawing.Color.PeachPuff;
            this.pnlInventoryValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInventoryValue.Controls.Add(this.lblTotalInventoryValue);
            this.pnlInventoryValue.Controls.Add(this.lblInventoryValue);
            this.pnlInventoryValue.Location = new System.Drawing.Point(303, 137);
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
            // pnlStocks
            // 
            this.pnlStocks.BackColor = System.Drawing.Color.Violet;
            this.pnlStocks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStocks.Controls.Add(this.lblTotalStock);
            this.pnlStocks.Controls.Add(this.lblStock);
            this.pnlStocks.Location = new System.Drawing.Point(18, 137);
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
            // lblDateTime
            // 
            this.lblDateTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(15, 15);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(253, 70);
            this.lblDateTime.TabIndex = 0;
            this.lblDateTime.Text = "DateTime";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefresh.Location = new System.Drawing.Point(736, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(119, 70);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 70);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inventory Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(900, 647);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DashboardForm";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentlyAddedProducts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlInventoryValue.ResumeLayout(false);
            this.pnlStocks.ResumeLayout(false);
            this.pnlCategories.ResumeLayout(false);
            this.pnlProducts.ResumeLayout(false);
            this.pnlSuppliers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLowStock;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvRecentlyAddedProducts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlInventoryValue;
        private System.Windows.Forms.Label lblTotalInventoryValue;
        private System.Windows.Forms.Label lblInventoryValue;
        private System.Windows.Forms.Panel pnlStocks;
        private System.Windows.Forms.Label lblTotalStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Panel pnlCategories;
        private System.Windows.Forms.Label lblTotalCategories;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Panel pnlProducts;
        private System.Windows.Forms.Label lblTotalProducts;
        private System.Windows.Forms.Label lblProductsTitle;
        private System.Windows.Forms.Panel pnlSuppliers;
        private System.Windows.Forms.Label lblTotalSuppliers;
        private System.Windows.Forms.Label lblSuppliers;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
    }
}