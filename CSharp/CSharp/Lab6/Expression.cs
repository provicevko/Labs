using System;

namespace Lab6
{
    public class Expression
    {
        public float A { get; set;}
        public float C { get; set;}
        public float D { get; set;}
        
        public Expression(){}
        public Expression(float a, float c, float d)
        {
            A = a;
            C = c;
            D = d;
        }

        public float GetTheResultExpression()
        {
            if(A == 0)
                throw new DivideByZeroException("Division on zero! Log(e,1) = 0!");
            if((1-A/4) <= 0)
                throw new ArithmeticException("For Log(e,1-a/4) (1-a/4) must be > 0");
                
            return (float) ((2 * C - D / 23) / Math.Log(1 - A / 4));
        }
    }
}