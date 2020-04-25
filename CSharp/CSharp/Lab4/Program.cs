using System;

namespace Lab4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Vector v1 = new Vector();
                Vector v2 = new Vector(3.2, 5, 7.1);
                Vector v3 = new Vector(v2);
                v3 *= 2;
                v1 = v3 - v2;
                //v1 = 2 * (Vector)null;
                //Console.WriteLine(Vector.GetLength(double.MaxValue); // => "?"
                Console.WriteLine($"V1 = ({v1.X};{v1.Y};{v1.Z})");
                Console.WriteLine($"V2 = ({v2.X};{v2.Y};{v2.Z})");
                Console.WriteLine($"V3 = ({v3.X};{v3.Y};{v3.Z})");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Process error! Please, check your input variables!");
            }
            
        }
    }
}