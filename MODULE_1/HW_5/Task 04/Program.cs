using System;

namespace Task_04
{
    class Program
    {
        static int[] ArrayGenerate(int n)
        {
            int[] array = new int[n];
            array[0] = 1;
            array[1] = 1;
            for (int i = 2; i < n; i++)
            {
                array[i] = array[i - 2] + array[i - 1];
            }

            return array;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = ArrayGenerate(n);
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}