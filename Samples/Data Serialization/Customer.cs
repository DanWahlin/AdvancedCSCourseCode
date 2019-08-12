using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Chapter8
{
    [Serializable]
    [XmlRoot("AcmeCustomer")]
    //Add namespace for elements
    [XmlType("Test",Namespace = "http://www.interfacett.com")]
    public class Customer
    {
        private string _FirstName;
        private string _LastName;
        private string _SSN;
        private Guid _ID;
        private List<string> _PhoneNumbers;

        public Customer()
        {
            //Demonstrate private properties
            this.SSN = "123456789";
        }

        [XmlElement("CustomerFirstName")]
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        [XmlElement("CustomerLastName")]
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        private string SSN
        {
            get { return _SSN; }
            set { _SSN = value; }
        }

        [XmlAttribute("CustomerID")]
        public Guid ID
	    {
		    get { return _ID;}
		    set { _ID = value;}
	    }

        [XmlArray("ContactNumbers")]
        [XmlArrayItem("Number")]
        public List<string> PhoneNumbers
        {
            get { return _PhoneNumbers; }
            set { _PhoneNumbers = value; }
        }
    }
}
