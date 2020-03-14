using System;

namespace Lab3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            TwoDimensionalArray matrix = new TwoDimensionalArray();
            if (matrix[7, 8] != Int32.MinValue)
            {
                int elem = matrix[7, 8];
            }
        }
    }
}