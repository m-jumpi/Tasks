using System;
namespace Shape
{
    public class Circle : Shape
    {
        public double R { get; private set; }

        public Circle(double r, string name = "Circle") : base(name)
        {
            R = r;
        }

        public override double GetPerimeter() => 2 * Math.PI * R;

        public override double GetSquare()
        {
            return Math.PI * Math.Pow(R, 2);
        }

        public override string ToString() => $"Radius 'r' = {R}";

        public override string Info()
        {
            return $"{base.ToString()}:\n{ToString()}\n";
        }
    }
}