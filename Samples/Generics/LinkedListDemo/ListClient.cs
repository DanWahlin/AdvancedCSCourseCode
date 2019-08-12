using System;
using System.Diagnostics;

using List = Chapter3.LinkedListDemo.LinkedList<int, string>;

namespace Chapter3.ListDemo
{
	class ListClient
	{
		static void Main(string[] args)
		{
         List list = new List();

         list.AddHead(123,"AAA");
         list.AddHead(456,"BBB");

         string item = list[456];

         Debug.Assert(item == "BBB");
      }
	}
}
