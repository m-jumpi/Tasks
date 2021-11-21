using System;

class Target
{
    public struct Point
    {
        public double x2;
        public double y2;

        public Point(double x2, double y2)
        {
            this.x2 = x2;
            this.y2 = y2;
        }
    }

    public static void Main()
    {
        int numberOfShuts = 0;

        try
        {
            Console.WriteLine("Please enter a number of shots you would like to make: ");
            numberOfShuts = int.Parse(Console.ReadLine());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Point[] array = new Point[numberOfShuts];
        var rand = new Random();
        double x1 = rand.Next(-10, 10);
        double y1 = rand.Next(-10, 10);
        int totalResult = 0;

        for (int i = 0; i < numberOfShuts; i++)
        {
            Console.WriteLine("To make a shot, please enter 'x' and 'y'");
            double x2 = doubleCheck("Enter x: ");
            double y2 = doubleCheck("Enter y: ");
            array[i] = new Point(x2, y2);
            totalResult += ShotResult(x1, y1, x2, y2);
        }
        Console.WriteLine($"Your result is {totalResult}");
    }

    static int ShotResult(double x1, double y1, double x2, double y2)
    {
        double radius = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        if (radius <= 1)
        {
            return 10;
        }
        if (radius <= 2)
        {
            return 5;
        }
        if (radius <= 3)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }

    static double doubleCheck(string message)
    {
        Console.WriteLine(message);
        var inputLine = Console.ReadLine();
        double resutl;
        while (!double.TryParse(inputLine, out resutl))
        {
            Console.WriteLine("Invalid Input");
            inputLine = Console.ReadLine();
        }
        return resutl;
    }
}