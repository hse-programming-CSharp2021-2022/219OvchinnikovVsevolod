using System;

namespace Task_05
{
    class Program
    {
        static string GetDestination(double x, double y, double r = 10)
        {
            return x * x + y * y <= r * r ? "Точка внутри круга!" : "Точка вне круга!";
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

                Console.WriteLine(GetDestination(x, y));
                Console.WriteLine("Нажмите ESC, чтобы выйти");
                runKey = Console.ReadKey();
            } while (runKey.Key != ConsoleKey.Escape);
        }
    }
}