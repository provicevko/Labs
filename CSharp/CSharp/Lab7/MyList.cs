using System;
using System.Collections.Generic;

namespace Lab7
{
    public class MyList<T> : IMyList<T>
    {
        public MyListNode<T> Head;
        public int Count { get; internal set; }
        
        public MyList()
        {
            if (typeof(T) != typeof(int) && typeof(T) != typeof(double) && typeof(T) != typeof(decimal))
            {
                throw new ArgumentException("Invalid generic parametr");
            }
        }
        
        public void Add(T value)
        {
            if (Head == null)
            {
                Head = new MyListNode<T>(value);
                ++Count;
                return;
            }
            MyListNode<T> newNode = new MyListNode<T>(value);
            newNode.next = Head.next;
            Head.next = newNode;
            ++Count;
        }

        public void Delete(T value)
        {
            MyListNode<T> node = FindNode(value);
            if (node == null)
            {
                throw new NullReferenceException($"Not exist node with value {value}");
            }
            
            if (node == Head)
            {
                Head = node.next;
            }
            else
            {
                MyListNode<T> t = Head;
                while (t.next != node)
                {
                    t = t.next;
                }

                t.next = node.next;
            }

            --Count;
        }

        public MyListNode<T> FindNode(T value)
        {
            MyListNode<T> node = Head;
            while (node != null)
            {
                if (!Convert.ToBoolean(Comparer<T>.Default.Compare(node.Value, value)))
                {
                    return node;
                }

                node = node.next;
            }

            return null;
        }
        
        public void DeleteAfterMax()
        {
            MyListNode<T> max = Max();
            MyListNode<T> node = max.next;
            while (node != null)
            {
                node = node.next;
                --Count;
            }

            max.next = null;
        }

        public MyListNode<T> Max()
        {
            if (Head == null)
            {
                throw new NullReferenceException("Head node is null");
            }
            MyListNode<T> node = Head;
            MyListNode<T> max = Head;
            while (node != null)
            {
                if (Comparer<T>.Default.Compare(node.Value, max.Value) >= 0)
                {
                    max = node;
                }

                node = node.next;
            }

            return max;
        }

        public int FiveKrat()
        {
            if (Head == null)
            {
                throw new NullReferenceException("Head node is null");
            }
            int counter = 0;
            MyListNode<T> node = Head;
            while (node != null)
            {
                if ((dynamic)node.Value % 5 == 0)
                {
                    ++counter;
                }

                node = node.next;
            }

            return counter;
        }
        
    }
}