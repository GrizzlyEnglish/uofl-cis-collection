// Program 2
// CIS 200-01/76
// Fall 2017
// Due: 10/23/2017
// By: D4199

// File: LetterForm.cs
// A simple letter form entry. Does NOT create the obj, untill called by elsewhere.
// Needs the caller to fill the items in the combo boxes
// Allows for the creator to determine how letters will be used.


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

    // Precondition:  None
    // Postcondition: A form will be created
    public partial class LetterForm : Form
    {
        //The address/letter singleton
        private UserParcelView _UPV;

        // Precondition:  Pass a UPV
        // Postcondition: Instatiates a letter form
        public LetterForm(UserParcelView upv)
        {
            InitializeComponent();

            //Set the UPV
            _UPV = upv;

            //Fill the combo boxes with the addresses names
            setAddresses(_UPV.AddressList);
        }

        // Precondition:  None
        // Postcondition: Allows the caller to set the items in the list
        public void setAddresses(List<Address> addresses)
        {
            //Loop through address that were given and convert to Address Combo Items, convert to array for combo box
            var addressesArr = addresses.Select(add => new AddressComboItem(add)).ToArray();

            //Clear and set values for both origin and destination
            addItemsToComboBox(originBox, addressesArr);
            addItemsToComboBox(destinationBox, addressesArr);
        }

        // Precondition:  Takes a non null combo box, and array of objects
        // Postcondition: Clears and adds items to combobox
        private void addItemsToComboBox(ComboBox box, object[] items)
        {
            box.Items.Clear();
            box.Items.AddRange(items);
        }

        [System.Obsolete("Deprecated, it was wrong")]
        // Precondition:  None
        // Postcondition: Will return null or the letter the user created
        public Letter getEnteredLetter()
        {
            decimal fixedCost; //To use in parsing

            //Try to parse out the fixed cost
            bool parsed = decimal.TryParse(fixedCostInput.Text, out fixedCost);

            //If parsing failed, lets just set to zero
            if (!parsed) fixedCost = 0;

            Letter letter = null; //Lets default to null, and see if we can do this

            //If the user selected addresses we can create the letter if not skip and return null
            if (originBox.SelectedItem != null || destinationBox.SelectedItem != null)
            {
                //Take the selected item of origin and destination, cast to AddressComboItem and snag the address for use in creation of the letter
                Address origin = (originBox.SelectedItem as AddressComboItem).Address;
                Address destination = (destinationBox.SelectedItem as AddressComboItem).Address;

                //Finally create that letter
                letter = new Letter(origin, destination, fixedCost);
            }

            //If no address selected value will be null, otherwise a letter
            return letter;
        }

        // Precondition:  None
        // Postcondition: Will return true or false, and if not valid will show error labels
        private bool validateEntry()
        {
            //Lets check if the user actuallly selected an origin and destination, if not lets throw up error labels
            originErr.Visible = originBox.SelectedItem == null || originBox.SelectedItem.ToString() == "";
            destinationErr.Visible = destinationBox.SelectedItem == null || destinationBox.SelectedItem.ToString() == "";

            //If either of the error labels are visible, the form is not valid
            return !(originErr.Visible || destinationErr.Visible);
        }

        // Precondition:  User clicked the create button
        // Postcondition: If valid closes the form
        private void createBtn_Click(object sender, EventArgs e)
        {
            //Check if the form is valid if not return, validateEntry() will display errors
            if (!validateEntry()) return;

            //Take the selected item of origin and destination, cast to AddressComboItem and snag the address for use in creation of the letter
            Address origin = (originBox.SelectedItem as AddressComboItem).Address;
            Address destination = (destinationBox.SelectedItem as AddressComboItem).Address;

            decimal fixedCost; //To use in parsing

            //Try to parse out the fixed cost
            bool parsed = decimal.TryParse(fixedCostInput.Text, out fixedCost);

            //If parsing failed, let ask the user if they meant free
            if (!parsed)
            {
                //Display a message and wait for input
                DialogResult dialogResult = MessageBox.Show("You enter an incorrect value for the cost to ship, is shipping free?", "Are you sure?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //The user agreed
                    fixedCost = 0;
                }
                else if (dialogResult == DialogResult.No)
                {
                    //They said no, lets return so they can change it
                    return;
                }
            }

            //Create the letter with UPV
            _UPV.AddLetter(origin, destination, fixedCost);

            //Close the form we are done here
            this.Close();
        }

        // Precondition:  User clicked cancel button
        // Postcondition: Closes the form
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            //Close the form, don't worry about asking it's not a lot of entry
            this.Close();
        }

        // Precondition:  For use in a combo box
        // Postcondition: A helper class for displaying the name in the combo box
        private class AddressComboItem
        {
            // Precondition:  None
            // Postcondition: Creates an AddressComboItem
            public AddressComboItem(Address address)
            {
                Address = address;
            }

            // Precondition:  None
            // Postcondition: Returns the text for display purposes
            public string DisplayText
            {
                get
                {
                    return Address.Name;
                }
            }

            // Precondition:  None
            // Postcondition: Sets the address for retrieval
            public Address Address { get; set; }

            // Precondition:  None
            // Postcondition: Combobox calls to string for display text
            public override string ToString()
            {
                return DisplayText;
            }
        }
    }
}
