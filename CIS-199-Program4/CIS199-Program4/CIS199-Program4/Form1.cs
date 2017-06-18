/*
 *  Program 4
 *  CIS 199-75
 *  Grading ID: C1695
 *  Due: April 25 2017
 *  
 *  A ground package creation and viewer.
 *  
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS199_Program4
{
    public partial class PackageForm : Form
    {
        private int CreationCount = 0; //A Cheap GUID of Package
        private List<GroundPackage> Packages = new List<GroundPackage>(); //Collection of packages in list view

        public PackageForm()
        {
            InitializeComponent();
        }

        //User deletes package from list
        //PreCondition: Defined by form behavior
        //PostCondition: If not valid entry display error, else add package to list and list view, clear input
        private void createBtn_Click(object sender, EventArgs e)
        {
            //Grab all the outputs from TextBoxs
            string originStr = originInput.Text;
            string destinationStr = destinationInput.Text;
            string weightStr = weightInput.Text;
            string lengthStr = lengthInput.Text;
            string heightStr = heightInput.Text;
            string widthStr = widthInput.Text;

            //The values for each text
            int originZip;
            int destinationZip;
            double length, width, height, weight;

            //Parse all the strings into their given values
            bool originParsed = int.TryParse(originStr, out originZip);
            bool destParsed = int.TryParse(destinationStr, out destinationZip);
            bool lengthParsed = double.TryParse(lengthStr, out length);
            bool widthParsed = double.TryParse(widthStr, out width);
            bool heightParsed = double.TryParse(heightStr, out height);
            bool weightParsed = double.TryParse(weightStr, out weight);

            //If parse failed tell user and return
            if (!(originParsed || destParsed || lengthParsed ||
                widthParsed || heightParsed || weightParsed))
            {
                MessageBox.Show("Please check entries for value and try again");
                return;
            }

            //Create new ground package and add to Packages
            GroundPackage package = new GroundPackage(originZip, destinationZip, length, width, height, weight);
            Packages.Add(package);

            //Generate a unique string for view in list box
            string packageStr = "Package #" + ++CreationCount + ": " + package.CalcCost().ToString("C");
            packageList.Items.Add(packageStr);

            //Clear the inputs for quick entry
            clearInputs();
        }

        //Clear user inputs
        //PreCondition: None
        //PostCondition: All Inputs clear
        private void clearInputs()
        {
            originInput.Text = "";
            destinationInput.Text = "";
            weightInput.Text = "";
            lengthInput.Text = "";
            heightInput.Text = "";
            widthInput.Text = "";
        }

        //User clicks View Details
        //PreCondition: Defined by form behavior
        //PostCondition: If index is -1 display error or display properties of ground package
        private void detailsBtn_Click(object sender, EventArgs e)
        {
            int index = packageList.SelectedIndex;

            if (index == -1) MessageBox.Show("Please select a package.");
            else MessageBox.Show(Packages[index].ToString());
        }

        //User deletes package from list
        //PreCondition: Defined by form behavior
        //PostCondition: If index is -1 display error or remove item
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int index = packageList.SelectedIndex;

            if (index == -1) MessageBox.Show("Please select a package.");
            else
            {
                Packages.Remove(Packages[index]);
                packageList.Items.RemoveAt(index);
            }
        }

        //When user clicks Send To U of L Update packages destination zip to U of L and cost of package in the list view
        //PreCondition: Defined by form behavior
        //PostCondition: If packaged selected update values, else display error
        private void sendToBtn_Click(object sender, EventArgs e)
        {
            int index = packageList.SelectedIndex;

            if (index == -1) MessageBox.Show("Please select a package.");
            else
            {
                //Original values before update
                int originalDestination;
                double originalCost;

                //Get package and update values
                GroundPackage gp = Packages[index];
                originalDestination = gp.DestinationZip;
                originalCost = gp.CalcCost();
                gp.DestinationZip = 40292;

                //Updates string in list view
                updatePackageCostInList(gp, index);

                //Shows user changes
                displayUpdate(originalDestination, originalCost, gp.DestinationZip, gp.CalcCost(), "Destination");
            }
        }

        //When user clicks Send From U of L Update packages origin zip to U of L and cost of package in the list view
        //PreCondition: Defined by form behavior
        //PostCondition: If packaged selected update values, else display error
        private void sendFromBtn_Click(object sender, EventArgs e)
        {
            int index = packageList.SelectedIndex;

            if (index == -1) MessageBox.Show("Please select a package.");
            else
            {
                //Original values before update
                double originalCost;
                int originalOrigin;

                //Get package and update values
                GroundPackage gp = Packages[index];
                originalOrigin = gp.OriginZip;
                originalCost = gp.CalcCost();
                gp.OriginZip = 40292;

                //Updates string in list view
                updatePackageCostInList(gp, index);

                //Show user changes
                displayUpdate(originalOrigin, originalCost, gp.OriginZip, gp.CalcCost(), "Origin");
            }
        }

        //Generates a message of changed values
        //PreCondition: Must send new and old values and the type of values changed
        //PostCondition: Shows message in message box
        private void displayUpdate(int oldZip, double oldCost, int newZip, double newCost, string typeChange)
        {
            string message = "Package updated." + Environment.NewLine
                    + "Original " + typeChange + ": " + oldZip + "  New " + typeChange + ": " + newZip +
                    Environment.NewLine + "Original Cost: " + oldCost.ToString("C") + " New Cost: " + newCost.ToString("C");

            MessageBox.Show(message);
        }

        //Updates the string value of the package in the list items
        //PreCondition: Ground package must be within items, index >= 0
        //PostCondition: None
        private void updatePackageCostInList(GroundPackage gp, int index)
        {
            string packageName = (string)packageList.Items[index];
            packageList.Items.RemoveAt(index);

            int priceStart = packageName.IndexOf("$");
            string subStr = packageName.Substring(0, priceStart);

            packageList.Items.Insert(index, subStr + gp.CalcCost().ToString("C"));
        }
    }



    /// <summary>
    /// Ground Package Class
    /// Keeps track of package Dimensions and Origin and Destionation
    /// </summary>
    public class GroundPackage
    {
        //Private fields of all properties
        private int _originZip;
        private int _destinationZip;
        private double _length;
        private double _width;
        private double _height;
        private double _weight;

        //Default Constructor
        public GroundPackage(int originZip, int destinationZip, double length, double width, double height, double weight)
        {
            DestinationZip = destinationZip;
            OriginZip = originZip;
            Length = length;
            Width = width;
            Height = height;
            Weight = weight;
        }
        
        //Origin Zip -> Setter validates entry and defaults the zip if entered incorrectly
        public int OriginZip {
            get
            {
                return _originZip;
            }
            set {
                _originZip = validateZip(value, 40202);
            }
        }

        //Destination Zip -> Setter validates entry and defaults the zip if entered incorrectly
        public int DestinationZip {
            get
            {
                return _destinationZip;
            }
            set
            {
                _destinationZip = validateZip(value, 90210);
            }
        }

        //Length of package for use in calculation of cost
        public double Length {
            get {
                return _length;
            }
            set {
                _length = vaildateDimension(value);
            }
        }

        //Width of package for use in calculation of cost
        public double Width {
            get
            {
                return _width;
            }
            set
            {
                _width = vaildateDimension(value);
            }
        }

        //Height of package for use in calculation of cost
        public double Height {
            get
            {
                return _height;
            }
            set
            {
                _height = vaildateDimension(value);
            }
        }

        //Weight of package for use in calculation of cost
        public double Weight {
            get
            {
                return _weight;
            }
            set
            {
                _weight = vaildateDimension(value);
            }
        }

        //Length between the origin zip and the destination zip
        public int ZoneDistance
        {
            get
            {
                return (DestinationZip / 10000) - (OriginZip / 10000);
            }
        }

        //Cost of shipping the package
        public double CalcCost()
        {
            return .2 * (Length + Width + Height) + .5 * (ZoneDistance + 1) * Weight; //Formula defined by instructions
        }

        //Ground Package ToString method traverses the properties to display name and value on new lines
        //PreCondition: None
        //PostCondition: Returns string value of object
        public override string ToString()
        {
            StringBuilder strBuilder = new StringBuilder(); //String builder to quickly create string
            PropertyInfo[] properties = typeof(GroundPackage).GetProperties(); //Get all the types properties

            foreach (PropertyInfo prop in properties)
            {
                strBuilder.Append(prop.Name + ": " + prop.GetValue(this, null)); //Add the name and value to string builder
                strBuilder.AppendLine(); //Add line to make more viewable
            }
            strBuilder.Append("Cost: " + this.CalcCost().ToString("C")); //Since cost is a method slap it in after

            return strBuilder.ToString();
        }

        //Validates Entry of Dimension
        //PreCondition: Must pass in double value
        //PostCondition: Returns the double is greater than zero or 1
        private double vaildateDimension(double d)
        {
            return d > 0 ? d : 1.0;
        }

        //Validates Entry of Zips
        //PreCondition: Must pass in the zip to check and a default zip
        //PostCondition: Returns the zip if valid or the default passed
        private int validateZip(int zip, int defaultZip)
        {
            Regex reg = new Regex("^\\d{5}(?:[-\\s]\\d{4})?$"); //Regex from StackOverFlow for zips ex. 12345 12345-1234
            if (reg.IsMatch(zip.ToString())) return zip;
            return defaultZip;
        }
    }

}
