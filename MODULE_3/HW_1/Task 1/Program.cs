using System;

namespace Task_1
{
    delegate int Cast(double a);
    class Program
    {
        static void Main(string[] args)
        {
            Cast cast = new Cast((a) => (int)Math.Round(a));
            Cast cast1 = new Cast((a) => (int)a);
            Console.WriteLine(cast(3.261));
            Console.WriteLine(cast1(3.261));
            Console.WriteLine(cast(1.5));
            Console.WriteLine(cast1(1.5));
            Console.WriteLine();
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                double a = rnd.NextDouble() + rnd.Next(1, 5);
                Console.WriteLine($"{a}\n{cast(a)}\n{cast1(a)}\n");
            }
        }
    }
}