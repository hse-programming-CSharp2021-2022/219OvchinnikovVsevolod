using System;

namespace Task_02
{
    class Program
    {
        static int[] ArrayGenerate(int n)
        {
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = 2 * i + 1;
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