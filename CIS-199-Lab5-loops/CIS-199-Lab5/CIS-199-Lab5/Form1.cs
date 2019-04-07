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
/// Program 1 - CIS 199-75
/// Id C1695
/// Due: Feb 14, 2017
/// Purpose: Display count using various loops
/// 
/// </summary>

namespace CIS_199_Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            int start; //Start of loop
            int end; //End of loop

            bool parsedStart = int.TryParse(fromInput.Text, out start);
            bool parsedEnd = int.TryParse(toInput.Text, out end);

            //If invalid entry display to user
            if(!parsedEnd || !parsedStart)
            {
                MessageBox.Show("Please check input and try again.");
                return;
            }

            //Count based on radio selected
            if (whileRadio.Checked) RunWhileLoop(start, end);
            else if (forRadio.Checked) RunForLoop(start, end);
            else if (doRadio.Checked) RunDoWhileLoop(start, end);
        }

        private void RunWhileLoop(int start, int end)
        {
            while(start <= end)
            {
                countList.Items.Add(start++.ToString());
                listBox1.Items.Add(start++.ToString());
            }
        }

        private void RunForLoop(int start, int end)
        {
            for (; start <= end; start++)
            {
                countList.Items.Add(start.ToString());
                listBox1.Items.Add(start++.ToString());
            }
        }

        private void RunDoWhileLoop(int start, int end)
        {
            do
            {
                countList.Items.Add(start++.ToString());
                listBox1.Items.Add(start++.ToString());
            } while (start <= end);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            countList.Clear();
        }
    }
}
