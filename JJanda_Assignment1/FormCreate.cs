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
    public partial class FormCreate : Form
    {
        List<string> toppingList = new List<string>();
        
        string description = string.Empty;

        const decimal TOPPING_COST = 0.30m;

        public string FormatDescription(string pToppings)
        {
            if (description == string.Empty)
            {
                description = pToppings;
            }
            else
            {
                description += ", " + pToppings;
            }

            return description;
        }

        public decimal CalculateToppingsPrice(int ToppingCount)
        {
            decimal total;
            total = TOPPING_COST * ToppingCount;
            return total;
        }

        /// <summary>
        /// Check RadioBox In Group runs through each GroupBox and 
        /// checks to see if a RadioBox has been selected. .
        /// </summary>
        /// <param name="box">a GroupBox Control</param>
        /// <returns>True if an item is checked, false otherwise.</returns>
        public bool CheckedRadioBoxInGroup(GroupBox box)
        {
            bool anythingChecked = false;

            foreach (RadioButton rb in box.Controls)
            {

                if (rb.Checked) anythingChecked = true;
            }

            return anythingChecked;
        }

        private bool DataIsValid()
        {
            //creates an output variable for the Quanity Tryparse validation
            int qty;

            //flag returned at the end. Initialized to false.
            bool isValid = false;


            //declares a variable to hold the value of the
            //Check RadioBox in Group method

            if (!CheckedRadioBoxInGroup(groupBoxSize))
            {
                labelMessage.Text = "Please select a size";
            }

            else if (!CheckedRadioBoxInGroup(groupBoxCrust))
            {
                labelMessage.Text = "Please select a crust";
            }

            else if (!CheckedRadioBoxInGroup(groupBoxSauce))
            {
                labelMessage.Text = "Please select a sauce";
            }


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

            else
            {

                //sets isValid to true
                isValid = true;
                labelMessage.ResetText();

            }

            //labelMessage.Text  = isValid.ToString();
            return isValid;
        }



        public FormCreate()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Upon loading, the Create Your Own Form, presets the meat, sauce and 
        /// cheese ListBoxes with the items in the respective radio boxes. This 
        /// also preselects the red sauce, original crust, and large size radio
        /// boxes, since these are the most ordered items by Jeff's Pizza shop. 
        /// </summary>
        /// <param name="sender">event handler</param>
        /// <param name="e">event argument</param>
        private void FormCreate_Load(object sender, EventArgs e)
        {

            try
            {
                //generic counter variable used to fill the toppings ListBoxes
                int count = 0;

                //creates an array of meat toppings available for order
                //TODO: Develop functionality to populate the array using a file
                string[] meat = {"Pepperoni", "Sausage", "Ground Beef", "Bacon",
                            "Canadian Bacon", "Chicken", "Salami", "Anchovies"};

                //populates the Meat toppings ListBox
                foreach (string topping in meat)
                {
                    listBoxMeat.Items.Add(meat[count]);
                    count++;
                }

                //creates an array of vegetable toppings available for order
                //TODO: Develop functionality to populate the array using a file
                string[] veg = {"Tomatoes", "Pineapple", "Sun-dried Tomatoes",
                           "Mixed Onions", "Green Olives", "Green Peppers",
                           "Mushrooms", "Black Olives", "Zucchini", 
                           "Artichoke Hearts", "Spinach", "Garlic", "Jalapenos",
                           "Banana Peppers"};

                //resets the counter
                count = 0;

                //populates the Vegetable toppings ListBox
                foreach (string topping in veg)
                {
                    listBoxVeg.Items.Add(veg[count]);
                    count++;
                }

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

                //Preselects RadioButtons "Large", "Original", and "Red"
                //for UX, since these are the most ordered items
                radioButtonLarge.Checked = true;
                radioButtonOriginal.Checked = true;
                radioButtonRed.Checked = true;
            }
            catch (Exception ex)
            {

                labelMessage.Text = "Error Message: " + ex.Message;
            }


        }

        /// <summary>
        /// Submits a pizza order and takes the user to the confirmation screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (DataIsValid())
            {
                Item myItem = new Item();

                foreach (RadioButton rb in groupBoxSize.Controls)
                {

                    if (rb.Checked)
                    {
                        Debug.Print(rb.Text);

                        myItem.Size = rb.Text.Remove(rb.Text.IndexOf("$")).Trim();
                        Debug.Print(myItem.Size);
                    }
                }

                foreach (RadioButton rb in groupBoxSauce.Controls)
                {

                    if (rb.Checked)
                    {
                       FormatDescription(rb.Text + " sauce");
                    }
                }

                foreach (RadioButton rb in groupBoxCrust.Controls)
                {

                    if (rb.Checked)
                    {
                        myItem.Crust = rb.Text;
                    }
                }

                foreach (string topping in listBoxToppings.Items) 
                {
                    myItem.Description = FormatDescription(topping);                                      
                }
              

                //assigns the quantity amount entered to the Item's Quantity Property
                myItem.Quantity = int.Parse(textBoxQty.Text);

                myItem.CalculatePrice(CalculateToppingsPrice
                                                     (listBoxToppings.Items.Count)); 

             

               

                FormConfirmation myConfirmation = new FormConfirmation(myItem);
                myConfirmation.ShowDialog();
            }
        }

        private void buttonRemoveAll_Click(object sender, EventArgs e)
        {
            listBoxToppings.Items.Clear();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (listBoxCheese.SelectedIndex == -1 && listBoxVeg.SelectedIndex == -1 &&
                listBoxMeat.SelectedIndex == -1 && !checkBoxNoTop.Checked)
            {
                labelMessage.Text = "Please select a topping or check 'No Toppings'.";
            }

            else
            {
                if (listBoxMeat.SelectedIndex > -1)
                {
                    listBoxCheese.ClearSelected();
                    listBoxVeg.ClearSelected();
                    checkBoxNoTop.Checked = false;
                    listBoxToppings.Items.Add(listBoxMeat.SelectedItem);
                    listBoxMeat.ClearSelected();
                }

                if (listBoxCheese.SelectedIndex > -1)
                {
                    listBoxMeat.ClearSelected();
                    listBoxVeg.ClearSelected();
                    checkBoxNoTop.Checked = false;
                    listBoxToppings.Items.Add(listBoxCheese.SelectedItem);
                    listBoxCheese.ClearSelected();
                }

                if (listBoxVeg.SelectedIndex > -1)
                {
                    listBoxMeat.ClearSelected();
                    listBoxCheese.ClearSelected();
                    checkBoxNoTop.Checked = false;
                    listBoxToppings.Items.Add(listBoxVeg.SelectedItem);
                    listBoxVeg.ClearSelected();
                }
            }

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonRemoveTop_Click(object sender, EventArgs e)
        {
            if (listBoxToppings.SelectedIndex == -1)
            {
                labelMessage.Text = "Please select an Item to remove";
            }

            else
            {
                listBoxToppings.Items.Remove(listBoxToppings.SelectedItem);
            }
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButtonLarge.Checked = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxToppings.Items.Clear();
            labelMessage.ResetText();
        }




    }
}
