using System;
using System.Collections.Generic;

namespace Chapter2.Collections
{
    public class GenericPersonComparer : IComparer<Person> {

        //Less than zero - x is less than y. 
        //Zero - x equals y. 
        //Greater than zero - x is greater than y. 

		public int Compare(Person x, Person y) {
			return string.Compare(x.FirstName, y.FirstName);
		}
    }
}
