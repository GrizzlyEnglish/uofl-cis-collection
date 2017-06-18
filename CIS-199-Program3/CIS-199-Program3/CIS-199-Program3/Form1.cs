/// <summary>
/// 
/// Program 3 - CIS 199-75
/// Id C1695
/// Due: April 11, 2017
/// A revist of the registration dates. Here I tried something different, and honestly it turned out with less code (not counting
/// the path of what you wanted to see), but was rather complicated. I honestly think the best way to make these is by amount of students
/// in each category. I tried to make this dynamic, so next year you could just change a few values and have the program work there too.
/// I blocked each region based on mine and the classes. Also to change the use, use SEQ_ARR_MODE.
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

namespace CIS_199_Program3
{
    public partial class regForm : Form
    {
        //Change this boolean to change how the program operates. My way or the way the prof wanted
        private bool SEQ_ARR_MODE = false;

        //This dictionary contains all the available windows per grade, built dynamically on run
        private Dictionary<int, List<RegistarWindow>> Windows = new Dictionary<int, List<RegistarWindow>>();

        //The starting letter of the windows
        private char START_LETTER = 'p';

        //Start date of registration to build on
        private DateTime START_DATE = new DateTime(2017, 3, 28);

        //All of the available windows, not counting special time frames
        private TimeSpan[] REGISTAR_WINDOWS = new TimeSpan[]
        {
            new TimeSpan(8,30,0),
            new TimeSpan(10,0,0),
            new TimeSpan(11,30,0),
            new TimeSpan(14,0,0),
            new TimeSpan(16,0,0),
        };

        public regForm()
        {
            InitializeComponent();
        }

        //On form load we are going to build the dictionary of time frames per grade. As each grade goes we add one or two dates
        //to the starting date, to keep tracking of the date frame.
        private void regForm_Load(object sender, EventArgs e)
        {
            DateTime date = START_DATE;

            //Starting with graduates we have a special time frame so we only need the one frame
            Windows.Add((int)GradeNames.Graduate, buildGrade(new DateTime[]{ date }, 
                new TimeSpan[] { new TimeSpan(10, 30, 0) }, new int[] { 25 }, 'a'));
            date = date.AddDays(1);

            //Seniors are only one day, with each of the specified times
            Windows.Add((int)GradeNames.Senior, buildGrade(new DateTime[] { date },
                REGISTAR_WINDOWS, getLetterSpans()));
            date = date.AddDays(1);

            //Juniors are only one day, with each of the specified times
            Windows.Add((int)GradeNames.Junior, buildGrade(new DateTime[] { date },
                REGISTAR_WINDOWS, getLetterSpans()));
            date = date.AddDays(1);

            //Sophmore is a two day event, with each of the specified times
            Windows.Add((int)GradeNames.Sophomore, buildGrade(new DateTime[] { date, date.AddDays(3) },
                REGISTAR_WINDOWS, getLetterSpans(true)));
            date = date.AddDays(4); //Add four days between soph and freshmen as per the website

            //Freshmen is a two day event, with each of the specified times
            Windows.Add((int)GradeNames.Freshmen, buildGrade(new DateTime[] { date, date.AddDays(1) },
                REGISTAR_WINDOWS, getLetterSpans(true)));

            //Add all the grades to the select box
            gradeBox.Items.AddRange(Enum.GetNames(typeof(GradeNames)));

            //Preset labels for user
            dateLabel.Text = "Enter grade and/or last name";
            timeLabel.Text = "Enter name and grade for time";
        }

        //This defines how many letters are in each time window. NOT INCLUDING START LETTER
        //Precondition: We have to types of windows split days and non split days
        private int[] getLetterSpans(bool split = false)
        {
            if(split) return new int[] { 1, 1, 2, 3, 1, 1, 1, 2, 2, 2 }; 
            else return new int[] { 3, 6, 3, 4, 5 };
        }
        
        /// <summary>
        /// Here we build the grades day(s) and time frames, by defining the start letter you can change
        /// how the windows are built.
        /// </summary>
        /// <param name="dates">Each of the dates we span</param>
        /// <param name="spans">Each of the time windows for each day</param>
        /// <param name="spanLetterAmount">How many letters teach time frame span</param>
        /// <param name="startLetter">The starting letter of the day. If null use global var</param>
        /// <returns></returns>
        private List<RegistarWindow> buildGrade(DateTime[] dates, TimeSpan[] spans, int[] spanLetterAmount, char? startLetter = null)
        {
            List<RegistarWindow> windows = new List<RegistarWindow>(); //A list of built windows
            if(startLetter == null) startLetter = START_LETTER; //If startLetter null use global
            int onLSpan = 0; //Keeps track of which time window we are on for the letter span of said time window

            for(var d = 0; d < dates.Length; d++)
            {
                for (var i = 0; i < spans.Length; i++)
                {
                    dates[d].Add(new TimeSpan(0, 0, 0)); //Set time to null so we only use the date
                    char endLetter = (char)(((int)startLetter + spanLetterAmount[onLSpan++])); //Find the end of the char window

                    //Create registart window and add to list
                    windows.Add(new RegistarWindow()
                    {
                        Window = dates[d].Add(spans[i]),
                        StartLetter = (char)startLetter,
                        EndLetter = endLetter
                    });

                    //Increase the start by the end of the previous window and add 1 letter. If we go beyond the alpahabet go back to a
                    startLetter = (char)(((int)endLetter + 1));
                    if (startLetter > 'z') startLetter = (char)(((int)startLetter - 26));
                }
            }
            //return the built windows
            return windows;
        }

        //When user changes the grade box validate entry
        private void gradeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            validateInput(nameInput.Text, gradeBox.SelectedIndex);
        }

        //When user changes the text box validate entry
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            validateInput(nameInput.Text, gradeBox.SelectedIndex);
        }

        /// <summary>
        /// Validate the entry by the user. If entry is correct then find time and date for registration
        /// </summary>
        /// <param name="name">Name entered in text box</param>
        /// <param name="selected">Selected index of grade box. Corresponds to the grade enum</param>
        private void validateInput(string name, int selected)
        {
            if (name != "" && selected >= 0)
            {
                char firstLetter = name.ToLower()[0];

                //If the first letter is not a letter tell user and return
                if (!char.IsLetter(firstLetter))
                {
                    timeLabel.Text = "Verify your name is correct";
                } else
                {
                    //Find windows my way or school way
                    if (SEQ_ARR_MODE) seqArrFindDate(selected, firstLetter);
                    else findWindow(Windows[selected], firstLetter);
                }
            }

            //If no name was entered just show what dates the user could fall into
            if (selected >= 0) findDate(Windows[selected]);
        }

        #region SCHOOL PATH

        /// <summary>
        /// Find the date and time for registartion the school way
        /// This was uses hard coded arrays and traverses them based on values entered
        /// </summary>
        /// <param name="gradeLevel">Grade level of user</param>
        /// <param name="firstLetter">First letter of last name of user</param>
        private void seqArrFindDate(int gradeLevel, char firstLetter)
        {
            if(gradeLevel == (int)GradeNames.Graduate)
            {
                //Gradute is a special day set these values no matter the first letter
                timeLabel.Text = "10:30 AM";
                dateLabel.Text = "March 28";
            }
            else if (gradeLevel <= (int)GradeNames.Junior) seqArrUpperClassmen(firstLetter, (gradeLevel == (int)GradeNames.Junior));
            else seqArrLowerClassmen(firstLetter, (gradeLevel == (int)GradeNames.Freshmen));
        }

        /// <summary>
        /// Lower classmen have split day, so the times array will not corrispond with letters, we will
        /// have to incriment the timeIndex based on how many times we traverse the letters
        /// </summary>
        /// <param name="firstLetter">First letter of user name</param>
        /// <param name="isFreshmen">Is the user a freshmen? Used to determine date</param>
        private void seqArrLowerClassmen(char firstLetter, bool isFreshmen)
        {
            //The first time has to match the first letter. Also, use the last letter in time window
            char[] letters = { 'b', 'd', 'f', 'i', 'l', 'o', 'q', 's', 'v', 'z' };
            string[] times = { "4:00 PM","8:30 AM", "10:00 AM", "11:30 AM", "2:00 PM"};
            
            //Available dates first two are soph second two are fresh
            string[] dates = { "March 31", "April 3", "April 4", "April 5" };

            int timeIndex = 0; //Track index of time array
            int dateIndex = isFreshmen ? 2 : 0; //Track index of date array, start at 2 for freshmen and add one if you go past 

            for(int i = 0; i < letters.Length; i++)
            {
                char c = letters[i];

                if (firstLetter <= c)
                {
                    if (firstLetter >= 'd' && firstLetter <= 'o') dateIndex++; //Add to the date if your letter is within the range

                    //Grab time and date and set to labels
                    string time = times[timeIndex];
                    string date = dates[dateIndex];

                    timeLabel.Text = time;
                    dateLabel.Text = date;

                    break;
                }

                //Add to time index and check if exceed bounds
                timeIndex++;
                if (timeIndex == 5) timeIndex = 0;
            }
        }

        /// <summary>
        /// Upper classmen are only on a single date. Letters and time match
        /// </summary>
        /// <param name="firstLetter">First letter of user name</param>
        /// <param name="isJunior">Is user a Junior? Used for dates</param>
        private void seqArrUpperClassmen(char firstLetter, bool isJunior)
        {
            char[] letters = { 'd', 'i', 'o', 's', 'z'}; //End letters of time frames
            string[] times = { "11:30 AM", "2:00 PM", "4:00 PM", "8:30 AM", "10:00 AM" }; //Time frames

            for (int i = 0; i < letters.Length; i++)
            {
                char c = letters[i];

                if (firstLetter <= c)
                {
                    //Grab time and date set to labels. Time and letters match since single date
                    string time = times[i];
                    string date = isJunior ? "March 30" : "March 29";

                    timeLabel.Text = time;
                    dateLabel.Text = date;

                    break;
                }
            }
        }

        #endregion SCHOOL PATH

        #region MY PATH

        /// <summary>
        /// Find the date based on the passed parameters. This is used
        /// for when the user doesn't enter a name, just grade.
        /// PRECONDITION: The list MUST be the available window for the grade, not all the windows.
        /// </summary>
        /// <param name="windows">Windows for the grade specified</param>
        private void findDate(List<RegistarWindow> windows)
        {
            List<string> dates = new List<string>(); //Just in case we have mutli days use a list

            foreach (var window in windows)
            {
                string date = window.Window.ToString("MMMM d");
                if (!dates.Contains(date)) dates.Add(date);
            }

            dateLabel.Text = string.Join(",", dates); //Join the list into singular array. This way we can easily skip extra comma

            //If there is only one window (special days) then we already know the time else tell user to insert name
            if (windows.Count == 1)
            {
                timeLabel.Text = windows[0].Window.ToShortTimeString();
            }
            else timeLabel.Text = "Enter name and grade for time";
        }

        /// <summary>
        /// Find the window the user fits into based on the last letter of their name
        /// </summary>
        /// <param name="windows">Windows available for the grade specified</param>
        /// <param name="letter">Last Letter of users name</param>
        private void findWindow(List<RegistarWindow> windows, char letter)
        {
            foreach (var window in windows)
            {
                if (window.StartLetter <= letter && window.EndLetter >= letter) //If letter is within bounds, we found set labels and return
                {
                    dateLabel.Text = window.Window.ToString("MMMM d");
                    timeLabel.Text = window.Window.ToShortTimeString();
                    return;
                }
            }
        }
    }

    /// <summary>
    /// An enumerate of grades. Matches select box for easy retrieval
    /// </summary>
    public enum GradeNames
    {
        Graduate = 0,
        Senior = 1,
        Junior = 2,
        Sophomore = 3,
        Freshmen = 4
    }

    /// <summary>
    /// Registart Window. Keeps the start letter, end letter and time frame of the particular window.
    /// </summary>
    public class RegistarWindow
    {
        public DateTime Window { get; set; }
        public char StartLetter { get; set; }
        public char EndLetter { get; set; }
    }

    #endregion MY PATH
}
