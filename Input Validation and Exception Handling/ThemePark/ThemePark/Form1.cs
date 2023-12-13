using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThemePark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int numOfTickets = 0;

            double totalCost = 0;

            double ticketPrice = 10.99;

            try
            {

                numOfTickets = int.Parse(textBox1.Text);

                totalCost = (numOfTickets *  ticketPrice);
                if (totalCost > 40000)
                {
                    MessageBox.Show("Ticket Sales are high!");
                }
                else
                {
                    MessageBox.Show("Tickets are low!");
                }
            }

            catch (Exception ex) { 

                MessageBox.Show("Exception: " + ex.Message);
            }
            

        }
    }
}
