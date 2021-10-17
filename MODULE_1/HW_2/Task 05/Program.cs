using System;

namespace Task_05
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
            Console.WriteLine((a + b > c) ? (a + c > b ? (b + c > a ? "OK" : "BAD") : "BAD") : "BAD");
        }
    }
}