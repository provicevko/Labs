namespace Lab1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Increment obj = new Increment();
            obj.mainFunc(15);
            
            CompareVariables cmp = new CompareVariables();
            cmp.mainFunc(-125,12);
        }
    }
}