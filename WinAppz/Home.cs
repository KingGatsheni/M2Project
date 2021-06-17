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
       public ListViewItem lvItem;
        
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
            // TODO: This line of code loads data into the 'group8NewDataSet.Inventories' table. You can move, or remove it, as needed.
            try
            {
                this.inventoriesTableAdapter1.Fill(this.group8NewDataSet.Inventories);
            }catch(SqlException error)
            {
                MessageBox.Show(error.Message);
            }
           
            // TODO: This line of code loads data into the 'group8DataSet.Inventories' table. You can move, or remove it, as needed.
        
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

                ListViewItem item = new ListViewItem(txtPId.Text);
                item.SubItems.Add(txtPName.Text);
                item.SubItems.Add(cbQuantity.SelectedItem.ToString());
                item.SubItems.Add("R" + cartItemPrice.ToString());
                lvCart.Items.Add(item);

                SubTotal = SubTotal + cartItemPrice;
                txtSubTotal.Text = "R" + SubTotal.ToString();

                lvItem = item;
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
            inventoriesTableAdapter1.FillBySearch(group8NewDataSet.Inventories, txtSearch.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConString);// initialise sql connection
            if (SubTotal != 0) {
               

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

                    Payment.txtAmountDue.Text = "R" + SubTotal.ToString();
                    // Payment.ShowDialog();
                    if (Payment.ShowDialog() == DialogResult.OK)
                    {
                        lbChange.Text = Payment._Change;
                    }
                    sqlconn.Close();
                }
                else
                {
                    string error = "Select an item to Sell before checking out";
                    MessageBox.Show(error);
                }





                try
                {
                    sqlconn.Open(); // on sql connection

                    var result = id.ExecuteScalar();
                    //string queryItem = "insert into SaleItems(SaleId,InventoryId,Quantity,ItemPrice) values('" + result + "','" + Int32.Parse(txtPId.Text) + "','" + Int32.Parse(cbQuantity.SelectedItem.ToString()) + "','" + decimal.Parse(txtPrice.Text) + "')";

                    foreach (ListViewItem item in lvCart.Items)
                    {
                        string queryItem = "insert into SaleItems values(@SaleId,@InventoryId,@Quantity,@ItemPrice)";
                        SqlCommand sqlItem = new SqlCommand(queryItem, sqlconn);
                        sqlItem.Parameters.AddWithValue("@SaleId", result);
                        sqlItem.Parameters.AddWithValue("@InventoryId", Int32.Parse(item.SubItems[0].Text.ToString()));
                        sqlItem.Parameters.AddWithValue("@Quantity", Int32.Parse(item.SubItems[2].Text.ToString()));
                        sqlItem.Parameters.AddWithValue("@ItemPrice", Decimal.Parse(item.SubItems[3].Text.ToString().Trim('R')));

                        sqlItem.ExecuteNonQuery();
                    }

                    foreach (ListViewItem update in lvCart.Items)
                    {
                        string sqlUpdateQty = "update Inventories set Quantity = Quantity - '" + Int32.Parse(update.SubItems[2].Text.ToString()) + "' where InventoryId = '" + Int32.Parse(update.SubItems[0].Text.ToString()) + "'";
                        SqlCommand sqlupdate = new SqlCommand(sqlUpdateQty, sqlconn);
                        sqlupdate.ExecuteNonQuery();
                    }
                    inventoriesTableAdapter1.Fill(group8NewDataSet.Inventories);
                    if(LblChange.Text != "") {
                        MessageBox.Show("Transcation Successful!!..");
                    }     
                    
                   
                    foreach (ListViewItem slip in lvCart.Items)
                    {
                        var lbcontrnt = string.Format("{0, -10}| {1, -10}|{2,-5}", slip.SubItems[1].Text.ToString() + " \t ", slip.SubItems[2].Text.ToString() + " \t ", slip.SubItems[3].Text.ToString());
                        listSlip.Items.Add(lbcontrnt);

                    }
                    foreach(ListViewItem items in lvCart.Items)
                    {
                        lvCart.Items.Remove(items);
                    }

                    if(lbChange.Text == "")
                    {
                        lblDiscount.Text = "";
                        lblSubtotal.Text = "";
                        listSlip.Items.Clear();
                    }
                    else
                    {
                        lblDiscount.Text = "R0.00";
                        lblSubtotal.Text = txtSubTotal.Text;
                    }
                }
                catch (SqlException err)
                {
                    MessageBox.Show(err.Message);
                }
                finally
                {
                    sqlconn.Close();
                }
            }

        }

      

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listSlip.Items.Clear();
            lbChange.Text = "";
            lblDiscount.Text = "";
            lblSubtotal.Text = "";
            SubTotal = 0;
            txtSubTotal.Text = "R0.00";
        }

        private void lvCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                cbQuantity.Text = lvCart.SelectedItems[0].SubItems[2].Text;
                txtPrice.Text = lvCart.SelectedItems[0].SubItems[3].Text;


            } catch { }
        }

        private void btnupdateitem_Click(object sender, EventArgs e)// code here to be fixed to update item total and also update subtotal
        {
            try {

                //var nPrice = Int32.Parse(txtPrice.Text.ToString()) / decimal.Parse(cbQuantity.Text.ToString());
                //decimal newprice = (decimal.Parse(lvCart.SelectedItems[0].SubItems[3].Text.ToString().Trim('R')) / Int32.Parse(lvCart.SelectedItems[0].SubItems[2].Text));
                // var newCartItemPrice = Int32.Parse(lvCart.SelectedItems[0].SubItems[2].Text) * newprice;
                //SubTotal = SubTotal - decimal.Parse(lvCart.SelectedItems[0].SubItems[3].Text);
                //lvCart.SelectedItems[0].SubItems[2].Text = cbQuantity.Text;
                //lvCart.SelectedItems[0].SubItems[3].Text = newCartItemPrice.ToString();
                lvCart.SelectedItems[0].SubItems[2].Text = cbQuantity.Text;

                //SubTotal += newCartItemPrice;
            }catch(FormatException s)
            {
                MessageBox.Show(s.Message);
            }
            
            

        }

        private void btndeletefromItem_Click(object sender, EventArgs e)//need more code to update subtotal
        {
            foreach (ListViewItem item in lvCart.SelectedItems)
            {
                 lvCart.Items.Remove(item);

            }
        }
    }
}
