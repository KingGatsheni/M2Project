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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'group8DataSet2.RepairReportTable' table. You can move, or remove it, as needed.
            this.repairReportTableTableAdapter.Fill(this.group8DataSet2.RepairReportTable);
            // TODO: This line of code loads data into the 'group8DataSet2.DataTable1' table. You can move, or remove it, as needed.
            //this.dataTable1TableAdapter1.Fill(this.group8DataSet2.DataTable1);
            // TODO: This line of code loads data into the 'group8DataSet1.RepairReportTable' table. You can move, or remove it, as needed.
            this.repairReportTableTableAdapter.Fill(this.group8DataSet1.RepairReportTable);
            // TODO: This line of code loads data into the 'group8DataSet.RepairReportTable' table. You can move, or remove it, as needed.
            this.repairReportTableTableAdapter.Fill(this.group8DataSet.RepairReportTable);
            // TODO: This line of code loads data into the 'group8DataSet1.DataTable1' table. You can move, or remove it, as needed.
           // this.dataTable1TableAdapter1.Fill(this.group8DataSet1.DataTable1);

        }

        private void dataTable1DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Reports_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'group8DataSet3.OrdersTable' table. You can move, or remove it, as needed.
            this.ordersTableTableAdapter.Fill(this.group8DataSet3.OrdersTable);
            // TODO: This line of code loads data into the 'group8DataSet3.RepairReportTable' table. You can move, or remove it, as needed.
            this.repairReportTableTableAdapter1.Fill(this.group8DataSet3.RepairReportTable);

        }

        private void txtSearchrepairTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
