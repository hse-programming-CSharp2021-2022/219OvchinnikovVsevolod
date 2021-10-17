using System;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int minN = m < n ? m : n;
            int maxN = m < n ? n : m;
            int t = 1;
            for (int i = 0; i <= maxN; i += 1)
            {
                Console.WriteLine(t);
                if (minN == i)
                {
                    m = t;
                }

                if (maxN == i)
                {
                    n = t;
                }
                t += t;
            }
            Console.WriteLine($"{m + n}");
        }
    }
}