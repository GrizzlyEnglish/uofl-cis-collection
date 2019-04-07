using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS199_Lab4
{
    public partial class Form1 : Form
    {
        const double GPA_TIPPING_POINT = 3.0;
        const double TESTSCORE_BELOW_TIPPING = 80;
        const double TESTSCORE_ABOVE_TIPPING = 60;

        private int ACCEPTED_COUNT = 0;
        private int REJECTED_COUNT = 0;

        public Form1()
        {
            InitializeComponent();
        }

        //When form loads set the labels as zeros
        private void Form1_Load(object sender, EventArgs e)
        {
            setLabel(accepetedAmount, ACCEPTED_COUNT, "Accepted");
            setLabel(deniedAmount, REJECTED_COUNT, "Rejected");
        }

        //Easy method to set label of the denied and accepted fields
        private void setLabel(Label label, int amount, string type)
        {
            label.Text = amount + " - " + type;
        }

        private void checkStudent_Click(object sender, EventArgs e)
        {
            double gpa; //GPA of Student
            double testScore; // Test score of student

            //Attempt to parse each var
            bool isGPAParsed = double.TryParse(gpaInput.Text, out gpa);
            bool isScoreParsed = double.TryParse(adminInput.Text, out testScore);

            //If either was unable to parse tell user, and return
            if(!isGPAParsed || !isScoreParsed)
            {
                MessageBox.Show("Please check inputs");
                return;
            }

            //Clear previous entries
            gpaInput.Text = "";
            adminInput.Text = "";

            //Check is students gpa and test scores allowed from them to enter
            bool acceptedStudent = (gpa >= GPA_TIPPING_POINT && testScore >= TESTSCORE_ABOVE_TIPPING) 
                || (gpa < GPA_TIPPING_POINT && testScore >= TESTSCORE_BELOW_TIPPING);

            if (acceptedStudent)
            {
                //If accepted set label and increase counter
                entryStatus.Text = "Accepted";
                setLabel(accepetedAmount, ++ACCEPTED_COUNT, "Accepted");
                //The use of ++ before the variable name will add 1 to the value before pushing to method
            } else
            {
                //If rejected set label and increase counter
                entryStatus.Text = "Rejected";
                setLabel(deniedAmount, ++REJECTED_COUNT, "Rejected");
                //The use of ++ before the variable name will add 1 to the value before pushing to method
            }

        }

        
    }
}
