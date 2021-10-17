using System;

namespace Task_02
{
    class Program
    {
        private static double Function(double x, double a, double b, double c)
        {
            double y = 0;
            if (x < 1.2)
            {
                return x * (a * x + b) + c;
            }
            else if (Math.Abs(x - 1.2) < 0.000000000001)
            {
                return (a / x) + Math.Sqrt(x * x + 1);
            }
            else
            {
                return (a + b * x) / Math.Sqrt(x * x + 1);
            }
        }
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            for (double x = 1; x <= 2; x += 0.05)
            {
                Console.WriteLine($"f({x}) = {Function(x, a, b, c)}");
            }
        }
    }
}