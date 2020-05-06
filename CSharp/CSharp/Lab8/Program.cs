using System;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array = {'A','c','C','b','B','a','5'};
            // char[] array = null;
            SortArray obj = new SortArray(array);
            SortArray.SortDelegate del = obj.DownSort;
            del();
            SortArray.SortStaticDelegate del2 = SortArray.DownSort;
            del2(array);
            foreach (var elem in array)
            {
                Console.Write(elem+" ");
            }
        }
    }
}