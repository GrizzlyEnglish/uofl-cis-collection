using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    /*
     * <summary>
     *  Lab 2 for CIS 199 01/28/17
     *  Grading Id: C1695
     *  Lab 2 takes input from the user and formats the string 
     *  if differing ways depending on the button that was pressed.
     * </summary>
    */

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        //Check input checks the input of first and last name and if both are empty, and if they have values
        //it will return true, if they are both empty it will return false.
        private bool checkInput()
        {
            return firstNameInput.Text != "" && lastNameInput.Text != "";
        }

        //Format One example: Ms. Kelly Jane Smith
        private void formatOneBtn_Click(object sender, EventArgs e)
        {
            string output = ""; //The formatted output string
            
            //This checks the input entered by the user
            if (!checkInput())
            {
                outputLabel.Text = "Please enter first and last name";
                return;
            }

            output = titleInput.Text + " " + firstNameInput.Text + " " + middleNameInput.Text + " " + lastNameInput.Text;

            outputLabel.Text = output;
        }

        //Format Two example: Kelly Jane Smith
        private void formatTwoBtn_Click(object sender, EventArgs e)
        {
            string output = ""; //The formatted output string

            //This checks the input entered by the user
            if (!checkInput())
            {
                outputLabel.Text = "Please enter first and last name";
                //If input is missing first and last set the ouput as needing more information and return
                return;
            }

            output = firstNameInput.Text + " " + middleNameInput.Text + " " + lastNameInput.Text;

            outputLabel.Text = output;
        }

        //Format Three example: Kelly Smith
        private void formatThreeBtn_Click(object sender, EventArgs e)
        {
            string output = ""; //The formatted output string

            //This checks the input entered by the user
            if (!checkInput())
            {
                outputLabel.Text = "Please enter first and last name";
                //If input is missing first and last set the ouput as needing more information and return
                return;
            }

            output = firstNameInput.Text + " " + lastNameInput.Text;

            outputLabel.Text = output;
        }

        //Format Four example: Smith, Kelly Jane, Ms.
        private void formatFourBtn_Click(object sender, EventArgs e)
        {
            string output = ""; //The formatted output string

            //This checks the input entered by the user
            if (!checkInput())
            {
                outputLabel.Text = "Please enter first and last name";
                //If input is missing first and last set the ouput as needing more information and return
                return;
            }

            output = lastNameInput.Text + ", " + firstNameInput.Text + " " + middleNameInput.Text + ", " + titleInput.Text;

            outputLabel.Text = output;
        }

        //Format Five exapmle: Smith, Kelly Jane
        private void formatFiveBtn_Click(object sender, EventArgs e)
        {
            string output = ""; //The formatted output string

            //This checks the input entered by the user
            if (!checkInput())
            {
                outputLabel.Text = "Please enter first and last name";
                //If input is missing first and last set the ouput as needing more information and return
                return;
            }

            output = lastNameInput.Text + ", " + firstNameInput.Text + " " + middleNameInput.Text;

            outputLabel.Text = output;
        }

        //Format Six example: Smith, Kelly
        private void formatSixBtn_Click(object sender, EventArgs e)
        {
            string output = ""; //The formatted output string

            //This checks the input entered by the user
            if (!checkInput())
            {
                outputLabel.Text = "Please enter first and last name";
                //If input is missing first and last set the ouput as needing more information and return
                return;
            }

            output = lastNameInput.Text + ", " + firstNameInput.Text;

            outputLabel.Text = output;
        }
    }
}
