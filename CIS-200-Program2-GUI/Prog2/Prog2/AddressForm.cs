// Program 2
// CIS 200-01/76
// Fall 2017
// Due: 10/23/2017
// By: D4199

// File: AddressForm.cs
// A simple address form entry. Does NOT create the obj.
// Allows for the creator to determine how address will be used.

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
    public partial class AddressForm : Form
    {
        //The singleton that handles addresses and parcels
        private UserParcelView _UPV;

        // Precondition:  Pass a userparcelview
        // Postcondition: Creates Form
        public AddressForm(UserParcelView upv)
        {
            InitializeComponent();

            //Set the Upv
            _UPV = upv;

            //Fill state boxes with some states
            fillStateBox();
        }

        // Precondition:  StateBox muste exist
        // Postcondition: Add a few states to the statebox
        private void fillStateBox()
        {
            //Add state strings to statebox's items
            stateBox.Items.Add("KY");
            stateBox.Items.Add("IL");
            stateBox.Items.Add("IN");
            stateBox.Items.Add("OH");
            stateBox.Items.Add("TN");
            stateBox.Items.Add("MI");
        }

        // Precondition:  User clicked Create
        // Postcondition: Shows errors if not valid or closes the form
        private void createBtn_Click(object sender, EventArgs e)
        {
            //Check if the form is valid if no return
            if (!validateEntry())
            {
                return;
            }

            //Set all the inputs to variables, they have already been validated
            string name = firstInput.Text + " " + lastInput.Text;
            string address = addressLine1Input.Text;
            string addressLine2 = addressLine2Input.Text;
            string city = cityInput.Text;
            string state = stateBox.SelectedItem.ToString();
            int zip = int.Parse(zipInput.Text);

            //Add an ddress to the UPV
            _UPV.AddAddress(name, address, addressLine2, city, state, zip);

            //Close the form if valid
            this.Close();
        }

        // Precondition:  None
        // Postcondition: Checks each input box for validation returns if any were invalid
        private bool validateEntry()
        {
            //If Both are empty throw up the error
            firstErr.Visible = firstInput.Text == "" && lastInput.Text == "" ;
            lastErr.Visible = firstErr.Visible;

            //If any entries are empty text throw up the erorr
            line1Err.Visible = addressLine1Input.Text == "";
            cityErr.Visible = cityInput.Text == "";
            stateErr.Visible = stateBox.SelectedItem == null || stateBox.SelectedItem.ToString() == "";

            //Validate zip
            int zip; //For use in parsing
            bool passed = int.TryParse(zipInput.Text, out zip);

            //If parse failed, or zip is outside of the bounds throw up error
            zipErr.Visible = !passed || zip < Address.MIN_ZIP || zip > Address.MAX_ZIP;

            //Any any of the labels are showing its invalid
            return !(firstErr.Visible || line1Err.Visible || cityErr.Visible || stateErr.Visible || zipErr.Visible);
        }

        [System.Obsolete("Deprecated, it was wrong")]
        // Precondition:  For external use
        // Postcondition: Returns an address obj from the enteries
        public Address getEnteredAddress()
        {
            //Try to create an address
            try
            {
                //Combine the first and last name enteries
                string name = firstInput.Text + " " + lastInput.Text;

                //If the user entered a line 2, use it if not use the one without
                return addressLine1Input.Text == "" ? new Address(name, addressLine1Input.Text, cityInput.Text,
                    stateBox.SelectedItem.ToString(), int.Parse(zipInput.Text)) :
                    new Address(name, addressLine1Input.Text, addressLine2Input.Text, cityInput.Text,
                    stateBox.SelectedItem.ToString(), int.Parse(zipInput.Text));
            }
            catch
            {
                //Something was wrong, lets just return null
                return null;
            }
        }

        // Precondition:  User clicked Cancel
        // Postcondition: Closes the eror, no warning
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            //Close the form we are done
            this.Close();
        }
    }
}
