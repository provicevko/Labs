#include <iostream>
#include "Increment.h"
#include "CompareVariables.h" 
int main()
{
    Increment obj = Increment();
    obj.mainFunc(17);

    CompareVariables cmp = CompareVariables();
    cmp.mainFunc(56,54);
}
