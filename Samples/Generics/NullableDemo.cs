using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter3
{
    class NullableDemo
    {
        public static void Main()
        {
            //Nullable<DateTime> can be used in place of the ? shortcut character if desired
            DateTime? nullableDateTime = null;
            if (nullableDateTime.HasValue)
            {
                Console.WriteLine("Nullable type has value of: " + nullableDateTime.Value.ToLongDateString());
            }
            else
            {
                Console.WriteLine("Nullable type has a null value.");
            }
            Console.WriteLine("Default value of nullable type: " + default(DateTime));


            //Nullable types can also be compared to null directly
            DateTime? nullableDateTime2 = DateTime.MaxValue;
            if (nullableDateTime2 != null)
            {
                Console.WriteLine("Nullable type has value of: " + nullableDateTime2.Value.ToLongDateString());
            }
            else
            {
                Console.WriteLine("Nullable type compared to null and has a null value.");
            }

            //Demonstrate ?? C# operator
            //Nullable<int> can be used in place of the ? shortcut character if desired
            int? x = null;
            int y = x ?? -1;
            Console.WriteLine("Y=" + y);

            //Can also use ?? with reference types
            string name = null;
            string output = name ?? "John Doe";
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
