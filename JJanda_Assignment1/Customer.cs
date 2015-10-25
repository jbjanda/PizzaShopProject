﻿/*
 * --------------------------------------------------------------------------
 * Developer: Jeff Janda
 * Program Name: Assignment 2, Customer Class
 * Date: 9/23/15
 * ---------------------------------------------------------------------------
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace JJanda_Assignment1
{
    /// <summary>
    /// The Customer class holds and reports information about a customer.
    /// Its only methods are Constructors (default and overloaded), 
    /// a Destructor, Property Gets/Sets, and an overriden ToString(). 
    /// </summary>

    class Customer
    {
        #region Fields and Properties
        //field variable for Customer first name  
        private string _firstName;

        //FirstName property methods
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value.Trim(); }
        }

        //field variable for Customer last name
        private string _lastName;

        //LastName property methods
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value.Trim(); }
        }

        //field variable for Customer phone number
        private string _phoneNumber;

        //PhoneNumber property methods
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value.Trim(); }
        }
        #endregion

        # region Constructor and Destructor
        /// <summary>
        /// Default Constructor. Creates a Customer object with empty values.
        /// </summary>
        public Customer()
        {
            _firstName = string.Empty;
            _lastName = string.Empty;
            _phoneNumber = string.Empty;
        }

        /// <summary>
        /// Overloaded Customer constructor. 
        /// </summary>
        /// <param name="pFirstName">First Name parameter</param>
        /// <param name="pLastName">Last Name parameter</param>
        /// <param name="pPhoneNumber">Phone Number parameter</param>
        public Customer(string pFirstName, string pLastName,
                                string pPhoneNumber)
        {
            FirstName = pFirstName;
            LastName = pLastName;
            PhoneNumber = pPhoneNumber;
        }
        /// <summary>
        /// Destructor; sets all attributes to null
        /// </summary>
        ~Customer()
        {
            _firstName = null;
            _lastName = null;
            _phoneNumber = null;
        }
        #endregion

        /// <summary>
        /// Creates a string representation of a Customer object formatted
        /// as a customer information summary.
        /// </summary>
        /// <returns>A string representation of a Customer object</returns>
        public override string ToString()
        {
            //message variable holds string information about Customer object
            string message;

            //formats Customer object information into a information summary
            //phone number calls the FormatPhoneNumber method to format
            //in an approved form.
            message = "Name: " + FirstName + " " + LastName + Environment.NewLine +
               "Phone Number: " + formatPhoneNumber(PhoneNumber);

            //returns the summary
            return message;
        }


        /// <summary>
        /// Formats a phone number into the form 111-222-3333.
        /// Assumes data from parameter is validated to contain
        /// 10 digits.
        /// </summary>
        /// <param name="pPhoneNumber">Takes in string phone number validated to have 10 digits</param>
        /// <returns>formatted phone number</returns>
        private string formatPhoneNumber(string pPhoneNumber)
        {
            //variable reference to hold the formatted phone number
            string formattedNumber;
            //assignment of argument data to formattedNumber
            formattedNumber = pPhoneNumber;

            /*-------------------------------------------------------
             * The following algorithm moves through the string array
             * and replaces any character that is not a digit with 
             * an empty string character.
             * -----------------------------------------------------*/



            try
            {
                foreach (char c in formattedNumber)
                {
                    //if character c is not a digit
                    if (!char.IsDigit(c))
                    {
                        //replaces the character with empty string character
                        formattedNumber = formattedNumber.Replace(c.ToString(), "");
                    }
                }

                //following two statments add formatting to the phonenumber 
                //as (111) 222-3333.
                formattedNumber = formattedNumber.Insert(0, "(");
                formattedNumber = formattedNumber.Insert(4, ") ");
                formattedNumber = formattedNumber.Insert(9, "-");

                //returns the formatted number.
                return formattedNumber;
            }
            catch (Exception ex)
            {
                return "Please enter a valid phone number. " 
                    + Environment.NewLine + ex.Message;
            }

        }
    }
}
