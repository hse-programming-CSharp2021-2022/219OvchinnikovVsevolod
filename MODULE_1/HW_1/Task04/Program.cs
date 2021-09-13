using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            var U = double.Parse(Console.ReadLine());
            var R = double.Parse(Console.ReadLine());
            Console.WriteLine($"I = {U/R}");
            Console.WriteLine($"P = {U*U/R}");
        }
    }
}