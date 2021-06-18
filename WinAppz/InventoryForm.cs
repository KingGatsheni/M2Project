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
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'group8NewDataSet.Inventories' table. You can move, or remove it, as needed.
            this.inventoriesTableAdapter.Fill(this.group8NewDataSet.Inventories);

        }
    }
}
