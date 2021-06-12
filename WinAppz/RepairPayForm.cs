using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            try
            {
                this.invoiceTableAdapter.Fill(this.group8NewDataSet.Invoice);
            }catch(SqlException error)
            {
                MessageBox.Show(error.Message);
            }



        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            if(txtSearchbyNo.Text != "")
            {
                var id = this.invoiceTableAdapter.ScalarQuery(txtSearchbyNo.Text);
                rPay pForm = new rPay();
                pForm.txtAmountDue.Text = "R" + txtTotalOwed.Text.ToString();
                pForm.lbRepId.Text = id.ToString();
                pForm.ShowDialog();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter Customer Cell phone number");
            }
            
        }

        private void txtSearchbyNo_TextChanged(object sender, EventArgs e)
        {
            //this.invoiceTableAdapter.FillBySearch(group8NewDataSet.Invoice, txtSearchbyNo.Text);
        }

        private void dtProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
