 
//Questions? Comments? go to 
//http://www.idesign.net

using System;
using System.Collections;
using System.Collections.Generic;
namespace Chapter2.LinkedListDemo
{
    //K is the key, T is the data item
    class Node<K, T>
    {
        public Node()
        {
            Key = default(K);
            Item = default(T);
            NextNode = null;
        }
        public Node(K key, T item, Node<K, T> nextNode)
        {
            Key = key;
            Item = item;
            NextNode = nextNode;
        }
        public K Key;
        public T Item;
        public Node<K, T> NextNode;
    }


    public class CustomLinkedList<K, T> : IEnumerable<T> where K : IComparable<K>
    {
        Node<K, T> m_Head;

        public CustomLinkedList()
        {
            m_Head = new Node<K, T>();
        }
        public void AddHead(K key, T item)
        {
            Node<K, T> newNode = new Node<K, T>(key, item, m_Head.NextNode);
            m_Head.NextNode = newNode;
        }
        public T this[K key]
        {
            get
            {
                return Find(key);
            }
        }
        T Find(K key)
        {
            Node<K, T> current = m_Head;

            while (current.NextNode != null)
            {
                if (current.Key.Equals(key))
                {
                    break;
                }
                else
                {
                    current = current.NextNode;
                }
            }
            return current.Item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<K, T> current = m_Head;
            while (current != null)
            {
                yield return current.Item;
                current = current.NextNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public static CustomLinkedList<K, T> operator +(CustomLinkedList<K, T> lhs, CustomLinkedList<K, T> rhs)
        {
            return concatenate(lhs, rhs);
        }
        static CustomLinkedList<K, T> concatenate(CustomLinkedList<K, T> list1, CustomLinkedList<K, T> list2)
        {
            CustomLinkedList<K, T> newList = new CustomLinkedList<K, T>();
            Node<K, T> current;

            current = list1.m_Head;
            while (current != null)
            {
                newList.AddHead(current.Key, current.Item);
                current = current.NextNode;
            }

            current = list2.m_Head;

            while (current != null)
            {
                newList.AddHead(current.Key, current.Item);
                current = current.NextNode;
            }
            return newList;
        }
    }
}
















