using System;
using System.Collections;
using System.Collections.Specialized;
using System.Text;

namespace Chapter2.ContextUtilDemo
{
    class CollectionsUtilDemo
    {
        static void Main()
        {
            Hashtable cart = CollectionsUtil.CreateCaseInsensitiveHashtable();
            cart.Add("ID-1234", "Harry Potter");
            cart.Add("ID-5435", "Star Wars");
            cart.Add("ID-3432", "Lord of the Rings");

            if (cart.Contains("id-1234"))
            {
                Console.WriteLine("Harry Potter is found in the collection");
            }

            Console.Read();
        }
    }
}
