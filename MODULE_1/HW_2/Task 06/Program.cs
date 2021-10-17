using System;
using System.Globalization;
using System.Text;

namespace Task_06
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            int p = 0;
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
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out p))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Bad input");
                }
            }
            x *= p / 100.0;
            decimal y = new decimal(x);
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(y.ToString("C", CultureInfo.CreateSpecificCulture("ru-RU")));
            Console.WriteLine(y.ToString("C", CultureInfo.CreateSpecificCulture("de-DE")));
            Console.WriteLine(y.ToString("C", CultureInfo.CreateSpecificCulture("us-US")));
        }
    }
}