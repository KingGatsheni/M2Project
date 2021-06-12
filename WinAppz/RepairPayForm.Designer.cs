namespace WinAppz
{
    partial class RepairPayForm
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
            this.txtSearchbyNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtProductList = new System.Windows.Forms.DataGridView();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPayNow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalOwed = new System.Windows.Forms.TextBox();
            this.invoiceBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.group8NewDataSet = new WinAppz.group8NewDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBookon = new System.Windows.Forms.TextBox();
            this.invoiceTableAdapter = new WinAppz.group8NewDataSetTableAdapters.InvoiceTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repairPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repairTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.group8NewDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchbyNo
            // 
            this.txtSearchbyNo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearchbyNo.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.invoiceBindingSource2, "Cell_No", true));
            this.txtSearchbyNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource2, "Cell_No", true));
            this.txtSearchbyNo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchbyNo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSearchbyNo.Location = new System.Drawing.Point(629, 12);
            this.txtSearchbyNo.Multiline = true;
            this.txtSearchbyNo.Name = "txtSearchbyNo";
            this.txtSearchbyNo.Size = new System.Drawing.Size(230, 45);
            this.txtSearchbyNo.TabIndex = 9;
            this.txtSearchbyNo.TextChanged += new System.EventHandler(this.txtSearchbyNo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(382, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 32);
            this.label5.TabIndex = 14;
            this.label5.Text = "Customer\'s Number";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtProductList);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(68, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 491);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Items in for Reapirs";
            // 
            // dtProductList
            // 
            this.dtProductList.AllowUserToAddRows = false;
            this.dtProductList.AllowUserToDeleteRows = false;
            this.dtProductList.AutoGenerateColumns = false;
            this.dtProductList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtProductList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lastNameDataGridViewTextBoxColumn,
            this.cellNoDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.repairPriceDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.repairTotalDataGridViewTextBoxColumn,
            this.bookonDataGridViewTextBoxColumn});
            this.dtProductList.DataSource = this.invoiceBindingSource2;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtProductList.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtProductList.GridColor = System.Drawing.Color.Black;
            this.dtProductList.Location = new System.Drawing.Point(3, 22);
            this.dtProductList.Name = "dtProductList";
            this.dtProductList.ReadOnly = true;
            this.dtProductList.Size = new System.Drawing.Size(754, 466);
            this.dtProductList.TabIndex = 11;
            this.dtProductList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtProductList_CellContentClick);
            // 
            // btnPayNow
            // 
            this.btnPayNow.BackColor = System.Drawing.Color.Blue;
            this.btnPayNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayNow.ForeColor = System.Drawing.Color.White;
            this.btnPayNow.Location = new System.Drawing.Point(722, 780);
            this.btnPayNow.Name = "btnPayNow";
            this.btnPayNow.Size = new System.Drawing.Size(140, 74);
            this.btnPayNow.TabIndex = 17;
            this.btnPayNow.Text = "Pay Now";
            this.btnPayNow.UseVisualStyleBackColor = false;
            this.btnPayNow.Click += new System.EventHandler(this.btnPayNow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(516, 606);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "Total Owing";
            // 
            // txtTotalOwed
            // 
            this.txtTotalOwed.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotalOwed.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.invoiceBindingSource2, "RepairTotal", true));
            this.txtTotalOwed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource2, "RepairTotal", true));
            this.txtTotalOwed.Enabled = false;
            this.txtTotalOwed.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalOwed.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtTotalOwed.Location = new System.Drawing.Point(713, 593);
            this.txtTotalOwed.Multiline = true;
            this.txtTotalOwed.Name = "txtTotalOwed";
            this.txtTotalOwed.ReadOnly = true;
            this.txtTotalOwed.Size = new System.Drawing.Size(146, 45);
            this.txtTotalOwed.TabIndex = 9;
            // 
            // invoiceBindingSource2
            // 
            this.invoiceBindingSource2.DataMember = "Invoice";
            this.invoiceBindingSource2.DataSource = this.group8NewDataSet;
            // 
            // group8NewDataSet
            // 
            this.group8NewDataSet.DataSetName = "group8NewDataSet";
            this.group8NewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(507, 677);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "Was BookedOn";
            // 
            // txtBookon
            // 
            this.txtBookon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBookon.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.invoiceBindingSource2, "Bookon", true));
            this.txtBookon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource2, "Bookon", true));
            this.txtBookon.Enabled = false;
            this.txtBookon.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookon.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBookon.Location = new System.Drawing.Point(713, 664);
            this.txtBookon.Multiline = true;
            this.txtBookon.Name = "txtBookon";
            this.txtBookon.ReadOnly = true;
            this.txtBookon.Size = new System.Drawing.Size(146, 45);
            this.txtBookon.TabIndex = 9;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(545, 780);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 74);
            this.button1.TabIndex = 17;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cellNoDataGridViewTextBoxColumn
            // 
            this.cellNoDataGridViewTextBoxColumn.DataPropertyName = "Cell_No";
            this.cellNoDataGridViewTextBoxColumn.HeaderText = "Cell_No";
            this.cellNoDataGridViewTextBoxColumn.Name = "cellNoDataGridViewTextBoxColumn";
            this.cellNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // repairPriceDataGridViewTextBoxColumn
            // 
            this.repairPriceDataGridViewTextBoxColumn.DataPropertyName = "RepairPrice";
            this.repairPriceDataGridViewTextBoxColumn.HeaderText = "RepairPrice";
            this.repairPriceDataGridViewTextBoxColumn.Name = "repairPriceDataGridViewTextBoxColumn";
            this.repairPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // repairTotalDataGridViewTextBoxColumn
            // 
            this.repairTotalDataGridViewTextBoxColumn.DataPropertyName = "RepairTotal";
            this.repairTotalDataGridViewTextBoxColumn.HeaderText = "RepairTotal";
            this.repairTotalDataGridViewTextBoxColumn.Name = "repairTotalDataGridViewTextBoxColumn";
            this.repairTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookonDataGridViewTextBoxColumn
            // 
            this.bookonDataGridViewTextBoxColumn.DataPropertyName = "Bookon";
            this.bookonDataGridViewTextBoxColumn.HeaderText = "Bookon";
            this.bookonDataGridViewTextBoxColumn.Name = "bookonDataGridViewTextBoxColumn";
            this.bookonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RepairPayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(878, 866);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPayNow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBookon);
            this.Controls.Add(this.txtTotalOwed);
            this.Controls.Add(this.txtSearchbyNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RepairPayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RepairPayForm";
            this.Load += new System.EventHandler(this.RepairPayForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.group8NewDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchbyNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private group8NewDataSet group8NewDataSet;
        private group8NewDataSetTableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private System.Windows.Forms.Button btnPayNow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalOwed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBookon;
        private System.Windows.Forms.DataGridView dtProductList;
        private System.Windows.Forms.BindingSource invoiceBindingSource2;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repairPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repairTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookonDataGridViewTextBoxColumn;
    }
}