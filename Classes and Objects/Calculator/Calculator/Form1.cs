using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public class Calc
    {
        //Attributes

        private int firstNum;

        private int secondNum;

        private int result;

        public int Add(int n1, int n2)
        {
            return n1 + n2;
        }

        public int Subtract(int n1, int n2)
        {
            return n1 - n2;
        }

        public int Multiply(int n1, int n2)
        {
            return n1 * n2;
        }

        public int Divide(int n1, int n2)
        {
            return n1/ n2;
        }
    }

    public partial class Form1 : Form
    {
        Calc calculator;

        public Form1()
        {
            InitializeComponent();
            calculator = new Calc();
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtFirstNum.Text);
            //The second number input text box is stuck being called 'TextBox1' because I can't get back on the design view for some reason.
            int n2 = int.Parse(textBox1.Text);

            int result = calculator.Add(n1, n2);
            MessageBox.Show($"The result of the addition is {result}");

            txtOutput.Text = result.ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtFirstNum.Text);

            int n2 = int.Parse (textBox1.Text);

            int result = calculator.Subtract(n1, n2);
            MessageBox.Show($"The result of the subtraction is {result}");

            txtOutput.Text = result.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtFirstNum.Text);

            int n2 = int.Parse(textBox1.Text);

            int result = calculator.Multiply(n1, n2);
            MessageBox.Show($"The result of the multiplication is {result}");

            txtOutput.Text = result.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtFirstNum.Text);

            int n2 = int.Parse(textBox1.Text);

            int result = calculator.Divide(n1, n2);
            MessageBox.Show($"The result of the division is {result}");

            txtOutput.Text = result.ToString();
        }
    }
}
