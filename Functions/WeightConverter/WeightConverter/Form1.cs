using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeightConverter
{
    public partial class Form1 : Form
    {

        double weightInOunces;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConvertWeight_Click(object sender, EventArgs e)
        {
            //Assign variables


            double weightInPounds;

            double weightInGrams;

            double weightInKilograms;

            //Take original weight in ounces from user

            weightInOunces = double.Parse(txtInputWeight.Text);

            //Call the conversion functions to work out the weight in different conversions
            //Pass the weightInOunces as a parameter, return values as floats for later display.

            weightInPounds = CalculateWeightInPounds(weightInOunces);


            weightInGrams = CalculateWeightInGrams(weightInOunces);


            weightInKilograms = CalculateWeightInKilograms(weightInOunces);


            //Call the display result function to display converted weights

            DisplayResults(weightInPounds, weightInGrams, weightInKilograms);



            double CalculateWeightInPounds(double weightInOunces)

            {

                double myWeightInPounds;

                myWeightInPounds = weightInOunces / 16;

                return myWeightInPounds;
            }


            double CalculateWeightInGrams(double weightInOunces)
            {
                double myWeightInGrams;

                myWeightInGrams = weightInOunces * 28.3495;

                return myWeightInGrams;
            }

            double CalculateWeightInKilograms(double weightInOunces)
            {
                double myWeightInKilograms;

                myWeightInKilograms = weightInOunces / 35.3274;

                return myWeightInKilograms;
            }


            void DisplayResults(double myWeightInPounds, double myWeightInGrams, double myWeightInKilograms)
            {
                txtWeightToPounds.Text = myWeightInPounds.ToString();

                txtWeightToGrams.Text = myWeightInGrams.ToString();

                txtWeightToKg.Text = myWeightInKilograms.ToString();
            }



        }
    }
}
