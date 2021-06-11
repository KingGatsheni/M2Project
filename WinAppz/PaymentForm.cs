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
                groupCardPay.Enabled = false;
            }
        }

        private void rbCard_CheckedChanged(object sender, EventArgs e)
        {
            if(rbCard.Checked == true)
            {
                groupCardPay.Enabled = true;
                groupCardPay.BackColor = Color.FromArgb(32, 30, 45);
                txtPaidAmount.Text = txtAmountDue.Text;
                txtCardNo.Focus();

            }
        } 

        private void rbCash_CheckedChanged(object sender, EventArgs e)
        {
            if(rbCash.Checked == true)
            {
                groupCardPay.Enabled = false;
                groupCardPay.BackColor = Color.FromArgb(32, 30, 12);
                txtPaidAmount.Text = "";
                txtPaidAmount.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnPay_MouseHover(object sender, EventArgs e)
        {
            btnPay.BackColor.R.ToString();
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
                if (rbCash.Checked == true)
                {
                    Change = AmountPaid - AmountDue;
                    PaymentMethod = "Cash";

                    sqlconn.Open();
                    var _SaleId = sqlCheckId.ExecuteScalar().ToString();

                   

                    string InertToPayQuery = "insert into Payments(SaleId,EmployeeId,PaymentMethod,TotalAmount) values('"+ _SaleId +"', '"+ 3 +"', '"+ PaymentMethod +"', '"+ decimal.Parse(txtAmountDue.Text.Trim('R'))+"')";
                    SqlCommand sqlCash = new SqlCommand(InertToPayQuery, sqlconn);
                    sqlCash.ExecuteNonQuery();
                    _Change ="R" + Change;
                    //MessageBox.Show("R"+Change.ToString() + "  And PaymentMethod:  " + PaymentMethod );
                    this.Hide();
                    sqlconn.Close();

                }
                else if(rbCard.Checked == true)
                {
                   

                    if ((txtCardNo.Text == "" && txtCardNo.Text.Length != 16) && (txtExpiry.Text == "") && (txtCVC.Text == "" && txtCVC.Text.Length != 3))
                    {
                      lbInvalidCardInfo.Text =  "Please Enter Correct Card Details";
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
                        MessageBox.Show("R" + Change.ToString() + " And PaymentMethod: " + PaymentMethod);
                        this.Hide();
                    }
                }
            }
            catch (SqlException s) {
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
    }
}
