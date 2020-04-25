#include "Expression.h"
#include <exception>
#include <stdexcept>
#include <math.h>
Expression::Expression() {}
Expression::Expression(float a, float c, float d)
{
    A = a;
    C = c;
    D = d;
}
float Expression::GetTheResultExpression()
{
    if (A == 0)
        throw std::logic_error("Division on zero! Log(e,1) = 0");
    if ((1 - A / 4) <= 0)
        throw std::underflow_error("For Log(e,1-a/4) (1-a/4) must be > 0");

    return (float)((2 * C - D / 23) / log(1 - A / 4));
}