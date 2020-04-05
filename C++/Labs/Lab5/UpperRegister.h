#pragma once
#include "String.h"
class UpperRegister : public String
{
public:
    UpperRegister(string str);
    void PasteSymbol(char symb);
    int GetLength();
};

