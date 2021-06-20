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
    public partial class rPay : Form
    {

        public decimal AmountPaid;
        public decimal AmountDue;
        public decimal Change = 0;
        public string PaymentMethod = "";
        public string ConString = ConfigurationManager.ConnectionStrings["pcCon"].ConnectionString;
        public rPay()
        {
            InitializeComponent();
        }

       

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnPay_MouseHover(object sender, EventArgs e)
        {
            btnPay.BackColor.R.ToString();
        }

       

        private void btnPay_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConString);
            try
            {
                AmountDue = decimal.Parse(txtAmountDue.Text.Trim('R'));
                AmountPaid = decimal.Parse(txtPaidAmount.Text.Trim('R'));
                if (rbCash.Checked == true)
                {

                    Change = AmountPaid - AmountDue;
                    PaymentMethod = "Cash";

                    sqlconn.Open();
                  
                    string InertToPayQuery = "insert into Payments(RepairId,EmployeeId,PaymentMethod,TotalAmount) values('" + Int32.Parse(lbRepId.Text) + "', '" + 3 + "', '" + PaymentMethod + "', '" + decimal.Parse(txtAmountDue.Text.Trim('R')) + "')";
                    SqlCommand sqlCash = new SqlCommand(InertToPayQuery, sqlconn);
                    sqlCash.ExecuteNonQuery();

                    MessageBox.Show("R"+Change.ToString() + "  And PaymentMethod:  " + PaymentMethod );
                    this.Hide();
                    sqlconn.Close();

                }




                if (rbCard.Checked == true)
                {


                    Change = 0;
                    PaymentMethod = "Debit/Credit Card";

                    sqlconn.Open();
                    string InertToPayQuery = "insert into Payments(RepairId,EmployeeId,PaymentMethod,TotalAmount) values('" + Int32.Parse(lbRepId.Text)+ "', '" + 3 + "', '" + PaymentMethod + "', '" + decimal.Parse(txtAmountDue.Text.Trim('R')) + "')";
                    SqlCommand sqlCash = new SqlCommand(InertToPayQuery, sqlconn);
                    sqlCash.ExecuteNonQuery();
                   
                    MessageBox.Show("R" + Change.ToString() + " And PaymentMethod: " + PaymentMethod);
                    this.Hide();

                }

                MessageBox.Show("Payment Processed for repaired item");



            }
            catch (SqlException s)
            {
                MessageBox.Show(s.Message);
            }
            finally
            {
                sqlconn.Close();
            }


        }

       

        private void rPay_Load(object sender, EventArgs e)
        {
            if (rbCard.Checked == false)
            {
                groupCardPay.Enabled = false;
            }
        }

        private void rPay_Shown(object sender, EventArgs e)
        {
            txtPaidAmount.Focus();
        }

        private void rbCash_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbCash.Checked == true)
            {
                groupCardPay.Enabled = false;
                groupCardPay.BackColor = Color.FromArgb(32, 30, 12);
                txtPaidAmount.Text = "";
                txtPaidAmount.Focus();
            }
        }

        private void rbCard_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbCard.Checked == true)
            {
                groupCardPay.Enabled = true;
                groupCardPay.BackColor = Color.FromArgb(32, 30, 45);
                txtPaidAmount.Text = txtAmountDue.Text;
                txtCardNo.Focus();

            }
        }

        private void txtPaidAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
