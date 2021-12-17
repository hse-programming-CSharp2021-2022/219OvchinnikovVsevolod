using System;
using System.Collections.Generic;

namespace Task_1
{
    class Shape
    {
        public virtual double Area() => 0;
    }

    class Circle : Shape
    {
        private double R { get; set; }

        public Circle(double r)
        {
            R = r;
        }

        public override double Area() => 2 * Math.PI * R;

        public override string ToString() => $"Square {this.Area()}";
    }

    class Cylinder : Shape
    {
        private double R { get; set; }
        private double H { get; set; }

        public Cylinder(double r, double h)
        {
            R = r;
            H = h;
        }

        public override double Area() => Math.PI * R * R * 2 + 2 * Math.PI * R * H;

        public override string ToString() => $"Square {this.Area()}";
    }

    class Sphere : Shape
    {
        private double R { get; set; }

        public Sphere(double r)
        {
            R = r;
        }

        public override double Area() => 4 * R * Math.PI * R;
        public override string ToString() => $"Square {this.Area()}";
    }

    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var n1 = r.Next(3, 6);
            var n2 = r.Next(3, 6);
            var n3 = r.Next(3, 6);
            var shapes = new List<Shape>();
            for (var i = 0; i < n1; i++)
                shapes.Add(new Circle(r.Next(20)));
            for (var i = 0; i < n2; i++)
                shapes.Add(new Cylinder(r.Next(20), r.Next(20)));
            for (var i = 0; i < n3; i++)
                shapes.Add(new Sphere(r.Next(20)));
            foreach (Shape shape in shapes)
            {
                if (shape is Circle)
                    Console.WriteLine($"Circle {shape}");
                if (shape is Cylinder)
                    Console.WriteLine($"Cylinder {shape}");
                if (shape is Sphere)
                    Console.WriteLine($"Sphere {shape}");
            }
        }
    }
}