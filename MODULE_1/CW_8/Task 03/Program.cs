using System;

namespace Task_03
{
    class Program
    {
        static int[,] GenerateArray(int length)
        {
            int[,] result = new int[length,length];
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                result[i,].Resize();
                result[i] = rnd.Next(0, 1001);
            }

            return result;
        }
        static int[][] MultiSort(int[][] )
        static void Main(string[] args)
        {
            
        }
    }
}