using System;

namespace Task_04
{
    class Program
    {
        static string GetSymbolType(char symbol)
        {
            return (symbol >= '0' && symbol <= '9')
                ? "Это цифра!"
                : (((symbol >= 'a' && symbol <= 'z') || (symbol >= 'A' && symbol <= 'Z'))
                    ? "Это буква!"
                    : "Это ни буква, ни цифра!");
        }

        static void Main(string[] args)
        {
            ConsoleKeyInfo runKey;
            char symbol = 'a';
            bool run = false;
            do
            {
                do
                {
                    Console.Write("Введите символ: ");
                    run = char.TryParse(Console.ReadLine(), out symbol);
                } while (!run);

                Console.WriteLine(GetSymbolType(symbol));
                Console.WriteLine("Нажмите ESC, чтобы выйти");
                runKey = Console.ReadKey();
            } while (runKey.Key != ConsoleKey.Escape);
        }
    }
}