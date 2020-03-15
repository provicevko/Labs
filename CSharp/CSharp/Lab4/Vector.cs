using System;

namespace Lab4
{
    public class Vector
    {
        private double x, y, z;
        public Vector() {}// x = 0, y = 0, z = 0;

        public Vector(double coord)//x = coord, y = coord, z = coord
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
            x = vec[0];
            y = vec[1];
            z = vec[2];
        }
        public Vector(Vector vec)
        {
            x = vec.x;
            y = vec.y;
            z = vec.z;
        }

        public double X => x;
        public double Y => y;
        public double Z => z;

        public double GetLength(double x, double y, double z) => Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2)+Math.Pow(z,2));

        public double GetLength(Vector vec) => Math.Sqrt(Math.Pow(vec.x,2)+Math.Pow(vec.y,2)+Math.Pow(vec.z,2));
        
        public double GetLength(double coord) => Math.Sqrt(3*Math.Pow(coord,2));
        
        public double[] getVector() => new[]{x,y,z};

        public double[] getVector(Vector vec) => new[] {vec.X, vec.Y, vec.Z};

        public static Vector operator *(double c, Vector vec) => new Vector(c * vec.x, c* vec.y, c* vec.z);

        public static Vector operator *(Vector vec, double c) => new Vector(c * vec.x, c* vec.y, c* vec.z);
        
        public static Vector operator *(Vector vec1, Vector vec2) => new Vector(vec1.x * vec2.x, vec1.y* vec2.y, vec1.z* vec2.z);
        
        public static Vector operator -(double c, Vector vec) => new Vector(c - vec.x, c - vec.y, c - vec.z);
        
        public static Vector operator -(Vector vec, double c) => new Vector(vec.x - c, vec.y - c, vec.z - c);
        
        public static Vector operator -(Vector vec1, Vector vec2) => new Vector(vec1.x - vec2.x, vec1.y - vec2.y, vec1.z - vec2.z);
    }
}