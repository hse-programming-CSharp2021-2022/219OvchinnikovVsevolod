using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic result = "5 / 3 = " + 5 / 3;
            Console.WriteLine(result);
            result = "5.0 / 3.0 = " + 5.0 / 3.0;
            Console.WriteLine(result);
            result = 5 / 3;
            Console.WriteLine(result);
            result = 5/3 + " - это 5 / 3";
            Console.WriteLine(result);
        }
    }
}