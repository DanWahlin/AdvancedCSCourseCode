using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter4.Interfaces
{
    public class Address
    {
        private string _Street;
        private string _City;
        private string _State;

        public string Street
        {
            get { return _Street; }
            set { _Street = value; }
        }

        public string City
        {
            get { return _City; }
            set { _City = value; }
        }

        public string State
        {
            get { return _State; }
            set { _State = value; }
        }	
    }
}
