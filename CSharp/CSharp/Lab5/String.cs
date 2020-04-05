namespace Lab5
{
    public class String
    {
        public string Str { get; protected set; }
        public String(){}
        public String(string str)
        {
            Str = str;
        }

        public virtual int GetLength() => Str.Length;
        public virtual void PasteSymbol(char symb) => Str += symb;
    }
}