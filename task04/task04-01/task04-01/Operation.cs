using System;

namespace Operation
{
    class Operation
    {
        public static double Square(double a, double b, double c)
        {
            if (TrianglePresence(a, b, c))
            {
                double p = (a + b + c)/2;
                double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return s;
            }
            else
            {
                Console.WriteLine("Cannot computer Square");
                return 0;
            }

        }

        public static double Square(double a)
        {
            if (TrianglePresence(a))
            {
                double p = (3 * a)/2;
                double s = Math.Sqrt(p * (p - a) * (p - a) * (p - a));
                return s;
            }
            else
            {
                Console.WriteLine("Cannot computer Square");
                return 0;
            }

        }

        private static bool TrianglePresence(double a, double b, double c)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool TrianglePresence(double a)
        {
            if (a > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}