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
    public partial class RepairPayForm : Form
    {
        public RepairPayForm()
        {
            InitializeComponent();
        }

        private void RepairPayForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'group8NewDataSet1.Invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter.Fill(this.group8NewDataSet1.Invoice);
            // TODO: This line of code loads data into the 'group8NewDataSet.Invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter.Fill(this.group8NewDataSet.Invoice);

        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtSearchbyNo_TextChanged(object sender, EventArgs e)
        {
            this.invoiceTableAdapter.FillBySearch(group8NewDataSet.Invoice, txtSearchbyNo.Text);
        }
    }
}
