using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CementOrderSummary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Define Variables

            string customerName;

            double numCementBags;

            double totalCost;

            //Input name

            customerName = txtName.Text;

            //Input number of cement bags

            numCementBags = float.Parse(txtNumCementBags.Text);


            //Calculate the total cost

            totalCost = numCementBags * 0.93;

            //Output cost

            txtCost.Text += " " + totalCost.ToString();

            //Output customer name

            textOrderName.Text += " " + customerName;

            //Output number of cement bags ordered

            txtCementBags.Text += " " + numCementBags.ToString();
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textOrderName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
