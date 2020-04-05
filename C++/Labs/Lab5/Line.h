#pragma once
#include <math.h>
class Line
{
protected:
    double startCoord[2];
    double endCoord[2];
    double LineLength(double x, double y);
    double LineLength(double vector[]);
public:
    Line(double x1, double y1, double x2, double y2);
    double LineLength();
};

