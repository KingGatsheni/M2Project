using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppz
{
    public partial class LoginForm : Form
    {
       
        
       
      

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
            //label1.Text = "Please Login To Use the System";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (rdAdmin.Checked == true && txtUserName.Text == "admin" && txtPassword.Text == "pass") {
                ContainerForm Container = new ContainerForm(txtUserName.Text);
                Container.Show();
                this.Hide();

            }
            else if(rdManager.Checked == true && txtUserName.Text == "manager" && txtPassword.Text == "pass")
            {
                ContainerForm Container = new ContainerForm(txtUserName.Text);
                Container.Show();
                this.Hide();

            }
            else
            {
                lbError.Text =("Please Provide correct login Details");
                lbError.ForeColor = Color.Red;
            }


        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            

        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

       
    }
}
