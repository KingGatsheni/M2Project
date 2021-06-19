namespace WinAppz
{
    partial class Home
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.dtProductList = new System.Windows.Forms.DataGridView();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoriesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.group8NewDataSet = new WinAppz.group8NewDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbQuantity = new System.Windows.Forms.ComboBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtPId = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listSlip = new System.Windows.Forms.ListBox();
            this.LblChange = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbChange = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lvCart = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.inventoriesTableAdapter1 = new WinAppz.group8NewDataSetTableAdapters.InventoriesTableAdapter();
            this.btnupdateitem = new System.Windows.Forms.Button();
            this.btndeletefromItem = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoriesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.group8NewDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(509, 878);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(206, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "CheckOut";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtProductList
            // 
            this.dtProductList.AllowUserToAddRows = false;
            this.dtProductList.AllowUserToDeleteRows = false;
            this.dtProductList.AutoGenerateColumns = false;
            this.dtProductList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtProductList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.costPriceDataGridViewTextBoxColumn,
            this.sellingPriceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dtProductList.DataSource = this.inventoriesBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtProductList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtProductList.GridColor = System.Drawing.Color.Black;
            this.dtProductList.Location = new System.Drawing.Point(372, 84);
            this.dtProductList.Name = "dtProductList";
            this.dtProductList.ReadOnly = true;
            this.dtProductList.Size = new System.Drawing.Size(531, 405);
            this.dtProductList.TabIndex = 10;
            this.dtProductList.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtProductList_ColumnHeaderMouseClick);
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costPriceDataGridViewTextBoxColumn
            // 
            this.costPriceDataGridViewTextBoxColumn.DataPropertyName = "CostPrice";
            this.costPriceDataGridViewTextBoxColumn.HeaderText = "CostPrice";
            this.costPriceDataGridViewTextBoxColumn.Name = "costPriceDataGridViewTextBoxColumn";
            this.costPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sellingPriceDataGridViewTextBoxColumn
            // 
            this.sellingPriceDataGridViewTextBoxColumn.DataPropertyName = "SellingPrice";
            this.sellingPriceDataGridViewTextBoxColumn.HeaderText = "SellingPrice";
            this.sellingPriceDataGridViewTextBoxColumn.Name = "sellingPriceDataGridViewTextBoxColumn";
            this.sellingPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inventoriesBindingSource1
            // 
            this.inventoriesBindingSource1.DataMember = "Inventories";
            this.inventoriesBindingSource1.DataSource = this.group8NewDataSet;
            // 
            // group8NewDataSet
            // 
            this.group8NewDataSet.DataSetName = "group8NewDataSet";
            this.group8NewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbQuantity);
            this.groupBox1.Controls.Add(this.btnAddToCart);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtCategory);
            this.groupBox1.Controls.Add(this.txtPId);
            this.groupBox1.Controls.Add(this.txtPName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 407);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // cbQuantity
            // 
            this.cbQuantity.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbQuantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuantity.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuantity.FormattingEnabled = true;
            this.cbQuantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbQuantity.Location = new System.Drawing.Point(171, 224);
            this.cbQuantity.Name = "cbQuantity";
            this.cbQuantity.Size = new System.Drawing.Size(174, 38);
            this.cbQuantity.TabIndex = 14;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnAddToCart.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddToCart.Location = new System.Drawing.Point(171, 356);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddToCart.Size = new System.Drawing.Size(174, 45);
            this.btnAddToCart.TabIndex = 3;
            this.btnAddToCart.Text = "AddToCart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPrice.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.inventoriesBindingSource1, "SellingPrice", true));
            this.txtPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoriesBindingSource1, "SellingPrice", true));
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(171, 288);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(174, 45);
            this.txtPrice.TabIndex = 2;
            this.txtPrice.Tag = "";
            // 
            // txtCategory
            // 
            this.txtCategory.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCategory.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.inventoriesBindingSource1, "Category", true));
            this.txtCategory.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoriesBindingSource1, "Category", true));
            this.txtCategory.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.Location = new System.Drawing.Point(171, 150);
            this.txtCategory.Multiline = true;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(174, 45);
            this.txtCategory.TabIndex = 2;
            // 
            // txtPId
            // 
            this.txtPId.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPId.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.inventoriesBindingSource1, "InventoryId", true));
            this.txtPId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoriesBindingSource1, "InventoryId", true));
            this.txtPId.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPId.Location = new System.Drawing.Point(171, 11);
            this.txtPId.Multiline = true;
            this.txtPId.Name = "txtPId";
            this.txtPId.Size = new System.Drawing.Size(174, 45);
            this.txtPId.TabIndex = 2;
            // 
            // txtPName
            // 
            this.txtPName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPName.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.inventoriesBindingSource1, "ProductName", true));
            this.txtPName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoriesBindingSource1, "ProductName", true));
            this.txtPName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPName.Location = new System.Drawing.Point(171, 83);
            this.txtPName.Multiline = true;
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(174, 45);
            this.txtPName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(10, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(10, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Qauntity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Product ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(10, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Category";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(6, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "ProductName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(394, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search by ProductName";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listSlip);
            this.groupBox2.Controls.Add(this.LblChange);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lbChange);
            this.groupBox2.Controls.Add(this.lblDiscount);
            this.groupBox2.Controls.Add(this.lblSubtotal);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 510);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 413);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reciept Info";
            // 
            // listSlip
            // 
            this.listSlip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.listSlip.ForeColor = System.Drawing.Color.White;
            this.listSlip.FormattingEnabled = true;
            this.listSlip.ItemHeight = 17;
            this.listSlip.Location = new System.Drawing.Point(7, 24);
            this.listSlip.Name = "listSlip";
            this.listSlip.Size = new System.Drawing.Size(341, 293);
            this.listSlip.TabIndex = 15;
            // 
            // LblChange
            // 
            this.LblChange.AutoSize = true;
            this.LblChange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChange.Location = new System.Drawing.Point(260, 320);
            this.LblChange.Name = "LblChange";
            this.LblChange.Size = new System.Drawing.Size(63, 21);
            this.LblChange.TabIndex = 14;
            this.LblChange.Text = "Change";
            this.LblChange.Click += new System.EventHandler(this.label9_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(138, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 21);
            this.label9.TabIndex = 14;
            this.label9.Text = "Vat(15%)";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // lbChange
            // 
            this.lbChange.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbChange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChange.Location = new System.Drawing.Point(240, 368);
            this.lbChange.Name = "lbChange";
            this.lbChange.Size = new System.Drawing.Size(96, 34);
            this.lbChange.TabIndex = 14;
            // 
            // lblDiscount
            // 
            this.lblDiscount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(127, 368);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(96, 34);
            this.lblDiscount.TabIndex = 14;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(13, 368);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(96, 34);
            this.lblSubtotal.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "SubTotal";
            // 
            // lTime
            // 
            this.lTime.AutoSize = true;
            this.lTime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lTime.Location = new System.Drawing.Point(24, -1);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(53, 25);
            this.lTime.TabIndex = 1;
            this.lTime.Text = "Time";
            this.lTime.Click += new System.EventHandler(this.lTime_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(20, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "SubTotal";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(186, 41);
            this.txtSubTotal.Multiline = true;
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(174, 37);
            this.txtSubTotal.TabIndex = 2;
            // 
            // lvCart
            // 
            this.lvCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.lvCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCart.ForeColor = System.Drawing.Color.White;
            this.lvCart.HideSelection = false;
            this.lvCart.Location = new System.Drawing.Point(3, 21);
            this.lvCart.Name = "lvCart";
            this.lvCart.Size = new System.Drawing.Size(435, 338);
            this.lvCart.TabIndex = 13;
            this.lvCart.UseCompatibleStateImageBehavior = false;
            this.lvCart.View = System.Windows.Forms.View.Details;
            this.lvCart.SelectedIndexChanged += new System.EventHandler(this.lvCart_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ProductID";
            this.columnHeader1.Width = 95;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ProductName";
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantity";
            this.columnHeader3.Width = 119;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.Width = 165;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(650, 123);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 45);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(679, 30);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(224, 45);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvCart);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(366, 510);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(441, 362);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Invoice";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(114, 929);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(98, 40);
            this.button2.TabIndex = 15;
            this.button2.Text = "Print Slip";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // inventoriesTableAdapter1
            // 
            this.inventoriesTableAdapter1.ClearBeforeFill = true;
            // 
            // btnupdateitem
            // 
            this.btnupdateitem.BackColor = System.Drawing.Color.DarkViolet;
            this.btnupdateitem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdateitem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnupdateitem.Location = new System.Drawing.Point(810, 519);
            this.btnupdateitem.Name = "btnupdateitem";
            this.btnupdateitem.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnupdateitem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnupdateitem.Size = new System.Drawing.Size(113, 38);
            this.btnupdateitem.TabIndex = 9;
            this.btnupdateitem.Text = "Update Item";
            this.btnupdateitem.UseVisualStyleBackColor = false;
            this.btnupdateitem.Click += new System.EventHandler(this.btnupdateitem_Click);
            // 
            // btndeletefromItem
            // 
            this.btndeletefromItem.BackColor = System.Drawing.Color.Red;
            this.btndeletefromItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletefromItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndeletefromItem.Location = new System.Drawing.Point(810, 565);
            this.btndeletefromItem.Name = "btndeletefromItem";
            this.btndeletefromItem.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btndeletefromItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btndeletefromItem.Size = new System.Drawing.Size(113, 38);
            this.btndeletefromItem.TabIndex = 9;
            this.btndeletefromItem.Text = "Delete Item";
            this.btndeletefromItem.UseVisualStyleBackColor = false;
            this.btndeletefromItem.Click += new System.EventHandler(this.btndeletefromItem_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(114, 975);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(98, 40);
            this.button5.TabIndex = 15;
            this.button5.Text = "Print Slip";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button2_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(935, 966);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btndeletefromItem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnupdateitem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.dtProductList);
            this.Controls.Add(this.lTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Home";
            this.Text = "Home";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoriesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.group8NewDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtProductList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lTime;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvCart;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtPId;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbQuantity;
        private System.Windows.Forms.Label LblChange;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        public System.Windows.Forms.Label lbChange;
        public System.Windows.Forms.Label lblDiscount;
        public System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.ListBox listSlip;
        private System.Windows.Forms.Button button2;
        private group8NewDataSet group8NewDataSet;
        private System.Windows.Forms.BindingSource inventoriesBindingSource1;
        private group8NewDataSetTableAdapters.InventoriesTableAdapter inventoriesTableAdapter1;
        private System.Windows.Forms.Button btnupdateitem;
        private System.Windows.Forms.Button btndeletefromItem;
        private System.Windows.Forms.Button button5;
    }
}