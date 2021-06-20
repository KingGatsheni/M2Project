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
    public partial class Employee : Form
    {
        public string ConString = ConfigurationManager.ConnectionStrings["pcCon"].ConnectionString; // cpnnectionstring for datatbase
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'group8DataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.group8DataSet.Employees);
            // TODO: This line of code loads data into the 'group8NewDataSet.Employees' table. You can move, or remove it, as needed.
            // this.employeesTableAdapter.Fill(this.group8NewDataSet.Employees);

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if(txtIDNo.Text.Length != 13 || txtCellNo.Text.Length !=10)
            {
                MessageBox.Show("Please Provide A correct South African Id Number.");
            }
            else
            {
                SqlConnection sqlConnection = new SqlConnection(ConString);
                sqlConnection.Open();
                string queryId = "select top 1 StuffId from Employees order by StuffId desc";
                SqlCommand QId = new SqlCommand(queryId, sqlConnection);

                var stuffId = QId.ExecuteScalar();
                stuffId = (long)stuffId + 1;

                sqlConnection.Close();

                employeesTableAdapter.InsertQuery((long)stuffId, txtFirstName.Text, txtIDNo.Text, txtCellNo.Text, txtEmail.Text, cbEmployeeRole.SelectedItem.ToString(), txtAddress.Text, txtLastName.Text);
                employeesTableAdapter.Fill(this.group8DataSet.Employees);

                Accounts accountForm = new Accounts();
                accountForm.txtUserName.Text = stuffId.ToString();
                accountForm.ShowDialog();

                MessageBox.Show("Successfully");
            }
          

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtIDNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if(!Char.IsDigit(ch) && ch != 8 && ch != 46)
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
    }
}
