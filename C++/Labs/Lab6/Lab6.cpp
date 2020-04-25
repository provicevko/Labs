#include <iostream>
#include "Expression.h"

int main()
{
    try
    {
        int size = 3;
        Expression* objArray = new Expression[size];
        objArray[0] = Expression(1, 5, 7);
        objArray[1] = Expression(1, 7, 2);
        objArray[2] = Expression();
        objArray[2].A = 5;
        objArray[2].C = 8;
        objArray[2].D = 1;
        for(int i =0; i<size;i++)
        {
            std::cout<<objArray[i].GetTheResultExpression()<< std::endl;
        }
    }
    catch (std::logic_error ex)
    {
        std::cout << ex.what() << std::endl;
    }
    catch (std::underflow_error ex)
    {
        std::cout << ex.what() << std::endl;
    }
    catch (std::exception)
    {
        std::cout<<"Unreal get result. Please, check your input variables."<< std::endl;
    }
}