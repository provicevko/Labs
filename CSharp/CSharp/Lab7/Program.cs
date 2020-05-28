using System;

namespace Lab7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            list.Add(10);
            list.Add(7);
            list.Add(5);
            list.Add(3);
            list.Add(15);
            list.Add(88);
            list.Add(75);
            list.Add(7);
            // list.DeleteAfterMax();
            list.Delete(7);
            list.Delete(88);
            // list.FiveKrat();
            MyListNode<int> ind = list.Head; 
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(ind.Value);
                ind = ind.Next;
            }
        }
    }
}