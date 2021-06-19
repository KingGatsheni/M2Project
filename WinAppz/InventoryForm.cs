using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppz
{
    public partial class InventoryForm : Form
    {
        decimal percentage = 0;
        decimal sellPrice = 0;
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'group8NewDataSet.Inventories' table. You can move, or remove it, as needed.
            this.inventoriesTableAdapter.Fill(this.group8NewDataSet.Inventories);

        }

       

        private void cbMarkup_SelectedIndexChanged(object sender, EventArgs e)
        {
            percentage = (decimal.Parse(cbMarkup.Text.Trim('%')) / 100);
            sellPrice = decimal.Parse(txtCostPrice.Text) + (decimal.Parse(txtCostPrice.Text) * percentage);
            txtSPrice.Text = sellPrice.ToString();
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {


            this.inventoriesTableAdapter.InsertQuery(txtProductName.Text, cbCategory.SelectedItem.ToString(), decimal.Parse(txtCostPrice.Text.Trim(' ')), percentage, sellPrice, Int32.Parse(cbPQuantity.SelectedItem.ToString()));
            MessageBox.Show("Inventory Items Added Suceessfully!!");
            this.inventoriesTableAdapter.Fill(this.group8NewDataSet.Inventories);
        }

        private void txtSearchBPB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

/*
 
     */