using System;

namespace Task_06
{
    class Program
    {
        static int CountDivisors(int n)
        {
            int total = 1;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    total += 1;
                }
            }

            return total;
        }

        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            for (int i = 100; i < 1000; i++)
            {
                if (CountDivisors(i) == k)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}