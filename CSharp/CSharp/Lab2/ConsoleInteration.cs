using System;
namespace Lab2
{
    public class ConsoleInteration
    {
        internal char[] GetString()
        {
            char[] text = Console.ReadLine()?.ToCharArray();
            return text;
        }
    }
}