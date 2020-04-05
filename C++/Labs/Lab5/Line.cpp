#include "Line.h"
double Line::LineLength()
{
    return sqrt(pow(endCoord[0] - startCoord[0], 2) + pow(endCoord[1] - startCoord[1], 2));
}
Line::Line(double x1, double y1, double x2, double y2)
{
    startCoord[0] = x1;
    startCoord[1] = y1;

    endCoord[0] = x2;
    endCoord[1] = y2;
}
double Line::LineLength(double x, double y) { return sqrt(pow(x, 2) + pow(y, 2)); }
double Line::LineLength(double vector[]) { return sqrt(pow(vector[0], 2) + pow(vector[1], 2)); }
