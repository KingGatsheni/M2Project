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
    public partial class Accounts : Form
    {
        public string ConString = ConfigurationManager.ConnectionStrings["pcCon"].ConnectionString; 
        public Accounts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConString);
            if (txtPassword.Text.Equals(txtConfirmPass.Text))
            {
                sqlconn.Open();
                var id = txtUserName.Text;

                string EmployeeId = "select top 1 EmployeeId from Employees order by EmployeeId desc";

                try {
                 

                    SqlCommand EmpId = new SqlCommand(EmployeeId, sqlconn);

                    var lastEmpId = EmpId.ExecuteScalar();

                    string insertAccount = "insert into Accounts values(@EmployeeId,@UserName,@Password)";

                    SqlCommand Account = new SqlCommand(insertAccount, sqlconn);
                    Account.Parameters.AddWithValue("@EmployeeId", lastEmpId);
                    Account.Parameters.AddWithValue("@UserName", long.Parse(txtUserName.Text.Trim(' ')));
                    Account.Parameters.AddWithValue("@Password", txtPassword.Text);

                    Account.ExecuteNonQuery();
                    sqlconn.Close();
                    MessageBox.Show("Account Created Successfully");
                    this.Hide();
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }

            }
            else
            {
                lbError.Text = "Passwords do not match";
            }
        }
    }
}
