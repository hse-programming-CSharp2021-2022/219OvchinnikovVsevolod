using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine($"c = {Math.Sqrt((a*a) + (b*b))}");
        }
    }
}