using System;

namespace Lab4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Vector v1 = new Vector();
            Vector v2 = new Vector(3.2,5,7.1);
            Vector v3 = new Vector(v2);
            v3 *= 3;
            v1 = v3 - v2;
            Console.WriteLine($"V1 = ({v1.X};{v1.Y};{v1.Z})");
            Console.WriteLine($"V2 = ({v2.X};{v2.Y};{v2.Z})");
            Console.WriteLine($"V3 = ({v3.X};{v3.Y};{v3.Z})");
        }
    }
}