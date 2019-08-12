using System;
using System.Collections;

namespace Chapter2.Collections
{
	public class ArrayListDemo2 {
		public static void Main() {
			ArrayList namesList= new ArrayList();
			namesList.Add("Fred");
			namesList.Add("Val");
			namesList.Add("Ted");
			namesList.Add("Albert");
			namesList.Add("Zeus");

			//Sort ArrayList
			Console.WriteLine("Sorting names...");
			namesList.Sort();

			//Iterate using For..Each
			foreach (object name in namesList) {
				Console.WriteLine(name);
			}
			Console.WriteLine("");

			//Do a binarysearch
			Console.WriteLine("Searching for Ted...");
			if (namesList.BinarySearch("Ted") > 0) {
				Console.WriteLine("Ted found!");
			} else {
				Console.WriteLine("Ted not found!");
			}

			Console.ReadLine();
		}
    }
}
