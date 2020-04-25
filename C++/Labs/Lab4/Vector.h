#pragma once
#include <math.h>
#include <stdexcept>
class Vector{
    private: 
        double x, y, z;
    public:
        Vector() {}// x = 0, y = 0, z = 0;

        Vector(double coord)//x = coord, y = coord, z = coord
        {
            x = coord;
            y = coord;
            z = coord;
        }
        Vector(double x, double y, double z)
        {
            this->x = x;
            this->y = y;
            this->z = z;
        }

        Vector(double vec[])
        {
            if (vec == NULL)
                throw std::invalid_argument("vec invalid argument!");
            if (sizeof(vec)/sizeof(double) != 3)
                throw std::range_error("Vector array must contains 3 elements!");
            x = vec[0];
            y = vec[1];
            z = vec[2];
        }
        Vector(Vector& vec)
        {
            if (&vec == NULL)
                throw std::invalid_argument("vec invalid argument!");
            x = vec.x;
            y = vec.y;
            z = vec.z;
        }

        double X(){ return x; }
        double Y(){ return y; }
        double Z(){ return z; }

        static double GetLength(double x, double y, double z) 
        {
            return sqrt(pow(x, 2) + pow(y, 2) + pow(z, 2));
        }

        static double GetLength(double coord)
        {
            return sqrt(3 * pow(coord, 2));
        }

        double GetLength()
        {
            return sqrt(pow(x, 2) + pow(y, 2) + pow(z, 2));
        }

        double* GetVector() 
        {
            return new double[3]{ x, y, z };
        }

        friend Vector operator*(double c, Vector& vec) {
            if (&vec == NULL)
                throw std::invalid_argument("vec invalid argument!");
            Vector temp(c * vec.x, c * vec.y, c * vec.z);
            return temp;
        }
        friend Vector operator*(Vector& vec, double c)
        {
            if (&vec == NULL)
                throw std::invalid_argument("vec invalid argument!");
            Vector temp(c * vec.x, c * vec.y, c * vec.z);
            return temp;
        }
        friend Vector operator*(Vector& vec1, Vector& vec2)
        {
            if (&vec1 == NULL)
                throw std::invalid_argument("vec1 invalid argument!");
            if (&vec2 == NULL)
                throw std::invalid_argument("vec2 invalid argument!");
            Vector temp(vec1.x * vec2.x, vec1.y * vec2.y, vec1.z * vec2.z);
            return temp;
        }
        friend Vector operator -(double c, Vector& vec) {
            if (&vec == NULL)
                throw std::invalid_argument("vec invalid argument!");
            Vector temp(c - vec.x, c - vec.y, c - vec.z);
            return temp;
        }
        friend Vector operator -(Vector& vec, double c) {
            if (&vec == NULL)
                throw std::invalid_argument("vec invalid argument!");
            Vector temp(vec.x - c, vec.y - c, vec.z - c);
            return temp;
        }
        friend Vector operator -(Vector& vec1, Vector& vec2) {
            if (&vec1 == NULL)
                throw std::invalid_argument("vec1 invalid argument!");
            if (&vec2 == NULL)
                throw std::invalid_argument("vec2 invalid argument!");
            Vector temp(vec1.x - vec2.x, vec1.y - vec2.y, vec1.z - vec2.z);
            return temp;
        }
};
