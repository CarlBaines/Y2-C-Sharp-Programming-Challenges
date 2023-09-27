using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VanType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            //Assign Variables

            string customerName;

            int numItems;

            //Input the name of the customer

            customerName = txtCustomerName.Text;

            //Input the number of items to be moved

            numItems = int.Parse(txtNumItemsMoved.Text);

            //Output the customer name and whether the van has to be large or small.

            if (numItems < 30)
            {
                txtSummary.Text = customerName + ", You need a SMALL VAN";
            }

            if (numItems > 30)
            {
                txtSummary.Text = customerName + ", You need a LARGE VAN";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
