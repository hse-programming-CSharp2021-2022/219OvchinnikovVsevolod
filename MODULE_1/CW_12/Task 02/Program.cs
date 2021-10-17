using System;
using System.Linq;

namespace Task_02
{
    class Program
    {
        static int[] GenerateArray(int n = 0)
        {
            Random rnd = new Random();
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = rnd.Next(1, 10001);
            }

            return result;
        }

        static string ReverseString(string str)
        {
            string result = "";
            foreach (var item in str)
            {
                result = item + result;
            }

            return result;
        }

        static void PrintArray(Array array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            int[] array = GenerateArray(n);
            Console.WriteLine("0");
            PrintArray(array);
            Console.WriteLine("1");
            PrintArray(
                array.Where(
                    t => (t < 100) && (t >= 10) && (t % 3 == 0)
                ).ToArray()
            );
            Console.WriteLine("2");
            PrintArray(
                array.Where(
                    t => ReverseString(t.ToString()) == t.ToString()
                ).ToArray()
            );
            Console.WriteLine("3");
            PrintArray(
                array.OrderBy(
                    DigitsSum
                ).ThenBy(
                    t => t
                ).ToArray()
            );
            Console.WriteLine("4");
            Console.WriteLine(
                array.Where(
                    t => (t > 999) && (t < 10000)
                ).Sum()
            );
            Console.WriteLine("5");
            Console.WriteLine(
                array.Where(
                    t => (t > 9) && (t < 100)
                ).DefaultIfEmpty().Min()
            );
            Console.WriteLine("6");
            foreach (var item in array)
            {
                Console.Write($"{GetMaxDigit(item)} ");
            }
        }

        private static int DigitsSum(int arg)
        {
            int sum = 0;
            while (arg > 0)
            {
                sum += arg % 10;
                arg /= 10;
            }

            return sum;
        }

        private static int GetMaxDigit(int arg)
        {
            int max = -1;
            while (arg > 0)
            {
                int t = arg % 10;
                if (t > max)
                {
                    max = t;
                }

                arg /= 10;
            }

            return max;
        }
    }
}