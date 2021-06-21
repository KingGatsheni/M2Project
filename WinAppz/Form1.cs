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
    public partial class ContainerForm :Form
    {
        public int EmployeeId;
        public int _EmployeeId;
       
        public ContainerForm()
        {
            InitializeComponent();
        }

        string UserName;
        public ContainerForm(string s)
        {
            InitializeComponent();
            UserName = s;
        }
        public int myId
        {
            get { return _EmployeeId; }
            set { _EmployeeId = value; }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {

        }

        private void ContainerForm_Load(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            if (UserName =="202101")
            {
                btnManager.Enabled = true;
            }
            else
            {
                btnManager.Enabled = false;
            }
            // this.panelBody.Controls.Add(HomePage);
            // this.HomePage.Show();
            switchPanel(new Home());
            _EmployeeId = EmployeeId;
            
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            panelManager.Visible = true;
            this.btnManager.BackColor = Color.DarkOrange;
         
           
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm LForm = new LoginForm();
            LForm.Show();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnManager_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnManager_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void btnRepairs_Click(object sender, EventArgs e)
        {

            switchPanel(new Repairs());
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            switchPanel(new InventoryForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switchPanel(new Employee());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //switchPanel(new Reports());
        }

       


        public void switchPanel(object form)
        {
            panelBody.Controls.Clear();
            Form frm = form as Form;
            frm.TopLevel = false;
            panelBody.Controls.Add(frm);
            panelBody.Tag = frm;
            frm.Show();

        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            switchPanel(new Home());
        }

        private void panelBody_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
