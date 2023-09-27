using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimesTableDisplayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtFourTimesTable_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFourTimesTable_Click(object sender, EventArgs e)
        {

            //Variables

            int result; //used as a placeholder for the results of the multiplication.

            for (int i = 0; i < 13; i++) //Loops until i is equal to 12. 'I' represents the current number that is being multiplied.
            {
                result = i * 4;
                txtFourTimesTable.Text += $" {i} x 4 = {result}" + System.Environment.NewLine; 
                //The $ sign creates a string that inserts the I variable and the expression required to loop through the four times table.
            }
        }
    }
}
