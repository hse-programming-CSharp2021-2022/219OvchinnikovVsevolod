using System;

namespace Task_04
{
    class Program
    {
        static int Function(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else if (m > 0 && n == 0)
            {
                return Function(m - 1, 1);
            }
            else if (m > 0 && n > 0)
            {
                return Function(m - 1, Function(m, n - 1));
            }

            return 0;
        }

        static void Main(string[] args)
        {
            int numberM = int.Parse(Console.ReadLine());
            int numberN = int.Parse(Console.ReadLine());
            Console.WriteLine(Function(numberM, numberN));
        }
    }
}