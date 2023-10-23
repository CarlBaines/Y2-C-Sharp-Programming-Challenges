using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Machine;

namespace VendingMachine
{
    public partial class Form1 : Form
    {
        vendingMachine machine;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            machine = new vendingMachine(3, 3, 3);

        }

        private void txtVendingMachineContents_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChocolate_Click_1(object sender, EventArgs e)
        {
            bool result = machine.BuyChocolate(1);

            if (result)
            {
                MessageBox.Show("Enjoy your chocolate :)");
            } else
            {
                MessageBox.Show("Sorry, there is no chocolate left :(");
            }
        }

        private void btnCrisps_Click(object sender, EventArgs e)
        {
            bool result = machine.BuyCrisps(1);

            if (result)
            {
                MessageBox.Show("Enjoy your crisps :)");
            }
            else
            {
                MessageBox.Show("Sorry, there are no crisps left :(");
            }
        }

        private void btnWater_Click(object sender, EventArgs e)
        {
            bool result = machine.BuyWater(1);

            if (result)
            {
                MessageBox.Show("Enjoy your water :)");
            } else
            {
                MessageBox.Show("Sorry, there is no water left :(");
            }

        }
    }
}
