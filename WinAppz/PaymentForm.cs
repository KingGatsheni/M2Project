using MetroSet_UI.Forms;
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
    public partial class PaymentForm : Form
    {
        public decimal AmountPaid;
        public decimal AmountDue;
        public decimal Change = 0;
        public string PaymentMethod = "";
        public string ConString = ConfigurationManager.ConnectionStrings["pcCon"].ConnectionString;
        public string _Change;
        public PaymentForm()
        {
            InitializeComponent();
        }

        public string myChange
        {
            get { return _Change; }
            set { _Change = value; }
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
           
            if (rbCard.Checked == false)
            {
                groupCardPay.Visible = false;
            }
        }

        private void rbCard_CheckedChanged(object sender, EventArgs e)
        {
            if(rbCard.Checked == true)
            {
                groupCardPay.Visible = true;
                groupCardPay.BackColor = Color.FromArgb(32, 30, 45);
                txtPaidAmount.Text = txtAmountDue.Text;
                txtCardNo.Focus();

            }
        } 

        private void rbCash_CheckedChanged(object sender, EventArgs e)
        {
            if(rbCash.Checked == true)
            {
                groupCardPay.Visible = false;
                groupCardPay.BackColor = Color.FromArgb(32, 30, 12);
                txtPaidAmount.Text = "";
                txtPaidAmount.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
            SqlConnection sqlconn = new SqlConnection(ConString);
            string deleteSaleId = "select top 1 SaleId from Sales order by SaleId desc";
            SqlCommand sqlDel = new SqlCommand(deleteSaleId, sqlconn);

            sqlconn.Open();
            var del = sqlDel.ExecuteScalar();


            string delQuery = "delete from Sales where SaleId = '" + del + "'";
            SqlCommand DelQ = new SqlCommand(delQuery, sqlconn);
            DelQ.ExecuteNonQuery();
            sqlconn.Close();

            MessageBox.Show("Transaction Cancelled");
            this.Hide();
        }

        private void btnPay_MouseHover(object sender, EventArgs e)
        {
            //btnPay.BackColor = Color.DarkRed;
        }

        private void txtExpiry_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
          
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConString);
         
            string SaleIdQuery = "select top 1 SaleId from Sales order by SaleId desc";  // check the last inserted item ID

            SqlCommand sqlCheckId = new SqlCommand(SaleIdQuery, sqlconn);

            try
            {
                 AmountDue = decimal.Parse(txtAmountDue.Text.Trim('R'));
              
                 AmountPaid = decimal.Parse(txtPaidAmount.Text.Trim('R'));
                

                if (rbCash.Checked == true )
                {
                    
                    
                        if (AmountDue > AmountPaid)
                        {
                            MessageBox.Show("Insufficient funds!,please pay full amount");
                            txtPaidAmount.Text = "";

                           
                        }
                        else
                        {
                            Change = AmountPaid - AmountDue;
                            PaymentMethod = "Cash";

                            sqlconn.Open();
                            var _SaleId = sqlCheckId.ExecuteScalar().ToString();



                            string InertToPayQuery = "insert into Payments(SaleId,EmployeeId,PaymentMethod,TotalAmount) values('" + _SaleId + "', '" + 3 + "', '" + PaymentMethod + "', '" + decimal.Parse(txtAmountDue.Text.Trim('R')) + "')";
                            SqlCommand sqlCash = new SqlCommand(InertToPayQuery, sqlconn);
                            sqlCash.ExecuteNonQuery();
                            _Change = "R" + Change;
                            sqlconn.Close();
                            MessageBox.Show("Transcation Successful");
                            this.Hide();
                        
                    }
               

                }

                


                if (rbCard.Checked == true)
                    {
                    string CardNumber = txtCardNo.Text;
                    string CardType = CardNumber.Substring(0,1);

                    if (txtCardNo.Text.Length != 14 && (int.Parse(CardType) != 4 || Int32.Parse(CardType) != 5) && txtCVC.Text.Length != 0 && txtExpiry.Text.Length !=0)
                    {
                        MessageBox.Show("Card Number Does Not Exist or The card type is not accepted");
                    }
                    else
                    {
                        Change = 0;
                        PaymentMethod = "Debit/Credit Card";

                        sqlconn.Open();
                        var _SaleId = sqlCheckId.ExecuteScalar().ToString();

                        string InertToPayQuery = "insert into Payments(SaleId,EmployeeId,PaymentMethod,TotalAmount) values('" + _SaleId + "', '" + 3 + "', '" + PaymentMethod + "', '" + decimal.Parse(txtAmountDue.Text.Trim('R')) + "')";
                        SqlCommand sqlCash = new SqlCommand(InertToPayQuery, sqlconn);
                        sqlCash.ExecuteNonQuery();
                        _Change = "R0.00";
                    
                        this.Hide();
                    }
                    
                }
               
              

            }
            catch (Exception s) {
                MessageBox.Show(s.Message);
            }
            finally
            {
                sqlconn.Close();
            }
          

        }

        private void PaymentForm_Shown(object sender, EventArgs e)
        {
            txtPaidAmount.Focus();
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPaidAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtCardNo_TextChanged(object sender, EventArgs e)
        {
            string CardNumber = txtCardNo.Text;
            string CardType = CardNumber.Substring(0, 1);
            if(Int32.Parse(CardType) == 4)
            {
                txtCardType.Text = "Visa";
                txtCardType.ForeColor = Color.Blue;
            }else if (Int32.Parse(CardType) == 5)
            {
                txtCardType.Text = "Master Card";
                txtCardType.ForeColor = Color.Blue;
            }
        }
    }
}

