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
    public partial class Repairs : Form
    {
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
          
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            EnableGroupBoxItem();
        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {
            EnableGroupBoxItem();
        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {
            EnableGroupBoxItem();
        }

        private void txtCellNo_TextChanged(object sender, EventArgs e)
        {
            EnableGroupBoxItem();
        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {
            if (txtFname.Text == "" || txtLName.Text == "" || txtCellNo.Text == "" || txtEmail.Text == "" || txtPhysicalAddress.Text == "")
            {
                lbMissing.Text = "Please fill All the Customer Info";
                lbMissing.ForeColor = Color.Red;

            }
        }

        private void lvRepairList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
