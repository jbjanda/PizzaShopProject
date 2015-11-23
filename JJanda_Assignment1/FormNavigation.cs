/*
 * --------------------------------------------------------------------------
 * Developer: Jeff Janda
 * 
 * Program Name: Assignment 5, Database integration Locations and Definition Class.
 * 
 * Current Version adds Location Maintenance and State Maintenance to the form.
 * Changes to the Navigation form are: the introduction of a Maintenance Menu option
 * in the menu bar with two selections; Log-in and Log-out, an addition to the Menu Bar
 * under Forms, Locations Maintenance and States Maintenance; and the addition of a public
 * static variable, 'administrator' which serves as a flag to determine if a user has
 * admin rights to the system.
 * 
 * Navigation loads with Log-in enabled and Log-out, Locations Maintenance, and States 
 * Maintenance disabled. Those features are enabled if a user successfully logs in using
 * the Admin Form.
 * 
 * Note: This program still uses the original namespace from the original 
 * iteration
 * 
 * Section: Navigation Form
 * 
 * Date: 11/11/15
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
using System.IO;
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
        /// Global variable used for granting administrator rights in the
        /// Location Maintenance Form and the State Maintenance Form.
        /// Value is initially set to false which prevents users from having
        /// access to the Locations Maintenance Forms, States Maintenance Forms
        /// and Log-out Menu Item.
        /// </summary>
        public static bool administrator = false;


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
            try
            {
                FormConfirmation myConfirmation = new FormConfirmation();
                myConfirmation.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show("No ordered Items");
            }
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

        /// <summary>
        /// Opens the Customer Form
        /// </summary>
        /// <param name="sender">control initiating event</param>
        /// <param name="e">event argument</param>
        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCustomer myCustomerForm = new FormCustomer();
            myCustomerForm.ShowDialog();
        }

        /// <summary>
        /// Opens the Locations Form
        /// </summary>
        /// <param name="sender">Control Initiating Event</param>
        /// <param name="e">Event Argument</param>
        private void buttonLocation_Click(object sender, EventArgs e)
        {
            FormLocations myLocations = new FormLocations();

            myLocations.ShowDialog();
        }


        /// <summary>
        /// Opens the Admin Form. If the administrator is true it allows access
        /// to the admin menu items on the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Creates a Admin Form variable and opens the form.
            FormAdmin myFormAdmin = new FormAdmin();
            myFormAdmin.ShowDialog();

            // Checks if administrator flag has been changed to true.
            if (administrator)
            {
                // Enables admin Menu items on the Navigation Form (see below)
                adminForm();
            }
        }

        /// <summary>
        /// Sets all Navigation Form features to the original loaded state
        /// </summary>
        public void defaultForm()
        {
            // Log-In enabled Log-out disabled
            loginToolStripMenuItem.Enabled = true;
            logoutToolStripMenuItem.Enabled = false;
            // Location Maintenance and States Maintenance disabled
            locationMaintenanceToolStripMenuItem.Enabled = false;
            statesMaintenanceToolStripMenuItem.Enabled = false;

            // Sets administrator flag back to false;
            administrator = false;
        }

        /// <summary>
        /// Sets all Navigation Form features to the Admin Form state
        /// </summary>
        public void adminForm()
        {
            // Log-in disabled, Log-out enabled
            loginToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Enabled = true;
            // Location Maintenance and States Maintenance enabled
            locationMaintenanceToolStripMenuItem.Enabled = true;
            statesMaintenanceToolStripMenuItem.Enabled = true;
        }

        /// <summary>
        /// Allows a user to Log-out of the admin form and set
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            defaultForm();
        }

        private void locationMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLocationMaint myFormLocationMaint = new FormLocationMaint();

            //if(PizzaShopDB!=null)
            myFormLocationMaint.ShowDialog();
        }

        private void statesMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStateMaint myFormStMaint = new FormStateMaint();

            myFormStMaint.ShowDialog();
        }

        private void openData(string FileName)
        {
            if (File.Exists(FileName))//check file exists
            {
                //clearData();
                StreamReader myFile = new StreamReader(FileName);

                try
                {
                    string input;
                   
                    while (!myFile.EndOfStream)
                    {
                        input = myFile.ReadLine();
                    }
                }
                catch (Exception ex)
                {

                    labelMessage.Text= "File Exception " + ex.Message + " File error (write)";
                }
                finally
                {
                    myFile.Close();
                }
            }
            else
            {
                labelMessage.Text= "File " + FileName + " does not exist " + " error";
            }
        }

        private void FormNavigation_Load(object sender, EventArgs e)
        {

        }





    }
}
