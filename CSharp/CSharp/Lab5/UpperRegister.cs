using System;

namespace Lab5
{
    public class UpperRegister : String
    {
        public UpperRegister(string str):base(str)
        {
            Str = Str?.ToUpper();
        }
        public override void PasteSymbol()
        {
            if (Str != null)
            {
                for (int i = 1; i < Str.Length; i += 2)
                {
                    Str = Str.Insert(i, "/");
                }
            }
            else
            {
                Str += "/";
            }
        }
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