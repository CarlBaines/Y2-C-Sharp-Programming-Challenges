using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxLoop
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

        private void txtEnterName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Inputs

            string name;

            name = txtEnterName.Text;

            //Loop outputting name to the textbox ten times

            for (int i = 0; i < 11; i++)
            {
                txtNameLoop.Text += name + System.Environment.NewLine;
                
            }
        }
    }
}
