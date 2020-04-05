#include "LowerRegister.h"
LowerRegister::LowerRegister(string str)
{
    if (str != "")
    {
        for (size_t i = 0; i < str.length(); i++)
        {
            Str += tolower(str[i]);
        }
    }
}
void LowerRegister::PasteSymbol(char symb) 
{
    Str += "\\";
    Str += tolower(symb);
}
int LowerRegister::GetLength()
{
    int counter = 0;
    if (Str != "")
    {
        for (int i = 0; i < Str.length(); i++)
        {
            if (Str[i] != '\\') counter++;
        }
    }

    return counter;
}