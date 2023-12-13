using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celsius_to_Fahrenheit_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float celcius = 0;

            float fahrenheit = 0;

            
            try
            {
                fahrenheit = float.Parse(textBox1.Text);
                if (fahrenheit < -100 || fahrenheit > 100) {
                    MessageBox.Show("Temperature out of range");
                }

                else
                {
                    celcius = (fahrenheit - 32) * 5/9;
                    MessageBox.Show(fahrenheit + "°F is equal to " + celcius + "°C");
                }
               
            }

            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
