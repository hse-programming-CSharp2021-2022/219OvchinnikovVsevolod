using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write down your name:");
            var data = Console.ReadLine().Split(" ");
            Console.WriteLine($"Hello, {data[1]} {data[0]}");
        }
    }
}