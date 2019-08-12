using System;
using System.Collections.Specialized;
using System.Text;

namespace Chapter2.DictionaryDemo
{
    class HybridDictionaryDemo
    {
        static void Main()
        {
            //Store 9 items in a case-insensitive manner
            HybridDictionary hb = new HybridDictionary(9, true);
            hb.Add(1231, "Tony Smith");
            hb.Add(6541, "Fred Jamison");
            hb.Add(1234, "Michelle Humphries");

            foreach (int key in hb.Keys)
            {
                Console.WriteLine(key.ToString() + " " + hb[key]);
            }
            Console.Read();
        }
    }
}
