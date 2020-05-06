using System;

namespace Lab8
{
    public class SortArray
    {
        public delegate void SortDelegate();
        public delegate void SortStaticDelegate(char[] array);
        private char[] Array;
        
        public SortArray(char[] array)
        {
            Array = array;
        }
        private static int Partition (char[] array, int start, int end) 
        {
            char temp;
            int marker = start;
            for ( int i = start; i <= end; i++ ) 
            {
                if (array[i] > array[end]) 
                {
                    temp = array[marker]; 
                    array[marker] = array[i];
                    array[i] = temp;
                    marker++;
                }
            }
            temp = array[marker];
            array[marker] = array[end];
            array[end] = temp; 
            return marker;
        }

        private static void Quicksort (char[] array, int start, int end)
        {
            if ( start >= end ) 
            {
                return;
            }
            int pivot = Partition (array, start, end);
            Quicksort (array, start, pivot-1);
            Quicksort (array, pivot+1, end);
        }
        public static void DownSort(char[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException("Char array");
            }
            Quicksort(array,0,array.Length-1);
        }
        public void DownSort() => DownSort(Array);
    }
}