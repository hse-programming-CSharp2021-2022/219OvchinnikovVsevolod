using System;

namespace Task_01
{
    class Program
    {
        public static void Sums(uint number, out uint even, out uint odd)
        {
            even = 0;
            odd = 0;
            while (number > 0)
            {
                odd += number % 10;
                number /= 10;
                even += number % 10;
                number /= 10;
            }
        }
        static void Main(string[] args)
        {
            uint n, even, odd;
            n = uint.Parse(Console.ReadLine());
            Sums(n, out even, out odd);
            Console.WriteLine($"{odd} {even}");
        }
    }
}