/*
 * --------------------------------------------------------------------------
 * Developer: Jeff Janda
 * Program Name: Assignment 4, Modified Pizza Shop and Games Class
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
    /// Navigation form directs users through pizza ordering process.
    /// Users can select to go to any of the forms usinig the Menu bar
    /// at the top or by using the buttons in the form.
    /// </summary>
    public partial class FormNavigation : Form
    {
        public FormNavigation()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens a Create Your Own Form
        /// </summary>
        /// <param name="sender">event handler</param>
        /// <param name="e">event argument</param>
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            FormCreate myFormCreate = new FormCreate();
            myFormCreate.ShowDialog();
        }
        /// <summary>
        /// Opens a Customer Form
        /// </summary>
        /// <param name="sender">event handler</param>
        /// <param name="e">event argument</param>
        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            FormCustomer myCustomerForm = new FormCustomer();
            myCustomerForm.ShowDialog();
        }

        /// <summary>
        /// Closes the Navigation Form and Exits the application
        /// </summary>
        /// <param name="sender">event handler</param>
        /// <param name="e">event argument</param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }



        /// <summary>
        /// Takes user to the original pizza shop order form no longer being used.
        /// Functionality remains for possible future development cycles.
        /// </summary>
        /// <param name="sender">event handler</param>
        /// <param name="e">event argument</param>
        private void buttonOrder_Click(object sender, EventArgs e)
        {
            PizzaShop myPizzaShop = new PizzaShop();
            myPizzaShop.ShowDialog();
        }

        /// <summary>
        /// Opens the Confirmation Form
        /// </summary>
        /// <param name="sender">event handler</param>
        /// <param name="e">event argument</param>
        private void confirmationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConfirmation myConfirmation = new FormConfirmation();
            myConfirmation.ShowDialog();
        }

        /// <summary>
        /// Opens a message box that gives the user information about the
        /// pizza shop program.
        /// </summary>
        /// <param name="sender">event handler</param>
        /// <param name="e">event argument</param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Prints information about the program.
            string aboutMessage = "Pizza Shop Application" + Environment.NewLine
            + "version 2.1, 10/28/2015" + Environment.NewLine
            + "Written by Jeff Janda";

            MessageBox.Show(aboutMessage);

        }





    }
}
