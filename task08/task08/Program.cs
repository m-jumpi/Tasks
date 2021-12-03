using System;

namespace Triangel
{
    class Program
    {
        public static void Main()
        {
            try
            {
                Triangel tr = new Triangel(4);
                double perimeter = tr.Perimeter();
                double square = tr.Square();
                Console.WriteLine(tr);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}