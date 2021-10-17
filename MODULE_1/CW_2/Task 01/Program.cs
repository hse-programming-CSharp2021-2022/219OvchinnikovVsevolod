using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            while (n > 0)
            {
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    double b = (1 + Math.Sqrt(5)) / 2.0;
                    double u = (Math.Pow(b, n) - (-Math.Pow(b, -n))) / (2.0 * b - 1.0);
                    Console.WriteLine($"u={u}");
                }
                else
                {
                    continue;
                }
            }
        }
    }
}