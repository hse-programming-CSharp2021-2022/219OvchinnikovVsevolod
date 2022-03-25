using System;

namespace Task_1
{
    struct Point
    {
        public double x { get; }
        public double y { get; }

        public double RadiusVectorLength { get; }

        public Point(double _x = 0, double _y = 0)
        {
            x = _x;
            y = _y;
            RadiusVectorLength = Math.Sqrt(x * x + y * y);
        }

        public static double Distance(Point p1, Point p2) => p1.Distance(p2);
        public double Distance(Point p) => Math.Sqrt((x - p.x) * (x - p.x) + (y - p.y) * (y - p.y));
        public override string ToString() => $"{{{x}, {y}}}";
    }

    struct Circle : IComparable
    {
        public readonly Point center;
        double rad;

        public double Rad
        {
            get => rad;
        }

        public Circle(double x, double y, double radius)
        {
            center = new(x, y);
            rad = radius;
        }

        public override string ToString() => $"Circle: {center}, radius {rad}";

        public int CompareTo(object obj)
        {
            if (obj.GetType() != typeof(Circle)) return 1;
            Circle a = (Circle) obj;
            return a.center.RadiusVectorLength * a.Rad < center.RadiusVectorLength * Rad ? 1 : -1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            Random rnd = new();
            Circle[] circles = new Circle[n];
            for (int i = 0; i < n; i++)
                circles[i] = new(rnd.Next(-20, 21), rnd.Next(-20, 21), rnd.NextDouble() * 10);
            Array.Sort(
                circles,
                (a, b) => a.center.RadiusVectorLength * a.Rad > b.center.RadiusVectorLength * b.Rad ? 1 : -1
            );
            Array.Sort(circles);
            foreach (Circle c in circles)
                Console.WriteLine(c);
        }
    }
}