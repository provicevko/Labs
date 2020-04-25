using System;

namespace Lab4
{
    public class Vector
    {
        private double x, y, z;
        public Vector() {}// x = 0, y = 0, z = 0;

        public Vector(double coord)
        {
            x = coord;
            y = coord;
            z = coord;
        }
        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector(double[] vec)
        {
            if (vec == null)
                throw new ArgumentNullException("vec");
            if (vec.Length != 3)
                throw new ArgumentException("Vector array must contains 3 elements!");
            x = vec[0];
            y = vec[1];
            z = vec[2];
        }
        public Vector(Vector vec)
        {
            if (vec == null)
                throw new ArgumentNullException("vec");
            x = vec.x;
            y = vec.y;
            z = vec.z;
        }

        public double X => x;
        public double Y => y;
        public double Z => z;

        public static double GetLength(double x, double y, double z) => Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
        public static double GetLength(double coord) => Math.Sqrt(3*Math.Pow(coord,2));
        public double GetLength() => Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2)+Math.Pow(z,2));
        public double[] GetVector() => new[]{x,y,z};

        public static Vector operator *(double c, Vector vec)
        {
            if(vec == null)
                throw new ArgumentNullException("vec");
            return new Vector(c * vec.x, c* vec.y, c* vec.z);
        }

        public static Vector operator *(Vector vec, double c)
        {
            if(vec == null)
                throw new ArgumentNullException("vec");
            return new Vector(c * vec.x, c* vec.y, c* vec.z);
        }

        public static Vector operator *(Vector vec1, Vector vec2)
        {
            if(vec1 == null)
                throw new ArgumentNullException("vec1");
            if(vec2 == null)
                throw new ArgumentNullException("vec2");
            return new Vector(vec1.x * vec2.x, vec1.y* vec2.y, vec1.z* vec2.z);
        }

        public static Vector operator -(double c, Vector vec)
        {
            if(vec == null)
                throw new ArgumentNullException("vec");
            return new Vector(c - vec.x, c - vec.y, c - vec.z);
        }

        public static Vector operator -(Vector vec, double c)
        {
            if(vec == null)
                throw new ArgumentNullException("vec");
            return new Vector(vec.x - c, vec.y - c, vec.z - c);
        }

        public static Vector operator -(Vector vec1, Vector vec2)
        {
            if(vec1 == null)
                throw new ArgumentNullException("vec1");
            if(vec2 == null)
                throw new ArgumentNullException("vec2");
            return new Vector(vec1.x - vec2.x, vec1.y - vec2.y, vec1.z - vec2.z);
        }
    }
}