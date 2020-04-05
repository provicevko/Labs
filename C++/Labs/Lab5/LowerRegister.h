#pragma once
#include "String.h"
class LowerRegister : public String
{
public:
    LowerRegister(string str);
    void PasteSymbol(char symb);
    int GetLength();
};

