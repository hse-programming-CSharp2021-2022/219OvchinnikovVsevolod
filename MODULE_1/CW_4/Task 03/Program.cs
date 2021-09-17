using System;

namespace Task_06
{
    class Program
    {
        static double Function(double x)
        {
            return x * x;
        }

        static double Count(double y1, double y2, double delta)
        {
            return (y1 + y2) / 2.0 * delta;
        }
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double delta = double.Parse(Console.ReadLine());
            double current = 0;
            double square = 0;
            while (current <= a)
            {
                square += Count(Function(current), Function(current + delta), delta);
                current += delta;
            }
            square += Count(Function(current), Function(a), a - current); 
            Console.WriteLine(square);
        }
    }
}