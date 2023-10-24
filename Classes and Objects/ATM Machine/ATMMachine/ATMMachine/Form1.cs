using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMMachine
{
    public partial class Form1 : Form
    {   
        //Declare account object
        ATMAccount ATM;


        public Form1()
        {
            ATM = new ATMAccount();
            InitializeComponent();
        }

        private void txtEnterPin_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            //Make a withdrawal
            //Take user pin input

            int pin = int.Parse(txtEnterPin.Text);
            bool result = ATM.pinCheck(pin);

            if (result == true)
            {
                decimal withdrawalAmount = decimal.Parse(txtWithdrawAmount.Text);
                ATM.MakeWithdrawal(withdrawalAmount);
                MessageBox.Show($"You have withdrawed £{withdrawalAmount}.");
                txtWithdrawAmount.Text = "";
            }
            else
            {
                txtEnterPin.Text = "";
                txtWithdrawAmount.Text = "";
                MessageBox.Show("PIN number was not accepted");
            }


        }

        private void btnDepositAmount_Click(object sender, EventArgs e)
        {
            //Make a deposit
            //Take user pin input

            int pin = int.Parse(txtEnterPin.Text);
            bool result = ATM.pinCheck(pin);

            //Checks to see if the user input is equal to a valid pin number stored in the system.
            if (result == true)
            {
                decimal depositAmount = decimal.Parse(txtDepositAmount.Text);
                ATM.MakeDeposit(depositAmount);
                MessageBox.Show($"£{depositAmount} has been deposited");
                txtDepositAmount.Text = "";
            }
            else
            {
                txtEnterPin.Text = "";
                txtDepositAmount.Text = "";
                MessageBox.Show("PIN number was not accepted");
            }

        }

        private void btnDisplayBalance_Click(object sender, EventArgs e)
        {
            //Display balance

            MessageBox.Show("Balance is " + ATM.GetBalance().ToString());
        }

        private void btnEnterPin_Click(object sender, EventArgs e)
        {   
            //Take user pin input

            int pin = int.Parse(txtEnterPin.Text);
            bool result = ATM.pinCheck(pin);

            //Checks to see if the pin number is the 
            if (result == true)
            {
                MessageBox.Show("PIN number accepted");
            }
            else
            {
                MessageBox.Show("PIN number was not accepted");
            }
           
        }

        private void txtWithdrawAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
