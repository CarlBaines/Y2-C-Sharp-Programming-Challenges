﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VowelOrConsonant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtoneLetter_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   

            //Assign variables
            string letter;

            //Take input from user

            letter = txtoneLetter.Text;

            //Switch Statements

            switch (letter.ToUpper()) {
                case "A":
                    txtOutput.Text = "Vowel";
                    break;
                case "E":
                    txtOutput.Text = "Vowel";
                    break;
                case "I":
                    txtOutput.Text = "Vowel";
                    break;
                case "O":
                    txtOutput.Text = "Vowel";
                    break;
                case "U":
                    txtOutput.Text = "Vowel";
                    break;

                case "Y":
                    txtOutput.Text = "Can be a vowel or a consonant";
                    break;
                default:
                    txtOutput.Text = "Consonant";
                    break;
            }
        }
    }
}
