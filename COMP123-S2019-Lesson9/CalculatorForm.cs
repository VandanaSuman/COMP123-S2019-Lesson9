﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson9
{
    public partial class CalculatorForm : Form
    {
        /// <summary>
        /// This is the constrcot for the calculator form
        /// </summary>
        public CalculatorForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the shared event handler for all the calculator buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            var TheButton = sender as Button;
            int buttonvalue;
            bool resultCondition = int.TryParse(TheButton.Text, out buttonvalue);

            if(resultCondition)
            {
                ResultLabel.Text += TheButton.Text;
            }
            else
            {
                ResultLabel.Text = "Not a Number(NAN)";
            }
            ResultLabel.Text = TheButton.Text;
        }
    }
}
