using System;

namespace Task_06
{
    class Program
    {
        static double RecursiveTotal(double k, double r, uint n)
        {
            if (n == 1)
            {
                return k * (1.0 + r);
            }
            else
            {
                return RecursiveTotal(k * (1.0 + r), r, n - 1);
            }
        }

        static double NonRecursiveTotal(double k, double r, uint n)
        {
            for (int i = 0; i < n; i++)
            {
                k *= 1.0 + r;
            }

            return k;
        }
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double k = double.Parse(Console.ReadLine());
            uint n = uint.Parse(Console.ReadLine());
            Console.WriteLine(RecursiveTotal(k, r , n));
            Console.WriteLine(NonRecursiveTotal(k, r , n));
        }
    }
}