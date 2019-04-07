using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 * <summary>
 *  Lab 1 for CIS 199 01/28/17
 *  Grading Id: C1695
 *  The objective of Lab 1 is to create a from that
 *  displays an image of an animal, a grading Id, and
 *  three buttons that when pressed show a message box
 *  based on the buttons. 
 * </summary>
*/
namespace CIS199_Lab1
{
    public partial class Form1 : Form
    {
        //This initializes the form. I set the name here, since I -for
        //whatever reason could not find it in the design view and
        //got lazy.
        public Form1()
        {
            Name = "Lab 1";
            InitializeComponent();
        }

        //Pressing hobbiesBtn Displays my hobbies
        private void hobbiesBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programming, Table Tennis, Games");
        }

        //Pressing booksBtn displays my favorite books
        private void booksBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Flowers for Algernon by Dainiel Keys");
        }

        //Pressing moviesBtn displaytts my favorite movies
        private void moviesBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Iron Giant");
        }
    }
}
