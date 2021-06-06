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
        private decimal SubTotal = 0;
        public   string ConString = ConfigurationManager.ConnectionStrings["pcCon"].ConnectionString;
        
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
                var cartItemPrice = (Int32.Parse(txtQauntity.Text) * decimal.Parse(txtPrice.Text));

                ListViewItem item = new ListViewItem(txtPName.Text);
                item.SubItems.Add(txtQauntity.Text);
                item.SubItems.Add(cartItemPrice.ToString("C"));
                lvCart.Items.Add(item);

                SubTotal = SubTotal + cartItemPrice;
                txtSubTotal.Text = SubTotal.ToString("C");
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());
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
            
            SqlConnection sqlconn = new SqlConnection(ConString);
            string query = "insert into Sales(EmployeeId,Total,Date) values(3,'" + SubTotal + "', '" + DateTime.Now +"')";
            string lastId = "select top 1 SaleId from Sales order by SaleId desc"; 
            
            SqlCommand sqlcomm = new SqlCommand(query, sqlconn);
            SqlCommand id = new SqlCommand(lastId, sqlconn);
            
            try {
                sqlconn.Open();
                sqlcomm.ExecuteNonQuery();
                var result = id.ExecuteScalar();
                string queryItem = "insert into SaleItems(SaleId,InventoryId,Quantity,ItemPrice) values('" + result + "','" + Int32.Parse(txtPId.Text) + "','" + Int32.Parse(txtQauntity.Text) + "','" + decimal.Parse(txtPrice.Text) + "')";
                SqlCommand sqlItem = new SqlCommand(queryItem, sqlconn);
                sqlItem.ExecuteNonQuery();
                MessageBox.Show("Thank You for shopping with us..");
               
            }catch(SqlException err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                sqlconn.Close();
            }
           
        }

        private void txtQauntity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
