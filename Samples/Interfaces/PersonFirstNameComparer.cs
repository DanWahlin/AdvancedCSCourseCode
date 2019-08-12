using System;
using System.Collections;

namespace Chapter2.Collections
{
    public class PersonFirstNameComparer : IComparer {

        //Less than zero - x is less than y. 
        //Zero - x equals y. 
        //Greater than zero - x is greater than y. 

		public int Compare(object x, object y) {
			Person perX = (Person)x;
			Person perY = (Person)y;
			return string.Compare(perX.FirstName, perY.FirstName);
		}
    }

    public class Person
    {
        private string _FirstName;

        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        private string _LastName;

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

    }
}
