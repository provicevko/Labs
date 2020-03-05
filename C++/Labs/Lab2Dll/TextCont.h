#pragma once
#include "String.h"

namespace Lab2Dll
{
    
    class TextCont
    {
    public:
        int countStr;
        String* Text;

        TextCont()
        {
            Text = new String[0];
        }

        TextCont(char** text, const int countStr)
        {
            Text = new String[countStr];
            for (int i = 0; i < countStr; i++)
            {
                Text[i] = String(text[i]);
            }
            this->countStr = countStr;
        }
        void AddStr(char* str)
        {
            if (str != NULL) {
                String* CopyText = Text;
                Text = new String[countStr + 1];
                for (int i = 0; i < countStr; i++)
                {
                    Text[i] = CopyText[i];
                }
                delete[] CopyText;
                Text[countStr] = String(str);
                countStr++;
            }
        }
        void DeleteStr(int index)
        {
            if (index - 1 <= countStr && index - 1 >= 0) {
                String* CopyText = Text;
                --index;
                countStr--;
                Text = new String[countStr];
                for (int i = 0; i < countStr; i++)
                {
                    if (i < index) Text[i] = CopyText[i];
                    else Text[i] = CopyText[i + 1];
                }
                delete[] CopyText;
            }
        }
        void ClearText()
        {
            delete[] Text;
            Text = new String[0];
        }
        float GetAverageLength()
        {
            float averageLength = 0;
            for (int i = 0; i < countStr; i++)
            {
                averageLength += strlen(Text[i].Str);
            }
            averageLength /= countStr;
            return averageLength;
        }
        float PersentVowels()
        {
            int counter = 0;
            int countStrSymbols = 0;
            char vowels[] = { 'a', 'e', 'i', 'o', 'u', 'y' };
            for (int i = 0; i < countStr; i++)
            {
                for(int j = 0; j<strlen(Text[i].Str);j++)
                {
                    for(int k =0; k<6;k++)
                    {
                        if (Text[i].Str[j] == vowels[k] || Text[i].Str[j] == toupper(vowels[k]))
                        {
                            counter++;
                            break;
                        }
                    }
                }

                countStrSymbols += strlen(Text[i].Str);
            }
            return ((float)counter / countStrSymbols) * 100;
        }
        void DelStrwithSubstr(char* substr)
        {
            for (int i = 0; i < countStr; i++)
            {
                int index = 0;
                for (int j = 0; j < strlen(Text[i].Str); j++)
                {
                    if (Text[i].Str[j] == substr[index]) index++;
                    else index = 0;
                    if (index == strlen(substr) - 1)
                    {
                        this->DeleteStr(i + 1);
                        i--;
                        break;
                    }
                }
            }
        }
    };
}