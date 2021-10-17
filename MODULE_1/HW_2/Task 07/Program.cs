using System;

namespace Task_07
{
    class Program
    {
        private (int, double) SplitNumber(double number)
        {
            int fraction = (int) number;
            double remainder = number - fraction;
            return (fraction, remainder);
        }
        private (double, double) SquareRootNumber(double number)
        {
            double fraction = (int) number;
            double remainder = number - fraction;
            return (fraction, remainder);
        }
        static void Main(string[] args)
        {
            double x = 0;
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out x))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Bad input");
                }
            }
            Console.WriteLine("Hello World!");
        }
    }
}