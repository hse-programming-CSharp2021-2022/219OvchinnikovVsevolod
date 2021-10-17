using System;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = 0;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out p))
                {
                    if (p >= 100 && p <= 999)
                        break;
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
            int t1 = p / 100;
            int t3 = p % 10;
            int t2 = (p - t3 - t1 * 100) / 10;
            int aMax = Math.Max(Math.Max(t1, t3), t2);
            int aMin = Math.Min(Math.Min(t1, t3), t2);
            int aMid = t1 + t2 + t3 - aMin - aMax;
            Console.WriteLine($"{aMax}{aMid}{aMin}");
        }
    }
}