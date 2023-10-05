namespace PythagorasTheorem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcHypotenuse_click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Assign Variables

            double firstSide;

            double secondSide;

            double hypotenuse;

            //Input first shortest side and second shortest side

            firstSide = double.Parse(txt1stShortSide.Text);

            secondSide = double.Parse(txt2ndShortSide.Text);

            //Call the CalculateHypotenuse function to work out the hypotenuse
            //Pass the firstSide and secondSide as parameters, return values as floats. They are displayed later

            hypotenuse = CalculateHypotenuse(firstSide, secondSide);

            //Call the display result function to display the calculated hypotenuse.

            DisplayResults(hypotenuse);




            //Function to return hypotenuse given the lengths of the first shortest and second shortest sides.

            double CalculateHypotenuse(double firstSide, double secondSide)
            {
                double myHypotenuse;

                //Math.sqrt square roots the entire calculation below to perform Pythagora's Theorem.
                myHypotenuse = Math.Sqrt((firstSide * firstSide) + (secondSide * secondSide));

                return myHypotenuse;
            }

            void DisplayResults(double myHypotenuse)
            {
                txtOutput.Text = myHypotenuse.ToString();
            }


        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}