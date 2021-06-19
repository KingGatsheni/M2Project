namespace WinAppz
{
    partial class InventoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbPQuantity = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.txtSPrice = new System.Windows.Forms.TextBox();
            this.txtCostPrice = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnArchive = new System.Windows.Forms.Button();
            this.cbMarkup = new System.Windows.Forms.ComboBox();
            this.inventoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.group8NewDataSet = new WinAppz.group8NewDataSet();
            this.inventoriesTableAdapter = new WinAppz.group8NewDataSetTableAdapters.InventoriesTableAdapter();
            this.inventoryIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markupDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchBPB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.group8NewDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMarkup);
            this.groupBox1.Controls.Add(this.cbCategory);
            this.groupBox1.Controls.Add(this.cbPQuantity);
            this.groupBox1.Controls.Add(this.btnAddStock);
            this.groupBox1.Controls.Add(this.txtSPrice);
            this.groupBox1.Controls.Add(this.txtCostPrice);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 481);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Laptops/Computers",
            "Accessories"});
            this.cbCategory.Location = new System.Drawing.Point(171, 90);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(229, 38);
            this.cbCategory.TabIndex = 14;
            // 
            // cbPQuantity
            // 
            this.cbPQuantity.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbPQuantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPQuantity.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPQuantity.FormattingEnabled = true;
            this.cbPQuantity.Items.AddRange(new object[] {
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
            this.cbPQuantity.Location = new System.Drawing.Point(171, 368);
            this.cbPQuantity.Name = "cbPQuantity";
            this.cbPQuantity.Size = new System.Drawing.Size(229, 38);
            this.cbPQuantity.TabIndex = 14;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.BlueViolet;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(752, 22);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUpdate.Size = new System.Drawing.Size(171, 106);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAddStock
            // 
            this.btnAddStock.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddStock.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddStock.Location = new System.Drawing.Point(171, 426);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddStock.Size = new System.Drawing.Size(229, 45);
            this.btnAddStock.TabIndex = 3;
            this.btnAddStock.Text = "Add To Inventory";
            this.btnAddStock.UseVisualStyleBackColor = false;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // txtSPrice
            // 
            this.txtSPrice.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSPrice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSPrice.Location = new System.Drawing.Point(171, 288);
            this.txtSPrice.Multiline = true;
            this.txtSPrice.Name = "txtSPrice";
            this.txtSPrice.Size = new System.Drawing.Size(229, 45);
            this.txtSPrice.TabIndex = 2;
            this.txtSPrice.Tag = "";
            // 
            // txtCostPrice
            // 
            this.txtCostPrice.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCostPrice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostPrice.Location = new System.Drawing.Point(171, 150);
            this.txtCostPrice.Multiline = true;
            this.txtCostPrice.Name = "txtCostPrice";
            this.txtCostPrice.Size = new System.Drawing.Size(229, 45);
            this.txtCostPrice.TabIndex = 2;
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(171, 24);
            this.txtProductName.Multiline = true;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(229, 45);
            this.txtProductName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(10, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(10, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Selling Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(10, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "MarkUp(%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Product Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(10, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Cost Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(6, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Category";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 511);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(751, 386);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "InventoryList";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inventoryIdDataGridViewTextBoxColumn1,
            this.productNameDataGridViewTextBoxColumn1,
            this.categoryDataGridViewTextBoxColumn1,
            this.costPriceDataGridViewTextBoxColumn1,
            this.markupDataGridViewTextBoxColumn1,
            this.sellingPriceDataGridViewTextBoxColumn1,
            this.quantityDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.inventoriesBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(3, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(745, 362);
            this.dataGridView1.TabIndex = 11;
            // 
            // btnArchive
            // 
            this.btnArchive.BackColor = System.Drawing.Color.Red;
            this.btnArchive.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchive.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnArchive.Location = new System.Drawing.Point(752, 182);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnArchive.Size = new System.Drawing.Size(171, 101);
            this.btnArchive.TabIndex = 3;
            this.btnArchive.Text = "Archived Inventory Item";
            this.btnArchive.UseVisualStyleBackColor = false;
            // 
            // cbMarkup
            // 
            this.cbMarkup.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbMarkup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarkup.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarkup.FormattingEnabled = true;
            this.cbMarkup.Items.AddRange(new object[] {
            "10%",
            "15%",
            "20%",
            "25%",
            "30%",
            "35%",
            "40%",
            "45%",
            "50%"});
            this.cbMarkup.Location = new System.Drawing.Point(171, 224);
            this.cbMarkup.Name = "cbMarkup";
            this.cbMarkup.Size = new System.Drawing.Size(229, 38);
            this.cbMarkup.TabIndex = 14;
            this.cbMarkup.SelectedIndexChanged += new System.EventHandler(this.cbMarkup_SelectedIndexChanged);
            // 
            // inventoriesBindingSource
            // 
            this.inventoriesBindingSource.DataMember = "Inventories";
            this.inventoriesBindingSource.DataSource = this.group8NewDataSet;
            // 
            // group8NewDataSet
            // 
            this.group8NewDataSet.DataSetName = "group8NewDataSet";
            this.group8NewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoriesTableAdapter
            // 
            this.inventoriesTableAdapter.ClearBeforeFill = true;
            // 
            // inventoryIdDataGridViewTextBoxColumn1
            // 
            this.inventoryIdDataGridViewTextBoxColumn1.DataPropertyName = "InventoryId";
            this.inventoryIdDataGridViewTextBoxColumn1.HeaderText = "InventoryId";
            this.inventoryIdDataGridViewTextBoxColumn1.Name = "inventoryIdDataGridViewTextBoxColumn1";
            this.inventoryIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn1
            // 
            this.productNameDataGridViewTextBoxColumn1.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn1.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn1.Name = "productNameDataGridViewTextBoxColumn1";
            this.productNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn1
            // 
            this.categoryDataGridViewTextBoxColumn1.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn1.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn1.Name = "categoryDataGridViewTextBoxColumn1";
            this.categoryDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // costPriceDataGridViewTextBoxColumn1
            // 
            this.costPriceDataGridViewTextBoxColumn1.DataPropertyName = "CostPrice";
            this.costPriceDataGridViewTextBoxColumn1.HeaderText = "CostPrice";
            this.costPriceDataGridViewTextBoxColumn1.Name = "costPriceDataGridViewTextBoxColumn1";
            this.costPriceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // markupDataGridViewTextBoxColumn1
            // 
            this.markupDataGridViewTextBoxColumn1.DataPropertyName = "Markup";
            this.markupDataGridViewTextBoxColumn1.HeaderText = "Markup";
            this.markupDataGridViewTextBoxColumn1.Name = "markupDataGridViewTextBoxColumn1";
            this.markupDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sellingPriceDataGridViewTextBoxColumn1
            // 
            this.sellingPriceDataGridViewTextBoxColumn1.DataPropertyName = "SellingPrice";
            this.sellingPriceDataGridViewTextBoxColumn1.HeaderText = "SellingPrice";
            this.sellingPriceDataGridViewTextBoxColumn1.Name = "sellingPriceDataGridViewTextBoxColumn1";
            this.sellingPriceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn1
            // 
            this.quantityDataGridViewTextBoxColumn1.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn1.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn1.Name = "quantityDataGridViewTextBoxColumn1";
            this.quantityDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // txtSearchBPB
            // 
            this.txtSearchBPB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSearchBPB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBPB.Location = new System.Drawing.Point(450, 448);
            this.txtSearchBPB.Multiline = true;
            this.txtSearchBPB.Name = "txtSearchBPB";
            this.txtSearchBPB.Size = new System.Drawing.Size(286, 45);
            this.txtSearchBPB.TabIndex = 17;
            this.txtSearchBPB.TextChanged += new System.EventHandler(this.txtSearchBPB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(443, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 37);
            this.label2.TabIndex = 18;
            this.label2.Text = "SearchBy ProductName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(443, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 37);
            this.label5.TabIndex = 18;
            this.label5.Text = "Update Inventory By Id";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(450, 83);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 45);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.txtSearchBPB_TextChanged);
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(935, 966);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtSearchBPB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "InventoryForm";
            this.Text = "InventoryForm";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.group8NewDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private group8NewDataSet group8NewDataSet;
        private System.Windows.Forms.BindingSource inventoriesBindingSource;
        private group8NewDataSetTableAdapters.InventoriesTableAdapter inventoriesTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbPQuantity;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.TextBox txtSPrice;
        private System.Windows.Forms.TextBox txtCostPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbMarkup;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn costPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn markupDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox txtSearchBPB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
    }
}