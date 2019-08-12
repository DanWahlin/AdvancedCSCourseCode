using System;
using System.Collections.Generic;

namespace Chapter2.Collections {
    public class GenericListDemo {
		public static void Main() {
            //Demonstrates adding objects to ArrayList
            //This is preferred over using Re/Preserve with an Array
            List<Person> personList = new List<Person>();
            Console.WriteLine("Adding new person - John Doe");
            Person per1 = new Person();
            per1.FirstName = "John";
            per1.LastName = "Doe";

            Console.WriteLine("Adding new person - Jane Doe");
            Person per2 = new Person();
            per2.FirstName = "Jane";
            per2.LastName = "Doe";

            Console.WriteLine("Adding new person - Zito Ziffer");
            Person per3 = new Person();
            per3.FirstName = "Zito";
            per3.LastName = "Ziffer";

            //Add person objects into collection
            personList.Add(per3);
            personList.Add(per2);
            personList.Add(per1);

            personList.Sort(new GenericPersonComparer());
            Console.WriteLine("\r\nIterating through Person objects:");
            foreach (Person person in personList)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName);
            }


            Console.ReadLine();
        }
    }
}
