using System;
namespace Shape
{
    abstract public class Shape
    {
        public string Name { get; set; }

        protected Shape(string name = "NoName")
        {
            Name = name;
        }

        public abstract double GetPerimeter();

        public abstract double GetSquare();

        public override string ToString() => $"{this.Name}";

        public virtual string Info() => $"NoInfo";
    }
}