using System;

namespace Operation
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please select a type of triangle:\n(0) - To quit\n(1) - Equilateral\n(2) - Regular");
            int choice = ChoiceCheck();

            if (choice == 1)
            {
                Console.WriteLine("Please enter one side of triangle: 'a'");
                double a = IntCheck("Enter value 'a'");
                Console.WriteLine($"Square = {(Operation.Square(a)):F2}");
            }
            if (choice == 2)
            {
                Console.WriteLine("Please enter sides of triangle: 'a', 'b' and 'c'");

                double a = IntCheck("Enter value 'a'");
                double b = IntCheck("Enter value 'b'");
                double c = IntCheck("Enter value 'c'");
                Console.WriteLine($"Square = {(Operation.Square(a, b, c)):F2}");
            }
            else
            {
                Environment.Exit(0);
            }
        }

        public static int ChoiceCheck()
        {
            var inputLine = Console.ReadLine();
            int result;
            while (!int.TryParse(inputLine, out result) || !(result == 1 || result == 2 || result == 0))
            {
                Console.WriteLine("Invalid Input");
                inputLine = Console.ReadLine();
            }
            return result;
        }

        public static double IntCheck(string message)
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
}