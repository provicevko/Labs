using System;

namespace Lab3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            TwoDimensionalArray matrix = new TwoDimensionalArray();
            Console.WriteLine(matrix[7,1]);
            Console.WriteLine(matrix.CountCols);
            Console.WriteLine(matrix.CountRows);
        }
    }
}