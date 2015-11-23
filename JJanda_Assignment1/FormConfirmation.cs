/*
 * --------------------------------------------------------------------------
 * Developer: Jeff Janda
 * 
 * Program Name: Assignment 4, Modified Pizza Shop and Games Class
 * Note: This program still uses the original namespace from the original 
 * iteration
 * 
 * Section: Confirmation Form 
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

namespace JJanda_Assignment1
{
    /// <summary>
    /// The confirmation form is used to display the Item ordered by the customer
    /// in the Create Your Own Form.
    /// </summary>
    public partial class FormConfirmation : Form
    {
        //variable used to hold the value of the Item passed by the
        //Create Your Own Form.
        private Item myItem;


        /// <summary>
        /// Confirmation Form Constructor
        /// </summary>
        public FormConfirmation()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Overloaded Constructor that allows an Item to be passed to the
        /// Confirmation Form.
        /// </summary>
        /// <param name="myItem">An Item Object</param>
        public FormConfirmation(Item myItem)
        {

            InitializeComponent();

            ///Item created in Create Your Own Form
            this.myItem = myItem;

        }
        /// <summary>
        /// Confirmation Form load event passes the Item created in 
        /// the Create your own form and displays the Item 
        /// </summary>
        /// <param name="sender">control initiating event</param>
        /// <param name="e">event argument</param>
        private void FormConfirmation_Load(object sender, EventArgs e)
        {
            try
            {
                //loads the Item string representation to the Message Label.
                labelMessage.Text = myItem.ToString();
            }
            //prevents an error if no Item is passed to the form load.
            catch (Exception ex)
            {
                //error message printed to user.
                labelMessage.Text = "You have no orders.";

            }
        }

        /// <summary>
        /// Closes the Confirmation Form and returns the user to the Create
        /// Your Own Form
        /// </summary>
        /// <param name="sender">control initiating event</param>
        /// <param name="e">event argument</param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
