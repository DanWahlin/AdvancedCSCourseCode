using System;
using System.Diagnostics;

using List = Chapter2.LinkedListDemo.CustomLinkedList<int, string>;

namespace Chapter2.ListDemo
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
