namespace WinAppz
{
    partial class Repairs
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
            this.btnItemList = new System.Windows.Forms.Button();
            this.btnBookRepair = new System.Windows.Forms.Button();
            this.groupRepairItem = new System.Windows.Forms.GroupBox();
            this.cbQuantity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtItemFault = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvRepairList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPhysicalAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtCellNo = new System.Windows.Forms.TextBox();
            this.btnPayRepair = new System.Windows.Forms.Button();
            this.lbMissing = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchByEmail = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.Button();
            this.groupRepairItem.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnItemList
            // 
            this.btnItemList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnItemList.Enabled = false;
            this.btnItemList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemList.ForeColor = System.Drawing.Color.White;
            this.btnItemList.Location = new System.Drawing.Point(727, 459);
            this.btnItemList.Name = "btnItemList";
            this.btnItemList.Size = new System.Drawing.Size(178, 74);
            this.btnItemList.TabIndex = 13;
            this.btnItemList.Text = "Add Item To List";
            this.btnItemList.UseVisualStyleBackColor = false;
            this.btnItemList.Click += new System.EventHandler(this.btnItemList_Click);
            // 
            // btnBookRepair
            // 
            this.btnBookRepair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnBookRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookRepair.ForeColor = System.Drawing.Color.White;
            this.btnBookRepair.Location = new System.Drawing.Point(593, 788);
            this.btnBookRepair.Name = "btnBookRepair";
            this.btnBookRepair.Size = new System.Drawing.Size(230, 74);
            this.btnBookRepair.TabIndex = 14;
            this.btnBookRepair.Text = "Book a Repair";
            this.btnBookRepair.UseVisualStyleBackColor = false;
            this.btnBookRepair.Click += new System.EventHandler(this.btnBookRepair_Click);
            // 
            // groupRepairItem
            // 
            this.groupRepairItem.Controls.Add(this.cbQuantity);
            this.groupRepairItem.Controls.Add(this.label5);
            this.groupRepairItem.Controls.Add(this.label4);
            this.groupRepairItem.Controls.Add(this.label3);
            this.groupRepairItem.Controls.Add(this.label8);
            this.groupRepairItem.Controls.Add(this.txtItemFault);
            this.groupRepairItem.Controls.Add(this.txtPrice);
            this.groupRepairItem.Controls.Add(this.txtItemName);
            this.groupRepairItem.Enabled = false;
            this.groupRepairItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupRepairItem.ForeColor = System.Drawing.Color.White;
            this.groupRepairItem.Location = new System.Drawing.Point(486, 93);
            this.groupRepairItem.Name = "groupRepairItem";
            this.groupRepairItem.Size = new System.Drawing.Size(419, 360);
            this.groupRepairItem.TabIndex = 9;
            this.groupRepairItem.TabStop = false;
            this.groupRepairItem.Text = "Repair Item";
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
            "5"});
            this.cbQuantity.Location = new System.Drawing.Point(138, 235);
            this.cbQuantity.Name = "cbQuantity";
            this.cbQuantity.Size = new System.Drawing.Size(275, 38);
            this.cbQuantity.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(6, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Item Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(6, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Repair Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(6, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(6, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Item Fault";
            // 
            // txtItemFault
            // 
            this.txtItemFault.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtItemFault.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemFault.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtItemFault.Location = new System.Drawing.Point(138, 99);
            this.txtItemFault.Multiline = true;
            this.txtItemFault.Name = "txtItemFault";
            this.txtItemFault.Size = new System.Drawing.Size(275, 118);
            this.txtItemFault.TabIndex = 9;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPrice.Location = new System.Drawing.Point(138, 288);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(275, 45);
            this.txtPrice.TabIndex = 8;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtItemName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtItemName.Location = new System.Drawing.Point(138, 37);
            this.txtItemName.Multiline = true;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(275, 45);
            this.txtItemName.TabIndex = 7;
            this.txtItemName.TextChanged += new System.EventHandler(this.txtItemName_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvRepairList);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(26, 532);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(561, 422);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Repair ItemList";
            // 
            // lvRepairList
            // 
            this.lvRepairList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.lvRepairList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvRepairList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvRepairList.ForeColor = System.Drawing.Color.White;
            this.lvRepairList.HideSelection = false;
            this.lvRepairList.Location = new System.Drawing.Point(3, 18);
            this.lvRepairList.Name = "lvRepairList";
            this.lvRepairList.Size = new System.Drawing.Size(555, 401);
            this.lvRepairList.TabIndex = 14;
            this.lvRepairList.UseCompatibleStateImageBehavior = false;
            this.lvRepairList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ItemName";
            this.columnHeader1.Width = 107;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ItemFault";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantity";
            this.columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "RepairPrice";
            this.columnHeader4.Width = 165;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPhysicalAddress);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtFname);
            this.groupBox1.Controls.Add(this.txtLName);
            this.groupBox1.Controls.Add(this.txtCellNo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(29, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 360);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Info";
            // 
            // txtPhysicalAddress
            // 
            this.txtPhysicalAddress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPhysicalAddress.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhysicalAddress.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPhysicalAddress.Location = new System.Drawing.Point(190, 267);
            this.txtPhysicalAddress.Multiline = true;
            this.txtPhysicalAddress.Name = "txtPhysicalAddress";
            this.txtPhysicalAddress.Size = new System.Drawing.Size(230, 82);
            this.txtPhysicalAddress.TabIndex = 9;
            this.txtPhysicalAddress.TextChanged += new System.EventHandler(this.txtPhysicalAddress_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(6, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "Physical address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(6, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Email Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(6, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cellphone No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(6, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "First Name";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtEmail.Location = new System.Drawing.Point(190, 205);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(230, 45);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtFname
            // 
            this.txtFname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFname.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtFname.Location = new System.Drawing.Point(190, 21);
            this.txtFname.Multiline = true;
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(230, 45);
            this.txtFname.TabIndex = 8;
            this.txtFname.TextChanged += new System.EventHandler(this.txtFname_TextChanged);
            // 
            // txtLName
            // 
            this.txtLName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtLName.Location = new System.Drawing.Point(190, 83);
            this.txtLName.Multiline = true;
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(230, 45);
            this.txtLName.TabIndex = 7;
            this.txtLName.TextChanged += new System.EventHandler(this.txtLName_TextChanged);
            // 
            // txtCellNo
            // 
            this.txtCellNo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCellNo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCellNo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtCellNo.Location = new System.Drawing.Point(190, 143);
            this.txtCellNo.Multiline = true;
            this.txtCellNo.Name = "txtCellNo";
            this.txtCellNo.Size = new System.Drawing.Size(230, 45);
            this.txtCellNo.TabIndex = 6;
            this.txtCellNo.TextChanged += new System.EventHandler(this.txtCellNo_TextChanged);
            this.txtCellNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCellNo_KeyPress);
            // 
            // btnPayRepair
            // 
            this.btnPayRepair.BackColor = System.Drawing.Color.Blue;
            this.btnPayRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayRepair.ForeColor = System.Drawing.Color.White;
            this.btnPayRepair.Location = new System.Drawing.Point(593, 880);
            this.btnPayRepair.Name = "btnPayRepair";
            this.btnPayRepair.Size = new System.Drawing.Size(230, 74);
            this.btnPayRepair.TabIndex = 14;
            this.btnPayRepair.Text = "Paying For an Item?";
            this.btnPayRepair.UseVisualStyleBackColor = false;
            this.btnPayRepair.Click += new System.EventHandler(this.btnPayRepair_Click);
            // 
            // lbMissing
            // 
            this.lbMissing.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMissing.IsDerivedStyle = true;
            this.lbMissing.Location = new System.Drawing.Point(520, 497);
            this.lbMissing.Name = "lbMissing";
            this.lbMissing.Size = new System.Drawing.Size(64, 36);
            this.lbMissing.Style = MetroSet_UI.Enums.Style.Dark;
            this.lbMissing.StyleManager = null;
            this.lbMissing.TabIndex = 15;
            this.lbMissing.Text = "R0.00";
            this.lbMissing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbMissing.ThemeAuthor = "Narwin";
            this.lbMissing.ThemeName = "MetroDark";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroSetLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(348, 497);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(166, 36);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 15;
            this.metroSetLabel1.Text = "Total Repair Price";
            this.metroSetLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroDark";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Search By Email";
            // 
            // txtSearchByEmail
            // 
            this.txtSearchByEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearchByEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSearchByEmail.Location = new System.Drawing.Point(241, 20);
            this.txtSearchByEmail.Multiline = true;
            this.txtSearchByEmail.Name = "txtSearchByEmail";
            this.txtSearchByEmail.Size = new System.Drawing.Size(214, 45);
            this.txtSearchByEmail.TabIndex = 17;
            this.txtSearchByEmail.TextChanged += new System.EventHandler(this.txtSearchByEmail_TextChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(461, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(75, 45);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.Text = "Search";
            this.txtSearch.UseVisualStyleBackColor = false;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // Repairs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(935, 966);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtSearchByEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroSetLabel1);
            this.Controls.Add(this.lbMissing);
            this.Controls.Add(this.btnItemList);
            this.Controls.Add(this.btnPayRepair);
            this.Controls.Add(this.btnBookRepair);
            this.Controls.Add(this.groupRepairItem);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Repairs";
            this.Text = "Repairs";
            this.Load += new System.EventHandler(this.Repairs_Load);
            this.groupRepairItem.ResumeLayout(false);
            this.groupRepairItem.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnItemList;
        private System.Windows.Forms.Button btnBookRepair;
        private System.Windows.Forms.GroupBox groupRepairItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtItemFault;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtCellNo;
        private System.Windows.Forms.Button btnPayRepair;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbQuantity;
        private System.Windows.Forms.TextBox txtPhysicalAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private MetroSet_UI.Controls.MetroSetLabel lbMissing;
        private System.Windows.Forms.ListView lvRepairList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchByEmail;
        private System.Windows.Forms.Button txtSearch;
    }
}