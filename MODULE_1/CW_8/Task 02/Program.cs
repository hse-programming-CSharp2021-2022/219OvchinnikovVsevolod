using System;
using System.Security.Cryptography;

namespace Task_01
{
    class Program
    {
        static (int[], double[]) SplitArray(double[] array)
        {
            int[] resultInt = new int[array.Length];
            double[] resultDouble = new double[array.Length];
            for(int i = 0; i < array.Length; i ++)
            {
                int tempInt = (int) array[i];
                double tempDouble = array[i] - tempInt;
                resultInt[i] = tempInt;
                resultDouble[i] = tempDouble;
            }
            return (resultInt, resultDouble);
        }

        static double[] GenerateArray(int length)
        {
            double[] result = new double[length];
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                result[i] = rnd.NextDouble() + rnd.Next(0, 100);
            }

            return result;
        }
        static void Main(string[] args)
        {
            int arrayLength = int.Parse(Console.ReadLine());
            double[] resultArray = GenerateArray(arrayLength);
            Array.ForEach(resultArray, el => Console.Write($"{el} "));
            Console.WriteLine();
            double[] splitArrayDouble = new double[0];
            int[] splitArrayInt = new int[0];
            (splitArrayInt, splitArrayDouble) = SplitArray(resultArray);
            Array.Sort(splitArrayInt);
            Array.ForEach(splitArrayInt, el => Console.Write($"{el} "));
            Console.WriteLine();
            Array.Sort(splitArrayDouble);
            Array.ForEach(splitArrayDouble, el => Console.Write($"{el} "));
            Console.WriteLine();
        }
    }
}