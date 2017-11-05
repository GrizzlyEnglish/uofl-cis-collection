﻿// Program 2
// CIS 200-01/76
// Fall 2017
// Due: 10/23/2017
// By: Andrew L. Wright (Students use Grading ID)

// File: Prog2Form.cs
// This class creates the main GUI for Program 2. It provides a
// File menu with About and Exit items, an Insert menu with Address and
// Letter items, and a Report menu with List Addresses and List Parcels
// items.

using Prog2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class Prog2Form : Form
    {
        private UserParcelView upv; // The UserParcelView

        // Precondition:  None
        // Postcondition: The form's GUI is prepared for display. A few test addresses are
        //                added to the list of addresses
        public Prog2Form()
        {
            InitializeComponent();

            upv = new UserParcelView();

            //D4199 -- No longer need test data, since we can open file

            //Test Data -Magic Numbers OK
            //upv.AddAddress("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
            //    "  Louisville   ", "  KY   ", 40202); // Test Address 1
            //upv.AddAddress("Jane Doe", "987 Main St.",
            //    "Beverly Hills", "CA", 90210); // Test Address 2
            //upv.AddAddress("James Kirk", "654 Roddenberry Way", "Suite 321",
            //    "El Paso", "TX", 79901); // Test Address 3
            //upv.AddAddress("John Crichton", "678 Pau Place", "Apt. 7",
            //    "Portland", "ME", 04101); // Test Address 4
            //upv.AddAddress("John Doe", "111 Market St.", "",
            //    "Jeffersonville", "IN", 47130); // Test Address 5
            //upv.AddAddress("Jane Smith", "55 Hollywood Blvd.", "Apt. 9",
            //    "Los Angeles", "CA", 90212); // Test Address 6
            //upv.AddAddress("Captain Robert Crunch", "21 Cereal Rd.", "Room 987",
            //    "Bethesda", "MD", 20810); // Test Address 7
            //upv.AddAddress("Vlad Dracula", "6543 Vampire Way", "Apt. 1",
            //    "Bloodsucker City", "TN", 37210); // Test Address 8

            //upv.AddLetter(upv.AddressAt(0), upv.AddressAt(1), 3.95M);                     // Letter test object
            //upv.AddLetter(upv.AddressAt(2), upv.AddressAt(3), 4.25M);                     // Letter test object
            //upv.AddGroundPackage(upv.AddressAt(4), upv.AddressAt(5), 14, 10, 5, 12.5);    // Ground test object
            //upv.AddGroundPackage(upv.AddressAt(6), upv.AddressAt(7), 8.5, 9.5, 6.5, 2.5); // Ground test object
            //upv.AddNextDayAirPackage(upv.AddressAt(0), upv.AddressAt(2), 25, 15, 15,      // Next Day test object
            //    85, 7.50M);
            //upv.AddNextDayAirPackage(upv.AddressAt(2), upv.AddressAt(4), 9.5, 6.0, 5.5,   // Next Day test object
            //    5.25, 5.25M);
            //upv.AddNextDayAirPackage(upv.AddressAt(1), upv.AddressAt(6), 10.5, 6.5, 9.5,  // Next Day test object
            //    15.5, 5.00M);
            //upv.AddTwoDayAirPackage(upv.AddressAt(4), upv.AddressAt(6), 46.5, 39.5, 28.0, // Two Day test object
            //    80.5, TwoDayAirPackage.Delivery.Saver);
            //upv.AddTwoDayAirPackage(upv.AddressAt(7), upv.AddressAt(0), 15.0, 9.5, 6.5,   // Two Day test object
            //    75.5, TwoDayAirPackage.Delivery.Early);
            //upv.AddTwoDayAirPackage(upv.AddressAt(5), upv.AddressAt(3), 12.0, 12.0, 6.0,  // Two Day test object
            //    5.5, TwoDayAirPackage.Delivery.Saver);
        }

        // Precondition:  File, About menu item activated
        // Postcondition: Information about author displayed in dialog box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NL = Environment.NewLine; // Newline shorthand

            MessageBox.Show($"Program 2{NL}By: Andrew L. Wright{NL}CIS 200{NL}Fall 2017{NL}Program 3{NL}By: D4199",
                "About Program 2/3");
        }

        // Precondition:  File, Exit menu item activated
        // Postcondition: The application is exited
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Precondition:  Insert, Address menu item activated
        // Postcondition: The Address dialog box is displayed. If data entered
        //                are OK, an Address is created and added to the list
        //                of addresses
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressForm addressForm = new AddressForm();    // The address dialog box form
            DialogResult result = addressForm.ShowDialog(); // Show form as dialog and store result
            int zip; // Address zip code

            if (result == DialogResult.OK) // Only add if OK
            {
                if (int.TryParse(addressForm.ZipText, out zip))
                {
                    upv.AddAddress(addressForm.AddressName, addressForm.Address1,
                        addressForm.Address2, addressForm.City, addressForm.State,
                        zip); // Use form's properties to create address
                }
                else // This should never happen if form validation works!
                {
                    MessageBox.Show("Problem with Address Validation!", "Validation Error");
                }
            }

            addressForm.Dispose(); // Best practice for dialog boxes
                                   // Alternatively, use with using clause as in Ch. 17
        }

        // Precondition:  Report, List Addresses menu item activated
        // Postcondition: The list of addresses is displayed in the addressResultsTxt
        //                text box
        private void listAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String
            string NL = Environment.NewLine;            // Newline shorthand

            result.Append("Addresses:");
            result.Append(NL); // Remember, \n doesn't always work in GUIs
            result.Append(NL);

            foreach (Address a in upv.AddressList)
            {
                result.Append(a.ToString());
                result.Append(NL);
                result.Append("------------------------------");
                result.Append(NL);
            }

            reportTxt.Text = result.ToString();

            // -- OR --
            // Not using StringBuilder, just use TextBox directly

            //reportTxt.Clear();
            //reportTxt.AppendText("Addresses:");
            //reportTxt.AppendText(NL); // Remember, \n doesn't always work in GUIs
            //reportTxt.AppendText(NL);

            //foreach (Address a in upv.AddressList)
            //{
            //    reportTxt.AppendText(a.ToString());
            //    reportTxt.AppendText(NL);
            //    reportTxt.AppendText("------------------------------");
            //    reportTxt.AppendText(NL);
            //}

            // Put cursor at start of report
            reportTxt.Focus();
            reportTxt.SelectionStart = 0;
            reportTxt.SelectionLength = 0;
        }

        // Precondition:  Insert, Letter menu item activated
        // Postcondition: The Letter dialog box is displayed. If data entered
        //                are OK, a Letter is created and added to the list
        //                of parcels
        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LetterForm letterForm; // The letter dialog box form
            DialogResult result;   // The result of showing form as dialog
            decimal fixedCost;     // The letter's cost

            if (upv.AddressCount < LetterForm.MIN_ADDRESSES) // Make sure we have enough addresses
            {
                MessageBox.Show("Need " + LetterForm.MIN_ADDRESSES + " addresses to create letter!",
                    "Addresses Error");
                return; // Exit now since can't create valid letter
            }

            letterForm = new LetterForm(upv.AddressList); // Send list of addresses
            result = letterForm.ShowDialog();

            if (result == DialogResult.OK) // Only add if OK
            {
                if (decimal.TryParse(letterForm.FixedCostText, out fixedCost))
                {
                    // For this to work, LetterForm's combo boxes need to be in same
                    // order as upv's AddressList
                    upv.AddLetter(upv.AddressAt(letterForm.OriginAddressIndex),
                        upv.AddressAt(letterForm.DestinationAddressIndex),
                        fixedCost); // Letter to be inserted
                }
               else // This should never happen if form validation works!
                {
                    MessageBox.Show("Problem with Letter Validation!", "Validation Error");
                }
            }

            letterForm.Dispose(); // Best practice for dialog boxes
                                  // Alternatively, use with using clause as in Ch. 17
        }

        // Precondition:  Report, List Parcels menu item activated
        // Postcondition: The list of parcels is displayed in the parcelResultsTxt
        //                text box
        private void listParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String
            decimal totalCost = 0;                      // Running total of parcel shipping costs
            string NL = Environment.NewLine;            // Newline shorthand

            result.Append("Parcels:");
            result.Append(NL); // Remember, \n doesn't always work in GUIs
            result.Append(NL);

            foreach (Parcel p in upv.ParcelList)
            {
                result.Append(p.ToString());
                result.Append(NL);
                result.Append("------------------------------");
                result.Append(NL);
                totalCost += p.CalcCost();
            }

            result.Append(NL);
            result.Append($"Total Cost: {totalCost:C}");

            reportTxt.Text = result.ToString();

            // Put cursor at start of report
            reportTxt.Focus();
            reportTxt.SelectionStart = 0;
            reportTxt.SelectionLength = 0;
        }


        #region Added by D4199


        //PreConditions: Clicked the Open Tool Item
        //PostConditions: Opens a dialog and loads any data
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open a file explorer
            OpenFileDialog ofd = new OpenFileDialog();

            //We only want to show .dat as specified in the instructions
            ofd.Filter = "UserParcelViewData (*.dat)|*.dat";

            //Show the dialog and wait for a response
            DialogResult ofdResult = ofd.ShowDialog();

            //If Ok lets read the data and put it into the UPV
            if(ofdResult == DialogResult.OK)
            {
                //Read the file
                UserParcelView read_upv = ReadUserParcelView(ofd.FileName);

                //If the result is not null lets use it as the UPV
                if (read_upv != null) this.upv = read_upv;
            }

            //Lets display the list of parcels to the user, to indicate that it indeed loaded
            listParcelsToolStripMenuItem_Click(sender, e);

            //Dispose the dialog
            ofd.Dispose();
        }

        //PreConditions: Clicked the Save As Tool Item
        //PostConditions: Opens a dialog and saves any data
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open a save file dialog
            SaveFileDialog sfd = new SaveFileDialog();

            //Lets setup some values
            sfd.CheckFileExists = false; //No need for overwrite check
            sfd.InitialDirectory = "..\\"; //Sets the location of the opening file
            sfd.RestoreDirectory = true; //Go to previously opened location (if there was one)
            sfd.Filter = "UserParcelViewData (*.dat)|*.dat"; //Only show .dat files

            //Show the dialog and wait for a response
            DialogResult saveResult = sfd.ShowDialog();
            
            //If the dialog was a success lets save the upv
            if (saveResult == DialogResult.OK)
            {
                SaveUPVToFile(upv, sfd.FileName);
            }

            //Dispose the form
            sfd.Dispose();
        }

        //PreConditions: Clicked the Edit Tool Item
        //PostConditions: Opens a dialog and loads any data
        private void addressToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //If there no addresses in the list alert the user and return
            if(upv.AddressList.Count == 0)
            {
                MessageBox.Show("Must have addresses in lsit to edit.");
                return;
            }

            //Create the selector form
            AddressSelectorForm addSelect = new AddressSelectorForm(upv);

            //Show the form and wait
            var result = addSelect.ShowDialog();

            //If everything was successful list the addresses to show the edit
            if (result == DialogResult.OK) listAddressesToolStripMenuItem_Click(sender, e);
        }

        //PreConditions: UPV is not null
        //PostConditions: Saves the upv to file, returning true if successful
        private bool SaveUPVToFile(UserParcelView upv, string path = "../UserParcel.upv")
        {
            //Lets attempt to save catching any exceptions
            try
            {
                //Create the formatter
                BinaryFormatter formatter = new BinaryFormatter();

                //Setup the stream, need to open or create and have write access
                FileStream fStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);

                //Serialize the upv to the file
                formatter.Serialize(fStream, upv);
            }
            //There was a problem opening or creating the file, maybe rights problem? Lets just tell the user and return false
            catch (IOException)
            {
                MessageBox.Show("Error creating file. Please try again");
                return false;
            }
            //Error writting the file, lets just tell the user and return false
            catch (Exception)
            {
                MessageBox.Show("Error saving file. Please try again");
                return false;
            }
            
            //Everything went smoothly return true
            return true;
        }

        //PreConditions: The path cant be null
        //PostConditions: Returns a loaded UPV or null
        private UserParcelView ReadUserParcelView(string path)
        {
            //Lets attempt to laod catching any exceptions
            try
            {
                //Setup formatter
                BinaryFormatter formatter = new BinaryFormatter();

                //Setup stream we need read access and to open the file
                FileStream fStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                
                //Attempt to deserialize
                UserParcelView read_upv = (UserParcelView)formatter.Deserialize(fStream);

                //All went well return upv
                return read_upv;

            }
            //File was null show message and return null
            catch (ArgumentNullException)
            {
                MessageBox.Show("File not correct format, try again.");
            }
            //Couldnt read the file, tell user and return null
            catch (IOException)
            {
                MessageBox.Show("Unable to read file");
            }

            //Something went wrong return null
            return null;
        }

        #endregion
    }
}