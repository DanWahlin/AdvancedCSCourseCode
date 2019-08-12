using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Chapter2.RegularExpressions
{
    class RegexSimple
    {
        public static void Main()
        {
            //This example uses the Regex class to parse out the numbers
            //found in a phone number entered by an end user.
            string newPhoneNumber = null;           
            string phoneNumber = "(123) 456-7890";
            string pattern = "[0-9]*";
            Regex reg = new Regex(pattern, RegexOptions.Singleline |
                RegexOptions.Compiled);
            MatchCollection matches = reg.Matches(phoneNumber);
            foreach (Match m in matches) {
                if (m.Success) {
                    newPhoneNumber += m.Value.ToString();
                }
            }
            Console.WriteLine("Corrected phone number: " + newPhoneNumber);
            Console.ReadLine();
        }
    }
}
