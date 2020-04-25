using System;

namespace Lab5
{
    public class LineSegment : Line
    {
        public LineSegment(double x1, double y1, double x2, double y2):base(x1,y1,x2,y2){}
        public double AngleWithOX()
        {
            double[] vector = {endCoord[0] - startCoord[0], endCoord[1] - startCoord[1]};
            if (LineLength(vector) == 0) return 0;
            return Math.Acos(vector[0] / LineLength(vector));
        }

        public double[] StartCoord => startCoord;
        public double[] EndCoord => endCoord;
    }
}