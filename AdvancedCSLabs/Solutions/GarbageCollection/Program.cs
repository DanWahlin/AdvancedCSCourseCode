using System;

namespace GarbageCollection
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			GC.Collect();
			Console.WriteLine("Total bytes before allocation: {0}", GC.GetTotalMemory(false));
			Customer cust = new Customer();
			Console.WriteLine("Total bytes after allocation: {0}", GC.GetTotalMemory(false));
			Console.WriteLine("Object is at generation {0}", GC.GetGeneration(cust));
			Console.WriteLine("Collect");
			GC.Collect();
			Console.WriteLine("Total bytes after collection: {0}", GC.GetTotalMemory(false));
			Console.WriteLine("Object is at generation {0}", GC.GetGeneration(cust));
			Console.WriteLine("Deallocating object");
			cust = null;
			Console.WriteLine("Collect");
			GC.Collect();
			Console.WriteLine("Total bytes after collection: {0}", GC.GetTotalMemory(false));
			Console.WriteLine("Collect");
			GC.Collect();
			Console.WriteLine("Total bytes after collection: {0}", GC.GetTotalMemory(false));
			
            Console.Read();
		}
	}
}
