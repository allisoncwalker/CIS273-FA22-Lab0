﻿using System;
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

		public Vector Dot(Vector v)
		{

            Vector result = new Vector(this.X * v.X, this.Y * v.Y);

            return result;
        }

		public double AngleBetween(Vector v)
		{
            double radians = Math.Acos(((this.X * v.X) + (this.Y * v.Y)) / (Math.Sqrt(Math.Pow(this.X, 2) + Math.Pow(this.Y, 2)) * (Math.Sqrt(Math.Pow(v.X, 2) + Math.Pow(v.Y, 2)))));
            double degrees = radians * 180 / Math.PI;
            return degrees;
        }

        public override string ToString()
		{
			// Example
			// <4.2, 5.39> 
			return $"<{X}, {Y}>"; 
		}

	public static Vector operator + (Vector a, Vector b)
	{
		return a.Add(b);
	}

    public static Vector operator - (Vector a, Vector b)
    {
        return a.Subtract(b);
    }

    public static Vector operator * (Vector a, Vector b)
    {
        return a.Dot(b);
    }

    public static double AngleBetween(Vector a, Vector b)
    {
        return a.AngleBetween(b);
    }


    } 
}

