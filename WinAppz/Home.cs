using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppz
{
    public partial class Home : Form
    {
        //globl variables
        private decimal SubTotal = 0;
        public   string ConString = ConfigurationManager.ConnectionStrings["pcCon"].ConnectionString; // cpnnectionstring for datatbase
        
        public Home()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'group8DataSet.Inventories' table. You can move, or remove it, as needed.
            this.inventoriesTableAdapter.Fill(this.group8DataSet.Inventories);
             txtSubTotal.Text = SubTotal.ToString();

           
        }

        private void lTime_Click(object sender, EventArgs e)
        {
            //lTime.Text = DateTime.Now.ToString();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            try {
                var cartItemPrice = (Int32.Parse(cbQuantity.SelectedItem.ToString()) * decimal.Parse(txtPrice.Text));

                ListViewItem item = new ListViewItem(txtPName.Text);
                item.SubItems.Add(cbQuantity.SelectedItem.ToString());
                item.SubItems.Add(cartItemPrice.ToString("C"));
                lvCart.Items.Add(item);

                SubTotal = SubTotal + cartItemPrice;
                txtSubTotal.Text = SubTotal.ToString("C");
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
           

           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lTime.Text = DateTime.Now.ToString("dd-MM-yy hh:mm:ss tt");

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           /* SqlConnection sqlconn = new SqlConnection(ConString);
            string query = "select * from [dbo].[Inventories] where Inventories ='" + txtSearch.Text + "'";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(query, sqlconn);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dtProductList.DataSource = dt;
            sqlconn.Close();
           */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConString);// initialise sql connection

            //sql query statements
            string query = "insert into Sales(EmployeeId,Total,Date) values(3,'" + SubTotal + "', '" + DateTime.Now + "')"; // insert sale date into  Sale table 
            string lastId = "select top 1 SaleId from Sales order by SaleId desc";  // check the last inserted item ID

            SqlCommand sqlcomm = new SqlCommand(query, sqlconn);
            SqlCommand id = new SqlCommand(lastId, sqlconn);

            if (SubTotal != 0)
            {
                sqlconn.Open();
                sqlcomm.ExecuteNonQuery();
                PaymentForm Payment = new PaymentForm();
                Payment.txtAmountDue.Text = SubTotal.ToString("C");
                Payment.ShowDialog();
                sqlconn.Close();
            }
            else {
                string error = "Select an item to Sell before checking out";
                MessageBox.Show(error);
            }
           
            
           
            
            try {
                sqlconn.Open(); // on sql connection
                
                var result = id.ExecuteScalar();
                string queryItem = "insert into SaleItems(SaleId,InventoryId,Quantity,ItemPrice) values('" + result + "','" + Int32.Parse(txtPId.Text) + "','" + Int32.Parse(cbQuantity.SelectedItem.ToString()) + "','" + decimal.Parse(txtPrice.Text) + "')";
                SqlCommand sqlItem = new SqlCommand(queryItem, sqlconn);
                sqlItem.ExecuteNonQuery();
                string sqlUpdateQty = "update Inventories set Quantity = Quantity - '"+Int32.Parse(cbQuantity.SelectedItem.ToString()) +"' where InventoryId = '"+ Int32.Parse(txtPId.Text)+"'";
                SqlCommand sqlupdate = new SqlCommand(sqlUpdateQty, sqlconn);
                sqlupdate.ExecuteNonQuery();
                MessageBox.Show("Transcation Successful!!..");
               
            }catch(SqlException err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                sqlconn.Close();
            } 
           
        }

        private void txtQauntity_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
