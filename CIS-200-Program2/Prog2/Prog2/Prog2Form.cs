using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class Prog2Form : Form
    {
        //The address/letter singleton
        private UserParcelView UserParcelView;

        // Precondition:  None
        // Postcondition: Program exits
        public Prog2Form()
        {
            InitializeComponent();

            //Create an instance of the singleton
            UserParcelView = new UserParcelView();

            //Lets add some fake data to the singleton
            pseudoData();

            //Output all the data
            outputAddressesAndLetters();
        }

        #region File

        // Precondition:  None
        // Postcondition: Display my information
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var NL = System.Environment.NewLine; //Quick newline use

            //Build a crummy string of my stats
            var aboutStr = "Program 2" + NL + "By: D4199" + NL + "CIS 200" + NL + "Fall 2016";

            //Show them in a message box
            MessageBox.Show(aboutStr);
        }

        // Precondition:  None
        // Postcondition: Program exits
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Insert 

        // Precondition:  None
        // Postcondition: Adds a handler to the Insert -> Address
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create the address from, giving it the UPV
            AddressForm addressEntry = new AddressForm(UserParcelView);

            //Show the dialog and wait for user response
            addressEntry.ShowDialog();

            //Lets rebuild the list, something might have been added
            outputAddressesAndLetters(true);
        }

        // Precondition:  None
        // Postcondition: Adds a handler to the Insert -> Letter
        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create the letter form, giving it the UPV
            LetterForm letterForm = new LetterForm(UserParcelView);

            //Show the dialog wait for it to close
            letterForm.ShowDialog();

            //Lets rebuild the list, something might have been added
            outputAddressesAndLetters(true);
        }

        #endregion

        #region Report

        // Precondition:  None
        // Postcondition: Outputs addresses to the text area
        private void listAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Call helper to print letter
            outputItems<Address>(UserParcelView.AddressList, "Addresses");
        }

        // Precondition:  None
        // Postcondition: Outputs letters to the text area
        private void listParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Call helper function to print addressers
            outputItems<Parcel>(UserParcelView.ParcelList, "Letters");
        }

        // Precondition:  None
        // Postcondition: Outputs addresses/letters to the text area
        private void listBothToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Call helper function
            outputAddressesAndLetters();
        }

        #endregion

        #region Helper Functions

        // Precondition:  None
        // Postcondition: Outputs addresses/letters to the text area
        private void outputAddressesAndLetters(bool clear = false)
        {
            //Call helper function to print addressers, with/without clearing
            outputItems<Parcel>(UserParcelView.ParcelList, "Letters", clear);

            //Add a new line for visiblity
            outputTextArea.AppendText(System.Environment.NewLine);

            //Call helper to print letter, without clearing, since we are doing both
            outputItems<Address>(UserParcelView.AddressList, "Addresses", false);

            //Call helper to scroll to the top
            outputScrollToTop();
        }

        // Precondition:  None
        // Postcondition: Scrolls to the top of text area
        private void outputScrollToTop()
        {
            //Sets the scroll bar to poistion 0
            outputTextArea.SelectionStart = 0;

            //Scrolls to the position
            outputTextArea.ScrollToCaret();
        }

        // Precondition:  Have a list T items, a formatted name of what they are, and if we want to clear the output area
        // Postcondition: Formats the Outputs addresses to the text area
        private void outputItems<T>(List<T> items, string formattedTypeName, bool clear = true)
        {
            //Clear if need to before printing
            if (clear) outputTextArea.Clear();

            //Lets make a nice header
            outputTextArea.AppendText("---------------- "+formattedTypeName.ToUpper()+" ON FILE----------------------");

            //Append a new line
            outputTextArea.AppendText(System.Environment.NewLine);

            //Call helper to print out the list of addresses from the UPV, display error if empty
            fillOutputText<T>(items, "No "+formattedTypeName+" to display");

            //Scroll to the top of the text area
            outputScrollToTop();
        }

        // Precondition:  List of T items, an error message if empty
        // Postcondition: Prints an item to the output area
        private void fillOutputText<T>(List<T> items, string errorMessage = "No items to display")
        {
            //Check if list is empty if it is display error message
            if(items == null || items.Count == 0)
            {
                outputTextArea.AppendText(errorMessage);
            }
            else
            {
                //Loop backwards to always print newest first
                for (var i = items.Count - 1; i > 0; i--)
                {
                    T item = items[i];

                    outputTextArea.AppendText(item.ToString());
                    outputTextArea.AppendText(System.Environment.NewLine);
                    outputTextArea.AppendText("--------------------------------------");
                    outputTextArea.AppendText(System.Environment.NewLine);
                }
            }
        }

        // Precondition:  None
        // Postcondition: Fills form with fake data
        private void pseudoData()
        {
            //Add the addresses to the user factory
            UserParcelView.AddAddress("Gary Smith", "10405 Thrift Drive", "Apt 105", "Louisvile", "KY", 40223);
            UserParcelView.AddAddress("Bob Jones", "3603 Spring Villa Circle", "Apt 5", "Louisvile", "KY", 40223);
            UserParcelView.AddAddress("Alan Gavin", "U of L", "Louisvile", "KY", 40291);
            UserParcelView.AddAddress("Gray Thomas", "18 Lane Avenue", "Louisvile", "KY", 42044);
            UserParcelView.AddAddress("This Guy", "222 Road Road", "Apt 105", "Louisvile", "KY", 40223);
            UserParcelView.AddAddress("That Guy", "123 Ave Street", "Apt 105", "Louisvile", "KY", 40223);

            //Add the letters to the user factory
            UserParcelView.AddLetter(UserParcelView.AddressAt(0), UserParcelView.AddressAt(5), 12.50m);
            UserParcelView.AddLetter(UserParcelView.AddressAt(1), UserParcelView.AddressAt(5), 9.50m);
            UserParcelView.AddLetter(UserParcelView.AddressAt(2), UserParcelView.AddressAt(3), 12.50m);
            UserParcelView.AddLetter(UserParcelView.AddressAt(3), UserParcelView.AddressAt(4), 122.50m);
            UserParcelView.AddLetter(UserParcelView.AddressAt(0), UserParcelView.AddressAt(2), 122.50m);
        }


        #endregion

    }
}
