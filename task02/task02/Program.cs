using System;

class Program
{
    public struct Distance
    {
        public int feet;
        public int inch;

    }
    public static void Main()
    {
        Distance a;
        Distance b;

        Console.WriteLine("Please enter value of distance 'a' in inches: ");
        a.inch = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter value of distance 'b' in inches: ");
        b.inch = int.Parse(Console.ReadLine());

        Distance c;

        c.inch = a.inch + b.inch;
        c.feet = c.inch / 12;
        c.inch = c.inch % 12;

        Console.WriteLine($"Sum of distance 'a' and distance 'b': {c.feet}' - {c.inch}\"");
    }
}