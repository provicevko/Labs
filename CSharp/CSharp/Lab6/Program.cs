using System;

namespace Lab6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Expression[] objArray = new Expression[3];
                objArray[0] = new Expression(1, 5, 7);
                objArray[1] = new Expression(2, 7, 2);
                objArray[2] = new Expression();
                objArray[2].A = 0;
                objArray[2].C = 8;
                objArray[2].D = 1;
                foreach (var obj in objArray)
                {
                    Console.WriteLine(obj.GetTheResultExpression());
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception)
            {
                Console.WriteLine("Unreal get result. Please, check your input variables.");
            }
                
        }
    }
}