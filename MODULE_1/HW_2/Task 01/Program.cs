using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out x))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("BAD NUMBER");
                }
            }
            double result = x * (x * (x * (x * 12 + 9) - 3) + 2) - 4;
            Console.WriteLine(result);
        }
    }
}