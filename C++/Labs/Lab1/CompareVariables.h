#pragma once
#include <iostream>
using namespace std;
class CompareVariables
{
public: bool Comparing(int num1, int num2)
{
    if ((num1 & (1 << sizeof(num1)*8-1)) &&
        !(num2 & (1 << sizeof(num2) * 8 - 1))) return false;
    else if (!(num1 & (1 << sizeof(num1) * 8 - 1)) &&
        (num2 & (1 << sizeof(num2) * 8 - 1))) return true;
    for (int i = sizeof(num1) * 8 - 2; i >= 0; i--)
    {
        if ((num1 & (1 << i)) && !(num2 & (1 << i))) return true;
        else if (!(num1 & (1 << i)) && (num2 & (1 << i))) return false;
    }
    return false;
}
};

