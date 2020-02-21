using System;
using System.Runtime.InteropServices;

namespace Lab1
{
    public class CompareVariables
    {
        internal void mainFunc(int num1, int num2)
        {
            Comparing(num1, num2);
        } 
        private static bool Comparing(int num1, int num2)
        {
            if ((num1 & (1 << Marshal.SizeOf(num1)*8 - 1))!=0 && 
                (num2 & (1 << Marshal.SizeOf(num2)*8 - 1))==0) return false;
            else if ((num1 & (1 << Marshal.SizeOf(num1) * 8 - 1))==0 &&
                     (num2 & (1 << Marshal.SizeOf(num2) * 8 - 1))!=0) return true;
            for (int i = Marshal.SizeOf(num1)*8-2; i >= 0; i--)
            {
                if ((num1 & (1 << i))!=0 && (num2 & (1 << i))==0) return true;
                else if ((num1 & (1 << i))==0 && (num2 & (1 << i))!=0) return false;
            }
            return false;
        }
    }
}