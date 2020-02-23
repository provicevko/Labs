using System;
using Lab2Dll;
using String = Lab2Dll.String;

namespace Lab2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            char[][] arr =
            {
                "dfgb".ToCharArray(),
                "Hello world!".ToCharArray(),
                "None".ToCharArray(),
                "okay".ToCharArray()
            };

            Lab2Dll.TextCont obj = new TextCont(arr);
            obj.AddStr("nu tipa str34689!on".ToCharArray());
            obj.DeleteStr(2);
            obj.GetAverageLength();
            obj.PersentVowels();
            obj.DelStrwithSubstr("on".ToCharArray());
            /*obj.ClearText();*/
        }
    }
}