using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// 
/// Program 2
/// CIS 199 02/25/2017
/// Grading ID: C1695
/// 
/// The purpose of this minature program is to take a users grade and last name
/// and then give them the time they are allowed to registar with the University
/// of Louisville. Resource used: http://louisville.edu/registrar/registration-information/prisummer
/// 
/// Attempted to use the least amount of code, which was suprisingly difficult
/// without using a collection. I did however use a ternary expression, which was 
/// not covered in class; but is just a inline if-else statement so I assumed fair game.
/// 
/// </summary>

namespace CIS150_Lab4
{
    public partial class Program2Form : Form
    {
        //String values of grades for combo box and comparison
        const string GRAD = "Graduate";
        const string POST_SENIOR = "Post-Baccalaureate and Seniors";
        const string JUNIOR = "Juniors";
        const string SOPH = "Sophomores";
        const string FRESH = "Freshman";

        //String values of dates for easy changing
        const string DAY_ONE = "March 28";
        const string DAY_TWO = "March 29";
        const string DAY_THREE = "March 30";
        const string DAY_FOUR = "March 31";
        const string DAY_FIVE = "April 3";
        const string DAY_SIX = "April 4";
        const string DAY_SEVEN = "April 5";
        const string DAY_EIGHT = "April 6";

        //String values of times for easy changing
        const string TIME_ONE = "8:30 AM";
        const string TIME_TWO = "10:00 AM";
        const string TIME_THREE = "11:30 AM";
        const string TIME_FOUR = "2:00 PM";
        const string TIME_FIVE = "4:00 PM";

        //Special time for Graduates
        const string TIME_GRAD = "10:30 AM";

        public Program2Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Add the grade names to the combo box
            gradeBox.Items.Add(GRAD);
            gradeBox.Items.Add(POST_SENIOR);
            gradeBox.Items.Add(JUNIOR);
            gradeBox.Items.Add(SOPH);
            gradeBox.Items.Add(FRESH);
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            char firstLetter; //Used to find standing based on fist letter of last name
            string grade; //Used to find standing based on grade

            //Get input from boxes
            object gradeBox_Selected = gradeBox.SelectedItem;
            string input = lastNameInput.Text.ToLower();

            //Validate input
            if(gradeBox_Selected == null || input == "")
            {
                MessageBox.Show("Please verify entry and try again");
                return;
            }

            firstLetter = input.First();
            grade = gradeBox_Selected.ToString();

            scheduleLabel.Text = getDate(grade, firstLetter);
        }

        //Combines the date and time span for nice display
        private string CombineTimeAndDate(string date, string time)
        {
            return date + " at " + time;
        }

        //Gets the date and time based on grade and first letter of last name
        //View chart here: http://louisville.edu/registrar/registration-information/prisummer
        private string getDate(string grade, char letter)
        {
            string date;
            string time;
            int dayPassed;

            switch (grade)
            {
                case GRAD:
                    date = DAY_ONE;
                    time = TIME_GRAD;
                    break;
                case POST_SENIOR:
                    return JuniorSeniorTime(letter, true);
                case JUNIOR:
                    return JuniorSeniorTime(letter, false);
                case SOPH:
                    dayPassed = SophomoreFreshmanTime(letter, true, out time);
                    date = dayPassed == 0 ? DAY_FOUR : DAY_FIVE; //Ternary Expersion if we return a 1 add a day
                    break;
                case FRESH:
                    dayPassed = SophomoreFreshmanTime(letter, true, out time);
                    date = dayPassed == 0 ? DAY_SIX : DAY_SEVEN; //Ternary Expersion if we return a 1 add a day
                    break;
                default:
                    date = DAY_EIGHT;
                    time = TIME_ONE;
                    break;
            }

            return CombineTimeAndDate(date, time);
        }

        //Junior/Seniors/And Post-Bacc don't have multi tiers so its a simple name check
        private string JuniorSeniorTime(char letter, bool senior)
        {
            string time;

            if (letter <= 'd') time = TIME_THREE;
            else if (letter <= 'i') time = TIME_FOUR;
            else if (letter <= 'o') time = TIME_FIVE;
            else if (letter <= 's') time = TIME_ONE;
            else time = TIME_TWO;

            //Ternary if its a senior return prior day or if its a junior return the next
            string date = senior ? DAY_TWO : DAY_THREE;

            return CombineTimeAndDate(date, time);
        }

        //Freshman/Sophomores have 2 tiers so to accomplish this we check first by continiously 
        // going up the alphabet, if false then we check specific cases. This allows for the least
        // amoune of checks as possible. We also return an integer based on which tier they are in
        // so we can add a day to the date string.
        private int SophomoreFreshmanTime(char letter, bool sophomore, out string time)
        {
            if (letter <= 'b' || (letter >= 'm' && letter <= 'o')) time = TIME_FIVE;
            else if (letter <= 'd' || (letter >= 'p' && letter <= 'q')) time = TIME_ONE;
            else if (letter <= 'f' || (letter >= 'r' && letter <= 's')) time = TIME_TWO;
            else if (letter <= 'i' || (letter >= 't' && letter <= 'v')) time = TIME_THREE;
            else time = TIME_FOUR;

            return letter >= 'p' || (letter == 'a' || letter == 'b') ? 0 : 1;
        }

    }
}
