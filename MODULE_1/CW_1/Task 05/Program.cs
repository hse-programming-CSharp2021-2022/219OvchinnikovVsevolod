using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputA = Console.ReadLine();
            var inputB = Console.ReadLine();
            double numberA = 0;
            double numberB = 0;
            if (!double.TryParse(inputA, out numberA) || !double.TryParse(inputB, out numberB))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            if ((numberA * numberA + numberB * numberB <= 2.0) && (numberA * numberA + numberB * numberB >= 1.0))
            {
                Console.WriteLine("True");
                return;
            }
            Console.WriteLine("False");
        }
    }
}