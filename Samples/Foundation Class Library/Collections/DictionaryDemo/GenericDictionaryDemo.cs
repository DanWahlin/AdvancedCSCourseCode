using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter2.DictionaryDemo
{
    class GenericDictionaryDemo
    {
        static void Main()
        {
            Dictionary<string, int> peopleAges = new Dictionary<string, int>();
            peopleAges.Add("Tony", 45);
            peopleAges.Add("Dave", 32);
            peopleAges.Add("Michelle", 17);

            foreach (string key in peopleAges.Keys)
            {
                Console.WriteLine(key + " " + peopleAges[key].ToString());
            }

            Console.WriteLine();
            Console.WriteLine("Sorted Dictionary Items...");

            SortedDictionary<string, int> peopleAgesSorted = new SortedDictionary<string, int>();
            peopleAgesSorted.Add("Tony", 45);
            peopleAgesSorted.Add("Dave", 32);
            peopleAgesSorted.Add("Michelle", 17);
            SortedDictionary<string,int>.Enumerator e = peopleAgesSorted.GetEnumerator();

            while (e.MoveNext())
            {
                Console.WriteLine(e.Current.Key + " " + e.Current.Value.ToString());
            }

            Console.Read();
        }
    }
}
