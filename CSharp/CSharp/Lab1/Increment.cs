using System;

namespace Lab1
{
    public static class Increment
    {
        internal static void IncrementNum(ref int number)
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