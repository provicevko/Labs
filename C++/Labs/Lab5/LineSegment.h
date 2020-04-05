#pragma once
#include "Line.h"
class LineSegment : public Line
{
public: LineSegment(double x1, double y1, double x2, double y2);
      double AngleWithOX();
      double* StartCoords();
      double* EndCoords();
};

