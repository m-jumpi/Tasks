using System;

namespace Equation
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter coefficients 'a', 'b' and 'c' for Quadratic Equation");
            int a = IntCheck("Enter value 'a':");
            int b = IntCheck("Enter value 'b':");
            int c = IntCheck("Enter value 'c':");

            int result = Equation.SolutionEquation(a, b, c, out double x1, out double x2);

            switch (result)
            {
                case 1:
                    Console.WriteLine($"There are two roots with coefficients a={a}, b={b}, c={c} : x1={x1}, x2={x2}.");
                    break;
                case 0:
                    Console.WriteLine($"There is one root with coefficients a={a}, b={b}, c={c} : x1=x2={x1}.");
                    break;
                default:
                    Console.WriteLine($"There are no roots with coefficients a={a}, b={b}, c={c} : no result.");
                    break;
            }
        }

        public static int IntCheck(string message)
        {
            Console.WriteLine(message);
            var inputLine = Console.ReadLine();
            int resutl;
            while (!int.TryParse(inputLine, out resutl))
            {
                Console.WriteLine("Invalid Input");
                inputLine = Console.ReadLine();
            }
            return resutl;
        }
    }
}