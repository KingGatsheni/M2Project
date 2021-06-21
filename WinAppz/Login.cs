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
    public partial class LoginForm : Form
    {
        public string ConString = ConfigurationManager.ConnectionStrings["pcCon"].ConnectionString;




        public LoginForm()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
            //label1.Text = "Please Login To Use the System";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConString);
            string user = "select * from Accounts where UserName = '"+ txtUserName.Text.Trim(' ')+"' And Password = '"+txtPassword.Text.Trim(' ')+"'";
            sqlconn.Open();
            SqlCommand loginUser = new SqlCommand(user, sqlconn);
            SqlDataAdapter userAdpter = new SqlDataAdapter(loginUser);
            DataTable dt = new DataTable();
            userAdpter.Fill(dt);
            if (dt.Rows.Count > 0) {
                ContainerForm Container = new ContainerForm((string)(dt.Rows[0][2]));
               int id1 = (int)dt.Rows[0][1];
                Container.EmployeeId = id1;
                Container.Show();
                this.Hide();

            }
            else if(dt.Rows.Count > 0)
            {
                ContainerForm Container = new ContainerForm((string)(dt.Rows[0][2]));
               
                this.Hide();

            }
            else
            {
                lbError.Text =("Please Provide correct login Details");
                lbError.ForeColor = Color.Red;
            }
            sqlconn.Close();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            

        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            //txtPassword.PasswordChar = '*';
        }

        private void lbFPass_MouseLeave(object sender, EventArgs e)
        {
            lbFPass.ForeColor = Color.LimeGreen;
        }

        private void lbFPass_MouseHover(object sender, EventArgs e)
        {
            lbFPass.ForeColor = Color.White;

        }

        private void lbFPass_Click(object sender, EventArgs e)
        {
            txtUserName.Focus();

            if(txtUserName.Text == "")
            {
                MessageBox.Show("Retrieve your password using your username");
            }
            else
            {
                SqlConnection sqlconn = new SqlConnection(ConString);
                string requestPassword = "select Password from Accounts where UserName = '" + txtUserName.Text.Trim(' ') + "'";
                sqlconn.Open();
                SqlCommand command = new SqlCommand(requestPassword, sqlconn);

                var password = command.ExecuteScalar();
                if(password == null)
                {
                    MessageBox.Show("Employee With StuffId Of: " + txtUserName.Text + " Does Not Exist");
                }
                else
                {
                    MessageBox.Show("Your login Password is: " + password);
                }

               
                sqlconn.Close();

            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
