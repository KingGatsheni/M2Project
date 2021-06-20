using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppz
{
    public partial class Repairs : Form
    {
        private string ConString = ConfigurationManager.ConnectionStrings["pcCon"].ConnectionString;
        private bool Repairstatus = false;
        private decimal RepairTotal = 0;
        public Repairs()
        {
            InitializeComponent();
        }

        private void EnableGroupBoxItem()
        {

            if (txtFname.Text != "" || txtLName.Text != "" || txtCellNo.Text != "" || txtEmail.Text != "" || txtPhysicalAddress.Text != "")
            {
                groupRepairItem.Enabled = true;
                btnItemList.Enabled = true;

            }
            else if (txtFname.Text == "" || txtLName.Text == "" || txtCellNo.Text == "" || txtEmail.Text == "" || txtPhysicalAddress.Text == "")
            {
                groupRepairItem.Enabled = false;
                btnItemList.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           

        }

        private void txtPhysicalAddress_TextChanged(object sender, EventArgs e)
        {
            EnableGroupBoxItem();
        }

        private void btnItemList_Click(object sender, EventArgs e)
        {
            if (!txtItemName.Text.Equals("") && !txtItemFault.Text.Equals("") && !cbQuantity.Text.Equals("") && !txtPrice.Text.Equals(""))
            {
                var RepairItemPrice = (Int32.Parse(cbQuantity.SelectedItem.ToString()) * decimal.Parse(txtPrice.Text));

                ListViewItem itemList = new ListViewItem(txtItemName.Text);
                itemList.SubItems.Add(txtItemFault.Text);
                itemList.SubItems.Add((cbQuantity.SelectedItem.ToString()));
                itemList.SubItems.Add("R" + txtPrice.Text);
                lvRepairList.Items.Add(itemList);
                ClearText();


                RepairTotal += RepairItemPrice;
                lbMissing.Text = "R" + RepairTotal.ToString();
            }
            else
            {
                MessageBox.Show("Please Fill in the missing fields");
            }

           
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCellNo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void lvRepairList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void ClearText()
        {
            txtItemName.Clear();
            txtItemFault.Clear();
            txtPrice.Clear();
        }

        private void btnBookRepair_Click(object sender, EventArgs e)
        {
            if(txtCellNo.Text.Length != 10)
            {
                MessageBox.Show("Please Enter a Valid South African 10 Digit number");
            }
            else if(txtLName.Text != "" && txtFname.Text != "" && txtCellNo.Text != "" && cbQuantity.Text != "" && txtPhysicalAddress.Text != "" && txtPrice.Text != "")
            {
                SqlConnection sqlconn = new SqlConnection(ConString);


                string RepairIdQuery = "select top 1 RepairId from Repairs order by RepairId desc";
                SqlCommand rpId = new SqlCommand(RepairIdQuery, sqlconn);
                try
                {
                    sqlconn.Open();
                    string InsertQuery = "insert into Customers values(@FirstName,@LastName,@Cell_No,@Email,@address)";
                    SqlCommand insertCom = new SqlCommand(InsertQuery, sqlconn);
                    insertCom.Parameters.AddWithValue("@FirstName", txtFname.Text);
                    insertCom.Parameters.AddWithValue("@LastName", txtLName.Text);
                    insertCom.Parameters.AddWithValue("@Cell_No", txtCellNo.Text);
                    insertCom.Parameters.AddWithValue("@Email", txtEmail.Text);
                    insertCom.Parameters.AddWithValue("@address", txtPhysicalAddress.Text);

                    insertCom.ExecuteNonQuery();

                    string QueryCustId = "select top 1 CustomerId from Customers order by CustomerId desc";
                    SqlCommand CustId = new SqlCommand(QueryCustId, sqlconn);
                    var CustomerId = CustId.ExecuteScalar();

                    string insertRepair = "insert into Repairs values(@CustomerId,@EmployeeId,@RepairStatus,@RepairTotal,@Bookon)";
                    SqlCommand repairinsert = new SqlCommand(insertRepair, sqlconn);
                    repairinsert.Parameters.AddWithValue("@CustomerId", CustomerId);
                    repairinsert.Parameters.AddWithValue("@EmployeeId", 3);
                    repairinsert.Parameters.AddWithValue("@RepairStatus", Repairstatus);
                    repairinsert.Parameters.AddWithValue("@RepairTotal", RepairTotal);
                    repairinsert.Parameters.AddWithValue("Bookon", DateTime.Now);

                    repairinsert.ExecuteNonQuery();


                    var Id = rpId.ExecuteScalar();


                    foreach (ListViewItem list in lvRepairList.Items)
                    {

                        string insertToRepairItem = "insert into RepairLists values(@RepairId,@Quantity,@RepairPrice,@ItemName,@ItemFault)";
                        SqlCommand InsertList = new SqlCommand(insertToRepairItem, sqlconn);
                        InsertList.Parameters.AddWithValue("@RepairId", Id);
                        InsertList.Parameters.AddWithValue("@Quantity", Int32.Parse(list.SubItems[2].Text.ToString()));
                        InsertList.Parameters.AddWithValue("@RepairPrice", decimal.Parse(list.SubItems[3].Text.ToString().Trim('R')));
                        InsertList.Parameters.AddWithValue("@ItemName", list.SubItems[0].Text.ToString());
                        InsertList.Parameters.AddWithValue("@ItemFault", list.SubItems[1].Text.ToString());

                        InsertList.ExecuteNonQuery();

                    }

                    MessageBox.Show("Added Repair Information Successfully");
                    lvRepairList.Items.Clear();
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);

                }
                finally
                {
                    sqlconn.Close();
                }
            }
            else
            {
                MessageBox.Show("Error Can Book For An Empty Item");
            }
           
        }

        private void btnPayRepair_Click(object sender, EventArgs e)
        {


            RepairPayForm rpForm = new RepairPayForm();
            rpForm.ShowDialog();
            
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtCellNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void Repairs_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConString);
            string query = "select * from Customers where Email= '"+ txtSearchByEmail.Text+"'";

            sqlconn.Open();
            SqlCommand QByEmail = new SqlCommand(query, sqlconn);
            SqlDataAdapter adapter = new SqlDataAdapter(QByEmail);
            DataTable dt = new DataTable();
            adapter.Fill(dt);


            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("User Already Exist");
                txtFname.Text = (string)dt.Rows[0][1];
                txtLName.Text = (string)dt.Rows[0][2];
                txtCellNo.Text =(string)dt.Rows[0][3];
                txtEmail.Text = (string)dt.Rows[0][4];
                txtPhysicalAddress.Text = (string)dt.Rows[0][5];

            }
            else
            {
                MessageBox.Show("User Not Found, Create new Account ");
            }

            sqlconn.Close();
        }

        private void txtSearchByEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
 