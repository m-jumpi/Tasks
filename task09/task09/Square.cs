using System;
namespace Shape
{
    public class Square : Shape, IRotate
    {
        public double A { get; private set; }

        public Square(double a)
        {
            A = a;
        }

        public override double GetPerimeter() => 4 * A;

        public override double GetSquare()
        {
            return Math.Pow(A, 2);
        }

        public override string ToString() => $"Side 'a' = {A}";

        public string Rotate()
        {
            return $"{this.Name} has been rotated";
        }
    }
}