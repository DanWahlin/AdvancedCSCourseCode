using System;
using System.Text;
using System.Collections.Generic;

namespace Chapter2.LinkedListDemo
{
    public class LinkedListWordsDemo
    {
        public static void Main()
        {
            string[] words = 
            { "the", "fox", "jumped", "over", "the", "dog" };
            LinkedList<string> sentence = new LinkedList<string>(words);
            Display(sentence);

            Console.WriteLine("sentence.Contains(\"jumped\") = {0}",
                sentence.Contains("jumped"));

            // Add the word "today" to the beginning of the linked list.
            // Remove the new node, and add it to the end of the list.
            sentence.AddFirst("today");
            Display(sentence);

            LinkedListNode<string> mark1 = sentence.First;
            sentence.RemoveFirst();
            sentence.AddLast(mark1);
            Display(sentence);

            sentence.RemoveLast();
            sentence.AddLast("yesterday");
            Display(sentence);

            mark1 = sentence.Last;
            sentence.RemoveLast();
            sentence.AddFirst(mark1);
            Display(sentence);

            sentence.RemoveFirst();

            LinkedListNode<string> current = sentence.FindLast("the");
            DisplayNode(current);

            sentence.AddAfter(current, "old");
            sentence.AddAfter(current, "lazy");
            DisplayNode(current);

            current = sentence.Find("fox");
            DisplayNode(current);

            sentence.AddBefore(current, "quick");
            sentence.AddBefore(current, "brown");
            DisplayNode(current);

            // Keep a reference to the current node, "fox", and to the
            // previous node in the list. Use the Find method to locate
            // the node containing the value "dog". Show the position.
            mark1 = current;
            LinkedListNode<string> mark2 = current.Previous;
            current = sentence.Find("dog");
            DisplayNode(current);

            // The AddBefore method throws an InvalidOperationException
            // if you try to add a node that already belongs to a list.
            try
            {
                sentence.AddBefore(current, mark1);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Exception message: {0}", ex.Message);
            }

            // Remove the node referred to by mark1, and add it before 
            // the node referred to by current. Show the sentence, 
            // highlighting the position of the node referred to by
            // current.
            sentence.Remove(mark1);
            sentence.AddBefore(current, mark1);
            DisplayNode(current);

            // Remove the node referred to by current. If you try to show
            // its position now, the DisplayNode method prints a message.
            // Add the node after the node referred to by mark2, and 
            // display the sentence, highlighting current.
            sentence.Remove(current);
            DisplayNode(current);
            sentence.AddAfter(mark2, current);
            DisplayNode(current);

            // The Remove method finds and removes the first node that 
            // that has the specified value.
            sentence.Remove("old");
            Display(sentence);

            // When the linked list is cast to ICollection(Of String),
            // the Add method adds a node to the end of the list. 
            sentence.RemoveLast();
            ICollection<string> icoll = sentence;
            icoll.Add("rhinoceros");
            Display(sentence);

            // Create an array with the same number of elements as the
            // linked list.
            Console.WriteLine("\nCopy the list to an array.");
            string[] sArray = new string[sentence.Count];
            sentence.CopyTo(sArray, 0);

            foreach (string s in sArray)
            {
                Console.WriteLine(s);
            }

            // Release all the nodes.
            sentence.Clear();
            Console.ReadLine();

        }

        private static void Display(LinkedList<string> words)
        {
            foreach (string word in words)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
        }

        private static void DisplayNode(LinkedListNode<string> node)
        {
            if (node.List == null)
            {
                Console.WriteLine("Node \"{0}\" is not in a list.",
                    node.Value);
                return;
            }

            StringBuilder result = new StringBuilder("(" + node.Value + ")");
            LinkedListNode<string> nodeP = node.Previous;

            while (nodeP != null)
            {
                result.Insert(0, nodeP.Value + " ");
                nodeP = nodeP.Previous;
            }

            node = node.Next;
            while (node != null)
            {
                result.Append(" " + node.Value);
                node = node.Next;
            }

            Console.WriteLine(result);
        }
    }
}

