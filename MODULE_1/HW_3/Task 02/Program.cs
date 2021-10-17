using System;

namespace Task_02
{
    class Program
    {
        static double G(double x, double y)
        {
            if (x < y && x > 0)
                return x + Math.Sin(y);
            if (x > y & x < 0)
                return y - Math.Cos(x);
            return 0.5 * x * y;
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo runKey;
            bool run = false;
            double x, y;
            do
            {
                do
                {
                    Console.Write("Введите x: ");
                    run = double.TryParse(Console.ReadLine(), out x);
                } while (!run);

                run = false;
                do
                {
                    Console.Write("Введите y: ");
                    run = double.TryParse(Console.ReadLine(), out y);
                } while (!run);

                Console.WriteLine(G(x, y));
                Console.WriteLine("Нажмите ESC, чтобы выйти");
                runKey = Console.ReadKey();
            } while (runKey.Key != ConsoleKey.Escape);
        }
    }
}