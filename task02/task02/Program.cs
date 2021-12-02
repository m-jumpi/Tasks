using System;

class Program
{
    public struct Distance
    {
        public int feet;
        public int inch;

        public Distance(int input)
        {
            feet = (int)input / 12;
            inch = (int)input % 12;
        }

        public override string ToString() => $"{feet}' - {inch}\"";

    }
    public static void Main()
    {
        Distance z;
        //z.feet = 100;
        //z.inch = 100;
        Console.WriteLine(z);

        Distance a = new Distance(IntCheck("Please enter value of distance 'a' in inches: "));
        Distance b = new Distance(IntCheck("Please enter value of distance 'b' in inches: "));
        Distance c = new Distance((a.feet * 12 + a.inch) + (b.feet * 12 + b.inch));

        Console.WriteLine($"'a' = {a},\n'b' = {b},\n'a + b' = {c}");

        int IntCheck(string message)
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