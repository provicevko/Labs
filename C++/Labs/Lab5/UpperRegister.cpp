#include "UpperRegister.h"
UpperRegister::UpperRegister(string str)
{
    if (str != "")
    {
        for (size_t i = 0; i < str.length(); i++)
        {
            Str += toupper(str[i]);
        }
    }
}
void UpperRegister::PasteSymbol(char symb) { 
    Str += "/";
    Str += toupper(symb);
}
int UpperRegister::GetLength()
{
    int counter = 0;
    if (Str != "")
    {
        for (int i = 0; i < Str.length(); i++)
        {
            if (Str[i] != '/') counter++;
        }
    }

    return counter;
}