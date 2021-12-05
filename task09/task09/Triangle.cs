using System;
namespace Shape
{
    public class Triangle : Shape, IRotate
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public Triangle(double a, double b, double c, string name = "Triangle") : base(name)
        {
            A = a;
            B = b;
            C = c;
        }

        public Triangle(double a) : this(a, a, a) { }

        public override double GetPerimeter() => A + B + C;

        public override double GetSquare()
        {
            double p = GetPerimeter() / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public override string ToString() => $"Side 'a' = {A},\nSide 'b' = {B},\nSide 'c' = {C}";

        public override string Info()
        {
            return $"{base.ToString()}:\n{ToString()}\nPerimeter = {GetPerimeter()}\nSquare = {GetSquare():N2}\n";
        }

        public string Rotate()
        {
            return $"{this.Name} has been rotated";
        }
    }
}