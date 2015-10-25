/*------------------------------------------------------------------------------------
 * Developer: Jeff Janda
 * Program Name: Assignment 3, Item Class
 * Date 10/7/15
 * COP 2361
 * -----------------------------------------------------------------------------------
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJanda_Assignment1
{
    /// <summary>
    /// Item class holds and reports information about a menu Item. Its properties
    /// are an item Description, the number of Items selected, a Size, what type of 
    /// Crust, and the Price.
    /// </summary>
    public class Item
    {
        // field variables
        private string _description;
        private int _quantity;
        private string _size;
        private string _crust;
        private decimal _price;
    
        /// <summary>
        /// Default Constructor. Creates an Item object with empty values.
        /// </summary>
        public Item()
        {
            _description = string.Empty;
            _quantity = 0;
            _size = string.Empty;
            _crust = string.Empty;
            _price = 0;
        }

        /// <summary>
        /// Overloaded customer constructor.
        /// </summary>
        /// <param name="pDescription">Description</param>
        /// <param name="pQuantity">Quantity</param>
        /// <param name="pSize">Size</param>
        /// <param name="pCrust">Crust</param>
        /// <param name="pPrice">Price</param>
        public Item(string pDescription, int pQuantity, string pSize, 
                    string pCrust, decimal pPrice)
        {
            Description = pDescription;
            Quantity = pQuantity;
            Size = pSize;
            Crust = pCrust;
            Price = pPrice;
        }

        /// <summary>
        /// Item destructor.
        /// </summary>
        ~Item()
        {
            _description = string.Empty;
            _quantity = 0;
            _size = string.Empty;
            _crust = string.Empty;
            _price = 0;
        }
        /// <summary>
        /// Description property methods
        /// </summary>
        public string Description
        {
            get { return _description; }

            set { _description = value.Trim(); }
        }

        /// <summary>
        /// Quantity property methods
        /// </summary>
        public int Quantity
        {
            get { return _quantity; }

            set { _quantity = value; }
        }

        /// <summary>
        /// Size property methods
        /// </summary>
        public string Size
        {
            get { return _size; }

            set { _size = value.Trim(); }
        }

        /// <summary>
        /// Crust property methods
        /// </summary>
        public string Crust
        {
            get { return _crust; }

            set { _crust = value.Trim(); }
        }

        /// <summary>
        /// Price property methods
        /// </summary>
        public decimal Price
        {
            get { return _price; }

            set { _price = value; }
        }

        /// <summary>
        /// Creates a string representation of an Item object formatted
        /// as an Item order summary. Calls the figureTotalPrice method to 
        /// determine the total of the order. Provides a different string 
        /// format based on whether a user orders a single or multiple Items.
        /// </summary>
        /// <returns>A string representation of an Item object</returns>
        public override string ToString()
        {
            //message variable holds string information about Item object
            string message;


            //Condition if Item has a quantity of one
            if (Quantity == 1)
            {
                //formats Item information into a summary for a single Item
                message = Quantity + " " + Size + " sized " + Description + " "
                        + Crust + " crust pizza for a total of " 
                        + Price.ToString("c");                        
            }

            //condition if Item as a quantity of more than one
            else  
            {
                //formats Item information into a summary for multiple Items
                message = Quantity + " " + Size + " sized " + Description + " "
                        + Crust + " crust pizzas for a total of " + Price.ToString("c");         
            }
          

            //returns the message based on the above conditions
            return message;
        }

        /// <summary>
        /// Calculate Price method accepts a default parameter which is set
        /// to $0.00 in order to add variable prices to an Item order. Base
        /// price is deterimined by the Size and Quantity Properties.
        /// </summary>
        /// <param name="pAddOnPrice">An additional expense added to an 
        ///                           Item Price</param>
        public void CalculatePrice(decimal pAddOnPrice = 0m)
        {
            if(Size =="Large")
            {
                Price = Quantity * (10.00m + pAddOnPrice);
            }
            else if (Size =="Family")
            {
                Price = Quantity * (13.00m + pAddOnPrice);
            }
         }
     
        
    }
}
