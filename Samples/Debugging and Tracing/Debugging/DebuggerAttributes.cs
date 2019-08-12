using System;
using System.Diagnostics;

namespace DebuggingAndTracing.Debugging
{
    class DebuggerAttributes
    {
        static void Main()
        {
            Person p = new Person();
            p.SSN = 123456789;
            p.Name = "John Doe";
            p.Address = new Address("12354 Anywhere St.");
            bool status = p.SSNValid();
            Console.Read();
        }
    }

    [DebuggerDisplay("{_Name}: {_SSN}")]
    public class Person
    {
        private int? _SSN;
        private string _Name;
        private Address _Address;

        public int? SSN
        {
            get { return _SSN; }
            set { _SSN = value; }
        }


        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public Address Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        [DebuggerHidden]
        public bool SSNValid()
        {
            if (_SSN != null)
            {
                return true;
            }
            return false;
        }
		
    }

    [DebuggerStepThrough]
    public class Address
    {
        public Address() { }
        public Address(string street)
        {
            this.Street = street;
        }

        private string _Street;

        public string Street
        {
            get { return _Street; }
            set { _Street = value; }
        }	
    }
}
