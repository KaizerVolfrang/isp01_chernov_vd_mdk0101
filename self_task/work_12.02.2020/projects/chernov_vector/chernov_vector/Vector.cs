using System;
using System.Collections.Generic;
using System.Text;

namespace chernov_vector
{
    class Vector
    {
        private double X { get; set; }

        private double Y { get; set; }

        private double Z { get; set; }

        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double Length()
        {
            double L = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));
            return L;
        }

        public double ScalarProduct(Vector vector2)
        {
            double S = X * vector2.X + Y * vector2.Y + Z * vector2.Z;
            return S;
        }

        public Vector VectorArtWork(Vector vector2)
        {
            double x = (Y * vector2.Z * vector2.Y);
            double y = (Z * vector2.X * vector2.Z);
            double z = (X * vector2.Y * vector2.X);

            Vector vector3 = new Vector(x, y, z);
            return vector3;
        }

        public override string ToString()
        {
            return ($"(x = {X}, y = {Y}, z = {Z})");
        }
    }
}
