using System;

namespace Task_03
{
    class Program
    {
        static int[] ArrayGenerate(int n, int a, int d)
        {
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = a + i * d;
            }
            return array;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int[] array = ArrayGenerate(n, a, d);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}