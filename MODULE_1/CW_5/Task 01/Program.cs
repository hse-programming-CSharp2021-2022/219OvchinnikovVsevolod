using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
            uint number2 = number;
            uint n0 = 0;
            uint n1 = 0;
            uint n2 = 0;
            uint n3 = 0;
            uint n4 = 0;
            uint n5 = 0;
            uint n6 = 0;
            uint n7 = 0;
            uint n8 = 0;
            uint n9 = 0;
            while (number > 0)
            {
                uint t = number % 10;
                if (t == 0)
                {
                    n0 += 1;
                }
                else if (t == 1)
                {
                    n1 += 1;
                }
                else if (t == 2)
                {
                    n2 += 1;
                }
                else if (t == 3)
                {
                    n3 += 1;
                }
                else if (t == 4)
                {
                    n4 += 1;
                }
                else if (t == 5)
                {
                    n5 += 1;
                }
                else if (t == 6)
                {
                    n6 += 1;
                }
                else if (t == 7)
                {
                    n7 += 1;
                }
                else if (t == 8)
                {
                    n8 += 1;
                }
                else if (t == 9)
                {
                    n9 += 1;
                }

                number /= 10;
            }

            while (n9 > 0)
            {
                Console.Write("9");
                n9 -= 1;
            }
            while (n8 > 0)
            {
                Console.Write("8");
                n8 -= 1;
            }
            while (n7 > 0)
            {
                Console.Write("7");
                n7 -= 1;
            }
            while (n6 > 0)
            {
                Console.Write("6");
                n6 -= 1;
            }
            while (n5 > 0)
            {
                Console.Write("5");
                n5 -= 1;
            }
            while (n4 > 0)
            {
                Console.Write("4");
                n4 -= 1;
            }
            while (n3 > 0)
            {
                Console.Write("3");
                n3 -= 1;
            }
            while (n2 > 0)
            {
                Console.Write("2");
                n2 -= 1;
            }
            while (n1 > 0)
            {
                Console.Write("1");
                n1 -= 1;
            }
            while (n0 > 0)
            {
                Console.Write("0");
                n0 -= 1;
            }
        }
    }
}