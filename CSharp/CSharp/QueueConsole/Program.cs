using System;
using MyQueue;

namespace QueueConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Queue queue = new Queue(5);
                queue.RegisterHandler(Alert);
                queue.Push(-547);
                queue.Push(-548);
                queue.Push(-549);
                Console.WriteLine(queue.Peek());
                queue.Push(-550);
                Console.WriteLine(queue.Peek());
                queue.Push(-551);
                Console.WriteLine(queue.Peek());
                queue.Push(-552);
                queue.Push(-552);
                queue.Delete();
                Console.WriteLine(queue.Peek());
                queue.Delete();
                queue.Delete();
                queue.Delete();
                queue.Delete();
                Console.WriteLine(queue.Peek());
                queue.Push(0);
                Console.WriteLine(queue.Peek());
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Process error. Please, check your input values!");
            }
        }
        private static void Alert(object sender, QueueEvent e)
        {
            Console.WriteLine(e.Message);
        }
    }
}