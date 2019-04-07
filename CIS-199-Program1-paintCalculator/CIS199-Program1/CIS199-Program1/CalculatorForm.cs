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

/// <summary>
/// 
/// Program 1 - CIS 199-75
/// Id C1695
/// Due: Feb 14, 2017
/// Purpose: This program will act as a calculator
/// for a painting company. User will enter a wall space,gallons of paint, and price of paint
/// and will be returned totals of cost, wall space, and hours.
/// 
/// </summary>

namespace CIS199_Program1
{
    public partial class CalculatorForm : Form
    {
        //These values are from the prompt
        //When form loads it sets values
        //But user can change in settings form
        public double SQFT_PER_GALLON_AND_HOURS { get; set; }
        public double LABOR_PER_GALLONS { get; set; }
        public double PRICE_PER_LABOR { get; set; }

        public CalculatorForm()
        {
            InitializeComponent();
        }

        //Set properties on load
        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            SQFT_PER_GALLON_AND_HOURS = 330;
            LABOR_PER_GALLONS = 6;
            PRICE_PER_LABOR = 10.5;
        }

        //When user pushes button this will check values
        //and if values are correct it will then calculate
        //totals and display in output box
        private void calcBtn_Click(object sender, EventArgs e)
        {
            float wallSpace; //The amount of sq ft of wall space -> to be used in calculation
            float paintCost; //Cost of paint per gallon -> to be used in calculation
            int paintCoats; //The amount of coats of paint -> to be used in calculation


            //Grab user input
            string wallSpace_Input = wallSpaceInput.Text;
            string paintCost_Input = paintPriceInput.Text;
            paintCoats = (int)coatsInput.Value;

            //Remove $ if user entered it
            wallSpace_Input = wallSpace_Input.Replace("$", string.Empty);
            paintCost_Input = paintCost_Input.Replace("$", string.Empty);

            //Check the input for unacceptable values like chars
            bool isWallSpaceCorrect = isCorrect(wallSpace_Input);
            bool isPaintCostCorrect = isCorrect(paintCost_Input);

            //If incorrect values display message box and return
            if(!isWallSpaceCorrect || !isPaintCostCorrect)
            {
                string message;

                //Tell user where the problem lies
                if (!isWallSpaceCorrect && !isPaintCostCorrect) message = "Wall Space and Paint Cost";
                else message = !isWallSpaceCorrect ? "Wall Space" : "Paint Cost";

                MessageBox.Show("Please Check " + message + " for incorrect values");

                return;
            }

            //Parse values
            wallSpace = float.Parse(wallSpace_Input);
            paintCost = float.Parse(paintCost_Input);

            //Calculate values
            float totalWallSpace = (paintCoats * wallSpace);
            int totalGallons = (int)Math.Ceiling(totalWallSpace / SQFT_PER_GALLON_AND_HOURS);
            double totalHours = (totalWallSpace / SQFT_PER_GALLON_AND_HOURS) * LABOR_PER_GALLONS;
            double totalPaintCost = totalGallons * paintCost;
            double totalLabor = totalHours * PRICE_PER_LABOR;
            double totalCost = totalLabor + totalPaintCost;

            //DisplayValues
            totalSqFtOutput.Text = totalWallSpace.ToString("N1");
            totalGallonsOutput.Text = totalGallons.ToString();
            totalHoursOutput.Text = totalHours.ToString("N1");
            totalCostPaintOutput.Text = totalPaintCost.ToString("C");
            totalLaborCostOutput.Text = totalLabor.ToString("C");
            totalPriceOutput.Text = totalCost.ToString("C");
        }

        //Checks if the input is empty or contains special chars or regular chars. 
        //Regex is taken from StackOverflow -> http://stackoverflow.com/questions/10644318/regex-for-alphanumeric-and-special-characters
        //Modified Regex to ignore numbers
        public bool isCorrect(string input)
        {
            return !(input == string.Empty || input == "" || Regex.IsMatch(input, @"[a-zA-Z@#$%&*+\-_(),+':;?,!\[\]\s\\/]+$"));
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            //Create Setting Form and show it
            SettingsForm Settings = new SettingsForm(this);
            Settings.Show();
        }
    }
}
