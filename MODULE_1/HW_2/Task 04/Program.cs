using System;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            if (int.TryParse(Console.ReadLine(), out int p))
            {
                if (p >= 1000 && p <= 9999)
                {
                    Console.WriteLine(
                        $"{p % 10}{(p / 10) % 10}{(p / 100) % 10}{p / 1000}"
                    );
                }
                else
                {
                    Console.WriteLine("BAD NUMBER");
                }
            }
            else
            {
                Console.WriteLine("BAD NUMBER");
            }
        }
    }
}