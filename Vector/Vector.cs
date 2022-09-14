using System;
using System.Xml.Schema;

namespace Vector
{
    public struct Vector
    {
        //PROPERTIES
        public double X { get; set; }
        public double Y { get; set; }

        public double Magnitude
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y);
            }
        }

        public double Direction
        {
            get
            {
                return Math.Atan2(Y, X) * 180 / Math.PI;
            }
        }

        // CONTSTRUCTOR
        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }

        // METHODS
        public Vector Add(Vector v)
        {
            Vector result = new Vector(this.X + v.X, this.Y + v.Y);

            return result;
        }

        public Vector Subtract(Vector v)
        {
            Vector result = new Vector(this.X - v.X, this.Y - v.Y);

            return result;
        }

        public double Dot(Vector v)
        {
            Vector result = new Vector(this.X * v.X, this.Y * v.Y);

            return result.Magnitude;
        }

        public double AngleBetween(Vector v)
        {
            Vector result = this.Add(v);
            double mag = result.Magnitude;
            double angle = Math.Asin(result.Y / mag) * 180 / Math.PI;
            return angle;
        }

        public override string ToString()
        {
            // Example
            // <4.2, 5.39> 
            return $"<{X}, {Y}>";
        }


        public static Vector operator +(Vector a, Vector b)
        {
            return a.Add(b);
        }

        public static Vector operator -(Vector a, Vector b)
        {
            return a.Subtract(b);
        }

        public static double operator *(Vector a, Vector b)
        {
            return a.Dot(b);
        }

        public static double AngleBetween(Vector a, Vector b)
        {
            return a.AngleBetween(b);
        }


    }
}

