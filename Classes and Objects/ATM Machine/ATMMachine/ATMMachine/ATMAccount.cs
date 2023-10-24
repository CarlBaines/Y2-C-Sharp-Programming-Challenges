using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMMachine
{
    public class ATMAccount
    {
        //Declare attributes

        private decimal balance;
        private int pin;
        protected bool checkPin;
        private List<int> ValidPins = new List<int>()
        {
            1234,
            5678,
            9101,
        };

        public ATMAccount()
        {
            balance = 100;
            checkPin = false;
        }

        public void MakeDeposit(decimal depositAmount)
        {
            balance = balance + depositAmount;
        }

        public bool pinCheck(int pin)
        {
            if (ValidPins.Contains(pin))
            {
                checkPin = true;
            }

            else
            {
                checkPin = false;
            }

            return checkPin;
        }
        


        public bool MakeWithdrawal(decimal withdrawalAmount) //? allows the function to be nullable so that a null value can be checked for. 
        {
            if (balance >= withdrawalAmount && checkPin == true)
            {
                balance = balance - withdrawalAmount;
                return true;
            } 
            else
            {
                return false;
            }
               
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }
}
