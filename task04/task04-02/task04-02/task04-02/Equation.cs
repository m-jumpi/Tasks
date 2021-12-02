using System;

namespace Equation
{
    public class Equation
    {
        public static int SolutionEquation(int a, int b, int c, out double x1, out double x2)
        {
            double d = Math.Pow(b, 2) - 4 * a * c;

            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / 2 * a;
                x2 = (-b - Math.Sqrt(d)) / 2 * a;
                return 1;
            }
            if (d == 0)
            {
                x1 = x2 = -b / 2 * a;
                return 0;
            }
            else
            {
                x1 = x2 = 0;
                return -1;
            }
        }
    }
}