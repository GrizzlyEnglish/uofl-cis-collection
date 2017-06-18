/// <summary>
/// 
/// Lab 7 - CIS 199-75
/// Id C1695
/// Due: April 1, 2017
/// Translate selected English Month Name to Spanish and Italian
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

namespace Lab8
{
    public partial class transForm : Form
    {
        const int ENGLISH = 0; //English months location in array
        const int SPANISH = 1; //Spanish months location in array
        const int ITALIAN = 2; //Italian months location in array

        //Init all the different month names into a jagged array based on [language][monthNumber]
        private string[][] MONTHS_ARR = 
        {
            new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"},
            new string[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio","Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"},
            new string[] { "Gennaio", "Febbraio", "Marzo", "Aprile", "Maggio", "Giugno", "Luglio","Agosto", "Settembre", "Ottobre", "Novembre", "Dicembre"}
        };

        public transForm()
        {
            InitializeComponent();
        }

        //On form load preselect English to force correct input
        private void transForm_Load(object sender, EventArgs e)
        {
            englishButton.Select();
        }

        private void translateButton_Click(object sender, EventArgs e)
        {
            int selectedNum; //Month num entered by user

            if (int.TryParse(monthNum.Text, out selectedNum) && (selectedNum >= 0 && selectedNum <= 12))
            {
                int langNum; //0-2 Depending on the radio buttons selected

                if (englishButton.Checked) langNum = 0;
                else if (spanishButton.Checked) langNum = 1;
                else langNum = 2;

                outputLabel.Text = GetMonth(langNum, selectedNum);
            }
        }

        //Little helper function to tell me which function to call. We default english since we auto select English
        private string GetMonth(int langNum, int monthNum)
        {
            switch (langNum)
            {
                default:
                    return GetEnglishMonth(monthNum);
                case SPANISH:
                    return GetSpanishMonth(monthNum);
                case ITALIAN:
                    return GetItalianMonth(monthNum);
            }
        }

        //Gets the English name of month number, num must be less than 12 and greater than 0
        private string GetEnglishMonth(int num)
        {
            return MONTHS_ARR[ENGLISH][num - 1];
        }

        //Gets the Spanish name of month number, num must be less than 12 and greater than 0
        private string GetSpanishMonth(int num)
        {
            return MONTHS_ARR[SPANISH][num - 1];
        }

        //Gets the Italian name of month number, num must be less than 12 and greater than 0
        private string GetItalianMonth(int num)
        {
            return MONTHS_ARR[ITALIAN][num - 1];
        }
    }
}
