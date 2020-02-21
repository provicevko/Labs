#pragma once
#include <iostream>
using namespace std;
class Increment
{
public: void mainFunc(int number)
{
    IncrementNum(number);
}
private: static void IncrementNum(int& number)
{
    int mask = 1;
    while (number & mask)
    {
        number &= ~mask;
        mask <<= 1;
    }
    number |= mask;
}
};


