using System;

class Program
{
    public struct Distance
    {
        public int inputInches;
        public int feet;
        public int inch;

        public Distance(int inputInches)
        {
            this.inputInches = inputInches;
            feet = (int)inputInches / 12;
            inch = (int)inputInches % 12;
        }

        public string Display()
        {
            return ($"{feet}' - {inch}\"");
        }

    }
    public static void Main()
    {
        Distance a = new Distance(intCheck("Please enter value of distance 'a' in inches: "));
        Distance b = new Distance(intCheck("Please enter value of distance 'b' in inches: "));
        Distance c = new Distance(a.inputInches + b.inputInches);

        Console.WriteLine($"'a' = {a.Display()},\n'b' = {b.Display()},\n'a + b' = {c.Display()}");
    }

    static int intCheck(string message)
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