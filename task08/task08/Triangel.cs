using System;

namespace Triangel
{
    public class Triangel
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }
        private bool exists = false;

        public Triangel(double a, double b, double c)
        {
            if (Exist(a, b, c))
            {
                A = a;
                B = b;
                C = c;
            }
        }

        public Triangel(double a) : this(a, a, a)
        {
        }

        public void Populate(double a, double b, double c)
        {
            if (Exist(a, b, c))
            {
                A = a;
                B = b;
                C = c;
            }
        }

        public double Perimeter() => A + B + C;

        public double Square()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public override string ToString() => $"Side 'a' = {A},\nSide 'b' = {B},\nSide 'c' = {C}";

        private bool Exist(double a, double b, double c)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                A = a;
                B = b;
                C = c;
                return exists = true;
            }
            else
            {
                throw new ArgumentException("Side of tirangle cannot be less than or equal to zero!");
            }
        }
    }
}