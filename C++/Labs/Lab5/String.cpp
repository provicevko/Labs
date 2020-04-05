#include "String.h"
String::String() {}
String::String(string str)
{
    Str = str;
}
int String::GetLength() { return Str.length(); }
void String::PasteSymbol(char symb) { Str += symb; }