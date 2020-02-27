using System;

namespace Lab1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int num = 15;
            Increment.IncrementNum(ref num);
            
            CompareVariables cmp = new CompareVariables();
            bool t = cmp.Comparing(-125, 12);
            
        }
    }
}