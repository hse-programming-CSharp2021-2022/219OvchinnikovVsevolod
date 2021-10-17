using System;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int x);
            int.TryParse(Console.ReadLine(), out int y);
            int.TryParse(Console.ReadLine(), out int z);
            int aMin = x < y ? (z < x ? z : x) : (y < z ? y : z);
            int aMax = x > y ? (z > x ? z : x) : (y > z ? y : z);
            int aMid = x + y + z - aMin - aMax;
            x = aMin;
            y = aMid;
            z = aMax;
            Console.WriteLine($"{x} {y} {z}");
        }
    }
}