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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.button1 = new System.Windows.Forms.Button();
            this.dtProductList = new System.Windows.Forms.DataGridView();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.group8DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.group8DataSet = new WinAppz.group8DataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQauntity = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inventoriesTableAdapter = new WinAppz.group8DataSetTableAdapters.InventoriesTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvSlip = new System.Windows.Forms.ListView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSlip = new System.Windows.Forms.Button();
            this.lTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lvCart = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.group8DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.group8DataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(567, 847);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(174, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "CheckOut";
            this.button1.UseVisualStyleBackColor = false;
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
            this.dtProductList.DataSource = this.inventoriesBindingSource;
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
            // inventoriesBindingSource
            // 
            this.inventoriesBindingSource.DataMember = "Inventories";
            this.inventoriesBindingSource.DataSource = this.group8DataSetBindingSource;
            // 
            // group8DataSetBindingSource
            // 
            this.group8DataSetBindingSource.DataSource = this.group8DataSet;
            this.group8DataSetBindingSource.Position = 0;
            // 
            // group8DataSet
            // 
            this.group8DataSet.DataSetName = "group8DataSet";
            this.group8DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddToCart);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtQauntity);
            this.groupBox1.Controls.Add(this.txtCategory);
            this.groupBox1.Controls.Add(this.txtPName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(15, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 407);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnAddToCart.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddToCart.Location = new System.Drawing.Point(171, 336);
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
            this.txtPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoriesBindingSource, "SellingPrice", true));
            this.txtPrice.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.inventoriesBindingSource, "SellingPrice", true));
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(171, 233);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(174, 45);
            this.txtPrice.TabIndex = 2;
            this.txtPrice.Tag = "R";
            // 
            // txtQauntity
            // 
            this.txtQauntity.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtQauntity.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQauntity.Location = new System.Drawing.Point(171, 162);
            this.txtQauntity.Multiline = true;
            this.txtQauntity.Name = "txtQauntity";
            this.txtQauntity.Size = new System.Drawing.Size(174, 45);
            this.txtQauntity.TabIndex = 2;
            // 
            // txtCategory
            // 
            this.txtCategory.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCategory.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.inventoriesBindingSource, "Category", true));
            this.txtCategory.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoriesBindingSource, "Category", true));
            this.txtCategory.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.Location = new System.Drawing.Point(171, 95);
            this.txtCategory.Multiline = true;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(174, 45);
            this.txtCategory.TabIndex = 2;
            // 
            // txtPName
            // 
            this.txtPName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPName.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.inventoriesBindingSource, "ProductName", true));
            this.txtPName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoriesBindingSource, "ProductName", true));
            this.txtPName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPName.Location = new System.Drawing.Point(171, 24);
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
            this.label4.Location = new System.Drawing.Point(6, 253);
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
            this.label6.Location = new System.Drawing.Point(10, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Qauntity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(10, 115);
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
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "ProductName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(578, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search";
            // 
            // inventoriesTableAdapter
            // 
            this.inventoriesTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvSlip);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(13, 510);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 320);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reciept Info";
            // 
            // lvSlip
            // 
            this.lvSlip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.lvSlip.ForeColor = System.Drawing.Color.White;
            this.lvSlip.HideSelection = false;
            this.lvSlip.Location = new System.Drawing.Point(6, 24);
            this.lvSlip.Name = "lvSlip";
            this.lvSlip.Size = new System.Drawing.Size(335, 290);
            this.lvSlip.TabIndex = 13;
            this.lvSlip.UseCompatibleStateImageBehavior = false;
            // 
            // btnSlip
            // 
            this.btnSlip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnSlip.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlip.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSlip.Location = new System.Drawing.Point(86, 847);
            this.btnSlip.Name = "btnSlip";
            this.btnSlip.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSlip.Size = new System.Drawing.Size(174, 45);
            this.btnSlip.TabIndex = 9;
            this.btnSlip.Text = "Print Slip";
            this.btnSlip.UseVisualStyleBackColor = false;
            // 
            // lTime
            // 
            this.lTime.AutoSize = true;
            this.lTime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lTime.Location = new System.Drawing.Point(379, 40);
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
            this.columnHeader3});
            this.lvCart.ForeColor = System.Drawing.Color.White;
            this.lvCart.HideSelection = false;
            this.lvCart.Location = new System.Drawing.Point(384, 510);
            this.lvCart.Name = "lvCart";
            this.lvCart.Size = new System.Drawing.Size(523, 320);
            this.lvCart.TabIndex = 13;
            this.lvCart.UseCompatibleStateImageBehavior = false;
            this.lvCart.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ItemName";
            this.columnHeader1.Width = 156;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Qauntity";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Total";
            this.columnHeader3.Width = 243;
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
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(919, 927);
            this.Controls.Add(this.lvCart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSlip);
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
            ((System.ComponentModel.ISupportInitialize)(this.inventoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.group8DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.group8DataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtProductList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQauntity;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource group8DataSetBindingSource;
        private group8DataSet group8DataSet;
        private System.Windows.Forms.BindingSource inventoriesBindingSource;
        private group8DataSetTableAdapters.InventoriesTableAdapter inventoriesTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnSlip;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lTime;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.ListView lvSlip;
        private System.Windows.Forms.ListView lvCart;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtSearch;
    }
}