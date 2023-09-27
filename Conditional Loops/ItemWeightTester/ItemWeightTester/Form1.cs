using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemWeightTester
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRejectOrAccept_Click(object sender, EventArgs e)
        {
            //Variables

            decimal weight;
            string testAgain;

            //Input the weight of the tin

            weight = decimal.Parse(txtWeight.Text);

            //If the tin is less than 1kg reject it but accept otherwise.

            if (weight > 1) {
                txtOutput.Text = "Reject";
            }
            else
            {
                txtOutput.Text = "Accept";
            }

            //Input if the user wants to test another tin

            testAgain = txtTestAgain.Text;

         }

        private void btnOnChange(object sender, EventArgs e) {  //Checks the testAgain user input to see if it is equal to a 'y' or a 'n'. If it is equal to a 'y' it clears the text boxes so that the code can be used again.

            if (txtTestAgain.Text.ToLower() == "y")
            {
                //txtTestAgain.Text = "";
                txtOutput.Text = "";
                txtWeight.Text = "";
            }
        }

    }
}
