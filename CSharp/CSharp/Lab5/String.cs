namespace Lab5
{
    public abstract class String
    {
        public string Str { get; protected set; }
        public String(string str)
        {
            Str = str;
        }

        public virtual int GetLength() => Str.Length;
        public void PasteSymbol(char symb) => Str += symb;
        public abstract void PasteSymbol();
    }
}