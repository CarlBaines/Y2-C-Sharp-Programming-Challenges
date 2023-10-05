using System.Numerics;

namespace TaxiChargeFunction
{
    public partial class Form1 : Form
    {
        double totalFare;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //Assign variables

            double baseFare = 4.00;

            double distanceTravelled;

            //Output base fare to the user

            txtBaseFare.Text = baseFare.ToString();

            //Take inputs

            distanceTravelled = double.Parse(txtDistanceTravelled.Text);





            //Call the CalculateTotalFare function to work out the total fare.

            totalFare = CalculateTotalFare(baseFare, distanceTravelled);




            //Call the DisplayResults function to display the total fare

            DisplayResults(totalFare);

            //Function to return the total fare

            double CalculateTotalFare(double baseFare, double distanceTravelled)
            {
                double myTotalFare;

                myTotalFare = (distanceTravelled / 1000 / 140) * 0.25 + baseFare;
                
                return myTotalFare;
            }

            void DisplayResults(double myTotalFare) {

                txtOutput.Text = myTotalFare.ToString();
            }

        }
    }
}