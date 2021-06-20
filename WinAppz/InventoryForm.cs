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
            inventoriesTableAdapter.FillBySearch(group8NewDataSet.Inventories, txtSearchBPB.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        } 

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtSearchByID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtProductName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cbCategory.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtCostPrice.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cbMarkup.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtSPrice.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cbPQuantity.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.inventoriesTableAdapter.UpdateQuery(txtProductName.Text, cbCategory.Text, decimal.Parse(txtCostPrice.Text), (decimal.Parse(cbMarkup.Text.Trim('%'))/100), decimal.Parse(txtSPrice.Text), int.Parse(cbPQuantity.Text), int.Parse(txtSearchByID.Text));
            MessageBox.Show("Inventory Item Updated Suceessfully!!");
            this.inventoriesTableAdapter.Fill(this.group8NewDataSet.Inventories);
        }
    }
}

/*
 
     */