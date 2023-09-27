using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyDivider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblNumOfPeople_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Assign variables

            int sumMoney;

            int numOfPeople;

            int total;

            //Input sum of money

            sumMoney = int.Parse(txtSumMoney.Text);

            //Input number of people

            numOfPeople = int.Parse(txtNumOfPeople.Text);

            //Calculate total

            total = sumMoney / numOfPeople;

            //Output how much money each person gets

            txtTotal.Text = total.ToString();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
