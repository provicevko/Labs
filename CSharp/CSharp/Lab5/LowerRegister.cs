using System;

namespace Lab5
{
    public class LowerRegister : String
    {
        public LowerRegister(string str)
        {
            Str = str?.ToLower();
        }

        public override void PasteSymbol(char symb) => Str += $"\\{Char.ToLower(symb)}";
        public override int GetLength()
        {
            int counter = 0;
            if (Str != null)
            {
                foreach (var symb in Str)
                {
                    if (symb != '\\') counter++;
                }
            }
            return counter;
        }
    }
}