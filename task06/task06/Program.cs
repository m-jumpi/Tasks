using System;

namespace Triangel
{
    class Program
    {
        public static void Main()
        {
            try
            {
                Triangel tr = new Triangel();
                tr.Populate(4, 2, 5);
                double perimeter = tr.Perimeter();
                double square = tr.Square();
                Console.WriteLine(tr);
                Console.WriteLine($"Square = {square:N2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}