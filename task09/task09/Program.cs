using System;

namespace Shape
{
    class Program
    {
        public static void Main()
        {
            Triangle tr = new Triangle(3, 3, 4);
            Console.WriteLine(tr.Info());
            Console.WriteLine(tr.Rotate());

            Circle cr = new Circle(3);
            Console.WriteLine(cr.Info());

            Square sq = new Square(4);
            Console.WriteLine(sq);
            Console.WriteLine(sq.Info());
            Console.WriteLine(sq.Rotate());
        }
    }
}