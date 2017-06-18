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

namespace CIS199_Program1
{
    public partial class SettingsForm : Form
    {
        public CalculatorForm Parent;

        public SettingsForm(CalculatorForm parent)
        {
            Parent = parent;
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            wallSpaceInput.Text = Parent.SQFT_PER_GALLON_AND_HOURS.ToString();
            hoursInput.Text = Parent.LABOR_PER_GALLONS.ToString();
            costInput.Text = Parent.PRICE_PER_LABOR.ToString();
        }

        //Checks if the input is empty or contains special chars or regular chars. 
        //Regex is taken from StackOverflow -> http://stackoverflow.com/questions/10644318/regex-for-alphanumeric-and-special-characters
        //Modified Regex to ignore numbers
        //Here we added a check for 0, since none of these can be zero
        public bool isCorrect(string input)
        {
            return !(input == "0" || input == string.Empty || input == "" || Regex.IsMatch(input, @"[a-zA-Z@#$%&*+\-_(),+':;?.,!\[\]\s\\/]+$"));
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //Get Input
            string space = wallSpaceInput.Text;
            string hours = hoursInput.Text;
            string cost = costInput.Text;

            //Check values
            bool isSpace = isCorrect(space);
            bool isHours = isCorrect(hours);
            bool isCost = isCorrect(cost);

            //If incorrect values tell user
            if (!isSpace || !isHours || !isCost)
            {
                List<string> problems = new List<string>();

                if(!isHours) problems.Add("Hours");
                if (!isCost) problems.Add("Cost");
                if (!isSpace) problems.Add("Wall Space");

                string message = string.Join(", and", problems);

                MessageBox.Show("Please Check " + message + " for incorrect values");

                return;
            }

            //Set values in parent form
            Parent.SQFT_PER_GALLON_AND_HOURS = double.Parse(space);
            Parent.LABOR_PER_GALLONS = double.Parse(hours);
            Parent.PRICE_PER_LABOR = double.Parse(cost);

            //Close the form
            Close();
        }
    }
}
