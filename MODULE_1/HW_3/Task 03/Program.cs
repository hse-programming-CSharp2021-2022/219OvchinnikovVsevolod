using System;

namespace Task_03
{
    class Program
    {
        static double G(double x, double y)
        {
            return x <= 0.5 ? Math.Sin(0.5 * Math.PI) : Math.Sin(0.5 * ((x - 1) * Math.PI));
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