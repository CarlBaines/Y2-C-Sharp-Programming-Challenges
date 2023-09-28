using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleSumMaker
{
    
    public partial class Form1 : Form
    {

        private int answer = 2;
        private int userAnswer;

        public Form1()
        {
            InitializeComponent();
            txtSum.Text = "What is 1+1?";
        }

        private void btnCorrectOrIncorrect_Click(object sender, EventArgs e)
        {
            //Assign variables

            string sum = "What is 1+1?";

            //Output sum for user to try

            txtSum.Text = sum;

            //Input user answer

            if (txtUserAnswer.Text.Length == 0) return;

            userAnswer = int.Parse(txtUserAnswer.Text);

            //Output message to say if the answer is correct or incorrect.

            if (userAnswer == answer){
                txtCorrectOrIncorrect.Text = "Well Done! Your answer was correct!";
            }
            else
            {
                txtCorrectOrIncorrect.Text = "Try Again, your answer was incorrect :(";
            }

            //Clear text box to answer question again when try again button is clicked.

            if (userAnswer != answer)
            {
                txtUserAnswer.Text = "";
            }
        }

        private void btntryAgain_Click(object sender, EventArgs e)
        {
            
        }

        private void txtCorrectOrIncorrect_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
