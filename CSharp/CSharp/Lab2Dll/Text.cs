using System;

namespace Lab2Dll
{
    public class TextCont
    {
        public String[] Text;

        public TextCont()
        {
            Text = new String[0];
        }
        public TextCont(char[][] text)
        {
            Text = new String[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                Text[i] = new String(text[i]);
            }
        }
        
        public void AddStr(char[] str)
        {
            if (str != null)
            {
                int countStr = Text.GetLength(0);
                String[] CopyText = Text;
                Text = new String[countStr + 1];
                for (int i = 0; i < countStr; i++)
                {
                    Text[i] = CopyText[i];
                }

                Text[countStr] = new String(str);
            }
        }

        public void DeleteStr(int index)
        {
            if (index - 1 <= Text.GetLength(0) && index - 1 >= 0)
            {
                int countStr = Text.GetLength(0);
                String[] CopyText = Text;
                Text = new String[countStr - 1];
                --index;
                for (int i = 0; i < countStr - 1; i++)
                {
                    if (i < index) Text[i] = CopyText[i];
                    else Text[i] = CopyText[i + 1];
                }
            }
        }

        public void ClearText()
        {
            Text = new String[0];
        }

        public float GetAverageLength()
        {
            float averageLength = 0f;
            for (int i = 0; i < Text.GetLength(0); i++)
            {
                averageLength += Text[i].Str.Length;
            }
            averageLength /= Text.GetLength(0);
            return averageLength;
        }

        public float PersentVowels()
        {
            int counter = 0;
            int countStrSymbols = 0;
            char[] vowels = {'a', 'e', 'i', 'o', 'u', 'y'};
            for (int i = 0; i < Text.GetLength(0); i++)
            {
                foreach (var letter in Text[i].Str)
                {
                    foreach (var vowel in vowels)
                    {
                        if (letter == vowel || letter == Char.ToUpper(vowel))
                        {
                            counter++;
                            break;
                        }
                    }
                }

                countStrSymbols += Text[i].Str.Length;
            }
            return (Convert.ToSingle(counter)/countStrSymbols)*100;
        }
        public void DelStrwithSubstr(char[] substr)
        {
            int countStr = Text.GetLength(0);
            for (int i = 0; i < countStr; i++)
            {
                int index = 0;
                foreach (var symb in Text[i].Str)
                {
                    if (symb == substr[index]) index++;
                    else index = 0;
                    if (index == substr.Length - 1)
                    {
                        this.DeleteStr(i+1);
                        i--;
                        countStr--;
                        break;
                    }
                }
            }
        }
    }
}