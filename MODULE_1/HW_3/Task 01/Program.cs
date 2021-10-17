using System;

namespace HW_3
{
    class Program
    {
        static bool InsideG(double x, double y, double r = 2)
        {
            if (x <= 0)
            {
                return x * x + y * y <= r * r;
            }

            double t = Math.Sqrt(r * r / 2.0);
            return x <= t && y >= x && (x * x + y * y)<= r * r;
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

                Console.WriteLine(InsideG(x, y) ? "Внутри G" : "Вне G");
                Console.WriteLine("Нажмите ESC, чтобы выйти");
                runKey = Console.ReadKey();
            } while (runKey.Key != ConsoleKey.Escape);
        }
    }
}