#include "LineSegment.h"

LineSegment::LineSegment(double x1, double y1, double x2, double y2) :Line(x1, y1, x2, y2) {}
double LineSegment::AngleWithOX()
{
    double vector[] = { endCoord[0] - startCoord[0], endCoord[1] - startCoord[1] };
    if (LineLength(vector) == 0) return 0;
    return acos(vector[0] / LineLength(vector));
}
double* LineSegment::StartCoords() { return startCoord; }
double* LineSegment::EndCoords() { return endCoord; }