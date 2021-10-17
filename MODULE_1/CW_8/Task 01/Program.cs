using System;
using System.Security.Cryptography;

namespace Task_01
{
    class Program
    {
        static int CountDigitsSum(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }

            return sum;
        }
        static int CountDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += 1;
                n /= 10;
            }

            return sum;
        }
        static int EvenComparator(int n, int m)
        {
            
            return n % 2 == 0 ? (m % 2 == 0 ? -1 : 1) : (m % 2 == 0 ? 1 : -1);
        }
        static int CountComparatpr(int n, int m)
        {

            return CountDigits(n) > CountDigits(m) ? 1 : -1;
        }
        static int SumComparator(int n, int m)
        {
            
            return CountDigitsSum(n) > CountDigitsSum(m) ? 1 : -1;
        }

        static int[] GenerateArray(int length)
        {
            int[] result = new int[length];
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                result[i] = rnd.Next(0, 1001);
            }

            return result;
        }
        static void Main(string[] args)
        {
            int arrayLength = int.Parse(Console.ReadLine());
            int[] resultArray = GenerateArray(arrayLength);
            Array.ForEach(resultArray, el => Console.Write($"{el} "));
            Console.WriteLine();
            Array.Sort(resultArray, EvenComparator);
            Array.ForEach(resultArray, el => Console.Write($"{el} "));
            Console.WriteLine();
            Array.Sort(resultArray, CountComparatpr);
            Array.ForEach(resultArray, el => Console.Write($"{el} "));
            Console.WriteLine();
            Array.Sort(resultArray, SumComparator);
            Array.ForEach(resultArray, el => Console.Write($"{el} "));
            Console.WriteLine();
            
        }
    }
}
