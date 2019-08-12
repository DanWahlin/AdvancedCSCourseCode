using System;
using System.Globalization;
namespace Chapter2.DateTimeDemo {
    public class DateTimeDemo {
        public static void Main() {
            string futureDate = "01/05/2010";
            System.DateTime today = System.DateTime.Now;
            Console.WriteLine("Today is : " + today.ToShortDateString());
            Console.WriteLine("Current time is: " + today.ToShortTimeString());
            Console.WriteLine("A week from now is: " + 
                today.AddDays(7).ToShortDateString());
            Console.WriteLine("Day is: " + today.DayOfWeek.ToString());

            //Parse date and write out the year component
            Console.WriteLine("\r\nFuture Date Year: ");
            Console.WriteLine(System.DateTime.Parse(futureDate).Year.ToString());
            //Generate custom format
            Console.WriteLine(System.DateTime.Parse(futureDate).ToString("dddd, MMMM yyyy "));
            //TryParseExact()
            DateTime date;
            bool status = DateTime.TryParseExact("Nov 21 11:34:17 2010", "MMM d HH:mm:ss yyyy", null, DateTimeStyles.AllowInnerWhite | DateTimeStyles.AllowWhiteSpaces, out date);
            if (status)
            {
                Console.WriteLine(date.ToLongDateString());
            }
            else
            {
                Console.WriteLine("Unable to write out date using TryParseExact()");
            }
            Console.ReadLine();
        }
    }
}
