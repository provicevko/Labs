#include <iostream>
#include "Increment.h"
#include "CompareVariables.h" 
int main()
{
    int num = 15;
    Increment obj = Increment();
    obj.IncrementNum(num);

    CompareVariables cmp = CompareVariables();
    bool t = cmp.Comparing(-125,12);

}
