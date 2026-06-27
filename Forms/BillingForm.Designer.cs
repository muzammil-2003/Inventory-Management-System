namespace InventoryManagementSystem.Forms
{
    partial class BillingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.grpInvoiceInfo = new System.Windows.Forms.GroupBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDateTitle = new System.Windows.Forms.Label();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.lblInvoiceNoTitle = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.cbxCustomer = new System.Windows.Forms.ComboBox();
            this.grpProductInfo = new System.Windows.Forms.GroupBox();
            this.grpShoppingCart = new System.Windows.Forms.GroupBox();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.grpTotals = new System.Windows.Forms.GroupBox();
            this.lblSubtotalTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReceivedTitle = new System.Windows.Forms.Label();
            this.lblGrandTotalTitle = new System.Windows.Forms.Label();
            this.lblChangeTitle = new System.Windows.Forms.Label();
            this.tbxReceived = new System.Windows.Forms.TextBox();
            this.tbxDiscount = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSaveInvoice = new System.Windows.Forms.Button();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.tbxStock = new System.Windows.Forms.TextBox();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.tlpMain.SuspendLayout();
            this.grpInvoiceInfo.SuspendLayout();
            this.grpProductInfo.SuspendLayout();
            this.grpShoppingCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.grpTotals.SuspendLayout();
            this.flpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.grpInvoiceInfo, 0, 0);
            this.tlpMain.Controls.Add(this.grpProductInfo, 0, 1);
            this.tlpMain.Controls.Add(this.grpShoppingCart, 0, 2);
            this.tlpMain.Controls.Add(this.grpTotals, 0, 3);
            this.tlpMain.Controls.Add(this.flpButtons, 0, 4);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(10, 10);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 5;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.Size = new System.Drawing.Size(999, 695);
            this.tlpMain.TabIndex = 0;
            // 
            // grpInvoiceInfo
            // 
            this.grpInvoiceInfo.Controls.Add(this.cbxCustomer);
            this.grpInvoiceInfo.Controls.Add(this.lblCustomer);
            this.grpInvoiceInfo.Controls.Add(this.lblDate);
            this.grpInvoiceInfo.Controls.Add(this.lblDateTitle);
            this.grpInvoiceInfo.Controls.Add(this.lblInvoiceNo);
            this.grpInvoiceInfo.Controls.Add(this.lblInvoiceNoTitle);
            this.grpInvoiceInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpInvoiceInfo.Location = new System.Drawing.Point(3, 3);
            this.grpInvoiceInfo.Name = "grpInvoiceInfo";
            this.grpInvoiceInfo.Padding = new System.Windows.Forms.Padding(5);
            this.grpInvoiceInfo.Size = new System.Drawing.Size(993, 104);
            this.grpInvoiceInfo.TabIndex = 0;
            this.grpInvoiceInfo.TabStop = false;
            this.grpInvoiceInfo.Text = "Invoice Information";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(380, 46);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(112, 23);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "26-Jun-2026";
            // 
            // lblDateTitle
            // 
            this.lblDateTitle.AutoSize = true;
            this.lblDateTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTitle.Location = new System.Drawing.Point(321, 46);
            this.lblDateTitle.Name = "lblDateTitle";
            this.lblDateTitle.Size = new System.Drawing.Size(53, 23);
            this.lblDateTitle.TabIndex = 2;
            this.lblDateTitle.Text = "Date:";
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNo.Location = new System.Drawing.Point(113, 47);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(86, 23);
            this.lblInvoiceNo.TabIndex = 1;
            this.lblInvoiceNo.Text = "INV-0001";
            // 
            // lblInvoiceNoTitle
            // 
            this.lblInvoiceNoTitle.AutoSize = true;
            this.lblInvoiceNoTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNoTitle.Location = new System.Drawing.Point(8, 47);
            this.lblInvoiceNoTitle.Name = "lblInvoiceNoTitle";
            this.lblInvoiceNoTitle.Size = new System.Drawing.Size(99, 23);
            this.lblInvoiceNoTitle.TabIndex = 0;
            this.lblInvoiceNoTitle.Text = "Invoice No:";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(610, 46);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(93, 23);
            this.lblCustomer.TabIndex = 4;
            this.lblCustomer.Text = "Customer:";
            // 
            // cbxCustomer
            // 
            this.cbxCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCustomer.FormattingEnabled = true;
            this.cbxCustomer.Location = new System.Drawing.Point(715, 46);
            this.cbxCustomer.Name = "cbxCustomer";
            this.cbxCustomer.Size = new System.Drawing.Size(250, 24);
            this.cbxCustomer.TabIndex = 5;
            // 
            // grpProductInfo
            // 
            this.grpProductInfo.Controls.Add(this.cmbProducts);
            this.grpProductInfo.Controls.Add(this.lblProductName);
            this.grpProductInfo.Controls.Add(this.textBox1);
            this.grpProductInfo.Controls.Add(this.lblPrice);
            this.grpProductInfo.Controls.Add(this.btnAddToCart);
            this.grpProductInfo.Controls.Add(this.tbxStock);
            this.grpProductInfo.Controls.Add(this.tbxQuantity);
            this.grpProductInfo.Controls.Add(this.lblQuantity);
            this.grpProductInfo.Controls.Add(this.lblStock);
            this.grpProductInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpProductInfo.Location = new System.Drawing.Point(3, 113);
            this.grpProductInfo.Name = "grpProductInfo";
            this.grpProductInfo.Padding = new System.Windows.Forms.Padding(5);
            this.grpProductInfo.Size = new System.Drawing.Size(993, 174);
            this.grpProductInfo.TabIndex = 1;
            this.grpProductInfo.TabStop = false;
            this.grpProductInfo.Text = "Product Information";
            // 
            // grpShoppingCart
            // 
            this.grpShoppingCart.Controls.Add(this.dgvCart);
            this.grpShoppingCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpShoppingCart.Location = new System.Drawing.Point(3, 293);
            this.grpShoppingCart.Name = "grpShoppingCart";
            this.grpShoppingCart.Padding = new System.Windows.Forms.Padding(5);
            this.grpShoppingCart.Size = new System.Drawing.Size(993, 199);
            this.grpShoppingCart.TabIndex = 2;
            this.grpShoppingCart.TabStop = false;
            this.grpShoppingCart.Text = "Shopping Cart";
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.BackgroundColor = System.Drawing.Color.White;
            this.dgvCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCart.EnableHeadersVisualStyles = false;
            this.dgvCart.GridColor = System.Drawing.Color.LightGray;
            this.dgvCart.Location = new System.Drawing.Point(5, 20);
            this.dgvCart.MultiSelect = false;
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCart.RowTemplate.Height = 32;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(983, 174);
            this.dgvCart.TabIndex = 0;
            // 
            // grpTotals
            // 
            this.grpTotals.Controls.Add(this.lblChange);
            this.grpTotals.Controls.Add(this.lblGrandTotal);
            this.grpTotals.Controls.Add(this.lblSubtotal);
            this.grpTotals.Controls.Add(this.tbxDiscount);
            this.grpTotals.Controls.Add(this.tbxReceived);
            this.grpTotals.Controls.Add(this.lblChangeTitle);
            this.grpTotals.Controls.Add(this.lblGrandTotalTitle);
            this.grpTotals.Controls.Add(this.lblReceivedTitle);
            this.grpTotals.Controls.Add(this.label1);
            this.grpTotals.Controls.Add(this.lblSubtotalTitle);
            this.grpTotals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTotals.Location = new System.Drawing.Point(3, 498);
            this.grpTotals.Name = "grpTotals";
            this.grpTotals.Padding = new System.Windows.Forms.Padding(5);
            this.grpTotals.Size = new System.Drawing.Size(993, 134);
            this.grpTotals.TabIndex = 3;
            this.grpTotals.TabStop = false;
            this.grpTotals.Text = "Invoice Summary";
            // 
            // lblSubtotalTitle
            // 
            this.lblSubtotalTitle.AutoSize = true;
            this.lblSubtotalTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalTitle.Location = new System.Drawing.Point(16, 42);
            this.lblSubtotalTitle.Name = "lblSubtotalTitle";
            this.lblSubtotalTitle.Size = new System.Drawing.Size(84, 23);
            this.lblSubtotalTitle.TabIndex = 0;
            this.lblSubtotalTitle.Text = "Subtotal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Discount:";
            // 
            // lblReceivedTitle
            // 
            this.lblReceivedTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReceivedTitle.AutoSize = true;
            this.lblReceivedTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceivedTitle.Location = new System.Drawing.Point(348, 40);
            this.lblReceivedTitle.Name = "lblReceivedTitle";
            this.lblReceivedTitle.Size = new System.Drawing.Size(86, 23);
            this.lblReceivedTitle.TabIndex = 2;
            this.lblReceivedTitle.Text = "Received:";
            // 
            // lblGrandTotalTitle
            // 
            this.lblGrandTotalTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGrandTotalTitle.AutoSize = true;
            this.lblGrandTotalTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotalTitle.Location = new System.Drawing.Point(348, 89);
            this.lblGrandTotalTitle.Name = "lblGrandTotalTitle";
            this.lblGrandTotalTitle.Size = new System.Drawing.Size(108, 23);
            this.lblGrandTotalTitle.TabIndex = 3;
            this.lblGrandTotalTitle.Text = "Grand Total:";
            // 
            // lblChangeTitle
            // 
            this.lblChangeTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChangeTitle.AutoSize = true;
            this.lblChangeTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeTitle.Location = new System.Drawing.Point(711, 40);
            this.lblChangeTitle.Name = "lblChangeTitle";
            this.lblChangeTitle.Size = new System.Drawing.Size(75, 23);
            this.lblChangeTitle.TabIndex = 4;
            this.lblChangeTitle.Text = "Change:";
            // 
            // tbxReceived
            // 
            this.tbxReceived.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxReceived.Location = new System.Drawing.Point(450, 40);
            this.tbxReceived.MaximumSize = new System.Drawing.Size(120, 22);
            this.tbxReceived.Name = "tbxReceived";
            this.tbxReceived.Size = new System.Drawing.Size(120, 22);
            this.tbxReceived.TabIndex = 5;
            this.tbxReceived.Text = "0";
            this.tbxReceived.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxDiscount
            // 
            this.tbxDiscount.Location = new System.Drawing.Point(113, 89);
            this.tbxDiscount.Name = "tbxDiscount";
            this.tbxDiscount.Size = new System.Drawing.Size(112, 22);
            this.tbxDiscount.TabIndex = 6;
            this.tbxDiscount.Text = "0";
            this.tbxDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(114, 42);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(45, 23);
            this.lblSubtotal.TabIndex = 7;
            this.lblSubtotal.Text = "0.00";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.ForeColor = System.Drawing.Color.DarkRed;
            this.lblGrandTotal.Location = new System.Drawing.Point(462, 87);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(45, 23);
            this.lblGrandTotal.TabIndex = 8;
            this.lblGrandTotal.Text = "0.00";
            // 
            // lblChange
            // 
            this.lblChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(792, 40);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(45, 23);
            this.lblChange.TabIndex = 9;
            this.lblChange.Text = "0.00";
            // 
            // flpButtons
            // 
            this.flpButtons.Controls.Add(this.btnClear);
            this.flpButtons.Controls.Add(this.btnPrint);
            this.flpButtons.Controls.Add(this.btnSaveInvoice);
            this.flpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpButtons.Location = new System.Drawing.Point(3, 638);
            this.flpButtons.Name = "flpButtons";
            this.flpButtons.Padding = new System.Windows.Forms.Padding(10);
            this.flpButtons.Size = new System.Drawing.Size(993, 54);
            this.flpButtons.TabIndex = 4;
            this.flpButtons.WrapContents = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(840, 13);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 40);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(704, 13);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(130, 40);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnSaveInvoice
            // 
            this.btnSaveInvoice.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSaveInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveInvoice.FlatAppearance.BorderSize = 0;
            this.btnSaveInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveInvoice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveInvoice.ForeColor = System.Drawing.Color.White;
            this.btnSaveInvoice.Location = new System.Drawing.Point(568, 13);
            this.btnSaveInvoice.Name = "btnSaveInvoice";
            this.btnSaveInvoice.Size = new System.Drawing.Size(130, 40);
            this.btnSaveInvoice.TabIndex = 2;
            this.btnSaveInvoice.Text = "Save Invoice";
            this.btnSaveInvoice.UseVisualStyleBackColor = false;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(452, 46);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(61, 23);
            this.lblStock.TabIndex = 2;
            this.lblStock.Text = "Stock:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(452, 101);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(85, 23);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity:";
            // 
            // tbxStock
            // 
            this.tbxStock.Location = new System.Drawing.Point(549, 43);
            this.tbxStock.Name = "tbxStock";
            this.tbxStock.ReadOnly = true;
            this.tbxStock.Size = new System.Drawing.Size(100, 22);
            this.tbxStock.TabIndex = 6;
            this.tbxStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Location = new System.Drawing.Point(549, 101);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(100, 22);
            this.tbxQuantity.TabIndex = 7;
            this.tbxQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddToCart.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(730, 115);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(150, 40);
            this.btnAddToCart.TabIndex = 8;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(46, 98);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(54, 23);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(46, 44);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(78, 23);
            this.lblProductName.TabIndex = 11;
            this.lblProductName.Text = "Product:";
            // 
            // cmbProducts
            // 
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(137, 43);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(283, 24);
            this.cmbProducts.TabIndex = 12;
            // 
            // BillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 715);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "BillingForm";
            this.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Invoice";
            this.tlpMain.ResumeLayout(false);
            this.grpInvoiceInfo.ResumeLayout(false);
            this.grpInvoiceInfo.PerformLayout();
            this.grpProductInfo.ResumeLayout(false);
            this.grpProductInfo.PerformLayout();
            this.grpShoppingCart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.grpTotals.ResumeLayout(false);
            this.grpTotals.PerformLayout();
            this.flpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.GroupBox grpInvoiceInfo;
        private System.Windows.Forms.Label lblInvoiceNoTitle;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDateTitle;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cbxCustomer;
        private System.Windows.Forms.GroupBox grpProductInfo;
        private System.Windows.Forms.GroupBox grpShoppingCart;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.GroupBox grpTotals;
        private System.Windows.Forms.Label lblSubtotalTitle;
        private System.Windows.Forms.Label lblChangeTitle;
        private System.Windows.Forms.Label lblGrandTotalTitle;
        private System.Windows.Forms.Label lblReceivedTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxReceived;
        private System.Windows.Forms.TextBox tbxDiscount;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSaveInvoice;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.TextBox tbxStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.ComboBox cmbProducts;
    }
}