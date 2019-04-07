/*
 * 
 * Lab 9
 * CIS 199-75
 * C1695
 * Due: April 16th 2017
 * 
 * Display a date as a string and
 * update values based on user input.
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS_199_Lab9
{
    public partial class Form1 : Form
    {
        private Date Date; //Date used in form

        public Form1()
        {
            InitializeComponent();

            Date = new Date(1, 1, 2000); //Init forms date
            dateInput.Text = Date.ToString(); //Set input to date
        }

        //Update date based on button click
        private void monthBtn_Click(object sender, EventArgs e)
        {
            updateDate(monthInput.Text, Date.DateProperties.Month);
        }

        //Update date based on button click
        private void dayBtn_Click(object sender, EventArgs e)
        {
            updateDate(dayInput.Text, Date.DateProperties.Day);
        }

        //Update date based on button click
        private void yearBtn_Click(object sender, EventArgs e)
        {
            updateDate(yearInput.Text, Date.DateProperties.Year);
        }

        /// <summary>
        /// Change the selected date properties based on input
        /// PreCondition: Must pass string and which date property you want to change
        /// PostCondition: Displays error is unable to parse or sets value
        /// </summary>
        /// <param name="text"></param>
        /// <param name="type"></param>
        private void updateDate(string text, Date.DateProperties type)
        {
            int value; //Value of the parse

            if(int.TryParse(text, out value)) //Parse input
            {
                //Switch by property and set value
                switch (type)
                {
                    case Date.DateProperties.Month:
                        Date.Month = value;
                        break;
                    case Date.DateProperties.Day:
                        Date.Day = value;
                        break;
                    case Date.DateProperties.Year:
                        Date.Year = value;
                        break;
                }

                //Reset date input in GUI
                dateInput.Text = Date.ToString();
            } else
            {
                //Display error if can't parse
                MessageBox.Show("Please check " + type.ToString() + " entry");
            }
        }

    }

    public class Date
    {
        //Enumerate of the properties of the date class
        public enum DateProperties
        {
            Month,
            Day,
            Year
        }

        //Private fields of date properties
        private int _Month;
        private int _Day;
        private int _Year;

        //Default Date constructor
        public Date(int month, int day, int year)
        {
            Month = month;
            Year = year;
            Day = day;
        }

        public int Month {
            get {
                return _Month;
            }
            set
            {
                _Month = (value < 1 || value > 12) ? 1 : value; //Ternary for validation, if less than 1 or greater than 12 default to 1
            }
        }
        public int Day {
            get
            {
                return _Day;
            }
            set
            {
                _Day = (value < 1 || value > 31) ? 1 : value; //Ternary for validation, if less than 1 or greater than 31 default to 1
            }
        }
        public int Year {
            get
            {
                return _Year;
            }
            set
            {
                _Year = (value < 0) ? 2000 : value; //Ternary to validate year is postive, if not use the year 2000
            }
        }

        //String date to format MM/DD/YYYY
        public override string ToString()
        {
            return _Month.ToString("D2") + "/" + _Day.ToString("D2") + "/" + _Year.ToString("D4");
        }

    }

}
