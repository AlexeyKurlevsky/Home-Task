﻿using System;
namespace HomeTask
{
    public class Vector
    {

        //Properties
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        //Indexer
        public double this[int i]
        {
            get
            {
                if (i == 0)
                {
                    return this.X;
                }
                else if (i == 1)
                {
                    return this.Y;
                }
                else if (i == 2)
                {
                    return this.Z;
                }
                throw new Exception();
            }
            set
            {
                if (i == 0)
                {
                    this.X = value;
                }
                else if (i == 1)
                {
                    this.Y = value;
                }
                else if (i == 2)
                {
                    this.Z = value;
                }
                else
                {
                    throw new Exception();
                }

            }
        }

        public double Length
        {
            get
            {
                return GetLength();
            }
        }

        //Static properties
        public static Vector XAxis
        {
            get => new Vector(1, 0, 0);
        }
        public static Vector YAxis
        {
            get => new Vector(0, 1, 0);
        }
        public static Vector ZAxis
        {
            get => new Vector(0, 0, 1);
        }
        //Constructors

        public Vector()
        {
            this.X = 0;
            this.Y = 0;
            this.Z = 0;

        }
        public Vector(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;

        }

        public Vector(Vector other)
        {
            this.X = other.X;
            this.Y = other.Y;
            this.Z = other.Z;
        }

        //Method
        private double GetLength()
        {
            double sql = this.X * this.X + this.Y * this.Y + this.Z * this.Z;
            double len = Math.Sqrt(sql);
            return len;
        }

        public void Reverse()
        {
            this.X = -this.X;
            this.Y = -this.Y;
            this.Z = -this.Z;

        }
        public void Scale(double factor)
        {
            this.X *= factor;
            this.Y *= factor;
            this.Z *= factor;

        }
        public void Unitize()
        {
            double len = this.GetLength();
            if (len <= 0)
            {
                return;
            }
            this.X /= len;
            this.Y /= len;
            this.Z /= len;
        }
        public void Add(Vector other)
        {
            this.X += other.X;
            this.Y += other.Y;
            this.Z += other.Z;
        }
        //Operator overloads
        public static Vector operator +(Vector a, Vector b)
        {
            return Vector.Addition(a, b);
        }
        public static double operator *(Vector a, Vector b)
        {
            return Vector.DotProduct(a, b);
        }
        public static Vector operator *(double a, Vector b)
        {
            Vector v = new Vector(b);
            v.Scale(a);
            return v;
        }
        // Static method
        public static Vector Addition(Vector a, Vector b)
        {
            double newX = a.X + b.X;
            double newY = a.Y + b.Y;
            double newZ = a.Z + b.Z;
            Vector v = new Vector(newX, newY, newZ);
            return v;
        }

        public static double DotProduct(Vector a, Vector b)
        {
            double dot = a.X * b.X + a.Y * b.Y + a.Z * b.Z;
            return dot;
        }

        public static Vector CrossProduct(Vector a, Vector b)
        {
            double x = a.Y * b.Z - a.Z * b.Y;
            double y = a.Z * b.X - a.X * b.Z;
            double z = a.X * b.Y - a.Y * b.X;
            return new Vector(x, y, z);

        }

        //Overrides
        public override string ToString()
        {
            return $"{this.X}, {this.Y}, {this.Z}";
        }

        //Write to txt file
        public static string ConvertToString(Vector a)
        {
            return $"{a.X} {a.Y} {a.Z}";
        }
    }

}

