/// <summary>
/// 
/// Lab 7 - CIS 199-75
/// Id C1695
/// Due: March 12, 2017
/// Present Value Calculator
/// 
/// </summary>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS_199_Lab7
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            double futureValue; //The value of the money in the future
            double aiRate; //The rate of annual interest
            int numYears; //The number of years it till reaching the future value

            //Parse the values from the textboxes
            bool futureParsed = double.TryParse(futureTxt.Text, out futureValue);
            bool airParsed = double.TryParse(airTxt.Text, out aiRate);
            bool yearParsed = int.TryParse(yearsTxt.Text, out numYears) && numYears > 0;

            //Display error or calculation based on values
            if (futureParsed && airParsed && yearParsed) presentTxt.Text = CalcPresentValue(futureValue, aiRate, numYears).ToString("c");
            else MessageBox.Show("Please check values and try again");
        }

        /// <summary>
        /// Calculates the present value based on Future Value / ( 1 + Annual Interest Rate)^Years
        /// </summary>
        /// <param name="futureValue">The value of the money in the future</param>
        /// <param name="annualRate">The rate of annual interest</param>
        /// <param name="numYears">The number of years it till reaching the future value</param>
        /// <PreCondition>Years must be greater than 0</PreCondition>
        /// <returns>The Present Value using the specified formula.</returns>
        private double CalcPresentValue(double futureValue, double annualRate, int numYears)
        {
            return futureValue / (Math.Pow((1 + annualRate), numYears));
        }
    }
}
