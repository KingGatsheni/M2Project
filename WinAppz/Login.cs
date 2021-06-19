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
            txtPassword.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
            //label1.Text = "Please Login To Use the System";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim(' ') == "admin" && txtPassword.Text.Trim(' ') == "pass") {
                ContainerForm Container = new ContainerForm(txtUserName.Text);
                Container.Show();
                this.Hide();

            }
            else if(txtUserName.Text.Trim(' ') == "manager" && txtPassword.Text.Trim(' ') == "pass")
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
    }
}
