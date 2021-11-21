using System;

public class Program
{
    public static void Main()
    {
        double target = 2023;
        double x = Sqrt(target);
        Console.WriteLine(x);
        Console.WriteLine(x * x);
    }

    public static double Sqrt(double target)
    {
        double x = 1;
        double oldx;
        do
        {
            oldx = x;
            x = (x + target / x) / 2;
        }
        while (oldx != x);
        return x;
    }
}