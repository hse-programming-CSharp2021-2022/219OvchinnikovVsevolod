using System;

namespace Task_03
{
    class Program
    {
        public static void Function1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"i * i = {i * i}");
            }
        }

        public static void Function2()
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine($"i * i = {i * i}");
                i += 1;
            }
        }

        public static void Function3()
        {
            int i = 1;
            do
            {
                Console.WriteLine($"i * i = {i * i}");
                i += 1;
            } while (i <= 10);
        }

        static void Main(string[] args)
        {
            Function1();
            Function2();
            Function3();
        }
    }
}