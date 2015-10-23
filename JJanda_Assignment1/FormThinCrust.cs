/*------------------------------------------------------------------------------------
 * Developer: Jeff Janda
 * Program Name: Assignment 3, Thin Crust Form
 * Date 10/7/15
 * COP 2361
 * -----------------------------------------------------------------------------------
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

namespace JJanda_Assignment1
{
    /// <summary>
    /// Thin Crust Form allows users to enter information specific
    /// to Thin Crust pizzas and create an Item object based on the data entered.
    /// </summary>
    public partial class FormThinCrust : Form
    {
        /// <summary>
        /// Thin Crust Form constructor. 
        /// </summary>
        public FormThinCrust()
        {
            InitializeComponent();
        }

        //constant variable is used to assign to an Item's Thin Crust Property.
        //This variable exists only for users entering items on the 
        //Thin Crust Form.
        const string THIN_CRUST = "Thin";
        
        /// <summary>
        /// Checks that Thin Crust form controls have valid data types and 
        /// have been selected and prints an error message for users.
        /// </summary>
        /// <returns>returns true only if all controls valid</returns>
        private bool dataIsValid()
        {
            //creates an output variable for the Quanity Tryparse validation
            int qty;
            bool isValid = false;

            //Description Property Validation
            //checks the Specials ListBox has a selected item
            if (listBoxSpecials.SelectedIndex == -1)
            {
                //prints error message asking user to select a special
                labelMessage.Text = "Please select a special menu item.";

                //returns focus to Specials ListBox
                listBoxSpecials.Focus();

                //false
                return isValid;
            }

            //Quantity Property Validation
            //checks that Quantity TextBox has a valid data type
            
            else if (!int.TryParse(textBoxQuantity.Text, out qty))
            {
               
                //error message prompting user to enter a quantity
                labelMessage.Text = "Please enter valid quantity.";

                //returns focus to Quantity TextBox and highlights invalid entry
                textBoxQuantity.Focus();
                textBoxQuantity.SelectAll();
                
                //false
                return isValid;
            }
            
            //checks if the text box holds a value of zero
            else if (qty == 0)
            {
                //error message for zero items
                labelMessage.Text = "Did you mean to order zero items?";

                //puts focus on the Quantity TextBox Control
                textBoxQuantity.Focus();

                //highlights input in the Quantity TextBox Control
                textBoxQuantity.SelectAll();

                //false
                return isValid;
            }

                           
            //Size Property validation
            //Checks if either the Large or Family RadioButton has a selected item

            else if (!radioButtonFamily.Checked && !radioButtonLarge.Checked)
            {
                //error message
                labelMessage.Text = "Please select a size.";
                
                //false
                return isValid;
            }
            //sets isValid to true
            isValid = true;

            //true 
            return isValid;
            }
  
        



        /// <summary>
        /// Creates a Item object based on customer input. Validates  user 
        /// input for the correct type or that a selection was made and
        /// prints appropriate error messages prompting the user to correct
        /// invalid data using the dataIsValid method.
        /// 
        /// A successful entry prints an order summary report
        /// to the message Label control.
        /// 
        /// Crust Property set to "Thin Crust" since Item is being created on
        /// the Thin Crust form.
        /// </summary>
        /// <param name="sender">control initiating event</param>
        /// <param name="e">event argument</param>
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
          
            //returns true if all controls selected and 
            if(dataIsValid())
            {
               //creates an Item object
                Item myItem = new Item();
               
               //checks if Large radio button is selected
                if (radioButtonLarge.Checked)
               {
                    //assigns the size to the Item Size Property
                    myItem.Size = "Large";

                    //assigns Large Price times Quantity to Item Price Property
                    myItem.Price = 11.00m * int.Parse(textBoxQuantity.Text);
               }
                //checks if the Family radio button is selected
                else if (radioButtonFamily.Checked)
                {
                    //assigns the size to the Item Size Property
                    myItem.Size = "Family";

                    //assigns Family Price times Quantity to Item Price Property
                    myItem.Price = 13.00m * int.Parse(textBoxQuantity.Text);
                }

               //assigns the selected special to the Item Description Property
               myItem.Description = listBoxSpecials.SelectedItem.ToString();

               //assigns the quantity amount entered to the Item's Quantity Property
               myItem.Quantity = int.Parse(textBoxQuantity.Text);

               //assigns the crust type to the Item's crust Property
               myItem.Crust = THIN_CRUST;

               //prints the order summar by calling the Item ToString method.
               labelMessage.Text = myItem.ToString();        
               
            }

        }
   

        /// <summary>
        /// Clears the form and returns focus to size ComboBox.
        /// </summary>
        /// <param name="sender">control initiating event</param>
        /// <param name="e">event argument</param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            //Clears controls and resets selections.
            textBoxQuantity.Clear();
            listBoxSpecials.ClearSelected();
            labelMessage.ResetText();
            radioButtonLarge.Checked = false;
            radioButtonFamily.Checked = false;
            
            //Returns focus to the Specials ListBox.
            listBoxSpecials.Focus();
        }

        /// <summary>
        /// Closes the form and returns the user to the Main Form.
        /// </summary>
        /// <param name="sender">control intiating event</param>
        /// <param name="e">event argument</param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            //closes the Thin Crust Form
            Close();
        }

       

        
    }
}
