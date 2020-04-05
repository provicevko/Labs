using System;

namespace Lab5
{
    public class Line
    {
        protected double[] startCoord, endCoord;
        public Line(double x1, double y1, double x2, double y2)
        {
            startCoord = new double[2];
            endCoord = new double[2];
            startCoord[0] = x1;
            startCoord[1] = y1;

            endCoord[0] = x2;
            endCoord[1] = y2;
        }
        public double LineLength() =>
            Math.Sqrt(Math.Pow(endCoord[0] - startCoord[0], 2) + Math.Pow(endCoord[1] - startCoord[1], 2));
        protected double LineLength(double x, double y) =>  Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        protected double LineLength(double[] vector) =>  Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2));
    }
}