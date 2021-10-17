using System;
using System.Linq;

namespace Task_01
{
    class Program
    {
        public static void PrintArray(int[] array)
        {
            foreach (var element in array)
            {
                Console.Write($"{element} ");
            }
            Console.Write("\n");
        }
        public static int Sum(int[] mas)
        {
            int total = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                total += mas[i];
            }

            return total;
        }
        public static void GenerateArray(int[] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                bool run = true;
                while (run)
                {
                    var tmp = rnd.Next(1, 101);
                    if (!array.Contains(tmp))
                    {
                        array[i] = tmp;
                        run = false;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] mas = new int[100];
            GenerateArray(mas);
            PrintArray(mas);
            Console.WriteLine(Sum(mas));
            PrintArray(mas);
        }
    }
}
