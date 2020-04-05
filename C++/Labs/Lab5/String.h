#pragma once
#include <string>
using namespace std;
class String
{
public: 
    string Str;
    String();
    String(string str);
    virtual int GetLength();
    virtual void PasteSymbol(char symb);
};

