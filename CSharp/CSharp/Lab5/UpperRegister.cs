using System;

namespace Lab5
{
    public class UpperRegister : String
    {
        public UpperRegister(string str)
        {
            Str = str?.ToUpper();
        }
        public override void PasteSymbol(char symb) => Str += $"/{Char.ToUpper(symb)}";
        public override int GetLength()
        {
            int counter = 0;
            if (Str != null)
            {
                foreach (var symb in Str)
                {
                    if (symb != '/') counter++;
                }
            }

            return counter;
        }
    }
}