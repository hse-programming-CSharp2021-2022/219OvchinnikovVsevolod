using System;

namespace Task_1
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public Point() : this(0, 0) {}

        public double Ro => Math.Sqrt(this.X * this.X + this.Y * this.Y);
        public double Fi => Math.Atan(this.X / this.Y);

        public string PointData
        {
            get
            {
                string maket = "X = {0:F2}; Y = {1:F2}; Ro = {2:F2}; Fi = {3:F2} ";
                return string.Format(maket, this.X, this.Y, this.Ro, this.Fi);    
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(0, 1);
            Point B = new Point(2, 5);
            string[] line = Console.ReadLine().Split();
            double x, y;
            while (!double.TryParse(line[0], out x) || !double.TryParse(line[1], out y))
            {
                Console.WriteLine("WRONG FORMAT");
                line = Console.ReadLine().Split();
            }
            Point C = new Point(x, y);
            Console.WriteLine($"A ro = {A.Ro}");
            Console.WriteLine($"B ro = {B.Ro}");
            Console.WriteLine($"C ro = {C.Ro}");
        }
    }
}