using System;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, c = 0;
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out a))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Bad input");
                }
            }
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out b))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Bad input");
                }
            }
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out c))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Bad input");
                }
            }
            double d = b * b - 4.0 * a * c;
            Console.WriteLine(
                d < 0 ? $"Нет корней" : (d == 0.0 ? $"{-b / (2.0 * a)}" : $"{(-b + Math.Sqrt(d)) / (2.0 * a)} {(-b - Math.Sqrt(d)) / (2.0 * a)}")
            );
        }
    }
}