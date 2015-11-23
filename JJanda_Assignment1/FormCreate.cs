/*
 * --------------------------------------------------------------------------
 * Developer: Jeff Janda
 * 
 * Program Name: Assignment 4, Modified Pizza Shop and Games Class
 * Note: This program still uses the original namespace from the original 
 * iteration
 * 
 * Section: Create Your Own Form
 * 
 * Date: 10/28/15
 * COP 2360
 * ---------------------------------------------------------------------------
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace JJanda_Assignment1
{
    /// <summary>
    /// The Create Form allows customers to create their own pizza
    /// using a combination of RadioBox controls and ListBoxes to build
    /// their pizza from the available menu items. When complete
    /// the user can then submit their order where they will be taken
    /// to the Confirmation form to view their completed order.
    /// 
    /// This form contains several methods used to aid in input validation
    /// or the processing of data. Global functions and variables for the
    ///Create Form may be found at the begining of the statements. 
    /// </summary>
    public partial class FormCreate : Form
    {
        #region Global variables
        //Creates a list variable to hold the customers selected toppings
        // this will be used when customers choose to add toppings
        // to their pizzas
        List<string> toppingList = new List<string>();

        //Creates a variable to hold pizza data that will be passed
        //to the Item class for it's Description Property.     
        string description = string.Empty;

        //holds the current price of Jeff's Pizza Shop's toppings
        const decimal TOPPING_COST = 0.30m;
        #endregion

        /// <summary>
        /// Formats pizza data used in the description property 
        /// into a list. This method is used to process sauce and 
        /// toppings data. This is used in the Submit Button click
        /// event during data validation and processing.
        /// </summary>
        /// <param name="descriptionData">Toppings and sauce data</param>
        /// <returns>A string list of data delimted by commas and a space</returns>
        public string FormatDescription(string descriptionData)
        {

            //checks to see if the descrition variable holds no data.
            if (description == string.Empty)
            {
                //adds the data to the description variable
                description = descriptionData;
            }
            //description holds at least one item
            else
            {
                //adds a comma and space then the next data item
                description += ", " + descriptionData;
            }

            //the delimted description
            return description;
        }

        /// <summary>
        /// Takes a customer's selected toppings and
        /// multiplies the number of toppings
        /// by the current constant topping's cost
        /// to determine the total for all toppings.
        /// This method is used in part, to determine
        /// the Item's Price property.
        /// </summary>
        /// <param name="toppingCount">Toppings ListBox Count property</param>
        /// <returns>Total of all toppings based on current Topping price</returns>
        public decimal CalculateToppingsPrice(int toppingCount)
        {
            //holds the total price of the toppings
            decimal total;

            //algorithm determining the total cost
            //TODO: build in functionality to allow for special topping pricing
            total = TOPPING_COST * toppingCount;


            return total;
        }

        /// <summary>
        /// Check RadioBox In Group runs through a GroupBox and 
        /// checks to see if a RadioBox has been selected. This is 
        /// used as part of the data validation in the DataIsValid method.
        /// 
        /// TODO:Check this method for potential future performance issues.
        /// Currently runs through all controls in a GroupBox based
        /// on the assumption the GroupBox only holds RadioButtons.
        /// </summary>
        /// <param name="box">a GroupBox Control</param>
        /// <returns>True if an item is checked, false otherwise.</returns>
        public bool CheckedRadioBoxInGroup(GroupBox box)
        {
            //flag set to false turns true if RadioButton checked
            bool anythingChecked = false;

            //Checks each RadioButton (rb) in the GroupBox (box)
            foreach (RadioButton rb in box.Controls)
            {
                //sets flag
                if (rb.Checked) anythingChecked = true;
            }

            return anythingChecked;
        }

        /// <summary>
        /// This method processes the data entered into the Create Form 
        /// and verifies that required data is not missing or formatted
        /// incorrectly. This method uses other methods detailed above
        /// to determine validation.
        /// </summary>
        /// <returns></returns>
        private bool DataIsValid()
        {
            //creates an output variable for the Quanity Tryparse validation
            int qty;

            //flag used to determine if data is valid.
            bool isValid = false;



            #region Size, Crust, and Sauce Validation
            //Checks that each GroupBox has a selection and
            //prints an error message if unchecked.

            //Size
            if (!CheckedRadioBoxInGroup(groupBoxSize))
            {
                labelMessage.Text = "Please select a size";
            }

            //Crust
            else if (!CheckedRadioBoxInGroup(groupBoxCrust))
            {
                labelMessage.Text = "Please select a crust";
            }

            //Sauce
            else if (!CheckedRadioBoxInGroup(groupBoxSauce))
            {
                labelMessage.Text = "Please select a sauce";
            }
            #endregion


            #region Toppings Validation
            //Description Property Validation
            //checks the Specials ListBox has a selected item
            else if (listBoxToppings.Items.Count == 0
                     && !checkBoxNoTop.Checked)
            {

                //prints error message asking user to select a special
                labelMessage.Text = "Would you like any toppings? " +
                                    "Please select a topping or " +
                                    "or check the 'No Topping' box";
            }
            #endregion

            #region Quantity Validation
            //Quantity Property Validation
            //checks that Quantity TextBox has a valid data type

            else if (!int.TryParse(textBoxQty.Text, out qty))
            {

                //error message prompting user to enter a quantity
                labelMessage.Text = "Please enter valid quantity.";

                //returns focus to Quantity TextBox and highlights invalid entry
                textBoxQty.Focus();
                textBoxQty.SelectAll();
            }

            //checks if the text box holds a value of zero
            else if (qty == 0)
            {
                //error message for zero items
                labelMessage.Text = "Zero items ordered. Please close the order " +
                    "form to cancel or enter a quantity greater than zero.";

                //puts focus on the Quantity TextBox Control
                textBoxQty.Focus();

                //highlights input in the Quantity TextBox Control
                textBoxQty.SelectAll();
            }
            #endregion

            else
            {

                //sets isValid to true
                isValid = true;
                labelMessage.ResetText();

            }

            //labelMessage.Text  = isValid.ToString();
            return isValid;
        }



        /// <summary>
        /// Initializes the components and loads them onto the form
        /// </summary>
        public FormCreate()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Upon loading, the Create Your Own Form, presets the meat, sauce and 
        /// cheese ListBoxes with menu items in their respective ListBoxes. This 
        /// also preselects the Red sauce, Original crust, and Large size RadioBox
        /// controls, since these are the most ordered items by Jeff's Pizza shop.
        /// 
        /// TODO: Develop functionality to populate the Menu Arrays using a file.
        /// </summary>
        /// <param name="sender">control initiating event</param>
        /// <param name="e">event argument</param>
        private void FormCreate_Load(object sender, EventArgs e)
        {

            try
            {
                //generic counter variable used to fill the toppings ListBoxes
                int count = 0;

                #region Meat
                //creates an array of meat toppings available for order
                //TODO: Develop functionality to populate the array using a file
                string[] meat = {"Pepperoni", "Sausage", "Ground Beef", "Bacon",
                            "Canadian Bacon", "Chicken", "Salami", "Anchovies"};

                //populates the Meat toppings ListBox
                //TODO: Maybe change this and following to for loop structure?
                foreach (string topping in meat)
                {
                    listBoxMeat.Items.Add(meat[count]);
                    count++;
                }
                #endregion

                #region Vegetable
                //creates an array of vegetable toppings available for order
                //TODO: Develop functionality to populate the array using a file
                string[] veg = {"Tomatoes", "Pineapple", "Sun-dried Tomatoes",
                           "Mixed Onions", "Green Olives", "Green Peppers",
                           "Mushrooms", "Black Olives", "Zucchini", 
                           "Artichoke Hearts", "Spinach", "Garlic", "Jalapenos",
                           "Banana Peppers"};

                //resets the counter to zero
                count = 0;

                //populates the Vegetable toppings ListBox
                foreach (string topping in veg)
                {
                    listBoxVeg.Items.Add(veg[count]);
                    count++;
                }
                #endregion

                #region Cheese
                //creates an array of cheese toppings available for order
                //TODO: Develop functionality to populate the array using a file
                string[] cheese = {"Extra Cheese", "Parmesan", "Feta", 
                              "Herb & Cheese Blend"};

                //resets the counter
                count = 0;

                //populates the Cheese toppings ListBox
                foreach (string topping in cheese)
                {
                    listBoxCheese.Items.Add(cheese[count]);
                    count++;
                }
                #endregion

                //Preselects RadioButtons "Large", "Original", and "Red"
                //for UX, since these are the most ordered items
                radioButtonLarge.Checked = true;
                radioButtonOriginal.Checked = true;
                radioButtonRed.Checked = true;
            }

            //Only catches general exceptions
            //TODO: make more robust event handling, especially if begin
            //using files to populate the arrays.
            catch (Exception ex)
            {
                //prints the error message for debugging purposes.
                //TODO: send error message to a log file and print a more
                //appropriate error message to the customer.
                labelMessage.Text = "Error Message: " + ex.Message;
            }


        }

        /// <summary>
        /// Submits a pizza order and takes the user to the confirmation screen.
        /// The users selections are used to create an Item that holds the customer's
        /// order information. Data is validated before the order Item is created.
        /// </summary>
        /// <param name="sender">control initiating event</param>
        /// <param name="e">event argument</param>
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (DataIsValid())
            {
                //Item variable to hold the order information
                Item myItem = new Item();


                //Checks the Size GroupBox and determines which RadioButton checked
                foreach (RadioButton rb in groupBoxSize.Controls)
                {

                    if (rb.Checked)
                    {
                        //This is a bit hacky. Uses the Text property of the
                        //RadioButton to set the value of Item Size Property.
                        //Trims the string from the '$' to the end.
                        //TODO: Develop a better method to handle this in future.
                        myItem.Size = rb.Text.Remove(rb.Text.IndexOf("$")).Trim();
                    }
                }

                //Checks the Sauce GroupBox and determines which RadioButton checked
                foreach (RadioButton rb in groupBoxSauce.Controls)
                {

                    if (rb.Checked)
                    {
                        //Determines if None RadioButton selected
                        if (rb == radioButtonNone)
                        {
                            //formats sauce description if None selected
                            description = "No sauce";
                        }

                        else
                        {
                            //See hacky note above. Adds sauce to the end of the name
                            //This information is passed to the description variable
                            //defined above. Eventually added to the Item Description
                            //Property below.
                            description = rb.Text + " sauce";
                        }
                    }
                }

                //Checks the Crust GroupBox and determines which RadioButton checked
                foreach (RadioButton rb in groupBoxCrust.Controls)
                {

                    if (rb.Checked)
                    {
                        //Uses the RadioButton Text Property and passes the value
                        //to the Item Crust Property.
                        myItem.Crust = rb.Text;
                    }
                }

                //If no topping CheckBox is not checked
                if (!checkBoxNoTop.Checked)
                {
                    //Loops through the Toppings the customer has selected
                    foreach (string topping in listBoxToppings.Items)
                    {

                        //Uses the Format Description method to create the description
                        //assigns the value the Item Description Property.
                        //See above for information about Format Description Method.
                        myItem.Description = FormatDescription(topping);

                    }
                }


                else
                {
                    //assigns the sauce description to the Item Description Property.
                    //This condition was implemented to solve a bug
                    //where sauce data would not be assigned to the Item Description
                    //if "No Toppings" was selected. 
                    //TODO: Develop better functionality in Format Description Method
                    //to fix side effect and reduce the amount of code.
                    myItem.Description = description;
                }

                //assigns the quantity amount entered to the Item's Quantity Property
                myItem.Quantity = int.Parse(textBoxQty.Text);

                //Calculates the total Price of the Item. 
                //Calculate Price is defined in Item Class Documentation. 
                //Calculate Topping Price is defined above.
                myItem.CalculatePrice(CalculateToppingsPrice
                                                     (listBoxToppings.Items.Count));




                //Calls overloaded Constructor of Confirmation Form
                //Takes an Item so data can be loaded into the Confirmation Form
                FormConfirmation myConfirmation = new FormConfirmation(myItem);
                myConfirmation.ShowDialog();
            }
        }

        /// <summary>
        /// Clears the Toppings ListBox of all items
        /// </summary>
        /// <param name="sender">control initiating event</param>
        /// <param name="e">event argument</param>
        private void buttonRemoveAll_Click(object sender, EventArgs e)
        {
            listBoxToppings.Items.Clear();
        }

        /// <summary>
        /// Adds the selected Topping to the Toppings ListBox
        /// </summary>
        /// <param name="sender">control initiating event</param>
        /// <param name="e">event argument</param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //checks that a topping has been selected. Will not show if 
            //'No Toppings' selected
            if (listBoxCheese.SelectedIndex == -1 && listBoxVeg.SelectedIndex == -1 &&
                listBoxMeat.SelectedIndex == -1 && !checkBoxNoTop.Checked)
            {
                labelMessage.Text = "Please select a topping or check 'No Toppings'.";
            }


            //TODO: Wrap the following lines into a single Method call
            //to eliminate repeated statements.
            else
            {
                // Meat Topping selected
                if (listBoxMeat.SelectedIndex > -1)
                {
                    //Clears selections from Cheese and Veg ListBoxes
                    listBoxCheese.ClearSelected();
                    listBoxVeg.ClearSelected();

                    //Unchecks "No Toppings"
                    checkBoxNoTop.Checked = false;

                    //Adds topping to Toppings ListBox and clears the selectioin
                    listBoxToppings.Items.Add(listBoxMeat.SelectedItem);
                    listBoxMeat.ClearSelected();
                }

                // Cheese Topping selected
                if (listBoxCheese.SelectedIndex > -1)
                {
                    //clears selections from Meat & Veg ListBoxes
                    listBoxMeat.ClearSelected();
                    listBoxVeg.ClearSelected();

                    //Unchecks "No Topping"
                    checkBoxNoTop.Checked = false;

                    //adds topping to Toppings ListBox and clears the selection
                    listBoxToppings.Items.Add(listBoxCheese.SelectedItem);
                    listBoxCheese.ClearSelected();
                }

                // Vegetable Topping selected
                if (listBoxVeg.SelectedIndex > -1)
                {
                    //Clears Meat and Cheese ListBoxes
                    listBoxMeat.ClearSelected();
                    listBoxCheese.ClearSelected();

                    //unchecks "No Topping"
                    checkBoxNoTop.Checked = false;

                    //Adds topping to Toppings ListBox and clears the selection
                    listBoxToppings.Items.Add(listBoxVeg.SelectedItem);
                    listBoxVeg.ClearSelected();
                }
            }

        }

        /// <summary>
        /// Closes the Create form and brings the user back to the Navigation Form
        /// </summary>
        /// <param name="sender">control initiating event</param>
        /// <param name="e">event argument</param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Removes a selected topping From the Toppings ListBox. Prints 
        /// a prompt if no topping has been selected to remove.
        /// </summary>
        /// <param name="sender">control initiating event</param>
        /// <param name="e">event argument</param>
        private void buttonRemoveTop_Click(object sender, EventArgs e)
        {
            //checks that the Toppings ListBox has a selection

            //TODO: remove bug in case where user clicks the 'Remove
            //Topping' button and does not choose to select an item
            //and remove it, leaving the error message in the 
            //message label.
            if (listBoxToppings.SelectedIndex == -1)
            {
                labelMessage.Text = "Please select an Item to remove";
            }

            else
            {
                //removes the selected item from the list
                listBoxToppings.Items.Remove(listBoxToppings.SelectedItem);

                //resets the message box to empty
                labelMessage.ResetText();
            }
        }


        /// <summary>
        /// Clears all controls, resets default values, and returns focus to
        /// the quantity text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            //clears the toppings ListBox
            listBoxToppings.Items.Clear();
            //resets the Quantity TextBox
            textBoxQty.ResetText();

            //Preselects RadioButtons "Large", "Original", and "Red"
            //for UX, since these are the most ordered items
            radioButtonLarge.Checked = true;
            radioButtonOriginal.Checked = true;
            radioButtonRed.Checked = true;

            //puts focus on the Quantity TextBox
            textBoxQty.Focus();
        }




    }
}
