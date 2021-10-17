using System;

namespace Task_01
{
    class Program
    {
        static int[] ArrayGenerate(int n)
        {
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = (int)Math.Pow(2, i);
            }

            return array;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = ArrayGenerate(n);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}