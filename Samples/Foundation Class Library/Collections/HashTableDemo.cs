using System;
using System.Collections;

namespace Chapter2.Collections
{
    public class HashTableDemo {
        public static void Main() {
            //Demonstrates key/value pairs with HashTable
            Hashtable hash = new Hashtable();
            Person per1 = new Person();
            per1.FirstName = "John";
            per1.LastName = "Doe";

            Person per2 = new Person();
            per2.FirstName = "Barbara";
            per2.LastName = "Thomas";

            //Add people to hash
            //This implementation of Object.GetHashCode can only guarantee 
            //that the same hash code will be returned for the same instance; 
            //it cannot guarantee that different instances will have different 
            //hash codes or that two objects referring to the same value will 
            //have the same hash codes.

            Console.WriteLine("Adding key: " + per1.GetHashCode());
            hash.Add(per1.GetHashCode(), per1);
            Console.WriteLine("Adding key: " + per2.GetHashCode());
            hash.Add(per2.GetHashCode(), per2);

            //Iterate through keys
            Console.WriteLine("Iterating through keys..");
            foreach (object key in hash.Keys) {
                Person per = (Person)hash[key];
				Console.WriteLine(per.FirstName + " " + per.LastName);
			}

            Console.WriteLine("\r\nIterating through values..");
            foreach (object val in hash.Values) {
                 Person per = (Person)val;
				Console.WriteLine(per.FirstName + " " + per.LastName);
			}

            Console.ReadLine();
        }
    }
}
