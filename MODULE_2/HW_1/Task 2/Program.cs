using System;

namespace Task_2
{
    class Polygon
    {
        public int Sides { get; set;}
        public double Radius { get; set;}

        public Polygon(int sides, int radius)
        {
            this.Sides = sides;
            this.Radius = radius;
        }
        public Polygon() : this(0, 0) {}

        public double Perimeter => 2 * this.Sides * this.Radius * Math.Tan(Math.PI / this.Sides);
        public double Square => this.Sides * this.Radius * this.Radius * Math.Tan(Math.PI / this.Sides);
        public override string ToString()
        {
            string maket = "N = {0}; R = {1:F2}; P = {2:F2}; S = {3:F2} ";
            return string.Format(maket, this.Sides, this.Radius, this.Perimeter, this.Square);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Задание с опеределением ссылки на тип класса не понял(
            Polygon A = new Polygon(4, 2);
            Console.WriteLine(A);
        }
    }
}