using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJanda_Assignment1
{
    /// <summary>
    /// Address class holds the general street address information for 
    /// a location. 
    /// 
    /// NOTE: This class replicates information from the Location Class.
    /// This class implemented to showcase inheritance with the BusinessAddress
    /// class.
    /// </summary>
    class Address
    {
        private string _streetAddress;

        public string StreetAddress
        {
            get { return _streetAddress; }
            set { _streetAddress = value; }
        }
        private string _unit;

        public string Unit
        {
            get { return _unit; }
            set { _unit = value; }
        }
        private string _city;

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        private string _state;

        public string State
        {
            get { return _state; }
            set { _state = value; }
        }
        private string _zipCode;

        public string ZipCode
        {
            get { return _zipCode; }
            set { _zipCode = value; }
        }

        public Address()
        {
            throw new System.NotImplementedException();
        }

        public Address(string pStreetAddress, string pUnit, string pCity, string pState, string pzipCode)
        {
            throw new System.NotImplementedException();
        }

        ~Address()
        {
            throw new System.NotImplementedException();
        }

        public string ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}
