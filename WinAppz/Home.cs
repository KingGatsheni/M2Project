using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
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
        public decimal Tax = 0.15m;
        public List<string> listofItems = new List<string>{};
       
        public   string ConString = ConfigurationManager.ConnectionStrings["pcCon"].ConnectionString; // cpnnectionstring for datatbase
        

        public Home()
        {
            InitializeComponent();
           

        }

        private void PrintPageEventHandler(Action<object, PrintPageEventArgs> printSlipDoc_PrintPage)
        {
            throw new NotImplementedException();
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

            //ContainerForm container = new ContainerForm();

            //lbEmployeeId.Text = container._EmployeeId.ToString();

        }

        private void lTime_Click(object sender, EventArgs e)
        {
            //lTime.Text = DateTime.Now.ToString();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            try {
               
                
                int QtyValue = Int32.Parse(dtProductList.CurrentRow.Cells[4].Value.ToString());

                if (Int32.Parse(cbQuantity.Text) > QtyValue || QtyValue == 0)
                {
                    MessageBox.Show("Can not Proceed with Sale Item out of Stock or Selected Quantity Exceed Available Stock!!!");
                }
                else
                {
                    var cartItemPrice = (Int32.Parse(cbQuantity.SelectedItem.ToString()) * decimal.Parse(txtPrice.Text));

                    ListViewItem item = new ListViewItem(txtPId.Text);
                    item.SubItems.Add(txtPName.Text);
                    item.SubItems.Add(cbQuantity.SelectedItem.ToString());
                    item.SubItems.Add("R" + cartItemPrice.ToString());
                    lvCart.Items.Add(item);

                    SubTotal = SubTotal + cartItemPrice;
                    txtSubTotal.Text = "R" + SubTotal.ToString();
                    listofItems.Add(item.ToString());
                }
                

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
           
            PaymentForm Payment = new PaymentForm();

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
                   

                    Payment.txtAmountDue.Text = "R" + SubTotal.ToString();
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
                        decimal itemPrice = decimal.Parse(item.SubItems[3].Text.ToString().Trim('R'));
                        int Qty = Int32.Parse(item.SubItems[2].Text.ToString());
                        decimal newPrice = itemPrice / Qty;
                        sqlItem.Parameters.AddWithValue("@ItemPrice", newPrice);

                        sqlItem.ExecuteNonQuery();
                    }


                    if ((Payment.AmountPaid <= 0))
                    {
                        Console.WriteLine("Amount was null and inventory not updated ");
                    }
                    else if (Payment.AmountDue > Payment.AmountPaid)
                    {
                       

                            Console.WriteLine(" Insufficient Funds");
                        if(Payment.ShowDialog() == DialogResult.OK)
                        {
                            lbChange.Text = Payment._Change;
                            foreach (ListViewItem slip in lvCart.Items)
                            {

                                //var lbcontrnt = string.Format("{0, -10}| {1, -10}|{2,-5}", slip.SubItems[1].Text.ToString() + " \t ", slip.SubItems[2].Text.ToString() + " \t ", slip.SubItems[3].Text.ToString());
                                // lvSlipTxt.Items.Add(lbcontrnt);
                                ListViewItem item1 = new ListViewItem(slip.SubItems[1].Text.ToString());
                                item1.SubItems.Add(slip.SubItems[2].Text.ToString());
                                item1.SubItems.Add(slip.SubItems[3].Text.ToString());
                                lvSlipTxt.Items.Add(item1);



                            }
                        }
                    }
                    else
                    {
                        foreach (ListViewItem update in lvCart.Items)
                        {
                            string sqlUpdateQty = "update Inventories set Quantity = Quantity - '" + Int32.Parse(update.SubItems[2].Text.ToString()) + "' where InventoryId = '" + Int32.Parse(update.SubItems[0].Text.ToString()) + "'";
                            SqlCommand sqlupdate = new SqlCommand(sqlUpdateQty, sqlconn);
                            sqlupdate.ExecuteNonQuery();
                        }
                        inventoriesTableAdapter1.Fill(group8NewDataSet.Inventories);
                        foreach (ListViewItem slip in lvCart.Items)
                        {

                            //var lbcontrnt = string.Format("{0, -10}| {1, -10}|{2,-5}", slip.SubItems[1].Text.ToString() + " \t ", slip.SubItems[2].Text.ToString() + " \t ", slip.SubItems[3].Text.ToString());
                            //lvSlipTxt.Items.Add(lbcontrnt);
                            ListViewItem item1 = new ListViewItem(slip.SubItems[1].Text.ToString());
                            item1.SubItems.Add(slip.SubItems[2].Text.ToString());
                            item1.SubItems.Add(slip.SubItems[3].Text.ToString());
                            lvSlipTxt.Items.Add(item1);


                        }
                        
                    }

                 


                    foreach (ListViewItem items in lvCart.Items)
                    {
                        lvCart.Items.Remove(items);
                    }

                    if(lbChange.Text == "")
                    {
                        lblDiscount.Text = "";
                        lblSubtotal.Text = "";
                        lvSlipTxt.Items.Clear();
                    }
                    else
                    {
                        decimal taxValue = SubTotal * Tax;
                        lblDiscount.Text ="R" + taxValue.ToString(); 
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
            /*

            using (PdfWriter writer = new PdfWriter("slip.pdf"))
            using (PdfDocument pdfDocument = new PdfDocument(writer))
            using(Document doc = new Document(pdfDocument))
            {
                foreach(string li in listofItems )
                {
                    doc.Add(new Paragraph(li.ToString()));
                }
               // string content = "list one slip";
               
                //doc.Add(new Paragraph("Mjay"));
            }
             */

            PrintDialog printD = new PrintDialog();
            printD.ShowDialog();
            printD.Document = printDocument1;

            printD.AllowSelection = true;

            if(printD.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }

            lvSlipTxt.Items.Clear();
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


            } catch(Exception s) { MessageBox.Show(s.Message); }
        }

        private void btnupdateitem_Click(object sender, EventArgs e)// code here to be fixed to update item total and also update subtotal
        {
            try {
               
                var nPrice = decimal.Parse(txtPrice.Text.Trim('R')) / Int32.Parse(lvCart.SelectedItems[0].SubItems[2].Text);
                var newCartItemPrice = Int32.Parse(cbQuantity.Text) * nPrice;
              
                    lvCart.SelectedItems[0].SubItems[2].Text = cbQuantity.Text;
                    lvCart.SelectedItems[0].SubItems[3].Text = "R"+ newCartItemPrice.ToString();

                SubTotal = 0;
                decimal listPrice = 0;
                foreach (ListViewItem lv in lvCart.Items)
                {

                    listPrice = listPrice + decimal.Parse(lv.SubItems[3].Text.Trim('R'));
                }

                SubTotal = listPrice;
                txtSubTotal.Text ="R" + SubTotal.ToString();

            }
            catch(FormatException s)
            {
                MessageBox.Show(s.Message);
            }
            
            

        }

        private void btndeletefromItem_Click(object sender, EventArgs e)//need more code to update subtotal
        {
            SubTotal = SubTotal - decimal.Parse(txtPrice.Text.Trim('R'));
            foreach (ListViewItem item in lvCart.SelectedItems)
            {
                
                lvCart.Items.Remove(item);
                
            }
            txtSubTotal.Text = SubTotal.ToString();
        }

        private void dtProductList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           // int Qty = dtProductList.CurrentRow[].Value
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
           // int col = ;
            int row = 10;
            
            e.Graphics.DrawString("Pcwizrd point of sale", new Font("Ariel", 28, FontStyle.Bold), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString("Product Name", new Font("Ariel", 20, FontStyle.Regular), Brushes.Black, new Point(10, 150));
            e.Graphics.DrawString("Quantity", new Font("Ariel", 20, FontStyle.Regular), Brushes.Black, new Point(200, 150));
            e.Graphics.DrawString("Price", new Font("Ariel", 20, FontStyle.Regular), Brushes.Black, new Point(390, 150));


            foreach (ListViewItem item in lvSlipTxt.Items)
              {

                  e.Graphics.DrawString(item.SubItems[0].Text.ToString(), new Font("Ariel",20, FontStyle.Regular), Brushes.Black, new Point(10, 300));
                    row += 190;
                  e.Graphics.DrawString(item.SubItems[1].Text.ToString(), new Font("Ariel", 20, FontStyle.Regular), Brushes.Black, new Point(row, 300));
                    row += 190;
                  e.Graphics.DrawString(item.SubItems[2].Text.ToString() + "\n", new Font("Ariel", 20, FontStyle.Regular), Brushes.Black, new Point(row, 300));
                 row += 190;


            }
             e.Graphics.DrawString(lblSubtotal.Text, new Font("Ariel", 20, FontStyle.Regular), Brushes.Black, new Point(10, 1000));
            e.Graphics.DrawString(lblDiscount.Text, new Font("Ariel", 20, FontStyle.Regular), Brushes.Black, new Point(200, 1000));
            e.Graphics.DrawString(lbChange.Text, new Font("Ariel", 20, FontStyle.Regular), Brushes.Black, new Point(390, 1000));
              
        }
    }
}
