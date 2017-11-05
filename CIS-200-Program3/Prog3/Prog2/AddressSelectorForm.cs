// Program 3
// CIS 200-01/76
// Fall 2017
// Due: 11/05/2017
// By: D4199

// File: AddressSelectorForm.cs
// This is an address selector. You pass it a UPV that will use the
// address to populate a select box the user can grab an address out
// of and edit it.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPVApp;

namespace Prog2
{
    public partial class AddressSelectorForm : Form
    {
        //The upv to be used within the form
        private UserParcelView _UPV;


        //PreConditions: Requires User Parcel View
        //PostConditions: Shows a Selector Form
        public AddressSelectorForm(UserParcelView upv)
        {
            //Init Components
            InitializeComponent();

            //Set UPV
            this._UPV = upv;

            //Grab all the address names and set it to the select boxes items
            var addresses = _UPV.AddressList.Select(add => add.Name).ToArray();
            addressCBox.Items.AddRange(addresses);
        }

        //PreConditions: User clicks edit button
        //PostConditions: Shows a Address Form
        private void editButton_Click(object sender, EventArgs e)
        {
            //Get the index of the selected value
            int selectedIndex = addressCBox.SelectedIndex;

            //If nothing is selected tell the user and return
            if (selectedIndex < 0)
            {
                MessageBox.Show("You must select an address to edit");
                return;
            }


            //The user selected a valid index lets create the form
            AddressForm addressForm = new AddressForm();

            //Get the address
            var address = _UPV.AddressAt(addressCBox.SelectedIndex);
            
            //Set the forms values based on the selected address
            addressForm.AddressName = address.Name;
            addressForm.Address1 = address.Address1;
            addressForm.Address2 = address.Address2;
            addressForm.City = address.City;
            addressForm.State = address.State;
            addressForm.ZipText = address.Zip.ToString();

            //Lets hide the form to make it look cleaner
            this.Visible = false;

            //Show the address form and wait for a response
            var result = addressForm.ShowDialog();

            //The user closed the form, if they accepted the edit lets set the values, if not close the form
            if (result == DialogResult.OK)
            {
                //Set the values from the form to the address
                address.Name = addressForm.AddressName;
                address.Address1 = addressForm.Address1;
                address.Address2 = addressForm.Address2;
                address.City = addressForm.City;
                address.State = addressForm.State;
                address.Zip = int.Parse(addressForm.ZipText);

                //Close the form with an OK status
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                //Closes the form
                cancelButton_Click(sender, e);
            }
    
        }

        //PreConditions: Clicks the cancel button
        //PostConditions: Closes the form
        private void cancelButton_Click(object sender, EventArgs e)
        {
            //Close the form with a cancel status
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
