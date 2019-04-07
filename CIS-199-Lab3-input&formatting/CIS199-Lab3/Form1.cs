using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS199_Lab3
{

    /*
     * <summary>
     *  Lab 3 for CIS 199 02/12/17
     *  Grading Id: C1695
     * Lab 3 takes the input from user to calculate the tip based of the
     * price of the meal entered by the user
     * </summary>
    */

    public partial class Form1 : Form
    {

        private const double TIP_ONE = 0.15;
        private const double TIP_TWO = 0.18;
        private const double TIP_THREE = 0.20;

        public Form1()
        {
            InitializeComponent();
        }

        //On the form load set the percentage labels for 
        //the tips.
        private void Form1_Load(object sender, EventArgs e)
        {
            tipOneLabel.Text = toPercent(TIP_ONE);
            tipTwoLabel.Text = toPercent(TIP_TWO);
            tipThreeLabel.Text = toPercent(TIP_THREE);
        }

        //This is my version of to string. This skips the trailing zeroes
        private string toPercent(double d)
        {
            return (d * 100) + "%";
        }


        //Calculates tip based on users input
        private void calcBtn_Click(object sender, EventArgs e)
        {
            double mealPrice; //The value of the meal entered by user

            string enteredPrice = priceInput.Text;

            //If the user did not enter any value or the value contains letters
            //Tell user to only enter numbers and return
            if(enteredPrice == null || Regex.IsMatch(enteredPrice, "[a-zA-Z]"))
            {
                MessageBox.Show("Please enter only number values");
                return;
            }

            mealPrice = double.Parse(enteredPrice);

            tipOneCalced.Text = calcTip(mealPrice, TIP_ONE).ToString("C");
            tipTwoCalced.Text = calcTip(mealPrice, TIP_TWO).ToString("C");
            tipThreeCalced.Text = calcTip(mealPrice, TIP_THREE).ToString("C");
        }

        //This takes the value of the price multiplies by the tip
        //and returns the value
        private double calcTip(double price, double tip)
        {
            return price * tip;
        }
        
    }
}
