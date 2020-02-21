using System;

namespace Lab1
{
    public class Increment
    {
        internal void mainFunc(int number)
        {
            IncrementNum(ref number);
        }
        private static void IncrementNum(ref int number)
        {
            int mask = 1;
            while ((number & mask) != 0)
            {
                number &= ~mask;
                mask <<= 1;
            }
            number |= mask;
        }
    }
}